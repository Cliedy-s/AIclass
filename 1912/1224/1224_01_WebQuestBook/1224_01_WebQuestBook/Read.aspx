<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="_1224_01_WebQuestBook.Read" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>글쓴이 : </td>
                    <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>이메일 : </td>
                    <td><asp:Label ID="lblEmail" runat="server" TextMode="Email"></asp:Label></td>
                </tr>
                <tr>
                    <td>글제목 : </td>
                    <td><asp:Label ID="lblTitle" runat="server" TextMode="MultiLine"></asp:Label></td>
                </tr>
                <tr>
                    <td>글내용 : </td>
                    <td><asp:Label ID="lblContents" runat="server" TextMode="MultiLine"></asp:Label></td>
                </tr>
            </table>
            <a href="list.aspx">글 목록</a>&nbsp;&nbsp;
            <a href="Edit.aspx?id=<%Convert.ToString(Request.QueryString["id"]);%>">수정하기</a>&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
