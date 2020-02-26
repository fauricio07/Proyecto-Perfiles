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
    public partial class frmDetalleConsulta : Form
    {
        public frmDetalleConsulta()
        {
            InitializeComponent();
        }

        public void cargarControles(int id, string nombre, string nacimiento, string contraseña, Image img, string correo, int telefono)
        {
            txtID.Text = id.ToString();
            txtNombreC.Text = nombre;
            txtContraseña.Text = contraseña;
            txtCorreo.Text = correo;
            txtTelefono.Text = telefono.ToString();
            pbxImagen.Image = img;
            dtpFechaN.Text = nacimiento;
            gbxControles.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
