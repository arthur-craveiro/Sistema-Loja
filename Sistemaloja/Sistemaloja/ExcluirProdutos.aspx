<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="ExcluirProdutos.aspx.cs" Inherits="Sistemaloja.ExcluirProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        div {
           top:0;
        }
     td {
            padding:10px;
        }
        table {
            top:0;
            
            margin-top:0;
             margin-left:60px;
             background-color:#EAEAEA;
           
           
        }
        </style>
    <table>
        <caption>Excluir Produtos</caption>
     <tr><td><asp:Label ID="Label1" runat="server" Text="Código:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label3" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label2" runat="server" Text="Descrição:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label4" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
        <tr><td><asp:Button ID="Button1" runat="server" Text="Excluir" CssClass="Botao5 botao5 " OnClick="Button1_Click" /></td>
   <td> <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="Botao4 botao4" OnClick="Button2_Click" /></td></tr>
    </table>
</asp:Content>
