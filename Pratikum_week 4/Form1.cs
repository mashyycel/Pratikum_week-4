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
    public partial class FormPenambahanData : Form
    {
        public FormPenambahanData()
        {
            InitializeComponent();
        }
        public static DataTable dataOrang = new DataTable();


        public static string nama = "";
        public static string alamat = "";
        public static string telp = "";
        
        private void FormPenambahanData_Load(object sender, EventArgs e)
        {
            dataOrang.Columns.Add("Nama");
            dataOrang.Columns.Add("Alamat");
            dataOrang.Columns.Add("Telp");
        }
        private void btnLihatData_Click(object sender, EventArgs e)
        {
            

            nama = txtBoxNama.Text;
            alamat = txtBoxAlamat.Text;
            telp = txtBoxTelpon.Text;
            this.Hide();
            Form_Tampilan_Data formtampil = new Form_Tampilan_Data();
            formtampil.Show();

        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {

            
            dataOrang.Rows.Add(txtBoxNama.Text, txtBoxAlamat.Text, txtBoxTelpon.Text);
           
            if (dataOrang.Rows.Count == 10)
            {
                MessageBox.Show("Data sudah penuh");
              
            }

            
        }
        private void txtBoxTelpon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form_Tampilan_Data formtampil = new Form_Tampilan_Data();
            formtampil.Hide();
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
            }
        }
    }
}
