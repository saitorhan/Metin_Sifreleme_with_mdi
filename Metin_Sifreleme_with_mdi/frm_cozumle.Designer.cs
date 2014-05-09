namespace Metin_Sifreleme_with_mdi
{
    partial class frm_cozumle
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcozumlenmis = new System.Windows.Forms.TextBox();
            this.txt_cozumlenecek = new System.Windows.Forms.TextBox();
            this.mskAnahtar = new System.Windows.Forms.MaskedTextBox();
            this.progIslemDurumu = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(465, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Anahtar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(468, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Çözümle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcozumlenmis
            // 
            this.txtcozumlenmis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtcozumlenmis.Location = new System.Drawing.Point(532, 12);
            this.txtcozumlenmis.Multiline = true;
            this.txtcozumlenmis.Name = "txtcozumlenmis";
            this.txtcozumlenmis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcozumlenmis.Size = new System.Drawing.Size(450, 500);
            this.txtcozumlenmis.TabIndex = 8;
            // 
            // txt_cozumlenecek
            // 
            this.txt_cozumlenecek.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_cozumlenecek.Location = new System.Drawing.Point(12, 12);
            this.txt_cozumlenecek.Multiline = true;
            this.txt_cozumlenecek.Name = "txt_cozumlenecek";
            this.txt_cozumlenecek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_cozumlenecek.Size = new System.Drawing.Size(450, 500);
            this.txt_cozumlenecek.TabIndex = 7;
            // 
            // mskAnahtar
            // 
            this.mskAnahtar.Location = new System.Drawing.Point(468, 65);
            this.mskAnahtar.Mask = "00-00";
            this.mskAnahtar.Name = "mskAnahtar";
            this.mskAnahtar.Size = new System.Drawing.Size(58, 20);
            this.mskAnahtar.TabIndex = 11;
            this.mskAnahtar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progIslemDurumu
            // 
            this.progIslemDurumu.Location = new System.Drawing.Point(21, 528);
            this.progIslemDurumu.Name = "progIslemDurumu";
            this.progIslemDurumu.Size = new System.Drawing.Size(930, 23);
            this.progIslemDurumu.TabIndex = 12;
            // 
            // frm_cozumle
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 545);
            this.Controls.Add(this.progIslemDurumu);
            this.Controls.Add(this.mskAnahtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcozumlenmis);
            this.Controls.Add(this.txt_cozumlenecek);
            this.Name = "frm_cozumle";
            this.Text = "Çözümle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_cozumle_FormClosing);
            this.Load += new System.EventHandler(this.frm_cozumle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcozumlenmis;
        private System.Windows.Forms.TextBox txt_cozumlenecek;
        private System.Windows.Forms.MaskedTextBox mskAnahtar;
        private System.Windows.Forms.ProgressBar progIslemDurumu;
    }
}