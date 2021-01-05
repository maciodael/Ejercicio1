using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaLogica;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public partial class verificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrase_Click(object sender, EventArgs e)
        {

            enviar();

            
        }
        public void enviar()
        {
            string from = "larsplach9@gmail.com";
            string to = "larsplach@hotmail.com";
            new Email().enviar(from, to);
        }
        
    }
}