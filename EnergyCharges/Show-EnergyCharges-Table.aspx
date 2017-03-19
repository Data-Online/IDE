<%@ Register Tagprefix="IDE" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Show_EnergyCharges_Table" Assembly="IDE" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Show-EnergyCharges-Table.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Show_EnergyCharges_Table" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="IDE" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="IDE" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <IDE:EnergyChargesTableControl runat="server" id="EnergyChargesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Energy Charges&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IDE:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IDE:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="BD0004Label1" Text="EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<asp:TextBox runat="server" id="BD0004FromFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox>
                        <span class="rft"><%# GetResourceValue("Txt:To", "IDE") %></span>
                        <asp:TextBox runat="server" id="BD0004ToFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><IDE:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;IDE&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="EnergyChargesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="EnergyChargesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:EnergyChargesTableControlRow runat="server" id="EnergyChargesTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="11" colspan="3">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                                  
                                    <br /><br />
                                  </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0004"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004RLabel" Text="EvaluateFormula(&quot;= \&quot;Busness Day 0004 Rate\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0004R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0408"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408RLabel" Text="BD0408R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0408R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0812"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812RLabel" Text="BD0812R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0812R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1216"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216RLabel" Text="BD1216R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1216R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1620"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620RLabel" Text="BD1620R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1620R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD2024"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024RLabel" Text="BD2024R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD2024R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0004"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004RLabel" Text="EvaluateFormula(&quot;= \&quot;Non Business Day 0004 Rate\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0004R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0408"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408RLabel" Text="NBD0408R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0408R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0812"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812RLabel" Text="NBD0812R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0812R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1216"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216RLabel" Text="NBD1216R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1216R"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1620"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620RLabel" Text="NBD1620R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1620R"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD2024"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024RLabel" Text="NBD2024R">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD2024R"></asp:Literal></span>
 </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr id="EnergyChargesTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="6"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<BaseClasses:TabContainer runat="server" id="EnergyChargesTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="InvoiceSummariesTabPanel" HeaderText="Energy Charge">	<ContentTemplate>
  <IDE:InvoiceSummariesRecordControl runat="server" id="InvoiceSummariesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="InvoiceSummariesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="SiteNameLabel" Text="Site Name">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="SiteName"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="AccountNumberLabel" Text="Account Number">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="AccountNumber"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedDateLabel" Text="Approved Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ApprovedDate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedLabel" Text="Approved">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="Approved"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ConnectionNumberLabel" Text="Connection Number">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ConnectionNumber"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDateLabel" Text="Invoice Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceDate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustomerNumberLabel" Text="Customer Number">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustomerNumber"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceNumberLabel" Text="Invoice Number">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="InvoiceNumber"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDueDateLabel" Text="Invoice Due Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceDueDate"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="MonthLabel" Text="Month">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="Month"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyChargesTotalLabel" Text="Energy Charges Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EnergyChargesTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="GSTChargesLabel" Text="GST Charges">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="GSTCharges"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="GstTotalLabel" Text="GST Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="GstTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceIdLabel" Text="Invoice">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceId"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceTotalLabel" Text="Invoice Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="MiscChargesTotalLabel" Text="EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="MiscChargesTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NetworkChargesTotalLabel" Text="Network Charges Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NetworkChargesTotal"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="PercentageChangeLabel" Text="Percentage Change">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PercentageChange"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalChargesLabel" Text="Total Charges">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalCharges"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalEnergyChargesLabel" Text="Total Energy Charges">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalEnergyCharges"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="TotalMiscChargesLabel" Text="Total Misc Charges">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalMiscCharges"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalNetworkChargesLabel" Text="EvaluateFormula(&quot;= \&quot;Total Network/Line Charges\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalNetworkCharges"></asp:Literal></span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="YearLabel" Text="Year">	</asp:Literal></td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="Year"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="InvoiceSummariesRecordControl_PostbackTracker" runat="server" />
</IDE:InvoiceSummariesRecordControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="tableRowDivider" colspan="9"></td></tr></IDE:EnergyChargesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="EnergyChargesTableControl_PostbackTracker" runat="server" />
</IDE:EnergyChargesTableControl>

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
                