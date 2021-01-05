<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">

    <p>
        <br />
    </p>
    <p>
    </p>
    <center>
    <table style="width:%100">
        <tr>
            <td class="text-center">
                Registro
                <p></p>
            </td>
        </tr>
        <tr>
            <td align="right">
                Cedula: <asp:TextBox ID="txt_cedula" class="form-control" runat="server"></asp:TextBox>
            </td >
        </tr>
        <tr>
            <td align="right">
                Nombre: <asp:TextBox ID="txt_nombre" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Apellido: <asp:TextBox ID="txt_apellido" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Direccion: <asp:TextBox ID="txt_direccion" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Telefono:<asp:TextBox ID="txt_telefono" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Contraseña:<asp:TextBox ID="txt_clave" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Usuario:<asp:TextBox ID="txt_usu" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Correo:<asp:TextBox ID="txt_correo" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

                <asp:DropDownList ID="DropDownList1"  runat="server" Height="16px" Width="127px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>

                <center><asp:Button ID="btn_registrase" runat="server"  Width="120px" CssClass="btn btn-success" style="margin-left: 0" Text="Registrarce" OnClick="btn_registrase_Click" /></center>

            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="lbl_mesaje" runat="server" Text=""></asp:Label>

            </td>
        </tr>
    </table>

    </center>

</asp:Content>
