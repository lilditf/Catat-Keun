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
namespace CatatKeun
{
    public partial class Form1 : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Port=3306;UID=root;PWD=;Database=catatan");
        }

        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {

            //LOGIN 

            string user = userTXT.Text;
            string pass = passTXT.Text;

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login where usr='" + userTXT.Text + "' AND pwd='" + passTXT.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Berhasil!!", "Information bang");
                MainForm frmMain = new MainForm();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan Silahkan COba Lagi", "Information Bang");
            }
            con.Close();

        }
    }
}
