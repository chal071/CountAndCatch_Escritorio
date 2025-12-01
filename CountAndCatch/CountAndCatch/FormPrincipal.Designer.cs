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
            this.buttonDirecoty = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.dataGridViewJson = new System.Windows.Forms.DataGridView();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCat = new System.Windows.Forms.PictureBox();
            this.grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.White;
            this.grid.BackgroundImage = global::CountAndCatch.Properties.Resources.bginicio;
            this.grid.ColumnCount = 6;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.grid.Controls.Add(this.buttonRenombrar, 4, 0);
            this.grid.Controls.Add(this.buttonEliminar, 3, 0);
            this.grid.Controls.Add(this.buttonJson, 2, 0);
            this.grid.Controls.Add(this.buttonDirecoty, 1, 0);
            this.grid.Controls.Add(this.listViewFiles, 0, 1);
            this.grid.Controls.Add(this.dataGridViewJson, 2, 2);
            this.grid.Controls.Add(this.buttonFiltrar, 5, 1);
            this.grid.Controls.Add(this.buttonExportar, 5, 3);
            this.grid.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.grid.Controls.Add(this.pictureBoxCat, 4, 3);
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
            this.buttonRenombrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonRenombrar.BackgroundImage = global::CountAndCatch.Properties.Resources.btnRenombrar;
            this.buttonRenombrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRenombrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRenombrar.FlatAppearance.BorderSize = 0;
            this.buttonRenombrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRenombrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRenombrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenombrar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRenombrar.Location = new System.Drawing.Point(1109, 0);
            this.buttonRenombrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRenombrar.Name = "buttonRenombrar";
            this.buttonRenombrar.Size = new System.Drawing.Size(317, 98);
            this.buttonRenombrar.TabIndex = 4;
            this.buttonRenombrar.UseVisualStyleBackColor = false;
            this.buttonRenombrar.Click += new System.EventHandler(this.buttonRenombrar_Click);
            this.buttonRenombrar.MouseLeave += new System.EventHandler(this.buttonRenombrar_MouseLeave);
            this.buttonRenombrar.MouseHover += new System.EventHandler(this.buttonRenombrar_MouseHover);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.BackgroundImage = global::CountAndCatch.Properties.Resources.btnEliminar;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(792, 0);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(317, 98);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            this.buttonEliminar.MouseLeave += new System.EventHandler(this.buttonEliminar_MouseLeave);
            this.buttonEliminar.MouseHover += new System.EventHandler(this.buttonEliminar_MouseHover);
            // 
            // buttonJson
            // 
            this.buttonJson.BackColor = System.Drawing.Color.Transparent;
            this.buttonJson.BackgroundImage = global::CountAndCatch.Properties.Resources.btnImporta;
            this.buttonJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonJson.FlatAppearance.BorderSize = 0;
            this.buttonJson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonJson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJson.ForeColor = System.Drawing.Color.White;
            this.buttonJson.Location = new System.Drawing.Point(475, 0);
            this.buttonJson.Margin = new System.Windows.Forms.Padding(0);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(317, 98);
            this.buttonJson.TabIndex = 2;
            this.buttonJson.UseVisualStyleBackColor = false;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            this.buttonJson.MouseLeave += new System.EventHandler(this.buttonJson_MouseLeave);
            this.buttonJson.MouseHover += new System.EventHandler(this.buttonJson_MouseHover);
            // 
            // buttonDirecoty
            // 
            this.buttonDirecoty.BackColor = System.Drawing.Color.Transparent;
            this.buttonDirecoty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDirecoty.BackgroundImage")));
            this.buttonDirecoty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDirecoty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDirecoty.FlatAppearance.BorderSize = 0;
            this.buttonDirecoty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDirecoty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDirecoty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDirecoty.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDirecoty.Location = new System.Drawing.Point(158, 0);
            this.buttonDirecoty.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDirecoty.Name = "buttonDirecoty";
            this.buttonDirecoty.Size = new System.Drawing.Size(317, 98);
            this.buttonDirecoty.TabIndex = 1;
            this.buttonDirecoty.UseVisualStyleBackColor = false;
            this.buttonDirecoty.Click += new System.EventHandler(this.buttonDirecoty_Click);
            this.buttonDirecoty.MouseLeave += new System.EventHandler(this.buttonDirecoty_MouseLeave);
            this.buttonDirecoty.MouseHover += new System.EventHandler(this.buttonDirecoty_MouseHover);
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
            this.listViewFiles.Size = new System.Drawing.Size(469, 885);
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
            this.dataGridViewJson.Location = new System.Drawing.Point(478, 199);
            this.dataGridViewJson.Name = "dataGridViewJson";
            this.dataGridViewJson.RowHeadersVisible = false;
            this.dataGridViewJson.RowHeadersWidth = 82;
            this.dataGridViewJson.RowTemplate.Height = 33;
            this.dataGridViewJson.Size = new System.Drawing.Size(1185, 686);
            this.dataGridViewJson.TabIndex = 6;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonFiltrar.BackgroundImage = global::CountAndCatch.Properties.Resources.btnFiltrar;
            this.buttonFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFiltrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFiltrar.FlatAppearance.BorderSize = 0;
            this.buttonFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(1426, 98);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(240, 98);
            this.buttonFiltrar.TabIndex = 7;
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.MouseLeave += new System.EventHandler(this.buttonFiltrar_MouseLeave);
            this.buttonFiltrar.MouseHover += new System.EventHandler(this.buttonFiltrar_MouseHover);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.Transparent;
            this.buttonExportar.BackgroundImage = global::CountAndCatch.Properties.Resources.btnGuardar;
            this.buttonExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExportar.FlatAppearance.BorderSize = 0;
            this.buttonExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.ForeColor = System.Drawing.Color.White;
            this.buttonExportar.Location = new System.Drawing.Point(1426, 888);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(240, 101);
            this.buttonExportar.TabIndex = 8;
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            this.buttonExportar.MouseLeave += new System.EventHandler(this.buttonExportar_MouseLeave);
            this.buttonExportar.MouseHover += new System.EventHandler(this.buttonExportar_MouseHover);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::CountAndCatch.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(152, 92);
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxCat
            // 
            this.pictureBoxCat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCat.BackgroundImage = global::CountAndCatch.Properties.Resources.imageCat;
            this.pictureBoxCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCat.Location = new System.Drawing.Point(1112, 891);
            this.pictureBoxCat.Name = "pictureBoxCat";
            this.pictureBoxCat.Size = new System.Drawing.Size(311, 95);
            this.pictureBoxCat.TabIndex = 10;
            this.pictureBoxCat.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.Button buttonJson;
        private System.Windows.Forms.Button buttonDirecoty;
        private System.Windows.Forms.Button buttonRenombrar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.DataGridView dataGridViewJson;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxCat;
    }
}

