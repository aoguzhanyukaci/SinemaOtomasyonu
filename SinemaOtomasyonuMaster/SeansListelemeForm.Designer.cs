
namespace SinemaOtomasyonuMaster
{
    partial class SeansListelemeForm
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
            this.dgvSeanslariListele = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpSecilenTarih = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.chckKaldir = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeanslariListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gösterimde Olan Filimleri Listeleyiniz.";
            // 
            // dgvSeanslariListele
            // 
            this.dgvSeanslariListele.AllowUserToAddRows = false;
            this.dgvSeanslariListele.AllowUserToDeleteRows = false;
            this.dgvSeanslariListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeanslariListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeanslariListele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSeanslariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeanslariListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSeanslariListele.Location = new System.Drawing.Point(12, 47);
            this.dgvSeanslariListele.Name = "dgvSeanslariListele";
            this.dgvSeanslariListele.ReadOnly = true;
            this.dgvSeanslariListele.RowHeadersVisible = false;
            this.dgvSeanslariListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeanslariListele.Size = new System.Drawing.Size(948, 500);
            this.dgvSeanslariListele.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FilmAdi";
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Film Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SalonAdi";
            this.Column3.HeaderText = "Salon Adı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tarih";
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Gösterim Tarihi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SeansZamani";
            this.Column5.HeaderText = "Seans Zamani";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dtpSecilenTarih
            // 
            this.dtpSecilenTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSecilenTarih.Location = new System.Drawing.Point(628, 16);
            this.dtpSecilenTarih.Name = "dtpSecilenTarih";
            this.dtpSecilenTarih.Size = new System.Drawing.Size(200, 23);
            this.dtpSecilenTarih.TabIndex = 3;
            this.dtpSecilenTarih.ValueChanged += new System.EventHandler(this.dtpSecilenTarih_ValueChanged);
            // 
            // btnListele
            // 
            this.btnListele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListele.Location = new System.Drawing.Point(834, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(126, 29);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // chckKaldir
            // 
            this.chckKaldir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chckKaldir.AutoSize = true;
            this.chckKaldir.Location = new System.Drawing.Point(386, 17);
            this.chckKaldir.Name = "chckKaldir";
            this.chckKaldir.Size = new System.Drawing.Size(236, 21);
            this.chckKaldir.TabIndex = 7;
            this.chckKaldir.Text = "Seansı Geçen Filimleri Kaldır";
            this.chckKaldir.UseVisualStyleBackColor = true;
            // 
            // SeansListelemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 559);
            this.Controls.Add(this.chckKaldir);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSeanslariListele);
            this.Controls.Add(this.dtpSecilenTarih);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeansListelemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seansları Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeanslariListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSeanslariListele;
        private System.Windows.Forms.DateTimePicker dtpSecilenTarih;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox chckKaldir;
    }
}