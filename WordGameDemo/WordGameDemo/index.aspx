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
            <div ID="guessPanel">
                <asp:Label ID="g1" CssClass="guesstile" runat="server"></asp:Label>
                <asp:Label ID="g2" CssClass="guesstile" runat="server"></asp:Label>
                <asp:Label ID="g3" CssClass="guesstile" runat="server"></asp:Label>
                <asp:Label ID="g4" CssClass="guesstile" runat="server"></asp:Label>
                <asp:Label ID="g5" CssClass="guesstile" runat="server"></asp:Label>
                <asp:Label ID="g6" CssClass="guesstile" runat="server"></asp:Label>
                <asp:Label ID="g7" CssClass="guesstile" runat="server"></asp:Label>
            </div>
            <br />
            <div ID="wordPanel" runat="server"></div>
            <br />
            <div id="btnPanel">
                <asp:Button ID="btnGuess" CssClass="btn btn-lg panelBtn" Text="Guess!" OnClick="btnGuess_Click" runat="server"/>
                <asp:Button ID="btnClear" CssClass="btn btn-lg" Text="Clear" OnClick="btnClear_Click" runat="server"/>
            </div>
            
        </div>
    </form>
</body>
</html>
