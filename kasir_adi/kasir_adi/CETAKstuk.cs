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
    public partial class CETAKstuk : Form
    {
        string id_transaksi;
        public CETAKstuk(string i)
        {
            InitializeComponent();
            id_transaksi = i;
        }

        private void CETAKstuk_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM vdetaill WHERE id_transaksi='" + id_transaksi + "'", koneksi.con).Fill(dt);
                LPstruk1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = LPstruk1;
                crystalReportViewer1.Refresh();
                koneksi.con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("gagal cetak struk" + ex.Message);
                koneksi.con.Close();
            }
        }

        private void CETAKstuk_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Hide();
            }
        }
    }
}
