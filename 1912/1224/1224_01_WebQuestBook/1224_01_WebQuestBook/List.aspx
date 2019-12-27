<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="_1224_01_WebQuestBook.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowCustomPaging ="True" OnPageIndexChanging ="GridView1_PageIndexChanging" AllowSorting="True" OnSorting ="GridView1_Sorting" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText ="글번호"/>
                    <asp:HyperLinkField DataTextField="id" HeaderText="글번호" DataNavigateUrlFormatString="Read.aspx?id={0}" DataNavigateUrlFields="id"/>
                    <asp:HyperLinkField DataTextField="Title" HeaderText="글제목" DataNavigateUrlFormatString="Read.aspx?id={0}" DataNavigateUrlFields="id"/>
                    <asp:BoundField DataField="Name" HeaderText ="작성자"/>
                    <asp:BoundField DataField="Email" HeaderText ="이메일"/>
                </Columns>
            </asp:GridView>


            <a href="Write.aspx">글쓰기</a>
        </div>
    </form>
</body>
</html>
