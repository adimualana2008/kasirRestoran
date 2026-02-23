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
    public partial class f_petugas : UserControl
    {
        string q = "", level, stw = "";
        dashboard d;
        string us, pw;
        public f_petugas(dashboard ds)
        {
            InitializeComponent();
            d = ds;
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM `petugas`", koneksi.con).Fill(dt);
                dgtampil.DataSource = dt;
                koneksi.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("gagal tampil " + ex.Message);
                koneksi.con.Close();
            }
        }
        private void baru()
        {
            txtid.Enabled = false;
            txtnama.Enabled = false;
            txtnotelepon.Enabled = false;
            txtusername.Enabled = false;
            txtpassword.Enabled = false;
            txtlevel.Enabled = false;
            txtstatus.Enabled = false;


            btnnew.Text = "Baru";
            btnsimpan.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btncetak.Enabled = true;

            txtid.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtnotelepon.Text = string.Empty;
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtlevel.Text = string.Empty;
            txtstatus.Text = string.Empty;
            panel2.Visible = true;
        }
        private void f_petugas_Load(object sender, EventArgs e)
        {
            tampil();
            baru();
        }

        private void dgtampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Enabled = false;
            txtnama.Enabled = false;
            txtnotelepon.Enabled = false;
            txtusername.Enabled = false;
            txtpassword.Enabled = false;
            txtlevel.Enabled = false;
            txtstatus.Enabled = false;

            btnnew.Text = "Batal";
            btnsimpan.Enabled = false;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btncetak.Enabled = false;

            int b = dgtampil.CurrentCell.RowIndex;
            txtid.Text = dgtampil.Rows[b].Cells[0].Value.ToString();
            txtnama.Text = dgtampil.Rows[b].Cells[1].Value.ToString();
            txtnotelepon.Text = dgtampil.Rows[b].Cells[2].Value.ToString();
            us = dgtampil.Rows[b].Cells[3].Value.ToString();
            pw = dgtampil.Rows[b].Cells[4].Value.ToString();
            level = dgtampil.Rows[b].Cells[5].Value.ToString();
            txtstatus.Text = dgtampil.Rows[b].Cells[6].Value.ToString();
            txtusername.Text = us;
            txtpassword.Text = pw;
            txtlevel.Text = level;
            if (level == "owner")
            {
                panel2.Visible = false;
                btndelete.Enabled = false;
            }
            else
            {
                panel2.Visible = true;
                btndelete.Enabled = true;
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                int jp = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM transaksi WHERE id_petugas='" + txtid.Text + "'", koneksi.con).ExecuteScalar());
                koneksi.con.Close();
                if(jp > 0)
                {
                    MessageBox.Show("Data petugas tidak dapat dihapus karena datanya sudah ada dalam transaksi.  \n ubah status menjadi nonaktif jika tidak digunakan");
                    return;
                }
                else if(MessageBox.Show("Konfirmasi Hapus", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    new MySqlCommand("DELETE FROM petugas WHERE id_petugas='" + txtid.Text + "'", koneksi.con).ExecuteNonQuery();
                    koneksi.con.Close();
                    tampil();
                    baru();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("gagal delete " + ex.Message);
                koneksi.con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtnama.Enabled = true;
            txtnotelepon.Enabled = true;
            txtusername.Enabled = true;
            txtpassword.Enabled = true;
            txtlevel.Enabled = true;
            txtstatus.Enabled = true;

            stw = "e";

            btnnew.Text = "Batal";
            btnsimpan.Enabled = true;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btncetak.Enabled = false;

            if(level == "owner")
            {
                btndelete.Enabled = false;
            }
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            new CETAKpetugas(txtcari.Text).Show();
        }
        private void validasi()
        {
            
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                if (string.IsNullOrWhiteSpace(txtnama.Text) || string.IsNullOrWhiteSpace(txtnotelepon.Text) || string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text) || string.IsNullOrWhiteSpace(txtlevel.Text) || string.IsNullOrWhiteSpace(txtstatus.Text))
                {
                    MessageBox.Show("Harap diisi secara lengkap !");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtnama.Text) || string.IsNullOrWhiteSpace(txtnotelepon.Text) || string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Harap diisi secara lengkap !");
                    return;
                }
            }


            if (txtnotelepon.Text.Length < 10 || txtnotelepon.Text.Length > 13)
            {
                MessageBox.Show("No telepon terdiri 10 - 13 digit");
                return;
            }else if(txtusername.Text.Length < 4 || txtusername.Text.Length > 20 || !txtusername.Text.Any(char.IsLetter) || !txtusername.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Username Minmal 4 - 20 karakter yang terdiri dari huruf dan angka");
                return;
            }
            else if (txtpassword.Text.Length < 6 || txtpassword.Text.Length > 20 || !txtpassword.Text.Any(char.IsLetter) || !txtpassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Password Minmal 6 - 20 karakter yang terdiri dari huruf dan angka");
                return;
            }
            else if(txtusername.Text.Contains(" ") )
            {
                MessageBox.Show("Username tidak boleh ada sepasi");
                return;
            }
            else if (txtpassword.Text.Contains(" "))
            {
                MessageBox.Show("password tidak boleh ada sepasi");
                return;
            }
            try
            {
                koneksi.con.Open();
                if(panel2.Visible == false)
                {

                    q = "UPDATE `petugas` SET `nama`='" + txtnama.Text + "',`no`='" + txtnotelepon.Text + "',`username`='" + txtusername.Text + "',`password`='" + txtpassword.Text + "' WHERE `id_petugas`='" + txtid.Text + "'";
                }
                else if (stw == "e")
                {
                    q = "UPDATE `petugas` SET `nama`='" + txtnama.Text + "',`no`='" + txtnotelepon.Text + "',`username`='" + txtusername.Text + "',`password`='" + txtpassword.Text + "',`level`='" + txtlevel.Text + "',`status_petugas`='" + txtstatus.Text + "' WHERE `id_petugas`='" + txtid.Text + "'";
                }
                else
                {
                    q = "INSERT INTO `petugas`(`id_petugas`, `nama`, `no`, `username`, `password`, `level`, `status_petugas`) VALUES " +
                        "('" + txtid.Text + "','" + txtnama.Text + "','" + txtnotelepon.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtlevel.Text + "','aktif')";
                }
                new MySqlCommand(q, koneksi.con).ExecuteNonQuery();
                MessageBox.Show("Berhasil Disimpan ");
                koneksi.con.Close();
               
                if(panel2.Visible == false)
                {
                    if(txtusername.Text != us || txtpassword.Text != pw)
                    {
                        d.Hide();
                        new login().Show();
                    }
                    else
                    {
                        d.header();
                    }
                }
                tampil();
                baru();
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("Duplicate") && ex.Message.Contains("username"))
                {
                    MessageBox.Show("Username Sudah ada !");
                }
                else if (ex.Message.Contains("Duplicate") && ex.Message.Contains("no"))
                {
                    MessageBox.Show("No telepon Sudah ada !");
                }
                else
                {
                    MessageBox.Show("gagal simpan " + ex.Message);
                }
                koneksi.con.Close();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if(btnnew.Text == "Baru")
            {
                txtid.Enabled = false;
                txtnama.Enabled = true;
                txtnotelepon.Enabled = true;
                txtusername.Enabled = true;
                txtpassword.Enabled = true;
                txtlevel.Enabled = true;
                txtstatus.Enabled = false;

                stw = "i";

                btnnew.Text = "Batal";
                btnsimpan.Enabled = true;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btncetak.Enabled = false;

                txtstatus.Text = "aktif";
                txtid.Text = "P" + new Random().Next(1000, 9999).ToString();
            }
            else
            {
                baru();
            }
        }

        private void txtnotelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtnotelepon.Text.Length == 0 && e.KeyChar != '0')
            {
                e.Handled = true;
            }
            else if (txtnotelepon.Text.Length == 1 && e.KeyChar != '8')
            {
                e.Handled = true;
            }
        }

        private void txtnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM `petugas` WHERE nama LIKE '%" + txtcari.Text + "%' OR level LIKE '%" + txtcari.Text + "%'", koneksi.con).Fill(dt);
                dgtampil.DataSource = dt;
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cari " + ex.Message);
                koneksi.con.Close();
            }
        }
    }
}
