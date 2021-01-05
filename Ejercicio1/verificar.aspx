<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="verificar.aspx.cs" Inherits="Ejercicio1.verificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <table class="nav-justified">
                <tr>
                    <td class="text-center">
                Verificar
                <p></p>
                     </td>
                </tr>
                <tr>
                    <td align="right">
                         Correo:<asp:TextBox ID="txt_correo" class="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td>
                         <center><asp:Button ID="btn_Verificar" runat="server"  Width="120px" CssClass="btn btn-success" style="margin-left: 0" Text="Verificar" OnClick="btn_registrase_Click" /></center>
                    </td>
              </tr>
                 <tr>
                    <td>
                        <asp:Label ID="lbl_mesaje" runat="server" Text="hola"></asp:Label>
                     </td>
                </tr>

            </table>

        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
