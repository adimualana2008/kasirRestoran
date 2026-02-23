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
    public partial class f_informasi : UserControl
    {
        public f_informasi()
        {
            InitializeComponent();
        }
        private void owner()
        {
            try
            {
                koneksi.con.Open();

                txttext1.Text = "Jumlah Petugas Aktif";
                txttext2.Text = "Pendapatan Bulan ini";
                txtisi1.Text = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM petugas WHERE" +
                    " status_petugas='aktif' AND level != 'owner'", koneksi.con).ExecuteScalar()).ToString() + " Petugas ";
                txtisi2.Text = "Rp " + Convert.ToInt32(new MySqlCommand("SELECT IFNULL(SUM(total), 0) FROM transaksi WHERE YEAR(tgl) = YEAR(CURDATE()) AND MONTH(tgl) = MONTH(CURDATE()) ", koneksi.con).ExecuteScalar()).ToString("N0");
                koneksi.con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("gagal owner" + ex.Message);
                koneksi.con.Close();
            }
        }
        private void admin()
        {
            try
            {
                koneksi.con.Open();

                txttext1.Text = "Jumlah Jenis Menu";
                txttext2.Text = "Jumlah Menu Aktif";
                txtisi1.Text = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM jenis_menu WHERE" +
                    " status_jenis='aktif' AND id_jenis != 'J00005'", koneksi.con).ExecuteScalar()).ToString() + " Jenis Menu ";
                txtisi2.Text = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM viewmenu WHERE" +
                    " status_jenis='aktif' AND id_jenis != 'J00005'", koneksi.con).ExecuteScalar()).ToString() + " Menu ";
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal admin" + ex.Message);
                koneksi.con.Close();
            }
        }
        private void kasir()
        {
            try
            {
                koneksi.con.Open();

                txttext1.Text = "Transaksi Hari ini";
                txttext2.Text = "Pendapatan Hari ini";
                txtisi1.Text = Convert.ToInt32(new MySqlCommand("SELECT COUNT(*) FROM transaksi WHERE" +
                    " YEAR(tgl) = YEAR(CURDATE()) AND MONTH(tgl) = MONTH(CURDATE()) AND DAY(tgl) = DAY(CURDATE()) " +
                    "AND id_petugas='" + datauser.id_petugas + "'", koneksi.con).ExecuteScalar()).ToString() + " Transaksi";
                txtisi2.Text = "Rp " + Convert.ToInt32(new MySqlCommand("SELECT IFNULL(SUM(total),0) FROM transaksi WHERE" +
                    " YEAR(tgl) = YEAR(CURDATE()) AND MONTH(tgl) = MONTH(CURDATE()) AND DAY(tgl) = DAY(CURDATE()) " +
                    "AND id_petugas='" + datauser.id_petugas + "'", koneksi.con).ExecuteScalar()).ToString("N0");
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal kasir" + ex.Message);
                koneksi.con.Close();
            }
        }
        private void f_informasi_Load(object sender, EventArgs e)
        {
            txtprofile.Text = "Selamat datang " + datauser.level + " | " + DateTime.Now.ToString("dd MMMM yyyy");
            if(datauser.level == "owner")
            {
                owner();
            }else if(datauser.level == "admin")
            {
                admin();
            }
            else
            {
                kasir();
            }
        }
    }
}
