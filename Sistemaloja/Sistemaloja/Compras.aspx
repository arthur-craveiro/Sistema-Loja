<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="Sistemaloja.Compras" %>
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
    <h1 class="titulo">Compras</h1><br />
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Filtrar por:"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Fornecedor:"></asp:Label></td><td><asp:DropDownList ID="DropDownList1" runat="server" ForeColor="Black" Font-Bold="true"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Período:"></asp:Label></td><td><asp:DropDownList ID="DropDownList2" runat="server" ForeColor="Black" Font-Bold="true"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Produto:"></asp:Label></td><td><asp:DropDownList ID="DropDownList3" runat="server" ForeColor="Black" Font-Bold="true"></asp:DropDownList></td><td><asp:Button ID="Button1" runat="server" Text="Pesquisar" cssClass="Botao5 botao5" OnClick="Button1_Click" /></td>
        </tr>
    </table>
    <asp:Table ID="Table1" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
      <asp:TableRow>
          <asp:TableCell>Data</asp:TableCell>
          <asp:TableCell>Fornecedor</asp:TableCell>
          <asp:TableCell>Desconto</asp:TableCell>
          <asp:TableCell>Valor Total</asp:TableCell>
      </asp:TableRow>
    </asp:Table> <br />

    <h2 class="titulo">&nbsp;&nbsp;Itens da Compra</h2>
    <asp:Table ID="Table2" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
      <asp:TableRow>
          <asp:TableCell>Produto</asp:TableCell>
          <asp:TableCell>Unidade</asp:TableCell>
          <asp:TableCell>Quantidade</asp:TableCell>
          <asp:TableCell>Preço Unitário</asp:TableCell>
          <asp:TableCell>Valor Total</asp:TableCell>
      </asp:TableRow>
    </asp:Table> 
</asp:Content>
