<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Write.aspx.cs" Inherits="ForTest.Write" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <script src="js/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-lg">
        <div><br /><br /></div>
            <span>제목</span>
            &nbsp;<asp:TextBox ID="txtTitle" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
            <br />
            <br />
            <span>글내용</span>
            &nbsp;<asp:TextBox ID="txtContents" runat="server" Height="191px" TextMode="MultiLine" Width="100%"></asp:TextBox>
            <br /><br />
            <span>작성자</span>
            <asp:TextBox ID="txtReporter" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnWrite" runat="server" CssClass="auto-style1" Text="등록" OnClick="btnWrite_Click"/>
            &nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="취소" OnClick="btnCancel_Click"/>
        </div>
    </form>
</body>
</html>
