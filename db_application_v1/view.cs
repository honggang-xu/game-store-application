using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace db_application_v1
{
    public partial class view : Form
    {

        public static string _productID;
        public static string _totalPrice;
        public static string _gameTitle;

        public view(String item)
        {
            InitializeComponent();
            Console.WriteLine("view form: " + item);

            label_gameTitle.Text = item;
            label_totalPrice.Text = "";

            _gameTitle = item;
        }

        private void button_buy_Click(object sender, EventArgs e)
        {
            payment payment = new payment();
            payment.ShowDialog();
            payment = null;
            Show();
        }

        private void view_Load(object sender, EventArgs e)
        {
            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from PROJECT_Product where Title='" + label_gameTitle.Text + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //label_totalPrice.Text = dr.GetString(2);

                while(dr.Read())
                {

                    textBox_gameDesc.Text = dr.GetString(3);
                    label_totalPrice.Text = "$" + dr.GetValue(2).ToString();

                    _productID = dr.GetValue(0).ToString();
                    _totalPrice = dr.GetValue(2).ToString();

                    //Console.WriteLine(dr.GetString(2).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
