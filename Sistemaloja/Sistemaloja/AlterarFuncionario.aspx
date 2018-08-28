<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="AlterarFuncionario.aspx.cs" Inherits="Sistemaloja.AlterarFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        td {
            padding:10px;
        }
        table {
             margin-left:60px;
             background-color:#EAEAEA;
            opacity:0.8;
            filter:alpha(opacity=80);
        }
         .Botao {
					 	width: 15em;
					    background-color: #ffff; 
					    border: 1px; 
						border-radius: 8px;
					    color: white;
					    padding: 16px 32px;
					    text-align: center;
					    text-decoration: none;
					    display: inline-block;
					    font-size: 19px;
					    margin: 4px 2px;
					    -webkit-transition-duration: 0.4s; 
					    transition-duration: 0.4s;
					    cursor: pointer;

						}
        	.botao1 {
					    background-color: white;
					    color: black;
					    border: 2px solid #555552;
					}
        .botao1:hover {
					    background-color:  green;
					    color: white;
					    border-color: white;
					}
    </style>
    <table >
   <tr><td><asp:Label ID="Label1" runat="server" Text="Nome:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI"></asp:TextBox></td></tr>
     <tr><td><asp:Label ID="Label2" runat="server" Text="Telefones:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI" ></asp:TextBox><br /></td></tr>
     <tr><td><asp:Label ID="Label3" runat="server" Text="Identidade:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI"></asp:TextBox><br /></td></tr>
    <tr><td> <asp:Label ID="Label4" runat="server" Text="Carteira de trabalho" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Label ID="Label5" runat="server" Text="Salário:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI"></asp:TextBox><br /></td></tr>
     <tr><td><asp:Label ID="Label6" runat="server" Text="Motorista:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" BorderStyle="NotSet"  Font-Size="18px" Font-Names="Segoe UI" /><br /></td></tr>
    <tr><td> <asp:Label ID="Label7" runat="server" Text="Tecnico:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="CheckBox2" runat="server" BorderStyle="NotSet"  Font-Size="18px" Font-Names="Segoe UI" /><br /></td></tr>
    <tr><td> <asp:Label ID="Label8" runat="server" Text="Observação:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI" ></asp:TextBox><br /></td></tr>
    
     <tr><center><td style="padding:20px;"> <asp:Button ID="Button1" runat="server" Text="Atualizar"  cssClass="Botao5 botao5"  OnClick="Button1_Click" /></td><td><asp:Button ID="Button2" runat="server" Text="Cancelar"  cssClass="Botao4 botao4"  OnClick="Button2_Click" /></td></center> </tr> 
    </table>
</asp:Content>
