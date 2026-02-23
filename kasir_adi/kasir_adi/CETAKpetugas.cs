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
    public partial class CETAKpetugas : Form
    {
        string cari;
        public CETAKpetugas(string c)
        {
            InitializeComponent();
            cari = c;
        }

        private void CETAKpetugas_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM vpetugas WHERE level LIKE '%" + cari + "%' OR status_petugas='aktif'", koneksi.con).Fill(dt);
                LPpetugas1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = LPpetugas1;
                crystalReportViewer1.Refresh();
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cetak" + ex.Message);
                koneksi.con.Close();
            }
        }
    }
}
