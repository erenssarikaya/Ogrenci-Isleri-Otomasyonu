
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
    public partial class DersEkle : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
       
        public DersEkle()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DersEkle_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lardan veriyi al
            string dersAdi = txtdersadi.Text;
            int kredi = Convert.ToInt32(txtkredi .Text);
            string dersKodu = txtderskodu .Text;
            string donem = txtdonem .Text;
            int akts = Convert.ToInt32(txtakts .Text);

            // Veritabanına ekleme işlemi
            try
            {
               
                {
                   
                    connection.Open();

                    string query = "INSERT INTO Dersler (DersAdi, Kredi, DersKodu, Donem, AKTS) " +
                                   "VALUES (@DersAdi, @Kredi, @DersKodu, @Donem, @AKTS)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@DersAdi", dersAdi);
                        command.Parameters.AddWithValue("@Kredi", kredi);
                        command.Parameters.AddWithValue("@DersKodu", dersKodu);
                        command.Parameters.AddWithValue("@Donem", donem);
                        command.Parameters.AddWithValue("@AKTS", akts);

                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Veri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Veri eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtakts.Clear();
                        txtdersadi.Clear();
                        txtderskodu.Clear();
                        txtdonem.Clear();
                        txtkredi.Clear();




                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtderskodu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
