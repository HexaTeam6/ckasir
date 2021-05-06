namespace kasir_lks
{
    partial class Supplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_kode = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.t_hp = new System.Windows.Forms.TextBox();
            this.t_alamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_new = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 58);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "KodeSupplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telepon";
            // 
            // t_kode
            // 
            this.t_kode.Enabled = false;
            this.t_kode.Location = new System.Drawing.Point(111, 19);
            this.t_kode.Name = "t_kode";
            this.t_kode.Size = new System.Drawing.Size(242, 20);
            this.t_kode.TabIndex = 33;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(111, 49);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(242, 20);
            this.t_nama.TabIndex = 34;
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(111, 84);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(242, 20);
            this.t_hp.TabIndex = 35;
            // 
            // t_alamat
            // 
            this.t_alamat.Location = new System.Drawing.Point(111, 112);
            this.t_alamat.Multiline = true;
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(242, 58);
            this.t_alamat.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Alamat";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.t_cari);
            this.groupBox1.Controls.Add(this.t_kode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t_alamat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.t_hp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.t_nama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 185);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.table);
            this.groupBox3.Location = new System.Drawing.Point(12, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 362);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(6, 10);
            this.table.Name = "table";
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(601, 346);
            this.table.TabIndex = 0;
            this.table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.b_exit);
            this.groupBox2.Controls.Add(this.b_cancel);
            this.groupBox2.Controls.Add(this.b_delete);
            this.groupBox2.Controls.Add(this.b_new);
            this.groupBox2.Controls.Add(this.b_edit);
            this.groupBox2.Controls.Add(this.b_simpan);
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 65);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.b_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.Location = new System.Drawing.Point(498, 19);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(88, 33);
            this.b_exit.TabIndex = 46;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.b_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel.FlatAppearance.BorderSize = 0;
            this.b_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel.ForeColor = System.Drawing.Color.White;
            this.b_cancel.Location = new System.Drawing.Point(310, 19);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(88, 33);
            this.b_cancel.TabIndex = 45;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.b_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_delete.FlatAppearance.BorderSize = 0;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.ForeColor = System.Drawing.Color.White;
            this.b_delete.Location = new System.Drawing.Point(404, 19);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(88, 33);
            this.b_delete.TabIndex = 44;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_new
            // 
            this.b_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.b_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_new.FlatAppearance.BorderSize = 0;
            this.b_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_new.ForeColor = System.Drawing.Color.White;
            this.b_new.Location = new System.Drawing.Point(216, 19);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(88, 33);
            this.b_new.TabIndex = 43;
            this.b_new.Text = "New";
            this.b_new.UseVisualStyleBackColor = false;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // b_edit
            // 
            this.b_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.b_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_edit.FlatAppearance.BorderSize = 0;
            this.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_edit.ForeColor = System.Drawing.Color.White;
            this.b_edit.Location = new System.Drawing.Point(122, 19);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(88, 33);
            this.b_edit.TabIndex = 42;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = false;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.b_simpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_simpan.FlatAppearance.BorderSize = 0;
            this.b_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_simpan.ForeColor = System.Drawing.Color.White;
            this.b_simpan.Location = new System.Drawing.Point(28, 19);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(88, 33);
            this.b_simpan.TabIndex = 41;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = false;
            this.b_simpan.Click += new System.EventHandler(this.b_simpan_Click);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(440, 150);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(167, 20);
            this.t_cari.TabIndex = 42;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cari";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 702);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_kode;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.TextBox t_alamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_simpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_cari;
    }
}