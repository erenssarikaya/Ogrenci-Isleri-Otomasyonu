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
    public partial class ogrenci_ekrani : Form
    {
      

       

        public ogrenci_ekrani()
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

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Profil());
        }

        private void panelPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ogrenci_ekrani_Load(object sender, EventArgs e)
        {
            
        }
    }
}
