
namespace kasir_adi
{
    partial class f_laporan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmulai = new System.Windows.Forms.DateTimePicker();
            this.dtsampai = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnama = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.ComboBox();
            this.txtpilih = new System.Windows.Forms.ComboBox();
            this.dgtampil = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncari = new System.Windows.Forms.Button();
            this.btncetak = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtampil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Transaksi penjualan";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mulai";
            // 
            // dtmulai
            // 
            this.dtmulai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtmulai.Location = new System.Drawing.Point(55, 328);
            this.dtmulai.Name = "dtmulai";
            this.dtmulai.Size = new System.Drawing.Size(200, 34);
            this.dtmulai.TabIndex = 2;
            // 
            // dtsampai
            // 
            this.dtsampai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtsampai.Location = new System.Drawing.Point(281, 328);
            this.dtsampai.Name = "dtsampai";
            this.dtsampai.Size = new System.Drawing.Size(200, 34);
            this.dtsampai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sampai";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtpilih);
            this.panel1.Location = new System.Drawing.Point(503, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 178);
            this.panel1.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtnama.FormattingEnabled = true;
            this.txtnama.Location = new System.Drawing.Point(25, 110);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(153, 36);
            this.txtnama.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kasir";
            // 
            // txtid
            // 
            this.txtid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtid.FormattingEnabled = true;
            this.txtid.Location = new System.Drawing.Point(25, 68);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(153, 36);
            this.txtid.TabIndex = 1;
            // 
            // txtpilih
            // 
            this.txtpilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtpilih.FormattingEnabled = true;
            this.txtpilih.Items.AddRange(new object[] {
            "All",
            "Custom"});
            this.txtpilih.Location = new System.Drawing.Point(24, 25);
            this.txtpilih.Name = "txtpilih";
            this.txtpilih.Size = new System.Drawing.Size(153, 36);
            this.txtpilih.TabIndex = 0;
            this.txtpilih.SelectedIndexChanged += new System.EventHandler(this.txtpilih_SelectedIndexChanged);
            // 
            // dgtampil
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgtampil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtampil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtampil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtampil.ColumnHeadersHeight = 40;
            this.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtampil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtampil.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgtampil.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtampil.Location = new System.Drawing.Point(55, 68);
            this.dgtampil.Name = "dgtampil";
            this.dgtampil.ReadOnly = true;
            this.dgtampil.RowHeadersVisible = false;
            this.dgtampil.Size = new System.Drawing.Size(692, 181);
            this.dgtampil.TabIndex = 6;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgtampil.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtampil.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgtampil.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtampil.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtampil.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtampil.ThemeStyle.HeaderStyle.Height = 40;
            this.dgtampil.ThemeStyle.ReadOnly = true;
            this.dgtampil.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtampil.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgtampil.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtampil.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgtampil.ThemeStyle.RowsStyle.Height = 22;
            this.dgtampil.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtampil.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Transaksi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tanggal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kasir";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jenis Pesanan";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btncari
            // 
            this.btncari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncari.Location = new System.Drawing.Point(55, 377);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(94, 42);
            this.btncari.TabIndex = 7;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // btncetak
            // 
            this.btncetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Location = new System.Drawing.Point(155, 377);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(100, 42);
            this.btncetak.TabIndex = 8;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = true;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // f_laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.dgtampil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtsampai);
            this.Controls.Add(this.dtmulai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "f_laporan";
            this.Size = new System.Drawing.Size(844, 574);
            this.Load += new System.EventHandler(this.f_laporan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmulai;
        private System.Windows.Forms.DateTimePicker dtsampai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtnama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtid;
        private System.Windows.Forms.ComboBox txtpilih;
        private Guna.UI2.WinForms.Guna2DataGridView dgtampil;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
