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
    public partial class f_menu : UserControl
    {
        string stw = "";
        public f_menu()
        {
            InitializeComponent();
        }

        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM viewmenu WHERE status_jenis='aktif'", koneksi.con).ExecuteReader();
                dgtampil.Rows.Clear();
                while (rd.Read())
                {
                    dgtampil.Rows.Add(
                        rd["id_menu"].ToString(),
                        rd["nama_jenis"].ToString(),
                        rd["nama_menu"].ToString(),
                        "Rp " + Convert.ToInt32(rd["harga"]).ToString("N0")
                        );
                }
                rd.Close();
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tampil " + ex.Message);
                koneksi.con.Close();
            }
        }
        private void tampiljenismenu()
        {
            koneksi.con.Open();
            DataTable dt = new DataTable();
            new MySqlDataAdapter("SELECT * FROM jenis_menu WHERE status_jenis='aktif'", koneksi.con).Fill(dt);
            txtidjenis.DataSource = dt;
            txtidjenis.ValueMember = "id_jenis";
            txtnamajenis.DataSource = dt;
            txtnamajenis.ValueMember = "nama_jenis";
            koneksi.con.Close();
        }
        private void baru()
        {
            txtid.Enabled = false;
            txtnama.Enabled = false;
            txtharga.Enabled = false;
            txtnamajenis.Enabled = false;
            

            btnnew.Text = "Baru";
            btnsimpan.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btncetak.Enabled = true;

            txtid.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtharga.Text = string.Empty;
            txtnamajenis.Text = string.Empty;
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            if(btnnew.Text == "Baru")
            {
                txtid.Enabled = false;
                txtnama.Enabled = true;
                txtharga.Enabled = true;
                txtnamajenis.Enabled = true;

                stw = "i";
                btnnew.Text = "Batal";
                btnsimpan.Enabled = true;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btncetak.Enabled = false;

                tampiljenismenu();
                txtid.Text = "M" + new Random().Next(100000, 999999).ToString();
            }
            else
            {
                baru();
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtnama.Text) || string.IsNullOrWhiteSpace(txtharga.Text))
            {
                MessageBox.Show("Isi semua data !");
                return;
            }
            try
            {
                koneksi.con.Open();
                string q = "";
                if (stw == "e")
                {
                    q = "UPDATE `menu` SET `id_jenis`='" + txtidjenis.Text + "',`nama_menu`='" + txtnama.Text + "',`harga`='" + txtharga.Text + "' WHERE `id_menu`='" + txtid.Text + "'";
                }
                else
                {
                    q = "INSERT INTO `menu`(`id_menu`, `id_jenis`, `nama_menu`, `harga`) VALUES" +
                         " ('" + txtid.Text + "','" + txtidjenis.Text + "','" + txtnama.Text + "','" + txtharga.Text + "')";
                }
                new MySqlCommand(q, koneksi.con).ExecuteNonQuery();
                MessageBox.Show("Berhasil Disimpan ");
                koneksi.con.Close();
                tampil();
                baru();

            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("Duplicate") && ex.Message.Contains("nama_menu"))
                {
                    MessageBox.Show("username sudah ada !");
                }
                else
                {
                    MessageBox.Show("gagal simpan " + ex.Message);
                }
                koneksi.con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Konfirmasi Hapus", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    new MySqlCommand("DELETE FROM menu WHERE id_menu='" + txtid.Text + "'", koneksi.con).ExecuteNonQuery();
                    koneksi.con.Close();
                    tampil();
                    baru();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal delete " + ex.Message);
                koneksi.con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtnama.Enabled = true;
            txtharga.Enabled = true;
            txtnamajenis.Enabled = true;

            stw = "e";
            btnnew.Text = "Batal";
            btnsimpan.Enabled = true;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btncetak.Enabled = false;
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            new CETAKmenu(txtcari.Text).Show();
        }

        private void dgtampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Enabled = false;
            txtnama.Enabled = false;
            txtharga.Enabled = false;
            txtnamajenis.Enabled = false;

            btnnew.Text = "Batal";
            btnsimpan.Enabled = false;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btncetak.Enabled = false;

            int b = dgtampil.CurrentCell.RowIndex;
            txtid.Text = dgtampil.Rows[b].Cells[0].Value.ToString();

            koneksi.con.Open();
            var rd = new MySqlCommand("SELECT * FROM viewmenu WHERE id_menu='" + txtid.Text + "'", koneksi.con).ExecuteReader();
            if(rd.Read())
            {
                txtnama.Text = rd["nama_menu"].ToString();
                txtnamajenis.Text = rd["nama_jenis"].ToString();
                txtharga.Text = rd["harga"].ToString();
            }
            rd.Close();
            koneksi.con.Close();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM viewmenu WHERE status_jenis='aktif' AND nama_menu LIKE '%" + txtcari.Text + "%' OR nama_jenis LIKE '%" + txtcari.Text + "%'", koneksi.con).ExecuteReader();
                dgtampil.Rows.Clear();
                while (rd.Read())
                {
                    dgtampil.Rows.Add(
                        rd["id_menu"].ToString(),
                        rd["nama_jenis"].ToString(),
                        rd["nama_menu"].ToString(),
                        "Rp " + Convert.ToInt32(rd["harga"]).ToString("N0")
                        );
                }
                rd.Close();
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tampil " + ex.Message);
                koneksi.con.Close();
            }
        }

        private void f_menu_Load(object sender, EventArgs e)
        {
            tampil();
            baru();
            tampiljenismenu();
        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }else if(txtharga.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }
    }
}
