namespace MangaStore_
{
    partial class MangaForm
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
            this.dtgvMangas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tomo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMangas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMangas
            // 
            this.dtgvMangas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMangas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titulo,
            this.Tomo,
            this.Author,
            this.Editorial,
            this.Genero,
            this.Precio});
            this.dtgvMangas.Location = new System.Drawing.Point(25, 178);
            this.dtgvMangas.Name = "dtgvMangas";
            this.dtgvMangas.RowTemplate.Height = 25;
            this.dtgvMangas.Size = new System.Drawing.Size(625, 150);
            this.dtgvMangas.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Codigo de barra";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Tomo
            // 
            this.Tomo.HeaderText = "Tomo";
            this.Tomo.Name = "Tomo";
            this.Tomo.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // MangaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvMangas);
            this.Name = "MangaForm";
            this.Text = "MangaForm";
            this.Load += new System.EventHandler(this.MangasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMangas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgvMangas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Tomo;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Editorial;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Precio;
    }
}