<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.ascx.cs" Inherits="PlantaoDeDuvidas.WebApplication.UserControls.Cadastro" %>
<asp:Label ID="Label1" runat="server" Text="CPF:"></asp:Label>
&nbsp;<asp:TextBox ID="cnpjTextBox" runat="server"></asp:TextBox>
<asp:CustomValidator ID="cnpjCustomValidator" runat="server" 
    ErrorMessage="CNPJ inválido" 
    onservervalidate="cnpjCustomValidator_ServerValidate">(!)</asp:CustomValidator>

