<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="AlterarItensVenda.aspx.cs" Inherits="Sistemaloja.AlterarItensVenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        table {
            margin-left:20px;

        }
        h1 {
            margin-left:20px;
        }
    </style>
    <h1 class="titulo">Visualizar/Alterar Itens Venda</h1><br />

    <h2 class="titulo">&nbsp;&nbsp;Itens da Venda&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Incluir" Height="30px" Width="98px" />&nbsp;&nbsp;
  <asp:Button ID="Button4" runat="server" Text="Excluir" Height="30px" OnClick="Button4_Click" Width="98px" />
    </h2>
    <asp:Table ID="Table2" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
      <asp:TableRow>
          <asp:TableCell>Produto</asp:TableCell>
          <asp:TableCell>Peso</asp:TableCell>
          <asp:TableCell>Preço/KG</asp:TableCell>
          <asp:TableCell>Valor Total</asp:TableCell>
      </asp:TableRow>
    </asp:Table> 
    <asp:Table ID="Table3" runat="server">
    </asp:Table>
    <br />
    <br/>
    
</asp:Content>
