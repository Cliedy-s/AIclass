<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="ForTest.Read" %>

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
        <div><br /><br /></div>
        <div class="container-sm">
            <asp:Label ID="lblTitle" runat="server" Text="제목" CssClass="font-weight-bold"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="입력 "></asp:Label>
            <asp:Label ID="lblDateTime" runat="server" Text="입력날짜"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="|"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="수정 "></asp:Label>
            <asp:Label ID="lblEditDateTime" runat="server" Text="수정날짜"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblContents" runat="server" Text="글내용"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblReporter" runat="server" Text="취재진"></asp:Label>
        </div>
    </form>
</body>
</html>
