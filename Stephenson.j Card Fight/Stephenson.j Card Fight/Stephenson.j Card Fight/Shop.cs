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
        int i = 0;

        public Shop()
        {
            InitializeComponent();
            string strName = Form1.strName;
            int intGold = Form1.intGold;

            lblName.Text = strName;
            lblGold.Text = Convert.ToString(intGold);
        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Human Swordsman";
                arrayCards[i].Attack = 2;
                arrayCards[i].Defence = 3;
                arrayCards[i].Cost = 100;

                //add to array
            }
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Orc Grunt";
                arrayCards[i].Attack = 3;
                arrayCards[i].Defence = 4;
                arrayCards[i].Cost = 200;

                //add to array
            }
            i++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Elven Archer";
                arrayCards[i].Attack = 3;
                arrayCards[i].Defence = 2;
                arrayCards[i].Cost = 150;

                //add to array
            }
            i++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Dwarf Hammer Warrior";
                arrayCards[i].Attack = 3;
                arrayCards[i].Defence = 5;
                arrayCards[i].Cost = 250;

                //add to array
            }
            i++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Knight";
                arrayCards[i].Attack = 4;
                arrayCards[i].Defence = 5;
                arrayCards[i].Cost = 300;

                //add to array
            }
            i++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Orc Berserker";
                arrayCards[i].Attack = 6;
                arrayCards[i].Defence = 3;
                arrayCards[i].Cost = 300;

                //add to array
            }
            i++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Barbarian warrior";
                arrayCards[i].Attack = 4;
                arrayCards[i].Defence = 5;
                arrayCards[i].Cost = 300;

                //add to array
            }
            i++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Druid Bear Shaman";
                arrayCards[i].Attack = 2;
                arrayCards[i].Defence = 8;
                arrayCards[i].Cost = 350;

                //add to array
            }
            i++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Wolf Warrior";
                arrayCards[i].Attack = 7;
                arrayCards[i].Defence = 3;
                arrayCards[i].Cost = 350;

                //add to array
            }
            i++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Rock Monster";
                arrayCards[i].Attack = 1;
                arrayCards[i].Defence = 9;
                arrayCards[i].Cost = 350;

                //add to array
            }
            i++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Paladin";
                arrayCards[i].Attack = 6;
                arrayCards[i].Defence = 7;
                arrayCards[i].Cost = 450;

                //add to array
            }
            i++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Orc Crusader";
                arrayCards[i].Attack = 8;
                arrayCards[i].Defence = 5;
                arrayCards[i].Cost = 450;

                //add to array
            }
            i++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "The Old Guard";
                arrayCards[i].Attack = 8;
                arrayCards[i].Defence = 8;
                arrayCards[i].Cost = 500;

                //add to array
            }
            i++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Tiger Orc Berserker";
                arrayCards[i].Attack = 9;
                arrayCards[i].Defence = 8;
                arrayCards[i].Cost = 550;

                //add to array
            }
            i++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Vitas";
                arrayCards[i].Attack = 12;
                arrayCards[i].Defence = 12;
                arrayCards[i].Cost = 2000;

                //add to array
            }
            i++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (i >= 10)
            {
                //they choose the max //use for loop
                string strDisplay = "Name   Attack   Defence   Cost";
                for (int j = 0; j < 10; j++)
                {
                    strDisplay += Environment.NewLine + arrayCards[i].Name + " " + arrayCards[i].Attack + " " + arrayCards[i].Defence + " " + arrayCards[i].Cost;
                }
                MessageBox.Show(strDisplay);
            }
            else
            {
                arrayCards[i].Name = "Extra";
                arrayCards[i].Attack = 0;
                arrayCards[i].Defence = 1;
                arrayCards[i].Cost = 5;

                //add to array
            }
            i++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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

        private void button16_Click_1(object sender, EventArgs e)
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
