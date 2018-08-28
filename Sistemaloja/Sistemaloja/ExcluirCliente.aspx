<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="ExcluirCliente.aspx.cs" Inherits="Sistemaloja.WebForm2" %>
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
            opacity:0.8;
            filter:alpha(opacity=80);
        }
        </style>
    <table>
    <tr><td><asp:Label ID="Label1" runat="server" Text="Nome:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td>
        <td><asp:Label ID="Label8" runat="server" Text="Label" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td>
    </tr>
    <tr><td><asp:Label ID="Label2" runat="server" Text="Telefones:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label9" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label3" runat="server" Text="Cidade:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label10" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label4" runat="server" Text="Endereço:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label11" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label5" runat="server" Text="CPF:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label12" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label6" runat="server" Text="CNPJ:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label13" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"> </asp:Label></td></tr>
    <tr><td><asp:Label ID="Label7" runat="server" Text="Sigla:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label14" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Button ID="Button1" runat="server" Text="Excluir" CssClass="Botao4 botao4" OnClick="Button1_Click" /></td>
        <td><asp:Button ID="Button2" runat="server" Text="Cancelar"  CssClass="Botao5 botao5" OnClick="Button2_Click" /></td></tr>
        </table>
</asp:Content>
