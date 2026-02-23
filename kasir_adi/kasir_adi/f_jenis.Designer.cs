
namespace kasir_adi
{
    partial class f_jenis
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
            this.txtcari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgtampil = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtampil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcari
            // 
            this.txtcari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcari.Location = new System.Drawing.Point(761, 28);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(175, 34);
            this.txtcari.TabIndex = 24;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cari";
            // 
            // btnupdate
            // 
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnupdate.Location = new System.Drawing.Point(456, 345);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 41);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btndelete.Location = new System.Drawing.Point(333, 345);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 41);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtstatus);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnsimpan);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel1.Location = new System.Drawing.Point(28, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 384);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jenis Menu";
            // 
            // txtstatus
            // 
            this.txtstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "",
            "aktif",
            "nonaktif"});
            this.txtstatus.Location = new System.Drawing.Point(20, 210);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(176, 28);
            this.txtstatus.TabIndex = 13;
            // 
            // btnnew
            // 
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnnew.Location = new System.Drawing.Point(22, 254);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(65, 35);
            this.btnnew.TabIndex = 16;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Location = new System.Drawing.Point(93, 254);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(103, 35);
            this.btnsimpan.TabIndex = 15;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(22, 149);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(175, 27);
            this.txtnama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Jenis";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(22, 83);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(175, 27);
            this.txtid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Jenis";
            // 
            // dgtampil
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgtampil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtampil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtampil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtampil.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgtampil.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgtampil.Location = new System.Drawing.Point(334, 64);
            this.dgtampil.Margin = new System.Windows.Forms.Padding(4);
            this.dgtampil.Name = "dgtampil";
            this.dgtampil.ReadOnly = true;
            this.dgtampil.RowHeadersVisible = false;
            this.dgtampil.RowTemplate.Height = 40;
            this.dgtampil.Size = new System.Drawing.Size(602, 269);
            this.dgtampil.TabIndex = 19;
            this.dgtampil.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgtampil.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgtampil.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtampil.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtampil.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtampil.ThemeStyle.HeaderStyle.Height = 44;
            this.dgtampil.ThemeStyle.ReadOnly = true;
            this.dgtampil.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgtampil.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgtampil.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtampil.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgtampil.ThemeStyle.RowsStyle.Height = 40;
            this.dgtampil.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgtampil.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgtampil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtampil_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_jenis";
            this.Column1.HeaderText = "ID Jenis";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama_jenis";
            this.Column2.HeaderText = "Nama Jenis";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "status_jenis";
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // f_jenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgtampil);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "f_jenis";
            this.Size = new System.Drawing.Size(1043, 563);
            this.Load += new System.EventHandler(this.f_jenis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgtampil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
    }
}
