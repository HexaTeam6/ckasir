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
    public partial class Barang : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        public Barang()
        {
            InitializeComponent();
            autonumber();
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
        private void Tampil(string cari)
        {
            if (t_cari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM tb_barang", con.Buka());
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM tb_barang where nama like '%" + cari + "%' or jumlah like '%" + cari + "%' or id_barang like '%" + cari + "%' or satuan like '%" + cari + "%'", con.Buka());
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            table.DataSource = dt;
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
        private void autonumber()
        {
            long hitung;
            string urut;
            cmd = new MySqlCommand("SELECT id_barang From tb_barang where id_barang in (select max(id_barang) from tb_barang) order by id_barang desc", con.Buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id_barang"].ToString().Length - 4, 4)) + 1;
                string joinstr = "000" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "B0001";
            }
            reader.Close();
            t_kode.Text = urut;
            t_kode.Enabled = false;

        }
        private void b_edit_Click(object sender, EventArgs e)
        {
            if (validasi()==true)
            {
                con.UD("update tb_barang set nama = '" + t_nama.Text + "', jumlah = '" + t_jum.Text + "', satuan = '" + t_satuan.Text + "',harga_beli = '" + t_Beli.Text + "',harga_jual= '" + t_jual.Text + "' where id_barang = '"+t_kode.Text+"'", "Sukses Mengubah data!");
                
            }
            bersih();
            autonumber();
            Tampil("");


        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            con.UD("DELETE FROM tb_barang where id_barang = '" + t_kode.Text + "'", "Hapus Sukses!");
            bersih();

            autonumber();
            Tampil("");
        }

        private void Barang_Load(object sender, EventArgs e)
        {
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

        private void b_simpan_Click(object sender, EventArgs e)
        {
            if (validasi()==true)
            {
                con.Insert("SELECT count(*) from tb_barang where nama= '" + t_nama.Text + "'", "insert into tb_barang values('" + t_kode.Text + "','" + t_nama.Text + "','" + t_jum.Text + "','" + t_satuan.Text + "','" + t_Beli.Text + "','" + t_jual.Text + "');", "Sukses Menyimpan data!");
                
            }
            bersih();
            autonumber();
            Tampil("");

        }

        private void b_new_Click(object sender, EventArgs e)
        {
            bersih();
            autonumber();
        }

        private void table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = table.SelectedRows[0];
            t_kode.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_jum.Text = dr.Cells[2].Value.ToString();
            t_satuan.Text = dr.Cells[3].Value.ToString();
            t_Beli.Text = dr.Cells[4].Value.ToString();
            t_jual.Text = dr.Cells[5].Value.ToString();
        }
    }
}
