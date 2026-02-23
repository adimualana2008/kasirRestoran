
namespace kasir_adi
{
    partial class f_petugas
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgtampil = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnotelepon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncetak = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtampil)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgtampil
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.dgtampil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtampil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtampil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtampil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtampil.ColumnHeadersHeight = 44;
            this.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtampil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.u,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtampil.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgtampil.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgtampil.Location = new System.Drawing.Point(340, 73);
            this.dgtampil.Margin = new System.Windows.Forms.Padding(4);
            this.dgtampil.Name = "dgtampil";
            this.dgtampil.ReadOnly = true;
            this.dgtampil.RowHeadersVisible = false;
            this.dgtampil.RowTemplate.Height = 40;
            this.dgtampil.Size = new System.Drawing.Size(511, 269);
            this.dgtampil.TabIndex = 0;
            this.dgtampil.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgtampil.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.dgtampil.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtampil.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgtampil.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtampil.ThemeStyle.HeaderStyle.Height = 44;
            this.dgtampil.ThemeStyle.ReadOnly = true;
            this.dgtampil.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.dgtampil.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgtampil.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgtampil.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgtampil.ThemeStyle.RowsStyle.Height = 40;
            this.dgtampil.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.dgtampil.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgtampil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtampil_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_petugas";
            this.Column1.HeaderText = "ID Petugas";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama";
            this.Column2.HeaderText = "Nama Petugas";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "no";
            this.Column3.HeaderText = "No Telepon";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "password";
            this.Column6.HeaderText = "pass";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // u
            // 
            this.u.DataPropertyName = "username";
            this.u.HeaderText = "Username";
            this.u.Name = "u";
            this.u.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "level";
            this.Column4.HeaderText = "Level";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "status_petugas";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnsimpan);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtnotelepon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel1.Location = new System.Drawing.Point(30, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 488);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(25, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Petugas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtstatus);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtlevel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel2.Location = new System.Drawing.Point(9, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 100);
            this.panel2.TabIndex = 19;
            // 
            // txtstatus
            // 
            this.txtstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "",
            "aktif",
            "nonaktif"});
            this.txtstatus.Location = new System.Drawing.Point(20, 74);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(176, 28);
            this.txtstatus.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Level";
            // 
            // txtlevel
            // 
            this.txtlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtlevel.FormattingEnabled = true;
            this.txtlevel.Items.AddRange(new object[] {
            "",
            "kasir",
            "admin"});
            this.txtlevel.Location = new System.Drawing.Point(19, 23);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(176, 28);
            this.txtlevel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // btnnew
            // 
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnnew.Location = new System.Drawing.Point(32, 441);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(65, 35);
            this.btnnew.TabIndex = 16;
            this.btnnew.Text = "Baru";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Purple;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Location = new System.Drawing.Point(103, 441);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(103, 35);
            this.btnsimpan.TabIndex = 15;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(30, 295);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(175, 27);
            this.txtpassword.TabIndex = 9;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(30, 240);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(175, 27);
            this.txtusername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // txtnotelepon
            // 
            this.txtnotelepon.Location = new System.Drawing.Point(30, 183);
            this.txtnotelepon.Name = "txtnotelepon";
            this.txtnotelepon.Size = new System.Drawing.Size(175, 27);
            this.txtnotelepon.TabIndex = 5;
            this.txtnotelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotelepon_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "No Telepon";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(30, 130);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(175, 27);
            this.txtnama.TabIndex = 3;
            this.txtnama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnama_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Petugas";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(30, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(175, 27);
            this.txtid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Petugas";
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btndelete.Location = new System.Drawing.Point(341, 349);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 41);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Hapus";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnupdate.Location = new System.Drawing.Point(464, 349);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 41);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Edit";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncetak
            // 
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btncetak.Location = new System.Drawing.Point(587, 349);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(117, 41);
            this.btncetak.TabIndex = 4;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = true;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // txtcari
            // 
            this.txtcari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcari.Location = new System.Drawing.Point(676, 35);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(175, 34);
            this.txtcari.TabIndex = 17;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cari";
            // 
            // f_petugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgtampil);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_petugas";
            this.Size = new System.Drawing.Size(953, 581);
            this.Load += new System.EventHandler(this.f_petugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtampil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgtampil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnotelepon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn u;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label9;
    }
}
