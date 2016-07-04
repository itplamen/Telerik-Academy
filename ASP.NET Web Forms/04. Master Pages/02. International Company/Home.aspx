<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_02.International_Company.Home" %>

<asp:Content ID="ContentPage" runat="server" ContentPlaceHolderID="PageContentPlaceHolder">
    <asp:HyperLink runat="server" NavigateUrl="~/Bulgaria/Home.aspx" CssClass="bg-flag"/>
    <asp:HyperLink runat="server" NavigateUrl="~/England/Home.aspx" CssClass="uk-flag"/>
</asp:Content>
