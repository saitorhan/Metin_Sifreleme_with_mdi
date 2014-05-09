using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Sifreleme_with_mdi
{
    public partial class frm_sifrele : Form
    {
        static public bool form_acik = false;
        public frm_sifrele()
        {
            InitializeComponent();
        }

        private void frm_sifrele_Load(object sender, EventArgs e)
        {
            this.Size = new Size(547, 583);
        }

        private void frm_sifrele_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            int dakika = DateTime.Now.Minute;
            int saniye = DateTime.Now.Second;
            int anahtar = dakika + saniye;
            this.WindowState = FormWindowState.Maximized;
            progIslemDurumu.Maximum = txt_sifrelenecek.Text.Length;
            progIslemDurumu.Value = 0;
            txtSifrelenmis.Text = "";
            txtAnahtar.Text=dakika+"-"+saniye;
            string sifrelenecek_metin = txt_sifrelenecek.Text;
            DateTime baslama_zamani = DateTime.Now;
            for (int i = 0; i < sifrelenecek_metin.Length; i++)
            {
                int sifrelenmis_harf_degeri = Convert.ToInt32(sifrelenecek_metin[i]) + anahtar;
                if (sifrelenmis_harf_degeri<100)
                {
                    txtSifrelenmis.Text += "0" + sifrelenmis_harf_degeri;
                }
                else
                {
                    txtSifrelenmis.Text += sifrelenmis_harf_degeri.ToString();
                }
                progIslemDurumu.Value++;
            }
            DialogResult worde_kayit = MessageBox.Show("Şifreleme başarı ile sonuçlandı. Word'e kaydetmek istiyor musunuz?\nToplam süre: " + (DateTime.Now - baslama_zamani).TotalSeconds.ToString("#.###") + " Saniye", "Sonuç:", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (worde_kayit == DialogResult.Yes)
            {
                WordeKayit_Metod();
            }
            this.Enabled = true;
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_sifrelenecek.Copy();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_sifrelenecek.Paste();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_sifrelenecek.Cut();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (txt_sifrelenecek.SelectedText.Length>0)
            {
                kesToolStripMenuItem.Enabled = true;
                kopyalaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kesToolStripMenuItem.Enabled = false;
                kopyalaToolStripMenuItem.Enabled = false;
            }
            IDataObject buffer_data = Clipboard.GetDataObject();
            if (buffer_data.GetDataPresent(DataFormats.Text))
            {
                yapistirToolStripMenuItem.Enabled = true;
            }
            else
            {
                yapistirToolStripMenuItem.Enabled = false;
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (txtSifrelenmis.SelectedText.Length==0)
            {
                kes2ToolStripMenuItem1.Enabled = false;
                kopyala2ToolStripMenuItem1.Enabled = false;
            }
            else
            {
                kes2ToolStripMenuItem1.Enabled = true;
                kopyala2ToolStripMenuItem1.Enabled = true;
            }
        }

        private void kes2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtSifrelenmis.Cut();
        }

        private void kopyala2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtSifrelenmis.Copy();
        }

        private void wordeAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordeKayit_Metod();
        }

        void WordeKayit_Metod()
        {
            SaveFileDialog dosya_konumu = new SaveFileDialog();
            dosya_konumu.Filter = "Word Dosyası | *.doc";
            object oMissing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document WordDoc = new Microsoft.Office.Interop.Word.Document();
            WordDoc = Word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            dosya_konumu.ShowDialog();
            if (dosya_konumu.CheckPathExists)
            {
                DialogResult sonuc = MessageBox.Show("Devam ederseniz var olan dosyanızın içeriği değiştirilecek. Devam etmek istiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.No)
                {
                    return;
                }
            }
            string kaydedilecek_konum = dosya_konumu.FileName;
            WordDoc.SaveAs(kaydedilecek_konum, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref                             oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref                             oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            Microsoft.Office.Interop.Word.Paragraph oPara2;
            oPara2 = WordDoc.Paragraphs.Add(ref oMissing);
            oPara2.Range.Text = txtSifrelenmis.Text + "\n-------------------------------------------\nAnahtar değerleri: " + txtAnahtar.Text;
            oPara2.Range.InsertParagraphAfter();
            Word.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fontu_degistir = new FontDialog();
            DialogResult sonuc = fontu_degistir.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                txt_sifrelenecek.Font = fontu_degistir.Font;
                txtSifrelenmis.Font = fontu_degistir.Font;
            }
        }

    }
}
