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
   
    public partial class FigClicker : Form
    {
        int figNewtons;
        float autoClickers;
        public FigClicker()
        {
            InitializeComponent();
            

        }



        private void figClickerBttn_Click(object sender, EventArgs e)//fig newton button click main
        {
            figAmountSpin.Value = figAmountSpin.Value + 1;
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
            };
            BackColor = Color.Green;
            //Thread.Sleep(100);
            BackColor = Color.White;

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
                autoClickerSpin.Value = autoClickers;

            }
            else;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class AutoClicker
    {
        public void autoClicker()
        {
            float figNewtons;
            float autoClickers = FigClicker.autoClickerSpin.Value;
            
            
            if (autoClickerSpin >= 1)
            {
                figNewtons = figNewtons + autoClickerSpin;
                Thread.Sleep(1000);
            };
        }

        
    }
}
