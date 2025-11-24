namespace CountAndCatch
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRenombrar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonJson = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDirecoty = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.dataGridViewJson = new System.Windows.Forms.DataGridView();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJson)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grid.ColumnCount = 6;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.Controls.Add(this.buttonRenombrar, 4, 0);
            this.grid.Controls.Add(this.buttonEliminar, 3, 0);
            this.grid.Controls.Add(this.buttonJson, 2, 0);
            this.grid.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.grid.Controls.Add(this.buttonDirecoty, 1, 0);
            this.grid.Controls.Add(this.listViewFiles, 0, 1);
            this.grid.Controls.Add(this.dataGridViewJson, 2, 2);
            this.grid.Controls.Add(this.buttonFiltrar, 5, 1);
            this.grid.Controls.Add(this.buttonExportar, 5, 3);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowCount = 4;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.Size = new System.Drawing.Size(1666, 989);
            this.grid.TabIndex = 6;
            // 
            // buttonRenombrar
            // 
            this.buttonRenombrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRenombrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRenombrar.ForeColor = System.Drawing.Color.White;
            this.buttonRenombrar.Location = new System.Drawing.Point(1102, 20);
            this.buttonRenombrar.Margin = new System.Windows.Forms.Padding(20);
            this.buttonRenombrar.Name = "buttonRenombrar";
            this.buttonRenombrar.Size = new System.Drawing.Size(293, 58);
            this.buttonRenombrar.TabIndex = 4;
            this.buttonRenombrar.Text = "Renombrar Fichero";
            this.buttonRenombrar.UseVisualStyleBackColor = false;
            this.buttonRenombrar.Click += new System.EventHandler(this.buttonRenombrar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(769, 20);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(20);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(293, 58);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar Fichero";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonJson
            // 
            this.buttonJson.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonJson.ForeColor = System.Drawing.Color.White;
            this.buttonJson.Location = new System.Drawing.Point(436, 20);
            this.buttonJson.Margin = new System.Windows.Forms.Padding(20);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(293, 58);
            this.buttonJson.TabIndex = 2;
            this.buttonJson.Text = "Importar JSON";
            this.buttonJson.UseVisualStyleBackColor = false;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::CountAndCatch.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(77, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDirecoty
            // 
            this.buttonDirecoty.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDirecoty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDirecoty.ForeColor = System.Drawing.Color.White;
            this.buttonDirecoty.Location = new System.Drawing.Point(103, 20);
            this.buttonDirecoty.Margin = new System.Windows.Forms.Padding(20);
            this.buttonDirecoty.Name = "buttonDirecoty";
            this.buttonDirecoty.Size = new System.Drawing.Size(293, 58);
            this.buttonDirecoty.TabIndex = 1;
            this.buttonDirecoty.Text = "Abrir Directory";
            this.buttonDirecoty.UseVisualStyleBackColor = false;
            this.buttonDirecoty.Click += new System.EventHandler(this.buttonDirecoty_Click);
            // 
            // listViewFiles
            // 
            this.grid.SetColumnSpan(this.listViewFiles, 2);
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(3, 101);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.grid.SetRowSpan(this.listViewFiles, 3);
            this.listViewFiles.Size = new System.Drawing.Size(410, 885);
            this.listViewFiles.TabIndex = 5;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // dataGridViewJson
            // 
            this.dataGridViewJson.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.SetColumnSpan(this.dataGridViewJson, 4);
            this.dataGridViewJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJson.Location = new System.Drawing.Point(419, 199);
            this.dataGridViewJson.Name = "dataGridViewJson";
            this.dataGridViewJson.RowHeadersVisible = false;
            this.dataGridViewJson.RowHeadersWidth = 82;
            this.dataGridViewJson.RowTemplate.Height = 33;
            this.dataGridViewJson.Size = new System.Drawing.Size(1244, 686);
            this.dataGridViewJson.TabIndex = 6;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonFiltrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(1435, 118);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(20);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(211, 58);
            this.buttonFiltrar.TabIndex = 7;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonExportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExportar.ForeColor = System.Drawing.Color.White;
            this.buttonExportar.Location = new System.Drawing.Point(1435, 908);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(20);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(211, 61);
            this.buttonExportar.TabIndex = 8;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 989);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count & Catch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonJson;
        private System.Windows.Forms.Button buttonDirecoty;
        private System.Windows.Forms.Button buttonRenombrar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.DataGridView dataGridViewJson;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonExportar;
    }
}

