<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>تعمیرگاه</title>
    <link href="Styles/Default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            
            <asp:Image ID="ImageCover" runat="server" ImageUrl="~/Images/Cover.jpg" />
            
        </div>
        <div id="nav">
        
            <asp:Button ID="Button1" runat="server" Text="پنل مشتری" class="button" />
            <asp:Button ID="Button2" runat="server" Text="پنل پرسنل" class="button" />
            
        </div>
        <div id="footer">
            <p>Copyright (c) 2015 by Qafari</p>
        </div>
    </form>
</body>
</html>

