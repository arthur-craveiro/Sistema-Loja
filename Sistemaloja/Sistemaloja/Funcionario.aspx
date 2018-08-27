<%@ Page Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="Sistemaloja.Funcionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="Table1" runat="server">
      <asp:TableRow>
          <asp:TableCell>idFuncionario</asp:TableCell>
          <asp:TableCell>Nome</asp:TableCell>
          <asp:TableCell>Telefones</asp:TableCell>
          <asp:TableCell>Identidade</asp:TableCell>
          <asp:TableCell>Carteira de Trabalho</asp:TableCell>
          <asp:TableCell>Salário</asp:TableCell>
          <asp:TableCell>Motorista</asp:TableCell>
          <asp:TableCell>Técnico</asp:TableCell>
          <asp:TableCell>Observação</asp:TableCell>
      </asp:TableRow>
    </asp:Table>
</asp:Content>
