<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="ForTest.List" %>

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
        <div class="container-lg">
            <asp:GridView class="table table-borderless" ID="grvReportTitles" runat="server" AllowCustomPaging="True" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grvReportTitles_PageIndexChanging">
                <Columns>
                    <asp:HyperLinkField DataTextField="rpt_Title" HeaderText="JTBC뉴스룸" DataNavigateUrlFormatString="Read.aspx?No={0}" DataNavigateUrlFields="rpt_No"/>
                </Columns>
            </asp:GridView><br />
            <a href ="Write.aspx">기사쓰기</a>

        </div>
    </form>
</body>
</html>
