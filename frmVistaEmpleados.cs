using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace pryArmanini_TP3
{
    public partial class frmVistaEmpleados : Form
    {
       
        public frmVistaEmpleados()
        {
            InitializeComponent();
        }

        private void tvCarpeta_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string detalles = e.Node.Tag.ToString();
            rtbArchivos.Text = detalles;
        }

        private void frmVistaEmpleados_Load(object sender, EventArgs e)
        {

            clsConexion conexion = new clsConexion();
            conexion.CargarDatos(tvCarpeta);

            //string rutaCompleta = @"../../base/EMPLEO.accdb";

            //// Agregar la carpeta principal al árbol
            //TreeNode rootNode = new TreeNode("Carpetas y Archivos del Proyecto");
            //tvCarpeta.Nodes.Add(rootNode);

            //// Llamamos a un método recursivo para agregar carpetas y archivos
            ////AgregarDatos(rootNode, rutaCompleta);
        }
    }

    //private void AgregarDatos(TreeNode parentNode, string ruta)
    //{
    //    try
    //    {
    //        // Obtiene las carpetas y los archivos en la ruta
    //        string[] carpetas = Directory.GetDirectories(ruta);
    //        string[] archivos = Directory.GetFiles(ruta);

    //        // Agrega las carpetas al nodo
    //        foreach (string nombrecarpeta in carpetas)
    //        {
    //            TreeNode carpetaNode = new TreeNode(Path.GetFileName(nombrecarpeta));
    //            parentNode.Nodes.Add(carpetaNode);

    //            // Agrega carpetas y archivos dentro de esta carpeta
    //            AgregarDatos(carpetaNode, nombrecarpeta);
    //        }

    //        // Agregar archivos al nodo actual
    //        foreach (string nombreArchivo in archivos)
    //        {
    //            TreeNode archivoNode = new TreeNode(Path.GetFileName(nombreArchivo));
    //            archivoNode.Tag = nombreArchivo; // Almacena la ruta completa del archivo como un valor asociado
    //            parentNode.Nodes.Add(archivoNode);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show("Error: " + ex.Message);
    //    }
    //}
}
