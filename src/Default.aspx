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
        
            <asp:LinkButton ID="LinkButton1" class="button" runat="server" 
                PostBackUrl="~/CustomerLogin.aspx">پنل مشتری</asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" class="button" runat="server" 
                PostBackUrl="~/PersonnelLogin.aspx">پنل پرسنل</asp:LinkButton>
            <asp:LinkButton ID="LinkButton3" class="button" runat="server" 
                PostBackUrl="~/ManagerLogin.aspx">پنل مدیر</asp:LinkButton>
            
        </div>
        <div id="footer">
            <p>Copyright (c) 2015 by Qafari</p>
        </div>
    </form>
</body>
</html>

