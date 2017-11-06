<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaCategoria.aspx.cs" Inherits="Semana9Web.AltaCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="TxtDescripcion" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
        <br />
        <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
