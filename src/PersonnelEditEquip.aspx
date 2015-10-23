<%@ Page Language="C#" MasterPageFile="~/Masters/MasterPagePersonnel.master" AutoEventWireup="true" CodeFile="PersonnelEditEquip.aspx.cs" Inherits="PersonnelEditEquip" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="center">
        <table class="form">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="نوع:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListType" runat="server">
                        <asp:ListItem>لپ تاپ</asp:ListItem>
                        <asp:ListItem>مادربورد</asp:ListItem>
                        <asp:ListItem>گرافیک</asp:ListItem>
                        <asp:ListItem>هارد</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="برند:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListBrand" runat="server">
                        <asp:ListItem>اچ پی</asp:ListItem>
                        <asp:ListItem>مکستور</asp:ListItem>
                        <asp:ListItem>دل</asp:ListItem>
                        <asp:ListItem>ایسوس</asp:ListItem>
                        <asp:ListItem>وسترن دیجیتال</asp:ListItem>
                        <asp:ListItem>گیگا</asp:ListItem>
                        <asp:ListItem>ای‌تی‌آی</asp:ListItem>
                        <asp:ListItem>انویدیا</asp:ListItem>
                        <asp:ListItem>اپل</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="مدل:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxModel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="وضعیت:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListStatus" runat="server">
                        <asp:ListItem>آمده برای تعمبر</asp:ListItem>
                        <asp:ListItem>تعمیر شده</asp:ListItem>
                        <asp:ListItem>تعمیر نمی شود</asp:ListItem>
                        <asp:ListItem>منتظر خبر مشتری</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="کد مشتری:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxCustomer" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="ButtonEdit" class="button" runat="server"
                        Text="ویرایش" onclick="ButtonEdit_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
