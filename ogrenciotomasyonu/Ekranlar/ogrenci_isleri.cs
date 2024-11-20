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

    public partial class Form9 : Form
    {
        private int calisanTipi;
        private long tc;

        public Form9(int calisanTipi,long tc)
        {
            InitializeComponent();
            this.calisanTipi  = calisanTipi;
            this.tc = tc;
        }

        public long Gettc()
        {
            return tc;
        }

        public int GetCalisanTipi()
        {
            return calisanTipi ;
        }


        public Form9()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {

            panel1.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Tip: {calisanTipi}, Tc: {tc}", "Form3 Veri Al");

        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new DersEkle());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new OgrenciEkle());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Listele());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Sil());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Düzenle());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Profil(calisanTipi,tc));
        }
    }
}
