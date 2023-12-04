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
            button10 = new Button();
            panelMangaSubMenu = new Panel();
            button3 = new Button();
            btnCola = new Button();
            button6 = new Button();
            button7 = new Button();
            btnManga = new Button();
            btnRegistrar = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(button10);
            panel1.Controls.Add(panelMangaSubMenu);
            panel1.Controls.Add(btnManga);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 581);
            panel1.TabIndex = 0;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.Gainsboro;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 517);
            button10.Name = "button10";
            button10.Padding = new Padding(5, 0, 0, 0);
            button10.Size = new Size(250, 52);
            button10.TabIndex = 10;
            button10.Text = "    Creadores";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnCreadores_Click;
            // 
            // panelMangaSubMenu
            // 
            panelMangaSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelMangaSubMenu.Controls.Add(button3);
            panelMangaSubMenu.Controls.Add(btnCola);
            panelMangaSubMenu.Controls.Add(button6);
            panelMangaSubMenu.Controls.Add(button7);
            panelMangaSubMenu.Dock = DockStyle.Top;
            panelMangaSubMenu.Location = new Point(0, 280);
            panelMangaSubMenu.Name = "panelMangaSubMenu";
            panelMangaSubMenu.Size = new Size(250, 237);
            panelMangaSubMenu.TabIndex = 7;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(0, 135);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(250, 45);
            button3.TabIndex = 5;
            button3.Text = "Listas";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnListas_Click;
            // 
            // btnCola
            // 
            btnCola.Dock = DockStyle.Top;
            btnCola.FlatAppearance.BorderSize = 0;
            btnCola.FlatStyle = FlatStyle.Flat;
            btnCola.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCola.ForeColor = Color.LightGray;
            btnCola.Location = new Point(0, 90);
            btnCola.Name = "btnCola";
            btnCola.Padding = new Padding(35, 0, 0, 0);
            btnCola.Size = new Size(250, 45);
            btnCola.TabIndex = 3;
            btnCola.Text = "Cola";
            btnCola.TextAlign = ContentAlignment.MiddleLeft;
            btnCola.UseVisualStyleBackColor = true;
            btnCola.Click += btnCola_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.LightGray;
            button6.Location = new Point(0, 45);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(250, 45);
            button6.TabIndex = 2;
            button6.Text = "Arreglos";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnArreglos_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.LightGray;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(250, 45);
            button7.TabIndex = 1;
            button7.Text = "Pilas";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnPilas_Click;
            // 
            // btnManga
            // 
            btnManga.Dock = DockStyle.Top;
            btnManga.FlatAppearance.BorderSize = 0;
            btnManga.FlatStyle = FlatStyle.Flat;
            btnManga.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManga.ForeColor = Color.Gainsboro;
            btnManga.ImageAlign = ContentAlignment.MiddleLeft;
            btnManga.Location = new Point(0, 235);
            btnManga.Name = "btnManga";
            btnManga.Padding = new Padding(5, 0, 0, 0);
            btnManga.Size = new Size(250, 45);
            btnManga.TabIndex = 6;
            btnManga.Text = "    Mangas";
            btnManga.TextAlign = ContentAlignment.MiddleLeft;
            btnManga.UseVisualStyleBackColor = true;
            btnManga.Click += btnManga_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Top;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.Gainsboro;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(0, 190);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Padding = new Padding(5, 0, 0, 0);
            btnRegistrar.Size = new Size(250, 45);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "    Registrar";
            btnRegistrar.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 190);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(11, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(233, 190);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(260, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1110, 581);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(446, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 222);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelSideMenu
            // 
            ClientSize = new Size(1370, 581);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            Name = "panelSideMenu";
            Padding = new Padding(10, 0, 0, 0);
            panel1.ResumeLayout(false);
            panelMangaSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrar;
#pragma warning disable CS0169 // El campo 'panelSideMenu.button8' nunca se usa
        private Button button8;
#pragma warning restore CS0169 // El campo 'panelSideMenu.button8' nunca se usa
#pragma warning disable CS0169 // El campo 'panelSideMenu.button9' nunca se usa
        private Button button9;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
#pragma warning disable CS0169 // El campo 'panelSideMenu.dateTimePicker1' nunca se usa
        private DateTimePicker dateTimePicker1;
#pragma warning restore CS0169 // El campo 'panelSideMenu.dateTimePicker1' nunca se usa
        private Panel panelLogo;
        private Button button10;
        private Panel panelMangaSubMenu;
        private Button button3;
        private Button btnCola;
        private Button button6;
        private Button button7;
        private Button btnManga;
    }
}