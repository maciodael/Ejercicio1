using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio1
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usu"] != null)
            {
                lbl_sesion.Text = Session["usu"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }

        }
        protected void lnk_serrar_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }
}