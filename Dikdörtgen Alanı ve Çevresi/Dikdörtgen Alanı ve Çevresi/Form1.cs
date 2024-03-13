using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_Alanı_ve_Çevresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buton_Click(object sender, EventArgs e)
        {
            try
            {
                double uzunkenar = Convert.ToDouble(uzun.Text);
                double kisakenar = Convert.ToDouble(kisa.Text);
                double alanhesap, cevrehesap;
                if (uzunkenar <= 0 || kisakenar <= 0)
                {
                    MessageBox.Show("Negatif Değer Girmeyiniz.");  
                }
                else if (uzunkenar > 0 && kisakenar > 0)
                {
                    if (alan.Checked)
                    {
                        alanhesap = uzunkenar * kisakenar;
                        label3.Text = "Sonuç : " + alanhesap;
                    }
                    else if (cevre.Checked)
                    {
                        cevrehesap = (uzunkenar + kisakenar) * 2;
                        label3.Text = "Sonuç : " + cevrehesap;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilgileri Doğru Girdiğinizden Emin Olunuz.");
            }
            
        }

        private void uzun_TextChanged(object sender, EventArgs e)
        {

        }

        private void alan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
