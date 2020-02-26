using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        clsMantenimiento mantenimiento = new clsMantenimiento();
        int indice;

        private void abrirForm()
        {
            frmDetalleConsulta consulta = new frmDetalleConsulta();

            int id = Convert.ToInt32(dtgPerfiles.Rows[indice].Cells[0].Value);
            string nombre = dtgPerfiles.Rows[indice].Cells[1].Value.ToString();
            string nacimiento = dtgPerfiles.Rows[indice].Cells[2].Value.ToString();
            string contraseña = mantenimiento.desencriptarDatos(dtgPerfiles.Rows[indice].Cells[3].Value.ToString());
            byte[] foto = (byte[])(dtgPerfiles.Rows[indice].Cells[4].Value);
            string correo = dtgPerfiles.Rows[indice].Cells[5].Value.ToString();
            int telefono = Convert.ToInt32(dtgPerfiles.Rows[indice].Cells[6].Value);

            Image img = byteArrayToImg(foto);

            consulta.cargarControles(id, nombre, nacimiento, contraseña, img, correo, telefono);
            consulta.ShowDialog();
        }

        private void mostrarPerfiles()
        {
            dtgPerfiles.DataSource = mantenimiento.listarPerfiles();
            dtgPerfiles.Columns[0].HeaderText = "IDENTIFICACIÓN";
            dtgPerfiles.Columns[1].HeaderText = "NOMBRE COMPLETO";
            dtgPerfiles.Columns[2].HeaderText = "FECHA DE NACIMIENTO";
            dtgPerfiles.Columns[3].HeaderText = "CONTRASEÑA";
            dtgPerfiles.Columns[4].Visible = false;
            dtgPerfiles.Columns[5].HeaderText = "CORREO ELECTRÓNICO";
            dtgPerfiles.Columns[6].HeaderText = "TELÉFONO";
            dtgPerfiles.ClearSelection();
        }

        private Image byteArrayToImg(byte[] byteImg)
        {
            MemoryStream ms = new MemoryStream(byteImg);
            return Image.FromStream(ms);
        }

        #region "Métodos para convertir un objeto en Byte Array y visceverza"
        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
            { 
                return null;
            }

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
        
        private Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);

            return obj;
        }
        #endregion

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            mostrarPerfiles();
        }

        private void dtgPerfiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                indice = dtgPerfiles.CurrentRow.Index;
                if (dtgPerfiles.SelectedRows.Count != 0) //Para evitar que seleccione las cabeceras de columnas.
                {
                    abrirForm();
                    indice = -1;
                    dtgPerfiles.ClearSelection();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Asegúrese de seleccionar uno de los registro que se muestran" + "\n***" + ex.Message + "***", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPerfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = -1;
            dtgPerfiles.ClearSelection();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}
