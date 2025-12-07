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
using Newtonsoft.Json;

namespace CountAndCatch
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class FormPrincipal : Form
    {
        private string currentDirectory;
        private string currentJsonPath;
        private List<Partida> listaOriginal;

        public FormPrincipal()
        {
            InitializeComponent();
            ConfigurarListView();
            ConfigurarGridUsuarios();
        }

        private void ConfigurarListView()
        {
            int w = listViewFiles.ClientSize.Width;

            listViewFiles.View = View.Details;
            listViewFiles.FullRowSelect = true;
            listViewFiles.MultiSelect = false;

            listViewFiles.Columns.Add("Nombre");
            listViewFiles.Columns.Add("Tamaño");
            listViewFiles.Columns.Add("Modificado");

            listViewFiles.Columns[0].Width = (int)(w * 0.4);
            listViewFiles.Columns[1].Width = (int)(w * 0.2);
            listViewFiles.Columns[2].Width = (int)(w * 0.4); 

        }

        

        private void buttonDirecoty_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Elige un directorio";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    currentDirectory = dialog.SelectedPath;
                    LoadFiles();
                }
            }
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                var item = listViewFiles.SelectedItems[0];
                string ruta = item.Tag.ToString();
                currentJsonPath = ruta;

                var lista = CargarJson(ruta);

                if (lista != null)
                {
                    listaOriginal = lista;
                    dataGridViewJson.DataSource = new List<Partida>(listaOriginal);
                }
            }
            else
            {
                MessageBox.Show("Elegir un archivo Json");
            }
        }



        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                var item = listViewFiles.SelectedItems[0];
                var fullPath = item.Tag.ToString();

                if (File.Exists(fullPath))
                {
                    DialogResult result = MessageBox.Show(
                        "¿Seguro que quieres eliminar este archivo?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        File.Delete(fullPath);
                        LoadFiles();
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecciona un archivo para eliminar.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }



        private void buttonRenombrar_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                var item = listViewFiles.SelectedItems[0];
                var oldPath = item.Tag.ToString();
                var oldName = Path.GetFileName(oldPath);

                using (var dlg = new FormRenombrar(oldName))
                {
                    DialogResult result = dlg.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string newName = dlg.NuevoNombre;

                        if (!string.IsNullOrWhiteSpace(newName) && newName != oldName)
                        {
                            var newPath = Path.Combine(currentDirectory, newName);

                            try
                            {
                                File.Move(oldPath, newPath);
                                LoadFiles();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Fail to rename: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            bool hayDatosCargados = listaOriginal != null && listaOriginal.Count > 0;

            if (hayDatosCargados)
            {
                using (var dlg = new FormFiltrar())
                {
                    DialogResult result = dlg.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        if (dlg.QuitarFiltro)
                        {
                            dataGridViewJson.DataSource = new List<Partida>(listaOriginal);
                        }
                        else
                        {
                            List<Partida> query = new List<Partida>(listaOriginal);

                            if (dlg.JuegoSeleccionado.HasValue)
                            {
                                int juego = dlg.JuegoSeleccionado.Value;
                                query = query.Where(p => p.juego == juego).ToList();
                            }

                            bool hayDificultades = dlg.DificultadesSeleccionadas != null
                                                   && dlg.DificultadesSeleccionadas.Count > 0;

                            if (hayDificultades)
                            {
                                List<int> difs = dlg.DificultadesSeleccionadas;
                                query = query.Where(p => difs.Contains(p.dificultad)).ToList();
                            }

                            List<Partida> filtradas = query;
                            dataGridViewJson.DataSource = filtradas;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos cargados para filtrar.");
            }
        }




        private void LoadFiles()
        {
            listViewFiles.Items.Clear();

            if (Directory.Exists(currentDirectory))
            {
                var files = Directory.GetFiles(currentDirectory, "*.json");

                if (files.Length == 0)
                {
                    MessageBox.Show(
                        "Esta carpeta no contiene ningún archivo JSON.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var f in files)
                    {
                        FileInfo info = new FileInfo(f);
                        long size = info.Length;
                        string sizeText;

                        if (size < 1024)
                        {
                            sizeText = size + " B";
                        }
                        else
                        {
                            double kb = size / 1024.0;
                            sizeText = kb.ToString("0.0") + " KB";
                        }

                        var item = new ListViewItem(info.Name);
                        item.SubItems.Add(sizeText);
                        item.SubItems.Add(info.LastWriteTime.ToString("dd/MM/yyyy"));
                        item.Tag = f;

                        listViewFiles.Items.Add(item);
                    }
                }
            }
        }


        private List<Partida> CargarJson(string ruta)
        {
            List<Partida> resultado = null;

            try
            {
                string json = File.ReadAllText(ruta);
                var lista = JsonConvert.DeserializeObject<List<Partida>>(json);

                bool esListaValida = lista != null && lista.Count > 0;

                if (esListaValida)
                {
                    bool camposInvalidos = lista.Any(p => p.nombre == null || p.fecha_hora == null);

                    if (!camposInvalidos)
                    {
                        resultado = lista;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Faltan campos obligatorios en el archivo JSON.",
                            "Error de formato",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "La lista de partidas está vacía.",
                        "Error de formato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Este archivo JSON no tiene el formato esperado de 'Partida'.",
                    "Error de formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return resultado;
        }


        private void ConfigurarGridUsuarios()
        {
            var lst = dataGridViewJson;

            lst.BorderStyle = BorderStyle.None;
            lst.BackgroundColor = Color.White;
            lst.GridColor = Color.FromArgb(230, 230, 230);
            lst.RowTemplate.Height = 28;
            lst.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            lst.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            lst.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lst.EnableHeadersVisualStyles = false;
            lst.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            lst.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            lst.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            lst.DefaultCellStyle.SelectionForeColor = Color.White;
            lst.RowHeadersVisible = false;
            lst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lst.CellFormatting += dataGridViewJson_CellFormatting;
        }

        private void dataGridViewJson_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewJson.Columns[e.ColumnIndex].Name == "juego" && e.Value != null)
            {
                int juego;
                bool parsed = int.TryParse(e.Value.ToString(), out juego);

                if (parsed)
                {
                    if (juego == 1)
                    {
                        e.Value = "Juego Count";
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        if (juego == 2)
                        {
                            e.Value = "Juego Catch";
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
            else
            {
                if (dataGridViewJson.Columns[e.ColumnIndex].Name == "dificultad" && e.Value != null)
                {
                    int dif;
                    bool parsed = int.TryParse(e.Value.ToString(), out dif);

                    if (parsed)
                    {
                        if (dif == 1)
                        {
                            e.Value = "Fácil";
                        }
                        else
                        {
                            if (dif == 2)
                            {
                                e.Value = "Intermedio";
                            }
                            else
                            {
                                if (dif == 3)
                                {
                                    e.Value = "Difícil";
                                }
                            }
                        }

                        e.FormattingApplied = true;
                    }
                }
                else
                {
                    if (dataGridViewJson.Columns[e.ColumnIndex].Name == "terminada" && e.Value != null)
                    {
                        int terminado;
                        bool parsed = int.TryParse(e.Value.ToString(), out terminado);

                        if (parsed)
                        {
                            if (terminado == 1)
                            {
                                e.Value = "Terminado";
                            }
                            else
                            {
                                e.Value = "No terminado";
                            }

                            e.FormattingApplied = true;
                        }
                    }

                }
            }
        }


        private void buttonExportar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentJsonPath))
            {
                var lista = dataGridViewJson.DataSource as List<Partida>;

                if (lista != null)
                {
                    string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
                    File.WriteAllText(currentJsonPath, json);

                    MessageBox.Show("JSON guardado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se puede leer los datos del grid.");
                }
            }
        }


        private void buttonDirecoty_MouseHover(object sender, EventArgs e)
        {
            buttonDirecoty.BackgroundImage = Properties.Resources.btnAbrirDirectorioHover;
        }

        private void buttonDirecoty_MouseLeave(object sender, EventArgs e)
        {
            buttonDirecoty.BackgroundImage = Properties.Resources.btnAbrirDirectorio;
        }

        private void buttonRenombrar_MouseHover(object sender, EventArgs e)
        {
            buttonRenombrar.BackgroundImage = Properties.Resources.btnRenombrarHover;
        }

        private void buttonRenombrar_MouseLeave(object sender, EventArgs e)
        {
            buttonRenombrar.BackgroundImage = Properties.Resources.btnRenombrar;
        }

        private void buttonJson_MouseHover(object sender, EventArgs e)
        {
            buttonJson.BackgroundImage = Properties.Resources.btnImportaHover;
        }

        private void buttonJson_MouseLeave(object sender, EventArgs e)
        {
            buttonJson.BackgroundImage = Properties.Resources.btnImporta;
        }

        private void buttonEliminar_MouseHover(object sender, EventArgs e)
        {
            buttonEliminar.BackgroundImage = Properties.Resources.btnEliminarHover;
        }

        private void buttonEliminar_MouseLeave(object sender, EventArgs e)
        {
            buttonEliminar.BackgroundImage = Properties.Resources.btnEliminar;
        }

        private void buttonFiltrar_MouseHover(object sender, EventArgs e)
        {
            buttonFiltrar.BackgroundImage = Properties.Resources.btnFiltrarHover;
        }

        private void buttonFiltrar_MouseLeave(object sender, EventArgs e)
        {
            buttonFiltrar.BackgroundImage = Properties.Resources.btnFiltrar;
        }

        private void buttonExportar_MouseHover(object sender, EventArgs e)
        {
            buttonExportar.BackgroundImage = Properties.Resources.btnGuardarHover;
        }

        private void buttonExportar_MouseLeave(object sender, EventArgs e)
        {
            buttonExportar.BackgroundImage = Properties.Resources.btnGuardar;
        }
    }

}
