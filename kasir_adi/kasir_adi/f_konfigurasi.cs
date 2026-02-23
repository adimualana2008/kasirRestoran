using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kasir_adi
{
    public partial class f_konfigurasi : UserControl
    {
        dashboard d;
        public f_konfigurasi(dashboard w)
        {
            InitializeComponent();
            d = w;
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtnama.Text) || string.IsNullOrWhiteSpace(txtalamat.Text))
            {
               MessageBox.Show("hap diisi secara lengkap");
                return;
            }else if(txtno.Text.Length < 10 || txtno.Text.Length > 13)
            {
                MessageBox.Show("No Telepon terdiri 10 - 13 digit");
                return;
            }
            try
            {
                koneksi.con.Open();
                new MySqlCommand("UPDATE `konfigurasi` SET `nama_resto`='" + txtnama.Text + "',`alamat`='" + txtalamat.Text + "',`no_kantor`='" + txtno.Text + "',`pajak`='" + txtpajak.Value.ToString() + "' WHERE `id`='1'", koneksi.con).ExecuteNonQuery();
                koneksi.con.Close();
                MessageBox.Show("berhasil disimpan ");
                d.header();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal simpan " + ex.Message);
                koneksi.con.Close();
            }
        }

        private void f_konfigurasi_Load(object sender, EventArgs e)
        {
            koneksi.con.Open();
            var rd = new MySqlCommand("SELECT * FROM konfigurasi", koneksi.con).ExecuteReader();
            if (rd.Read())
            {
                txtnama.Text = rd["nama_resto"].ToString();
                txtalamat.Text = rd["alamat"].ToString();
                txtno.Text = rd["no_kantor"].ToString();
                txtpajak.Value = Convert.ToInt32(rd["pajak"]);
            }
            rd.Close();
            koneksi.con.Close();

        }

        private void txtno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }else if (txtno.Text.Length == 0 && e.KeyChar != '0')
            {
                e.Handled = true;
            }
            else if (txtno.Text.Length == 1 && e.KeyChar != '8')
            {
                e.Handled = true;
            }
        }

        private void txtpajak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
