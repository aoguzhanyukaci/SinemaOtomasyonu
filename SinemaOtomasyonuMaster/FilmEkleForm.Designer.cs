
namespace SinemaOtomasyonuMaster
{
    partial class FilmEkleForm
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
            this.dgvFilimler = new System.Windows.Forms.DataGridView();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cboFilmTur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFilmAciklama = new System.Windows.Forms.TextBox();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opdResimAc = new System.Windows.Forms.OpenFileDialog();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYapimYili = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnFilmKaldir = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilimler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilimler
            // 
            this.dgvFilimler.AllowUserToAddRows = false;
            this.dgvFilimler.AllowUserToDeleteRows = false;
            this.dgvFilimler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFilimler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFilimler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilimler.Location = new System.Drawing.Point(347, 7);
            this.dgvFilimler.MultiSelect = false;
            this.dgvFilimler.Name = "dgvFilimler";
            this.dgvFilimler.ReadOnly = true;
            this.dgvFilimler.RowHeadersVisible = false;
            this.dgvFilimler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilimler.Size = new System.Drawing.Size(950, 476);
            this.dgvFilimler.TabIndex = 25;
            this.dgvFilimler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFilimler_MouseDoubleClick);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(301, 7);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(40, 27);
            this.btnResimSec.TabIndex = 24;
            this.btnResimSec.Text = "...";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(132, 9);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(163, 23);
            this.txtResim.TabIndex = 23;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "(none)";
            this.btnGuncelle.Location = new System.Drawing.Point(125, 452);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 32);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cboFilmTur
            // 
            this.cboFilmTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilmTur.FormattingEnabled = true;
            this.cboFilmTur.Items.AddRange(new object[] {
            "Seçiniz",
            "Dram",
            "Komedi",
            "Aşk",
            "Aksiyon",
            "Bilim Kurgu",
            "Fantastik",
            "Korku"});
            this.cboFilmTur.Location = new System.Drawing.Point(132, 71);
            this.cboFilmTur.Name = "cboFilmTur";
            this.cboFilmTur.Size = new System.Drawing.Size(209, 24);
            this.cboFilmTur.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Film Tür :";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageKey = "(none)";
            this.btnEkle.Location = new System.Drawing.Point(236, 451);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 32);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFilmAciklama
            // 
            this.txtFilmAciklama.Location = new System.Drawing.Point(132, 218);
            this.txtFilmAciklama.Multiline = true;
            this.txtFilmAciklama.Name = "txtFilmAciklama";
            this.txtFilmAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFilmAciklama.Size = new System.Drawing.Size(209, 228);
            this.txtFilmAciklama.TabIndex = 17;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(132, 42);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(209, 23);
            this.txtFilmAd.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Film Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Film Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Film Resim :";
            // 
            // opdResimAc
            // 
            this.opdResimAc.FileName = "openFileDialog1";
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(132, 101);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(209, 23);
            this.txtYonetmen.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yönetmen :";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(132, 130);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(209, 23);
            this.txtSure.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Süre :";
            // 
            // txtYapimYili
            // 
            this.txtYapimYili.Location = new System.Drawing.Point(132, 159);
            this.txtYapimYili.Name = "txtYapimYili";
            this.txtYapimYili.Size = new System.Drawing.Size(209, 23);
            this.txtYapimYili.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Yapım Yılı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tarih :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(132, 188);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(209, 23);
            this.dtpTarih.TabIndex = 33;
            // 
            // btnFilmKaldir
            // 
            this.btnFilmKaldir.Location = new System.Drawing.Point(15, 452);
            this.btnFilmKaldir.Name = "btnFilmKaldir";
            this.btnFilmKaldir.Size = new System.Drawing.Size(49, 32);
            this.btnFilmKaldir.TabIndex = 34;
            this.btnFilmKaldir.Text = "-";
            this.btnFilmKaldir.UseVisualStyleBackColor = true;
            this.btnFilmKaldir.Click += new System.EventHandler(this.btnFilmKaldir_Click);
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(15, 250);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(105, 196);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 19;
            this.pbResim.TabStop = false;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(71, 452);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(49, 32);
            this.btnFilmEkle.TabIndex = 35;
            this.btnFilmEkle.Text = "+";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // FilmEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 492);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnFilmKaldir);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYapimYili);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvFilimler);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cboFilmTur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFilmAciklama);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FilmEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.FilmEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilimler;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cboFilmTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFilmAciklama;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog opdResimAc;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYapimYili;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnFilmKaldir;
        private System.Windows.Forms.Button btnFilmEkle;
    }
}