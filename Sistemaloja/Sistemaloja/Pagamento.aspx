<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="Pagamento.aspx.cs" Inherits="Sistemaloja.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="HyperLink1" CssClass="Botao2 botao2" runat="server" NavigateUrl="~/InserirPagamento.aspx">Incluir pagamento</asp:HyperLink><br />
    <asp:Label ID="Label1" runat="server" Text="Funcionário:"></asp:Label>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" ForeColor="Black" Font-Bold="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    <asp:Label ID="Label2" runat="server" Text="Mês/Ano referência:"></asp:Label><asp:DropDownList ID="DropDownList2" runat="server" ForeColor="Black" Font-Bold="true"></asp:DropDownList><asp:Button ID="Button1" runat="server" Text="Pesquisar" cssClass="Botao5 botao5" OnClick="Button1_Click" /><br />
    <asp:Label ID="Label3" runat="server" Text="Salário:"></asp:Label><asp:Label ID="Label4" runat="server" Text=""></asp:Label><br /><br />

      <asp:Table ID="Table1" runat="server" BackColor="#F3F3F3" Font-Bold="True" Font-Names="Segoe UI" Font-Size="18px" ForeColor="Black" GridLines="horizontal" Width="1200px">
        <asp:TableRow>
          <asp:TableCell>Data do Pagamento</asp:TableCell>
          <asp:TableCell>Mês/Ano de referência</asp:TableCell>
          <asp:TableCell>Valor pago</asp:TableCell>
      </asp:TableRow>
    </asp:Table><br /><br />
    <asp:Label ID="Label5" runat="server" Text="Valor dos pagamentos feitos:"></asp:Label><asp:Label ID="Label6" runat="server" Text=""></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Valor devido:"></asp:Label><asp:Label ID="Label8" runat="server" Text=""></asp:Label>
</asp:Content>
