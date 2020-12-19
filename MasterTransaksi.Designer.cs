namespace WindowsFormsApp1
{
    partial class MasterTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterTransaksi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cariBrg = new System.Windows.Forms.TextBox();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.grdTransaksi = new System.Windows.Forms.DataGridView();
            this.clmTanggalTrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeTrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHargaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKuantitasBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotHargaTrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_trs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_trs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_trs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totHarga_trs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBarangBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hargaBrg = new System.Windows.Forms.TextBox();
            this.txt_namaBrg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_masukan = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.recordDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.grd_brg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaksi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_brg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(456, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaksi Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(16, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah";
            // 
            // txt_cariBrg
            // 
            this.txt_cariBrg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_cariBrg.Location = new System.Drawing.Point(159, 132);
            this.txt_cariBrg.Name = "txt_cariBrg";
            this.txt_cariBrg.Size = new System.Drawing.Size(220, 20);
            this.txt_cariBrg.TabIndex = 4;
            this.txt_cariBrg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Klik_enter);
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_jumlah.Location = new System.Drawing.Point(159, 220);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(92, 20);
            this.txt_jumlah.TabIndex = 4;
            // 
            // grdTransaksi
            // 
            this.grdTransaksi.AllowUserToAddRows = false;
            this.grdTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTanggalTrs,
            this.clmKodeTrs,
            this.clmNamaBarang,
            this.clmHargaBrg,
            this.clmKuantitasBrg,
            this.clmTotHargaTrs});
            this.grdTransaksi.Location = new System.Drawing.Point(14, 306);
            this.grdTransaksi.Name = "grdTransaksi";
            this.grdTransaksi.ReadOnly = true;
            this.grdTransaksi.Size = new System.Drawing.Size(642, 243);
            this.grdTransaksi.TabIndex = 5;
            // 
            // clmTanggalTrs
            // 
            this.clmTanggalTrs.DataPropertyName = "tgl_trs";
            this.clmTanggalTrs.HeaderText = "Tanggal";
            this.clmTanggalTrs.Name = "clmTanggalTrs";
            this.clmTanggalTrs.ReadOnly = true;
            // 
            // clmKodeTrs
            // 
            this.clmKodeTrs.DataPropertyName = "kode_trs";
            this.clmKodeTrs.HeaderText = "Kode Transaksi";
            this.clmKodeTrs.Name = "clmKodeTrs";
            this.clmKodeTrs.ReadOnly = true;
            // 
            // clmNamaBarang
            // 
            this.clmNamaBarang.DataPropertyName = "nama_brg";
            this.clmNamaBarang.HeaderText = "Nama Barang";
            this.clmNamaBarang.Name = "clmNamaBarang";
            this.clmNamaBarang.ReadOnly = true;
            // 
            // clmHargaBrg
            // 
            this.clmHargaBrg.DataPropertyName = "harga_brg";
            this.clmHargaBrg.HeaderText = "Harga per Satuan";
            this.clmHargaBrg.Name = "clmHargaBrg";
            this.clmHargaBrg.ReadOnly = true;
            // 
            // clmKuantitasBrg
            // 
            this.clmKuantitasBrg.DataPropertyName = "kuantitasBrg_trs";
            this.clmKuantitasBrg.HeaderText = "Jumlah";
            this.clmKuantitasBrg.Name = "clmKuantitasBrg";
            this.clmKuantitasBrg.ReadOnly = true;
            // 
            // clmTotHargaTrs
            // 
            this.clmTotHargaTrs.DataPropertyName = "totHarga_trs";
            this.clmTotHargaTrs.HeaderText = "Total Harga";
            this.clmTotHargaTrs.Name = "clmTotHargaTrs";
            this.clmTotHargaTrs.ReadOnly = true;
            // 
            // id_trs
            // 
            this.id_trs.HeaderText = "ID";
            this.id_trs.Name = "id_trs";
            this.id_trs.ReadOnly = true;
            this.id_trs.Visible = false;
            // 
            // tgl_trs
            // 
            this.tgl_trs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tgl_trs.DataPropertyName = "tgl_trs";
            this.tgl_trs.HeaderText = "Tanggal";
            this.tgl_trs.Name = "tgl_trs";
            this.tgl_trs.ReadOnly = true;
            // 
            // kode_trs
            // 
            this.kode_trs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kode_trs.DataPropertyName = "kode_trs";
            this.kode_trs.HeaderText = "Kode Transaksi";
            this.kode_trs.Name = "kode_trs";
            this.kode_trs.ReadOnly = true;
            // 
            // nama_brg
            // 
            this.nama_brg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_brg.DataPropertyName = "nama_brg";
            this.nama_brg.HeaderText = "Nama Barang";
            this.nama_brg.Name = "nama_brg";
            this.nama_brg.ReadOnly = true;
            // 
            // jumlah_brg
            // 
            this.jumlah_brg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jumlah_brg.DataPropertyName = "kuantitasBrg_trs";
            this.jumlah_brg.HeaderText = "Jumlah";
            this.jumlah_brg.Name = "jumlah_brg";
            this.jumlah_brg.ReadOnly = true;
            // 
            // totHarga_trs
            // 
            this.totHarga_trs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totHarga_trs.DataPropertyName = "totHarga_trs";
            this.totHarga_trs.HeaderText = "Total";
            this.totHarga_trs.Name = "totHarga_trs";
            this.totHarga_trs.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bayar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAwalToolStripMenuItem,
            this.masterBarangToolStripMenuItem,
            this.masterTransaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.tambahBarangBaruToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.masterBarangToolStripMenuItem.Name = "masterBarangToolStripMenuItem";
            this.masterBarangToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.masterBarangToolStripMenuItem.Text = "Master Barang";
            this.masterBarangToolStripMenuItem.Click += new System.EventHandler(this.masterBarangToolStripMenuItem_Click);
            // 
            // tambahBarangBaruToolStripMenuItem
            // 
            this.tambahBarangBaruToolStripMenuItem.Name = "tambahBarangBaruToolStripMenuItem";
            this.tambahBarangBaruToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tambahBarangBaruToolStripMenuItem.Text = "Tambah Barang";
            this.tambahBarangBaruToolStripMenuItem.Click += new System.EventHandler(this.tambahBarangBaruToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // masterTransaksiToolStripMenuItem
            // 
            this.masterTransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaksiBaruToolStripMenuItem,
            this.laporanToolStripMenuItem1});
            this.masterTransaksiToolStripMenuItem.Name = "masterTransaksiToolStripMenuItem";
            this.masterTransaksiToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.masterTransaksiToolStripMenuItem.Text = "Master Transaksi";
            // 
            // transaksiBaruToolStripMenuItem
            // 
            this.transaksiBaruToolStripMenuItem.Name = "transaksiBaruToolStripMenuItem";
            this.transaksiBaruToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transaksiBaruToolStripMenuItem.Text = "Transaksi Baru";
            this.transaksiBaruToolStripMenuItem.Click += new System.EventHandler(this.transaksiBaruToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem1
            // 
            this.laporanToolStripMenuItem1.Name = "laporanToolStripMenuItem1";
            this.laporanToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.laporanToolStripMenuItem1.Text = "Laporan";
            this.laporanToolStripMenuItem1.Click += new System.EventHandler(this.laporanToolStripMenuItem1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(16, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Harga per Satuan";
            // 
            // txt_hargaBrg
            // 
            this.txt_hargaBrg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_hargaBrg.Location = new System.Drawing.Point(159, 194);
            this.txt_hargaBrg.Name = "txt_hargaBrg";
            this.txt_hargaBrg.Size = new System.Drawing.Size(92, 20);
            this.txt_hargaBrg.TabIndex = 4;
            this.txt_hargaBrg.Enter += new System.EventHandler(this.txt_kodeTrs_Enter);
            // 
            // txt_namaBrg
            // 
            this.txt_namaBrg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_namaBrg.Location = new System.Drawing.Point(159, 168);
            this.txt_namaBrg.Name = "txt_namaBrg";
            this.txt_namaBrg.Size = new System.Drawing.Size(220, 20);
            this.txt_namaBrg.TabIndex = 4;
            this.txt_namaBrg.Enter += new System.EventHandler(this.txt_kodeTrs_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total : ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(385, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(194, 108);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(429, 258);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 20);
            this.lbl_total.TabIndex = 13;
            // 
            // btn_masukan
            // 
            this.btn_masukan.Location = new System.Drawing.Point(266, 258);
            this.btn_masukan.Name = "btn_masukan";
            this.btn_masukan.Size = new System.Drawing.Size(92, 31);
            this.btn_masukan.TabIndex = 14;
            this.btn_masukan.Text = "Beli";
            this.btn_masukan.UseVisualStyleBackColor = true;
            this.btn_masukan.Click += new System.EventHandler(this.btn_beli_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(579, 132);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(75, 108);
            this.listBox2.TabIndex = 16;
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nama Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Jumlah";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(385, 238);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(32, 17);
            this.listBox3.TabIndex = 19;
            this.listBox3.Visible = false;
            // 
            // recordDoc
            // 
            this.recordDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.recordDoc;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // grd_brg
            // 
            this.grd_brg.AllowUserToAddRows = false;
            this.grd_brg.AllowUserToDeleteRows = false;
            this.grd_brg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_brg.Location = new System.Drawing.Point(674, 132);
            this.grd_brg.Name = "grd_brg";
            this.grd_brg.ReadOnly = true;
            this.grd_brg.Size = new System.Drawing.Size(659, 417);
            this.grd_brg.TabIndex = 20;
            this.grd_brg.DoubleClick += new System.EventHandler(this.grd_Barang_DoubleClick);
            // 
            // MasterTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.grd_brg);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_masukan);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdTransaksi);
            this.Controls.Add(this.txt_jumlah);
            this.Controls.Add(this.txt_hargaBrg);
            this.Controls.Add(this.txt_namaBrg);
            this.Controls.Add(this.txt_cariBrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toko Ucok Batas";
            this.Load += new System.EventHandler(this.MasterTransaksi_Load);
            this.DoubleClick += new System.EventHandler(this.MasterTransaksi_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaksi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_brg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cariBrg;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.DataGridView grdTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_trs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_trs;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_trs;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn totHarga_trs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterTransaksiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTanggalTrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeTrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHargaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKuantitasBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotHargaTrs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hargaBrg;
        private System.Windows.Forms.TextBox txt_namaBrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_masukan;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox3;
        private System.Drawing.Printing.PrintDocument recordDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem transaksiBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahBarangBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.DataGridView grd_brg;
        private System.Windows.Forms.ToolStripMenuItem menuAwalToolStripMenuItem;
    }
}