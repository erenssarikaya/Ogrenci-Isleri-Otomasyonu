using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciotomasyonu
{
    public partial class not_ekle : Form
    {
        public not_ekle()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}
