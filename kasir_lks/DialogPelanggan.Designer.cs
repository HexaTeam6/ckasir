namespace kasir_lks
{
    partial class DialogPelanggan
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
            this.label6 = new System.Windows.Forms.Label();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.dataGridView1_pelanggan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_pelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cari Pelanggan(Kode/Nama)";
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(158, 13);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(213, 20);
            this.t_cari.TabIndex = 49;
            this.t_cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // dataGridView1_pelanggan
            // 
            this.dataGridView1_pelanggan.AllowUserToAddRows = false;
            this.dataGridView1_pelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_pelanggan.Location = new System.Drawing.Point(11, 48);
            this.dataGridView1_pelanggan.Name = "dataGridView1_pelanggan";
            this.dataGridView1_pelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_pelanggan.Size = new System.Drawing.Size(704, 253);
            this.dataGridView1_pelanggan.TabIndex = 47;
            this.dataGridView1_pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_pelanggan_CellContentClick);
            this.dataGridView1_pelanggan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_pelanggan_CellDoubleClick);
            // 
            // DialogPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 315);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.dataGridView1_pelanggan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "->Cari Pelanggan<-";
            this.Load += new System.EventHandler(this.DialogPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_pelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.DataGridView dataGridView1_pelanggan;
    }
}