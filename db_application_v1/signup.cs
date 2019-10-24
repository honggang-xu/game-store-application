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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_SU_cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button_SU_create_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(dr.GetString(1));
            label_SU_message.Text = "";

            if (textBox_SU_username.Text == "" || textBox_SU_username.Text == " ")
            {

                label_SU_message.Text = "Please enter a valid username and password";
                //listBox_results.Items.Clear();
                return;
            }

            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from PROJECT_CUSTOMER_REAL where username='" + textBox_SU_username.Text + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    if (textBox_SU_username.Text == dr.GetString(0))
                    {
                        //Console.WriteLine("Checking");
                        label_SU_message.Text = "The username is already taken.";

                    }

                    
                }
                else if (textBox_reenterPass.Text != textBox_SU_password.Text)
                {
                    label_SU_message.Text = "Passwords do no match";
                    textBox_SU_password.Text = "";
                    textBox_reenterPass.Text = "";
                }
                else if (textBox_SU_username.Text == "" || textBox_SU_password.Text == "" || textBox_reenterPass.Text =="" || textBox_SU_fname.Text == "" || textBox_SU_lname.Text == ""
                    || textBox_SU_email.Text == "" || textBox_SU_country.Text == "" || textBox_SU_city.Text == "" || textBox_SU_address.Text == "")
                {
                    label_SU_message.Text = "Please fill in all text fields";
                }
                else
                {
                    //Console.WriteLine("else");

                    //insert into the database username and password
                    cmd.CommandText = "insert into project_customer_real values ('" + textBox_SU_username.Text + "','" +
                    textBox_SU_password.Text + "','" + textBox_SU_fname.Text + "','" + textBox_SU_lname.Text + "','" + textBox_SU_email.Text + "','" +
                    textBox_SU_country.Text + "','" + textBox_SU_city.Text + "','" + textBox_SU_address.Text + "',CARD_ID_SEQ.nextval)";


                    Console.WriteLine(cmd.CommandText); //check the query in the database

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    //insert to the card table
                    cmd.CommandText = "insert into project_card (cardid) values (CARD_ID_SEQ.currval)";
                    Console.WriteLine(cmd.CommandText); //check the query in the database
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    label_SU_message.Text = "Sign-up successful!";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }
    }
}
