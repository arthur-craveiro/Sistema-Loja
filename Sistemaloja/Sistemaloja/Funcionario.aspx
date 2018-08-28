<%@ Page Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="Sistemaloja.Funcionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left:1em;">
    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="Botao2 botao2" NavigateUrl="~/InserirFuncionario.aspx">Inserir Funcionario</asp:HyperLink>
    <asp:Table ID="Table1" runat="server"  BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
        <asp:TableRow>
            <asp:TableCell Visible="false">idFuncionario</asp:TableCell>
            <asp:TableCell>Nome</asp:TableCell>
            <asp:TableCell>Telefones</asp:TableCell>
            <asp:TableCell>Identidade</asp:TableCell>
            <asp:TableCell>Carteira de Trabalho</asp:TableCell>
            <asp:TableCell>Salário</asp:TableCell>
            <asp:TableCell>Motorista</asp:TableCell>
            <asp:TableCell>Técnico</asp:TableCell>
            <asp:TableCell>Observação</asp:TableCell>
        </asp:TableRow>
    </asp:Table></div>
</asp:Content>
