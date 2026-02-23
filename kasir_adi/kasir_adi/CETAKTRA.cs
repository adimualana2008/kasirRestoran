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
    public partial class CETAKTRA : Form
    {
        DateTime mulai, sampai;
        string id, q = "";
        public CETAKTRA(DateTime m, DateTime s, string i)
        {
            InitializeComponent();
            mulai = m;
            sampai = s;
            id = i;
        }

        private void CETAKTRA_Load(object sender, EventArgs e)
        {
            string owner = "";
            string td1 = "";
            string td2 = "";
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM petugas WHERE level='owner'", koneksi.con).ExecuteReader();
                if (rd.Read())
                {
                    owner = rd["nama"].ToString();
                }
                rd.Close();
                if (datauser.level == "kasir")
                {
                    q = "AND id_petugas='" + datauser.id_petugas + "'";
                    td1 = "pemiliki \n \n \n \n " + owner;
                    td2 = "Kasir  \n \n \n \n " + datauser.nama;
                }
                else if (id != "")
                {
                    q = "AND id_petugas='" + id + "'";
                    td1 = "pemiliki \n \n \n \n " + owner;
                    td2 = "Kasir \n \n \n \n " + datauser.namape;

                }
                else
                {
                    q = "";
                    td2 = "pemiliki \n \n \n \n " + owner;

                }
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM vtransaksi WHERE tgl >= '" + mulai.ToString("yyyy-MM-dd 00:00:01") + "' AND tgl <= '" + sampai.ToString("yyyy-MM-dd 23:59:59") + "' " + q, koneksi.con).Fill(dt);
                LPpenjualan1.SetDataSource(dt);
                LPpenjualan1.SetParameterValue("periode", "Periode : " + mulai.ToString("dd MMMM yyyy") + " s/d " + sampai.ToString("dd MMMM yyyy"));
                LPpenjualan1.SetParameterValue("nama_owner", td1);
                LPpenjualan1.SetParameterValue("nama_cetak", td2);
                crystalReportViewer1.ReportSource = LPpenjualan1;
                crystalReportViewer1.Refresh();
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cetak struk" + ex.Message);
                koneksi.con.Close();
            }
        }
    }
}
