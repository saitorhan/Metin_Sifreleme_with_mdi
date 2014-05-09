namespace Metin_Sifreleme_with_mdi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metinİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cozumleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metinİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // metinİşlemleriToolStripMenuItem
            // 
            this.metinİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cozumleToolStripMenuItem,
            this.sifreleToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.metinİşlemleriToolStripMenuItem.Name = "metinİşlemleriToolStripMenuItem";
            this.metinİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.metinİşlemleriToolStripMenuItem.Text = "İşlemler";
            // 
            // cozumleToolStripMenuItem
            // 
            this.cozumleToolStripMenuItem.Name = "cozumleToolStripMenuItem";
            this.cozumleToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.cozumleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.cozumleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cozumleToolStripMenuItem.Text = "Çözümle";
            this.cozumleToolStripMenuItem.Click += new System.EventHandler(this.cozumleToolStripMenuItem_Click);
            // 
            // sifreleToolStripMenuItem
            // 
            this.sifreleToolStripMenuItem.Name = "sifreleToolStripMenuItem";
            this.sifreleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.sifreleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sifreleToolStripMenuItem.Text = "Şifrele";
            this.sifreleToolStripMenuItem.Click += new System.EventHandler(this.sifreleToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 645);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metin Şifreleme ve Çözümleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem metinİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cozumleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;

    }
}

