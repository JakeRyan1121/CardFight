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
        public static Cards[] arrayCards = new Cards[10];
        int intCountCards = 0;

        string strName = Form1.strName;
        int intGold = Form1.intGold;
        static int intGoldCopy = Form1.intGold;


        public Shop()
        {
            InitializeComponent();
        }

        public void GoldCheck()
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
            lblGold.Text = Convert.ToString(intGold);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            lblName.Text = strName;
            lblGold.Text = Convert.ToString(intGold);

            for (int j = 0; j < 10; j++)
            {
                arrayCards[j] = new Cards();
            }
            GoldCheck();
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
                lstChoices.Items.Add("Extra");//put in else
                //add to array
            }
            intCountCards++;
           
            intGold = intGold - 5;
            GoldCheck();

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
                lstChoices.Items.Add("Human Swordsman");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 100;
            GoldCheck();

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
                lstChoices.Items.Add("Elven Archer");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 150;
            GoldCheck();

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
                lstChoices.Items.Add("Orc Grunt");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 200;
            GoldCheck();

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
                lstChoices.Items.Add("Dwarf Hammer Warrior");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 250;
            GoldCheck();

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
                lstChoices.Items.Add("Knight");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 300;
            GoldCheck();

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
                lstChoices.Items.Add("Orc Berserker");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 300;
            GoldCheck();

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
                lstChoices.Items.Add("Barbarian Warrior");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 300;
            GoldCheck();

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
                lstChoices.Items.Add("Druid Bear Shaman");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 350;
            GoldCheck();

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
                lstChoices.Items.Add("Wolf Warrior");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 350;
            GoldCheck();

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
                lstChoices.Items.Add("Rock Monster");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 350;
            GoldCheck();

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
                lstChoices.Items.Add("Paladin");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 450;
            GoldCheck();

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
                lstChoices.Items.Add("Orc Crusader");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 450;
            GoldCheck();

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
                lstChoices.Items.Add("The Old Guard");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 500;
            GoldCheck();

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
                lstChoices.Items.Add("Tiger Orc Berserker");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 550;
            GoldCheck();

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
                lstChoices.Items.Add("Vitas");
                //add to array
            }
            intCountCards++;
            
            intGold = intGold - 2000;
            GoldCheck();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Battle form3 = new Battle();
            form3.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnExtra.Enabled = true;                   //Re enables all buttons
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

            intGold = intGoldCopy;
            Array.Clear(arrayCards, 0, 9);
            lstChoices.Items.Clear();
            intCountCards = 0;
            GoldCheck();
            for (int j = 0; j < 10; j++)
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
