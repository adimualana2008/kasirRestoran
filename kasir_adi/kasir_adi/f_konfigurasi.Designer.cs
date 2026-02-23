
namespace kasir_adi
{
    partial class f_konfigurasi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtpajak = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpajak)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsimpan);
            this.panel1.Controls.Add(this.txtpajak);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtalamat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 431);
            this.panel1.TabIndex = 0;
            // 
            // btnsimpan
            // 
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Location = new System.Drawing.Point(58, 376);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(154, 42);
            this.btnsimpan.TabIndex = 1;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // txtpajak
            // 
            this.txtpajak.Location = new System.Drawing.Point(137, 328);
            this.txtpajak.Name = "txtpajak";
            this.txtpajak.Size = new System.Drawing.Size(108, 34);
            this.txtpajak.TabIndex = 1;
            this.txtpajak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpajak_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pajak ( % )";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(34, 241);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(211, 69);
            this.txtalamat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alamat";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(34, 173);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(211, 34);
            this.txtno.TabIndex = 4;
            this.txtno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "No telepon";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(34, 100);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(211, 34);
            this.txtnama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Restoran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konfiguarasi";
            // 
            // f_konfigurasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "f_konfigurasi";
            this.Size = new System.Drawing.Size(436, 544);
            this.Load += new System.EventHandler(this.f_konfigurasi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpajak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.NumericUpDown txtpajak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
