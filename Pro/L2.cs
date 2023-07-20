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
    public partial class L2 : Form
    {
        public L2()
        {
            InitializeComponent();
        }

        private void C_1_Click(object sender, EventArgs e)
        {
            L1.play1 = L1.play1 + 1;
            textBoxC1.Text = L1.play1.ToString();
        }

        private void label1C1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void price_1_Click(object sender, EventArgs e)
        {

        }

        private void L2_Load(object sender, EventArgs e)
        {
            textBoxC1.Text = L1.play1.ToString();
            textBoxC2.Text = L1.play2.ToString();
            textBoxC3.Text = L1.play3.ToString();
            textBoxC4.Text = L1.play4.ToString();

        }

        private void C_2_Click(object sender, EventArgs e)
        {
            L1.play2 += 1;
            
            textBoxC2.Text = L1.play2.ToString();
        }

        private void C_3_Click(object sender, EventArgs e)
        {
            L1.play3 += 1;
            textBoxC3.Text = L1.play3.ToString();
        }

        private void C_4_Click(object sender, EventArgs e)
        {
            L1.play4 += 1;
            textBoxC4.Text = L1.play4.ToString();
        }

        private void Next_L301_Click(object sender, EventArgs e)
        {
            this.Hide();
            L33 l3 = new L33();
            l3.ShowDialog();
            
            this.Close();
        }

        private void Buy1_Click(object sender, EventArgs e)
        {
            this.Hide();
            L4 l5 = new L4();
            l5.ShowDialog();
            this.Close();
        }

        private void NC_B1_Click(object sender, EventArgs e)
        {
            if (L1.play1 > 0)
            {
                L1.play1 -= 1;
                textBoxC1.Text = L1.play1.ToString();
            }
        }

        private void NC_B2_Click(object sender, EventArgs e)
        {
            if (L1.play2 > 0)
            {
                L1.play2 -= 1;
                textBoxC2.Text = L1.play2.ToString();
            }
        }

        private void NC_B3_Click(object sender, EventArgs e)
        {
            if (L1.play3 > 0)
            {
                L1.play3 -= 1;
                textBoxC3.Text = L1.play3.ToString();
            }
        }

        private void NC_B4_Click(object sender, EventArgs e)
        {
            if (L1.play4 > 0)
            {
                L1.play4 -= 1;
                textBoxC4.Text = L1.play4.ToString();
            }
        }

        private void P_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            img1 img1 = new img1();
            img1.ShowDialog();
            this.Close();
        }

        private void P_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            img2 img2 = new img2();
            img2.ShowDialog();
            this.Close();
        }

        private void P_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            img3 img3 = new img3();
            img3.ShowDialog();
            this.Close();
        }

        private void P_4_Click(object sender, EventArgs e)
        {
            this.Hide();
            img4 img4 = new img4();
            img4.ShowDialog();
            this.Close();
        }
    }
}
