using ogrenciotomasyonu.ıvır_zıvır;
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
    public partial class Form6 : Form
    {
        private int calisanTipi;
        private long tc;
        private int calisanID;
        public Form6(int calisanTipi, long tc,int calisanID)
        {
            InitializeComponent();
            this.calisanTipi = calisanTipi;
            this.tc = tc;
            this.calisanID = calisanID;
        }

        public long Gettc()
        {
            return tc;
        }

        public int GetCalisanTipi()
        {
            return calisanTipi;
        }
        public int GetCalisanID()
        {
            return calisanID;
        }
        private void panelPlayer_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            openChildForm(new Hoca_Ders(calisanTipi, tc, calisanID));
            

       
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Profil(calisanTipi, tc,calisanID ));
        }
    }
}
