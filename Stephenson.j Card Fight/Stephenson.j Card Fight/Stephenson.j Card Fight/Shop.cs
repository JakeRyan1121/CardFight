//Josh, Wyatt, Jake, Iyan
//Card Fight
//Shop Form 
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

namespace Stephenson.j_Card_Fight
{
    public partial class Shop : Form
    {
        public static Cards[] arrayCards = new Cards[10]; //the array of objects for the user's cards
        int intCountCards = 0; //the counter for the amount of cards the user has selected

        string strName = Form1.strName; //brings the name from form 1
        int intGold = Form1.intGold; //brings the gold from form 1
        static int intGoldCopy = Form1.intGold; //makes a copy of intGold to use for the reset button


        public Shop()
        {
            InitializeComponent();
        }

        public void GoldCheck() //disables buttons (cards) when the user doesn't have the money for it
        {
            if (intGold < 2000) 
            {
                btnVitas.Enabled = false;
            }
            if (intGold < 550)
            {
                btnTigerOrc.Enabled = false;
            }
            if (intGold < 500)
            {
                btnTheOldGuard.Enabled = false;

            }
            if (intGold < 450)
            {
                btnOrcCrusader.Enabled = false;
                btnPaladin.Enabled = false;

            }
            if (intGold < 350)
            {
                btnRockMonster.Enabled = false;
                btnWolfWarrior.Enabled = false;
                btnDruidBear.Enabled = false;

            }
            if (intGold < 300)
            {
                btnBarbarianWarrior.Enabled = false;
                btnOrcBerserker.Enabled = false;
                btnKnight.Enabled = false;

            }
            if (intGold < 250)
            {
                btnDwarfHammer.Enabled = false;
            }
            if (intGold < 200)
            {
                btnOrcGrunt.Enabled = false;
            }
            if (intGold < 150)
            {
                btnElvenArcher.Enabled = false;
            }
            if (intGold < 100)
            {
                btnHumanSwordsman.Enabled = false;
            }
            if (intGold < 5)
            {
                btnExtra.Enabled = false;
            }
            lblGold.Text = Convert.ToString(intGold); //show the user how much gold they have left
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            lblName.Text = strName;
            lblGold.Text = Convert.ToString(intGold);

            for (int j = 0; j < 10; j++)  //The instantiator for the array of cards
            {
                arrayCards[j] = new Cards();
            }
            GoldCheck();
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {               
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Extra";
                arrayCards[intCountCards].Attack = 0;
                arrayCards[intCountCards].Defence = 1;
                arrayCards[intCountCards].Cost = 5;
                lstChoices.Items.Add("Extra");              
            }
            intCountCards++;
           
            intGold = intGold - 5; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnHumanSwordsman_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Human Swordsman";
                arrayCards[intCountCards].Attack = 2;
                arrayCards[intCountCards].Defence = 3;
                arrayCards[intCountCards].Cost = 100;
                lstChoices.Items.Add("Human Swordsman");             
            }
            intCountCards++;
            
            intGold = intGold - 100; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnElvenArcher_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Elven Archer";
                arrayCards[intCountCards].Attack = 3;
                arrayCards[intCountCards].Defence = 2;
                arrayCards[intCountCards].Cost = 150;
                lstChoices.Items.Add("Elven Archer");
            }
            intCountCards++;
            
            intGold = intGold - 150; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnOrcGrunt_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Orc Grunt";
                arrayCards[intCountCards].Attack = 3;
                arrayCards[intCountCards].Defence = 4;
                arrayCards[intCountCards].Cost = 200;
                lstChoices.Items.Add("Orc Grunt");
            }
            intCountCards++;
            
            intGold = intGold - 200; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnDwarfHammer_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Dwarf Hammer Warrior";
                arrayCards[intCountCards].Attack = 3;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 250;
                lstChoices.Items.Add("Dwarf Hammer Warrior");
            }
            intCountCards++;
            
            intGold = intGold - 250; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Knight";
                arrayCards[intCountCards].Attack = 4;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 300;
                lstChoices.Items.Add("Knight");
            }
            intCountCards++;
            
            intGold = intGold - 300; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnOrcBerserker_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Orc Berserker";
                arrayCards[intCountCards].Attack = 6;
                arrayCards[intCountCards].Defence = 3;
                arrayCards[intCountCards].Cost = 300;
                lstChoices.Items.Add("Orc Berserker");
            }
            intCountCards++;
            
            intGold = intGold - 300; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnBarbarianWarrior_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                 MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Barbarian warrior";
                arrayCards[intCountCards].Attack = 4;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 300;
                lstChoices.Items.Add("Barbarian Warrior");
            }
            intCountCards++;
            
            intGold = intGold - 300; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnDruidBear_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Druid Bear Shaman";
                arrayCards[intCountCards].Attack = 2;
                arrayCards[intCountCards].Defence = 8;
                arrayCards[intCountCards].Cost = 350;
                lstChoices.Items.Add("Druid Bear Shaman");
            }
            intCountCards++;
            
            intGold = intGold - 350; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnWolfWarrior_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                 MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Wolf Warrior";
                arrayCards[intCountCards].Attack = 7;
                arrayCards[intCountCards].Defence = 3;
                arrayCards[intCountCards].Cost = 350;
                lstChoices.Items.Add("Wolf Warrior");
            }
            intCountCards++;
            
            intGold = intGold - 350; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnRockMonster_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                 MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Rock Monster";
                arrayCards[intCountCards].Attack = 1;
                arrayCards[intCountCards].Defence = 9;
                arrayCards[intCountCards].Cost = 350;
                lstChoices.Items.Add("Rock Monster");
            }
            intCountCards++;
            
            intGold = intGold - 350; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnPaladin_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Paladin";
                arrayCards[intCountCards].Attack = 6;
                arrayCards[intCountCards].Defence = 7;
                arrayCards[intCountCards].Cost = 450;
                lstChoices.Items.Add("Paladin");
            }
            intCountCards++;
            
            intGold = intGold - 450; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnOrcCrusader_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Orc Crusader";
                arrayCards[intCountCards].Attack = 8;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 450;
                lstChoices.Items.Add("Orc Crusader");
            }
            intCountCards++;
            
            intGold = intGold - 450; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnTheOldGuard_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                 MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "The Old Guard";
                arrayCards[intCountCards].Attack = 8;
                arrayCards[intCountCards].Defence = 8;
                arrayCards[intCountCards].Cost = 500;
                lstChoices.Items.Add("The Old Guard");
            }
            intCountCards++;
            
            intGold = intGold - 500; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnTigerOrc_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Tiger Orc Berserker";
                arrayCards[intCountCards].Attack = 9;
                arrayCards[intCountCards].Defence = 8;
                arrayCards[intCountCards].Cost = 550;
                lstChoices.Items.Add("Tiger Orc Berserker");
            }
            intCountCards++;
            
            intGold = intGold - 550; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnVitas_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10) //prevents the user from picking more then 10 cards
            {
                 MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else //sets the array for the selected card
            {
                arrayCards[intCountCards].Name = "Vitas";
                arrayCards[intCountCards].Attack = 12;
                arrayCards[intCountCards].Defence = 12;
                arrayCards[intCountCards].Cost = 2000;
                lstChoices.Items.Add("Vitas");
            }
            intCountCards++;
            
            intGold = intGold - 2000; //subtracts the cost of the card from the user's gold
            GoldCheck();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide(); //Shows the battle form and hides the shop
            Battle form3 = new Battle();
            form3.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e) //resets the entire shop
        {
            btnExtra.Enabled = true;             //Re enables all buttons
            btnHumanSwordsman.Enabled = true;
            btnDruidBear.Enabled = true;
            btnDwarfHammer.Enabled = true;
            btnBarbarianWarrior.Enabled = true;
            btnElvenArcher.Enabled = true;
            btnKnight.Enabled = true;
            btnOrcBerserker.Enabled = true;
            btnOrcCrusader.Enabled = true;
            btnOrcGrunt.Enabled = true;
            btnPaladin.Enabled = true;
            btnRockMonster.Enabled = true;
            btnTheOldGuard.Enabled = true;
            btnWolfWarrior.Enabled = true;
            btnVitas.Enabled = true;
            btnTigerOrc.Enabled = true;

            intGold = intGoldCopy;            //resets the gold
            Array.Clear(arrayCards, 0, 9);    //clears the array
            lstChoices.Items.Clear();         //clears the list
            intCountCards = 0;                //resets the card counter
            GoldCheck();                     
            for (int j = 0; j < 10; j++) //the instantiator 
            {
                arrayCards[j] = new Cards();
            }

        }
    }
    public class Cards
    {
        public String Name { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Cost { get; set; }

    }
    
}
