<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaFuncionario.aspx.cs" Inherits="Semana9Web.AltaFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <asp:Label ID="LblNombre" runat="server" Text="Nombre" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator">Campo requerido</asp:RequiredFieldValidator>
        <br />
         <asp:Label ID="LblSueldo" runat="server" Text="Sueldo" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtSueldo" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" MaximumValue="25000" MinimumValue="10000"></asp:RangeValidator>
        <br />
          <asp:Label ID="LblFecNacimiento" runat="server" Text="Fecha de nacimiento" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtFecNacimiento" runat="server" TextMode="Date"></asp:TextBox>
        <br />
          <asp:Label ID="LblDocumento" runat="server" Text="Documento" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtDocumento" runat="server"></asp:TextBox>
        <br />
          <asp:Label ID="LblCarnetSalud" runat="server" Text="Carnet de salud" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtCarnetSalud" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LblCargo" runat="server" Text="Cargo" Width="150px"></asp:Label>
        <asp:DropDownList ID="DDLCargos" runat="server"></asp:DropDownList>
        <br />
    <asp:RadioButton ID="RnbContratado" runat="server" Text="Contratado" GroupName="TipoFuncionario" AutoPostBack="True" OnCheckedChanged="RnbContratado_CheckedChanged" />
        <asp:RadioButton ID="RbnPresupuestado" runat="server" Text="Presupuestado" GroupName="TipoFuncionario" AutoPostBack="True" OnCheckedChanged="RbnPresupuestado_CheckedChanged" />   
    <br />   
    <asp:Panel ID="PnlContratado" runat="server">
    <asp:Label ID="LblFechaContrato" runat="server" Text="Fecha de contrato" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtFecContrato" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <asp:Label ID="LblAnioContrato" runat="server" Text="Duración" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtDuracion" runat="server"></asp:TextBox>
        <br />
        </asp:Panel>
     <asp:Panel ID="PnlPresupuestado" runat="server">
         <asp:Label ID="LblAnioIngreso" runat="server" Text="Anio de ingreso" Width="150px"></asp:Label>
        <asp:TextBox ID="TxtAnioIngreso" runat="server"></asp:TextBox>
        <br />
     </asp:Panel>
        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <br />
    <br />
        <br />
        <br />
        <asp:Label ID="LblMensaje" runat="server"></asp:Label>
</asp:Content>
