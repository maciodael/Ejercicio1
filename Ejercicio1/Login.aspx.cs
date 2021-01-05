using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using CapaLogica;
using CapaDatos;

namespace Ejercicio1
{
    public partial class Login : System.Web.UI.Page
    {

        int contador = 1;
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["con"] = Session["Conantiguo"];

        }



        protected void btn_recuperar_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Label2.Text = "A recuperado sus credenciales recargue la pagina para continuar";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton1.Visible = false;
            btn_ingresra.Visible = false;
            btn_recuperar.Visible = true;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ingresar();

        }
        private void ingresar()
        {
            Label2.Visible = false;
            if (string.IsNullOrEmpty(txt_usu.Text))
            {
                Label2.Visible = true;
                Label2.Text = "Ingresar su nombre";

            }
            else
            {
                if (string.IsNullOrEmpty(txt_clave.Text))
                {
                    Label2.Visible = true;
                    Label2.Text = "Ingresar Contraseña";

                }
                else
                {
                    //metodo para verificar
                    bool existenom = Logica_Usuario.autentificar_nom(txt_usu.Text);
                    bool existe = Logica_Usuario.autentificar(txt_usu.Text, txt_clave.Text);
                    {
                        if (existenom)
                        {
                            if (existe)
                            {
                                tbl_usuario usuario = new tbl_usuario();
                                usuario = Logica_Usuario.autentificar_x_Login(txt_usu.Text, txt_clave.Text);
                                int tusuario = usuario.tusu_id;
                                if (tusuario == 1)
                                {
                                    Session["admin"] = txt_usu.Text;
                                    Response.Redirect("~/Admin.aspx");
                                }
                                if (tusuario == 2)
                                {
                                    Session["usu"] = txt_usu.Text;
                                    Response.Redirect("~/Usuario.aspx");
                                }


                            }
                            else
                            {
                                Label2.Visible = true;
                                Label2.Text = "Contraseña Incorrecta";
                                Label1.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                                Session["Conantiguo"] = Label1.Text.ToString();
                                if (Convert.ToInt32(Label1.Text) == 3)
                                {
                                    btn_ingresra.Visible = false;
                                    btn_recuperar.Visible = true;
                                    Label2.Text = "A SUPERADO EL NUMERO DE INTENTOS";
                                    Session.Clear();
                                }

                            }

                        }
                        else
                        {
                            Label2.Visible = true;
                            Label2.Text = "Usuario no existe";
                        }
                    }
                }

            }
        }

        // metodo recuperar EMAIl
        //public static tbl_usuario obtenerUsuario() {

        //    var conta =Logica_Usuario.save
        //    return conta;
        //}
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}