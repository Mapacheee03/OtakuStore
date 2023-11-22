namespace MangaStore_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTomo = new TextBox();
            txtEditorial = new TextBox();
            txtAuthor = new TextBox();
            txtGenero = new TextBox();
            txtPrecio = new TextBox();
            txtTitulo = new TextBox();
            panel1 = new Panel();
            dtgvMangas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Tomo = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            btnCerrarForm = new Button();
            btnAgregar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMangas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(111, 82);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 0;
            label1.Text = "Registrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(111, 137);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(111, 172);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 2;
            label3.Text = "Tomo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(399, 137);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(399, 169);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 4;
            label5.Text = "Editorial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(698, 135);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 5;
            label6.Text = "Genero";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(698, 166);
            label7.Name = "label7";
            label7.Size = new Size(66, 28);
            label7.TabIndex = 6;
            label7.Text = "Precio";
            // 
            // txtTomo
            // 
            txtTomo.Location = new Point(221, 172);
            txtTomo.Name = "txtTomo";
            txtTomo.Size = new Size(121, 23);
            txtTomo.TabIndex = 8;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(509, 167);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(121, 23);
            txtEditorial.TabIndex = 14;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(509, 137);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(121, 23);
            txtAuthor.TabIndex = 15;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(808, 135);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(121, 23);
            txtGenero.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(808, 166);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 17;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(221, 143);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(121, 23);
            txtTitulo.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(dtgvMangas);
            panel1.Controls.Add(btnCerrarForm);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtGenero);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEditorial);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTomo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1777, 618);
            panel1.TabIndex = 20;
            // 
            // dtgvMangas
            // 
            dtgvMangas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMangas.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Tomo, Author, Editorial, Genero, Precio });
            dtgvMangas.Location = new Point(33, 260);
            dtgvMangas.Name = "dtgvMangas";
            dtgvMangas.RowTemplate.Height = 25;
            dtgvMangas.Size = new Size(1333, 245);
            dtgvMangas.TabIndex = 22;
            // 
            // Id
            // 
            Id.HeaderText = "Codigo de barra";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // Tomo
            // 
            Tomo.HeaderText = "Tomo";
            Tomo.Name = "Tomo";
            Tomo.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.Name = "Editorial";
            Editorial.ReadOnly = true;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // btnCerrarForm
            // 
            btnCerrarForm.BackColor = Color.FromArgb(32, 30, 45);
            btnCerrarForm.FlatAppearance.BorderSize = 0;
            btnCerrarForm.FlatStyle = FlatStyle.Flat;
            btnCerrarForm.ForeColor = SystemColors.ControlLightLight;
            btnCerrarForm.Image = (Image)resources.GetObject("btnCerrarForm.Image");
            btnCerrarForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarForm.Location = new Point(12, 12);
            btnCerrarForm.Name = "btnCerrarForm";
            btnCerrarForm.Size = new Size(31, 47);
            btnCerrarForm.TabIndex = 21;
            btnCerrarForm.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(1035, 137);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 33);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 618);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMangas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button btnAgregar;
        private Button btnCerrarForm;
        public TextBox txtTomo;
        public TextBox txtEditorial;
        public TextBox txtAuthor;
        public TextBox txtGenero;
        public TextBox txtPrecio;
        public TextBox txtTitulo;
        private DataGridView dtgvMangas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Tomo;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Editorial;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Precio;
    }
}