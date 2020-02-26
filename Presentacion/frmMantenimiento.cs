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
using Logica;

namespace Presentacion
{
    public partial class frmMantenimiento : Form
    {
        clsMantenimiento mantenimiento = new clsMantenimiento();

        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void nuevoPerfil(int id, string nombreC, string nacimiento, string contraseña, Image img, string correo, int telefono)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: IDENTIFICACIÓN", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtNombreC.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: NOMBRE COMPLETO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: CONTRASEÑA", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtCorreo.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: CORREO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtTelefono.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: TELÉFONO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (pbxImagen.Image == pbxImagen.InitialImage || pbxImagen.Image == null)
                {
                    MessageBox.Show("Debes seleccionar una foto", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    byte[] foto = imgToByteArray(img);
                    mantenimiento.agregarUsuario(id, nombreC, nacimiento, contraseña, foto, correo, telefono);

                    MessageBox.Show("Se ha agregado un nuevo perfil", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Upss!!! Se ha presentado el siguiente error ***" + ex.Message + "***", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarPerfil(int id, string nombreC, string nacimiento, string contraseña, Image img, string correo, int telefono)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: IDENTIFICACIÓN", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtNombreC.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: NOMBRE COMPLETO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: CONTRASEÑA", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtCorreo.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: CORREO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtTelefono.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: TELÉFONO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (pbxImagen.Image == pbxImagen.InitialImage || pbxImagen.Image == null)
                {
                    MessageBox.Show("Debes seleccionar una foto", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    byte[] foto = imgToByteArray(img);
                    mantenimiento.modificarUsuario(id, nombreC, nacimiento, contraseña, foto, correo, telefono);

                    MessageBox.Show("Se ha modificado el perfil", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upss!!! Se ha presentado el siguiente error ***" + ex.Message + "***", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarPerfil(int id)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: IDENTIFICACIÓN", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtNombreC.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: NOMBRE COMPLETO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: CONTRASEÑA", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtCorreo.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: CORREO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtTelefono.Text == "")
                {
                    MessageBox.Show("Debes completar el campo: TELÉFONO", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (pbxImagen.Image == pbxImagen.InitialImage || pbxImagen.Image == null)
                {
                    MessageBox.Show("Debes seleccionar una foto", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    mantenimiento.eliminarUsuario(id);

                    MessageBox.Show("Se ha eliminado el perfil", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upss!!! Se ha presentado el siguiente error ***" + ex.Message + "***", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarControles()
        {
            txtID.Clear();
            txtNombreC.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            dtpFechaN.ResetText();
            pbxImagen.Image = pbxImagen.InitialImage;
        }

        #region "Método para abrir el directorio y seleccionar una imagen para cargarla en el PictureBox"
        private void cargarImg()
        {
            OpenFileDialog obtImg = new OpenFileDialog();
            obtImg.InitialDirectory = "C:\\";
            obtImg.Filter = "Archivo de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (obtImg.ShowDialog() == DialogResult.OK)
            {
                pbxImagen.ImageLocation = obtImg.FileName;
            }
            else
            {
                MessageBox.Show("No se seleccionó una imagen", "SIN SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion|

        #region "Metodos para convertir una imagen en arreglo de bytes y viceverza"
        //private Image byteArrayToImg(byte[] byteImg)
        //{
        //    MemoryStream ms = new MemoryStream(byteImg);
        //    return Image.FromStream(ms);
        //}

        private byte[] imgToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        #endregion

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            pbxImagen.Image = pbxImagen.InitialImage;
            dtpFechaN.MinDate = DateTime.Now.AddYears(-100);
            dtpFechaN.MaxDate = DateTime.Now;
            gbxControles.Enabled = false;
            btnGuardar.Enabled = false;
            btnCambiar.Enabled = false;
            cbxProceso.Focus();
        }

        private void cbxProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxProceso.SelectedIndex != -1)
            {
                cbxProceso.Enabled = false;
                btnCambiar.Enabled = true;

                if (cbxProceso.SelectedIndex == 0)
                {
                    gbxControles.Enabled = true;
                    btnGuardar.Enabled = true;
                    txtID.Focus();
                }
            }
            else
            {
                gbxControles.Enabled = false;
                btnGuardar.Enabled = false;
                cbxProceso.Enabled = true;
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            gbxControles.Enabled = false;
            btnGuardar.Enabled = false;
            btnCambiar.Enabled = false;
            cbxProceso.SelectedIndex = -1;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            cargarImg();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (cbxProceso.SelectedIndex)
            {
                case 0:
                    nuevoPerfil(Convert.ToInt32(txtID.Text), txtNombreC.Text, dtpFechaN.Text, txtContraseña.Text, pbxImagen.Image, txtCorreo.Text, Convert.ToInt32(txtTelefono.Text));
                    break;
                case 1:
                    //actualizarPerfil(Convert.ToInt32(txtID.Text), txtNombreC.Text, dtpFechaN.Text, txtContraseña.Text, pbxImagen.Image, txtCorreo.Text, Convert.ToInt32(txtTelefono.Text));
                    break;
                case 2:
                    //borrarPerfil(Convert.ToInt32(txtID.Text));
                    break;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}
