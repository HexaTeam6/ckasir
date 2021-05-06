using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace kasir_lks
{
    class Config
    {
        private MySqlConnection cnn;
        private MySqlCommand cmd;
        string strkoneksi = null;
        public MySqlConnection Buka()
        {
            strkoneksi = "SERVER=localhost; database=lks_kasir;uid=root;password=;";
            cnn = new MySqlConnection(strkoneksi);
            try
            {
                cnn.Open();
                //MessageBox.Show("Sukses");

            }
            catch (Exception e)
            {
                MessageBox.Show("GaGaL " + e);

            }
            return cnn;
        }
        public MySqlConnection Tutup()
        {
            cnn.Close();
            return cnn;
        }
        public bool UD(string query, string info)
        {
            try
            {
                cmd = new MySqlCommand(query, Buka());
                cmd.ExecuteNonQuery();
                MessageBox.Show(info, "Informasi");
            }
            catch (Exception e)
            {
                MessageBox.Show("GaGaL " + e);

            }
            finally
            {
                Tutup();
            }

            return true;
        }
        
        public bool Insert(string query,string query2, string info)
        {
            try
            {
                MySqlCommand cek = new MySqlCommand(query, Buka());
                int anaorahayo = Convert.ToInt32(cek.ExecuteScalar());

                if (anaorahayo > 0)
                {
                    MessageBox.Show("Akun sudah ada!", "Informasi");
                }
                else
                {
                    cmd = new MySqlCommand(query2, Buka());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(info, "Informasi");
                    
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("GaGaL " + e);

            }
            finally
            {
                Tutup();
            }

            return true;
        }

        //public Config()
        //{
        //    Initialize();
        //}
        //private void Initialize()
        //{
        //    string strkoneksi;
        //    strkoneksi = "SERVER=localhost; database=lks_kasir;uid=root;password=;";
        //    cnn = new MySqlConnection(strkoneksi);
        //}
        //public bool Buka()
        //{
        //    try
        //    {
        //        cnn.Open();
        //        //MessageBox.Show("Sukses");
        //        return true;
        //    }
        //    catch (MySqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return false;

        //    }
        //}
        //public bool Tutup()
        //{
        //    try
        //    {
        //        cnn.Close();
        //        return true;
        //    }
        //    catch (MySqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return false;

        //    }
        //}
        //public void cud(string query,string info)
        //{
        //    if (this.Buka()==true)
        //    {
        //        try
        //        {
        //            cmd = new MySqlCommand(query, cnn);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show(info, "Informasi");
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("gagal "+e.Message);

        //        }
        //        finally
        //        {
        //            Tutup();
        //        }


        //    }
        //}
    }
}
