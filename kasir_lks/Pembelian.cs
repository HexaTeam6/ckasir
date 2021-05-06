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
    public partial class Pembelian : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        int subtotal, hasil;
        MasterMenu m = new MasterMenu();
        public Pembelian()
        {
            InitializeComponent();
            awal();
            bersih();

            t_kasir.Text = m.getNama();
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
            dateTimePicker1.Value = DateTime.Now;
            kd_barang.Enabled = false;
            t_barang.Enabled = false;
            kd_supp.Enabled = false;
            t_Supp.Enabled = false;
            t_harga.Enabled = false;
            b_hapus.Enabled = false;

            b_new.Enabled = false;


        }
        private void awal()
        {
            cmd = new MySqlCommand("SELECT * FROM v_beli order by NomorFaktur desc ", con.Buka());
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void Subtotal()
        {
            int aharga = Convert.ToInt32(t_harga.Text);
            int bjumlah = Convert.ToInt32(t_jumlah.Text);
            int cdiskon = Convert.ToInt32(t_diskon.Text);
            //int aharga, bjumlah, cdiskon;
            subtotal = aharga * bjumlah;
            subtotal = ((100 - cdiskon) * aharga / 100) * bjumlah;

        }
        private void Totalbarang()
        {
            try
            {
                cmd = new MySqlCommand("SELECT SUM(qty) from v_detailbeli where NomorFaktur='" + t_id.Text + "'", con.Buka());
                object a = cmd.ExecuteScalar();
                if (a==null || a is DBNull)
                {
                    hasil = 0;
                }
                else
                {
                    hasil = Convert.ToInt32(cmd.ExecuteScalar());
                }
                string totalbarang = hasil.ToString();
                t_total.Text = totalbarang;
                //

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Tutup();
            }
        }
        private void TotalBayar()
        {
            try
            {
                cmd = new MySqlCommand("SELECT SUM(subtotal) from v_detailbeli where NomorFaktur='" + t_id.Text + "'", con.Buka());
                object a = cmd.ExecuteScalar();
                if (a == null || a is DBNull)
                {
                    hasil = 0;
                }
                else
                {
                    hasil = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string TotalBayar = hasil.ToString();
                t_totalbayar.Text = TotalBayar;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Tutup();
            }
        }
        private void refresh_jual()

        {
            cmd = new MySqlCommand("SELECT * FROM v_detailbeli where NomorFaktur = '" + t_id.Text + "' order by NomorFaktur desc ", con.Buka());
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void refresh_transaksi()
        {
            refresh_jual();
            kd_barang.Clear();
            t_barang.Clear();
            t_harga.Clear();
            t_jumlah.Clear();
            t_diskon.Clear();
            cari_barang.Focus();
        }
        private void simpanMaster()
        {
            try
            {
                cmd = new MySqlCommand("INSERT INTO header_beli values ('" + t_id.Text + "','" + this.dateTimePicker1.Text + "','" + m.getKode() + "','" + kd_supp.Text + "','" + t_totalbayar.Text + "')", con.Buka());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Tutup();
            }

        }
        private void simpanDetail()
        {
            Subtotal();
            try
            {
                cmd = new MySqlCommand("INSERT INTO detail_beli values ('" + t_id.Text + "','" + kd_barang.Text + "','" + t_jumlah.Text + "','" + t_diskon.Text + "','" + subtotal + "')", con.Buka());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Tutup();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cari_barang_Click(object sender, EventArgs e)
        {
            DBarangbeli db = new DBarangbeli();
            db.ShowDialog();
            kd_barang.Text = db.getId();
            t_barang.Text = db.getNama();
            t_harga.Text = db.getHarga();
        }
        private void cari_supplier_Click(object sender, EventArgs e)
        {
            dialongsupplier dp = new dialongsupplier();
            dp.ShowDialog();
            kd_supp.Text = dp.getId();
            t_Supp.Text = dp.getNama();
        }
        private void b_save_Click(object sender, EventArgs e)
        {
            con.UD("UPDATE header_beli set total = '" + t_totalbayar.Text + "' where id_beli = '" + t_id.Text + "'", "TRansaksi Selesai");
            b_new.Enabled = true;
            b_save.Enabled = false;

        }
        private void b_new_Click(object sender, EventArgs e)
        {
            b_save.Enabled = true;
            awal();
            bersih();
            t_jumlah.Text = "0";
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
        private void b_tambah_Click(object sender, EventArgs e)
        {
            if (validasi())
            {

                cmd = new MySqlCommand("SELECT * from header_beli where id_beli = '" + t_id.Text + "'", con.Buka());
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    simpanDetail();
                    TotalBayar();
                    Totalbarang();
                }
                else
                {
                    simpanMaster();
                    simpanDetail();
                    TotalBayar();
                    Totalbarang();
                }
                refresh_transaksi();

            }
        }

        private void b_hapus_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("DELETE from detail_beli where id_beli = '" + t_id.Text + "' and id_barang = '" + kd_barang.Text + "'", con.Buka());
                cmd.ExecuteNonQuery();
                TotalBayar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Tutup();
            }
            refresh_transaksi();
            b_tambah.Enabled = true;
            b_hapus.Enabled = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            b_tambah.Enabled = false;
            b_hapus.Enabled = true;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            t_id.Text = row.Cells[0].Value.ToString();
            kd_barang.Text = row.Cells[1].Value.ToString();
            t_barang.Text = row.Cells[2].Value.ToString();
            t_jumlah.Text = row.Cells[3].Value.ToString();
            t_harga.Text = row.Cells[5].Value.ToString();
            t_diskon.Text = row.Cells[6].Value.ToString();

        }

        private void Pembelian_Load(object sender, EventArgs e)
        {

        }
    }
}
