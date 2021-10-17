<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="top_trumps_web_app._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <h3>&nbsp Plane top trumps</h3>
            <br />
            <br />
            &nbsp <asp:ImageButton ID="image_1" runat="server" Height="150px" Width="150px" OnClick="image_1_Click" />
            <br />
            <br />
            <br />
            &nbsp <asp:Label ID="result_lable" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
