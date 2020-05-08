using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete_Jass
{
    public partial class Form1 : Form
    {
        int firing = 0;
        int firewying = 0;
        int bulletsss = 0;
        int shootssss = 0;
        public SimpleClass sc = new SimpleClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageArea.Image = RussianRoullete_Jass.Properties.Resources._11;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;

            imageArea.Image = RussianRoullete_Jass.Properties.Resources._22;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;

            imageArea.Image = RussianRoullete_Jass.Properties.Resources._33;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // method is used for shooting  
            firing++;
            shootssss++;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(RussianRoullete_Jass.Properties.Resources.Shot);
            player.Play();

            imageArea.Image = RussianRoullete_Jass.Properties.Resources._44;
            if (firing == 4)
            {
                MessageBox.Show("Wohh you survived");
                button5.Enabled = false;
                button4.Enabled = false;

                firing = 0;
            }
            else if (shootssss == bulletsss)
            {
                MessageBox.Show("About to Die");
                button4.Enabled = false;
                button5.Enabled = false;

                firing = 0;
            }
            else
            {
                MessageBox.Show("Next Time Try");
            }
        }
        private void frstchance()
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //method is used for shoot away
            firewying++;
            shootssss++;
            imageArea.Image = RussianRoullete_Jass.Properties.Resources._55;
            if (firewying == 2)
            {
                MessageBox.Show("About to die");
                button4.Enabled = false;
                button5.Enabled = false;

                firing = 0;
            }
            else if (shootssss == bulletsss)
            {
                MessageBox.Show("Wohh You Suvived");
                button4.Enabled = false;
                button5.Enabled = false;

                firing = 0;
            }
            else
            {
                MessageBox.Show("Next Time Try");
            }
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
        }
    }
}
