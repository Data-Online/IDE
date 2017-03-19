<%@ Register Tagprefix="IDE" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="SignOut.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.SignOut" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="Content" ContentPlaceHolderID="PageContent" runat="server">
     <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">
          <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="DialogTitle" Text="&lt;%# GetResourceValue(&quot;Txt:SignOut&quot;, &quot;IDE&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td class="dBody"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ForgetSignInButton")) %><asp:panel id="SignOutCollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" style="width:100%;"><tr><td><div class="securityGraphicWrapper"><img src="../Images/SignOutPageGraphic.jpg" class="imageDropshadow" /></div>
        </td><td class="securityForm"><table><tr><td><asp:Label runat="server" id="SignOutMessage" Text="&lt;%# GetResourceValue(&quot;Txt:SuccessfullySignOut&quot;, &quot;IDE&quot;) %>">	</asp:Label><br /><br /></td></tr><tr><td align="center"><IDE:ThemeButton runat="server" id="ForgetSignInButton" button-causesvalidation="False" button-commandname="ForgetSignInInformation" button-text="&lt;%# GetResourceValue(&quot;Btn:ForgetSignInButton&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Txt:ForgetSignInButton&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButton></td></tr><tr><td><asp:Label id="CloseWindowMessage" runat="server" Text="<%# GetResourceValue(&quot;Txt:CloseWindowMessage&quot;, &quot;IDE&quot;) %>" />&nbsp;</td></tr></table>
</td></tr></table></asp:panel>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ForgetSignInButton")) %></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table></div><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
        <div class="QDialog" id="dialog" style="display:none;">
          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
        </div>  
          <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
          