using MangaStore_.Datos;
using MangaStore_.Datos.Listas;

namespace MangaStore_
{
    public partial class panelSideMenu : Form
    {
   
        public panelSideMenu()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelMangaSubMenu.Visible = false;

        }
        public void hideSubMenu()
        {
            if (panelMangaSubMenu.Visible == true)
                panelMangaSubMenu.Visible = false;

        }
        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;//A
                //A
            }
            else
                subMenu.Visible = false;
        }
        private void btnManga_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMangaSubMenu);


        }

#pragma warning disable CS8625 // No se puede convertir un literal NULL en un tipo de referencia que no acepta valores NULL.
        private Form activeForm = null;
#pragma warning restore CS8625 // No se puede convertir un literal NULL en un tipo de referencia que no acepta valores NULL.
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnCreadores_Click(object sender, EventArgs e)
        {
            openChildForm(new Creadores());
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {

            openChildForm(new Areglos());
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            openChildForm(new Pilas());
        }

        private void btnArreglos_Click(object sender, EventArgs e)
        {
            openChildForm(new Areglos());
        }

    }

}