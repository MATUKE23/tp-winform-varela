namespace Vista
{
    partial class FormArticulos
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
            this.DGVAllArticles = new System.Windows.Forms.DataGridView();
            this.PBXAllArticles = new System.Windows.Forms.PictureBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXAllArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAllArticles
            // 
            this.DGVAllArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAllArticles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVAllArticles.Location = new System.Drawing.Point(9, 35);
            this.DGVAllArticles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVAllArticles.MultiSelect = false;
            this.DGVAllArticles.Name = "DGVAllArticles";
            this.DGVAllArticles.RowHeadersWidth = 51;
            this.DGVAllArticles.RowTemplate.Height = 24;
            this.DGVAllArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAllArticles.Size = new System.Drawing.Size(690, 378);
            this.DGVAllArticles.TabIndex = 0;
            this.DGVAllArticles.SelectionChanged += new System.EventHandler(this.DGVAllArticles_SelectionChanged);
            // 
            // PBXAllArticles
            // 
            this.PBXAllArticles.Location = new System.Drawing.Point(802, 35);
            this.PBXAllArticles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBXAllArticles.Name = "PBXAllArticles";
            this.PBXAllArticles.Size = new System.Drawing.Size(286, 370);
            this.PBXAllArticles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXAllArticles.TabIndex = 1;
            this.PBXAllArticles.TabStop = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(113, 444);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(56, 19);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(35, 444);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(56, 19);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(188, 444);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(56, 19);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 490);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.PBXAllArticles);
            this.Controls.Add(this.DGVAllArticles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormArticulos";
            this.Text = "FormTestAllArticles";
            this.Load += new System.EventHandler(this.FormTestAllArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXAllArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAllArticles;
        private System.Windows.Forms.PictureBox PBXAllArticles;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}