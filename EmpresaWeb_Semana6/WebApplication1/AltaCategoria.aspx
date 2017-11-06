<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaCategoria.aspx.cs" Inherits="WebApplication1.AltaCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblDescripcion" runat="server" Text="Categoria"></asp:Label>
        <asp:TextBox ID="TxtDescripcion" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
     </div>
        <div>
            <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
            <asp:Label ID="lblIf" runat="server" Text=""></asp:Label>
        </div>
    </form>
    
</body>
</html>
