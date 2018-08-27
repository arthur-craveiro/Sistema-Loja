<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Sistemaloja.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/InserirCliente.aspx">Inserir Cliente</asp:HyperLink>
    <br />
    <asp:Table ID="Table1" runat="server">
      <asp:TableRow>
          <asp:TableCell>idCliente</asp:TableCell>
          <asp:TableCell>Nome</asp:TableCell>
          <asp:TableCell>Telefones</asp:TableCell>
          <asp:TableCell>Cidade</asp:TableCell>
          <asp:TableCell>Endereço</asp:TableCell>
          <asp:TableCell>CPF</asp:TableCell>
          <asp:TableCell>CNPJ</asp:TableCell>
          <asp:TableCell>Sigla</asp:TableCell>
      </asp:TableRow>
    </asp:Table>
</asp:Content>
