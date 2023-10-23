using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongüsü_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            lbSayılar.Items.Clear();
            int sayi = Convert.ToInt32(txtAd.Text);
            for(int i = 1; i < sayi; i++)
            {
                lbSayılar.Items.Add(i);
            }
        }
    }
}
