using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using System.Data.Linq;
namespace Ejercicio1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        private void cargartu() {
            List<tbl_tipoUsuario> listatu = new List<tbl_tipoUsuario>();
            //listatu = CapaLogica.Logica_TipoUsuario;
        }

        protected void btn_registrase_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_mesaje.Text = "";
                //usuinfo = new tbl_usuario();

                
            }
            catch (Exception)
            {

                throw;
            }
            Response.Redirect("~/Login.aspx");
        }
    }
}