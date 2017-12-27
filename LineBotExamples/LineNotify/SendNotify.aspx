<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendNotify.aspx.cs" Inherits="LineNotify.SendNotify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Token:<asp:TextBox ID="TextBoxToken" runat="server" Width="621px"></asp:TextBox>
        <br />
        <br />
        Messang:<asp:TextBox ID="TextBoxMsg" runat="server" Height="123px" TextMode="MultiLine" Width="593px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
    
    </div>
    </form>
</body>
</html>
