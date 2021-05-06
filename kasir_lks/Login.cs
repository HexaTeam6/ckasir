using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kasir_lks
{
    public partial class Login : Form
    {
        int x = 0;
        int stat = 0;
        string uname, jeneng, pass, pos;

        private MySqlCommand cmd;
        private MySqlDataReader reader;
        Config con = new Config();
        static string nama, status,id;
        public Login()
        {
            InitializeComponent();


        }
        private void bersih()
        {
            t_uname.Clear();
            t_pass.Clear();
            t_uname.Focus();
        }
        public static string getNama()
        {
            return nama;
        }
        public static string getId()
        {
            return id;
        }
        public static string getStatus()
        {
            return status;
        }

        private void b_show_Click(object sender, EventArgs e)
        {

            if (stat == 0)
            {
                t_pass.UseSystemPasswordChar = true;
                stat = 1;
            }
            else
            {
                t_pass.UseSystemPasswordChar = false;
                stat = 0;
            }


        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bersih();
            stat = 0;
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            if (t_uname.TextLength == 0 || t_pass.TextLength == 0)
            {
                MessageBox.Show("Periksa kembali dan isi username dan password dengan lengkap");
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("SELECT * FROM tb_user where username = '" + t_uname.Text + "'", con.Buka());
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            nama = reader["nama"].ToString();
                            id = reader["id_user"].ToString();
                            jeneng = reader["username"].ToString();
                            pass = reader["password"].ToString();
                            status = reader["status"].ToString();
                            pos = reader["position"].ToString();
                            if (jeneng == t_uname.Text && pass == t_pass.Text)
                            {
                                if (pos == "1")
                                {
                                    x = 0;
                                    MessageBox.Show("Login Berhasil");
                                    MasterMenu m = new MasterMenu();
                                    m.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Akun anda terblokir!, silahkan hubungi admin");
                                    
                                }
                               

                            }
                            else if (jeneng == t_uname.Text && pass != t_pass.Text)
                            {
                                uname = reader["username"].ToString();
                                x += 1;
                                if (x>3)
                                {
                                    MessageBox.Show("Akun anda terblokir!");
                                }
                                else
                                {
                                    MessageBox.Show("Password Salah, Anda diberi kesempatan untuk login 3x jika gagal akun terblokir");
                                }
                               
                                

                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Gagal");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Tutup();
                }
                if (x == 3)
                {
                    int z = 0;
                    con.UD("UPDATE tb_user set position = '" + z + "' where username = '" + uname + "'", "Selamat akun anda terblokir");
                   
                }
                bersih();
            }
        }
    }
}
 