<%@ Register Tagprefix="IDE" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Show-EnergyCharges.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Show_EnergyCharges" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Show_EnergyCharges" Assembly="IDE" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style="position:absolute; padding:30px;" class="updatingContainer">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <IDE:EnergyChargesRecordControl runat="server" id="EnergyChargesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Energy Charges&quot;) %>">	</asp:Literal>
                      </td><td class="dhir">
                  <asp:ImageButton runat="server" id="DialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" onmouseout="this.src=&#39;../Images/iconEdit.gif&#39;" onmouseover="this.src=&#39;../Images/iconEditOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="EnergyChargesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyChargeIdLabel" Text="Energy Charge">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="EnergyChargeId"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0004"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004RLabel" Text="EvaluateFormula(&quot;= \&quot;Busness Day 0004 Rate\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0004R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0408"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408RLabel" Text="BD0408R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0408R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0812"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812RLabel" Text="BD0812R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0812R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1216"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216RLabel" Text="BD1216R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1216R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1620"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620RLabel" Text="BD1620R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1620R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD2024"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024RLabel" Text="BD2024R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD2024R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0004"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004RLabel" Text="EvaluateFormula(&quot;= \&quot;Non Business Day 0004 Rate\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0004R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0408"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408RLabel" Text="NBD0408R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0408R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0812"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812RLabel" Text="NBD0812R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0812R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1216"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216RLabel" Text="NBD1216R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1216R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1620"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620RLabel" Text="NBD1620R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1620R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD2024"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024RLabel" Text="NBD2024R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD2024R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="EnergyChargesRecordControl_PostbackTracker" runat="server" />
</IDE:EnergyChargesRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><IDE:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td><td><IDE:ThemeButton runat="server" id="EditButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td></tr></table>
</td></tr></table>
</td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                