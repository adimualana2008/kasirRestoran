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
    public partial class f_laporan : UserControl
    {
        string q = "";
        public f_laporan()
        {
            InitializeComponent();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(dtmulai.Value.Date > dtsampai.Value.Date)
                {
                    MessageBox.Show("Tanggal Mulai Tidak Boleh Lebih dari Tanggal sampai");
                    return;
                }
                koneksi.con.Open();
                if (datauser.level == "kasir")
                {
                    q = "AND id_petugas='" + datauser.id_petugas + "'";
                    panel1.Visible = false;
                }
                else if(txtpilih.Text == "Custom")
                {
                    q = "AND id_petugas='" + txtid.Text + "'"; 
                }
                else if(txtpilih.Text == "All")
                {
                    q = "";
                }
                var rd = new MySqlCommand("SELECT * FROM `vtransaksi` WHERE tgl >= '" + dtmulai.Value.ToString("yyyy-MM-dd 00:00:01") + "' AND tgl <= '" + dtsampai.Value.ToString("yyyy-MM-dd 23:59:59") + "' " + q + " ORDER BY tgl DESC", koneksi.con).ExecuteReader();
                dgtampil.Rows.Clear();
                while (rd.Read())
                {
                    dgtampil.Rows.Add(
                        rd["id_transaksi"].ToString(),
                        rd["tgl"].ToString(),
                        rd["id_petugas"].ToString() + " | " + rd["nama"].ToString(),
                        rd["jenis_pesan"].ToString(),
                        "Rp " + Convert.ToInt32(rd["total"]).ToString("N0")
                        );
                }
                rd.Close();
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal " + ex.Message);
                koneksi.con.Close();
            }
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            if (dtmulai.Value.Date > dtsampai.Value.Date)
            {
                MessageBox.Show("Tanggal Mulai Tidak Boleh Lebih dari Tanggal sampai");
                return;
            }
            string id;
            if(datauser.level == "kasir")
            {
                id = datauser.id_petugas;
            }else if(txtpilih.Text == "Custom")
            {
                id = txtid.Text;
                datauser.namape = txtnama.Text;
            }
            else
            {
                id = "";
            }
            new CETAKTRA(dtmulai.Value, dtsampai.Value, id).Show();
        }

        private void txtpilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtpilih.Text == "All")
            {
                txtid.Visible = false;
                txtnama.Visible = false;
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT DISTINCT id_petugas,nama FROM vtransaksi", koneksi.con).Fill(dt);
                txtid.DataSource = dt;
                txtid.ValueMember = "id_petugas";
                txtnama.DataSource = dt;
                txtnama.ValueMember = "nama";
                koneksi.con.Close();
            }
            else
            {
                txtid.Visible = true;
                txtnama.Visible = true;

            }
        }

        private void f_laporan_Load(object sender, EventArgs e)
        {
            txtpilih.Text = "All";
            try
            {
                koneksi.con.Open();
                if(datauser.level == "kasir")
                {
                    q = "WHERE id_petugas='" + datauser.id_petugas + "'";
                    panel1.Visible = false;
                }
                var rd = new MySqlCommand("SELECT * FROM `vtransaksi` " + q + " ORDER BY tgl DESC", koneksi.con).ExecuteReader();
                dgtampil.Rows.Clear();
                while (rd.Read())
                {
                    dgtampil.Rows.Add(
                        rd["id_transaksi"].ToString(),
                        rd["tgl"].ToString(),
                        rd["id_petugas"].ToString() + " | " + rd["nama"].ToString(),
                        rd["jenis_pesan"].ToString(),
                        "Rp " + Convert.ToInt32(rd["total"]).ToString("N0")
                        );
                }
                rd.Close();
                koneksi.con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("gagal " + ex.Message);
                koneksi.con.Close();
            }
        }
    }
}
