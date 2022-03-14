using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratikum_week_4
{
    public partial class Form_Tampilan_Data : Form
    {
        public Form_Tampilan_Data()
        {
            InitializeComponent();
        }

        
        private void Form_Tampilan_Data_Load(object sender, EventArgs e)
        {
            txtBoxNama.Text = FormPenambahanData.nama;
            txtBoxAlamat.Text = FormPenambahanData.alamat;
            txtBoxTelpon.Text = FormPenambahanData.telp;

        }
        
        private void btnSebelum_Click(object sender, EventArgs e)
        {

            DataTable dataorangorang = FormPenambahanData.dataOrang;
            if (dataorangorang.Rows.Count == 1)
            {
                MessageBox.Show("Data sudah data pertama");
            }
        }

        private void btnSelanjut_Click(object sender, EventArgs e)
        {
            DataTable dataorangorang = FormPenambahanData.dataOrang;
            if (dataorangorang.Rows.Count == 10)
            {
                MessageBox.Show("Data sudah data terakhir");
            }
            
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormPenambahanData form = new FormPenambahanData();
            form.Show();
        }
    }
}
