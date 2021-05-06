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
    public partial class user : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
       
        private string akses, idakses;
        public user()
        {
            InitializeComponent();
            autonumber();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validasi()
        {
            foreach (Control control in groupBox1.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        MessageBox.Show(txtBox.Name + "Tidak boleh kosong");
                        return false;
                    }
                   

                }
                

            }
            return true;
           
        }
        private void Tampil(string cari)
        {
            if (t_cari.TextLength==0)
            {
                cmd = new MySqlCommand("SELECT * FROM tb_user",con.Buka());
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM tb_user where nama like '%"+cari+ "%' or username like '%" + cari + "%' or id_user like '%" + cari + "%' or position like '%" + cari + "%'", con.Buka());
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            table.DataSource = dt;
            table.Refresh();
        }
        private void user_Load(object sender, EventArgs e)
        {
            Tampil("");
            setBox();
        }
        private string Posisi()
        {
            if (radioButton1.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        private void b_simpan_Click(object sender, EventArgs e)
        {
            if (validasi()==true)
            {
                string[] stat = cmb_status.SelectedItem.ToString().Split('-');
                con.Insert("SELECT count(*) from tb_user where username = '" + t_user.Text + "'", "INSERT INTO tb_user values('" + t_kode.Text + "','" + t_nama.Text + "','" + t_alamat.Text + "','" + t_hp.Text + "','" + t_user.Text + "','" + t_Pass.Text + "','" + stat[0] + "','" + Posisi() + "')", "Sukses Menyimpan data!");
                bersih();
                autonumber();
                Tampil("");
            }
      
          
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            validasi();
            string[] stat = cmb_status.SelectedItem.ToString().Split('-');
            con.UD("update tb_user set nama = '"+t_nama.Text+ "', alamat = '" + t_alamat.Text + "', telp = '" + t_hp.Text + "',username = '" + t_user.Text + "',password = '" + t_Pass.Text + "',status = '" +stat[0] + "', position = '" +Posisi()+ "' where id_user = '"+t_kode.Text+"'","Sukses Mengubah data!");
            bersih();
            autonumber();
            Tampil("");

        }
        private void bersih()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }
        private void autonumber()
        {
            long hitung;
            string urut;
            cmd = new MySqlCommand("SELECT id_user From tb_user where id_user in (select max(id_user) from tb_user) order by id_user desc", con.Buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id_user"].ToString().Length - 5, 5)) + 1;
                string joinstr = "00000" + hitung;
                urut = "KR" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                urut = "KR00001";
            }
            reader.Close();
            t_kode.Text = urut;
            t_kode.Enabled = false;
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            bersih();
            autonumber();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            con.UD("DELETE FROM tb_user where id_user = '"+t_kode.Text+"'","Hapus Sukses!");
            bersih();

            autonumber();
            Tampil("");
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            bersih();
            autonumber();
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(t_cari.Text);
        }

        private void table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = table.SelectedRows[0];
            t_kode.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_alamat.Text = dr.Cells[2].Value.ToString();
            t_hp.Text = dr.Cells[3].Value.ToString();
            t_user.Text = dr.Cells[4].Value.ToString();
            t_Pass.Text = dr.Cells[5].Value.ToString();
            cmb_status.SelectedIndex = Convert.ToInt32((dr.Cells[6].Value.ToString()))-1;
            string ah= dr.Cells[7].Value.ToString();
            if (ah=="1")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true; 
            }

        }

        private void setBox()
        {
            cmd = new MySqlCommand("SELECT * from tb_akses", con.Buka());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idakses = reader["id"].ToString();
                akses = reader["nama"].ToString();
                cmb_status.Items.Add(idakses + " - " + akses);
            }
            reader.Close();
        }
    }
}
