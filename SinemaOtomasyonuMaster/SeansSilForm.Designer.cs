
namespace SinemaOtomasyonuMaster
{
    partial class SeansSilForm
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
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeansListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dtpSeansSilTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListele
            // 
            this.dgvListele.AllowUserToAddRows = false;
            this.dgvListele.AllowUserToDeleteRows = false;
            this.dgvListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListele.Location = new System.Drawing.Point(12, 12);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.ReadOnly = true;
            this.dgvListele.RowHeadersVisible = false;
            this.dgvListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListele.Size = new System.Drawing.Size(523, 269);
            this.dgvListele.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SeansId";
            this.Column4.HeaderText = "Film Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FilmAdi";
            this.Column1.HeaderText = "Film Adı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tarih";
            this.Column2.HeaderText = "Tarih";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SeansZamani";
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "Seans";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnSeansListele
            // 
            this.btnSeansListele.Location = new System.Drawing.Point(382, 289);
            this.btnSeansListele.Name = "btnSeansListele";
            this.btnSeansListele.Size = new System.Drawing.Size(153, 33);
            this.btnSeansListele.TabIndex = 1;
            this.btnSeansListele.Text = "Seans Listele";
            this.btnSeansListele.UseVisualStyleBackColor = true;
            this.btnSeansListele.Click += new System.EventHandler(this.btnSeansListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 289);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(153, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dtpSeansSilTarih
            // 
            this.dtpSeansSilTarih.Location = new System.Drawing.Point(176, 292);
            this.dtpSeansSilTarih.Name = "dtpSeansSilTarih";
            this.dtpSeansSilTarih.Size = new System.Drawing.Size(200, 23);
            this.dtpSeansSilTarih.TabIndex = 3;
            // 
            // SeansSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 333);
            this.Controls.Add(this.dtpSeansSilTarih);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSeansListele);
            this.Controls.Add(this.dgvListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SeansSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Sil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.Button btnSeansListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DateTimePicker dtpSeansSilTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}