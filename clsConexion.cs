using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryArmanini_TP3
{
    internal class clsConexion
    {

        OleDbConnection conexionBD;

        string rutaArachivo;
        string cadenaConexion;
        public string estadoConexion;

        public clsConexion()
        {
            rutaArachivo = @"../../base/EMPLEO.accdb";
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArachivo;
            estadoConexion = "CERRADO";
        }

        public void conectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "ABIERTO";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public void CargarDatos(TreeView tvCarpeta)
        {
            tvCarpeta.Nodes.Clear();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                // Consulta para DATOS_PERSONALES
                string consulta = "SELECT * FROM DATOS_PERSONALES";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string codigoEmpleado = reader["CODIGO"].ToString();
                    string nombre = reader["NOMBRE"].ToString();
                    string apellido = reader["APELLIDO"].ToString();
                    string telefono = reader["TELEFONO"].ToString();

                    TreeNode nodoEmpleado = new TreeNode($"{codigoEmpleado} - {nombre}");
                    nodoEmpleado.Tag = $"{codigoEmpleado} - {nombre}\nApellido: {apellido}\nTelefono: {telefono}";

                    tvCarpeta.Nodes.Add(nodoEmpleado);
                }

                // Consulta para DATOS_LABORALES
                string consulta1 = "SELECT * FROM DATOS_LABORALES";
                OleDbCommand comando1 = new OleDbCommand(consulta1, conexion);
                OleDbDataReader reader1 = comando1.ExecuteReader();

                while (reader1.Read())
                {
                    // Asegúrate de utilizar el mismo campo (CODIGO) para vincular los datos de ambas tablas
                    string codigoEmpleado = reader1["CODIGO"].ToString();
                    string experiencia = reader1["AÑOS/EXPERIENCIA"].ToString();
                    string ultLugarTrabajo = reader1["ULTIMO LUGAR DE TRABAJO"].ToString();
                    string cargo = reader1["CARGO DESEMPENADO"].ToString();
                    string remuneracion = reader1["REMUNERACION"].ToString();


                    // Busca el nodo correspondiente al código de empleado
                    TreeNode nodoEmpleado = BuscarNodoPorCodigo(tvCarpeta, codigoEmpleado);

                    // Agrega información adicional al Tag del nodo
                    if (nodoEmpleado != null)
                    {
                        nodoEmpleado.Tag += $"\nExperiencia: {experiencia}\nUltimo Lugar de Trabajo: {ultLugarTrabajo}\nCargo: {cargo}" +
                            $"\nRemuneracion: {remuneracion}";
                    }
                }

                string consulta2 = "SELECT * FROM DATOS_ACADEMICOS";
                OleDbCommand comando2 = new OleDbCommand(consulta2, conexion);
                OleDbDataReader reader2 = comando2.ExecuteReader();

                while (reader2.Read())
                {
                    // Asegúrate de utilizar el mismo campo (CODIGO) para vincular los datos de ambas tablas
                    string codigoEmpleado = reader2["CODIGO"].ToString();
                    string cursos = reader2["CURSOS QUE RECIBIO"].ToString();
                    string horasEstudio = reader2["HORAS/ESTUDIO"].ToString();
                    string lugarEstudio = reader2["LUGAR DE ESTUDIO"].ToString();

                    // Busca el nodo correspondiente al código de empleado
                    TreeNode nodoEmpleado = BuscarNodoPorCodigo(tvCarpeta, codigoEmpleado);

                    // Agrega información adicional al Tag del nodo
                    if (nodoEmpleado != null)
                    {
                        nodoEmpleado.Tag += $"\nCursos que Recibio: {cursos}\nHoras/Estudio: {horasEstudio}\nLugar de Estudio: {lugarEstudio}";
                    }
                }
                conexion.Close();
            }
        }

        private TreeNode BuscarNodoPorCodigo(TreeView tvCarpeta, string codigoEmpleado)
        {
            foreach (TreeNode nodo in tvCarpeta.Nodes)
            {
                if (nodo.Text.StartsWith(codigoEmpleado))
                {
                    return nodo;
                }
            }
            return null;
        }
    }
}
