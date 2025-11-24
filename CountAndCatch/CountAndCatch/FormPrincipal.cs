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
        private string currentDirectory = "";

        public FormPrincipal()
        {
            InitializeComponent();
            ConfigurarListView();
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
            if (listViewFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Elegir un archivo Json");
                return;
            }

            var item = listViewFiles.SelectedItems[0];
            string ruta = item.Tag.ToString();

            var lista = CargarJson(ruta);

            dataGridViewJson.DataSource = lista;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count == 0) return;

            var item = listViewFiles.SelectedItems[0];
            var fullPath = item.Tag.ToString();

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
                LoadFiles();
            }
        }

        private void buttonRenombrar_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count == 0) return;

            var item = listViewFiles.SelectedItems[0];
            var oldPath = item.Tag.ToString();
            var oldName = Path.GetFileName(oldPath);

            using (var dlg = new FormRenombrar(oldName))
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                string newName = dlg.NuevoNombre;
                if (string.IsNullOrWhiteSpace(newName) || newName == oldName)
                    return;

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

        private void LoadFiles()
        {
            listViewFiles.Items.Clear();

            if (!Directory.Exists(currentDirectory)) return;

            var files = Directory.GetFiles(currentDirectory);

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
        private List<Partida> CargarJson(string ruta)
        {
            if (!File.Exists(ruta))
                return new List<Partida>();

            string json = File.ReadAllText(ruta);

            return JsonConvert.DeserializeObject<List<Partida>>(json);
        }
    }

}
