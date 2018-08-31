<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="AlterarProdutos.aspx.cs" Inherits="Sistemaloja.AlterarProdutos" %>
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
        <caption>Alterar Dados do Produto</caption>
   <tr><td><asp:Label ID="Label1" runat="server" Text="Código:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI"></asp:TextBox></td></tr>
     <tr><td><asp:Label ID="Label2" runat="server" Text="Descrição:" ForeColor="Black" Font-Bold="true"></asp:Label></td><td>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" BorderStyle="NotSet" BackColor="#EAEAEA" Font-Size="18px" Font-Names="Segoe UI" ></asp:TextBox><br /></td></tr>
             <tr><center><td style="padding:20px;"> <asp:Button ID="Button1" runat="server" Text="Atualizar"  cssClass="Botao5 botao5"  OnClick="Button1_Click" /></td><td><asp:Button ID="Button2" runat="server" Text="Cancelar"  cssClass="Botao4 botao4"  OnClick="Button2_Click" /></td></center> </tr> 

    </table>
</asp:Content>
