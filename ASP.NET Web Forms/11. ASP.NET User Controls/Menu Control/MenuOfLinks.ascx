<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuOfLinks.ascx.cs" Inherits="Menu_Control.MenuOfLinks" %>

<asp:DataList ID="MenuDataList" runat="server">
    <ItemTemplate>
        <a href="<%# Eval("URL") %>" style="color:<%# Eval("FontColor") %>"><%# Eval("Title") %></a>
    </ItemTemplate>
</asp:DataList>
