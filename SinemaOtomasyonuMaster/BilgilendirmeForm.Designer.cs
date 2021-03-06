
namespace SinemaOtomasyonuMaster
{
    partial class BilgilendirmeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilmHakkinda = new System.Windows.Forms.TextBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.pcbAfis = new System.Windows.Forms.PictureBox();
            this.btnKoltukSec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalon1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSalon2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSalon3 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSalon6 = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSalon5 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvSalon4 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSalonSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSeansSec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAfis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon6)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon5)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon4)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Film Hakkında";
            // 
            // txtFilmHakkinda
            // 
            this.txtFilmHakkinda.Location = new System.Drawing.Point(185, 32);
            this.txtFilmHakkinda.Multiline = true;
            this.txtFilmHakkinda.Name = "txtFilmHakkinda";
            this.txtFilmHakkinda.ReadOnly = true;
            this.txtFilmHakkinda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFilmHakkinda.Size = new System.Drawing.Size(263, 209);
            this.txtFilmHakkinda.TabIndex = 10;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(6, 197);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(106, 28);
            this.btnGeriDon.TabIndex = 6;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // pcbAfis
            // 
            this.pcbAfis.Location = new System.Drawing.Point(15, 32);
            this.pcbAfis.Name = "pcbAfis";
            this.pcbAfis.Size = new System.Drawing.Size(164, 209);
            this.pcbAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAfis.TabIndex = 7;
            this.pcbAfis.TabStop = false;
            // 
            // btnKoltukSec
            // 
            this.btnKoltukSec.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoltukSec.Location = new System.Drawing.Point(126, 197);
            this.btnKoltukSec.Name = "btnKoltukSec";
            this.btnKoltukSec.Size = new System.Drawing.Size(106, 28);
            this.btnKoltukSec.TabIndex = 12;
            this.btnKoltukSec.Text = "Koltuk Seçimi";
            this.btnKoltukSec.UseVisualStyleBackColor = true;
            this.btnKoltukSec.Click += new System.EventHandler(this.btnKoltukSec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSalon1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 196);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon  1";
            // 
            // dgvSalon1
            // 
            this.dgvSalon1.AllowUserToAddRows = false;
            this.dgvSalon1.AllowUserToDeleteRows = false;
            this.dgvSalon1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalon1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalon1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSalon1.Location = new System.Drawing.Point(6, 25);
            this.dgvSalon1.Name = "dgvSalon1";
            this.dgvSalon1.ReadOnly = true;
            this.dgvSalon1.RowHeadersVisible = false;
            this.dgvSalon1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalon1.Size = new System.Drawing.Size(211, 165);
            this.dgvSalon1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SeansZamani";
            this.Column1.HeaderText = "Seans Saati";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSalon2);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(241, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 196);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salon  2";
            // 
            // dgvSalon2
            // 
            this.dgvSalon2.AllowUserToAddRows = false;
            this.dgvSalon2.AllowUserToDeleteRows = false;
            this.dgvSalon2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalon2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalon2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgvSalon2.Location = new System.Drawing.Point(6, 25);
            this.dgvSalon2.Name = "dgvSalon2";
            this.dgvSalon2.ReadOnly = true;
            this.dgvSalon2.RowHeadersVisible = false;
            this.dgvSalon2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalon2.Size = new System.Drawing.Size(211, 165);
            this.dgvSalon2.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SeansZamani";
            this.Column4.HeaderText = "Seans Saati";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSalon3);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(470, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 196);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salon  3";
            // 
            // dgvSalon3
            // 
            this.dgvSalon3.AllowUserToAddRows = false;
            this.dgvSalon3.AllowUserToDeleteRows = false;
            this.dgvSalon3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalon3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalon3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6});
            this.dgvSalon3.Location = new System.Drawing.Point(6, 25);
            this.dgvSalon3.Name = "dgvSalon3";
            this.dgvSalon3.ReadOnly = true;
            this.dgvSalon3.RowHeadersVisible = false;
            this.dgvSalon3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalon3.Size = new System.Drawing.Size(211, 165);
            this.dgvSalon3.TabIndex = 2;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SeansZamani";
            this.Column6.HeaderText = "Seans Saati";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSalon6);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(470, 449);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 196);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salon  6";
            // 
            // dgvSalon6
            // 
            this.dgvSalon6.AllowUserToAddRows = false;
            this.dgvSalon6.AllowUserToDeleteRows = false;
            this.dgvSalon6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalon6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalon6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12});
            this.dgvSalon6.Location = new System.Drawing.Point(6, 23);
            this.dgvSalon6.Name = "dgvSalon6";
            this.dgvSalon6.ReadOnly = true;
            this.dgvSalon6.RowHeadersVisible = false;
            this.dgvSalon6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalon6.Size = new System.Drawing.Size(211, 165);
            this.dgvSalon6.TabIndex = 3;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SeansZamani";
            this.Column12.HeaderText = "Seans Saati";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSalon5);
            this.groupBox5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(241, 449);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 196);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salon  5";
            // 
            // dgvSalon5
            // 
            this.dgvSalon5.AllowUserToAddRows = false;
            this.dgvSalon5.AllowUserToDeleteRows = false;
            this.dgvSalon5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalon5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalon5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10});
            this.dgvSalon5.Location = new System.Drawing.Point(6, 23);
            this.dgvSalon5.Name = "dgvSalon5";
            this.dgvSalon5.ReadOnly = true;
            this.dgvSalon5.RowHeadersVisible = false;
            this.dgvSalon5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalon5.Size = new System.Drawing.Size(211, 165);
            this.dgvSalon5.TabIndex = 2;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SeansZamani";
            this.Column10.HeaderText = "Seans Saati";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvSalon4);
            this.groupBox6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(12, 449);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(223, 196);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Salon  4";
            // 
            // dgvSalon4
            // 
            this.dgvSalon4.AllowUserToAddRows = false;
            this.dgvSalon4.AllowUserToDeleteRows = false;
            this.dgvSalon4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalon4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalon4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.dgvSalon4.Location = new System.Drawing.Point(6, 23);
            this.dgvSalon4.Name = "dgvSalon4";
            this.dgvSalon4.ReadOnly = true;
            this.dgvSalon4.RowHeadersVisible = false;
            this.dgvSalon4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalon4.Size = new System.Drawing.Size(211, 165);
            this.dgvSalon4.TabIndex = 1;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SeansZamani";
            this.Column8.HeaderText = "Seans Saati";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // cboSalonSec
            // 
            this.cboSalonSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalonSec.FormattingEnabled = true;
            this.cboSalonSec.Location = new System.Drawing.Point(6, 105);
            this.cboSalonSec.Name = "cboSalonSec";
            this.cboSalonSec.Size = new System.Drawing.Size(226, 27);
            this.cboSalonSec.TabIndex = 1;
            this.cboSalonSec.SelectedIndexChanged += new System.EventHandler(this.cboSalonSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Salon Seç";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtpTarih);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.cboSeansSec);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.cboSalonSec);
            this.groupBox7.Controls.Add(this.btnGeriDon);
            this.groupBox7.Controls.Add(this.btnKoltukSec);
            this.groupBox7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(454, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(238, 232);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Salon Ve Seans İşlemleri";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(6, 51);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(226, 26);
            this.dtpTarih.TabIndex = 34;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tarih Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Seans Seç";
            // 
            // cboSeansSec
            // 
            this.cboSeansSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeansSec.FormattingEnabled = true;
            this.cboSeansSec.Location = new System.Drawing.Point(6, 160);
            this.cboSeansSec.Name = "cboSeansSec";
            this.cboSeansSec.Size = new System.Drawing.Size(226, 27);
            this.cboSeansSec.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Film Afişi";
            // 
            // BilgilendirmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 650);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilmHakkinda);
            this.Controls.Add(this.pcbAfis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BilgilendirmeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filim Hakında Bilgiler";
            this.Load += new System.EventHandler(this.BilgilendirmeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAfis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon6)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon5)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon4)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmHakkinda;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.PictureBox pcbAfis;
        private System.Windows.Forms.Button btnKoltukSec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvSalon1;
        private System.Windows.Forms.DataGridView dgvSalon2;
        private System.Windows.Forms.DataGridView dgvSalon3;
        private System.Windows.Forms.DataGridView dgvSalon6;
        private System.Windows.Forms.DataGridView dgvSalon5;
        private System.Windows.Forms.DataGridView dgvSalon4;
        private System.Windows.Forms.ComboBox cboSalonSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSeansSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}