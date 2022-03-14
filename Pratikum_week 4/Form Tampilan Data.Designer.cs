
namespace Pratikum_week_4
{
    partial class Form_Tampilan_Data
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
            this.txtBoxTelpon = new System.Windows.Forms.TextBox();
            this.txtBoxAlamat = new System.Windows.Forms.TextBox();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.btnSebelum = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblTelpon = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnSelanjut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxTelpon
            // 
            this.txtBoxTelpon.Location = new System.Drawing.Point(125, 173);
            this.txtBoxTelpon.Name = "txtBoxTelpon";
            this.txtBoxTelpon.Size = new System.Drawing.Size(390, 27);
            this.txtBoxTelpon.TabIndex = 15;
            // 
            // txtBoxAlamat
            // 
            this.txtBoxAlamat.Location = new System.Drawing.Point(125, 115);
            this.txtBoxAlamat.Name = "txtBoxAlamat";
            this.txtBoxAlamat.Size = new System.Drawing.Size(390, 27);
            this.txtBoxAlamat.TabIndex = 14;
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Location = new System.Drawing.Point(125, 61);
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(390, 27);
            this.txtBoxNama.TabIndex = 13;
            // 
            // btnSebelum
            // 
            this.btnSebelum.Location = new System.Drawing.Point(229, 252);
            this.btnSebelum.Name = "btnSebelum";
            this.btnSebelum.Size = new System.Drawing.Size(128, 31);
            this.btnSebelum.TabIndex = 12;
            this.btnSebelum.Text = "Prev Data";
            this.btnSebelum.UseVisualStyleBackColor = true;
            this.btnSebelum.Click += new System.EventHandler(this.btnSebelum_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(51, 252);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(128, 31);
            this.btnKembali.TabIndex = 11;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // lblTelpon
            // 
            this.lblTelpon.AutoSize = true;
            this.lblTelpon.Location = new System.Drawing.Point(52, 180);
            this.lblTelpon.Name = "lblTelpon";
            this.lblTelpon.Size = new System.Drawing.Size(40, 20);
            this.lblTelpon.TabIndex = 10;
            this.lblTelpon.Text = "Telp:";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(51, 118);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(60, 20);
            this.lblAlamat.TabIndex = 9;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(52, 64);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(52, 20);
            this.lblNama.TabIndex = 8;
            this.lblNama.Text = "Nama:";
            // 
            // btnSelanjut
            // 
            this.btnSelanjut.Location = new System.Drawing.Point(402, 252);
            this.btnSelanjut.Name = "btnSelanjut";
            this.btnSelanjut.Size = new System.Drawing.Size(128, 31);
            this.btnSelanjut.TabIndex = 16;
            this.btnSelanjut.Text = "Next Data";
            this.btnSelanjut.UseVisualStyleBackColor = true;
            this.btnSelanjut.Click += new System.EventHandler(this.btnSelanjut_Click);
            // 
            // Form_Tampilan_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelanjut);
            this.Controls.Add(this.txtBoxTelpon);
            this.Controls.Add(this.txtBoxAlamat);
            this.Controls.Add(this.txtBoxNama);
            this.Controls.Add(this.btnSebelum);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblTelpon);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Name = "Form_Tampilan_Data";
            this.Text = "Form_Tampilan_Data";
            this.Load += new System.EventHandler(this.Form_Tampilan_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTelpon;
        private System.Windows.Forms.TextBox txtBoxAlamat;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.Button btnSebelum;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblTelpon;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnSelanjut;
    }
}