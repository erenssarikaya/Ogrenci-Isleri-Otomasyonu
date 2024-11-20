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
    public partial class DersDüzenle : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        CurrencyManager cm;
        public DersDüzenle()
        {
            InitializeComponent();
        }

        private void DersDüzenle_Load(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "Select * from dersler";
                conn.Open();
                dt.Load(cmd.ExecuteReader());

                comboBox1.DataBindings.Add("Text", dt, "dersID");
                txtakts.DataBindings.Add("Text", dt, "akts");
                txtdersadi .DataBindings.Add("Text", dt, "dersadi");
                txtderskodu .DataBindings.Add("Text", dt, "derskodu");
                txtdonem .DataBindings.Add("Text", dt, "donem");
                txtkredi .DataBindings.Add("Text", dt, "kredi");
            
                cm = (CurrencyManager)BindingContext[dt];

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "dersID";
                comboBox1.ValueMember = "dersID";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Mesajı", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            // TextBox'lardan veriyi al
          
            string dersAdi = txtdersadi.Text;
            int kredi = Convert.ToInt32(txtkredi.Text);
            string dersKodu = txtderskodu.Text;
            string donem = txtdonem.Text;
            int akts = Convert.ToInt32(txtakts.Text);
            try
            {
                // Örneğin DersID'si 1 olan bir dersin bilgilerini güncelleme
                string updateQuery = @"UPDATE Dersler 
                                   SET DersAdi = @DersAdi, Kredi = @Kredi, DersKodu = @DersKodu, Donem = @Donem, AKTS = @AKTS
                                   WHERE DersID = @id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@DersAdi", dersAdi);
                    cmd.Parameters.AddWithValue("@Kredi", kredi);
                    cmd.Parameters.AddWithValue("@DersKodu", dersKodu);
                    cmd.Parameters.AddWithValue("@Donem", donem);
                    cmd.Parameters.AddWithValue("@AKTS", akts);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Güncelleme başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
