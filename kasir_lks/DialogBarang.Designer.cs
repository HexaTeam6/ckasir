namespace kasir_lks
{
    partial class DialogBarang
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
            this.dg_barang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.t_cari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_barang
            // 
            this.dg_barang.AllowUserToAddRows = false;
            this.dg_barang.AllowUserToDeleteRows = false;
            this.dg_barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_barang.Location = new System.Drawing.Point(13, 50);
            this.dg_barang.Name = "dg_barang";
            this.dg_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_barang.Size = new System.Drawing.Size(704, 253);
            this.dg_barang.TabIndex = 0;
            this.dg_barang.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_barang_CellMouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cari Barang (Kode/Nama)";
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(160, 15);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(213, 20);
            this.t_cari.TabIndex = 46;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 315);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.dg_barang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "->CariBarang<-";
            this.Load += new System.EventHandler(this.DialogBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_barang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_cari;
    }
}