namespace kasir_lks
{
    partial class Login
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_uname = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.b_show = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.t_pass);
            this.groupBox2.Location = new System.Drawing.Point(28, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 59);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // t_pass
            // 
            this.t_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_pass.ForeColor = System.Drawing.Color.Silver;
            this.t_pass.Location = new System.Drawing.Point(12, 19);
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(250, 31);
            this.t_pass.TabIndex = 2;
            this.t_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_pass.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.t_uname);
            this.groupBox1.Location = new System.Drawing.Point(28, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ussername";
            // 
            // t_uname
            // 
            this.t_uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_uname.ForeColor = System.Drawing.Color.Silver;
            this.t_uname.Location = new System.Drawing.Point(12, 20);
            this.t_uname.Name = "t_uname";
            this.t_uname.Size = new System.Drawing.Size(250, 31);
            this.t_uname.TabIndex = 2;
            this.t_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.b_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.SystemColors.Control;
            this.b_login.Location = new System.Drawing.Point(28, 283);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(133, 52);
            this.b_login.TabIndex = 10;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 33);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 85);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Aplikasi SIKasir";
            // 
            // b_show
            // 
            this.b_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.b_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_show.ForeColor = System.Drawing.SystemColors.Control;
            this.b_show.Location = new System.Drawing.Point(239, 242);
            this.b_show.Name = "b_show";
            this.b_show.Size = new System.Drawing.Size(63, 35);
            this.b_show.TabIndex = 15;
            this.b_show.Text = "Show";
            this.b_show.UseVisualStyleBackColor = false;
            this.b_show.Click += new System.EventHandler(this.b_show_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.b_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.b_cancel.Location = new System.Drawing.Point(167, 283);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(135, 52);
            this.b_cancel.TabIndex = 16;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 391);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_show);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_uname;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_show;
        private System.Windows.Forms.Button b_cancel;
    }
}