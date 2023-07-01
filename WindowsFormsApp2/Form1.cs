using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void kontrol()
        {
            if (TxtDöner.Text == "")
            {
                TxtDöner.Text = "0";
            }
            if (TxtKahve.Text == "")
            {
                TxtKahve.Text = "0";
            }
            if (TxtKraker.Text == "")
            {
                TxtKraker.Text = "0";
            }
            if(TxtSu.Text== "")
            {
                TxtSu.Text = "0";
            }
            if(TxtÇay.Text== "")
            {
                TxtÇay.Text = "0";
            }
            if (TxtÇiko.Text == "")
            {
                TxtÇiko.Text = "0";
            }
        }
        double kasatutar = 0;
        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol();
            int döner, çay, çikolata, kraker, su, kahve;
            double toplam;
            döner = Convert.ToInt16(TxtDöner.Text);
            çay = Convert.ToInt16(TxtÇay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            çikolata = Convert.ToInt16(TxtÇiko.Text);
            kraker = Convert.ToInt16(TxtKraker.Text);
            kahve = Convert.ToInt16(TxtKahve.Text);
            toplam = döner * 20 + çay * 5 + su * 2 + çikolata * 3 + kraker * 3 + kahve * 3.5;
            lblToplam.Text = toplam.ToString();
            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDöner.Text ="";
            TxtKahve.Text = "";
            TxtKraker.Text = "";
            TxtSu.Text = "";
            TxtÇay.Text = "";
            TxtÇiko.Text = "";
            lblToplam.Text = "0 TL";
            TxtDöner.Focus();
        }
    }
}
