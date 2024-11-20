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
    public partial class DersSil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        DataTable dt = new DataTable();
        public DersSil()
        {
            InitializeComponent();
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
                    komut.CommandText = "delete from dersler where DersID=@id";
                    komut.Parameters.Add("@id", SqlDbType.VarChar).Value = txttc.Text;
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

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void DersSil_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
