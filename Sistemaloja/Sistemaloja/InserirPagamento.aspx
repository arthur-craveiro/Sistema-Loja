<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="InserirPagamento.aspx.cs" Inherits="Sistemaloja.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Valor pago"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Data do pagamento"></asp:Label><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br />
    <asp:Label ID="Label3" runat="server" Text="Mês/Ano de referência"></asp:Label><br />
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList> / <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br /><br />
    <asp:Label ID="Label4" runat="server" Text="Funcionário"></asp:Label><asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Inserir" OnClick="Button1_Click" />&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
</asp:Content>
