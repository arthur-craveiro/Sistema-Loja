<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Sistemaloja.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left:1em;">
    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="Botao2 botao2" NavigateUrl="~/InserirCliente.aspx">Inserir Cliente</asp:HyperLink>
    <br />
    <asp:Table ID="Table1" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
      <asp:TableRow>
          <asp:TableCell Visible="False">idCliente</asp:TableCell>
          <asp:TableCell>Nome</asp:TableCell>
          <asp:TableCell>Telefones</asp:TableCell>
          <asp:TableCell>Cidade</asp:TableCell>
          <asp:TableCell>Endereço</asp:TableCell>
          <asp:TableCell>CPF</asp:TableCell>
          <asp:TableCell>CNPJ</asp:TableCell>
          <asp:TableCell>Sigla</asp:TableCell>
      </asp:TableRow>
    </asp:Table>
        </div>
</asp:Content>
