using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
namespace kasir_lks
{
    public partial class l_jualan : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        public l_jualan()
        {
            InitializeComponent();
        }
        private void Tampil()
        {
            try
            {
                cmd = new MySqlCommand("SELECT * from v_kwi", con.Buka());
                adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

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
        private void Pencarian()
        {
            try
            {
                cmd = new MySqlCommand("SELECT * from v_kwi where tanggal = '" + this.dateTimePicker1.Text + "'", con.Buka());
                adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

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
        private void l_jualan_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void b_semua_Click(object sender, EventArgs e)
        {
            Tampil();
        }

        private void b_go_Click(object sender, EventArgs e)
        {
            Pencarian();
        }

        private void b_export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible=true;

            ws.Cells[1, 1] = "NO Faktur";
            ws.Cells[1, 2] = "Tanggal";
            ws.Cells[1, 3] = "ID Pelanggan";
            ws.Cells[1, 4] = "Pelanggan";
            ws.Cells[1, 5] = "ID Kasir";
            ws.Cells[1, 6] = "Kasir";
            ws.Cells[1, 7] = "Kode Barang";
            ws.Cells[1, 8] = "Nama Barang";
            ws.Cells[1, 9] = "Harga Jual";
            ws.Cells[1, 10] = "QTY";
            ws.Cells[1, 11] = "Subtotal";
            for (int j = 2; j < dataGridView1.Rows.Count; j++)
            {
                for (int i = 1; i <= 11; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }
    }
}
