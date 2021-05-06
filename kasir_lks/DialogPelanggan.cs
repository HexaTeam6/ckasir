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
    public partial class DialogPelanggan : Form
    {

        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataSet ds;
        public static string id_pelanggan, nama = "";
        public DialogPelanggan()
        {
            InitializeComponent();

        }
        private void Tampil(string cari)
        {
            
            if (t_cari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM tb_costumer", con.Buka());
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM tb_costumer where nama like '%" + t_cari + "%' or id_cost like '%" + t_cari + "%'", con.Buka());
            }
            ds = new DataSet();
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "tb_costumer");
            dataGridView1_pelanggan.DataSource = ds;
            dataGridView1_pelanggan.DataMember = "tb_costumer";
            dataGridView1_pelanggan.Refresh();
            con.Tutup();

        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(t_cari.Text);
        }

        private void dataGridView1_pelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1_pelanggan.SelectedRows[0];
            id_pelanggan = dr.Cells[0].Value.ToString();
            nama = dr.Cells[1].Value.ToString();
            this.Close();

        }

        private void DialogPelanggan_Load(object sender, EventArgs e)
        {
            Tampil("");
        }
        public string getId()
        {
            return id_pelanggan;
        }

        private void dataGridView1_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string getNama()
        {
            return nama;
        }
    }
}
