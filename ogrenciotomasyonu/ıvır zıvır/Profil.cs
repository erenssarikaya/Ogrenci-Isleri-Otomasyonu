using ogrenciotomasyonu.Ekranlar;
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
    public partial class Profil : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        private int calisanTipi;
        private long tc;
        private int calisanID;

        public Profil(int calisanTipi, long tc)
        {
            InitializeComponent();
            this.calisanTipi = calisanTipi;
            this.tc = tc;
        }
        public Profil(int calisanTipi, long tc,int calisanID)
        {
            InitializeComponent();
            this.calisanTipi = calisanTipi;
            this.tc = tc;
            this.calisanID = calisanID;
        }
        private void Profil_Load(object sender, EventArgs e)
        {
            switch (calisanTipi)
            {
                case 0: // Öğrenci İşleri
               
                    {
                        label6.Text = "ÖĞRENCİ İŞLERİ ÇALIŞANI";
                        break;
                    }

                case 1:// Hoca
         
                    {
                        label6.Text = "ÖĞRETİM ÜYESİ";
                        break;
                    }

                case 2: // Admin
         
                    {
                        label6.Text = "ADMİN";
                        break;
                    }
            }
                    // Alınan verileri kullan
                    // MessageBox.Show($"Tip: {calisanTipi}, Tc: {tc}", "Form3 Veri Al");

                    try
            {
                cmd.Connection = conn;
                cmd.CommandText = "Select * from calisanlar where Tc='" + tc + "'";
                conn.Open();
                dt.Load(cmd.ExecuteReader());

                txtad.DataBindings.Add("Text", dt, "ad");
                txtsoyad.DataBindings.Add("Text", dt, "soyad");
                txtdogumtarihi.DataBindings.Add("Text", dt, "dogumTarihi");
                txttel.DataBindings.Add("Text", dt, "telefon");
                txtemail.DataBindings.Add("Text", dt, "email");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Mesajı", MessageBoxButtons.OK);
            }
        }
   

    public Profil()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdogumtarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
