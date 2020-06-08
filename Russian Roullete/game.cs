using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        // class called and random number created
        russian russian = new russian();
        Random spinrandom = new Random();
        // added sound and location of sound
        SoundPlayer sound= new SoundPlayer(Russian_Roullete.Properties.Resources.gun);
        private void loadbtn_Click(object sender, EventArgs e)
        {
          

            russian.bulleteload = 1;
            spin.Enabled = true;
            load.Enabled = false;

            MessageBox.Show("Bullet load");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // display message for rematch 
            MessageBox.Show("Re-match");
            // to reopen the game from start
            (new game()).Show();
            this.Hide();
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {
           
            russian.loadchamber = spinrandom.Next(1, 6);
           
            shoot.Enabled = true;
            
            spin.Enabled = false;

            // message after clicking the spin button
            MessageBox.Show("Spinned");
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            

            int win = 0;
            win = russian.Shoot();

            if (win==1)
            {
                // sound to play
                // mesage to be displayed when you got shoot
                sound.Play();
                MessageBox.Show("You loose");

                load.Enabled = false;
                shoot.Enabled = false;
                spin.Enabled = false;
                




            }
            else if (win==2)
            {
                
                // message when bullet missed
                MessageBox.Show("Bullet Missed");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // for exit
            Close();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }
    }
    }

