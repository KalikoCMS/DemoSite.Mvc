<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FeaturePropertyEditor.ascx.cs" Inherits="DemoSite.Business.PropertyTypes.FeaturePropertyEditor" %>
<div class="form-group">
    <asp:Label AssociatedControlID="HeaderField" runat="server" ID="LabelText" CssClass="control-label col-xs-2" />
    <div class="controls col-xs-6">
      <div>
        <label for="<%=HeaderField.ClientID %>" class="control-label">Header:</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="HeaderField" />
      </div>
      <div>
        <label for="<%=DescriptionField.ClientID %>" class="control-label">Description:</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="DescriptionField" />
      </div>
      <div>
        <label for="<%=UrlField.ClientID %>" class="control-label">Url:</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="UrlField" />
      </div>
      <asp:Literal ID="ErrorText" runat="server" />
    </div>
</div>