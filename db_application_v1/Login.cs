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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            label_signinMess.Text = "Enter Username and Password then press 'Enter'";
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //label_signinMess.Text = "Logging in";
            

            string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "select department_name from departments where department_id = 10";
            //cmd.CommandText = "select * from all_tables where owner = 'COMPX323_15'";
            cmd.CommandText = "select * from PROJECT_CUSTOMER_REAL";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //textBox_input.Text = dr.GetString(0);

            while (dr.Read())
            {
                label_signinMess.Text = "Loggin in, please wait.";
                //Console.WriteLine(dr.GetString(1));
                if (textBox_username.Text == dr.GetString(0) && textBox_password.Text == dr.GetString(1))
                {
                    Hide();
                    Form1 form1 = new Form1(textBox_username.Text);
                    form1.ShowDialog();
                    form1 = null;
                    Show();

                    label_signinMess.Text = "Enter Username and Password then press 'Enter'";
                    textBox_password.Text = "";
                    //Console.WriteLine("End of dr.read");

                }
                else if(textBox_username.Text != dr.GetString(0) || textBox_password.Text != dr.GetString(1))
                {
                    label_signinMess.Text = "Your Username or Password was incorrect.";
                    //textBox_password.Text = "";
                }
                else
                {
                    label_signinMess.Text = "Enter Username and Password then press 'Enter'";
                }
                //Console.WriteLine(dr);
            }


            conn.Dispose();


            //if (textBox_username)
            //Hide();
            //Form1 form1 = new Form1();
            //form1.ShowDialog();
            //form1 = null;
            //Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(DateTime.Now.ToString("yyyy/mm/dd"));
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            //Hide();
            signup signup = new signup();
            signup.ShowDialog();
            signup = null;
            Show();
        }
    }
}
