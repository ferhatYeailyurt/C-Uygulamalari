using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KoltukDoldur(60, 7);
        }

        void KoltukDoldur(int koltukSayisi,int sira)
        {
            for (int i = 1; i <= koltukSayisi; i++)
            {
                Button koltuk = new Button();

                koltuk.Width = 40;
                koltuk.Height = 40;

                if (i % 4 == 3)
                    koltuk.Margin = new Padding(40, 0, 0, 0);

                else
                    koltuk.Margin = new Padding(0);
         
                flowLayoutPanel1.Controls.Add(koltuk); 
            }

        }
    }
}
