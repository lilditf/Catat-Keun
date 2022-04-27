using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CatatKeun
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        CatatanDAO md = new CatatanDAO();
        void lihatData()
        {
            DataSet data = md.getData();
            guna2DataGridView1.DataSource = data;
            guna2DataGridView1.DataMember = "tbl_catatan";
        }

        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedTab = tabPage1;
        }

        private void Guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedTab = tabPage2;
        }

        private void Guna2GradientButton3_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedTab = tabPage3;
        }

        private void Guna2GradientButton4_Click(object sender, EventArgs e)
        {
            //SAVE DATA
            Catatan m = new Catatan();
            m.Id = idTXT.Text;
            m.Type = typeCB.Text;
            m.Nama = desTXT.Text;
            m.Cat = katCB.Text;
            m.Jumlah = jumTXT.Text;

            md.insertData(m);
            MessageBox.Show("Input Data Berhasil !", "Informasi Bang");
            lihatData();
            desTXT.Text = "";
            idTXT.Text = "";
            jumTXT.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lihatData();
        }
        string Id;
        private void Guna2GradientButton5_Click(object sender, EventArgs e)
        {
            //UPDATE DATA
            Catatan m = new Catatan();
            m.Id = idTXT.Text;
            m.Nama = desTXT.Text;

            md.updateData(m, Id);
            lihatData();
        }

        private void Guna2GradientButton7_Click(object sender, EventArgs e)
        {
            //HAPUS DATA
            md.deleteData(Id);
            MessageBox.Show("Hapus Data Berhasil !", "Informasi Bang");
            lihatData();
        }

        private void Guna2GradientButton6_Click(object sender, EventArgs e)
        {
            //RESET FORM
            idTXT.Text = "";
            desTXT.Text = "";
            typeCB.Text = "";
            jumTXT.Text = "";
            katCB.Text = "";
        }

        private void Guna2DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idTXT.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            desTXT.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            jumTXT.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            typeCB.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            katCB.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            
        }
    }
}
