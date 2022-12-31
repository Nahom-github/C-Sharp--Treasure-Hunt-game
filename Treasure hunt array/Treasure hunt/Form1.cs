using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Treasure_hunt
{
    public partial class Form1 : Form
    {
        string[] allplayers = { "win", "win", "win", "lose", "lose", "lose", "lose", "lose", "lose", "lose", "lose", "lose", "lose", "lose", "lose", "lose", };
        string[] mixedupplayers = new string[16];
        int fillspot = 0;
        Random box = new Random(); 

        int lose = 0;
        int score = 0;
        int number = 0;
        SoundPlayer wrong = new SoundPlayer(Properties.Resources.fbi1);
        SoundPlayer right = new SoundPlayer(Properties.Resources.right1);
        SoundPlayer bad = new SoundPlayer(Properties.Resources.Bad);
        public Form1()
        {
            InitializeComponent();
            please();

        }

        private void please()
        {
            while (fillspot < allplayers.Length)
            {
                int num = box.Next(0, allplayers.Length);
                if (allplayers[num] != "taken") 
                {
                    mixedupplayers[fillspot] = allplayers[num];
                    allplayers[num] = "taken";
                    fillspot++;
                }
            }
        }
           

            

        private void loss() 
        {  
            //play audio
            wrong.Play();
            //counter for losses
            lose = lose + 1;
            if (lose == 1)
            {
                pblife1.Visible = false;
                MessageBox.Show("You have been caught by Hank Shrader! You have 2 lives left");
            }
            else if (lose == 2)
            {
                pblife2.Visible = false;
                MessageBox.Show("You have been caught by Hank Shrader! You have 1 life left");
            }
            else if (lose == 3)
            {
                // brings the ending pb for the game
                pblife3.Visible = false;
                pbbusted.Visible = true;
                lblbusted.Visible = true;
                lblbusted.BringToFront();
                btnend.Visible = true;
                btnend.BringToFront();

            }
        }
        private void win() 
        {
            //plays the sound effect
            right.Play();
            //counter for score
            number++;
            lbscore.Text = number.ToString();
            lbscore.Text = "Score:" + number + "/3";
            score = score + 1;
            if (score == 1)
            {
                MessageBox.Show("You have succesfully completed a drug deal! 2 more to go.");
            }
            else if (score == 2)
            {

                MessageBox.Show("You have succesfully completed a drug deal! 1 more to go.");
            }
            else if (score == 3)
            {
                // ending screen for the game
                pbempire.Visible = true;
                lblempire.Visible = true;
                lblempire.BringToFront();
                btnend.Visible = true;
                btnend.BringToFront();
            }
        }

        
        private void pb1_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[0] == "win")
            {
                win();
                pb1.BackgroundImage = Properties.Resources.money;

            }
            else 
            {
                loss();
                pb1.BackgroundImage = Properties.Resources.hank_shrader;
            }
                
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[1] == "win")
            {
                win();
                pb2.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb2.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[2] == "win")
            {
                win();
                pb3.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb3.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[3] == "win")
            {
                win();
                pb4.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb4.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[4] == "win")
            {
                win();
                pb5.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb5.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[5] == "win")
            {
                win();
                pb6.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb6.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[6] == "win")
            {
                win();
                pb7.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb7.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[7] == "win")
            {
                win();
                pb8.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb8.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[8] == "win")
            {
                win();
                pb9.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb9.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[9] == "win")
            {
                win();
                pb10.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb10.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[10] == "win")
            {
                win();
                pb11.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb11.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[11] == "win")
            {
                win();
                pb12.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb9.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[12] == "win")
            {
                win();
                pb13.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb13.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[13] == "win")
            {
                win();
                pb14.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb14.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[14] == "win")
            {
                win();
                pb15.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb15.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            if (mixedupplayers[15] == "win")
            {
                win();
                pb16.BackgroundImage = Properties.Resources.money;

            }
            else
            {
                loss();
                pb16.BackgroundImage = Properties.Resources.hank_shrader;
            }
        }

        private void lbscore_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // closes the application
            Application.Exit();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
         
           

        }
    }
}
