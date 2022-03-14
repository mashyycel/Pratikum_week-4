
namespace Pratikum_week_4
{
    partial class FormPenambahanData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNama = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblTelpon = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnLihatData = new System.Windows.Forms.Button();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.txtBoxAlamat = new System.Windows.Forms.TextBox();
            this.txtBoxTelpon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(64, 74);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(52, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(63, 128);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(60, 20);
            this.lblAlamat.TabIndex = 1;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblTelpon
            // 
            this.lblTelpon.AutoSize = true;
            this.lblTelpon.Location = new System.Drawing.Point(64, 190);
            this.lblTelpon.Name = "lblTelpon";
            this.lblTelpon.Size = new System.Drawing.Size(40, 20);
            this.lblTelpon.TabIndex = 2;
            this.lblTelpon.Text = "Telp:";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(63, 262);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(128, 31);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnLihatData
            // 
            this.btnLihatData.Location = new System.Drawing.Point(241, 262);
            this.btnLihatData.Name = "btnLihatData";
            this.btnLihatData.Size = new System.Drawing.Size(128, 31);
            this.btnLihatData.TabIndex = 4;
            this.btnLihatData.Text = "Lihat Data";
            this.btnLihatData.UseVisualStyleBackColor = true;
            this.btnLihatData.Click += new System.EventHandler(this.btnLihatData_Click);
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Location = new System.Drawing.Point(137, 71);
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(390, 27);
            this.txtBoxNama.TabIndex = 5;
            // 
            // txtBoxAlamat
            // 
            this.txtBoxAlamat.Location = new System.Drawing.Point(137, 125);
            this.txtBoxAlamat.Name = "txtBoxAlamat";
            this.txtBoxAlamat.Size = new System.Drawing.Size(390, 27);
            this.txtBoxAlamat.TabIndex = 6;
            // 
            // txtBoxTelpon
            // 
            this.txtBoxTelpon.Location = new System.Drawing.Point(137, 187);
            this.txtBoxTelpon.Name = "txtBoxTelpon";
            this.txtBoxTelpon.Size = new System.Drawing.Size(390, 27);
            this.txtBoxTelpon.TabIndex = 7;
            this.txtBoxTelpon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelpon_KeyPress);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxTelpon);
            this.Controls.Add(this.txtBoxAlamat);
            this.Controls.Add(this.txtBoxNama);
            this.Controls.Add(this.btnLihatData);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblTelpon);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Name = "FormPenambahanData";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormPenambahanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblTelpon;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnLihatData;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.TextBox txtBoxAlamat;
        private System.Windows.Forms.TextBox txtBoxTelpon;
    }
}

