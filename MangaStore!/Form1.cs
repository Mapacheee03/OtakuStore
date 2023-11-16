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

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnManga_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMangaSubMenu);
        }

        private void btnAnimes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAnimesSubMenu);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }

}