//Josh, Wyatt, Jake, Iyan
//Card Fight
//Opening Form 
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
        public static string strName = ""; //the string for the user's name
        public static int intGold = 0; //the integer for the gold
        bool blnCorrect = true; //the boolean for the try catch

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            strName = txtName.Text; //puts the user's name from the text box to strName

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                intGold = Convert.ToInt32(txtMoney.Text); //trys to convert intGold to a string
            }
            catch
            {
                blnCorrect = false; //sets binCorrect to false if intGold is not an integer
            }

            if (blnCorrect == false) //tells the user if they didn't input an integer
            {
                MessageBox.Show("Only numbers can be input for the gold");
            }
            else 
            {
                if (intGold < 1 || intGold > 2000) //if the user inputs an integer then it checks if it is between 1 and 2000
                {
                    MessageBox.Show("The amount of money has to be between 1 and 2000");

                }
                else //if the user inputs an integer between 1 and 2000 then the shop form is showed
                {
                    this.Hide();
                    Shop form2 = new Shop();
                    form2.ShowDialog();
                }
            }
            blnCorrect = true; 
        }

        
    }

}