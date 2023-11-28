using MangaStore_.Datos;

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


        private void btnShōnen_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            hideSubMenu();
        }

        private void btnShōjo_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();

        }

        private void btnSeinen_Click(object sender, EventArgs e)
        {
            openChildForm(new Pilas());
            hideSubMenu();

        }
        private void btnKodomo_Click(object sender, EventArgs e)
        {

            openChildForm(new());
            hideSubMenu();

        }



        private void btnMedievalFantasy_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnCreadores_Click(object sender, EventArgs e)
        {
            openChildForm(new Creadores());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            openChildForm(new Areglos());
        }
    }

}