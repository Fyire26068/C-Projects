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
        
        string diff;
        

       
        
        public Form1()
        {  
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            guessBttn.BackColor = Color.Gray;
            theNum = random.Next(1, 11);
            trys = 3;
            diff = "easy";
           BackColor = Color.LightSeaGreen;
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
            

            if (diff == "hard")
            {
                if (guessSpn.Value < theNum && trys > 0)
                {
                    highLbl.Visible = true;
                    trys = trys - 1;
                    guessAmLbl.Text = trys.ToString();
                    if (trys <= 0)
                    {
                        lossLbl.Visible = true;
                        theNumLbl.Text = theNum.ToString();
                        theNumLbl.Visible = true;
                        guessBttn.BackColor = Color.Red;

                    }
                }
                else if (guessSpn.Value > theNum && trys > 0)
                {
                    lowerLbl.Visible = true;
                    trys = trys - 1;
                    guessAmLbl.Text = trys.ToString();
                    if (trys <= 0)
                    {
                        lossLbl.Visible = true;
                        theNumLbl.Text = theNum.ToString();
                        theNumLbl.Visible = true;
                        guessBttn.BackColor = Color.Red;

                    }
                }
                else if (trys > 0)
                {
                    winLbl.Visible = true;
                    guessBttn.BackColor = Color.LightSeaGreen;
                }

            }
            else if(diff == "medium")
            {
                if (guessSpn.Value < theNum && trys > 0)
                {
                    highLbl.Visible = true;
                    trys = trys - 1;
                    guessAmLbl.Text = trys.ToString();
                    if (trys <= 0)
                    {
                        lossLbl.Visible = true;
                        theNumLbl.Text = theNum.ToString();
                        theNumLbl.Visible = true;
                        guessBttn.BackColor = Color.Red;

                    }
                }
                else if (guessSpn.Value > theNum && trys > 0)
                {
                    lowerLbl.Visible = true;
                    trys = trys - 1;
                    guessAmLbl.Text = trys.ToString();
                    if (trys <= 0)
                    {
                        lossLbl.Visible = true;
                        theNumLbl.Text = theNum.ToString();
                        theNumLbl.Visible = true;
                        guessBttn.BackColor = Color.Red;

                    }
                }
                else if (trys > 0)
                {
                    winLbl.Visible = true;
                    guessBttn.BackColor = Color.LightSeaGreen;
                }
            }
            else
            {
                if (guessSpn.Value < theNum && trys > 0)
                {
                    highLbl.Visible = true;
                    trys = trys - 1; 
                    guessAmLbl.Text = trys.ToString();
                    if (trys <= 0)
                    {
                        lossLbl.Visible = true;
                        theNumLbl.Text = theNum.ToString();
                        theNumLbl.Visible = true;
                        guessBttn.BackColor = Color.Red;

                    }
                }
                else if (guessSpn.Value > theNum && trys > 0)
                {
                    lowerLbl.Visible = true;
                    trys = trys - 1;
                    guessAmLbl.Text = trys.ToString();
                    if (trys <= 0)
                    {
                        lossLbl.Visible = true;
                        theNumLbl.Text = theNum.ToString();
                        theNumLbl.Visible = true;
                        guessBttn.BackColor = Color.Red;

                    }
                }
                else if (trys > 0)
                {
                    winLbl.Visible = true;
                    guessBttn.BackColor = Color.LightSeaGreen;
                }
            }                 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void hardRB_CheckedChanged(object sender, EventArgs e)
        {
            diff = "hard";//setting the difficulty settings
            guessAmLbl.Text = "10";
            theNum = random.Next(1, 11);
            trys = 10;
            guessSpn.Maximum = 100;
            pNumberLbl.Text = "1 - 100";   
           
            winLbl.Visible = false;//resetting game
            lowerLbl.Visible = false;
            highLbl.Visible = false;
            theNumLbl.Visible = false;
            lossLbl.Visible = false;
        }

        private void mediumRB_CheckedChanged(object sender, EventArgs e)
        {
            diff = "hard";//setting the difficulty settings
            guessAmLbl.Text = "5";
            theNum = random.Next(1, 51);
            trys = 5;
            guessSpn.Maximum = 50;
            pNumberLbl.Text = "1 - 50";
           
            winLbl.Visible = false;//resetting game
            lowerLbl.Visible = false;
            highLbl.Visible = false;
            theNumLbl.Visible = false;
            lossLbl.Visible = false;
        }

        private void easyRB_CheckedChanged(object sender, EventArgs e)
        {
            diff = "easy";//setting the difficulty settings
            guessAmLbl.Text = "3";
            theNum = random.Next(1, 101);
            trys = 3;
            guessSpn.Maximum = 10;
            pNumberLbl.Text = "1 - 10";
            
            guessBttn.BackColor = Color.Gray;
           
            winLbl.Visible = false;//resetting game
            lowerLbl.Visible = false;
            highLbl.Visible = false;
            theNumLbl.Visible = false;
            lossLbl.Visible = false;
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            guessBttn.BackColor = Color.Gray;
            theNum = random.Next(1, 11);
            trys = 3;
            diff = "easy";
            BackColor = Color.LightYellow;
        }
    }
}
