namespace WindowsFormsApp1
{
    partial class daftar_barang
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
            this.grd_Barang = new System.Windows.Forms.DataGridView();
            this.kode_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persediaan_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_brg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Barang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daftar Barang";
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
            this.grd_Barang.Location = new System.Drawing.Point(14, 91);
            this.grd_Barang.Name = "grd_Barang";
            this.grd_Barang.ReadOnly = true;
            this.grd_Barang.Size = new System.Drawing.Size(639, 458);
            this.grd_Barang.TabIndex = 7;
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
            // daftar_barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 561);
            this.Controls.Add(this.grd_Barang);
            this.Controls.Add(this.label1);
            this.Name = "daftar_barang";
            this.Text = "Toko Ucok Batas";
            ((System.ComponentModel.ISupportInitialize)(this.grd_Barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_Barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn persediaan_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan_brg;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_brg;
    }
}