namespace kasir_lks
{
    partial class Pembelian
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
            this.cari_barang = new System.Windows.Forms.Button();
            this.t_barang = new System.Windows.Forms.TextBox();
            this.t_Supp = new System.Windows.Forms.TextBox();
            this.kd_barang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.b_new = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cari_supplier = new System.Windows.Forms.Button();
            this.kd_supp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.t_kasir = new System.Windows.Forms.Label();
            this.t_diskon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_jumlah = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_harga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_tambah = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.t_totalbayar = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.TextBox();
            this.b_hapus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cari_barang
            // 
            this.cari_barang.Location = new System.Drawing.Point(356, 81);
            this.cari_barang.Name = "cari_barang";
            this.cari_barang.Size = new System.Drawing.Size(39, 23);
            this.cari_barang.TabIndex = 21;
            this.cari_barang.Text = "...";
            this.cari_barang.UseVisualStyleBackColor = true;
            this.cari_barang.Click += new System.EventHandler(this.cari_barang_Click);
            // 
            // t_barang
            // 
            this.t_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_barang.Location = new System.Drawing.Point(193, 82);
            this.t_barang.Name = "t_barang";
            this.t_barang.Size = new System.Drawing.Size(157, 21);
            this.t_barang.TabIndex = 19;
            // 
            // t_Supp
            // 
            this.t_Supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Supp.Location = new System.Drawing.Point(193, 53);
            this.t_Supp.Name = "t_Supp";
            this.t_Supp.Size = new System.Drawing.Size(157, 21);
            this.t_Supp.TabIndex = 18;
            // 
            // kd_barang
            // 
            this.kd_barang.Enabled = false;
            this.kd_barang.Location = new System.Drawing.Point(107, 84);
            this.kd_barang.Name = "kd_barang";
            this.kd_barang.Size = new System.Drawing.Size(80, 20);
            this.kd_barang.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Cari Barang";
            // 
            // b_new
            // 
            this.b_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.b_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_new.FlatAppearance.BorderSize = 0;
            this.b_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_new.ForeColor = System.Drawing.Color.White;
            this.b_new.Location = new System.Drawing.Point(685, 537);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(149, 47);
            this.b_new.TabIndex = 57;
            this.b_new.Text = "New";
            this.b_new.UseVisualStyleBackColor = false;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.b_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_save.FlatAppearance.BorderSize = 0;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_save.ForeColor = System.Drawing.Color.White;
            this.b_save.Location = new System.Drawing.Point(685, 481);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(149, 49);
            this.b_save.TabIndex = 56;
            this.b_save.Text = "Simpan";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PEMBELIAN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 52);
            this.panel1.TabIndex = 50;
            // 
            // cari_supplier
            // 
            this.cari_supplier.Location = new System.Drawing.Point(356, 50);
            this.cari_supplier.Name = "cari_supplier";
            this.cari_supplier.Size = new System.Drawing.Size(39, 23);
            this.cari_supplier.TabIndex = 20;
            this.cari_supplier.Text = "...";
            this.cari_supplier.UseVisualStyleBackColor = true;
            this.cari_supplier.Click += new System.EventHandler(this.cari_supplier_Click);
            // 
            // kd_supp
            // 
            this.kd_supp.Enabled = false;
            this.kd_supp.Location = new System.Drawing.Point(107, 54);
            this.kd_supp.Name = "kd_supp";
            this.kd_supp.Size = new System.Drawing.Size(80, 20);
            this.kd_supp.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.t_kasir);
            this.groupBox1.Controls.Add(this.t_diskon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cari_barang);
            this.groupBox1.Controls.Add(this.cari_supplier);
            this.groupBox1.Controls.Add(this.t_barang);
            this.groupBox1.Controls.Add(this.t_Supp);
            this.groupBox1.Controls.Add(this.kd_barang);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.kd_supp);
            this.groupBox1.Controls.Add(this.t_jumlah);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Controls.Add(this.t_harga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 145);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "::Form::";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Kasir";
            // 
            // t_kasir
            // 
            this.t_kasir.AutoSize = true;
            this.t_kasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_kasir.Location = new System.Drawing.Point(104, 115);
            this.t_kasir.Name = "t_kasir";
            this.t_kasir.Size = new System.Drawing.Size(51, 16);
            this.t_kasir.TabIndex = 24;
            this.t_kasir.Text = "Jumlah";
            // 
            // t_diskon
            // 
            this.t_diskon.Location = new System.Drawing.Point(521, 111);
            this.t_diskon.Name = "t_diskon";
            this.t_diskon.Size = new System.Drawing.Size(211, 20);
            this.t_diskon.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Diskon";
            // 
            // t_jumlah
            // 
            this.t_jumlah.Location = new System.Drawing.Point(521, 82);
            this.t_jumlah.Name = "t_jumlah";
            this.t_jumlah.Size = new System.Drawing.Size(211, 20);
            this.t_jumlah.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(521, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // t_id
            // 
            this.t_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id.Location = new System.Drawing.Point(107, 19);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(288, 21);
            this.t_id.TabIndex = 8;
            // 
            // t_harga
            // 
            this.t_harga.Enabled = false;
            this.t_harga.Location = new System.Drawing.Point(521, 50);
            this.t_harga.Name = "t_harga";
            this.t_harga.Size = new System.Drawing.Size(211, 20);
            this.t_harga.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "No Faktur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tanggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jumlah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // b_tambah
            // 
            this.b_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.b_tambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_tambah.FlatAppearance.BorderSize = 0;
            this.b_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_tambah.ForeColor = System.Drawing.Color.White;
            this.b_tambah.Location = new System.Drawing.Point(16, 19);
            this.b_tambah.Name = "b_tambah";
            this.b_tambah.Size = new System.Drawing.Size(88, 33);
            this.b_tambah.TabIndex = 47;
            this.b_tambah.Text = "Tambah";
            this.b_tambah.UseVisualStyleBackColor = false;
            this.b_tambah.Click += new System.EventHandler(this.b_tambah_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Jumlah Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total   Rp.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.t_totalbayar);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.t_total);
            this.groupBox5.Location = new System.Drawing.Point(15, 473);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(651, 113);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detail";
            // 
            // t_totalbayar
            // 
            this.t_totalbayar.AutoSize = true;
            this.t_totalbayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_totalbayar.Location = new System.Drawing.Point(328, 31);
            this.t_totalbayar.Name = "t_totalbayar";
            this.t_totalbayar.Size = new System.Drawing.Size(27, 29);
            this.t_totalbayar.TabIndex = 16;
            this.t_totalbayar.Text = "0";
            // 
            // t_total
            // 
            this.t_total.Enabled = false;
            this.t_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_total.Location = new System.Drawing.Point(130, 28);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(117, 21);
            this.t_total.TabIndex = 14;
            // 
            // b_hapus
            // 
            this.b_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.b_hapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_hapus.FlatAppearance.BorderSize = 0;
            this.b_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_hapus.ForeColor = System.Drawing.Color.White;
            this.b_hapus.Location = new System.Drawing.Point(16, 80);
            this.b_hapus.Name = "b_hapus";
            this.b_hapus.Size = new System.Drawing.Size(88, 33);
            this.b_hapus.TabIndex = 49;
            this.b_hapus.Text = "Hapus";
            this.b_hapus.UseVisualStyleBackColor = false;
            this.b_hapus.Click += new System.EventHandler(this.b_hapus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(833, 222);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(15, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 259);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "::Data::";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_hapus);
            this.groupBox2.Controls.Add(this.b_tambah);
            this.groupBox2.Location = new System.Drawing.Point(759, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 145);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "::Aksi::";
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 593);
            this.Controls.Add(this.b_new);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Pembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.Pembelian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cari_barang;
        private System.Windows.Forms.TextBox t_barang;
        private System.Windows.Forms.TextBox t_Supp;
        private System.Windows.Forms.TextBox kd_barang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cari_supplier;
        private System.Windows.Forms.TextBox kd_supp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_jumlah;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.TextBox t_harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_tambah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.Button b_hapus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label t_totalbayar;
        private System.Windows.Forms.TextBox t_diskon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label t_kasir;
    }
}