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

    public partial class Listele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        DataTable dt = new DataTable();
        public Listele()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            try
            {
                komut.Connection = baglanti;
                komut.CommandText = "select * from ogrenciler";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                komut.Connection = baglanti;
                komut.CommandText = "select * from ogrenciler where tc=@tc";
                komut.Parameters.AddWithValue("@tc", txttc.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                komut.Connection = baglanti;
                komut.CommandText = "select * from ogrenciler";
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

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
