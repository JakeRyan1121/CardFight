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
    public partial class Shop : Form
    {
        Cards[] arrayCards = new Cards[10];
        int intCountCards = 0;

        string strName = Form1.strName;
        int intGold = Form1.intGold;

        //lblName.Text = strName;
        //lblGold.Text = Convert.ToString(intGold);

        public Shop()
        {
            InitializeComponent();
        }
        
        public void GoldCheck()
        {
            if (intGold < 2000)
            {
                //vitas
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                arrayCards[j] = new Cards();
            }
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Extra";
                arrayCards[intCountCards].Attack = 0;
                arrayCards[intCountCards].Defence = 1;
                arrayCards[intCountCards].Cost = 5;

                //add to array
            }
            intCountCards++;
        }

        private void btnHumanSwordsman_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 
             
                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Human Swordsman";
                arrayCards[intCountCards].Attack = 2;
                arrayCards[intCountCards].Defence = 3;
                arrayCards[intCountCards].Cost = 100;

                //add to array
            }
            intCountCards++;
        }

        private void btnElvenArcher_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Elven Archer";
                arrayCards[intCountCards].Attack = 3;
                arrayCards[intCountCards].Defence = 2;
                arrayCards[intCountCards].Cost = 150;

                //add to array
            }
            intCountCards++;
        }

        private void btnOrcGrunt_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Orc Grunt";
                arrayCards[intCountCards].Attack = 3;
                arrayCards[intCountCards].Defence = 4;
                arrayCards[intCountCards].Cost = 200;

                //add to array
            }
            intCountCards++;
        }

        private void btnDwarfHammer_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Dwarf Hammer Warrior";
                arrayCards[intCountCards].Attack = 3;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 250;

                //add to array
            }
            intCountCards++;
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Knight";
                arrayCards[intCountCards].Attack = 4;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 300;

                //add to array
            }
            intCountCards++;
        }

        private void btnOrcBerserker_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Orc Berserker";
                arrayCards[intCountCards].Attack = 6;
                arrayCards[intCountCards].Defence = 3;
                arrayCards[intCountCards].Cost = 300;

                //add to array
            }
            intCountCards++;
        }

        private void btnBarbarianWarrior_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Barbarian warrior";
                arrayCards[intCountCards].Attack = 4;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 300;

                //add to array
            }
            intCountCards++;
        }

        private void btnDruidBear_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Druid Bear Shaman";
                arrayCards[intCountCards].Attack = 2;
                arrayCards[intCountCards].Defence = 8;
                arrayCards[intCountCards].Cost = 350;

                //add to array
            }
            intCountCards++;
        }

        private void btnWolfWarrior_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Wolf Warrior";
                arrayCards[intCountCards].Attack = 7;
                arrayCards[intCountCards].Defence = 3;
                arrayCards[intCountCards].Cost = 350;

                //add to array
            }
            intCountCards++;
        }

        private void btnRockMonster_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Rock Monster";
                arrayCards[intCountCards].Attack = 1;
                arrayCards[intCountCards].Defence = 9;
                arrayCards[intCountCards].Cost = 350;

                //add to array
            }
            intCountCards++;
        }

        private void btnPaladin_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Paladin";
                arrayCards[intCountCards].Attack = 6;
                arrayCards[intCountCards].Defence = 7;
                arrayCards[intCountCards].Cost = 450;

                //add to array
            }
            intCountCards++;
        }

        private void btnOrcCrusader_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Orc Crusader";
                arrayCards[intCountCards].Attack = 8;
                arrayCards[intCountCards].Defence = 5;
                arrayCards[intCountCards].Cost = 450;

                //add to array
            }
            intCountCards++;
        }

        private void btnTheOldGuard_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "The Old Guard";
                arrayCards[intCountCards].Attack = 8;
                arrayCards[intCountCards].Defence = 8;
                arrayCards[intCountCards].Cost = 500;

                //add to array
            }
            intCountCards++;
        }

        private void btnTigerOrc_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Tiger Orc Berserker";
                arrayCards[intCountCards].Attack = 9;
                arrayCards[intCountCards].Defence = 8;
                arrayCards[intCountCards].Cost = 550;

                //add to array
            }
            intCountCards++;
        }

        private void btnVitas_Click(object sender, EventArgs e)
        {
            if (intCountCards >= 10)
            {
                //they choose the max 

                MessageBox.Show("You have picked the maxiumum amount of cards.");
            }
            else
            {
                arrayCards[intCountCards].Name = "Vitas";
                arrayCards[intCountCards].Attack = 12;
                arrayCards[intCountCards].Defence = 12;
                arrayCards[intCountCards].Cost = 2000;

                //add to array
            }
            intCountCards++;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

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
