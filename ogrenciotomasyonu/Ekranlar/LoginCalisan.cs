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

namespace ogrenciotomasyonu
{

    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand cmd;
       
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = Username.Text;
            string parola = Password.Text;

            try
            {
                connection.Open();
                string query = "SELECT * FROM calisanlar WHERE Email = @eposta AND parola = @parola";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@eposta", kullaniciAdi);
                cmd.Parameters.AddWithValue("@parola", parola);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                  
                   int calisanTipi = Convert.ToInt32(dr["calisantipi"]);
                    long tc = Convert.ToInt64(dr["Tc"]);
                    int calisanID= Convert.ToInt32(dr["calisanID"]);
                    // Kullanıcı tipine göre uygun formu aç
                    switch (calisanTipi)
                    {
                        case 0 // Öğrenci İşleri
                       :
                            {
                               
                                Form9 ogrenci_isleri = new Form9(calisanTipi,tc);
                             
                                ogrenci_isleri.Show();
                                break;
                            }

                        case 1 // Hoca
                 :
                            {
                                Form6 hoca_form = new Form6(calisanTipi,tc, calisanID);
                                hoca_form.Show();
                                break;
                            }

                        case 2 // Admin
                 :
                            {
                                Form8 admin_form = new Form8(calisanTipi, tc);
                                admin_form.Show();
                                break;
                            }
                    }
                    this.Hide(); // Giriş formunu gizle
                }
                else
                    MessageBox.Show("Geçersiz kullanıcı adı veya parola!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Password.PasswordChar != '\0')
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '●';
            }
        }
    }
}
