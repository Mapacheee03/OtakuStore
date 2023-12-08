namespace MangaStore_.Vista.Pilas
{
    partial class EditarPila
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
            label8 = new Label();
            Codigo_de_barra = new Label();
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
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(47, 105);
            label8.Name = "label8";
            label8.Size = new Size(77, 28);
            label8.TabIndex = 69;
            label8.Text = "Codigo";
            // 
            // Codigo_de_barra
            // 
            Codigo_de_barra.AutoSize = true;
            Codigo_de_barra.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Codigo_de_barra.ForeColor = Color.Transparent;
            Codigo_de_barra.Location = new Point(157, 105);
            Codigo_de_barra.Name = "Codigo_de_barra";
            Codigo_de_barra.Size = new Size(62, 28);
            Codigo_de_barra.TabIndex = 68;
            Codigo_de_barra.Text = "Titulo";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(183, 370);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 33);
            btnAgregar.TabIndex = 67;
            btnAgregar.Text = "Editar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += Click_Editar;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(157, 158);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(121, 23);
            txtTitulo.TabIndex = 66;
            txtTitulo.KeyPress += TextUpDownTitulo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 54;
            label1.Text = "Editar";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(157, 305);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 65;
            txtPrecio.KeyPress += numericUpDownTomo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(47, 274);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 59;
            label6.Text = "Genero";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(157, 274);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(121, 23);
            txtGenero.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(47, 152);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 55;
            label2.Text = "Titulo";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(157, 216);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(121, 23);
            txtAuthor.TabIndex = 63;
            txtAuthor.KeyPress += TextUpDownAuthor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(47, 216);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 57;
            label4.Text = "Author";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(157, 245);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(121, 23);
            txtEditorial.TabIndex = 62;
            txtEditorial.KeyPress += TextUpDownEditorial_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(47, 305);
            label7.Name = "label7";
            label7.Size = new Size(66, 28);
            label7.TabIndex = 60;
            label7.Text = "Precio";
            // 
            // txtTomo
            // 
            txtTomo.Location = new Point(157, 187);
            txtTomo.Name = "txtTomo";
            txtTomo.Size = new Size(121, 23);
            txtTomo.TabIndex = 61;
            txtTomo.KeyPress += txtboxnumeros_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(47, 248);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 58;
            label5.Text = "Editorial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(47, 187);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 56;
            label3.Text = "Tomo";
            // 
            // EditarPila
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(325, 450);
            Controls.Add(label8);
            Controls.Add(Codigo_de_barra);
            Controls.Add(btnAgregar);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(label6);
            Controls.Add(txtGenero);
            Controls.Add(label2);
            Controls.Add(txtAuthor);
            Controls.Add(label4);
            Controls.Add(txtEditorial);
            Controls.Add(label7);
            Controls.Add(txtTomo);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "EditarPila";
            Text = "EditarPila";
            Load += EditarPila_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label Codigo_de_barra;
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
    }
}