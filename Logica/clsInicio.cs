using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class clsInicio
    {
        private PruebaEntities modeloBD = new PruebaEntities();
        private clsMantenimiento config = new clsMantenimiento();

        public bool inicioSesion(int id, string contraseña)
        {

            contraseña = config.encriptarDatos(contraseña);
            var usuario = modeloBD.TBL_USUARIOS.FirstOrDefault(datos => datos.Identificacion == id && datos.Contraseña == contraseña);

            if (usuario != null)
            {
                return true;
            }

            return false;
        }

        public string buscarNombre(int id)
        {
            string nombre = (from datos in modeloBD.TBL_USUARIOS where datos.Identificacion == id select datos.Nombre_Completo).FirstOrDefault();
            return nombre;
        }

    }
}
