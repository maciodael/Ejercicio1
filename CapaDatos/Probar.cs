using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Probar
    {
        static void Main(string[] args)
        {
            using (ConexionBaseDataDataContext dc = new ConexionBaseDataDataContext())
            {
                tbl_usuario oUser = new tbl_usuario();
                oUser.usu_nomlogin = "Mauricio";
                oUser.usu_contraseña =Encrypt.GetSHA256("123456");
                dc.tbl_usuario.Equals(oUser);
                


            }
        }
    }
}
