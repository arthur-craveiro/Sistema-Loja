<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="ExcluirPagamento.aspx.cs" Inherits="Sistemaloja.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        div {
           top:0;
        }
     td {
            padding:10px;
            color:black;
        }
        table {
            top:0;
            
            margin-top:0;
             margin-left:60px;
             background-color:#EAEAEA;
            
            
        }
        </style>
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Id:"></asp:Label></td>
            <td><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Funcionário:"></asp:Label></td>
            <td><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Data:"></asp:Label></td>
            <td><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label7" runat="server" Text="Mês/Ano Referência:"></asp:Label></td>
            <td><asp:Label ID="Label8" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label9" runat="server" Text="Valor pago:"></asp:Label></td>
            <td><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Button ID="Button1" runat="server" Text="Excluir" OnClick="Button1_Click" /></td>
            <td><asp:Button ID="Button2" runat="server" Text="Cancelar" OnClientClick="JavaScript:window.history.back(1); return false;" /></td>
        </tr>
    </table>

</asp:Content>
