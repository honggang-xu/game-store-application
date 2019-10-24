using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Oracle.ManagedDataAccess.Client;

namespace db_application_v1
{
    public partial class Form1 : Form
    {

        public static string _user;
        public static string _fname;
        public static string _lname;
        public static string _cardID;

        public Form1(String username)
        {
            InitializeComponent();

            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from PROJECT_CUSTOMER_REAL where username='" + username + "'"; //Query to get details of customer
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //label_totalPrice.Text = dr.GetString(2);

                while (dr.Read())
                {
                    label_customerName.Text = dr.GetString(2) + " " + dr.GetString(3); //sets label as customers first and last anme
                    _fname = dr.GetString(2); //sets the firstname global variable
                    _lname = dr.GetString(3); //sets the lastname global variable
                    _cardID = dr.GetString(8);
                    //Console.WriteLine(dr.GetString(2));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            label1.Text = "";
            
            _user = username; //global variable for username
            //_cardID = "12";


        }

        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //cmd.CommandText = "select department_name from departments where department_id = 10";
                //cmd.CommandText = "select * from all_tables where owner = 'COMPX323_15'";
                //cmd.CommandText = "select * from project_product";

                //Query to find title

                if (textBox_input.Text == "" || textBox_input.Text == " ")
                {
                    label1.Text = "Please search for an item";
                    listBox_results.Items.Clear();
                }
                else
                {
                    //queries the database for the title of a game
                    cmd.CommandText = "Select * from project_product " +
                        "where lower(title) like lower" + "('" + "%" + textBox_input.Text + "%" + "')" +
                        " or upper(title) like " + "'" + "%" + textBox_input.Text + "%" + "'";

                    Console.WriteLine(cmd.CommandText); //check the query in the database

                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();

                    //textBox_input.Text = dr.GetString(0);

                    //while (dr.Read())
                    //{
                    //    Console.WriteLine(dr.GetString((Convert.ToInt32(textBox_input.Text))));
                    //}

                    //List<List<string>> table = new List<List<string>>();
                    ArrayList query = new ArrayList();

                    while (dr.Read())
                    {
                        Console.WriteLine(dr.GetString(1));
                        //label1.Text = dr.GetString(1);
                        query.Add(dr.GetString(1));

                        //Console.WriteLine(dr.FieldCount);
                    }

                    label1.Text = ""; // reset label text
                    listBox_results.Items.Clear(); //reset listbox
                    foreach (String item in query)
                    {
                        //label1.Text = label1.Text + "\r\n" + item;
                        //label1.Text = item + "\r\n";
                        listBox_results.Items.Add(item);
                    }
                    if (textBox_input.Text == "" || textBox_input.Text == " ")
                    {
                        label1.Text = "No results found";
                        listBox_results.Items.Clear();
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_view_Click(object sender, EventArgs e)
        {
            
            view view = new view(listBox_results.SelectedItem.ToString());
            view.ShowDialog();
            view = null;
            Show();
            //Console.WriteLine(listBox_results.SelectedItem);
        }

        private void button_account_Click(object sender, EventArgs e)
        {
            accountDetails accountDetails = new accountDetails(_user);
            accountDetails.ShowDialog();
            accountDetails = null;
            Show();
        }
    }
}
