namespace MangaStore_.Vista.Colas
{
    partial class Cola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cola));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnEliminar = new Button();
            dtgvMangas = new DataGridView();
            btnCerrarForm = new Button();
            btnAgregar = new Button();
            txtTitulo = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            label6 = new Label();
            txtGenero = new TextBox();
            label2 = new Label();
            txtAuthor = new TextBox();
            label4 = new Label();
            txtEditorial = new TextBox();
            label7 = new Label();
            txtTomo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            Manga_Id = new DataGridViewTextBoxColumn();
            Manga_Titulo = new DataGridViewTextBoxColumn();
            Manga_Tomo = new DataGridViewTextBoxColumn();
            Manga_Author = new DataGridViewTextBoxColumn();
            Manga_Editorial = new DataGridViewTextBoxColumn();
            Manga_Genero = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Btn_Editar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMangas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(btnEliminar);
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
            panel1.Size = new Size(1069, 450);
            panel1.TabIndex = 21;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(129, 405);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 33);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dtgvMangas
            // 
            dtgvMangas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMangas.Columns.AddRange(new DataGridViewColumn[] { Manga_Id, Manga_Titulo, Manga_Tomo, Manga_Author, Manga_Editorial, Manga_Genero, dataGridViewTextBoxColumn1, Btn_Editar });
            dtgvMangas.Location = new Point(230, 29);
            dtgvMangas.Name = "dtgvMangas";
            dtgvMangas.RowTemplate.Height = 25;
            dtgvMangas.Size = new Size(1086, 535);
            dtgvMangas.TabIndex = 22;
            dtgvMangas.CellContentClick += dgv_CeldaClick;
            // 
            // btnCerrarForm
            // 
            btnCerrarForm.BackColor = Color.FromArgb(32, 30, 45);
            btnCerrarForm.FlatAppearance.BorderSize = 0;
            btnCerrarForm.FlatStyle = FlatStyle.Flat;
            btnCerrarForm.ForeColor = SystemColors.ControlLightLight;
            btnCerrarForm.Image = (Image)resources.GetObject("btnCerrarForm.Image");
            btnCerrarForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarForm.Location = new Point(3, 12);
            btnCerrarForm.Name = "btnCerrarForm";
            btnCerrarForm.Size = new Size(31, 47);
            btnCerrarForm.TabIndex = 21;
            btnCerrarForm.UseVisualStyleBackColor = false;
            btnCerrarForm.Click += btnCerrarForm_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(129, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 33);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(103, 144);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(121, 23);
            txtTitulo.TabIndex = 19;
            txtTitulo.KeyPress += TextUpDownTitulo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(21, 76);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 0;
            label1.Text = "Registrar Colas";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(103, 291);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 17;
            txtPrecio.KeyPress += txtboxnumeros_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(21, 253);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 5;
            label6.Text = "Genero";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(103, 260);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(121, 23);
            txtGenero.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(21, 131);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(103, 201);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(121, 23);
            txtAuthor.TabIndex = 15;
            txtAuthor.KeyPress += TextUpDownAuthor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(21, 194);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(103, 231);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(121, 23);
            txtEditorial.TabIndex = 14;
            txtEditorial.KeyPress += TextUpDownEditorial_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(21, 284);
            label7.Name = "label7";
            label7.Size = new Size(66, 28);
            label7.TabIndex = 6;
            label7.Text = "Precio";
            // 
            // txtTomo
            // 
            txtTomo.Location = new Point(103, 173);
            txtTomo.Name = "txtTomo";
            txtTomo.Size = new Size(121, 23);
            txtTomo.TabIndex = 8;
            txtTomo.KeyPress += numericUpDownTomo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(21, 226);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 4;
            label5.Text = "Editorial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(21, 166);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 2;
            label3.Text = "Tomo";
            // 
            // Manga_Id
            // 
            Manga_Id.Frozen = true;
            Manga_Id.HeaderText = "Codigo de barra";
            Manga_Id.Name = "Manga_Id";
            Manga_Id.ReadOnly = true;
            // 
            // Manga_Titulo
            // 
            Manga_Titulo.Frozen = true;
            Manga_Titulo.HeaderText = "Titulo";
            Manga_Titulo.Name = "Manga_Titulo";
            Manga_Titulo.ReadOnly = true;
            // 
            // Manga_Tomo
            // 
            Manga_Tomo.Frozen = true;
            Manga_Tomo.HeaderText = "Tomo";
            Manga_Tomo.Name = "Manga_Tomo";
            Manga_Tomo.ReadOnly = true;
            // 
            // Manga_Author
            // 
            Manga_Author.Frozen = true;
            Manga_Author.HeaderText = "Author";
            Manga_Author.Name = "Manga_Author";
            Manga_Author.ReadOnly = true;
            // 
            // Manga_Editorial
            // 
            Manga_Editorial.Frozen = true;
            Manga_Editorial.HeaderText = "Editorial";
            Manga_Editorial.Name = "Manga_Editorial";
            Manga_Editorial.ReadOnly = true;
            // 
            // Manga_Genero
            // 
            Manga_Genero.Frozen = true;
            Manga_Genero.HeaderText = "Genero";
            Manga_Genero.Name = "Manga_Genero";
            Manga_Genero.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "Precio";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.DataPropertyName = "Editar";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle1.NullValue = "Editar";
            dataGridViewCellStyle1.SelectionBackColor = Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 64);
            Btn_Editar.DefaultCellStyle = dataGridViewCellStyle1;
            Btn_Editar.Frozen = true;
            Btn_Editar.HeaderText = "Editar";
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Resizable = DataGridViewTriState.True;
            Btn_Editar.SortMode = DataGridViewColumnSortMode.Automatic;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseColumnTextForButtonValue = true;
            // 
            // Cola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 450);
            Controls.Add(panel1);
            Name = "Cola";
            Text = "Cola";
            Load += Cola_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMangas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvMangas;
        private Button btnCerrarForm;
        private Button btnAgregar;
        public TextBox txtTitulo;
        private Label label1;
        public TextBox txtPrecio;
        private Label label6;
        public TextBox txtGenero;
        private Label label2;
        public TextBox txtAuthor;
        private Label label4;
        public TextBox txtEditorial;
        private Label label7;
        public TextBox txtTomo;
        private Label label5;
        private Label label3;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Manga_Id;
        private DataGridViewTextBoxColumn Manga_Titulo;
        private DataGridViewTextBoxColumn Manga_Tomo;
        private DataGridViewTextBoxColumn Manga_Author;
        private DataGridViewTextBoxColumn Manga_Editorial;
        private DataGridViewTextBoxColumn Manga_Genero;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn Btn_Editar;
    }
}