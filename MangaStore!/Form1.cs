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
            panelAnimesSubMenu.Visible = false;
        }
        public void hideSubMenu()
        {
            if (panelMangaSubMenu.Visible == true)
                panelMangaSubMenu.Visible = false;
            if (panelAnimesSubMenu.Visible == true)
                panelAnimesSubMenu.Visible = false;
        }
        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnManga_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMangaSubMenu);
        }

        private void btnAnimes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAnimesSubMenu);
        }
        private Form activeForm = null;
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
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void btnShōjo_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();

        }

        private void btnSeinen_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }
        private void btnKodomo_Click(object sender, EventArgs e)
        {

            openChildForm(new());
            hideSubMenu();

        }

        private void btnAcción_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void btnMedievalFantasy_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRomance_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTerror_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDrama_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnCreadores_Click(object sender, EventArgs e)
        {
            openChildForm(new Creadores());
        }
        c
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}