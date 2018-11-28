<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="AlterarCompra.aspx.cs" Inherits="Sistemaloja.AlterarCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        table {
            margin-left:20px;

        }
        h1 {
            margin-left:20px;
        }
    </style>
    <h1 class="titulo">Alterar Compra</h1><br />

    <h2 class="titulo">&nbsp;&nbsp;Itens da Compra&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Incluir" Height="30px" Width="98px" />&nbsp;&nbsp;
  <asp:Button ID="Button4" runat="server" Text="Excluir" Height="30px" OnClick="Button4_Click" Width="98px" />
    </h2>
    <asp:Table ID="Table3" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
      <asp:TableRow>
          <asp:TableCell>Produto</asp:TableCell>
          <asp:TableCell>Unidade</asp:TableCell>
          <asp:TableCell>Quantidade</asp:TableCell>
          <asp:TableCell>Preço Unitário</asp:TableCell>
          <asp:TableCell>Valor Total</asp:TableCell>
      </asp:TableRow>
    </asp:Table> 
    <asp:Table ID="Table1" runat="server"></asp:Table>
    <br />
<asp:Label ID="Label5" runat="server"></asp:Label>
    <br/>
    
    <table>
        <caption>Atualização da compra</caption>
    <tr><td><asp:Label ID="Label1" runat="server" Text="Data:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td>
        <td><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
    </tr>
    <tr><td> <asp:Label ID="Label2" runat="server" Text="Fornecedor:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nome" DataValueField="idFornecedores">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:aspnetdbConnectionString %>" SelectCommand="SELECT [idFornecedores], [nome] FROM [Fornecedor]"></asp:SqlDataSource>
        <br /></td></tr>
     <tr><td><asp:Label ID="Label3" runat="server" Text="Desconto:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Label ID="Label4" runat="server" Text="Valor Total:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td>
         <asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
         <br /></td></tr>
     <tr><td><asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="Botao5 botao5"  OnClick="Button1_Click" /></td>
     <td><asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="Botao4 botao4" OnClick="Button2_Click" /> </td></tr>
        </table>
</asp:Content>
