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

        public Battle()
        {
            InitializeComponent();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            btnHand1.Text = arrayCards[0].Name;
            btnHand2.Text = arrayCards[1].Name;
            btnHand3.Text = arrayCards[2].Name;
            btnHand4.Text = arrayCards[3].Name;
            btnHand5.Text = arrayCards[4].Name;
            btnHand6.Text = arrayCards[5].Name;
            btnHand7.Text = arrayCards[6].Name;
            btnHand8.Text = arrayCards[7].Name;
            btnHand9.Text = arrayCards[8].Name;
            btnHand10.Text = arrayCards[9].Name;

        }


    }
}
