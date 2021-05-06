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
    public partial class Penjualan : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        int subtotal,hasil, jujul;
        MasterMenu m = new MasterMenu();
        public Penjualan()
        {
            InitializeComponent();
            awal();
            bersih();
            autonumber();
            t_kasir.Text = m.getNama();
        }
        private void awal()
        {
            cmd = new MySqlCommand("SELECT * FROM v_jual order by NomorFaktur desc ", con.Buka());
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
             adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void simpanMaster()
        {
            try
            {
                cmd = new MySqlCommand("INSERT INTO header_jual values ('" + t_id.Text + "','" + this.dateTimePicker1.Text + "','" + m.getKode() + "','" + t_idpel.Text + "','" + t_total.Text + "')", con.Buka());
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
                cmd = new MySqlCommand("INSERT INTO detail_jual values ('" + t_id.Text + "','" + t_kdbrang.Text + "','" + t_jumlah.Text + "','" +0+ "','" + subtotal + "')", con.Buka());
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
        private void Penjualan_Load(object sender, EventArgs e)
        {
            
        }
        private void Subtotal()
        {
            int a = Convert.ToInt32(t_harga.Text);
            int b = Convert.ToInt32(t_jumlah.Text);
            subtotal = a * b;

        }
        private void TotalBayar()
        {
            try
            {
                cmd = new MySqlCommand("SELECT SUM(subtotal) from v_detail where NomorFaktur='" + t_id.Text + "'", con.Buka());
                object a = cmd.ExecuteScalar();
                if (a==null || a is DBNull)
                {
                    hasil = 0;
                }
                else
                {
                    hasil = Convert.ToInt32(cmd.ExecuteScalar());
                }
                
                string TotalBayar = hasil.ToString();
                t_total.Text = TotalBayar;
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
            cmd = new MySqlCommand("SELECT * FROM v_detail where NomorFaktur = '"+t_id.Text+"' order by NomorFaktur desc ", con.Buka());
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
            t_kdbrang.Clear();
            t_barang.Clear();
            t_harga.Clear();
            t_jumlah.Clear();
            cari_barang.Focus();
        }
        private void bersih()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox && c.Name != "t_id")
                {
                    c.Text = "";
                }
            }
            dateTimePicker1.Value = DateTime.Now;
            t_idpel.Enabled = false;
            t_namaPelanggan.Enabled = false;
            t_kdbrang.Enabled = false;
            t_barang.Enabled = false;
            t_harga.Enabled = false;
            b_kurang.Enabled = false;
            b_save.Enabled = false;
            b_new.Enabled = false;


        }
        private void autonumber()
        {
            long hitung;
            string urut;
            cmd = new MySqlCommand("SELECT id_jual From header_jual where id_jual in (select max(id_jual) from header_jual) order by id_jual desc", con.Buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id_jual"].ToString().Length - 12, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "Anu-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                urut = "Anu-0001/"+ DateTime.Now.ToString("MM/yyyy");
            }
            reader.Close();
            t_id.Text = urut;
            t_id.Enabled = false;
            con.Tutup();

        }
        private void cari_konsumen_Click(object sender, EventArgs e)
        {
            DialogPelanggan dp = new DialogPelanggan();
            dp.ShowDialog();
            t_idpel.Text = dp.getId();
            t_namaPelanggan.Text = dp.getNama();
            

        }
        private void cari_barang_Click(object sender, EventArgs e)
        {
            DialogBarang db = new DialogBarang();
            db.ShowDialog();
            t_kdbrang.Text = db.getId();
            t_barang.Text = db.getNama();
            t_harga.Text = db.getHarga();
        }
        private void b_save_Click(object sender, EventArgs e)
        {
            
            con.UD("UPDATE header_jual set total = '" + t_total.Text + "' where id_jual = '" + t_id.Text + "'", "TRansaksi Selesai");
            b_new.Enabled = true;
            b_save.Enabled = false;
            t_bayar.Enabled = false;
            

           
            
            
        }
        private void b_tambah_Click(object sender, EventArgs e)
        {
            if (validasi())
            {

                cmd = new MySqlCommand("SELECT * from header_jual where id_jual = '"+t_id.Text+"'",con.Buka());
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    simpanDetail();
                    TotalBayar();
                }
                else
                {
                    simpanMaster();
                    simpanDetail();
                    TotalBayar();
                }
                refresh_transaksi();
                
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
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            b_tambah.Enabled = false;
            b_kurang.Enabled = true;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            t_id.Text = row.Cells[0].Value.ToString();
            t_kdbrang.Text = row.Cells[1].Value.ToString();
            t_barang.Text = row.Cells[2].Value.ToString();
            t_jumlah.Text = row.Cells[3].Value.ToString();
            t_harga.Text = row.Cells[5].Value.ToString();

        }
        private void t_bayar_Leave(object sender, EventArgs e)
        {
            //cekKembalian();
        }
        private void b_new_Click(object sender, EventArgs e)
        {
            awal();
            bersih();
            autonumber();
            t_bayar.Enabled = true;
            t_bayar.Clear();
            t_kembalian.Text = "0";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void t_bayar_TextChanged(object sender, EventArgs e)
        {
            int bayar;
            if(Int32.TryParse(t_bayar.Text, out bayar))
            {
                jujul = bayar - hasil;
                t_kembalian.Text = jujul.ToString();
                if (jujul < 0)
                {
                    t_bayar.Focus();
                    t_bayar.BackColor = Color.DarkOrange;
                }
                else
                {
                    t_bayar.BackColor = Color.LightGreen;
                    b_save.Enabled = true;
                }
            }
                
            
           
        }
        private void b_kurang_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("DELETE from detail_jual where id_jual = '" + t_id.Text + "' and id_barang = '" + t_kdbrang.Text + "'", con.Buka());
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
            b_kurang.Enabled = false;

        }
    }
}
