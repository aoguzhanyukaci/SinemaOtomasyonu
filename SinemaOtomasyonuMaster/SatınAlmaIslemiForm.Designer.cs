
namespace SinemaOtomasyonuMaster
{
    partial class SatınAlmaIslemiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatınAlmaIslemiForm));
            this.btnBiletIptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblTutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDuzenlemeYap = new System.Windows.Forms.Button();
            this.txtSecilenKoltuk = new System.Windows.Forms.TextBox();
            this.txtSecilenFilm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSecilenSalon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSecilenSeans = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSecilenTarih = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpBiletTarihi = new System.Windows.Forms.DateTimePicker();
            this.cboBiletFiyati = new System.Windows.Forms.ComboBox();
            this.cboOdemeTuru = new System.Windows.Forms.ComboBox();
            this.cboCinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBiletIptal
            // 
            this.btnBiletIptal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBiletIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletIptal.ForeColor = System.Drawing.Color.Black;
            this.btnBiletIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBiletIptal.ImageKey = "ticket.png";
            this.btnBiletIptal.ImageList = this.ımageList1;
            this.btnBiletIptal.Location = new System.Drawing.Point(148, 384);
            this.btnBiletIptal.Name = "btnBiletIptal";
            this.btnBiletIptal.Size = new System.Drawing.Size(133, 50);
            this.btnBiletIptal.TabIndex = 15;
            this.btnBiletIptal.Text = "Bilet İptal";
            this.btnBiletIptal.UseVisualStyleBackColor = false;
            this.btnBiletIptal.Click += new System.EventHandler(this.btnBiletIptal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back-arrow.png");
            this.ımageList1.Images.SetKeyName(1, "ticket.png");
            this.ımageList1.Images.SetKeyName(2, "settings.png");
            this.ımageList1.Images.SetKeyName(3, "debit-card.png");
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(369, 349);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(57, 19);
            this.lblTutar.TabIndex = 12;
            this.lblTutar.Text = "0,00 ₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(167, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ödenmesi Gereken Tutar :";
            // 
            // btnDuzenlemeYap
            // 
            this.btnDuzenlemeYap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDuzenlemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenlemeYap.ForeColor = System.Drawing.Color.Black;
            this.btnDuzenlemeYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenlemeYap.ImageKey = "settings.png";
            this.btnDuzenlemeYap.ImageList = this.ımageList1;
            this.btnDuzenlemeYap.Location = new System.Drawing.Point(287, 384);
            this.btnDuzenlemeYap.Name = "btnDuzenlemeYap";
            this.btnDuzenlemeYap.Size = new System.Drawing.Size(133, 50);
            this.btnDuzenlemeYap.TabIndex = 14;
            this.btnDuzenlemeYap.Text = "Düzenleme Yap";
            this.btnDuzenlemeYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenlemeYap.UseVisualStyleBackColor = false;
            this.btnDuzenlemeYap.Click += new System.EventHandler(this.btnDuzenlemeYap_Click);
            // 
            // txtSecilenKoltuk
            // 
            this.txtSecilenKoltuk.Location = new System.Drawing.Point(118, 142);
            this.txtSecilenKoltuk.Name = "txtSecilenKoltuk";
            this.txtSecilenKoltuk.ReadOnly = true;
            this.txtSecilenKoltuk.Size = new System.Drawing.Size(249, 23);
            this.txtSecilenKoltuk.TabIndex = 5;
            // 
            // txtSecilenFilm
            // 
            this.txtSecilenFilm.Location = new System.Drawing.Point(118, 28);
            this.txtSecilenFilm.Name = "txtSecilenFilm";
            this.txtSecilenFilm.ReadOnly = true;
            this.txtSecilenFilm.Size = new System.Drawing.Size(249, 23);
            this.txtSecilenFilm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koltuk No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSecilenSalon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSecilenSeans);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSecilenTarih);
            this.groupBox1.Controls.Add(this.txtSecilenKoltuk);
            this.groupBox1.Controls.Add(this.txtSecilenFilm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(107, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Bilgileri";
            // 
            // txtSecilenSalon
            // 
            this.txtSecilenSalon.Location = new System.Drawing.Point(118, 84);
            this.txtSecilenSalon.Name = "txtSecilenSalon";
            this.txtSecilenSalon.ReadOnly = true;
            this.txtSecilenSalon.Size = new System.Drawing.Size(249, 23);
            this.txtSecilenSalon.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salon Adı :";
            // 
            // txtSecilenSeans
            // 
            this.txtSecilenSeans.Location = new System.Drawing.Point(118, 113);
            this.txtSecilenSeans.Name = "txtSecilenSeans";
            this.txtSecilenSeans.ReadOnly = true;
            this.txtSecilenSeans.Size = new System.Drawing.Size(249, 23);
            this.txtSecilenSeans.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Seans :";
            // 
            // txtSecilenTarih
            // 
            this.txtSecilenTarih.Location = new System.Drawing.Point(118, 56);
            this.txtSecilenTarih.Name = "txtSecilenTarih";
            this.txtSecilenTarih.ReadOnly = true;
            this.txtSecilenTarih.Size = new System.Drawing.Size(249, 23);
            this.txtSecilenTarih.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpBiletTarihi);
            this.groupBox3.Controls.Add(this.cboBiletFiyati);
            this.groupBox3.Controls.Add(this.cboOdemeTuru);
            this.groupBox3.Controls.Add(this.cboCinsiyet);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(107, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 146);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satın Alma İşlemleri";
            // 
            // dtpBiletTarihi
            // 
            this.dtpBiletTarihi.Location = new System.Drawing.Point(118, 26);
            this.dtpBiletTarihi.Name = "dtpBiletTarihi";
            this.dtpBiletTarihi.Size = new System.Drawing.Size(249, 23);
            this.dtpBiletTarihi.TabIndex = 14;
            // 
            // cboBiletFiyati
            // 
            this.cboBiletFiyati.FormattingEnabled = true;
            this.cboBiletFiyati.Items.AddRange(new object[] {
            "Seçiniz",
            "Tam 20 ₺",
            "Öğrenci 15 ₺"});
            this.cboBiletFiyati.Location = new System.Drawing.Point(118, 114);
            this.cboBiletFiyati.Name = "cboBiletFiyati";
            this.cboBiletFiyati.Size = new System.Drawing.Size(249, 24);
            this.cboBiletFiyati.TabIndex = 13;
            this.cboBiletFiyati.SelectedIndexChanged += new System.EventHandler(this.cboBiletFiyati_SelectedIndexChanged);
            // 
            // cboOdemeTuru
            // 
            this.cboOdemeTuru.FormattingEnabled = true;
            this.cboOdemeTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Nakit",
            "Kredi Kartı"});
            this.cboOdemeTuru.Location = new System.Drawing.Point(118, 85);
            this.cboOdemeTuru.Name = "cboOdemeTuru";
            this.cboOdemeTuru.Size = new System.Drawing.Size(249, 24);
            this.cboOdemeTuru.TabIndex = 12;
            // 
            // cboCinsiyet
            // 
            this.cboCinsiyet.FormattingEnabled = true;
            this.cboCinsiyet.Items.AddRange(new object[] {
            "Seçiniz",
            "Bay",
            "Bayan"});
            this.cboCinsiyet.Location = new System.Drawing.Point(118, 56);
            this.cboCinsiyet.Name = "cboCinsiyet";
            this.cboCinsiyet.Size = new System.Drawing.Size(249, 24);
            this.cboCinsiyet.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ödeme Türü :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cinsiyet :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bilet Fiyatı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bilet Tarihi :";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.Color.Black;
            this.btnOdemeAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdemeAl.ImageKey = "debit-card.png";
            this.btnOdemeAl.ImageList = this.ımageList1;
            this.btnOdemeAl.Location = new System.Drawing.Point(426, 384);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(133, 50);
            this.btnOdemeAl.TabIndex = 16;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnGeriDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeriDon.ImageKey = "back-arrow.png";
            this.btnGeriDon.ImageList = this.ımageList1;
            this.btnGeriDon.Location = new System.Drawing.Point(9, 384);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(133, 50);
            this.btnGeriDon.TabIndex = 17;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // SatınAlmaIslemiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 443);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnBiletIptal);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDuzenlemeYap);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SatınAlmaIslemiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Satın Al";
            this.Load += new System.EventHandler(this.SatınAlmaIslemiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBiletIptal;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDuzenlemeYap;
        private System.Windows.Forms.TextBox txtSecilenKoltuk;
        private System.Windows.Forms.TextBox txtSecilenFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSecilenTarih;
        private System.Windows.Forms.TextBox txtSecilenSeans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpBiletTarihi;
        private System.Windows.Forms.ComboBox cboBiletFiyati;
        private System.Windows.Forms.ComboBox cboOdemeTuru;
        private System.Windows.Forms.ComboBox cboCinsiyet;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.TextBox txtSecilenSalon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList ımageList1;
    }
}