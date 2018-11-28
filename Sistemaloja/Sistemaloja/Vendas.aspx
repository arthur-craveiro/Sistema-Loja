<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Vendas.aspx.cs" Inherits="Sistemaloja.Vendas" %>
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
    <h1 class="titulo">Vendas</h1><br />
    <table>
        <tr>
            <td><asp:Button ID="Button2" runat="server" Text="Fechar" OnClick="Button2_Click" /></td>
            <td><asp:Button ID="Button3" runat="server" Text="Incluir" OnClick="Button3_Click" /></td>
        </tr>
    </table>
    <br />
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Filtrar por:"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Cliente:"></asp:Label></td><td><asp:DropDownList ID="DropDownList1" runat="server" ForeColor="Black" Font-Bold="True" DataSourceID="SqlDataSource3" DataTextField="nome" DataValueField="idCliente"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:aspnetdbConnectionString %>" SelectCommand="SELECT [idCliente], [nome] FROM [Cliente]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Período:"></asp:Label></td><td><asp:DropDownList ID="DropDownList2" runat="server" ForeColor="Black" Font-Bold="True" DataSourceID="SqlDataSource2" DataTextField="datas" DataValueField="datas"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:aspnetdbConnectionString %>" SelectCommand="SELECT [datas] FROM [Venda]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Produto:"></asp:Label></td><td><asp:DropDownList ID="DropDownList3" runat="server" ForeColor="Black" Font-Bold="True" DataSourceID="SqlDataSource1" DataTextField="descricao" DataValueField="idProduto"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:aspnetdbConnectionString %>" SelectCommand="SELECT [idProduto], [descricao] FROM [Produtos]"></asp:SqlDataSource>
            </td><td><asp:Button ID="Button1" runat="server" Text="Pesquisar" cssClass="Botao5 botao5"/></td>
        </tr>
    </table>
    <asp:Table ID="Table1" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
      <asp:TableRow>
          <asp:TableCell>Data</asp:TableCell>
          <asp:TableCell>Cliente</asp:TableCell>
          <asp:TableCell>Desconto</asp:TableCell>
          <asp:TableCell>Valor Total</asp:TableCell>
          <asp:TableCell>Itens da Compra</asp:TableCell>
          <asp:TableCell>Alterar</asp:TableCell>
          <asp:TableCell>Excluir</asp:TableCell>
      </asp:TableRow>
    </asp:Table> 
    <asp:Table ID="Table3" runat="server">
    </asp:Table>
    <br />

</asp:Content>
