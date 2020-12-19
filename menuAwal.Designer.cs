namespace WindowsFormsApp1
{
    partial class menuAwal
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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(78, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(713, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aplikasi kasir toko Ucok berbasis desktop dengan menggunakan bahasa C#";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAwalToolStripMenuItem,
            this.masterBarangToolStripMenuItem,
            this.masterTransaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAwalToolStripMenuItem
            // 
            this.menuAwalToolStripMenuItem.Name = "menuAwalToolStripMenuItem";
            this.menuAwalToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.menuAwalToolStripMenuItem.Text = "Menu Awal";
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
            // menuAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toko Ucok";
            this.Load += new System.EventHandler(this.menuAwal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem1;
    }
}