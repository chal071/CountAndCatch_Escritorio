namespace CountAndCatch
{
    partial class FormFiltrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltrar));
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.buttonQuitarFiltro = new System.Windows.Forms.CheckBox();
            this.chkDif3 = new System.Windows.Forms.CheckBox();
            this.chkDif2 = new System.Windows.Forms.CheckBox();
            this.chkDif1 = new System.Windows.Forms.CheckBox();
            this.chkJuego2 = new System.Windows.Forms.CheckBox();
            this.chkJuego1 = new System.Windows.Forms.CheckBox();
            this.buttonAceptar = new System.Windows.Forms.CheckBox();
            this.grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackgroundImage = global::CountAndCatch.Properties.Resources.bginicio;
            this.grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grid.ColumnCount = 6;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.grid.Controls.Add(this.buttonQuitarFiltro, 3, 2);
            this.grid.Controls.Add(this.chkDif3, 4, 1);
            this.grid.Controls.Add(this.chkDif2, 2, 1);
            this.grid.Controls.Add(this.chkDif1, 0, 1);
            this.grid.Controls.Add(this.chkJuego2, 3, 0);
            this.grid.Controls.Add(this.chkJuego1, 1, 0);
            this.grid.Controls.Add(this.buttonAceptar, 1, 2);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.Size = new System.Drawing.Size(1194, 672);
            this.grid.TabIndex = 0;
            // 
            // buttonQuitarFiltro
            // 
            this.buttonQuitarFiltro.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonQuitarFiltro.AutoSize = true;
            this.buttonQuitarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuitarFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuitarFiltro.BackgroundImage")));
            this.buttonQuitarFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQuitarFiltro.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grid.SetColumnSpan(this.buttonQuitarFiltro, 2);
            this.buttonQuitarFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonQuitarFiltro.FlatAppearance.BorderSize = 0;
            this.buttonQuitarFiltro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonQuitarFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonQuitarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonQuitarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitarFiltro.Location = new System.Drawing.Point(600, 451);
            this.buttonQuitarFiltro.Name = "buttonQuitarFiltro";
            this.buttonQuitarFiltro.Size = new System.Drawing.Size(392, 218);
            this.buttonQuitarFiltro.TabIndex = 6;
            this.buttonQuitarFiltro.UseVisualStyleBackColor = false;
            this.buttonQuitarFiltro.Click += new System.EventHandler(this.buttonQuitarFiltro_Click);
            this.buttonQuitarFiltro.MouseLeave += new System.EventHandler(this.buttonQuitarFiltro_MouseLeave);
            this.buttonQuitarFiltro.MouseHover += new System.EventHandler(this.buttonQuitarFiltro_MouseHover);
            // 
            // chkDif3
            // 
            this.chkDif3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDif3.AutoSize = true;
            this.chkDif3.BackColor = System.Drawing.Color.Transparent;
            this.chkDif3.BackgroundImage = global::CountAndCatch.Properties.Resources.btnDificil_noclick;
            this.chkDif3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkDif3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grid.SetColumnSpan(this.chkDif3, 2);
            this.chkDif3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDif3.FlatAppearance.BorderSize = 0;
            this.chkDif3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkDif3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkDif3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkDif3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDif3.Location = new System.Drawing.Point(799, 227);
            this.chkDif3.Name = "chkDif3";
            this.chkDif3.Size = new System.Drawing.Size(392, 218);
            this.chkDif3.TabIndex = 4;
            this.chkDif3.UseVisualStyleBackColor = false;
            this.chkDif3.CheckedChanged += new System.EventHandler(this.chkDif3_CheckedChanged);
            // 
            // chkDif2
            // 
            this.chkDif2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDif2.AutoSize = true;
            this.chkDif2.BackColor = System.Drawing.Color.Transparent;
            this.chkDif2.BackgroundImage = global::CountAndCatch.Properties.Resources.btnIntermedio_noclick;
            this.chkDif2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkDif2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grid.SetColumnSpan(this.chkDif2, 2);
            this.chkDif2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDif2.FlatAppearance.BorderSize = 0;
            this.chkDif2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkDif2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkDif2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkDif2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDif2.Location = new System.Drawing.Point(401, 227);
            this.chkDif2.Name = "chkDif2";
            this.chkDif2.Size = new System.Drawing.Size(392, 218);
            this.chkDif2.TabIndex = 3;
            this.chkDif2.UseVisualStyleBackColor = false;
            this.chkDif2.CheckedChanged += new System.EventHandler(this.chkDif2_CheckedChanged);
            // 
            // chkDif1
            // 
            this.chkDif1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDif1.AutoSize = true;
            this.chkDif1.BackColor = System.Drawing.Color.Transparent;
            this.chkDif1.BackgroundImage = global::CountAndCatch.Properties.Resources.btnFacil_noclick;
            this.chkDif1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkDif1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grid.SetColumnSpan(this.chkDif1, 2);
            this.chkDif1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDif1.FlatAppearance.BorderSize = 0;
            this.chkDif1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkDif1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkDif1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkDif1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDif1.Location = new System.Drawing.Point(3, 227);
            this.chkDif1.Name = "chkDif1";
            this.chkDif1.Size = new System.Drawing.Size(392, 218);
            this.chkDif1.TabIndex = 2;
            this.chkDif1.UseVisualStyleBackColor = false;
            this.chkDif1.CheckedChanged += new System.EventHandler(this.chkDif1_CheckedChanged);
            // 
            // chkJuego2
            // 
            this.chkJuego2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkJuego2.AutoSize = true;
            this.chkJuego2.BackColor = System.Drawing.Color.Transparent;
            this.chkJuego2.BackgroundImage = global::CountAndCatch.Properties.Resources.bgcatch_noclick;
            this.chkJuego2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkJuego2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grid.SetColumnSpan(this.chkJuego2, 2);
            this.chkJuego2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkJuego2.FlatAppearance.BorderSize = 0;
            this.chkJuego2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkJuego2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkJuego2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkJuego2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkJuego2.Location = new System.Drawing.Point(600, 3);
            this.chkJuego2.Name = "chkJuego2";
            this.chkJuego2.Size = new System.Drawing.Size(392, 218);
            this.chkJuego2.TabIndex = 1;
            this.chkJuego2.UseVisualStyleBackColor = false;
            this.chkJuego2.CheckedChanged += new System.EventHandler(this.chkJuego2_CheckedChanged);
            // 
            // chkJuego1
            // 
            this.chkJuego1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkJuego1.AutoSize = true;
            this.chkJuego1.BackColor = System.Drawing.Color.Transparent;
            this.chkJuego1.BackgroundImage = global::CountAndCatch.Properties.Resources.bgcount_noclick;
            this.chkJuego1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkJuego1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grid.SetColumnSpan(this.chkJuego1, 2);
            this.chkJuego1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkJuego1.FlatAppearance.BorderSize = 0;
            this.chkJuego1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkJuego1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkJuego1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkJuego1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkJuego1.Location = new System.Drawing.Point(202, 3);
            this.chkJuego1.Name = "chkJuego1";
            this.chkJuego1.Size = new System.Drawing.Size(392, 218);
            this.chkJuego1.TabIndex = 0;
            this.chkJuego1.UseVisualStyleBackColor = false;
            this.chkJuego1.CheckedChanged += new System.EventHandler(this.chkJuego1_CheckedChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonAceptar.AutoSize = true;
            this.buttonAceptar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.BackgroundImage = global::CountAndCatch.Properties.Resources.btnAceptarFiltro;
            this.buttonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAceptar.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grid.SetColumnSpan(this.buttonAceptar, 2);
            this.buttonAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(202, 451);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(392, 218);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            this.buttonAceptar.MouseLeave += new System.EventHandler(this.buttonAceptar_MouseLeave);
            this.buttonAceptar.MouseHover += new System.EventHandler(this.buttonAceptar_MouseHover);
            // 
            // FormFiltrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 672);
            this.Controls.Add(this.grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFiltrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar";
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.CheckBox chkJuego1;
        private System.Windows.Forms.CheckBox chkJuego2;
        private System.Windows.Forms.CheckBox chkDif1;
        private System.Windows.Forms.CheckBox chkDif3;
        private System.Windows.Forms.CheckBox chkDif2;
        private System.Windows.Forms.CheckBox buttonQuitarFiltro;
        private System.Windows.Forms.CheckBox buttonAceptar;
    }
}