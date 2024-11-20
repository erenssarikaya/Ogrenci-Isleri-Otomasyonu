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

namespace ogrenciotomasyonu.Ekranlar
{
    public partial class LoginOgrenci : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        DataView dv;
        public LoginOgrenci()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = Username.Text;
            string parola = Password.Text;
            try
            {
                connection.Open();
                string query = "SELECT * FROM ogrenciler WHERE Email = @eposta AND parola = @parola";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@eposta", kullaniciAdi);
                cmd.Parameters.AddWithValue("@parola", parola);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ogrenci_ekrani ogrenci_ek = new ogrenci_ekrani();

                    ogrenci_ek.Show();
                  


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

        private void LoginOgrenci_Load(object sender, EventArgs e)
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

