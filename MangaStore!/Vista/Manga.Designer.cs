namespace MangaStore_
{
    partial class Manga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manga));
            panel1 = new Panel();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            panel2 = new Panel();
            btnCerrarForm = new Button();
            panel3 = new Panel();
            txtDetalles = new TextBox();
            label3 = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            dgvDetalles = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtProducto = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 41, 61);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(52, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 40);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(140, 36);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(244, 36);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 40);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(332, 36);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 41, 61);
            panel2.Controls.Add(btnCerrarForm);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 39);
            panel2.TabIndex = 1;
            // 
            // btnCerrarForm
            // 
            btnCerrarForm.BackColor = Color.FromArgb(32, 30, 45);
            btnCerrarForm.FlatAppearance.BorderSize = 0;
            btnCerrarForm.FlatStyle = FlatStyle.Flat;
            btnCerrarForm.ForeColor = SystemColors.ControlLightLight;
            btnCerrarForm.Image = (Image)resources.GetObject("btnCerrarForm.Image");
            btnCerrarForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarForm.Location = new Point(0, 0);
            btnCerrarForm.Name = "btnCerrarForm";
            btnCerrarForm.Size = new Size(31, 47);
            btnCerrarForm.TabIndex = 22;
            btnCerrarForm.UseVisualStyleBackColor = false;
            btnCerrarForm.Click += btnCerrarForm_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 30, 45);
            panel3.Controls.Add(txtDetalles);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtValor);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dgvDetalles);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtProducto);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 311);
            panel3.TabIndex = 2;
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(23, 178);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(172, 23);
            txtDetalles.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 150);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 9;
            label3.Text = "DETALLES";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(23, 114);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(172, 23);
            txtValor.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 86);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 7;
            label2.Text = "VALOR";
            // 
            // dgvDetalles
            // 
            dgvDetalles.BackgroundColor = Color.FromArgb(32, 30, 45);
            dgvDetalles.BorderStyle = BorderStyle.None;
            dgvDetalles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, Column3, Column4 });
            dgvDetalles.GridColor = Color.FromArgb(32, 30, 45);
            dgvDetalles.Location = new Point(239, 22);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(527, 263);
            dgvDetalles.TabIndex = 6;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "TITULO";
            NOMBRE.Name = "NOMBRE";
            // 
            // Column3
            // 
            Column3.HeaderText = "AUTHOR";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "PRECIO";
            Column4.Name = "Column4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTO";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(23, 50);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(172, 23);
            txtProducto.TabIndex = 0;
            // 
            // Manga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Manga";
            Text = "Manga";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnAgregar;
        private Button btnModificar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label3;
        private TextBox txtValor;
        private Label label2;
        private Label label1;
        private TextBox txtProducto;
        private TextBox textBox1;
        private Button btnCerrarForm;
        private TextBox txtDetalles;
        private DataGridView dgvDetalles;
    }
}