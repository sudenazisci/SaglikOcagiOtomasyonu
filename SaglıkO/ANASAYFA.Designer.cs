namespace SaglıkO
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            referanslarToolStripMenuItem = new ToolStripMenuItem();
            poliklinikTanıtmaToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıTanıtmaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            hastaKabulToolStripMenuItem = new ToolStripMenuItem();
            hastaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            raporToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { referanslarToolStripMenuItem, hastaKabulToolStripMenuItem, raporlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(835, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // referanslarToolStripMenuItem
            // 
            referanslarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poliklinikTanıtmaToolStripMenuItem, kullanıcıTanıtmaToolStripMenuItem, çıkışToolStripMenuItem });
            referanslarToolStripMenuItem.Name = "referanslarToolStripMenuItem";
            referanslarToolStripMenuItem.Size = new Size(114, 29);
            referanslarToolStripMenuItem.Text = "Referanslar";
            // 
            // poliklinikTanıtmaToolStripMenuItem
            // 
            poliklinikTanıtmaToolStripMenuItem.Name = "poliklinikTanıtmaToolStripMenuItem";
            poliklinikTanıtmaToolStripMenuItem.Size = new Size(248, 34);
            poliklinikTanıtmaToolStripMenuItem.Text = "Poliklinik Tanıtma";
            poliklinikTanıtmaToolStripMenuItem.Click += poliklinikTanıtmaToolStripMenuItem_Click;
            // 
            // kullanıcıTanıtmaToolStripMenuItem
            // 
            kullanıcıTanıtmaToolStripMenuItem.Name = "kullanıcıTanıtmaToolStripMenuItem";
            kullanıcıTanıtmaToolStripMenuItem.Size = new Size(248, 34);
            kullanıcıTanıtmaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            kullanıcıTanıtmaToolStripMenuItem.Click += kullanıcıTanıtmaToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(248, 34);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // hastaKabulToolStripMenuItem
            // 
            hastaKabulToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hastaİşlemleriToolStripMenuItem });
            hastaKabulToolStripMenuItem.Name = "hastaKabulToolStripMenuItem";
            hastaKabulToolStripMenuItem.Size = new Size(122, 29);
            hastaKabulToolStripMenuItem.Text = "Hasta Kabul";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            hastaİşlemleriToolStripMenuItem.ShortcutKeys = Keys.F2;
            hastaİşlemleriToolStripMenuItem.Size = new Size(260, 34);
            hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            hastaİşlemleriToolStripMenuItem.Click += hastaİşlemleriToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { raporToolStripMenuItem });
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(95, 29);
            raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // raporToolStripMenuItem
            // 
            raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            raporToolStripMenuItem.Size = new Size(162, 34);
            raporToolStripMenuItem.Text = "Rapor";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(835, 607);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Anasayfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem referanslarToolStripMenuItem;
        private ToolStripMenuItem kullanıcıTanıtmaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem hastaKabulToolStripMenuItem;
        private ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem raporToolStripMenuItem;
        private ToolStripMenuItem poliklinikTanıtmaToolStripMenuItem;
    }
}