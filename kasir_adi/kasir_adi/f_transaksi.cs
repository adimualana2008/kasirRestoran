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
    public partial class f_transaksi : UserControl
    {
        string id_menu, id_pesanan, q = "";
        double harga, sub, persen, pajak, subtotal, total, bayar, kembalian;
        public f_transaksi()
        {
            InitializeComponent();
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM viewmenu WHERE status_jenis='aktif' AND id_jenis != 'J00005'", koneksi.con).ExecuteReader();
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

                var rdi = new MySqlCommand("SELECT * FROM vpesanan", koneksi.con).ExecuteReader();
                dgpesanan.Rows.Clear();
                while (rdi.Read())
                {
                    dgpesanan.Rows.Add(
                        rdi["id"].ToString(),
                        rdi["nama_jenis"].ToString(),
                        rdi["nama_menu"].ToString(),
                        "Rp " + Convert.ToInt32(rdi["harga"]).ToString("N0"),
                        rdi["jumlah"].ToString(),
                        "Rp " + Convert.ToInt32(rdi["subtotal"]).ToString("N0")
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
        private void baru()
        {
            txtharga.Text = "Rp 0";
            txtsub.Text = "Rp 0";
            txtjumlah.Value = 0;

            txtjumlah.Enabled = false;

            btnsimpan.Visible = false;
            btndelete.Visible = false;
        }
        private void caripajak()
        {
            koneksi.con.Open();
            subtotal = Convert.ToDouble(new MySqlCommand("SELECT IFNULL(SUM(subtotal), 0) FROM pesanan", koneksi.con).ExecuteScalar());
            var rd = new MySqlCommand("SELECT * FROM konfigurasi", koneksi.con).ExecuteReader();
            if (rd.Read())
            {
                persen = Convert.ToDouble(rd["pajak"]);
            }
            pajak = (persen / 100) * subtotal;
            total = pajak + subtotal;
            txttotal.Text = "Rp " + total.ToString("N0");
            txtsubtotal.Text = "Rp " + subtotal.ToString("N0");
            txtpajak.Text = persen.ToString() + " % | Rp " + pajak.ToString("N0");
            koneksi.con.Close();
        }
        private void insertpesanan()
        {
            if (txtjumlah.Value == 0)
            {
                MessageBox.Show("Masukkan Jumlah yang ingin dipesan");
                return;
            }
            try
            {
                koneksi.con.Open();
                int i = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM pesanan WHERE id_menu='" + id_menu + "'", koneksi.con).ExecuteScalar());
                if (btndelete.Visible == true)
                {
                    q = "UPDATE `pesanan` SET `jumlah`='" + txtjumlah.Value.ToString() + "',`subtotal`='" + sub.ToString() + "' WHERE `id`='" + id_pesanan + "'";
                }
                else if (i > 0)
                {
                    q = "UPDATE `pesanan` SET `jumlah`= jumlah + '" + txtjumlah.Value.ToString() + "',`subtotal`= subtotal + '" + sub.ToString() + "' WHERE `id_menu`='" + id_menu + "'";
                }
                else
                {
                    q = "INSERT INTO `pesanan`( `id_menu`, `jumlah`, `subtotal`) VALUES ('" + id_menu + "','" + txtjumlah.Value.ToString() + "','" + sub.ToString() + "')";
                }
                new MySqlCommand(q, koneksi.con).ExecuteNonQuery();
                koneksi.con.Close();

                tampil();
                baru();
                caripajak();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagagl simpan " + ex.Message);
                koneksi.con.Close();
                txtjumlah.Focus();
            }
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            insertpesanan();
        }

        private void munculdatamenu()
        {
            int b = dgtampil.CurrentCell.RowIndex;
            id_menu = dgtampil.Rows[b].Cells[0].Value.ToString();

            koneksi.con.Open();
            var rd = new MySqlCommand("SELECT * FROM viewmenu WHERE id_menu='" + id_menu + "'", koneksi.con).ExecuteReader();
            if (rd.Read())
            {
                harga = Convert.ToDouble(rd["harga"]);
                txtharga.Text = "Rp " + harga.ToString("N0");
            }
            rd.Close();
            koneksi.con.Close();

            txtjumlah.Enabled = true;

            btnsimpan.Visible = true;
            btndelete.Visible = false;
        }
        private void dgtampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            munculdatamenu();
        }

        private void txtbayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(txtbayar.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void txtjumlah_ValueChanged(object sender, EventArgs e)
        {
            sub = Convert.ToDouble(txtjumlah.Value) * harga;
            txtsub.Text = "Rp " + sub.ToString("N0");
        }
        private void kelashapus()
        {
            try
            {
                koneksi.con.Open();
                new MySqlCommand("DELETE FROM pesanan WHERE id='" + id_pesanan + "'", koneksi.con).ExecuteNonQuery();
                koneksi.con.Close();
                tampil();
                baru();
                caripajak();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal delete " + ex.Message);
                koneksi.con.Close();
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            kelashapus();
        }

        private void dgtampil_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                munculdatamenu();
                txtjumlah.Focus();
            }
        }

        private void txtjumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                insertpesanan();
                dgpesanan.Focus();
            }else if(btndelete.Visible == true && e.KeyCode == Keys.Delete)
            {
                kelashapus();
                dgpesanan.Focus();
            }
        }

        private void dgpesanan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                munculdatapesanan();
                txtjumlah.Focus();
            }
        }


        private void munculdatapesanan()
        {
            
            int b = dgpesanan.CurrentCell.RowIndex;
            id_pesanan = dgpesanan.Rows[b].Cells[0].Value.ToString();
            koneksi.con.Open();
            var rd = new MySqlCommand("SELECT * FROM vpesanan WHERE id='" + id_pesanan + "'", koneksi.con).ExecuteReader();
            if (rd.Read())
            {
                harga = Convert.ToDouble(rd["harga"]);
                sub = Convert.ToDouble(rd["subtotal"]);
                txtjumlah.Value = Convert.ToInt32(rd["jumlah"]);
                txtharga.Text = "Rp " + harga.ToString("N0");
                txtsub.Text = "Rp " + sub.ToString("N0");
            }
            rd.Close();
            koneksi.con.Close();

            txtjumlah.Enabled = true;

            btnsimpan.Visible = true;
            btndelete.Visible = true;
        }
        private void dgpesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            munculdatapesanan();
        }
        private void reset()
        {
            
            txtnama.Text = string.Empty;
            txtjenis.Text = string.Empty;
            txtbayar.Text = string.Empty;
            txtkembalian.Text = "Rp 0";
            txtjenis.Text = "dine in";
            koneksi.con.Open();
            new MySqlCommand("DELETE FROM pesanan", koneksi.con).ExecuteNonQuery();
            koneksi.con.Close();
            tampil();
            baru();
            caripajak();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnkonfirmasi_Click(object sender, EventArgs e)
        {
            if (txtjenis.Text == "dine in")
            {
                if (string.IsNullOrWhiteSpace(txtnama.Text))
                {
                    MessageBox.Show("No Meja tidak boleh kosong !");
                    return;
                }
                else if(!txtnama.Text.Any(char.IsLetter) || !txtnama.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("No Meja terdiri huruf dan angka !");
                    return;
                }
            }
            else if (txtjenis.Text == "take away")
            {
                if (string.IsNullOrWhiteSpace(txtnama.Text))
                {
                    MessageBox.Show("Nama pelanggan tidak boleh kosong !");
                    return;
                }
                
            }



            if (subtotal == 0)
            {
                MessageBox.Show("Belum Ada Menu yang dipesan !");
                return;
            }else if(txtbayar.Text == "")
            {
                MessageBox.Show("Masukkan Nominal Pembayaran !");
                return;
            }
            else if(total > bayar)
            {
                MessageBox.Show("Nominal tidak mencukupi !");
                return;
            }
            else if(MessageBox.Show("Konfirmasi pembayaran", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                string id_transaksi = DateTime.Now.ToString("yyMMddhhmm") + new Random().Next(1000, 9999).ToString();
                string tgl = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                koneksi.con.Open();
                int j = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM pesanan", koneksi.con).ExecuteScalar());

                new MySqlCommand("INSERT INTO `transaksi`(`id_transaksi`, `id_petugas`, `tgl`, `pelanggan`, `jenis_pesan`, `sub_total`, `persen`, `pajak`, `total`, `bayar`, `kembalian`) VALUES" +
                    " ('" + id_transaksi + "','" + datauser.id_petugas + "','" + tgl + "','" + txtnama.Text + "','" + txtjenis.Text + "','" + subtotal.ToString() + "','" + persen.ToString() + " %','" + pajak.ToString() + "','" + total.ToString() + "','" + txtbayar.Text + "', '" + kembalian.ToString() + "')", koneksi.con).ExecuteNonQuery();
                int i = 1;
                while(i <= j)
                {
                    var rd = new MySqlCommand("SELECT * FROM vpesanan", koneksi.con).ExecuteReader();
                    if (rd.Read())
                    {
                        string id = rd["id"].ToString();
                        string n = rd["nama_menu"].ToString();
                        string h = rd["harga"].ToString();
                        string ju = rd["jumlah"].ToString();
                        string s = rd["subtotal"].ToString();
                        rd.Close();

                        new MySqlCommand("INSERT INTO `detail_transaksi`(`id_transaksi`, `nama_menu`, `harga`, `jumlah`, `subtotal`) VALUES " +
                            "('" + id_transaksi + "','" + n + "','" + h + "','" + ju + "','" + s + "')", koneksi.con).ExecuteNonQuery();

                        new MySqlCommand("DELETE FROM pesanan WHERE id='" + id + "'", koneksi.con).ExecuteNonQuery();
                    }
                    i++;
                }
                MessageBox.Show("Berhasil pembayaran");
                koneksi.con.Close();
                new CETAKstuk(id_transaksi).Show();
                reset();
            }catch(Exception ex)
            {
                MessageBox.Show("gagal konfirmasi" + ex.Message);
                koneksi.con.Close();
            }
        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            if(txtbayar.Text == "")
            {
                bayar = 0;
            }
            else
            {
                bayar = Convert.ToDouble(txtbayar.Text);
            }
            kembalian = bayar - total;
            txtkembalian.Text = "Rp " + kembalian.ToString("N0");
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM viewmenu WHERE  " +
                    " nama_menu LIKE '%" + txtcari.Text + "%' AND status_jenis='aktif' AND id_jenis != 'J00005'", koneksi.con).ExecuteReader();
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
            }catch(Exception ex)
            {
                MessageBox.Show("gagal cari " + ex.Message);
                koneksi.con.Close();
            }
        }

        private void txtjumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtjenis.Text == "dine in")
            {
                label5.Text = "No Meja";
            }
            else if(txtjenis.Text == "take away")
            {
                label5.Text = "Nama Pelanggan";
            }
            txtnama.Text = string.Empty;
        }

        private void txtnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtjenis.Text == "take away")
            {
                if(!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtbayar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnkonfirmasi.Focus();
            }
        }

        private void f_transaksi_Load(object sender, EventArgs e)
        {
            reset();
           
        }


        public void dg1()
        {
            dgtampil.Focus();
        }
        public void dg2()
        {
            dgpesanan.Focus();
        }
        public void tbcari()
        {
            txtcari.Focus();
        }
        public void tbnama()
        {
            txtnama.Focus();
        }
        public void tbjenis()
        {
            txtjenis.Focus();
        }
        public void tbbayar()
        {
            txtbayar.Focus();
        }
        public void btreset()
        {
            reset();
        }
       
    }
}
