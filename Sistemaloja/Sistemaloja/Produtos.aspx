<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="Sistemaloja.Produtos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1> Produtos</h1></center><br />
    <div style="margin-left:1em;">
    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="Botao2 botao2" NavigateUrl="~/InserirProdutos.aspx">Inserir Produto</asp:HyperLink>
    <br />
    <asp:Table ID="Table1" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
        <asp:TableRow>
          <asp:TableCell Visible="False">idProdutos</asp:TableCell>
          <asp:TableCell>Código</asp:TableCell>
          <asp:TableCell>Descrição</asp:TableCell>
      </asp:TableRow>
    </asp:Table>
        </div>
</asp:Content>
