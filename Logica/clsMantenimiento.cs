using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class clsMantenimiento
    {
        PruebaEntities modeloBD = new PruebaEntities();

        public void agregarUsuario(int id, string nombreC, string nacimiento, string contraseña, byte[] foto, string correo, int telefono)
        {

            contraseña = encriptarDatos(contraseña);

            TBL_USUARIOS usuario = new TBL_USUARIOS();
            usuario.Identificacion = id;
            usuario.Nombre_Completo = nombreC;
            usuario.Fecha_Nacimiento = nacimiento;
            usuario.Contraseña = contraseña;
            usuario.Foto = foto;
            usuario.Correo = correo;
            usuario.Telefono = telefono;

            modeloBD.TBL_USUARIOS.Add(usuario);
            modeloBD.SaveChanges();
        }

        public void modificarUsuario(int id, string nombreC, string nacimiento, string contraseña, byte[] foto, string correo, int telefono)
        {

            contraseña = encriptarDatos(contraseña);

            var usuario = modeloBD.TBL_USUARIOS.FirstOrDefault(datos => datos.Identificacion == id);

            usuario.Identificacion = id;
            usuario.Nombre_Completo = nombreC;
            usuario.Fecha_Nacimiento = nacimiento;
            usuario.Contraseña = contraseña;
            usuario.Foto = foto;
            usuario.Correo = correo;
            usuario.Telefono = telefono;
            
            modeloBD.SaveChanges();
        }

        public void eliminarUsuario(int id)
        {

            var usuario = modeloBD.TBL_USUARIOS.FirstOrDefault(datos => datos.Identificacion == id);

            modeloBD.TBL_USUARIOS.Remove(usuario);
            modeloBD.SaveChanges();
        }

        public string encriptarDatos(string cadena)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadena);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public string desencriptarDatos(string cadena)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadena);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public object listarPerfiles()
        {

            var perfiles = from datos in modeloBD.TBL_USUARIOS select datos;
            return perfiles.ToList();
        }
        
    }
}
