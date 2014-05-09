namespace Metin_Sifreleme_with_mdi
{
    partial class frm_sifrele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_sifrelenecek = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSifrelenmis = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kes2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyala2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.progIslemDurumu = new System.Windows.Forms.ProgressBar();
            this.ctxOfficeIslemleri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wordeAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordtenAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.ctxOfficeIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sifrelenecek
            // 
            this.txt_sifrelenecek.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_sifrelenecek.ContextMenuStrip = this.contextMenuStrip1;
            this.txt_sifrelenecek.Location = new System.Drawing.Point(12, 12);
            this.txt_sifrelenecek.Multiline = true;
            this.txt_sifrelenecek.Name = "txt_sifrelenecek";
            this.txt_sifrelenecek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sifrelenecek.Size = new System.Drawing.Size(450, 500);
            this.txt_sifrelenecek.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapistirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Enabled = false;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Enabled = false;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapistirToolStripMenuItem
            // 
            this.yapistirToolStripMenuItem.Enabled = false;
            this.yapistirToolStripMenuItem.Name = "yapistirToolStripMenuItem";
            this.yapistirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yapistirToolStripMenuItem.Text = "Yapıştır";
            this.yapistirToolStripMenuItem.Click += new System.EventHandler(this.yapistirToolStripMenuItem_Click);
            // 
            // txtSifrelenmis
            // 
            this.txtSifrelenmis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSifrelenmis.ContextMenuStrip = this.contextMenuStrip2;
            this.txtSifrelenmis.Location = new System.Drawing.Point(532, 12);
            this.txtSifrelenmis.Multiline = true;
            this.txtSifrelenmis.Name = "txtSifrelenmis";
            this.txtSifrelenmis.ReadOnly = true;
            this.txtSifrelenmis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSifrelenmis.Size = new System.Drawing.Size(450, 500);
            this.txtSifrelenmis.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kes2ToolStripMenuItem1,
            this.kopyala2ToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 48);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // kes2ToolStripMenuItem1
            // 
            this.kes2ToolStripMenuItem1.Enabled = false;
            this.kes2ToolStripMenuItem1.Name = "kes2ToolStripMenuItem1";
            this.kes2ToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.kes2ToolStripMenuItem1.Text = "Kes";
            this.kes2ToolStripMenuItem1.Click += new System.EventHandler(this.kes2ToolStripMenuItem1_Click);
            // 
            // kopyala2ToolStripMenuItem1
            // 
            this.kopyala2ToolStripMenuItem1.Enabled = false;
            this.kopyala2ToolStripMenuItem1.Name = "kopyala2ToolStripMenuItem1";
            this.kopyala2ToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.kopyala2ToolStripMenuItem1.Text = "Kopyala";
            this.kopyala2ToolStripMenuItem1.Click += new System.EventHandler(this.kopyala2ToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(468, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Şifrele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(465, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anahtar";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAnahtar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnahtar.Location = new System.Drawing.Point(465, 65);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.ReadOnly = true;
            this.txtAnahtar.Size = new System.Drawing.Size(58, 20);
            this.txtAnahtar.TabIndex = 6;
            this.txtAnahtar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progIslemDurumu
            // 
            this.progIslemDurumu.Location = new System.Drawing.Point(31, 518);
            this.progIslemDurumu.Name = "progIslemDurumu";
            this.progIslemDurumu.Size = new System.Drawing.Size(930, 23);
            this.progIslemDurumu.TabIndex = 7;
            // 
            // ctxOfficeIslemleri
            // 
            this.ctxOfficeIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordeAktarToolStripMenuItem,
            this.wordtenAlToolStripMenuItem});
            this.ctxOfficeIslemleri.Name = "ctxOfficeIslemleri";
            this.ctxOfficeIslemleri.Size = new System.Drawing.Size(144, 48);
            // 
            // wordeAktarToolStripMenuItem
            // 
            this.wordeAktarToolStripMenuItem.Name = "wordeAktarToolStripMenuItem";
            this.wordeAktarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.wordeAktarToolStripMenuItem.Text = "Word\'e Aktar";
            this.wordeAktarToolStripMenuItem.Click += new System.EventHandler(this.wordeAktarToolStripMenuItem_Click);
            // 
            // wordtenAlToolStripMenuItem
            // 
            this.wordtenAlToolStripMenuItem.Name = "wordtenAlToolStripMenuItem";
            this.wordtenAlToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.wordtenAlToolStripMenuItem.Text = "Word\'ten Al";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(468, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Font";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_sifrele
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 545);
            this.ContextMenuStrip = this.ctxOfficeIslemleri;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progIslemDurumu);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSifrelenmis);
            this.Controls.Add(this.txt_sifrelenecek);
            this.Name = "frm_sifrele";
            this.Text = "Şifrele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_sifrele_FormClosing);
            this.Load += new System.EventHandler(this.frm_sifrele_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ctxOfficeIslemleri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sifrelenecek;
        private System.Windows.Forms.TextBox txtSifrelenmis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.ProgressBar progIslemDurumu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem kes2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyala2ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip ctxOfficeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem wordeAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordtenAlToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}