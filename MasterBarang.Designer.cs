namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kodeBrg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_namaBrg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_persediaanBrg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hargaBrg = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.grd_Barang = new System.Windows.Forms.DataGridView();
            this.kode_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persediaan_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Barang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // txt_kodeBrg
            // 
            this.txt_kodeBrg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_kodeBrg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_kodeBrg.Location = new System.Drawing.Point(271, 93);
            this.txt_kodeBrg.Name = "txt_kodeBrg";
            this.txt_kodeBrg.Size = new System.Drawing.Size(364, 20);
            this.txt_kodeBrg.TabIndex = 4;
            this.txt_kodeBrg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Klik_enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nama Barang";
            // 
            // txt_namaBrg
            // 
            this.txt_namaBrg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_namaBrg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_namaBrg.Location = new System.Drawing.Point(271, 132);
            this.txt_namaBrg.Name = "txt_namaBrg";
            this.txt_namaBrg.Size = new System.Drawing.Size(364, 20);
            this.txt_namaBrg.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Persediaan Barang";
            // 
            // txt_persediaanBrg
            // 
            this.txt_persediaanBrg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_persediaanBrg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_persediaanBrg.Location = new System.Drawing.Point(271, 169);
            this.txt_persediaanBrg.Name = "txt_persediaanBrg";
            this.txt_persediaanBrg.Size = new System.Drawing.Size(90, 20);
            this.txt_persediaanBrg.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Harga Barang";
            // 
            // txt_hargaBrg
            // 
            this.txt_hargaBrg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_hargaBrg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_hargaBrg.Location = new System.Drawing.Point(271, 207);
            this.txt_hargaBrg.Name = "txt_hargaBrg";
            this.txt_hargaBrg.Size = new System.Drawing.Size(90, 20);
            this.txt_hargaBrg.TabIndex = 4;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.Gold;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.Location = new System.Drawing.Point(428, 246);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(94, 45);
            this.btn_simpan.TabIndex = 5;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Gold;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(542, 246);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(94, 45);
            this.btn_hapus.TabIndex = 5;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // grd_Barang
            // 
            this.grd_Barang.AllowUserToAddRows = false;
            this.grd_Barang.AllowUserToOrderColumns = true;
            this.grd_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Barang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_brg,
            this.id_brg,
            this.nama_brg,
            this.persediaan_brg,
            this.satuan_brg,
            this.harga_brg});
            this.grd_Barang.Location = new System.Drawing.Point(15, 304);
            this.grd_Barang.Name = "grd_Barang";
            this.grd_Barang.ReadOnly = true;
            this.grd_Barang.Size = new System.Drawing.Size(639, 243);
            this.grd_Barang.TabIndex = 6;
            this.grd_Barang.DoubleClick += new System.EventHandler(this.grd_Barang_DoubleClick);
            // 
            // kode_brg
            // 
            this.kode_brg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kode_brg.DataPropertyName = "kode_brg";
            this.kode_brg.HeaderText = "Kode Barang";
            this.kode_brg.Name = "kode_brg";
            this.kode_brg.ReadOnly = true;
            // 
            // id_brg
            // 
            this.id_brg.DataPropertyName = "id_brg";
            this.id_brg.HeaderText = "ID Barang";
            this.id_brg.Name = "id_brg";
            this.id_brg.ReadOnly = true;
            this.id_brg.Visible = false;
            // 
            // nama_brg
            // 
            this.nama_brg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_brg.DataPropertyName = "nama_brg";
            this.nama_brg.HeaderText = "Nama Barang";
            this.nama_brg.Name = "nama_brg";
            this.nama_brg.ReadOnly = true;
            // 
            // persediaan_brg
            // 
            this.persediaan_brg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.persediaan_brg.DataPropertyName = "persediaan_brg";
            this.persediaan_brg.HeaderText = "Persediaan Barang";
            this.persediaan_brg.Name = "persediaan_brg";
            this.persediaan_brg.ReadOnly = true;
            // 
            // satuan_brg
            // 
            this.satuan_brg.DataPropertyName = "satuan_brg";
            this.satuan_brg.HeaderText = "Satuan";
            this.satuan_brg.Name = "satuan_brg";
            this.satuan_brg.ReadOnly = true;
            // 
            // harga_brg
            // 
            this.harga_brg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harga_brg.DataPropertyName = "harga_brg";
            this.harga_brg.HeaderText = "Harga Barang";
            this.harga_brg.Name = "harga_brg";
            this.harga_brg.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(216, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input Data Barang";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAwalToolStripMenuItem,
            this.masterBarangToolStripMenuItem,
            this.masterTransaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAwalToolStripMenuItem
            // 
            this.menuAwalToolStripMenuItem.Name = "menuAwalToolStripMenuItem";
            this.menuAwalToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.menuAwalToolStripMenuItem.Text = "Menu Awal";
            this.menuAwalToolStripMenuItem.Click += new System.EventHandler(this.menuAwalToolStripMenuItem_Click);
            // 
            // masterBarangToolStripMenuItem
            // 
            this.masterBarangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahBarangToolStripMenuItem});
            this.masterBarangToolStripMenuItem.Name = "masterBarangToolStripMenuItem";
            this.masterBarangToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.masterBarangToolStripMenuItem.Text = "Master Barang";
            this.masterBarangToolStripMenuItem.Click += new System.EventHandler(this.masterBarangToolStripMenuItem_Click);
            // 
            // tambahBarangToolStripMenuItem
            // 
            this.tambahBarangToolStripMenuItem.Name = "tambahBarangToolStripMenuItem";
            this.tambahBarangToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tambahBarangToolStripMenuItem.Text = "Tambah Barang";
            this.tambahBarangToolStripMenuItem.Click += new System.EventHandler(this.tambahBarangToolStripMenuItem_Click);
            // 
            // masterTransaksiToolStripMenuItem
            // 
            this.masterTransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaksiBaruToolStripMenuItem,
            this.laporanToolStripMenuItem1});
            this.masterTransaksiToolStripMenuItem.Name = "masterTransaksiToolStripMenuItem";
            this.masterTransaksiToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.masterTransaksiToolStripMenuItem.Text = "Master Transaksi";
            this.masterTransaksiToolStripMenuItem.Click += new System.EventHandler(this.masterTransaksiToolStripMenuItem_Click);
            // 
            // transaksiBaruToolStripMenuItem
            // 
            this.transaksiBaruToolStripMenuItem.Name = "transaksiBaruToolStripMenuItem";
            this.transaksiBaruToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.transaksiBaruToolStripMenuItem.Text = "Transaksi Baru";
            this.transaksiBaruToolStripMenuItem.Click += new System.EventHandler(this.transaksiBaruToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem1
            // 
            this.laporanToolStripMenuItem1.Name = "laporanToolStripMenuItem1";
            this.laporanToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.laporanToolStripMenuItem1.Text = "Laporan";
            this.laporanToolStripMenuItem1.Click += new System.EventHandler(this.laporanToolStripMenuItem1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pcs",
            "Kg",
            "L",
            "1/2 kg",
            "1/4 kg"});
            this.comboBox1.Location = new System.Drawing.Point(367, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(666, 561);
            this.Controls.Add(this.txt_kodeBrg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_hargaBrg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grd_Barang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_namaBrg);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_persediaanBrg);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toko Ucok Batas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Barang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kodeBrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_namaBrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_persediaanBrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hargaBrg;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DataGridView grd_Barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterTransaksiToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem tambahBarangToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn persediaan_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_brg;
        private System.Windows.Forms.ToolStripMenuItem transaksiBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuAwalToolStripMenuItem;
    }
}

