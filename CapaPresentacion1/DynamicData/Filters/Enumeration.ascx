<%@ Control Language="C#" CodeBehind="Enumeration.ascx.cs" Inherits="CapaPresentacion1.EnumerationFilter" %>

<asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="True" CssClass="DDFilter"
    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
  <asp:ListItem Text="Todo" Value="" />
</asp:DropDownList>

