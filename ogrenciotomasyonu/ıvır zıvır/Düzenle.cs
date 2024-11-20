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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ogrenciotomasyonu.ıvır_zıvır
{
    public partial class Düzenle : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        CurrencyManager cm;
        public Düzenle()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Düzenle_Load(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "Select * from ogrenciler";
                conn.Open();
                dt.Load(cmd.ExecuteReader());

                comboBox2.DataBindings.Add("Text", dt, "ogrenciID");
                txtad.DataBindings.Add("Text", dt, "ad");
                txtsoyad .DataBindings.Add("Text", dt, "soyad");
                txttc .DataBindings.Add("Text", dt, "tc");
                txtdogumtarihi .DataBindings.Add("Text", dt, "dogumTarihi");
                txttel.DataBindings.Add("Text", dt, "telefon");
                txtemail.DataBindings.Add("Text", dt, "email");
            comboBox1.DataBindings.Add("Text", dt, "bolumID");
                cm = (CurrencyManager)BindingContext[dt];

                comboBox2 .DataSource = dt;
                comboBox2.DisplayMember = "ogrenciID";
                comboBox2.ValueMember = "ogrenciID";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Mesajı", MessageBoxButtons.OK);
            }
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
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

                string secilenDeger = comboBox1.Text;

                string cinsiyet = radioButton1.Checked ? "Kadın" : "Erkek";

                cmd.CommandText = @"UPDATE ogrenciler SET 
                        ad = @ad, 
                        soyad = @soyad, 
                        tc = @tc, 
                        dogumtarihi = @dogumtarihi, 
                        cinsiyet = @cinsiyet, 
                        telefon = @telefon, 
                        email = @email, 
                        kayittarihi = @kayittarihi, 
                        bolumID = @bolumID 
                    WHERE ogrenciID = @ogrenciID";
                cmd.Parameters.AddWithValue("@ogrenciID", comboBox2.Text);
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

                MessageBox.Show("Başarıyla Güncellendi.");


                
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  
    }
}
