<%@ Page Language="C#" MasterPageFile="~/Masters/MasterPageManager.master" AutoEventWireup="true" CodeFile="ManagerAddPersonnel.aspx.cs" Inherits="ManagerAddPersonnel" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="center">
        <table class="form">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="نام:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxFirsName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="فامیل:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="تلفن:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxTelephone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="کاربری:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="گزرواژه:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="ButtonAdd" class="button" runat="server"
                        Text="ثبت" onclick="ButtonAdd_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
