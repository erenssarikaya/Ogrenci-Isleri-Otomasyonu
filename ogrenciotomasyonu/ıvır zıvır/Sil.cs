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
    public partial class Sil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        DataTable dt = new DataTable();
        public Sil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Silme işleminden önce kullanıcıya onay mesajı göster
            DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kullanıcı "Evet" seçeneğini seçerse
            if (result == DialogResult.Yes)
            {
                // Silme işlemini gerçekleştir
                try
                {
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from ogrenciler where tc=@tc";
                    komut.Parameters.Add("@tc", SqlDbType.VarChar).Value = txttc.Text;
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla silinmiştir.");
                    txttc.Clear();
                 
                    listele();

                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oldu." + ex.Message, "HATA MESAJI");
                }
            }
        }

        private void listele()
        {
           
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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