using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;




namespace Cinema_Booking_Sample
{
    public partial class Main : Form
    {
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Database4.accdb");
        public static string rname;
        public static string remail;
        public static string rphone;
     

        public Main()
        {
           
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aconnection.Open();
            if (textName.Text != string.Empty || textSurname.Text != string.Empty || textEmail.Text != string.Empty || textPassw.Text != string.Empty || textConfirm.Text != string.Empty || textPhone.Text != string.Empty)
            {
                if (textPassw.Text == textConfirm.Text)
                {
                    OleDbCommand cmd = new OleDbCommand("select * from register where fname='" + textName.Text + "'", Aconnection);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new OleDbCommand("insert into register values(@fname,@lname, @email, @phone, @password, @confirmp)", Aconnection);
                        cmd.Parameters.AddWithValue("fname", textName.Text);
                        cmd.Parameters.AddWithValue("lname", textSurname.Text);
                        cmd.Parameters.AddWithValue("email", textEmail.Text);
                        cmd.Parameters.AddWithValue("phone", textPhone.Text);
                        cmd.Parameters.AddWithValue("password", textPassw.Text);
                        cmd.Parameters.AddWithValue("confirmp", textConfirm.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rname = textName.Text;
                        remail = textEmail.Text;
                        rphone = textPhone.Text;

                        this.Hide();
                        login ss = new login();
                        ss.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Aconnection.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sagot = MessageBox.Show("Do you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (sagot.ToString() == "No")
            {
                e.Cancel = true;
            }
        }

        private void selection()
        {
            if (textName.Text == ""){

                textName.Text = "";
            }

            if (textSurname.Text == "")
            {
                textSurname.Text = "";
            }

            if (textEmail.Text == "")
            {
                textEmail.Text = "";
            }

            if (textPassw.Text == "")
            {
                textPassw.Text = "";
            }

            if (textConfirm.Text == "")
            {
                textConfirm.Text = "";
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void textPassw_TextChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void textConfirm_TextChanged(object sender, EventArgs e)
        {
            selection();
        }
    }
}





 
