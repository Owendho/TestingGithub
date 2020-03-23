using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Tomat, Agurk, Estimation, Mælk, Ost;

        private void btnFive_Click(object sender, EventArgs e)
        {
            Ost = 20;
            txtBox1.Text = "Ost 20 kr.";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            Estimation = Agurk + Tomat + Ost + Mælk;
            txtBox1.Text = Estimation.ToString() + " kr.";


        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Mælk = 14;
            txtBox1.Text = "Mælk 14 kr.";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Agurk = 10;
            txtBox1.Text = "Agurk 10 kr.";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            Tomat = 15;
            txtBox1.Text = "Tomat 15 kr.";

        }






    }
}
