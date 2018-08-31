<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="InserirProdutos.aspx.cs" Inherits="Sistemaloja.InserirProdutos" %>
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
        <caption>Cadastro de novo Produto</caption>
    <tr><td><asp:Label ID="Label1" runat="server" Text="Codigo:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td>
        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr><td> <asp:Label ID="Label2" runat="server" Text="Descrição" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="Botao5 botao5"  OnClick="Button1_Click" /></td>
     <td><asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="Botao4 botao4" OnClick="Button2_Click" /> </td></tr>
        </table>
</asp:Content>
