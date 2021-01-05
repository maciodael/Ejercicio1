using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaLogica
{
    //instalar la capa datos para el dbml para usar las consultas a la base
    public class Logica_Usuario
    {
        //instacia la cap datos 
        private static ConexionBaseDataDataContext dc = new ConexionBaseDataDataContext();

        //metodos

        public static List<tbl_usuario> obtener_usuario() {
            var lista = dc.tbl_usuario.Where(usu => usu.usu_estado == 'A');
            return lista.ToList();
        }
        //metodo para verifivar credenciales
        public static bool autentificar(string nombre, string pass) {
            var auto = dc.tbl_usuario.Any(usu => usu.usu_estado == 'A' & usu.usu_nomlogin.Equals(nombre)
                & usu.usu_contraseña.Equals(pass));
            return auto;
        }
        //metodo para verificar usuario con su credencial
        public static tbl_usuario autentificar_x_Login(string nombre, string pass) {
            var nlogin = dc.tbl_usuario.Single(usu => usu.usu_estado == 'A' & usu.usu_nomlogin.Equals(nombre) & usu.usu_contraseña.Equals(pass));
            return nlogin;
        }
        //creo metodo para verificar nombre login
        public static bool autentificar_nom(string nombre) {
            var auton = dc.tbl_usuario.Any(usu => usu.usu_estado == 'A' &
            usu.usu_nomlogin.Equals(nombre));
            return auton;
        }
        //metodo  de guardado datos
        public static void save(tbl_usuario usuario) {
            try
            {

               
            // Inserto los datos convertidos
                usuario.usu_fechacreacion = DateTime.Now;
                usuario.usu_estado = 'A';
                dc.tbl_usuario.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex) {
                throw new ArgumentException("Los Datos no an sido guardados <br>"+ex);
            }
        }


    }
}
