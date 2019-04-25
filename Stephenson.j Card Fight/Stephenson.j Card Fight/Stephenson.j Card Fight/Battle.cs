using System;
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

        public void HandToSlot()
        {
            
        }

        private void btnSlot1_Click(object sender, EventArgs e)
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
        }

        private void btnSlot2_Click(object sender, EventArgs e)
        {
            HandToSlot();
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
