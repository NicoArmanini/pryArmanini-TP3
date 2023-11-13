using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_TP3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        frmLogin v = new frmLogin();

        int contador = 0;
     

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            contador += 1;
            if (contador > 1)
            {
                toolHora.Text = Convert.ToString(DateTime.Now);
            }
            toolUser.Text = clsConexion.Usuario;
        }
    }
}
