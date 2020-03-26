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


        /*Vælger at bruge classes, for at undgå at lave en masse variabler. Siden vores program er et indkøbskurv er de nemmere at 
         * repæsentere items, som objekter.
         */
        Milk milk1 = new Milk();
       

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
            //Ved at lave items om til objekter kan vi give dem mere information
            //Mælk = 14;
            //txtBox1.Text = "Mælk 14 kr.";
            milk1.name = "Letmælk";
            milk1.size = 1;
            milk1.fat = 1.5f;
            milk1.price = 14f;

            txtBox1.Text = milk1.fat.ToString() + "";


        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            //Agurk = 10;
            //txtBox1.Text = "Agurk 10 kr.";

            Vegetables agurk = new Vegetables();
            agurk.name = "Øko Agurk";
            

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            Tomat = 15;
            txtBox1.Text = "Tomat 15 kr.";

        }






    }
}
