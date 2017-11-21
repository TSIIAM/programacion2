<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.Master" CodeBehind="AltaCategoria.aspx.cs" Inherits="Semana9Web.AltaCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function ValidarDescripcion() {
            if (document.getElementById("<%=TxtDescripcion.ClientID%>").value == "") {
                alert("La descripción no puede estar vacía");
                return false;
            }
            else {
                return true;
            }
        }

    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <div>
        <asp:Label ID="LblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="TxtDescripcion" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClientClick="return ValidarDescripcion()" OnClick="BtnGuardar_Click" />
        <br />
        <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>

        <asp:ListBox ID="LstCategorias" runat="server"></asp:ListBox>
        <asp:GridView ID="GrillaCategorias" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
            </Columns>
        </asp:GridView>
        <br />
    </div>
   </asp:Content>
