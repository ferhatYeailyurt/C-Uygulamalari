﻿using System;
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
            KoltukDoldur(70, 6);
        }

        void KoltukDoldur(int koltukSayisi,int sira)
        {
            for (int i = 0; i <= koltukSayisi; i++)
            {
                Button koltuk = new Button();

                koltuk.Width = 50;
                koltuk.Height = 50;

                koltuk.Margin = new Padding(0);
                flowLayoutPanel1.Controls.Add(koltuk); 
            }

        }
    }
}
