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
    public partial class Reservation : Form
    {
        OleDbCommand cmd;
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Database4.accdb");
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select *from register", Aconnection);
            Aconnection.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text = (read["fname"].ToString());
                textBox4.Text = (read["lname"].ToString());
                textBox2.Text = (read["email"].ToString());
                textBox3.Text = (read["phone"].ToString());

            }
            read.Close();
            textBox5.Text = MovieSection.passingDate.ToString();
            Aconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            
            if (comCity.Text != string.Empty || comSeat.Text != string.Empty)
            {
                Aconnection.Open();

                cmd = new OleDbCommand("insert into Booking values(@fName, @lName, @email, @phone, @seat,@city, @reservationDate, @guest_Id)", Aconnection);
                
                cmd.Parameters.AddWithValue("fName", OleDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.AddWithValue("lName", OleDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.AddWithValue("email", OleDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.AddWithValue("phone", OleDbType.VarChar).Value = textBox3.Text;
                cmd.Parameters.AddWithValue("city", comCity.Text);
                cmd.Parameters.AddWithValue("seat", comCity.Text);
                cmd.Parameters.AddWithValue("reservationDate", OleDbType.VarChar).Value = textBox5.Text;
                cmd.Parameters.AddWithValue("guest_Id", textId.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Reservation is Successful . Thank You For Choosing Our Cinema.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
                Receipt ss = new Receipt();
                ss.Show();
            }





            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Aconnection.Close();
        }

    
    }
    
}
