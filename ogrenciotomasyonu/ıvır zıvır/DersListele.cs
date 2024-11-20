using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciotomasyonu.ıvır_zıvır
{
    public partial class DersListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        DataTable dt = new DataTable();
        public DersListele()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                komut.Connection = baglanti;
                komut.CommandText = "select * from dersler where DersAdi=@ad";
                komut.Parameters.AddWithValue("@ad", txttc.Text);
                baglanti.Open();
                dt.Load(komut.ExecuteReader());
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Mesajı", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                komut.Connection = baglanti;
                komut.CommandText = "select * from dersler";
                baglanti.Open();
                dt.Load(komut.ExecuteReader());
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Mesajı", MessageBoxButtons.OK);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DersListele_Load_1(object sender, EventArgs e)
        {
            try
            {
                komut.Connection = baglanti;
                komut.CommandText = "select * from dersler";
                baglanti.Open();
                dt.Load(komut.ExecuteReader());
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Mesajı", MessageBoxButtons.OK);
            }
        }
    }
}
