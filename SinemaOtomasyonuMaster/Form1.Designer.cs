
namespace SinemaOtomasyonuMaster
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullaniciPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seanslarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeansListele = new System.Windows.Forms.Label();
            this.lvwFilmler = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciPaneliToolStripMenuItem,
            this.destekToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(972, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullaniciPaneliToolStripMenuItem
            // 
            this.kullaniciPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.seansEkleToolStripMenuItem,
            this.satışlarToolStripMenuItem,
            this.seanslarıListeleToolStripMenuItem});
            this.kullaniciPaneliToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciPaneliToolStripMenuItem.Name = "kullaniciPaneliToolStripMenuItem";
            this.kullaniciPaneliToolStripMenuItem.Size = new System.Drawing.Size(115, 23);
            this.kullaniciPaneliToolStripMenuItem.Text = "Kullanıcı Paneli";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.filmEkleToolStripMenuItem.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // seansEkleToolStripMenuItem
            // 
            this.seansEkleToolStripMenuItem.Name = "seansEkleToolStripMenuItem";
            this.seansEkleToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.seansEkleToolStripMenuItem.Text = "Seans Ekle / Sil";
            this.seansEkleToolStripMenuItem.Click += new System.EventHandler(this.seansEkleToolStripMenuItem_Click);
            // 
            // satışlarToolStripMenuItem
            // 
            this.satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem";
            this.satışlarToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.satışlarToolStripMenuItem.Text = "Satışları Listele";
            this.satışlarToolStripMenuItem.Click += new System.EventHandler(this.satışlarToolStripMenuItem_Click);
            // 
            // seanslarıListeleToolStripMenuItem
            // 
            this.seanslarıListeleToolStripMenuItem.Name = "seanslarıListeleToolStripMenuItem";
            this.seanslarıListeleToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.seanslarıListeleToolStripMenuItem.Text = "Seansları Listele";
            this.seanslarıListeleToolStripMenuItem.Click += new System.EventHandler(this.seanslarıListeleToolStripMenuItem_Click);
            // 
            // destekToolStripMenuItem
            // 
            this.destekToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.destekToolStripMenuItem.Name = "destekToolStripMenuItem";
            this.destekToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.destekToolStripMenuItem.Text = "Destek";
            this.destekToolStripMenuItem.Click += new System.EventHandler(this.destekToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(971, 24);
            this.label1.TabIndex = 11;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeansListele
            // 
            this.lblSeansListele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeansListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSeansListele.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeansListele.ForeColor = System.Drawing.Color.Black;
            this.lblSeansListele.Location = new System.Drawing.Point(0, 27);
            this.lblSeansListele.Name = "lblSeansListele";
            this.lblSeansListele.Size = new System.Drawing.Size(971, 24);
            this.lblSeansListele.TabIndex = 10;
            this.lblSeansListele.Text = "🡆  🡆  🡆 ⌛ Filmlerin Seanslarına Bakmak İçin Mause İle Bir Kere Yazıya Tıklaman" +
    "ız Yeterli. ⌛ 🡄  🡄  🡄";
            this.lblSeansListele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeansListele.Click += new System.EventHandler(this.lblSeansListele_Click);
            // 
            // lvwFilmler
            // 
            this.lvwFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFilmler.FullRowSelect = true;
            this.lvwFilmler.HideSelection = false;
            this.lvwFilmler.Location = new System.Drawing.Point(0, 54);
            this.lvwFilmler.Name = "lvwFilmler";
            this.lvwFilmler.Size = new System.Drawing.Size(972, 571);
            this.lvwFilmler.TabIndex = 9;
            this.lvwFilmler.UseCompatibleStateImageBehavior = false;
            this.lvwFilmler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwFilmler_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 656);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeansListele);
            this.Controls.Add(this.lvwFilmler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OĞUZHAN  SİNABOOST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullaniciPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeansListele;
        private System.Windows.Forms.ListView lvwFilmler;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seanslarıListeleToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

