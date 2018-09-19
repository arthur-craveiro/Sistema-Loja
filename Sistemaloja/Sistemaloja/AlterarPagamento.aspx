<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="AlterarPagamento.aspx.cs" Inherits="Sistemaloja.AlterarPagamento" %>
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
        <caption>Alterar Dados de Pagamento</caption>
        <tr><td style="padding:10px;"><asp:Label ID="Label1" runat="server" Text="Valor pago" Font-Names="Segoe UI"></asp:Label></td><td><asp:TextBox ID="TextBox1" runat="server" Width="200px" Height="30px" BackColor="#cccccc"></asp:TextBox></td></tr>
        <tr><td style="padding:10px;"><asp:Label ID="Label2" runat="server" Text="Data do pagamento" Font-Names="Segoe UI"></asp:Label></td><td ><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td></tr>
        <tr><td style="padding:10px;"><asp:Label ID="Label3" runat="server" Text="Mês/Ano de referência" Font-Names="Segoe UI"></asp:Label><br /></td>
        <td style="padding:10px;"><asp:DropDownList ID="DropDownList1" runat="server"  Width="70px" Height="30px"></asp:DropDownList> / <asp:DropDownList ID="DropDownList2" runat="server"  Width="70px" Height="30px"></asp:DropDownList></td></tr>
        <tr><td style="padding:10px;"><asp:Label ID="Label4" runat="server" Text="Funcionário" Font-Names="Segoe UI"></asp:Label></td><td><asp:DropDownList ID="DropDownList3" runat="server" Width="70px" Height="30px"></asp:DropDownList></td></tr>
    
     <tr><center><td style="padding:20px;"> <asp:Button ID="Button1" runat="server" Text="Atualizar"  cssClass="Botao5 botao5"  OnClick="Button1_Click" /></td><td><asp:Button ID="Button2" runat="server" Text="Cancelar"  cssClass="Botao4 botao4"  OnClick="Button2_Click" /></td></center> </tr> 
    </table>
</asp:Content>
