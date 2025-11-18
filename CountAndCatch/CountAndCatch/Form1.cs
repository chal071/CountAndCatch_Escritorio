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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            /*dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "");*/
            dgvResult.Rows.Clear();

            

        }
       

        private void cargarJson(string filePath)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buildTreeView();
        }

        private void tvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void buildTreeView() 
        {
            tvDirectory.Nodes.Clear();

            TreeNode root = new TreeNode("Directorio de datos") { Tag = "root"};
            tvDirectory.Nodes.Add(root);


            TreeNode functionNode = new TreeNode("Zona de funciones");
            root.Nodes.Add(functionNode);

            functionNode.Nodes.Add(new TreeNode("Importar archivos JSON"));

            // Filtro
            TreeNode filterNode = new TreeNode("Filtro");
            filterNode.Nodes.Add(new TreeNode("Mostrar solo archivos JSON"));  
            filterNode.Nodes.Add(new TreeNode("Mostrar solo carpetas"));      
            filterNode.Nodes.Add(new TreeNode("Mostrar todo el contenido"));  
            functionNode.Nodes.Add(filterNode);

            // Ordenar
            TreeNode sortNode = new TreeNode("Ordenar");
            sortNode.Nodes.Add(new TreeNode("Ordenar por nombre")); 
            sortNode.Nodes.Add(new TreeNode("Ordenar por fecha")); 
            sortNode.Nodes.Add(new TreeNode("Ordenar por tipo"));    
            functionNode.Nodes.Add(sortNode);

            // Gestión de carpetas 
            TreeNode folderNode = new TreeNode("Gestión de carpetas");
            folderNode.Nodes.Add(new TreeNode("Crear carpeta"));      
            folderNode.Nodes.Add(new TreeNode("Renombrar carpeta"));  
            folderNode.Nodes.Add(new TreeNode("Eliminar carpeta")); 
            root.Nodes.Add(folderNode);


            tvDirectory.ExpandAll();




        }

      

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            DgRenombrar dialog = new DgRenombrar();
            dialog.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DgEliminarArchivo dialog = new DgEliminarArchivo();
            dialog.ShowDialog();
        }
    }

}
