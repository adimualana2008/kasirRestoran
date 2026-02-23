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
    public partial class f_jenis : UserControl
    {
        string stw = "";
        public f_jenis()
        {
            InitializeComponent();
        }

        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM `jenis_menu` WHERE id_jenis != 'J00005'", koneksi.con).Fill(dt);
                dgtampil.DataSource = dt;
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tampil " + ex.Message);
                koneksi.con.Close();
            }
        }
        private void baru()
        {
            txtid.Enabled = false;
            txtnama.Enabled = false;
           
            txtstatus.Enabled = false;

            btnnew.Text = "Baru";
            btnsimpan.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;

            txtid.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtstatus.Text = string.Empty;
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            if (btnnew.Text == "Baru")
            {
                txtid.Enabled = false;
                txtnama.Enabled = true;
                txtstatus.Enabled = false;

                stw = "i";
                btnnew.Text = "Batal";
                btnsimpan.Enabled = true;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;

                txtstatus.Text = "aktif";
                txtid.Text = "J" + new Random().Next(10000, 99999).ToString();
            }
            else
            {
                baru();
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtnama.Text) || txtstatus.Text == "")
                {
                    MessageBox.Show("Harap diisi secara lengkap");
                    return;
                }
                koneksi.con.Open();
                string q = "";
                if (stw == "e")
                {
                    q = "UPDATE `jenis_menu` SET `nama_jenis`='" + txtnama.Text + "',`status_jenis`='" + txtstatus.Text + "' WHERE `id_jenis`='" + txtid.Text + "'";
                }
                else
                {
                    q = "INSERT INTO `jenis_menu`(`id_jenis`, `nama_jenis`, `status_jenis`) VALUES ('" + txtid.Text + "','" + txtnama.Text + "','" + txtstatus.Text + "')";
                }
                new MySqlCommand(q, koneksi.con).ExecuteNonQuery();
                MessageBox.Show("Berhasil Disimpan ");
                koneksi.con.Close();
                tampil();
                baru();

            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("Duplicate") && ex.Message.Contains("nama_jenis"))
                {
                    MessageBox.Show("nama jenis sudah ada !");
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
                koneksi.con.Open();
                int jp = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM menu WHERE id_jenis='" + txtid.Text + "'", koneksi.con).ExecuteScalar());
                koneksi.con.Close();
                if (jp > 0)
                {
                    MessageBox.Show("jenis menu tidak bisa dihapus, karena datanya digunakan dalam menu");
                    return;
                }
                else if (MessageBox.Show("Konfirmasi Hapus", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    new MySqlCommand("DELETE FROM jenis_menu WHERE id_jenis='" + txtid.Text + "'", koneksi.con).ExecuteNonQuery();
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
            
            txtstatus.Enabled = true;

            stw = "e";
            btnnew.Text = "Batal";
            btnsimpan.Enabled = true;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
        }

        private void dgtampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Enabled = false;
            txtnama.Enabled = false;
            
            txtstatus.Enabled = false;

            btnnew.Text = "Batal";
            btnsimpan.Enabled = false;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;

            int b = dgtampil.CurrentCell.RowIndex;
            txtid.Text = dgtampil.Rows[b].Cells[0].Value.ToString();
            txtnama.Text = dgtampil.Rows[b].Cells[1].Value.ToString();
           
            txtstatus.Text = dgtampil.Rows[b].Cells[2].Value.ToString();
        }

        private void f_jenis_Load(object sender, EventArgs e)
        {
            tampil();
            baru();

        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM `jenis_menu` WHERE id_jenis != 'J00005' AND nama_jenis LIKE '%" + txtcari.Text + "%'", koneksi.con).Fill(dt);
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
