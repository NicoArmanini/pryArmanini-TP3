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
     
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            toolHora.Text = DateTime.Now.ToLongTimeString();
            toolFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void registroEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVistaEmpleados frm = new frmVistaEmpleados();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
