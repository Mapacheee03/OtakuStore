namespace MangaStore_
{
    partial class Areglos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Areglos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTomo = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMangas = new System.Windows.Forms.DataGridView();
            this.Manga_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manga_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manga_Tomo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manga_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manga_Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manga_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCerrarForm = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMangas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar arreglos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tomo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(21, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Editorial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(21, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(21, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTomo
            // 
            this.txtTomo.Location = new System.Drawing.Point(103, 173);
            this.txtTomo.Name = "txtTomo";
            this.txtTomo.Size = new System.Drawing.Size(121, 23);
            this.txtTomo.TabIndex = 8;
            this.txtTomo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownTomo_KeyPress);
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(103, 232);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(121, 23);
            this.txtEditorial.TabIndex = 14;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(103, 202);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(121, 23);
            this.txtAuthor.TabIndex = 15;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(103, 261);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(121, 23);
            this.txtGenero.TabIndex = 16;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 292);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 23);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxnumeros_KeyPress);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(103, 144);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 23);
            this.txtTitulo.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.dtgvMangas);
            this.panel1.Controls.Add(this.btnCerrarForm);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEditorial);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTomo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 618);
            this.panel1.TabIndex = 20;
            // 
            // dtgvMangas
            // 
            this.dtgvMangas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMangas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manga_Id,
            this.Manga_Titulo,
            this.Manga_Tomo,
            this.Manga_Author,
            this.Manga_Editorial,
            this.Manga_Genero,
            this.dataGridViewTextBoxColumn1,
            this.Btn_Editar,
            this.Eliminar});
            this.dtgvMangas.Location = new System.Drawing.Point(241, 32);
            this.dtgvMangas.Name = "dtgvMangas";
            this.dtgvMangas.RowTemplate.Height = 25;
            this.dtgvMangas.Size = new System.Drawing.Size(1086, 535);
            this.dtgvMangas.TabIndex = 22;
            // 
            // Manga_Id
            // 
            this.Manga_Id.Frozen = true;
            this.Manga_Id.HeaderText = "Codigo de barra";
            this.Manga_Id.Name = "Manga_Id";
            this.Manga_Id.ReadOnly = true;
            // 
            // Manga_Titulo
            // 
            this.Manga_Titulo.Frozen = true;
            this.Manga_Titulo.HeaderText = "Titulo";
            this.Manga_Titulo.Name = "Manga_Titulo";
            this.Manga_Titulo.ReadOnly = true;
            // 
            // Manga_Tomo
            // 
            this.Manga_Tomo.Frozen = true;
            this.Manga_Tomo.HeaderText = "Tomo";
            this.Manga_Tomo.Name = "Manga_Tomo";
            this.Manga_Tomo.ReadOnly = true;
            // 
            // Manga_Author
            // 
            this.Manga_Author.Frozen = true;
            this.Manga_Author.HeaderText = "Author";
            this.Manga_Author.Name = "Manga_Author";
            this.Manga_Author.ReadOnly = true;
            // 
            // Manga_Editorial
            // 
            this.Manga_Editorial.Frozen = true;
            this.Manga_Editorial.HeaderText = "Editorial";
            this.Manga_Editorial.Name = "Manga_Editorial";
            this.Manga_Editorial.ReadOnly = true;
            // 
            // Manga_Genero
            // 
            this.Manga_Genero.Frozen = true;
            this.Manga_Genero.HeaderText = "Genero";
            this.Manga_Genero.Name = "Manga_Genero";
            this.Manga_Genero.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.DataPropertyName = "Editar";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.NullValue = "Editar";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Btn_Editar.Frozen = true;
            this.Btn_Editar.HeaderText = "Editar";
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Btn_Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.NullValue = "Eliminar";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.ToolTipText = "Eliminar";
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCerrarForm.FlatAppearance.BorderSize = 0;
            this.btnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarForm.Image")));
            this.btnCerrarForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarForm.Location = new System.Drawing.Point(3, 12);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(31, 47);
            this.btnCerrarForm.TabIndex = 21;
            this.btnCerrarForm.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(129, 321);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 33);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Areglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 618);
            this.Controls.Add(this.panel1);
            this.Name = "Areglos";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMangas)).EndInit();
            this.ResumeLayout(false);

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
        private DataGridViewTextBoxColumn Manga_Id;
        private DataGridViewTextBoxColumn Manga_Titulo;
        private DataGridViewTextBoxColumn Manga_Tomo;
        private DataGridViewTextBoxColumn Manga_Author;
        private DataGridViewTextBoxColumn Manga_Editorial;
        private DataGridViewTextBoxColumn Manga_Genero;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn Btn_Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}