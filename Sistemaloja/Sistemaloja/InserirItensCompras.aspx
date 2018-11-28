<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="InserirItensCompras.aspx.cs" Inherits="Sistemaloja.InserirItensCompras" %>
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
    .auto-style1 {
        height: 22px;
    }
    </style>
    
    <table>
        <caption>Inclusão de novo item</caption>
    <tr><td><asp:Label ID="Label1" runat="server" Text="Produto:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="descricao" DataValueField="idProduto">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:aspnetdbConnectionString %>" SelectCommand="SELECT [descricao], [idProduto] FROM [Produtos]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr><td class="auto-style1"> <asp:Label ID="Label2" runat="server" Text="Unidade:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td class="auto-style1">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br /></td></tr>
     <tr><td><asp:Label ID="Label3" runat="server" Text="Quantidade:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Label ID="Label4" runat="server" Text="Preço Unitário:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="Botao5 botao5"  OnClick="Button1_Click" /></td>
     <td><asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="Botao4 botao4" OnClick="Button2_Click" /> </td></tr>
        </table>
</asp:Content>

