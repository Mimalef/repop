<%@ Page Language="C#" MasterPageFile="~/Masters/MasterPageMessage.master" AutoEventWireup="true" CodeFile="PublicError.aspx.cs" Inherits="PublicError" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center">
        <asp:Label ID="LabelMessage" runat="server" Text="" CssClass="error"></asp:Label>
        <br />
        <asp:LinkButton ID="LinkButtonReturn" runat="server" CssClass="button">بازگشت</asp:LinkButton>
    </div>
</asp:Content>
