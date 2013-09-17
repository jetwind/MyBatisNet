<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProductDetail.aspx.cs" Inherits="MyBatisNetDemo.AddProductDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新增产品详情</title>
<style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="auto-style1">
            <tr>
                <td style="height: 25px; width: 80px;">&nbsp;</td>
                <td>产品信息添加</td>
            </tr>
            <tr>
                <td>产品名称:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>产品公司:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr><td>产品规格:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>产品描述:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>图片1:</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server">img1,jpg</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>图片2:</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server">img2,jpg</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>图片3:</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server">img3,jpg</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btSave" runat="server" OnClick="btSave_Click" Text="保存" />
                &nbsp;
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
