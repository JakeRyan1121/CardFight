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
        public Shop()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HumanSwordman humanSwordsman = new HumanSwordman();
            OrcGrunt orcGrunt = new OrcGrunt();
            ElvenArcher elvenArcher = new ElvenArcher();
            DwarfHammerWarrior dwarfHammerWarrior = new DwarfHammerWarrior();
            Knight knight = new Knight();
            OrcBerserker orcBerserker = new OrcBerserker();
            BarbarianWarrior barbarianWarrior = new BarbarianWarrior();
            DruidBearShaman druidBearShaman = new DruidBearShaman();
            WolfWarrior wolfWarrior = new WolfWarrior();
            RockMonster rockMonster = new RockMonster();
            Paladin paladin = new Paladin();
            OrcCrusader orcCrusader = new OrcCrusader();
            TheOldGuard theOldGuard = new TheOldGuard();
            TigerOrcBerserker tigerOrcBerserker = new TigerOrcBerserker();
            Vitas vitas = new Vitas();
            Extra extra = new Extra();

            MessageBox.Show(humanSwordsman.GetName() + " " + humanSwordsman.GetAttack() + " " + humanSwordsman.GetHealth() + " " + humanSwordsman.GetCost() + "\n" +
                orcGrunt.GetName() + " " + orcGrunt.GetAttack() + " " + orcGrunt.GetHealth() + " " + orcGrunt.GetCost() + "\n" +
                elvenArcher.GetName() + " " + elvenArcher.GetAttack() + " " + elvenArcher.GetHealth() + " " + elvenArcher.GetCost() + "\n" +
                dwarfHammerWarrior.GetName() + " " + dwarfHammerWarrior.GetAttack() + " " + dwarfHammerWarrior.GetHealth() + " " + dwarfHammerWarrior.GetCost() + "\n" +

                knight.GetName() + " " + knight.GetAttack() + " " + knight.GetHealth() + " " + knight.GetCost() + "\n" +
                orcBerserker.GetName() + " " + orcBerserker.GetAttack() + " " + orcBerserker.GetHealth() + " " + orcBerserker.GetCost() + "\n" +
                barbarianWarrior.GetName() + " " + barbarianWarrior.GetAttack() + " " + barbarianWarrior.GetHealth() + " " + barbarianWarrior.GetCost() + "\n" +
                druidBearShaman.GetName() + " " + druidBearShaman.GetAttack() + " " + druidBearShaman.GetHealth() + " " + druidBearShaman.GetCost() + "\n" +

                wolfWarrior.GetName() + " " + wolfWarrior.GetAttack() + " " + wolfWarrior.GetHealth() + " " + wolfWarrior.GetCost() + "\n" +
                rockMonster.GetName() + " " + rockMonster.GetAttack() + " " + rockMonster.GetHealth() + " " + rockMonster.GetCost() + "\n" +
                paladin.GetName() + " " + paladin.GetAttack() + " " + paladin.GetHealth() + " " + paladin.GetCost() + "\n" +
                orcCrusader.GetName() + " " + orcCrusader.GetAttack() + " " + orcCrusader.GetHealth() + " " + orcCrusader.GetCost() + "\n" +

                humanSwordsman.GetName() + " " + humanSwordsman.GetAttack() + " " + humanSwordsman.GetHealth() + " " + humanSwordsman.GetCost() + "\n" +
                orcGrunt.GetName() + " " + orcGrunt.GetAttack() + " " + orcGrunt.GetHealth() + " " + orcGrunt.GetCost() + "\n" +
                elvenArcher.GetName() + " " + elvenArcher.GetAttack() + " " + elvenArcher.GetHealth() + " " + elvenArcher.GetCost() + "\n" +
                dwarfHammerWarrior.GetName() + " " + dwarfHammerWarrior.GetAttack() + " " + dwarfHammerWarrior.GetHealth() + " " + dwarfHammerWarrior.GetCost() + "\n");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    public class Cards
    {
        public String Name { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Cost { get; set; }

        public virtual string GetName()
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
        }
    }
    public class HumanSwordman : Cards
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
    }
}
