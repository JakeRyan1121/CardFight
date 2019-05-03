//Josh, Wyatt, Jake, Iyan
//Card Fight
//Battle Form 
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
        Cards[] arrayCards = Shop.arrayCards; //pulls the array from the shop
        Cards[] arrayBD = new Cards[10]; //the array for the battle dummys
        int intSelectedCard = 0; //the selected card field position
        int intSelectedBD; //the selected battle dummy field position

        public Battle()
        {
            InitializeComponent();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++) //the instantiator for the card array
            {
                arrayBD[j] = new Cards();
            }
            for (int i = 0; i < 10; i++) //the instantiator for the battle dummys
            {
                arrayBD[i].Name = "Battle Dummy";
                arrayBD[i].Attack = 1;
                arrayBD[i].Defence = 1;
            }
            //prints the cards on the hand buttons 
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
        }


        public void BattleDummyKillUs() //the class for the battle dummy attacking
        {   
            arrayCards[intSelectedCard - 1].Defence = arrayCards[intSelectedCard - 1].Defence - arrayBD[intSelectedCard - 1].Attack; //the card that the user selects takes damage from the battle dummy
            if (arrayCards[intSelectedCard - 1].Defence <= 0) //takes the user's card off the field if their card dies
            {
                btnHand1.Enabled = true;
                btnHand2.Enabled = true;
                btnHand3.Enabled = true;
                btnHand4.Enabled = true;
                btnHand5.Enabled = true;
                btnHand6.Enabled = true;
                btnHand7.Enabled = true;
                btnHand8.Enabled = true;
                btnHand9.Enabled = true;
                btnHand10.Enabled = true;
                
                btnSlot1.Text = "1";

                MessageBox.Show(arrayCards[intSelectedCard - 1].Name + " is dead");
            }
            else //updates the cards health if they didn't die
            {
                btnSlot1.Text = arrayCards[intSelectedCard - 1].Name + "\n" + "Health: " + arrayCards[intSelectedCard - 1].Defence + "\n" + "Attack: " + arrayCards[intSelectedCard - 1].Attack;
            }

            if (arrayCards[0].Defence <= 0)   //disables the card in the hand if the card has 0 health left
            {
                btnHand1.Enabled = false;
            }
            if (arrayCards[1].Defence <= 0)
            {
                btnHand2.Enabled = false;
            }
            if (arrayCards[2].Defence <= 0)
            {
                btnHand3.Enabled = false;
            }
            if (arrayCards[3].Defence <= 0)
            {
                btnHand4.Enabled = false;
            }
            if (arrayCards[4].Defence <= 0)
            {
                btnHand5.Enabled = false;
            }
            if (arrayCards[5].Defence <= 0)
            {
                btnHand6.Enabled = false;
            }          
            if (arrayCards[6].Defence <= 0)
            {
                btnHand7.Enabled = false;
            }
            if (arrayCards[7].Defence <= 0)
            {
                btnHand8.Enabled = false;
            }
            if (arrayCards[8].Defence <= 0)
            {
                btnHand9.Enabled = false;
            }
            if (arrayCards[9].Defence <= 0)
            {
                btnHand10.Enabled = false;
            }
           
        }

        private void btnSlot1_Click(object sender, EventArgs e) //puts the user's selected card on the field
        {
            if (btnSlot1.Text == "1" && intSelectedCard > 0)
            {
                if (intSelectedCard == 1)
                {
                    btnSlot1.Text = btnHand1.Text;
                }
                if (intSelectedCard == 2)
                {
                    btnSlot1.Text = btnHand2.Text;
                }
                if (intSelectedCard == 3)
                {
                    btnSlot1.Text = btnHand3.Text;
                }
                if (intSelectedCard == 4)
                {
                    btnSlot1.Text = btnHand4.Text;
                }
                if (intSelectedCard == 5)
                {
                    btnSlot1.Text = btnHand5.Text;
                }
                if (intSelectedCard == 6)
                {
                    btnSlot1.Text = btnHand6.Text;
                }
                if (intSelectedCard == 7)
                {
                    btnSlot1.Text = btnHand7.Text;
                }
                if (intSelectedCard == 8)
                {
                    btnSlot1.Text = btnHand8.Text;
                }
                if (intSelectedCard == 9)
                {
                    btnSlot1.Text = btnHand9.Text;
                }
                if (intSelectedCard == 10)
                {
                    btnSlot1.Text = btnHand10.Text;
                }
                
                btnHand1.Enabled = false;  //disables the user's hand if they have a card on the field
                btnHand2.Enabled = false;
                btnHand3.Enabled = false;
                btnHand4.Enabled = false;
                btnHand5.Enabled = false;
                btnHand6.Enabled = false;
                btnHand7.Enabled = false;
                btnHand8.Enabled = false;
                btnHand9.Enabled = false;
                btnHand10.Enabled = false;

            }
            //prints the card that the user selects to the slot on the field 
            btnSlot1.Text = arrayCards[intSelectedCard - 1].Name + "\n" + "Health: " + arrayCards[intSelectedCard - 1].Defence + "\n" + "Attack: " + arrayCards[intSelectedCard - 1].Attack;
        }
        
        private void btnHand1_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 1;
            btnSlot1.Enabled = true;
        }

        private void btnHand2_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 2;
            btnSlot1.Enabled = true;
        }

        private void btnHand3_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 3;
            btnSlot1.Enabled = true;
        }

        private void btnHand4_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 4;
            btnSlot1.Enabled = true;
        }

        private void btnHand5_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 5;
            btnSlot1.Enabled = true;
        }

        private void btnHand6_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 6;
            btnSlot1.Enabled = true;
        }

        private void btnHand7_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 7;
            btnSlot1.Enabled = true;
        }

        private void btnHand8_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 8;
            btnSlot1.Enabled = true;
        }

        private void btnHand9_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 9;
            btnSlot1.Enabled = true;
        }

        private void btnHand10_Click(object sender, EventArgs e) //picks the hand position when the user selects a card in their hand
        {
            intSelectedCard = 10;
            btnSlot1.Enabled = true;
        }

        public void Fight() //the class for the user to deal damage
        {
            if (arrayCards[intSelectedCard - 1].Defence > 0) //if the user's card is not dead then they will do damage to the selected battle dummy
            {
                if (intSelectedBD == 1)
                {
                    arrayBD[0].Defence = arrayBD[0].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 2)
                {
                    arrayBD[1].Defence = arrayBD[1].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 3)
                {
                    arrayBD[2].Defence = arrayBD[2].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 4)
                {
                    arrayBD[3].Defence = arrayBD[3].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 5)
                {
                    arrayBD[4].Defence = arrayBD[4].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 6)
                {
                    arrayBD[5].Defence = arrayBD[5].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 7)
                {
                    arrayBD[6].Defence = arrayBD[6].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 8)
                {
                    arrayBD[7].Defence = arrayBD[7].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 9)
                {
                    arrayBD[8].Defence = arrayBD[8].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
                else if (intSelectedBD == 10)
                {
                    arrayBD[9].Defence = arrayBD[9].Defence - arrayCards[intSelectedCard - 1].Attack;
                }
            }
            
            if (arrayBD[0].Defence <= 0) //disables the battle dummy when its health is 0 or less
            {
                btnBD1.Enabled = false;
            }
            if (arrayBD[1].Defence <= 0)
            {
                btnBD2.Enabled = false;
            }
            if (arrayBD[2].Defence <= 0)
            {
                btnBD3.Enabled = false;
            }
            if (arrayBD[3].Defence <= 0)
            {
                btnBD4.Enabled = false;
            }
            if (arrayBD[4].Defence <= 0)
            {
                btnBD5.Enabled = false;
            }
            if (arrayBD[5].Defence <= 0)
            {
                btnBD6.Enabled = false;
            }
            if (arrayBD[6].Defence <= 0)
            {
                btnBD7.Enabled = false;
            }
            if (arrayBD[7].Defence <= 0)
            {
                btnBD8.Enabled = false;
            }
            if (arrayBD[8].Defence <= 0)
            {
                btnBD9.Enabled = false;
            }
            if (arrayBD[9].Defence <= 0)
            {
                btnBD10.Enabled = false;
            }

            //tells the user they won if they killed all of the battle dummys
            if (arrayBD[0].Defence <= 0 && arrayBD[1].Defence <= 0 && arrayBD[2].Defence <= 0 && arrayBD[3].Defence <= 0 && arrayBD[4].Defence <= 0 && arrayBD[5].Defence <= 0 && arrayBD[6].Defence <= 0 && arrayBD[7].Defence <= 0 && arrayBD[8].Defence <= 0 && arrayBD[9].Defence <= 0)
            {
                MessageBox.Show("You win!");
            }
            
        }
         
        private void btnBD1_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 1; 
            Fight();
            BattleDummyKillUs();
           
        }

        private void btnBD2_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 2;
            Fight();
            BattleDummyKillUs();
        }

        private void btnBD3_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 3;
            Fight();
            BattleDummyKillUs();
        }
        
        private void btnBD4_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 4;
            Fight();
            BattleDummyKillUs();
        }

        private void btnBD5_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 5;
            Fight();
            BattleDummyKillUs();
        }

        private void btnBD6_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 6;
            Fight();
            BattleDummyKillUs();
        }

        private void btnBD7_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 7;
            Fight();
            BattleDummyKillUs();
        }

        private void btnBD8_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 8;
            Fight();
            BattleDummyKillUs();
        }

        private void btnBD9_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 9;
            Fight();
            BattleDummyKillUs();
        }

        private void btnBD10_Click(object sender, EventArgs e) //does the fight and battle dummy class
        {
            intSelectedBD = 10;
            Fight();
            BattleDummyKillUs();
        }
        
    }
}
