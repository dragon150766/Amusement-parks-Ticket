using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pro
{
    public partial class L4 : Form
    {

        public static bool check = false, checkvalue = false;
        public static double price2 = 0;
        
        double oldprice = 0;
        public L4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void L5_Load(object sender, EventArgs e)
        {
            labelP1.Text = L1.play1.ToString();
            labelP2.Text = L1.play2.ToString();
            labelP3.Text = L1.play3.ToString();
            labelP4.Text = L1.play4.ToString();
            labelP5.Text = L1.play5.ToString();
            labelP6.Text = L1.play6.ToString();
            labelP7.Text = L1.play7.ToString();
            labelP8.Text = L1.play8.ToString();
            

            L1.ave = L1.play1 + L1.play2 + L1.play3 + L1.play4 + L1.play5 + L1.play6 + L1.play7 + L1.play8;
            label2.Text = L1.ave.ToString();

            L1.price = (L1.play1 * L1.playVal1) + (L1.play2 * L1.playVal2) + (L1.play3 * L1.playVal3) + (L1.play4 * L1.playVal4) + (L1.play5 * L1.playVal5)
                + (L1.play6 * L1.playVal6) + (L1.play7 * L1.playVal7) + (L1.play8 * L1.playVal8);
            if (L1.member == 1)
            {
                L1.price = L1.price - (L1.price * 0.20);
            }

            oldprice = L1.price;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkvalue == false)
            {
                checkvalue = true;
                
            }
            else
            {
                checkvalue = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                
                L1.price = L1.price + (L1.price * 0.40);
                

            }

            label4.Text = L1.price.ToString();
            price2 = L1.price;
            L1.price = oldprice;
                
          
            check = true;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            L33 l3 = new L33();
            l3.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void Print_button_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                
                Print_Form form = new Print_Form();
                form.ShowDialog();
            }
        }

        private void labelP1_Click(object sender, EventArgs e)
        {

        }
    }
}
