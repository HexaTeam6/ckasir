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
    public partial class MasterMenu : Form
    {
        Barang brg;
        Costumer cs;
        Eprofile pro;
        Supplier supp;
        Penjualan jual;
        user us;
        Pembelian pb;
        l_jualan lpJual;
        public string kode, name;

        public MasterMenu()
        {
            InitializeComponent();
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lpJual==null)
            {
                lpJual = new l_jualan();
                lpJual.MdiParent = this;
                lpJual.FormClosed += new FormClosedEventHandler(LpJual_FormClosed);
                lpJual.Show();
            }
            else
            {
                lpJual.Activate();
            }
        }

        private void LpJual_FormClosed(object sender, FormClosedEventArgs e)
        {
            lpJual = null;
        }

        public string getNama()
        {
            return name = Login.getNama();
        }
        public string getKode()
        {
            return kode = Login.getId();
        }
        private void m_barang_Click(object sender, EventArgs e)
        {
            if(brg == null)
            {
                brg = new Barang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(Brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void Brg_FormClosed(object sender, FormClosedEventArgs e)
        {
            brg = null;
        }

        private void m_costumer_Click(object sender, EventArgs e)
        {
            if (cs == null)
            {
                cs = new Costumer();
                cs.MdiParent = this;
                cs.FormClosed += new FormClosedEventHandler(Cs_FormClosed);
                cs.Show();
            }
            else
            {
                cs.Activate();
            }
        }

        private void Cs_FormClosed(object sender, FormClosedEventArgs e)
        {
            cs = null;
        }

        private void m_supplier_Click(object sender, EventArgs e)
        {
            if (supp == null)
            {
                supp = new Supplier();
                supp.MdiParent = this;
                supp.FormClosed += new FormClosedEventHandler(Supp_FormClosed);
                supp.Show();
            }
            else
            {
                supp.Activate();
            }
        }

        private void Supp_FormClosed(object sender, FormClosedEventArgs e)
        {
            supp = null;
        }

        private void m_transaksi_Click(object sender, EventArgs e)
        {

        }

        private void m_user_Click(object sender, EventArgs e)
        {
            if (us == null)
            {
                us = new user();
                us.MdiParent = this;
                us.FormClosed += new FormClosedEventHandler(Us_FormClosed);
                us.Show();
            }
            else
            {
                us.Activate();
            }
        }

        private void Us_FormClosed(object sender, FormClosedEventArgs e)
        {
            us = null;
        }

        private void m_profile_Click(object sender, EventArgs e)
        {
            if (true)
            {
                pro = new Eprofile();
                pro.MdiParent = this;
                pro.FormClosed += new FormClosedEventHandler(Pro_FormClosed);
                pro.Show();
            }
            else
            {
                pro.Activate();
            }
        }

        private void Pro_FormClosed(object sender, FormClosedEventArgs e)
        {
            pro = null;
        }

        private void m_penjualan_Click(object sender, EventArgs e)
        {
            if (jual == null)
            {
                jual = new Penjualan();
                jual.MdiParent = this;
                jual.FormClosed += new FormClosedEventHandler(Jual_FormClosed);
                jual.Show();
            }
            else
            {
                jual.Activate();
            }
        }

        private void Jual_FormClosed(object sender, FormClosedEventArgs e)
        {
            jual = null;
        }

        private void m_pembelian_Click(object sender, EventArgs e)
        {
            if (pb==null)
            {
                pb = new Pembelian();
                pb.MdiParent = this;
                pb.FormClosed += new FormClosedEventHandler(Pb_FormClosed);
                pb.Show();
            }
            else
            {
                pb.Activate();
            }
        }

        private void Pb_FormClosed(object sender, FormClosedEventArgs e)
        {
            pb = null;
        }

        private void MasterMenu_Load(object sender, EventArgs e)
        {
            if (Login.getStatus() == "2")
            {
                m_user.Visible = false;
                m_barang.Visible = false;
                m_laporan.Visible = false;

            }else if(Login.getStatus()=="3"){
                m_transaksi.Visible = false;
                m_laporan.Visible = false;
                m_user.Visible = false;

            }
            else
            {

            }

            nama.Text = Login.getNama();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void m_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Dispose();
            
        }
    }
}
