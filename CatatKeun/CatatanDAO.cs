using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CatatKeun
{
    class CatatanDAO
    {
        private MySqlCommand perintah = null;
        string konfigurasi = "Server=localhost;Port=3306;UID=root;PWD=;Database=catatan";
        MySqlConnection koneksi = new MySqlConnection();

        public CatatanDAO()
        {
            koneksi.ConnectionString = konfigurasi;
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "SELECT * FROM tbl_catatan";
                MySqlDataAdapter mdap = new MySqlDataAdapter(perintah);
                mdap.Fill(ds, "tbl_catatan");
                koneksi.Close();
            }catch (MySqlException)
            {

            }
            return ds;
        }


        public bool insertData(Catatan m)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "INSERT INTO tbl_catatan VALUES ('"+m.Id+"','"+m.Nama+"','"+m.Type+"','"+m.Cat+"','"+m.Jumlah+"')";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }

        public bool deleteData(String id)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "DELETE FROM tbl_catatan WHERE id='" + id + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }

        public bool updateData(Catatan m, String id)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "UPDATE tbl_catatan SET id'" + m.Id + "', nama='" + m.Nama + "'Where id='" + id + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }




    }
}
