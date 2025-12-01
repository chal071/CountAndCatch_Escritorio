using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountAndCatch
{
    public partial class FormFiltrar : Form
    {
        public int? JuegoSeleccionado { get; private set; }
        public List<int> DificultadesSeleccionadas { get; private set; }

        public bool QuitarFiltro { get; private set; }

        public FormFiltrar()
        {
            InitializeComponent();
            InicializarEstado();
        }

        private void InicializarEstado()
        {
            JuegoSeleccionado = null;
            DificultadesSeleccionadas = new List<int>();
            QuitarFiltro = false;
        }

    
        private void chkJuego1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuego1.Checked)
            {
                chkJuego2.Checked = false;
                chkJuego1.BackgroundImage = Properties.Resources.bgcount;
                chkJuego2.BackgroundImage = Properties.Resources.bgcatch_noclick;
            }
        }

        private void chkJuego2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuego2.Checked)
            {
                chkJuego1.Checked = false;
                chkJuego2.BackgroundImage = Properties.Resources.bgcatch;
                chkJuego1.BackgroundImage = Properties.Resources.bgcount_noclick;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (chkJuego1.Checked)
            {
                JuegoSeleccionado = 1;
            }
            else if (chkJuego2.Checked)
            {
                JuegoSeleccionado = 2;
            }
            else
            {
                JuegoSeleccionado = null;
            }

            DificultadesSeleccionadas = new List<int>();

            if (chkDif1.Checked)
            {
                DificultadesSeleccionadas.Add(1);
            }

            if (chkDif2.Checked)
            {
                DificultadesSeleccionadas.Add(2);
            }

            if (chkDif3.Checked)
            {
                DificultadesSeleccionadas.Add(3);
            }

            DialogResult = DialogResult.OK;
        }

        private void chkDif1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDif1.Checked)
            {
                chkDif1.BackgroundImage = Properties.Resources.btnFacil;
            }
            else
            {
                chkDif1.BackgroundImage = Properties.Resources.btnFacil_noclick;
            }
        }

        private void chkDif2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDif2.Checked)
            {
                chkDif2.BackgroundImage = Properties.Resources.btnIntermedio;
            }
            else
            {
                chkDif2.BackgroundImage = Properties.Resources.btnIntermedio_noclick;
            }

        }

        private void chkDif3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDif3.Checked)
            {
                chkDif3.BackgroundImage = Properties.Resources.btnDificil;
            }
            else
            {
                chkDif3.BackgroundImage = Properties.Resources.btnDificil_noclick;
            }

        }

        private void buttonQuitarFiltro_Click(object sender, EventArgs e)
        {
            chkJuego1.Checked = false;
            chkJuego2.Checked = false;

            chkDif1.Checked = false;
            chkDif2.Checked = false;
            chkDif3.Checked = false;

            JuegoSeleccionado = null;
            DificultadesSeleccionadas.Clear();
            QuitarFiltro = true;

            DialogResult = DialogResult.OK;
        }


        private void buttonAceptar_MouseHover(object sender, EventArgs e)
        {
            buttonAceptar.BackgroundImage = Properties.Resources.btnAceptar_hover;
        }

        private void buttonAceptar_MouseLeave(object sender, EventArgs e)
        {
            buttonAceptar.BackgroundImage = Properties.Resources.btnAceptarFiltro;
        }

        private void buttonQuitarFiltro_MouseLeave(object sender, EventArgs e)
        {
            buttonQuitarFiltro.BackgroundImage = Properties.Resources.btnQuitarFiltro;
        }

        private void buttonQuitarFiltro_MouseHover(object sender, EventArgs e)
        {
            buttonQuitarFiltro.BackgroundImage = Properties.Resources.btnQuitarFiltro_hover;
        }
    }

}
