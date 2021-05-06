namespace kasir_lks
{
    partial class MasterMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_file = new System.Windows.Forms.ToolStripMenuItem();
            this.m_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_masterdata = new System.Windows.Forms.ToolStripMenuItem();
            this.m_barang = new System.Windows.Forms.ToolStripMenuItem();
            this.m_costumer = new System.Windows.Forms.ToolStripMenuItem();
            this.m_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.m_user = new System.Windows.Forms.ToolStripMenuItem();
            this.m_transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.m_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pembelian = new System.Windows.Forms.ToolStripMenuItem();
            this.m_laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.l_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.l_pembelian = new System.Windows.Forms.ToolStripMenuItem();
            this.l_barang = new System.Windows.Forms.ToolStripMenuItem();
            this.l_costumer = new System.Windows.Forms.ToolStripMenuItem();
            this.l_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pengaturan = new System.Windows.Forms.ToolStripMenuItem();
            this.m_profile = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tentang = new System.Windows.Forms.ToolStripMenuItem();
            this.m_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.nama = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_file,
            this.m_masterdata,
            this.m_transaksi,
            this.m_laporan,
            this.m_pengaturan,
            this.m_tentang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_file
            // 
            this.m_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_logout,
            this.toolStripMenuItem1});
            this.m_file.Name = "m_file";
            this.m_file.Size = new System.Drawing.Size(37, 20);
            this.m_file.Text = "&File";
            // 
            // m_logout
            // 
            this.m_logout.Name = "m_logout";
            this.m_logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.m_logout.Size = new System.Drawing.Size(153, 22);
            this.m_logout.Text = "&Log Out";
            this.m_logout.Click += new System.EventHandler(this.m_logout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // m_masterdata
            // 
            this.m_masterdata.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_barang,
            this.m_costumer,
            this.m_supplier,
            this.m_user});
            this.m_masterdata.Name = "m_masterdata";
            this.m_masterdata.Size = new System.Drawing.Size(79, 20);
            this.m_masterdata.Text = "&MasterData";
            // 
            // m_barang
            // 
            this.m_barang.Name = "m_barang";
            this.m_barang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.m_barang.Size = new System.Drawing.Size(168, 22);
            this.m_barang.Text = "&Barang";
            this.m_barang.Click += new System.EventHandler(this.m_barang_Click);
            // 
            // m_costumer
            // 
            this.m_costumer.Name = "m_costumer";
            this.m_costumer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.m_costumer.Size = new System.Drawing.Size(168, 22);
            this.m_costumer.Text = "&Costumer";
            this.m_costumer.Click += new System.EventHandler(this.m_costumer_Click);
            // 
            // m_supplier
            // 
            this.m_supplier.Name = "m_supplier";
            this.m_supplier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.m_supplier.Size = new System.Drawing.Size(168, 22);
            this.m_supplier.Text = "&Supplier";
            this.m_supplier.Click += new System.EventHandler(this.m_supplier_Click);
            // 
            // m_user
            // 
            this.m_user.Name = "m_user";
            this.m_user.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.m_user.Size = new System.Drawing.Size(168, 22);
            this.m_user.Text = "&User";
            this.m_user.Click += new System.EventHandler(this.m_user_Click);
            // 
            // m_transaksi
            // 
            this.m_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_penjualan,
            this.m_pembelian});
            this.m_transaksi.Name = "m_transaksi";
            this.m_transaksi.Size = new System.Drawing.Size(67, 20);
            this.m_transaksi.Text = "&Transaksi";
            this.m_transaksi.Click += new System.EventHandler(this.m_transaksi_Click);
            // 
            // m_penjualan
            // 
            this.m_penjualan.Name = "m_penjualan";
            this.m_penjualan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.m_penjualan.Size = new System.Drawing.Size(167, 22);
            this.m_penjualan.Text = "&Penjualan";
            this.m_penjualan.Click += new System.EventHandler(this.m_penjualan_Click);
            // 
            // m_pembelian
            // 
            this.m_pembelian.Name = "m_pembelian";
            this.m_pembelian.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.m_pembelian.Size = new System.Drawing.Size(167, 22);
            this.m_pembelian.Text = "&Pembelian";
            this.m_pembelian.Click += new System.EventHandler(this.m_pembelian_Click);
            // 
            // m_laporan
            // 
            this.m_laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_penjualan,
            this.l_pembelian,
            this.l_barang,
            this.l_costumer,
            this.l_supplier});
            this.m_laporan.Name = "m_laporan";
            this.m_laporan.Size = new System.Drawing.Size(62, 20);
            this.m_laporan.Text = "&Laporan";
            // 
            // l_penjualan
            // 
            this.l_penjualan.Name = "l_penjualan";
            this.l_penjualan.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.J)));
            this.l_penjualan.Size = new System.Drawing.Size(249, 22);
            this.l_penjualan.Text = "&Laporan Penjualan";
            this.l_penjualan.Click += new System.EventHandler(this.penjualanToolStripMenuItem1_Click);
            // 
            // l_pembelian
            // 
            this.l_pembelian.Name = "l_pembelian";
            this.l_pembelian.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.l_pembelian.Size = new System.Drawing.Size(249, 22);
            this.l_pembelian.Text = "&Laporan Pembelian";
            // 
            // l_barang
            // 
            this.l_barang.Name = "l_barang";
            this.l_barang.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.l_barang.Size = new System.Drawing.Size(249, 22);
            this.l_barang.Text = "&Laporan Barang";
            // 
            // l_costumer
            // 
            this.l_costumer.Name = "l_costumer";
            this.l_costumer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.l_costumer.Size = new System.Drawing.Size(249, 22);
            this.l_costumer.Text = "Laporan Costumer";
            // 
            // l_supplier
            // 
            this.l_supplier.Name = "l_supplier";
            this.l_supplier.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.l_supplier.Size = new System.Drawing.Size(249, 22);
            this.l_supplier.Text = "Laporan Supplier";
            // 
            // m_pengaturan
            // 
            this.m_pengaturan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_profile});
            this.m_pengaturan.Name = "m_pengaturan";
            this.m_pengaturan.Size = new System.Drawing.Size(80, 20);
            this.m_pengaturan.Text = "&Pengaturan";
            // 
            // m_profile
            // 
            this.m_profile.Name = "m_profile";
            this.m_profile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.m_profile.Size = new System.Drawing.Size(167, 22);
            this.m_profile.Text = "&Edit Profile";
            this.m_profile.Click += new System.EventHandler(this.m_profile_Click);
            // 
            // m_tentang
            // 
            this.m_tentang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_about});
            this.m_tentang.Name = "m_tentang";
            this.m_tentang.Size = new System.Drawing.Size(62, 20);
            this.m_tentang.Text = "&Tentang";
            // 
            // m_about
            // 
            this.m_about.Name = "m_about";
            this.m_about.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.m_about.Size = new System.Drawing.Size(145, 22);
            this.m_about.Text = "&About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(485, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // nama
            // 
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(118, 17);
            this.nama.Text = "toolStripStatusLabel1";
            // 
            // MasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 306);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterMenu";
            this.Text = "MasterMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem m_file;
        public System.Windows.Forms.ToolStripMenuItem m_masterdata;
        public System.Windows.Forms.ToolStripMenuItem m_transaksi;
        public System.Windows.Forms.ToolStripMenuItem m_laporan;
        public System.Windows.Forms.ToolStripMenuItem m_pengaturan;
        public System.Windows.Forms.ToolStripMenuItem m_tentang;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem m_barang;
        public System.Windows.Forms.ToolStripMenuItem m_costumer;
        public System.Windows.Forms.ToolStripMenuItem m_supplier;
        public System.Windows.Forms.ToolStripMenuItem m_user;
        public System.Windows.Forms.ToolStripMenuItem m_profile;
        public System.Windows.Forms.ToolStripMenuItem m_about;
        public System.Windows.Forms.ToolStripMenuItem m_penjualan;
        public System.Windows.Forms.ToolStripMenuItem m_pembelian;
        public System.Windows.Forms.ToolStripMenuItem m_logout;
        public System.Windows.Forms.ToolStripMenuItem l_penjualan;
        public System.Windows.Forms.ToolStripMenuItem l_pembelian;
        public System.Windows.Forms.ToolStripMenuItem l_barang;
        public System.Windows.Forms.ToolStripMenuItem l_costumer;
        public System.Windows.Forms.ToolStripMenuItem l_supplier;
        private System.Windows.Forms.ToolStripStatusLabel nama;
    }
}