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
    public partial class frm_secenekler : Form
    {
        public frm_secenekler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_sifrele sifrele = new frm_sifrele();
            foreach (Form item in Form1.ActiveForm.MdiChildren)
            {
                if (item.Text.CompareTo(sifrele.Text) == 0)
                {
                    item.Activate();
                    return;
                }
            }
            sifrele.MdiParent = Form1.ActiveForm;
            sifrele.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_cozumle cozumle = new frm_cozumle();
            foreach (Form item in Form1.ActiveForm.MdiChildren)
            {
                if (item.Text.CompareTo(cozumle.Text) == 0)
                {
                    item.Activate();
                    return;
                }
            }
            cozumle.MdiParent = Form1.ActiveForm;
            cozumle.Show();
        }
    }
}
