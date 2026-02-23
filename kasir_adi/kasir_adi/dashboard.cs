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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            addusercontrol(new f_informasi());
            this.KeyPreview = true;
        }
        private f_transaksi tra;
        private void btnlogout_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
        private void addusercontrol(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            paneltampil.Controls.Clear();
            paneltampil.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        public void header()
        {
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM petugas WHERE id_petugas='" + datauser.id_petugas + "'", koneksi.con).ExecuteReader();
                if (rd.Read())
                {
                    label2.Text = rd["id_petugas"].ToString() + " | " + rd["nama"].ToString();
                }
                rd.Close();

                var rdd = new MySqlCommand("SELECT * FROM konfigurasi", koneksi.con).ExecuteReader();
                if (rdd.Read())
                {
                    label1.Text = "Rest Go " + rdd["nama_resto"].ToString();
                }
                rdd.Close();
                koneksi.con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("gagal header" + ex.Message);
                koneksi.con.Close();
            }
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            header();
            if(datauser.level == "owner")
            {
                btnpetugas.Visible = true;
                btnkonfigurasi.Visible = true;
                btnlaporan.Visible = true;
            }
            else if(datauser.level == "admin")
            {
                btnjenis.Visible = true;
                btnmenu.Visible = true;
                btnlaporan.Visible = true;

            }
            else if(datauser.level == "kasir")
            {
                btntransaksi.Visible = true;
                btnlaporan.Visible = true;
            }
        }

        private void btnpetugas_Click(object sender, EventArgs e)
        {
            addusercontrol(new f_petugas(this));

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            addusercontrol(new f_menu());
        }

        private void btnjenis_Click(object sender, EventArgs e)
        {
            addusercontrol(new f_jenis());

        }

        private void btnkonfigurasi_Click(object sender, EventArgs e)
        {
            addusercontrol(new f_konfigurasi(this));
        }

        private void btntransaksi_Click(object sender, EventArgs e)
        {
            tra = new f_transaksi();
            addusercontrol(tra);
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            addusercontrol(new f_laporan());
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            addusercontrol(new f_informasi());
        }
        private f_transaksi tran;
        private void dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if(tra != null && tra.Visible)
            {
                if(e.KeyCode == Keys.F1)
                {
                    tra.dg1();
                }
                else if(e.KeyCode == Keys.F2)
                {
                    tra.dg2();
                }
                else if (e.KeyCode == Keys.F3)
                {
                    tra.tbcari();
                }
                else if (e.KeyCode == Keys.F4)
                {
                    tra.tbjenis();
                }
                else if (e.KeyCode == Keys.F5)
                {
                    tra.tbnama();
                }
                else if (e.KeyCode == Keys.F6)
                {
                    tra.tbbayar();
                }
                else if (e.KeyCode == Keys.F7)
                {
                    tra.btreset();
                }
               
            }
        }
    }
}
