<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="_1224_01_WebQuestBook.Edit" %>

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
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>이메일 : </td>
                    <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>글제목 : </td>
                    <td><asp:TextBox ID="txtTitle" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>글내용 : </td>
                    <td><asp:TextBox ID="txtContents" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>비밀번호 : </td>
                    <td><asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
            </table>
            <input type="hidden" runat="server" name="hidPwd" id="hidPwd"/>
            <asp:Button ID="btnWrite" runat="server" Text="수정" OnClick="btnWrite_Click"/>
            <asp:Button ID="btnCancle" runat="server" Text="취소" OnClick="btnCancle_Click"/>
        </div>
    </form>
</body>
</html>
