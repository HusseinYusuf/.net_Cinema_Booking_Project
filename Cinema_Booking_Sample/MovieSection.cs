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
    public partial class MovieSection : Form
    {
        public static string passingText;
        public static string passingTitle;
        public static DateTime passingDate;
        public MovieSection()
        {
            InitializeComponent();
        }

        private void MovieSection_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("Nomadland");
            passingTitle = "Nomadland";
            DateTime thisDate = new DateTime(2023, 3, 15);
            passingDate = thisDate;
            passingText = "A female in her sixties start a journey via the Western USA after shedding everything in the Great Recession, living as a van-dwelling modern wanderer";
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("Avatar: The Way of Water");
            passingTitle = "Avatar: The Way of Water";
            DateTime thisDate = new DateTime(2023, 1, 04);
            passingDate = thisDate;
            passingText ="Set more than a decade after the events of the first film, learn the story of the Sully family(Jake, Neytiri, and their kids), the trouble that follows them, the lengths they go to keep each other safe, the battles they fight to stay alive, and the tragedies they endure.";
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("The Menu");
            passingTitle = "The Menu";
            DateTime thisDate = new DateTime(2023, 1, 05);
            passingDate = thisDate;
            passingText = "A couple travels to a coastal island to eat at an exclusive restaurant where the chef has prepared a lavish menu, with some shocking surprises.";
            ss.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("IT");
            passingTitle = "IT";
            DateTime thisDate = new DateTime(2023, 1, 06);
            passingDate = thisDate;
            passingText = "In a small town in Maine, seven kids known as The Losers Club come facess. face with life problems, bullies and a creature which takes the shape of a clown.";
            ss.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("TITANIC");
            passingTitle = "TITANI]";
            DateTime thisDate = new DateTime(2023, 1, 07);
            passingDate = thisDate;
            passingText = "Rose DeWitt Bukater informs the narrative of her own life aboard the Titanic, 8-4 years later. A young Rose boards the boat with fiancé and her mother. Meanwhile, the Jack Dawson and Fabrizio De Rossi win tickets aboard the boat. Rose informs the story from the departure of Titanic to its death--on its first and last voyage--on April 15, 1912.";
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("Fast & Furious");
            passingTitle = "Fast & Furious";
            DateTime thisDate = new DateTime(2023, 1, 08);
            passingDate = thisDate;
            passingText = "When a offense brings them back to L.A., fugitive ex-con Dom Toretto re-ignites his feud with agent Brian O'Conner. However, since they're made to face a enemy, both Dom and Brian must devote to a unclear trust if they hope to out maneuver him. And the two men will get the ideal method to get revenge: push the constraints of what's possible behind this wheel.|";
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("Aquaman");
            passingTitle = "Aquaman";
            DateTime thisDate = new DateTime(2023, 1, 10);
            passingDate = thisDate;
            passingText = "Once home to one of probably the most advanced civilization on the planet, Atlantis is an underwater realm ruled by the power-hungry King Orm. With a huge army at his disposal, Orm plans to conquer the oceanic then and persons your surface world. Standing in his way is Arthur Curry, the half-human brother and true heir to the throne of Orm.";
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("Akeela & The Bee");
            passingTitle = "Akeela ^The Bee";
            DateTime thisDate = new DateTime(2023, 1, 14);
            passingDate = thisDate;
            passingText = "Eleven year-old Akeelah Anderson's lifetime isn't easy her mom blows off herbrother runs with the local gangbangers. She's smart, but her environment threatens to encircle her dreams. Responding to a threat with the main of her school, Akeelah participates in a spelling bee to prevent detention due to her most absences. Much to her embarrassment and surprise, she wins. Her principal asks her to seek coaching from an English professor called Dr. Larabee for the prestigious regional bee. Akeelah might provide someone to her community to rally round and be proud of -- but only when she could overcome her insecurities and her homelife that is distracting as of making everything the way to the Scripps National Spelling Bee, the possibility looms. She also must acquire beyond Dr. Larabee's demons, and a field of experienced and privileged fellow spellers";
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("Final Destination");
            passingTitle = "Final Destination";
            DateTime thisDate = new DateTime(2023, 1, 25);
            passingDate = thisDate;
            passingText = "He prevents the accident to possess Death hunt them down, one by one after a teenager using a chilling vision of him along with his friends dying in a plane accident.";
            ss.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2("Captain Marvel");
            passingTitle = "Captain Marvel";
            DateTime thisDate = new DateTime(2023, 2, 01);
            passingDate = thisDate;
            passingText = "Carol Danvers because she becomes one of the most powerful heroes of the universe when Earth is caught in the midst of a war between two alien races is followed by the narrative. Set in the 1990s,'' Captain Marvel is a all-new adventure from a formerly unseen period from the Marvel Cinematic Universe's history.";
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
