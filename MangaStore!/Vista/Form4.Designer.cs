namespace MangaStore_
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label2 = new Label();
            btnCerrarForm = new Button();
            label1 = new Label();
            txtPosicion = new TextBox();
            txtValor = new TextBox();
            Liver = new ListBox();
            btnEliminar = new Button();
            btnEliminarDe = new Button();
            btnAgregar = new Button();
            btnMostraar = new Button();
            btnInsertar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 26;
            label2.Text = "Posición:";
            // 
            // btnCerrarForm
            // 
            btnCerrarForm.BackColor = Color.FromArgb(32, 30, 45);
            btnCerrarForm.FlatAppearance.BorderSize = 0;
            btnCerrarForm.FlatStyle = FlatStyle.Flat;
            btnCerrarForm.ForeColor = SystemColors.ControlLightLight;
            btnCerrarForm.Image = (Image)resources.GetObject("btnCerrarForm.Image");
            btnCerrarForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarForm.Location = new Point(17, 7);
            btnCerrarForm.Name = "btnCerrarForm";
            btnCerrarForm.Size = new Size(31, 47);
            btnCerrarForm.TabIndex = 20;
            btnCerrarForm.UseVisualStyleBackColor = false;
            btnCerrarForm.Click += btnCerrarForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 25;
            label1.Text = "Agregar Manga:";
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(168, 78);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(100, 23);
            txtPosicion.TabIndex = 24;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(154, 47);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(213, 23);
            txtValor.TabIndex = 23;
            // 
            // Liver
            // 
            Liver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Liver.FormattingEnabled = true;
            Liver.ItemHeight = 15;
            Liver.Location = new Point(105, 107);
            Liver.Name = "Liver";
            Liver.Size = new Size(362, 289);
            Liver.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(154, 440);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEliminarDe
            // 
            btnEliminarDe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminarDe.Location = new Point(247, 440);
            btnEliminarDe.Name = "btnEliminarDe";
            btnEliminarDe.Size = new Size(75, 23);
            btnEliminarDe.TabIndex = 19;
            btnEliminarDe.Text = "Eliminar De";
            btnEliminarDe.UseVisualStyleBackColor = true;
            btnEliminarDe.Click += btnEliminarDe_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(392, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostraar
            // 
            btnMostraar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMostraar.Location = new Point(442, 440);
            btnMostraar.Name = "btnMostraar";
            btnMostraar.Size = new Size(75, 23);
            btnMostraar.TabIndex = 16;
            btnMostraar.Text = "Mostrar";
            btnMostraar.UseVisualStyleBackColor = true;
            btnMostraar.Click += btnMostraar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.Location = new Point(344, 440);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 17;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPosicion);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(btnEliminarDe);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnInsertar);
            panel1.Controls.Add(btnMostraar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 496);
            panel1.TabIndex = 27;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 496);
            Controls.Add(btnCerrarForm);
            Controls.Add(Liver);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Button btnCerrarForm;
        private Label label1;
        private TextBox txtPosicion;
        private TextBox txtValor;
        private ListBox Liver;
        private Button btnEliminar;
        private Button btnEliminarDe;
        private Button btnAgregar;
        private Button btnMostraar;
        private Button btnInsertar;
        private Panel panel1;
    }
}