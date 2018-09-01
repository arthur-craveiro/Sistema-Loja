<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Pagamento.aspx.cs" Inherits="Sistemaloja.WebForm5" %>
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
    <h1 class="titulo">Pagamentos</h1><br />
    <table>
   
    <tr><td><asp:Label ID="Label1" runat="server" Text="Funcionário:"></asp:Label></td><td>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" ForeColor="Black" Font-Bold="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td></tr>
      <tr><td><asp:Label ID="Label2" runat="server" Text="Mês/Ano referência:"></asp:Label></td><td><asp:DropDownList ID="DropDownList2" runat="server" ForeColor="Black" Font-Bold="true"></asp:DropDownList></td><td><asp:Button ID="Button1" runat="server" Text="Pesquisar" cssClass="Botao5 botao5" OnClick="Button1_Click" /></td></tr>
     <tr><td> <asp:Label ID="Label3" runat="server" Text="Salário:"></asp:Label></td><td><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td></tr>
    </table>
      <asp:Table ID="Table1" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
        <asp:TableRow>
          <asp:TableCell>Data do Pagamento</asp:TableCell>
          <asp:TableCell>Mês/Ano de referência</asp:TableCell>
          <asp:TableCell>Valor pago</asp:TableCell>
      </asp:TableRow>
    </asp:Table>
    <table>
        <tr>
      
    <td><asp:Label ID="Label5" runat="server" Text="Valor dos pagamentos feitos:"></asp:Label>&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text=""></asp:Label>
   </td><td>&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label7" runat="server" Text="Valor devido:"></asp:Label>&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text=""></asp:Label></td> 
         <td> &nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" CssClass="Botao2 botao2" runat="server" NavigateUrl="~/InserirPagamento.aspx">Incluir pagamento</asp:HyperLink></td></tr>
        </table>
</asp:Content>
