﻿using System;
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
        public static string strName = "";
        public static int intGold = 0;

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

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            strName = txtName.Text;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                intGold = Convert.ToInt16(txtMoney.Text);
                if (intGold < 1 || intGold > 2000)
                {
                    MessageBox.Show("The amount of money has to be between 1 and 2000");                 
                }
                else
                {
                    MessageBox.Show(strName + "\n" + intGold);
                    this.Hide();
                    Shop form2 = new Shop();
                    form2.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Only numbers can be input for the gold");
            }
        }

        
    }

}