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
    public partial class FormRenombrar : Form
    {
        public string NuevoNombre { get; private set; }

        public FormRenombrar(string nombreActual)
        {
            InitializeComponent();
            textBoxNombre.Text = nombreActual; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Introducer un nombre");
                return;
            }

            NuevoNombre = textBoxNombre.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
