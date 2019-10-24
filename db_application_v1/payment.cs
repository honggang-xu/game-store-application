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
    public partial class payment : Form
    {
        public static string _paymentType;
        public payment()
        {
            InitializeComponent();
            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
            radioButton_customerCard.Checked = true;
            //radioButton_newCard.Checked = false;

            //makes items invisible
            //textBox_customerCard.Visible = false;
            //radioButton_customerCard.Visible = false;

            //textBox_newCard.Visible = false;
            //radioButton_newCard.Visible = false;

            //label_defaultCard.Visible = false;
            //label_newCard.Visible = false;

            //label_newCard.read
            

            try
            {

                textBox_OrderDetails.Text = "Customer name: " + Form1._fname + " " + Form1._lname + 
                    "\r\n" + "Game: " + view._gameTitle + "\r\n" + "Total Price: " + view._totalPrice;


                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                //gets the current value of ORDER_ID_SEQ
                cmd.CommandText = "select card_number from project_card where cardid="+ long.Parse(Form1._cardID);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                long cardNumber;
                while (dr.Read())
                {
                    Console.WriteLine("Current card id: " + dr.GetValue(0));
                    cardNumber = Convert.ToInt64(dr.GetValue(0));
                    Console.WriteLine("orderID variable = " + cardNumber);
                    //dr.Close();
                    textBox_customerCard.Text = cardNumber.ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void radioButton_customerCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_customerCard.Checked == true)
            {
                textBox_prepayVoucher.ReadOnly = true;
                textBox_newCard.ReadOnly = true;
                //this.Update();
            }
            else
            {
                textBox_prepayVoucher.ReadOnly = false;
                textBox_newCard.ReadOnly = false;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You are about to purchase a game, Do you want to continue?","Purchase game", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                //
            }
            else
            {
                //Purchase the game here
                Console.WriteLine("Clicked yes");
                //Console.WriteLine(view._totalPrice + view._productID);

                int orderID;
                long paymentID;

                try
                {
                    string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                    OracleConnection conn = new OracleConnection(oradb);  // C#
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;


                    //inserting into the PROJECT_ORDER table
                    cmd.CommandText = "insert into project_order values(ORDER_ID_SEQ.nextval" + ",'" + Form1._user + "'," + view._totalPrice + ", 'y', CURRENT_TIMESTAMP, PAYMENT_ID_SEQ.nextval)";
                    Console.WriteLine(cmd.CommandText); //check the query in the database
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    //gets the current value of ORDER_ID_SEQ
                    cmd.CommandText = "select ORDER_ID_SEQ.CURRVAL from dual";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine("Current ORDER_ID_SEQ: " + dr.GetValue(0));
                        orderID = Convert.ToInt32(dr.GetValue(0));
                        Console.WriteLine("orderID variable = " + orderID);
                        //dr.Close();

                    }

                    //gets the current value of ORDER_ID_SEQ
                    cmd.CommandText = "select PAYMENT_ID_SEQ.CURRVAL from dual";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr2 = cmd.ExecuteReader();


                    while (dr2.Read())
                    {
                        Console.WriteLine("Current PAYMENT_ID_SEQ: " + dr2.GetValue(0));
                        paymentID = Convert.ToInt64(dr2.GetValue(0));
                        Console.WriteLine("paymentID variable = " + paymentID);

                        //inserting into the PROJECT_Payment table
                        cmd.CommandText = "insert into project_payment values(" + paymentID + "," + "CURRENT_TIMESTAMP" + ",'" + Form1._cardID + "')";
                        Console.WriteLine(cmd.CommandText); //check the query in the database
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                    }

                    ////inserting into the PROJECT_Payment table
                    //cmd.CommandText = "insert into project_payment values(" + paymentID + "," + "CURRENT_TIMESTAMP" + ",'" + _paymentType + "','" + Form1._cardID + "')";
                    //Console.WriteLine(cmd.CommandText); //check the query in the database
                    //cmd.CommandType = CommandType.Text;
                    //cmd.ExecuteNonQuery();




                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Hide();
          }
        }

        private void radioButton_creditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_creditCard.Checked == true)
            {
                _paymentType = "Credit Card";
                Console.WriteLine(_paymentType);
            }
        }

        private void radioButton_debitCard_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_debitCard.Checked == true)
            {
                _paymentType = "Debit Card";
                Console.WriteLine(_paymentType);
            }
        }

        private void radioButton_newCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_newCard.Checked == true)
            {
                textBox_prepayVoucher.ReadOnly = true;
                textBox_newCard.ReadOnly = false;
                
                //this.Update();
            }
            
        }

        private void radioButton_prepayVoucher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_prepayVoucher.Checked == true)
            {
                textBox_prepayVoucher.ReadOnly = false;
                textBox_newCard.ReadOnly = true;
                radioButton_creditCard.Checked = false;
                radioButton_debitCard.Checked = false;

            }
        }

        private void radioButton_Choice_prepay_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Choice_prepay.Checked == true)
            {
                _paymentType = "Prepay Voucher";
                Console.WriteLine(_paymentType);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_15;Password=MXdH9mqcnr;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;


                //Update card
                cmd.CommandText = "update project_card set card_number = " + textBox_newCard.Text + ", card_type = '" + _paymentType + "' where cardid = " + long.Parse(Form1._cardID);
                Console.WriteLine(cmd.CommandText); //check the query in the database
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();


                cmd.CommandText = "select card_number from project_card where cardid=" + long.Parse(Form1._cardID);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                long cardNumber;
                while (dr.Read())
                {
                    Console.WriteLine("Current card id: " + dr.GetValue(0));
                    cardNumber = Convert.ToInt64(dr.GetValue(0));
                    Console.WriteLine("orderID variable = " + cardNumber);
                    //dr.Close();
                    textBox_customerCard.Text = cardNumber.ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
