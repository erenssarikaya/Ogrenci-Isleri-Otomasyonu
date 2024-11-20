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
    public partial class Hoca_Ders : Form
    {
        private int calisanTipi;
        private long tc;
        private int calisanID;

        SqlConnection baglanti = new SqlConnection("Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        DataTable dt = new DataTable();
        public Hoca_Ders()
        {
            InitializeComponent();
        }
        public Hoca_Ders(int calisanTipi, long tc, int calisanID)
        {
            InitializeComponent();
            this.calisanTipi = calisanTipi;
            this.tc = tc;
            this.calisanID = calisanID;
        }
        private void Hoca_Ders_Load(object sender, EventArgs e)
        {
            try
            {
                komut.Connection = baglanti;
                komut.CommandText = "select d.dersKodu,d.DersAdi from calisanlar c,ogretmenDers o,dersler d where c.calisnID=o.ogretmenID and o.DersId=d.DersID and calisanID=@id";
                komut.Parameters.Add("@id", SqlDbType.Int).Value = calisanID;
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
    }
}
