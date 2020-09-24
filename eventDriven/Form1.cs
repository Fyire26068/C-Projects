using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventDriven
{
    public partial class Form1 : Form
    {
        String fname;
        String mname;
        String lname;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.PaleTurquoise;
            Console.WriteLine(fname + " " + mname + " " + lname);
            MessageBox.Show(fname + " " + mname + " " + lname);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Orchid;
            MessageBox.Show("Main Form loaded");
        }

        private void firstnameLbl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Imagine clicking the label!");
            MessageBox.Show("First name label clicked!");
        }

        private void middlenameLbl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("What an idiot.");
            MessageBox.Show("Middle name label clicked?");
        }

        private void lastnameLbl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Really, Again?");
            MessageBox.Show("Last name label clicked.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            MessageBox.Show("First name textbox changed to : " + fname);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            mname = textBox2.Text;
            MessageBox.Show("Middle name textbox changed to : " + mname);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lname = textBox3.Text;
            MessageBox.Show("Last name textbox changed to : " + lname);
        }
    }
}
