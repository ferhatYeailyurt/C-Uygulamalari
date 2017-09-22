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
            //koltuk adeti ile orta kapının yerini paremetre olarak gönderdik
            KoltukDoldur(60, 7);
        }
        String str;
        void KoltukDoldur(int koltukSayisi, int sira)
        {
            //formu temizleyip yeniden koltukları sıralamak için.
            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= koltukSayisi; i++)
            {
                Button koltuk = new Button();
                //sağ click özelliği eklendi.
                koltuk.ContextMenuStrip = contextMenuStrip1;
                koltuk.MouseDown += Koltuk_MouseDown;
                koltuk.Width = 40;
                koltuk.Height = 40;
                koltuk.Text = i.ToString();
                str = i.ToString();

                if (sira * 4 - 2 == i)
                {
                    koltuk.Margin = new Padding(0, 0, 120, 0);
                }
                else if (i % 4 == 3 && i < (sira - 1) * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);

                else if (i % 4 == 1 && i > (sira) * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);
                else
                    koltuk.Margin = new Padding(0);

                flowLayoutPanel1.Controls.Add(koltuk);
            }

        }

        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = (Button)sender;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedItem.ToString())
            {//sefer saatine göre araç koltuk sayısını ve kapı yerine belirler
                case "07:00":
                    KoltukDoldur(46, 7);
                    break;
                case "09:00":
                    KoltukDoldur(42, 6);
                    break;
                case "13:00":
                    KoltukDoldur(50, 8);
                    break;
                case "20:00":
                    KoltukDoldur(54, 8);
                    break;
            }
        }

        private void bayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kirala(Color.Blue);

        }

        private void Kirala(Color renk)
        {
            KayitFormu kayitformu = new KayitFormu();
            DialogResult sonuc = kayitformu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem satir = new ListViewItem();

                satir.Text = tiklanan.Text;
                satir.SubItems.Add(kayitformu.txtAdi.Text);
                satir.SubItems.Add(kayitformu.txtSoyad.Text);
                satir.SubItems.Add(kayitformu.txtTelefon.Text);
                satir.SubItems.Add(toolStripComboBox1.SelectedItem.ToString());
                listView1.Items.Add(satir);
                tiklanan.BackColor = renk;
                    
        }
    }
        private void bayanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kirala(Color.Pink);
        }

      
    }
}
