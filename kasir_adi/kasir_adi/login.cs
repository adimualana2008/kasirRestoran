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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void tampilpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !txtpassword.UseSystemPasswordChar;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM petugas WHERE username='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'", koneksi.con).ExecuteReader();
                if (rd.Read())
                {
                    datauser.id_petugas = rd["id_petugas"].ToString();
                    datauser.nama = rd["nama"].ToString();
                    datauser.level = rd["level"].ToString();
                    string status = rd["status_petugas"].ToString();
                    rd.Close();
                    koneksi.con.Close();
                    if (status == "nonaktif")
                    {
                        MessageBox.Show("Akun Ini Terblokir");
                    }
                    else
                    {
                        MessageBox.Show("berhasil login");
                        new dashboard().Show();
                        this.Hide();
                    } 
                }
                else if(string.IsNullOrWhiteSpace(txtusername.Text) && string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Username dan password harus diisi");
                }
                else if (txtusername.Text.Length < 4 || txtusername.Text.Length > 20 || !txtusername.Text.Any(char.IsLetter) || !txtusername.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Username Minmal 4 - 20 karakter yang terdiri dari huruf dan angka");
                }
                else if (txtpassword.Text.Length < 6 || txtpassword.Text.Length > 20 || !txtpassword.Text.Any(char.IsLetter) || !txtpassword.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Password Minmal 6 - 20 karakter yang terdiri dari huruf dan angka");
                }
                else if (txtusername.Text.Contains(" "))
                {
                    MessageBox.Show("Username tidak boleh ada sepasi");
                }
                else if (txtpassword.Text.Contains(" "))
                {
                    MessageBox.Show("password tidak boleh ada sepasi");
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah");
                }
                rd.Close();
                koneksi.con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("gagal login" + ex.Message);
                koneksi.con.Close();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                var rd = new MySqlCommand("SELECT * FROM konfigurasi", koneksi.con).ExecuteReader();
                if (rd.Read())
                {
                    label3.Text = "Hallo, Selamat datang di \n " + rd["nama_resto"].ToString();
                }
                rd.Close();
                koneksi.con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Gagal di cek" + ex.Message);
            }
        }
    }
}
