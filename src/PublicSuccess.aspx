<%@ Page Language="C#" MasterPageFile="~/Masters/MasterPageMessage.master" AutoEventWireup="true" CodeFile="PublicSuccess.aspx.cs" Inherits="PublicSuccess" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center">
        <asp:Label ID="LabelMessage" runat="server" Text="" CssClass="success"></asp:Label>
        <br />
        <asp:LinkButton ID="LinkButtonReturn" runat="server" CssClass="button">بازگشت</asp:LinkButton>
    </div>
</asp:Content>
