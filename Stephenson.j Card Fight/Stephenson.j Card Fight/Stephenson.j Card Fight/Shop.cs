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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[intCountCards].Name + " " + arrayCards[intCountCards].Attack + " " + arrayCards[intCountCards].Defence + " " + arrayCards[intCountCards].Cost;
                }
                MessageBox.Show(strDisplay);
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

        /*public virtual string GetName()
        {
            return "";
        }
        public virtual int GetAttack()
        {
            return 0;
        }
        public virtual int GetHealth()
        {
            return 0;
        }
        public virtual int GetCost()
        {
            return 0;
        }*/
    }
    /* public class HumanSwordman : Cards
     {
         public override string GetName()
         {
             return "Human Swordsman";
         }
         public override int GetAttack()
         {
             return 2;
         }
         public override int GetHealth()
         {
             return 3;
         }
         public override int GetCost()
         {
             return 100;
         }
     }
     public class OrcGrunt : Cards
     {
         public override string GetName()
         {
             return "Orc Grunt";
         }
         public override int GetAttack()
         {
             return 3;
         }
         public override int GetHealth()
         {
             return 4;
         }
         public override int GetCost()
         {
             return 200;
         }
     }
     public class ElvenArcher : Cards
     {
         public override string GetName()
         {
             return "Elven Archer";
         }
         public override int GetAttack()
         {
             return 3;
         }
         public override int GetHealth()
         {
             return 2;
         }
         public override int GetCost()
         {
             return 150;
         }
     }
     public class DwarfHammerWarrior : Cards
     {
         public override string GetName()
         {
             return "Dwarf Hammer Warrior";
         }
         public override int GetAttack()
         {
             return 3;
         }
         public override int GetHealth()
         {
             return 5;
         }
         public override int GetCost()
         {
             return 250;
         }
     }
     public class Knight : Cards
     {
         public override string GetName()
         {
             return "Knight";
         }
         public override int GetAttack()
         {
             return 4;
         }
         public override int GetHealth()
         {
             return 5;
         }
         public override int GetCost()
         {
             return 300;
         }
     }
     public class OrcBerserker : Cards
     {
         public override string GetName()
         {
             return "Orc Berserker";
         }
         public override int GetAttack()
         {
             return 6;
         }
         public override int GetHealth()
         {
             return 3;
         }
         public override int GetCost()
         {
             return 300;
         }
     }
     public class BarbarianWarrior : Cards
     {
         public override string GetName()
         {
             return "Barbarian warrior";
         }
         public override int GetAttack()
         {
             return 4;
         }
         public override int GetHealth()
         {
             return 5;
         }
         public override int GetCost()
         {
             return 300;
         }
     }
     public class DruidBearShaman : Cards
     {
         public override string GetName()
         {
             return "Druid Bear Shaman";
         }
         public override int GetAttack()
         {
             return 2;
         }
         public override int GetHealth()
         {
             return 8;
         }
         public override int GetCost()
         {
             return 350;
         }
     }
     public class WolfWarrior : Cards
     {
         public override string GetName()
         {
             return "Wolf Warrior";
         }
         public override int GetAttack()
         {
             return 7;
         }
         public override int GetHealth()
         {
             return 3;
         }
         public override int GetCost()
         {
             return 350;
         }
     }
     public class RockMonster : Cards
     {
         public override string GetName()
         {
             return "Rock Monster";
         }
         public override int GetAttack()
         {
             return 1;
         }
         public override int GetHealth()
         {
             return 9;
         }
         public override int GetCost()
         {
             return 350;
         }
     }
     public class Paladin : Cards
     {
         public override string GetName()
         {
             return "Paladin";
         }
         public override int GetAttack()
         {
             return 6;
         }
         public override int GetHealth()
         {
             return 7;
         }
         public override int GetCost()
         {
             return 450;
         }
     }
     public class OrcCrusader : Cards
     {
         public override string GetName()
         {
             return "Orc Crusader";
         }
         public override int GetAttack()
         {
             return 8;
         }
         public override int GetHealth()
         {
             return 5;
         }
         public override int GetCost()
         {
             return 450;
         }
     }
     public class TheOldGuard : Cards
     {
         public override string GetName()
         {
             return "The Old Guard";
         }
         public override int GetAttack()
         {
             return 8;
         }
         public override int GetHealth()
         {
             return 8;
         }
         public override int GetCost()
         {
             return 500;
         }
     }
     public class TigerOrcBerserker : Cards
     {
         public override string GetName()
         {
             return "Tiger Orc Berserker";
         }
         public override int GetAttack()
         {
             return 9;
         }
         public override int GetHealth()
         {
             return 8;
         }
         public override int GetCost()
         {
             return 550;
         }
     }
     public class Vitas : Cards
     {
         public override string GetName()
         {
             return "Vitas";
         }
         public override int GetAttack()
         {
             return 12;
         }
         public override int GetHealth()
         {
             return 12;
         }
         public override int GetCost()
         {
             return 2000;
         }
     }
     public class Extra : Cards
     {
         public override string GetName()
         {
             return "Extra";
         }
         public override int GetAttack()
         {
             return 0;
         }
         public override int GetHealth()
         {
             return 1;
         }
         public override int GetCost()
         {
             return 5;
         }
     }*/
}
