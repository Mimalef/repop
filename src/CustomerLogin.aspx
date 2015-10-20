<%@ Page Language="C#" MasterPageFile="~/Masters/MasterPageCustomer.master" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="center">
        <table class="form">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="کاربری:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="گذرواژه:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="ButtonLogin" class="button" runat="server" Text="ورود" 
                        onclick="ButtonLogin_Click"  />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
