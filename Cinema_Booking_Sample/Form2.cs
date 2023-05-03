using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Sample
{
    public partial class Form2 : Form
    {
        public static string title;
        public static string numberoftickets;
        public static string price;
        public int amount;
        public Form2(string MovieName)
        {
            InitializeComponent();
            Title.Text = MovieName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Description.Text = MovieSection.passingText;
            Title.Text = MovieSection.passingTitle;
            dateTimePicker1.Text = MovieSection.passingDate.ToString(); 
            if (Title.Text == "Avatar: The Way of Water")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.avatar1;

            if (Title.Text == "The Menu")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.the_menu;

            if (Title.Text == "IT")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.it1;

            if (Title.Text == "TITANIC")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.titanic;

            if (Title.Text == "Fast & Furious")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.fast_furious1;

            if (Title.Text == "Aquaman")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.aquaman;

            if (Title.Text == "Akeela & The Bee")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.akeela;

            if (Title.Text == "Final Destination")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.Final_Destination;

            if (Title.Text == "Captain Marvel")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.captain_marvel;

            if (Title.Text == "Nomadland")
                pictureBox2.Image = Cinema_Booking_Sample.Properties.Resources.nomadland;

            pictureBox2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (comboBox1.SelectedItem.ToString() == "0")
                label5.Text = comboBox1.Text = "amount";

            else if (comboBox1.SelectedItem.ToString() == "1")
                label5.Text = comboBox1.Text = "100";

            else if (comboBox1.SelectedItem.ToString() == "2")
                label5.Text = comboBox1.Text = "200";

            else if (comboBox1.SelectedItem.ToString() == "3")
                label5.Text = comboBox1.Text = "300";

            else if (comboBox1.SelectedItem.ToString() == "4")
                label5.Text = comboBox1.Text = "400";

            else if (comboBox1.SelectedItem.ToString() == "5")
                label5.Text = comboBox1.Text = "500";

            else if (comboBox1.SelectedItem.ToString() == "6")
                label5.Text = comboBox1.Text = "600";

            else if (comboBox1.SelectedItem.ToString() == "7")
                label5.Text = comboBox1.Text = "700";

            else if (comboBox1.SelectedItem.ToString() == "8")
                label5.Text = comboBox1.Text = "800";

            else if (comboBox1.SelectedItem.ToString() == "9")
                label5.Text = comboBox1.Text = "900";

            else if (comboBox1.SelectedItem.ToString() == "10")
                label5.Text = comboBox1.Text = "1000";

            else if (comboBox1.SelectedItem.ToString() == "11")
                label5.Text = comboBox1.Text = "1,100";

            else if (comboBox1.SelectedItem.ToString() == "11")
                label5.Text = comboBox1.Text = "1,100";

            else if (comboBox1.SelectedItem.ToString() == "12")
                label5.Text = comboBox1.Text = "1,200";

            else if (comboBox1.SelectedItem.ToString() == "13")
                label5.Text = comboBox1.Text = "1,300";

           else if (comboBox1.SelectedItem.ToString() == "14")
                label5.Text = comboBox1.Text = "1,400";

            else if (comboBox1.SelectedItem.ToString() == "15")
                label5.Text = comboBox1.Text = "1,500";

            else if (comboBox1.SelectedItem.ToString() == "16")
                label5.Text = comboBox1.Text = "1,600";

            else if (comboBox1.SelectedItem.ToString() == "17")
                label5.Text = comboBox1.Text = "1,700";

            else if (comboBox1.SelectedItem.ToString() == "18")
                label5.Text = comboBox1.Text = "1,800";

            else if (comboBox1.SelectedItem.ToString() == "19")
                label5.Text = comboBox1.Text = "1,900";*/
             amount = Convert.ToInt32(comboBox1.ToString()) * 100;
             label5.Text = amount.ToString();
             price = label5.Text;






        }

        private void button3_Click(object sender, EventArgs e)
        {
            title = Title.Text;
            numberoftickets = comboBox1.Text;
            
            this.Hide();
            login ss = new login();
            //Title.Text, Convert.ToInt32(comboBox1.Text), Convert.ToInt32(label5.Text)
            ss.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieSection bck = new MovieSection();
            bck.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
