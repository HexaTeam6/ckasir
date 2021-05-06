using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_lks
{
    public partial class Eprofile : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataReader reader;
        MasterMenu m = new MasterMenu();
        string kode, passlama;
        public Eprofile()
        {
            InitializeComponent();
        }

        private void Eprofile_Load(object sender, EventArgs e)
        {
            kode = m.getKode();
            ambilData();
            t_username.Enabled = false;
            atur();
           
          
        }
        private void ambilData()
        {
            try
            {
                cmd = new MySqlCommand("SELECT * FROM tb_user where id_user = '" + kode + "'", con.Buka());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t_pegawai.Text = reader.GetString(0);
                    t_nama.Text = reader.GetString(1);
                    t_alamat.Text = reader.GetString(2);
                    t_telepon.Text = reader.GetString(3);
                    t_username.Text = reader.GetString(4);

                    passlama = reader.GetString(5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Tutup();
            }
           
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            if (t_pass.Text == t_confirm.Text && t_passlama.Text ==passlama)
            {
                con.UD("UPDATE tb_user set password = '" + t_confirm.Text + "' where id_user = '" + t_pegawai.Text + "'", "Update Password berhasil");
            }
            else
            {
                MessageBox.Show("Periksa Kembali");
            }
           
        }
        private void cek()
        {
            if (t_pass.Text != t_confirm.Text)
            {
                
                MessageBox.Show("Password tidak sama!", "Peringatan");
               
                t_confirm.BackColor = Color.OrangeRed;
                   
            }
            else
            {
                t_confirm.BackColor = Color.LightGreen;
            }
        }
        private void cek2()
        {
            if (t_passlama.Text != passlama)
            {
                MessageBox.Show("Password tidak sesuai password lama, silahkan input password lama dengan benar", "Peringatan");
                t_passlama.BackColor = Color.OrangeRed;
                b_simpan.Enabled = false;


            }
            else
            {
                t_passlama.BackColor = Color.LightGreen;
                b_simpan.Enabled = true;
            }
            
        }
        private void t_confirm_Leave(object sender, EventArgs e)
        {
            cek();
        }

        private void t_passlama_Leave(object sender, EventArgs e)
        {
            cek2();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            con.UD("update tb_user set nama = '" + t_nama.Text + "', alamat = '" + t_alamat.Text + "', telp = '" + t_telepon.Text + "' where id_user = '" + t_pegawai.Text + "'","Sukses Mengubah data!");
            ambilData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void atur()
        {
            if (b_ubah.Text == "change")
            {
                b_ubah.Text = "cancel";
                labelwkwk.Text = "Password Baru";
                lb1.Visible = true;
                lb2.Visible = true;
                t_confirm.Visible = true;
                t_passlama.Visible = true;
                b_simpan.Visible = true;
                b_simpan.Enabled = false;
                t_pass.Clear();

            }
            else
            {
                b_ubah.Text = "change";
                labelwkwk.Text = "Password";
                lb1.Visible = false;
                lb2.Visible = false;
                t_pass.Text = passlama;                 
                t_confirm.Visible = false;
                t_passlama.Visible = false;
                t_pass.Enabled = false;
                b_simpan.Visible = false;
                t_pass.Clear();
                t_passlama.Clear();
                t_confirm.Clear();
            }
        }

        private void b_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ubah_Click(object sender, EventArgs e)
        {
            t_pass.Enabled = true;
            atur();
        }
    }
}
