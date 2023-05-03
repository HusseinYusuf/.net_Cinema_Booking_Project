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
    public partial class Receipt : Form
    {
        OleDbCommand cmd;
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Database4.accdb");
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database4DataSet4.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.database4DataSet4.Booking);
            // TODO: This line of code loads data into the 'database4DataSet3.reservation' table. You can move, or remove it, as needed.
            label1.Text = MovieSection.passingTitle;
            cmd = new OleDbCommand("select *from Booking", Aconnection);
            Aconnection.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text = (read["fName"].ToString());
                textBox2.Text = (read["lName"].ToString());
                textBox3.Text = (read["phone"].ToString());
                textBox4.Text = (read["seat"].ToString());

            }
            read.Close();
            
            Aconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Receipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sagot = MessageBox.Show("Thank you for trusting or Cinema Booking System", "EXIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (sagot.ToString() == "Okay")
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieSection ss = new MovieSection();
            ss.Show();
        }
    }
}
