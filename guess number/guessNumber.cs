using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_my_number
{
   
    public partial class Form1 : Form
    {
        Random random = new Random();
        int theNum;
        int trys;
        string loss;
       
        
        public Form1()
        {  
            InitializeComponent();
            
        }

        private void guessSpn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guessBttn_Click(object sender, EventArgs e)
        {
            highLbl.Visible = false;
            lowerLbl.Visible = false;
           
            
            if (theNum == 0)
            {
               theNum = random.Next(1, 11);
                string loss = "You lost. The number was " + theNum;
                theNumLbl.Text = theNum.ToString();
            }


            if (guessSpn.Value < theNum && trys < 3)
            {
                highLbl.Visible = true;
            }
            else if (guessSpn.Value > theNum && trys < 3)
            {
                lowerLbl.Visible = true;
            }
            else if (trys < 3)
            {
                winLbl.Visible = true;
                guessBttn.BackColor = Color.LightSeaGreen;
                trys = 3;
            }
            else
            {
                lossLbl.Visible = true;
                theNumLbl.Visible = true;
                guessBttn.BackColor = Color.Red;

            }

            trys = trys+1;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
