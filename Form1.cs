using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mustafakoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m;
            try
            {
                m = (int.Parse(patlayicimadde.Text));
                if (m>50)
                {
                    MessageBox.Show("Tek dirsekli yol yapılmalıdır.");
                }
                else if (m<50)
                {
                    MessageBox.Show("Çift dirsekli yol yapılmalıdır.");
                }
            }
            catch
            {
                ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k;
            try
            {
                k = (int.Parse(patlayicimaddedepo.Text));
                if (k>8&&k<30)
                {
                    MessageBox.Show("Ortam sıcaklığı uygundur.");
                }
                else if (k>30)
                {
                     MessageBox.Show("Soğutma işlemleri uygulanmalıdır.");
                }
                else if (k<8)
                {
                    MessageBox.Show("ısıtma işlemleri uygulanmalıdır.");
                }
            }
            catch 
            {
                ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mustafa;
            try
            {
                mustafa = (int.Parse(havadakico.Text));
                if (mustafa>50)
                {
                    MessageBox.Show("Çalışma durdurulmalıdır.");
                }
                else if (mustafa<50)
                {
                    MessageBox.Show("Kontrol düzeyinde çalışılabilir.");
                }
            }
            catch
            {
                ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int isim;
            try
            {
                isim = (int.Parse(havadakihs.Text));
                if (isim>20)
                {
                    MessageBox.Show("Çalışma durdurulmalıdır.");
                }
                else if (isim<20)
                {
                    MessageBox.Show("Çalışmaya kontrollü şekilde devam edilmelidir.");
                }
            }
            catch
            {
                ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double koca;
            try
            {
                koca = double.Parse(tasima.Text);
                if (koca<=0.03)
                {
                    MessageBox.Show("Lokomatifler çalıştırılabilir.");
                }
                else
                {
                    MessageBox.Show("Lokomatifler çalıştırılamaz. Sürekli ölçümler ile gaz seviyesi düşürülmelidir.");
                }
            }
            catch 
            {
           ;
            }
        }
    }
}
