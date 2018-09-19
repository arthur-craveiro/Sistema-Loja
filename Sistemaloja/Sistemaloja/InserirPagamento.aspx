<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="InserirPagamento.aspx.cs" Inherits="Sistemaloja.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div style="margin-left:60px;">
    <table style="background-color:#e4dada; color:#0094ff;">
        <tr><td style="padding:10px;"><asp:Label ID="Label1" runat="server" Text="Valor pago" Font-Names="Segoe UI"></asp:Label></td><td><asp:TextBox ID="TextBox1" runat="server" Width="200px" Height="30px" BackColor="#cccccc"></asp:TextBox></td></tr>
        <tr><td style="padding:10px;"><asp:Label ID="Label2" runat="server" Text="Data do pagamento" Font-Names="Segoe UI"></asp:Label></td><td ><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td></tr>
        <tr><td style="padding:10px;"><asp:Label ID="Label3" runat="server" Text="Mês/Ano de referência" Font-Names="Segoe UI"></asp:Label><br /></td>
        <td style="padding:10px;"><asp:DropDownList ID="DropDownList1" runat="server"  Width="70px" Height="30px"></asp:DropDownList> / <asp:DropDownList ID="DropDownList2" runat="server"  Width="70px" Height="30px"></asp:DropDownList></td></tr>
        <tr><td style="padding:10px;"><asp:Label ID="Label4" runat="server" Text="Funcionário" Font-Names="Segoe UI"></asp:Label></td><td><asp:DropDownList ID="DropDownList3" runat="server" Width="70px" Height="30px"></asp:DropDownList></td></tr>
        <tr><td style="padding:10px;"><asp:Button ID="Button1" runat="server" Text="Inserir" OnClick="Button1_Click"  CssClass="Botao5 botao5" />&nbsp;</td><td><asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" CssClass="Botao4 botao4" /></td></tr>
    </table></div>
</asp:Content>
