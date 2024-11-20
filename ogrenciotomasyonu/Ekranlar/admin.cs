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
    public partial class Form8 : Form
    {
        private int calisanTipi;
        private long tc;
        public Form8(int calisanTipi, long tc)
        {
            InitializeComponent();
            this.calisanTipi = calisanTipi;
            this.tc = tc;
        }

        public long Gettc()
        {
            return tc;
        }

        public int GetCalisanTipi()
        {
            return calisanTipi;
        }
        public Form8()
        {
            InitializeComponent();
            hideSubMenu();

        }
        
        private void hideSubMenu()
        {
            
            panelPlaylistSubMenu.Visible = false;

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
        #region 
        private void button8_Click(object sender, EventArgs e)
        {
           

        }
        #endregion
        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Profil(calisanTipi, tc));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new OgrenciEkle());
            
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Listele());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Sil());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Düzenle());
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

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Düzenle());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
