using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cinema_Booking_Sample
{
    public partial class Seats : Form
    {
       
        public Seats()
        {
            InitializeComponent();
            label1.Text = Form2.title;
            textBox2.Text = Form2.price;
            textBox1.Text = Form2.numberoftickets;
            
        }

        private void Seats_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            B1.BackColor = Color.Red;
            this.Hide();
            Reservation ss = new Reservation();
            ss.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
