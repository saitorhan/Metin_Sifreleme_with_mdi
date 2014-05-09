using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Sifreleme_with_mdi
{
    public partial class frm_cozumle : Form
    {
        static public bool form_acik = false;
        public frm_cozumle()
        {
            InitializeComponent();
        }

        private void frm_cozumle_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik = false;
        }

        private void frm_cozumle_Load(object sender, EventArgs e)
        {
            this.Size = new Size(547, 583);
        }

        bool test_et(int anahtar)
        {
            int boyut = txt_cozumlenecek.Text.Length;
            string cozulecek_mesaj;
            if ((boyut/3.0-boyut/3)>0)
            {
                MessageBox.Show("Çözülecek şifrede eksik karakter bulunmaktadır.\nLütfen kontrol edip tekrar deneyiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                int a, adim=boyut/3;
                cozulecek_mesaj=txt_cozumlenecek.Text;
                for (int i = 0; i < adim; i++)
                {
                    a = int.Parse(cozulecek_mesaj.Substring(3 * i, 3)) - anahtar;
                    if (a<=0)
                    {
                        MessageBox.Show("Çözülecek şifrede rakam dışında karakter bulunamaz veya değerler anahtarla uyumsuz olamaz.\nLütfen kontrol edip tekrar deneyiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Çözülecek şifrede rakam dışında karakter bulunamaz veya değerler anahtarla uyumsuz olamaz.\nLütfen kontrol edip tekrar deneyiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anahtar=0;
            try
            {
                 anahtar = int.Parse(mskAnahtar.Text.Substring(0, 2)) + int.Parse(mskAnahtar.Text.Substring(3, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Anahtar değerini kontrol ediniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!test_et(anahtar))
            {
                return;
            }
            this.Enabled = false;
            progIslemDurumu.Value = 0;
            txtcozumlenmis.Text = "";
            this.WindowState = FormWindowState.Maximized;
            int karakter_sayisi = txt_cozumlenecek.Text.Length / 3;
            progIslemDurumu.Maximum = karakter_sayisi;
            string cozumlenecek_mesaj = txt_cozumlenecek.Text;
            //string[] degerler = new string[karakter_sayisi];
            char[] cozumlenmis_deger = new char[karakter_sayisi];
            for (int i = 0; i < karakter_sayisi; i++)
            {
                txtcozumlenmis.Text += Convert.ToChar(int.Parse(cozumlenecek_mesaj.Substring(3 * i, 3)) - anahtar);
                progIslemDurumu.Value++;
            }
            this.Enabled = true;

        }
    }
}
