<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WordGameDemo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row" id="nameWord">
                <asp:Panel ID ="nameWordPanel" runat="server"></asp:Panel>
            </div>
            <div class="row" id="answerRow">
                <div class="col-sm-3">
                    <asp:Panel ID="answerPanel1" runat="server"></asp:Panel>
                </div>
                <div class="col-sm-3">
                    <asp:Panel ID="answerPanel2" runat="server"></asp:Panel>
                </div>
                <div class="col-sm-3">
                    <asp:Panel ID="answerPanel3" runat="server"></asp:Panel>
                </div>
                <div class="col-sm-3">
                    <asp:Panel ID="answerPanel4" runat="server"></asp:Panel>
                </div>               
            </div>
            <br />
            <asp:Panel ID="guessPanel" runat="server"></asp:Panel>
            <br />
            <asp:Panel ID="wordPanel" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>
