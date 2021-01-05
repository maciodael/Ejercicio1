<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ejercicio1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">

    </asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="nav-justified">
            <tr>
                <td class="text-center"  colspan="2">    
                   <h3> Sistema de Seguridad </h3>
                </td>
            </tr>
                <tr>
                <td elign="center"> 
                   <center><table style="width:%50">
                       <tr>
                           <td ></td>
                               <td class="page-title">
                                   <h2>Iniciar Secion</h2>
                               </td>
   
                        <tr>
                            <td><h4>Usuario:</h4></td>
                            <td class="auto-style1">
                                <br />
                                <asp:TextBox ID="txt_usu" Height="25" class="form-control"  Width="200px"  runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td><h4>Clave:</h4></td>
                            <td>
                                <br />
                                <asp:TextBox ID="txt_clave" Height="25" type="password" class="form-control"  Width="200px" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center><asp:LinkButton ID="LinkButton1" style="color:crimson" runat="server" OnClick="LinkButton1_Click"><h5>Recuperar Clave</h5></asp:LinkButton></center>
                                
                                <br >
                            </td>
                            <td>
                                <center><asp:Button ID="btn_recuperar" runat="server" Height="39px" Text="Recuperar" Width="101px" CssClass="btn btn-danger" Visible="false"  style="margin-left: 0" OnClick="btn_recuperar_Click" /></center>
                                <center><asp:Button ID="btn_ingresra" runat="server" Height="39px" Text="Ingresar" Width="120px" CssClass="btn btn-success" style="margin-left: 0" OnClick="Button1_Click" /></center>
                            </td>
                            <td>
                               <asp:Button ID="btn_registrar" runat="server" Height="39px" Text="Registrarte" Width="120px" CssClass="btn btn-warning" style="margin-left: 0" OnClick="Button2_Click" />
                           </td>
                          
                        </tr>
                       <tr>
                             <td>
                               <h5><asp:Label ID="Label3" runat="server" Text="Intentos:"></asp:Label> <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h5>
                            </td>
                            <td>
                                <h4><asp:Label ID="Label2" runat="server" Text=""></asp:Label></h4>
                            </td>
                           
                       </tr>

                    </table>
                        <br><br><br><br> <br> <br><br>
                    
                       
                       
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
