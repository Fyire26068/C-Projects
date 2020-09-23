using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fig_Clicker
{
   
    public partial class Form1 : Form
    {
        int figNewtons;
        public Form1()
        {
            InitializeComponent();

        }



        private void figClickerBttn_Click(object sender, EventArgs e)//fig newton button click main
        {
            figAmountSpin.Value = figAmountSpin.Value + 1 + autoClickerSpin.Value;
            unlock1PrBar.Value = unlock1PrBar.Value + 1;
            if (unlock1PrBar.Value == 100)//checking if fig newton has been clicked 100 times
            {
                unlock1PrBar.Visible = false;//unlocking auto clicker
                autoClickerBuyBttn.Visible = true;
                hideLbl.Visible = true;
                autoClickerSpin.Visible = true;
                autoClickerLbl.Visible = true;
            };
            if (unlock1PrBar.Visible == false)
            {
                unlock1PrBar.Value = 0;//making progress bar 1 useless
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void autoClickerBuyBttn_Click(object sender, EventArgs e)//auto clicker buy function
        {
            if (figAmountSpin.Value >= 100)
            {
                figAmountSpin.Value = figAmountSpin.Value - 100;
                autoClickerSpin.Value = autoClickerSpin.Value + 1;//auto clicker amount
            }
            else;
            
       
        }
        
    }
}
