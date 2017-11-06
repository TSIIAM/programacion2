<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.Master" CodeBehind="AltaCategoria.aspx.cs" Inherits="Semana9Web.AltaCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <div>
        <asp:Label ID="LblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="TxtDescripcion" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
        <br />
        <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
        <br />
    </div>
   </asp:Content>
