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
using CrystalDecisions.CrystalReports.Engine;

namespace kasir_lks
{
    public partial class printKwitansi : Form
    {
        Config con = new Config();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        private string text_kwitansi;
        public printKwitansi(string noKwitansi)
        {
            InitializeComponent();
            text_kwitansi = noKwitansi;
                 
        }
        void cetak()
        {
            cmd = new MySqlCommand("SELECT * from v_kwi",con.Buka());
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            printKwitansi pr = new printKwitansi();
             
            
        }

        private void printKwitansi_Load(object sender, EventArgs e)
        {

        }
    }
}
