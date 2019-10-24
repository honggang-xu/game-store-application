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
    public partial class accountDetails : Form
    {
        public accountDetails(String user)
        {
            InitializeComponent();

            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from PROJECT_CUSTOMER_REAL where username='" + user + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //label_totalPrice.Text = dr.GetString(2);

                //while (dr.Read())
                //{
                //    label_customerName.Text = dr.GetString(2) + " " + dr.GetString(3);
                //    //Console.WriteLine(dr.GetString(2));
                //}
                while (dr.Read())
                {
                    textBox_AD_username.Text = dr.GetString(0);
                    textBox_AD_fname.Text = dr.GetString(2);
                    textBox_AD_lname.Text = dr.GetString(3);
                    textBox_AD_email.Text = dr.GetString(4);
                    textBox_AD_Country.Text = dr.GetString(5);
                    textBox_AD_city.Text = dr.GetString(6);
                    textBox_AD_street.Text = dr.GetString(7);
                    textBox_AD_cardid.Text = dr.GetString(8);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void accountDetails_Load(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
