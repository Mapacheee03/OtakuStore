namespace MangaStore_
{
    partial class panelSideMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelSideMenu));
            panel1 = new Panel();
            btnCreadores = new Button();
            panelAnimesSubMenu = new Panel();
            btnDrama = new Button();
            btnTerror = new Button();
            btnRomance = new Button();
            button10 = new Button();
            button11 = new Button();
            btnAnimes = new Button();
            panelMangaSubMenu = new Panel();
            button5 = new Button();
            btnKodomo = new Button();
            btnSeinen = new Button();
            btnShōjo = new Button();
            btnShōnen = new Button();
            btnManga = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelAnimesSubMenu.SuspendLayout();
            panelMangaSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(btnCreadores);
            panel1.Controls.Add(panelAnimesSubMenu);
            panel1.Controls.Add(btnAnimes);
            panel1.Controls.Add(panelMangaSubMenu);
            panel1.Controls.Add(btnManga);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 609);
            panel1.TabIndex = 0;
            // 
            // btnCreadores
            // 
            btnCreadores.Dock = DockStyle.Top;
            btnCreadores.FlatAppearance.BorderSize = 0;
            btnCreadores.FlatStyle = FlatStyle.Flat;
            btnCreadores.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreadores.ForeColor = Color.Gainsboro;
            btnCreadores.Image = (Image)resources.GetObject("btnCreadores.Image");
            btnCreadores.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreadores.Location = new Point(0, 758);
            btnCreadores.Name = "btnCreadores";
            btnCreadores.Padding = new Padding(5, 0, 0, 0);
            btnCreadores.Size = new Size(233, 52);
            btnCreadores.TabIndex = 5;
            btnCreadores.Text = "    Creadores";
            btnCreadores.TextAlign = ContentAlignment.MiddleLeft;
            btnCreadores.UseVisualStyleBackColor = true;
            btnCreadores.Click += btnCreadores_Click;
            // 
            // panelAnimesSubMenu
            // 
            panelAnimesSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelAnimesSubMenu.Controls.Add(btnDrama);
            panelAnimesSubMenu.Controls.Add(btnTerror);
            panelAnimesSubMenu.Controls.Add(btnRomance);
            panelAnimesSubMenu.Controls.Add(button10);
            panelAnimesSubMenu.Controls.Add(button11);
            panelAnimesSubMenu.Dock = DockStyle.Top;
            panelAnimesSubMenu.Location = new Point(0, 524);
            panelAnimesSubMenu.Name = "panelAnimesSubMenu";
            panelAnimesSubMenu.Size = new Size(233, 234);
            panelAnimesSubMenu.TabIndex = 4;
            // 
            // btnDrama
            // 
            btnDrama.Dock = DockStyle.Top;
            btnDrama.FlatAppearance.BorderSize = 0;
            btnDrama.FlatStyle = FlatStyle.Flat;
            btnDrama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDrama.ForeColor = Color.LightGray;
            btnDrama.Location = new Point(0, 180);
            btnDrama.Name = "btnDrama";
            btnDrama.Padding = new Padding(35, 0, 0, 0);
            btnDrama.Size = new Size(233, 45);
            btnDrama.TabIndex = 4;
            btnDrama.Text = "Drama";
            btnDrama.TextAlign = ContentAlignment.MiddleLeft;
            btnDrama.UseVisualStyleBackColor = true;
            btnDrama.Click += btnDrama_Click;
            // 
            // btnTerror
            // 
            btnTerror.Dock = DockStyle.Top;
            btnTerror.FlatAppearance.BorderSize = 0;
            btnTerror.FlatStyle = FlatStyle.Flat;
            btnTerror.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTerror.ForeColor = Color.LightGray;
            btnTerror.Location = new Point(0, 135);
            btnTerror.Name = "btnTerror";
            btnTerror.Padding = new Padding(35, 0, 0, 0);
            btnTerror.Size = new Size(233, 45);
            btnTerror.TabIndex = 3;
            btnTerror.Text = "Terror";
            btnTerror.TextAlign = ContentAlignment.MiddleLeft;
            btnTerror.UseVisualStyleBackColor = true;
            btnTerror.Click += btnTerror_Click;
            // 
            // btnRomance
            // 
            btnRomance.Dock = DockStyle.Top;
            btnRomance.FlatAppearance.BorderSize = 0;
            btnRomance.FlatStyle = FlatStyle.Flat;
            btnRomance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRomance.ForeColor = Color.LightGray;
            btnRomance.Location = new Point(0, 90);
            btnRomance.Name = "btnRomance";
            btnRomance.Padding = new Padding(35, 0, 0, 0);
            btnRomance.Size = new Size(233, 45);
            btnRomance.TabIndex = 2;
            btnRomance.Text = "Romance ";
            btnRomance.TextAlign = ContentAlignment.MiddleLeft;
            btnRomance.UseVisualStyleBackColor = true;
            btnRomance.Click += btnRomance_Click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.LightGray;
            button10.Location = new Point(0, 45);
            button10.Name = "button10";
            button10.Padding = new Padding(35, 0, 0, 0);
            button10.Size = new Size(233, 45);
            button10.TabIndex = 1;
            button10.Text = "Fantasía medieval";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnMedievalFantasy_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.LightGray;
            button11.Location = new Point(0, 0);
            button11.Name = "button11";
            button11.Padding = new Padding(35, 0, 0, 0);
            button11.Size = new Size(233, 45);
            button11.TabIndex = 0;
            button11.Text = "Acción";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnAcción_Click;
            // 
            // btnAnimes
            // 
            btnAnimes.Dock = DockStyle.Top;
            btnAnimes.FlatAppearance.BorderSize = 0;
            btnAnimes.FlatStyle = FlatStyle.Flat;
            btnAnimes.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnimes.ForeColor = Color.Gainsboro;
            btnAnimes.Image = (Image)resources.GetObject("btnAnimes.Image");
            btnAnimes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnimes.Location = new Point(0, 472);
            btnAnimes.Name = "btnAnimes";
            btnAnimes.Padding = new Padding(5, 0, 0, 0);
            btnAnimes.Size = new Size(233, 52);
            btnAnimes.TabIndex = 3;
            btnAnimes.Text = "    Animes";
            btnAnimes.TextAlign = ContentAlignment.MiddleLeft;
            btnAnimes.UseVisualStyleBackColor = true;
            btnAnimes.Click += btnAnimes_Click;
            // 
            // panelMangaSubMenu
            // 
            panelMangaSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelMangaSubMenu.Controls.Add(button5);
            panelMangaSubMenu.Controls.Add(btnKodomo);
            panelMangaSubMenu.Controls.Add(btnSeinen);
            panelMangaSubMenu.Controls.Add(btnShōjo);
            panelMangaSubMenu.Controls.Add(btnShōnen);
            panelMangaSubMenu.Dock = DockStyle.Top;
            panelMangaSubMenu.Location = new Point(0, 235);
            panelMangaSubMenu.Name = "panelMangaSubMenu";
            panelMangaSubMenu.Size = new Size(233, 237);
            panelMangaSubMenu.TabIndex = 2;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.LightGray;
            button5.Location = new Point(0, 180);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(233, 45);
            button5.TabIndex = 6;
            button5.Text = "Shōnen";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // btnKodomo
            // 
            btnKodomo.Dock = DockStyle.Top;
            btnKodomo.FlatAppearance.BorderSize = 0;
            btnKodomo.FlatStyle = FlatStyle.Flat;
            btnKodomo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKodomo.ForeColor = Color.LightGray;
            btnKodomo.Location = new Point(0, 135);
            btnKodomo.Name = "btnKodomo";
            btnKodomo.Padding = new Padding(35, 0, 0, 0);
            btnKodomo.Size = new Size(233, 45);
            btnKodomo.TabIndex = 5;
            btnKodomo.Text = "Kodomo";
            btnKodomo.TextAlign = ContentAlignment.MiddleLeft;
            btnKodomo.UseVisualStyleBackColor = true;
            btnKodomo.Click += btnKodomo_Click;
            // 
            // btnSeinen
            // 
            btnSeinen.Dock = DockStyle.Top;
            btnSeinen.FlatAppearance.BorderSize = 0;
            btnSeinen.FlatStyle = FlatStyle.Flat;
            btnSeinen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeinen.ForeColor = Color.LightGray;
            btnSeinen.Location = new Point(0, 90);
            btnSeinen.Name = "btnSeinen";
            btnSeinen.Padding = new Padding(35, 0, 0, 0);
            btnSeinen.Size = new Size(233, 45);
            btnSeinen.TabIndex = 3;
            btnSeinen.Text = "Seinen";
            btnSeinen.TextAlign = ContentAlignment.MiddleLeft;
            btnSeinen.UseVisualStyleBackColor = true;
            btnSeinen.Click += btnSeinen_Click;
            // 
            // btnShōjo
            // 
            btnShōjo.Dock = DockStyle.Top;
            btnShōjo.FlatAppearance.BorderSize = 0;
            btnShōjo.FlatStyle = FlatStyle.Flat;
            btnShōjo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShōjo.ForeColor = Color.LightGray;
            btnShōjo.Location = new Point(0, 45);
            btnShōjo.Name = "btnShōjo";
            btnShōjo.Padding = new Padding(35, 0, 0, 0);
            btnShōjo.Size = new Size(233, 45);
            btnShōjo.TabIndex = 2;
            btnShōjo.Text = "Shōjo ";
            btnShōjo.TextAlign = ContentAlignment.MiddleLeft;
            btnShōjo.UseVisualStyleBackColor = true;
            btnShōjo.Click += btnShōjo_Click;
            // 
            // btnShōnen
            // 
            btnShōnen.Dock = DockStyle.Top;
            btnShōnen.FlatAppearance.BorderSize = 0;
            btnShōnen.FlatStyle = FlatStyle.Flat;
            btnShōnen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShōnen.ForeColor = Color.LightGray;
            btnShōnen.Location = new Point(0, 0);
            btnShōnen.Name = "btnShōnen";
            btnShōnen.Padding = new Padding(35, 0, 0, 0);
            btnShōnen.Size = new Size(233, 45);
            btnShōnen.TabIndex = 1;
            btnShōnen.Text = "Shōnen";
            btnShōnen.TextAlign = ContentAlignment.MiddleLeft;
            btnShōnen.UseVisualStyleBackColor = true;
            btnShōnen.Click += btnShōnen_Click;
            // 
            // btnManga
            // 
            btnManga.Dock = DockStyle.Top;
            btnManga.FlatAppearance.BorderSize = 0;
            btnManga.FlatStyle = FlatStyle.Flat;
            btnManga.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManga.ForeColor = Color.Gainsboro;
            btnManga.Image = (Image)resources.GetObject("btnManga.Image");
            btnManga.ImageAlign = ContentAlignment.MiddleLeft;
            btnManga.Location = new Point(0, 190);
            btnManga.Name = "btnManga";
            btnManga.Padding = new Padding(5, 0, 0, 0);
            btnManga.Size = new Size(233, 45);
            btnManga.TabIndex = 1;
            btnManga.Text = "    Mangas";
            btnManga.TextAlign = ContentAlignment.MiddleLeft;
            btnManga.UseVisualStyleBackColor = true;
            btnManga.Click += btnManga_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 190);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(233, 190);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(260, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(549, 609);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 222);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelSideMenu
            // 
            ClientSize = new Size(809, 609);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            Name = "panelSideMenu";
            Padding = new Padding(10, 0, 0, 0);
            panel1.ResumeLayout(false);
            panelAnimesSubMenu.ResumeLayout(false);
            panelMangaSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnManga;
        private Panel panelMangaSubMenu;
        private Panel panelAnimesSubMenu;
        private Button button8;
        private Button button9;
        private Button btnAnimes;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1;
        private Panel panelLogo;
        private Button btnKodomo;

        private Button button5;
        private Button btnShōjo;
        private Button btnShōnen;
        private Button btnSeinen;
        private Button btnRomance;
        private Button btnTerror;
        private Button btnDrama;
        private Button button10;
        private Button button11;
        private Button btnCreadores;
    }
}