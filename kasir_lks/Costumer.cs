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
    public partial class Costumer : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        public Costumer()
        {
            InitializeComponent();
            autonumber();

        }
        private void autonumber()
        {
            long hitung;
            string urut;
            cmd = new MySqlCommand("SELECT id_cost From tb_costumer where id_cost in (select max(id_cost) from tb_costumer) order by id_cost desc", con.Buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id_cost"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "C" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "C001";
            }
            reader.Close();
            t_kode.Text = urut;
            t_kode.Enabled = false;

        }
        private void bersih()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
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
            if (t_cari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM tb_costumer", con.Buka());
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM tb_costumer where nama like '%" + cari + "%' or id_cost like '%" + cari + "%'", con.Buka());
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            table.DataSource = dt;
        }
        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(t_cari.Text);
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void Costumer_Load(object sender, EventArgs e)
        {
            Tampil("");
        }
        private void b_cancel_Click(object sender, EventArgs e)
        {
            bersih();
            autonumber();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            if (validasi() == true)
            {
                con.Insert("SELECT count(*) from tb_costumer where nama= '" + t_nama.Text + "'", "insert into tb_costumer values('" + t_kode.Text + "','" + t_nama.Text + "','" + t_alamat.Text + "','" + t_hp.Text + "');", "Sukses Menyimpan data!");

            }
            bersih();
            autonumber();
            Tampil("");
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            if (validasi() == true)
            {
                con.UD("update tb_costumer set nama = '" + t_nama.Text + "', alamat = '" + t_alamat.Text + "', no_telp = '" + t_hp.Text + "' where id_cost = '" + t_kode.Text + "'", "Sukses Mengubah data!");

            }
            bersih();
            autonumber();
            Tampil("");
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            con.UD("DELETE FROM tb_costumer where id_cost = '" + t_kode.Text + "'", "Hapus Sukses!");
            bersih();

            autonumber();
            Tampil("");
        }

        private void table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = table.SelectedRows[0];
            t_kode.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_alamat.Text = dr.Cells[2].Value.ToString();
            t_hp.Text = dr.Cells[3].Value.ToString();
            
        }
    }
}
