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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ogrenciotomasyonu.ıvır_zıvır
{
    public partial class OgrenciEkle : Form
    {
        SqlConnection conn= new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand cmd=new SqlCommand();
        
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void ÖğrenciEkle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                conn.Open();
                cmd.Connection = conn;

                // Şimdiki zamanı al
                DateTime simdi = DateTime.Now;

                int secilenDeger = (int)comboBox1.SelectedItem;

                string cinsiyet = radioButton1.Checked ? "Kadın" : "Erkek";

                cmd.CommandText = @"INSERT INTO ogrenciler(ad, soyad, tc, dogumtarihi, cinsiyet, telefon, email, kayittarihi, bolumID, parola) 
                            VALUES(@ad, @soyad, @tc, @dogumtarihi, @cinsiyet, @telefon, @email, @kayittarihi, @bolumID, @parola)";
                cmd.Parameters.AddWithValue("@ad", txtad.Text);
                cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                cmd.Parameters.AddWithValue("@tc", txttc.Text);

                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@telefon", txttel.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);

                DateTime dogumTarihi;
                if (DateTime.TryParse(txtdogumtarihi.Text, out dogumTarihi))
                {
                    cmd.Parameters.AddWithValue("@dogumtarihi", dogumTarihi);
                }
                else
                {
                    MessageBox.Show("Geçerli bir doğum tarihi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Doğru bir doğum tarihi olmadığı için işlemi sonlandır.
                }

                cmd.Parameters.AddWithValue("@kayittarihi", simdi); // Şimdiki tarih ve saat

                cmd.Parameters.AddWithValue("@parola", txttc.Text);
                cmd.Parameters.AddWithValue("@bolumID", secilenDeger);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Başarıyla eklendi.");


                txtad.Clear();
                txtdogumtarihi.Clear();
                txtemail.Clear();
                txtsoyad.Clear();
                txttc.Clear();
                txttel.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonkadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        
        }
    }
}
