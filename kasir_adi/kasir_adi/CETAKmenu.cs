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
    public partial class CETAKmenu : Form
    {
        string cari;
        public CETAKmenu(string c)
        {
            InitializeComponent();
            cari = c;
        }

        private void CETAKmenu_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM viewmenu WHERE status_jenis='aktif' AND id_jenis != 'J00005' AND nama_jenis LIKE '%" + cari + "%'", koneksi.con).Fill(dt);
                LPmenu1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = LPmenu1;
                crystalReportViewer1.Refresh();
                koneksi.con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("gagal cetak" + ex.Message);
                koneksi.con.Close();
            }
        }
    }
}
