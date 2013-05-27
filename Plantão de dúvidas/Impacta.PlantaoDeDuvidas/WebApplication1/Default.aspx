<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PlantaoDeDuvidas.WebApplication._Default" %>

<%@ Register Src="UserControls/Cadastro.ascx" TagName="Cadastro" TagPrefix="uc1" %>
<%@ Register Src="UserControls/ExemploPopup.ascx" TagName="ExemploPopup" TagPrefix="uc2" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <script type="text/jscript" language="javascript">
        $(document).ready(function () {
            $(".Valor").mask("999,99");
        });
    </script>
    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" Drag="True"
        DropShadow="True" PopupControlID="userControlPanel" TargetControlID="popupButton"
        BackgroundCssClass="modalBackground" OkControlID="okPopup" CancelControlID="cancelPopup"
        OnOkScript="OcultarModal">
    </ajaxToolkit:ModalPopupExtender>
    <asp:Panel runat="server" ID="userControlPanel" Style="display: none">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
            <ContentTemplate>
                <uc2:ExemploPopup ID="ExemploPopup1" runat="server" />
                <asp:Button ID="okPopup" runat="server" Text="OK - ocultar" CausesValidation="False" />
                <asp:Button ID="cancelPopup" runat="server" Text="Cancel - ocultar" CausesValidation="False" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
    <br />
    <uc1:Cadastro ID="Cadastro1" runat="server" />
    <br />
    Valor:
    <asp:TextBox ID="valorTextBox" ClientIDMode="Static" runat="server" CssClass="Valor"></asp:TextBox>
    <br />
    <asp:Button ID="gravarButton" runat="server" Text="Gravar" OnClick="gravarButton_Click" />
    <asp:Button ID="popupButton" runat="server" Text="Popup" CausesValidation="False" />
    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" TargetControlID="lnkPopup"
        PopupControlID="panEdit" BackgroundCssClass="modalBackground" CancelControlID="btnCancel">
    </ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="panEdit" runat="server" Height="180px" Width="400px" CssClass="ModalWindow">
        <h1>
            Edit</h1>
        <table width="100%">
            <tr>
                <td class="formtext" style="height: 23px; width: 150px;" align="left">
                    Fields1:
                </td>
                <td>
                    <asp:TextBox ID="txtFields1" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </asp:Panel>
    <a id="lnkPopup" runat="server">Show Popup</a>
</asp:Content>
