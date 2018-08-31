<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="InserirCliente.aspx.cs" Inherits="Sistemaloja.WebForm4" %>
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
        <caption>Cadastro de novo cliente</caption>
    <tr><td><asp:Label ID="Label1" runat="server" Text="Nome:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td>
        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr><td> <asp:Label ID="Label2" runat="server" Text="Telefones:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Label ID="Label3" runat="server" Text="Cidade:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Label ID="Label4" runat="server" Text="Endereco:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /></td></tr>
      <tr><td><asp:Label ID="Label5" runat="server" Text="CPF:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br /></td></tr>
    <tr><td> <asp:Label ID="Label6" runat="server" Text="CNPJ:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br /></td></tr>
        <tr><td><asp:Label ID="Label8" runat="server" Text="Email:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td><td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br /></td></tr>
     <tr>
         <td><asp:Label ID="Label7" runat="server" Text="UF:" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label></td>

         <td><asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:DropDownList> </td></tr>
     <tr><td><asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="Botao5 botao5"  OnClick="Button1_Click" /></td>
     <td><asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="Botao4 botao4" OnClick="Button2_Click" /> </td></tr>
        </table>
</asp:Content>
