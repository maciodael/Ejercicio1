using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaLogica
{
    class Logica_TipoUsuario
    {

        private static ConexionBaseDataDataContext dc = new ConexionBaseDataDataContext();

        public static List<tbl_tipoUsuario> optenerTusuario()
        {
            var lista = dc.tbl_tipoUsuario.Where(tusu => tusu.tusu_estado == 'A');
            return lista.ToList();
        }


    }
}