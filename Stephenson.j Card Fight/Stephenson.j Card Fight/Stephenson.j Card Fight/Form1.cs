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
    public partial class Form1 : Form
    {
        Cards[] cardsHand = new Cards[10];
        public static string strName;
        public static int intGold = 0;
        bool blnCorrect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int Instantiate = 0; Instantiate < 10; Instantiate++)
            {
                cardsHand[Instantiate] = new Cards();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            strName = txtName.Text;
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intGold = Convert.ToInt16(txtMoney.Text);
            }
            catch
            {
                blnCorrect = false;             
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (blnCorrect == true)
            {
                MessageBox.Show(strName + "\n" + intGold);
            }
            else
            {
                MessageBox.Show("Only numbers");
            }
        }
    }
    // test

    public class Cards
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Cost { get; set; }
        
    } 
}
