using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro
{
    public partial class L1 : Form
    {
        public static int member = 0, play1 = 0, play2 = 0, play3 = 0, play4 = 0, play5 = 0, play6 = 0, play7 = 0, play8 = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static double  price = 0, ave = 0, playVal1 = 120, playVal2 = 80, playVal3 = 70, playVal4 = 75, playVal5 = 50, playVal6 = 90, playVal7 = 150, playVal8 = 300;
        public L1()
        {
            
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
           
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            L2 l2 = new L2();
            l2.ShowDialog();
            this.Close();
        }
        

       
    }
}
