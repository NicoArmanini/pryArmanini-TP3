using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryArmanini_TP3
{
    internal class clsConexion
    {
        public string Nombre { get; set; }
        public static string Usuario { get; set; }

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
    }
}
