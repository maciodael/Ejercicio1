<%@ Page Title="" Language="C#" MasterPageFile="~/Sitio1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Ejercicio1.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_head2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje2" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido2" runat="server">
    
    <table style="width:100%">
        <tr>
            <td>
              <h3>  <asp:LinkButton ID="lnk_serrar" runat="server" OnClick="lnk_serrar_Click">Cerrar</asp:LinkButton></h3>
            </td>
        </tr> 
        <tr>
            <td align="center"><h4> Bienvenido
                <asp:Label ID="lbl_sesion" runat="server" Text=""></asp:Label></h4>
                no olvides serrar antes de irte.
            </td>
        </tr>
    </table>
</asp:Content>
