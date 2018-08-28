<%@ Page Title="" Language="C#" MasterPageFile="~/SistemaMaster.Master" AutoEventWireup="true" CodeBehind="InserirFuncionario.aspx.cs" Inherits="Sistemaloja.InserirFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <style>
     div {
           top:0;
        }
     td {
            padding:10px;
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
            <td>
                <asp:Label ID="Label1" runat="server" Text="Nome" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" BackColor="#EAEAEA"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2"  Text="Telefones" runat="server"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextBox2"  runat="server" BackColor="#EAEAEA"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" Text="Identidade" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"  runat="server" ></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" BackColor="#EAEAEA"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" Text="Carteira de trabalho" runat="server" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" ></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextBox4"  runat="server"  BackColor="#EAEAEA"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" Text="Salário" runat="server"  Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" ></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextBox5"  runat="server" BackColor="#EAEAEA"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Motorista" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label>

            </td>
            <td>
                <asp:CheckBox ID="CheckBox1"  runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="Label7" runat="server" Text="Técnico" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox2"  runat="server" />
            </td>
        </tr>
         <tr>
            <td>
                
                <asp:Label ID="Label8" runat="server" Text="Observação" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="TextBox6"  runat="server" BackColor="#EAEAEA"></asp:TextBox>
            </td>
        </tr>
        <tr><td><asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="Botao5 botao5" OnClick="Button1_Click" /></td>
   <td> <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="Botao4 botao4" OnClick="Button2_Click" /></td></tr>
    </table>
</asp:Content>
