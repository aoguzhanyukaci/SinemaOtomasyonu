
namespace SinemaOtomasyonuMaster
{
    partial class KoltukSecForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwKoltuk = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.lblGosterimTarihi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSeans = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwKoltuk);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(854, 617);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon A";
            // 
            // lvwKoltuk
            // 
            this.lvwKoltuk.HideSelection = false;
            this.lvwKoltuk.Location = new System.Drawing.Point(7, 23);
            this.lvwKoltuk.Name = "lvwKoltuk";
            this.lvwKoltuk.Size = new System.Drawing.Size(839, 585);
            this.lvwKoltuk.TabIndex = 0;
            this.lvwKoltuk.UseCompatibleStateImageBehavior = false;
            this.lvwKoltuk.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwKoltuk_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film Adı :";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.Location = new System.Drawing.Point(101, 19);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(214, 17);
            this.lblFilmAdi.TabIndex = 4;
            this.lblFilmAdi.Text = "label2";
            // 
            // lblGosterimTarihi
            // 
            this.lblGosterimTarihi.Location = new System.Drawing.Point(456, 19);
            this.lblGosterimTarihi.Name = "lblGosterimTarihi";
            this.lblGosterimTarihi.Size = new System.Drawing.Size(173, 17);
            this.lblGosterimTarihi.TabIndex = 6;
            this.lblGosterimTarihi.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gösterim Tarihi :";
            // 
            // lblSeans
            // 
            this.lblSeans.Location = new System.Drawing.Point(760, 19);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(103, 17);
            this.lblSeans.TabIndex = 8;
            this.lblSeans.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Film Seansı :";
            // 
            // KoltukSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 670);
            this.Controls.Add(this.lblSeans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGosterimTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFilmAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KoltukSecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koltuk Seçimi ";
            this.Load += new System.EventHandler(this.KoltukSecForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwKoltuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Label lblGosterimTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSeans;
        private System.Windows.Forms.Label label6;
    }
}