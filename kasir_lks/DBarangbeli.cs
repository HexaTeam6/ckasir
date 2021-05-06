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
    public partial class DBarangbeli : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        public static string kodebarang, nmBarang, harga = "";

        public DBarangbeli()
        {
            InitializeComponent();
        }
        public string getId()
        {
            return kodebarang;
        }
        public string getNama()
        {
            return nmBarang;
        }
        public string getHarga()
        {
            return harga;
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(t_cari.Text);
        }

        private void dg_barang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dg_barang.SelectedRows[0];
            kodebarang = dr.Cells[0].Value.ToString();
            nmBarang = dr.Cells[1].Value.ToString();
            harga = dr.Cells[4].Value.ToString();
            this.Close();
        }

        private void DBarangbeli_Load(object sender, EventArgs e)
        {
            Tampil("");
        }
        private void Tampil(string cari)
        {
            if (t_cari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM tb_barang", con.Buka());
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM tb_barang where nama like '%" + cari + "%'  or id_barang like '%" + cari + "%'", con.Buka());
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg_barang.DataSource = dt;
            dg_barang.Refresh();
        }
    }
}
