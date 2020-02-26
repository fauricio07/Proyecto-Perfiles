using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultas consultas = new frmConsultas();
            consultas.Show();
            this.Hide();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimiento mantenimiento = new frmMantenimiento();
            mantenimiento.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

    }
}
