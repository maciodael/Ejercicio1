using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio1
{
    public partial class Sitio1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"] != null)
            {
                Panel2.Visible = true;
                Panel3.Visible = true;
            }
            else if (Session["usu"] != null)
            {
                    Panel1.Visible = true;
                    Panel4.Visible = true;
            }
            

        }
    }
}