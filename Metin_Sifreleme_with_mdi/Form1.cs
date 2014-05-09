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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sifreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sifrele sifrele = new frm_sifrele();
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text.CompareTo(sifrele.Text)==0)
                {
                    item.Activate();
                    return;
                }
            }
            sifrele.MdiParent = this;
            sifrele.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_secenekler secenekler = new frm_secenekler();
            secenekler.MdiParent = this;
            secenekler.Show();
        }

        private void cozumleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_cozumle cozumle = new frm_cozumle();
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text.CompareTo(cozumle.Text) == 0)
                {
                    item.Activate();
                    return;
                }
            }
            cozumle.MdiParent = this;
            cozumle.Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
