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
    public partial class L33 : Form
    {
        public L33()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBoxC5.Text = L1.play5.ToString();
            textBoxC6.Text = L1.play6.ToString();
            textBoxC7.Text = L1.play7.ToString();
            textBoxC8.Text = L1.play8.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            L1.play5 += 1;
            textBoxC5.Text = L1.play5.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            L1.play6 += 1;
            textBoxC6.Text = L1.play6.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            L1.play7 += 1;
            textBoxC7.Text = L1.play7.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            L1.play8 += 1;
            textBoxC8.Text = L1.play8.ToString();
        }

        private void Back_L201_Click(object sender, EventArgs e)
        {
            this.Hide();
            L2 l2 = new L2();
            l2.ShowDialog();
            this.Close();
        
        }

        private void Buy2_Click(object sender, EventArgs e)
        {
            this.Hide();
            L4 l5 = new L4();
            l5.ShowDialog();
            this.Close();
        }

        private void price_8_Click(object sender, EventArgs e)
        {

        }

        private void NC_B8_Click(object sender, EventArgs e)
        {
            if (L1.play8 > 0)
            {
                L1.play8 -= 1;
                textBoxC8.Text = L1.play8.ToString();
            }
        }

        private void NC_B5_Click(object sender, EventArgs e)
        {
            if (L1.play5 > 0)
            {
                L1.play5 -= 1;
                textBoxC5.Text = L1.play5.ToString();
            }
        }

        private void NC_B6_Click(object sender, EventArgs e)
        {
            if (L1.play6 > 0)
            {
                L1.play6 -= 1;
                textBoxC6.Text = L1.play6.ToString();
            }
        }

        private void NC_B7_Click(object sender, EventArgs e)
        {
            if (L1.play7 > 0)
            {
                L1.play7 -= 1;
                textBoxC7.Text = L1.play7.ToString();
            }
        }

        private void P_5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void P_6_Click(object sender, EventArgs e)
        {
            this.Hide();
            img6 img6 = new img6();
            img6.ShowDialog();
            this.Close();
        }

        private void P_7_Click(object sender, EventArgs e)
        {
            this.Hide();
            img7 img7 = new img7();
            img7.ShowDialog();
            this.Close();
        }
    }
}
