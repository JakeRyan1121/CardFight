﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stephenson.j_Card_Fight
{
    public partial class Battle : Form
    {
        Cards[] arrayCards = Shop.arrayCards;
        Cards[] arrayBD = new Cards[10];
        int intSelectedCard = 0;

        public Battle()
        {
            InitializeComponent();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            btnHand1.Text = arrayCards[0].Name + "\n" + "Health: " + arrayCards[0].Defence + "\n" + "Attack: " + arrayCards[0].Attack;
            btnHand2.Text = arrayCards[1].Name + "\n" + "Health: " + arrayCards[1].Defence + "\n" + "Attack: " + arrayCards[1].Attack;
            btnHand3.Text = arrayCards[2].Name + "\n" + "Health: " + arrayCards[2].Defence + "\n" + "Attack: " + arrayCards[2].Attack;
            btnHand4.Text = arrayCards[3].Name + "\n" + "Health: " + arrayCards[3].Defence + "\n" + "Attack: " + arrayCards[3].Attack;
            btnHand5.Text = arrayCards[4].Name + "\n" + "Health: " + arrayCards[4].Defence + "\n" + "Attack: " + arrayCards[4].Attack;
            btnHand6.Text = arrayCards[5].Name + "\n" + "Health: " + arrayCards[5].Defence + "\n" + "Attack: " + arrayCards[5].Attack;
            btnHand7.Text = arrayCards[6].Name + "\n" + "Health: " + arrayCards[6].Defence + "\n" + "Attack: " + arrayCards[6].Attack;
            btnHand8.Text = arrayCards[7].Name + "\n" + "Health: " + arrayCards[7].Defence + "\n" + "Attack: " + arrayCards[7].Attack;
            btnHand9.Text = arrayCards[8].Name + "\n" + "Health: " + arrayCards[8].Defence + "\n" + "Attack: " + arrayCards[8].Attack;
            btnHand10.Text = arrayCards[9].Name + "\n" + "Health: " + arrayCards[9].Defence + "\n" + "Attack: " + arrayCards[9].Attack;

            for (int j = 0; j < 10; j++)
            {
                arrayBD[j] = new Cards();
            }
            for (int i = 0; i < 10; i++)
            {
                arrayBD[i].Name = "Battle Dummy";
                arrayBD[i].Attack = 1;
                arrayBD[i].Defence = 1;
            }
        }


        public void BattleTest()
        {
            arrayCards[0].Defence = arrayCards[0].Defence - arrayBD[0].Attack;
            if (arrayCards[0].Defence <= 0)
            {
                MessageBox.Show(arrayCards[0].Name + "has died");
            }

        }

        private void btnSlot1_Click(object sender, EventArgs e)
        {
            if (btnSlot1.Text == "1")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot1.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot1.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot1.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot1.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot1.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot1.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot1.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot1.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot1.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot1.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }                   

        }

        private void btnSlot2_Click(object sender, EventArgs e)
        {
            if (btnSlot2.Text == "2")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot2.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot2.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot2.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot2.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot2.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot2.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot2.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot2.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot2.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot2.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }
                

        }

        private void btnSlot3_Click(object sender, EventArgs e)
        {
            if (btnSlot3.Text == "3")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot3.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot3.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot3.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot3.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot3.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot3.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot3.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot3.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot3.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot3.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }

                

        }

        private void btnSlot4_Click(object sender, EventArgs e)
        {
            if (btnSlot4.Text == "4")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot4.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot4.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot4.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot4.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot4.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot4.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot4.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot4.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot4.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot4.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }
                

        }

        private void btnSlot5_Click(object sender, EventArgs e)
        {
            if (btnSlot5.Text == "5")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot5.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot5.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot5.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot5.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot5.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot5.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot5.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot5.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot5.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot5.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }
               

        }

        private void btnSlot6_Click(object sender, EventArgs e)
        {
            if (btnSlot6.Text == "6")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot6.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot6.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot6.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot6.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot6.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot6.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot6.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot6.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot6.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot6.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }
               

        }

        private void btnSlot7_Click(object sender, EventArgs e)
        {
            if (btnSlot7.Text == "7")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot7.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot7.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot7.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot7.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot7.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot7.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot7.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot7.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot7.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot7.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }
                

        }

        private void btnSlot8_Click(object sender, EventArgs e)
        {
            if (btnSlot8.Text == "8")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot8.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot8.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot8.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot8.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot8.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot8.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot8.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot8.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot8.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot8.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }
                

        }

        private void btnSlot9_Click(object sender, EventArgs e)
        {
            if (btnSlot9.Text == "9")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot9.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot9.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot9.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot9.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot9.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot9.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot9.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot9.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot9.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot9.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }
                intSelectedCard = 0;
            }
               

        }

        private void btnSlot10_Click(object sender, EventArgs e)
        {
            if (btnSlot10.Text == "10")
            {
                if (intSelectedCard == 1)
                {
                    btnSlot10.Text = btnHand1.Text;
                    btnHand1.Enabled = false;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot10.Text = btnHand2.Text;
                    btnHand2.Enabled = false;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot10.Text = btnHand3.Text;
                    btnHand3.Enabled = false;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot10.Text = btnHand4.Text;
                    btnHand4.Enabled = false;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot10.Text = btnHand5.Text;
                    btnHand5.Enabled = false;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot10.Text = btnHand6.Text;
                    btnHand6.Enabled = false;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot10.Text = btnHand7.Text;
                    btnHand7.Enabled = false;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot10.Text = btnHand8.Text;
                    btnHand8.Enabled = false;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot10.Text = btnHand9.Text;
                    btnHand9.Enabled = false;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot10.Text = btnHand10.Text;
                    btnHand10.Enabled = false;
                }

                intSelectedCard = 0;
            }
                

        }

        private void btnHand1_Click(object sender, EventArgs e)
        {
            intSelectedCard = 1; 
        }

        private void btnHand2_Click(object sender, EventArgs e)
        {
            intSelectedCard = 2;
        }

        private void btnHand3_Click(object sender, EventArgs e)
        {
            intSelectedCard = 3;
        }

        private void btnHand4_Click(object sender, EventArgs e)
        {
            intSelectedCard = 4;
        }

        private void btnHand5_Click(object sender, EventArgs e)
        {
            intSelectedCard = 5;
        }

        private void btnHand6_Click(object sender, EventArgs e)
        {
            intSelectedCard = 6;
        }

        private void btnHand7_Click(object sender, EventArgs e)
        {
            intSelectedCard = 7;
        }

        private void btnHand8_Click(object sender, EventArgs e)
        {
            intSelectedCard = 8;
        }

        private void btnHand9_Click(object sender, EventArgs e)
        {
            intSelectedCard = 9;
        }

        private void btnHand10_Click(object sender, EventArgs e)
        {
            intSelectedCard = 10;
        }

        
    }
}
