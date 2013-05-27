<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="../UserControls/ExemploPopup.ascx" TagName="ExemploPopup" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        var styleToSelect;
        function onOk() {
            alert("teste");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server">Please click to select an alternate text style.</asp:LinkButton><br />
    <br />
    <div>
        <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" Style="display: none"
            Width="233px">
            <uc1:ExemploPopup ID="ExemploPopup1" runat="server" />
            <div align="center">
<%--                <asp:Button ID="OkButton" runat="server" Text="OK" />
                <asp:Button ID="CancelButton" runat="server" Text="Cancel" />--%>
            </div>
        </asp:Panel>
        <br />
        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="LinkButton1"
            PopupControlID="Panel1" BackgroundCssClass="modalBackground" DropShadow="true"
             />
    </div>
    </form>
</body>
</html>
