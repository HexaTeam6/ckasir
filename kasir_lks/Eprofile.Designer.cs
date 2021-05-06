namespace kasir_lks
{
    partial class Eprofile
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelwkwk = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.b_update = new System.Windows.Forms.Button();
            this.t_pegawai = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.t_telepon = new System.Windows.Forms.TextBox();
            this.t_username = new System.Windows.Forms.TextBox();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.t_confirm = new System.Windows.Forms.TextBox();
            this.t_passlama = new System.Windows.Forms.TextBox();
            this.t_alamat = new System.Windows.Forms.TextBox();
            this.b_batal = new System.Windows.Forms.Button();
            this.b_ubah = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Profile";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Pegawai";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "username";
            // 
            // labelwkwk
            // 
            this.labelwkwk.AutoSize = true;
            this.labelwkwk.Location = new System.Drawing.Point(33, 288);
            this.labelwkwk.Name = "labelwkwk";
            this.labelwkwk.Size = new System.Drawing.Size(52, 13);
            this.labelwkwk.TabIndex = 6;
            this.labelwkwk.Text = "password";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(33, 322);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(91, 13);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Confirm Password";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(33, 356);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(82, 13);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Password Lama";
            // 
            // b_update
            // 
            this.b_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.b_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_update.FlatAppearance.BorderSize = 0;
            this.b_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_update.ForeColor = System.Drawing.Color.White;
            this.b_update.Location = new System.Drawing.Point(36, 395);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(164, 33);
            this.b_update.TabIndex = 10;
            this.b_update.Text = "Simpan";
            this.b_update.UseVisualStyleBackColor = false;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // t_pegawai
            // 
            this.t_pegawai.Enabled = false;
            this.t_pegawai.Location = new System.Drawing.Point(139, 89);
            this.t_pegawai.Name = "t_pegawai";
            this.t_pegawai.Size = new System.Drawing.Size(242, 20);
            this.t_pegawai.TabIndex = 0;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(139, 119);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(242, 20);
            this.t_nama.TabIndex = 1;
            // 
            // t_telepon
            // 
            this.t_telepon.Location = new System.Drawing.Point(139, 217);
            this.t_telepon.Name = "t_telepon";
            this.t_telepon.Size = new System.Drawing.Size(242, 20);
            this.t_telepon.TabIndex = 3;
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(139, 252);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(242, 20);
            this.t_username.TabIndex = 4;
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(139, 285);
            this.t_pass.Name = "t_pass";
            this.t_pass.PasswordChar = '.';
            this.t_pass.Size = new System.Drawing.Size(177, 20);
            this.t_pass.TabIndex = 5;
            this.t_pass.UseSystemPasswordChar = true;
            // 
            // t_confirm
            // 
            this.t_confirm.BackColor = System.Drawing.Color.White;
            this.t_confirm.Location = new System.Drawing.Point(139, 319);
            this.t_confirm.Name = "t_confirm";
            this.t_confirm.PasswordChar = '.';
            this.t_confirm.Size = new System.Drawing.Size(177, 20);
            this.t_confirm.TabIndex = 6;
            this.t_confirm.UseSystemPasswordChar = true;
            this.t_confirm.Leave += new System.EventHandler(this.t_confirm_Leave);
            // 
            // t_passlama
            // 
            this.t_passlama.Location = new System.Drawing.Point(139, 349);
            this.t_passlama.Name = "t_passlama";
            this.t_passlama.PasswordChar = '.';
            this.t_passlama.Size = new System.Drawing.Size(177, 20);
            this.t_passlama.TabIndex = 7;
            this.t_passlama.UseSystemPasswordChar = true;
            this.t_passlama.Leave += new System.EventHandler(this.t_passlama_Leave);
            // 
            // t_alamat
            // 
            this.t_alamat.Location = new System.Drawing.Point(139, 154);
            this.t_alamat.Multiline = true;
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(242, 47);
            this.t_alamat.TabIndex = 2;
            // 
            // b_batal
            // 
            this.b_batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.b_batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_batal.FlatAppearance.BorderSize = 0;
            this.b_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_batal.ForeColor = System.Drawing.Color.White;
            this.b_batal.Location = new System.Drawing.Point(223, 395);
            this.b_batal.Name = "b_batal";
            this.b_batal.Size = new System.Drawing.Size(158, 33);
            this.b_batal.TabIndex = 11;
            this.b_batal.Text = "Batal";
            this.b_batal.UseVisualStyleBackColor = false;
            this.b_batal.Click += new System.EventHandler(this.b_batal_Click);
            // 
            // b_ubah
            // 
            this.b_ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.b_ubah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_ubah.FlatAppearance.BorderSize = 0;
            this.b_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ubah.ForeColor = System.Drawing.Color.White;
            this.b_ubah.Location = new System.Drawing.Point(322, 285);
            this.b_ubah.Name = "b_ubah";
            this.b_ubah.Size = new System.Drawing.Size(59, 36);
            this.b_ubah.TabIndex = 8;
            this.b_ubah.Text = "Change";
            this.b_ubah.UseVisualStyleBackColor = false;
            this.b_ubah.Click += new System.EventHandler(this.b_ubah_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.b_simpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_simpan.FlatAppearance.BorderSize = 0;
            this.b_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_simpan.ForeColor = System.Drawing.Color.White;
            this.b_simpan.Location = new System.Drawing.Point(322, 333);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(59, 36);
            this.b_simpan.TabIndex = 9;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = false;
            this.b_simpan.Click += new System.EventHandler(this.b_simpan_Click);
            // 
            // Eprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 459);
            this.Controls.Add(this.b_simpan);
            this.Controls.Add(this.b_batal);
            this.Controls.Add(this.t_alamat);
            this.Controls.Add(this.t_passlama);
            this.Controls.Add(this.t_confirm);
            this.Controls.Add(this.t_pass);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.t_telepon);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.t_pegawai);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.labelwkwk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_ubah);
            this.Name = "Eprofile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Eprofile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelwkwk;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.TextBox t_pegawai;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.TextBox t_telepon;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.TextBox t_confirm;
        private System.Windows.Forms.TextBox t_passlama;
        private System.Windows.Forms.TextBox t_alamat;
        private System.Windows.Forms.Button b_batal;
        private System.Windows.Forms.Button b_ubah;
        private System.Windows.Forms.Button b_simpan;
    }
}