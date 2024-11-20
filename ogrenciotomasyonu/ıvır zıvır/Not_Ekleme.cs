using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ogrenciotomasyonu.ıvır_zıvır
{
    public partial class Not_Ekleme : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;

        public Not_Ekleme()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }
        private void InitializeDatabase()
        {
            // Veritabanı bağlantısı oluşturun
            string connectionString = "Data Source=Burak;Initial Catalog=ogrenci_otomasyon;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            // DataTable ve SqlDataAdapter oluşturun
            table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Notlar", connection);

            // Insert, Update, Delete komutlarını SqlCommandBuilder kullanarak otomatik oluşturun
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            // SqlDataAdapter'ı SqlCommandBuilder ile ilişkilendirin
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
        }

        private void LoadData()
        {
            // Veritabanındaki Notlar tablosunu DataGridView'e yükleyin
            adapter.Fill(table);
            dataGridViewNotlar.DataSource = table;
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            // Değişiklikleri veritabanına kaydet
            adapter.Update(table);
            MessageBox.Show("Notlar kaydedildi.");
        }

        private void dataGridViewNotlar_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView hücresi düzenlendiğinde çağrılır

            // Eğer Vize veya Final hücresi düzenlendiyse
            if (e.ColumnIndex == dataGridViewNotlar.Columns["Vize"].Index ||
                e.ColumnIndex == dataGridViewNotlar.Columns["Final"].Index)
            {
                // Vize ve Final notlarını al
                object vizeValue = dataGridViewNotlar.Rows[e.RowIndex].Cells["Vize"].Value;
                object finalValue = dataGridViewNotlar.Rows[e.RowIndex].Cells["Final"].Value;

                // Vize ve Final notları girilmişse
                if (vizeValue != null && vizeValue != DBNull.Value &&
                    finalValue != null && finalValue != DBNull.Value)
                {
                    // Vize ve Final notlarını double tipine çevirin
                    double vize = Convert.ToDouble(vizeValue);
                    double final = Convert.ToDouble(finalValue);

                    // Ortalamayı hesaplayın (Vize %30, Final %70)
                    double ortalama = (vize * 0.3) + (final * 0.7);

                    // Ortalamayı Ortalama hücresine yazın
                    dataGridViewNotlar.Rows[e.RowIndex].Cells["Ortalama"].Value = ortalama;
                }
            }
        }
    }
}
