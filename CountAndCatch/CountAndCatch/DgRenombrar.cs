using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountAndCatch
{
    public partial class DgRenombrar : Form
    {
        public string FilePath { get; set; }
        public DgRenombrar()
        {
            InitializeComponent();
        }

        private void DgRenombrar_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(FilePath))
            {
                txtNombre.Text = Path.GetFileName(FilePath); 
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debes escribir un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string newFilePath = Path.Combine(Path.GetDirectoryName(FilePath), txtNombre.Text);
                File.Move(FilePath, newFilePath);
                MessageBox.Show("Archivo renombrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al renombrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
