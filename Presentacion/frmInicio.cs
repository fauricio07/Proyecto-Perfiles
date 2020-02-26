using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        clsInicio inicio = new clsInicio();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentificacion.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: IDENTIFICACIÓN", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(txtContraseña.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: CONTRASEÑA", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if(inicio.inicioSesion(Convert.ToInt32(txtIdentificacion.Text), txtContraseña.Text) == true)
                    {
                        frmMenu menu = new frmMenu();
                        menu.lbIdentificacion.Text = "~" + txtIdentificacion.Text + "~";
                        menu.lbNombre.Text = inicio.buscarNombre(Convert.ToInt32(txtIdentificacion.Text));
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Los credenciales ingresados no corresponden a alguna cuenta existente", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error ***" + ex.Message + "***", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckbxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxMostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

    }
}
