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
    public partial class Print_Form : Form
    {
        Bitmap bmp;
        public Print_Form()
        {
            InitializeComponent();
        }

        private void Print_Form_Load(object sender, EventArgs e)
        {
            P_labelP1.Text = L1.play1.ToString();
            P_labelP2.Text = L1.play2.ToString();
            P_labelP3.Text = L1.play3.ToString();
            P_labelP4.Text = L1.play4.ToString();
            P_labelP5.Text = L1.play5.ToString();
            P_labelP6.Text = L1.play6.ToString();
            P_labelP7.Text = L1.play7.ToString();
            P_labelP8.Text = L1.play8.ToString();

            P_label2.Text = L1.ave.ToString();
            label13.Text = L4.price2.ToString();

            
            if(L4.checkvalue == true)
            {
                label11.Text = "true";
            }
            else
            {
                label11.Text = "false";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void Print_button_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
