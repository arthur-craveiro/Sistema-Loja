<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="ExcluirCliente.aspx.cs" Inherits="Sistemaloja.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Telefones:"></asp:Label><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label3" runat="server" Text="Cidade:"></asp:Label><asp:Label ID="Label10" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label4" runat="server" Text="Endereço:"></asp:Label><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label5" runat="server" Text="CPF:"></asp:Label><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label6" runat="server" Text="CNPJ:"></asp:Label><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label7" runat="server" Text="Sigla:"></asp:Label><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Excluir" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
</asp:Content>
