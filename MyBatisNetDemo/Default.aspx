<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyBatisNetDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="webFrom" runat="server">
    <div>
        
        <asp:Button ID="bt_Add" runat="server" Text="新增" OnClick="bt_Add_Click" />
        <br />

        <asp:Button ID="bt_Del" runat="server" Text="删除" OnClick="bt_Del_Click" />
    </div>
        <asp:Button ID="bt_Update" runat="server" Text="修改" OnClick="bt_Update_Click" />
        <br />
        
        <asp:Button ID="bt_Query" runat="server" Text="查询" OnClick="bt_Query_Click" />
    </form>
</body>
</html>
