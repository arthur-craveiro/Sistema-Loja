<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="ExcluirFuncionario.aspx.cs" Inherits="Sistemaloja.ExcluirFuncionario" %>
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
    <table  >
    <tr><td><asp:Label ID="Label1" runat="server" Text="Nome:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label8" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label2" runat="server" Text="Telefones:"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label9" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label3" runat="server" Text="Identidade:"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label10" runat="server" Text="Label "  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label4" runat="server" Text="Carteira de trabalho:"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label11" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label5" runat="server" Text="Salário:"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label12" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
    <tr><td><asp:Label ID="Label6" runat="server" Text="Observação:"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label13" runat="server" Text="Label"  Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td></tr>
   <tr><td><asp:Label ID="Label7" runat="server" Text="Motorista:"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td> <asp:CheckBox ID="CheckBox1" runat="server" /></td>
    <tr><td><asp:Label ID="Label14" runat="server" Text="Técnico:"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td> <asp:CheckBox ID="CheckBox2" runat="server" /></td>
        <tr><td><asp:Button ID="Button1" runat="server" Text="Excluir" CssClass="Botao5 botao5" OnClick="Button1_Click" /></td>
   <td> <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="Botao4 botao4" OnClick="Button2_Click" /></td></tr>
    </table>
    
</asp:Content>
