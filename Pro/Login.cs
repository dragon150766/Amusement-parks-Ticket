using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pro
{
    public partial class Login : Form
    {

        string filename = @"D:\ID\ID_PS.txt";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            L1 l1 = new L1();
            l1.ShowDialog();
            this.Close();
        }

        private void LoginButtom_Click(object sender, EventArgs e)
        {
            if( !File.Exists(filename))
            {
                C_or_F.Text = "File is invate";
            }
            else
            {
                StreamReader sr = new StreamReader(filename);
                string temp = "";
                while((temp = sr.ReadLine()) !=null)
                {
                    string[] data = temp.Split(',');
                    string ID = data[0];
                    string PS = data[1];
                    if(IDtextbox.Text == ID && Passwordtextbox.Text == PS)

                    {
                        C_or_F.Text = "Complete";
                        
                        L1.member += 1;
                        this.Hide();
                        L2 l2 = new L2();
                        l2.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        C_or_F.Text = "ID or Password is not wort";

                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
