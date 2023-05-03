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
  
    public partial class login : Form
    {
        string MovieName;
        int tickets;
        int amount;
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Database4.accdb");
        public login()
        {
            InitializeComponent();
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aconnection.Open();
            if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
            {
                OleDbCommand cmd = new OleDbCommand("select * from register where fname='" + textBox1.Text + "'", Aconnection);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Seats ss = new Seats();
                    ss.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Aconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }
    }
}
