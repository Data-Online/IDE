<%@ Register Tagprefix="IDE" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Register Tagprefix="IDE" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Group-By-EnergyPoints-Table.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Group_By_EnergyPoints_Table" %>
<%@ Register Tagprefix="IDE" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Group_By_EnergyPoints_Table" Assembly="IDE" %>
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
                        <IDE:EnergyPointsTableControl runat="server" id="EnergyPointsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Energy Points&quot;) %>">	</asp:Literal>
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
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="EnergyPointNumberLabel1" Text="EvaluateFormula(&quot;= \&quot;Connection Number\&quot;&quot;, true)">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="EnergyPointNumberFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><IDE:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;IDE&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="EnergyPointsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="EnergyPointsTableControlRepeater">		<ITEMTEMPLATE>		<IDE:EnergyPointsTableControlRow runat="server" id="EnergyPointsTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" colspan="3">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                                  
                                    <br /><br />
                                  </td><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyPointNumberLabel" Text="EvaluateFormula(&quot;= \&quot;Connection Number\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="EnergyPointNumber"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr id="EnergyPointsTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="6"><BaseClasses:TabContainer runat="server" id="EnergyPointsTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="InvoiceSummariesTabPanel1" HeaderText="Invoice Summaries">	<ContentTemplate>
  <IDE:InvoiceSummariesTableControl1 runat="server" id="InvoiceSummariesTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="InvoiceSummariesTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="InvoiceSummariesTableControl1Repeater">		<ITEMTEMPLATE>		<IDE:InvoiceSummariesTableControl1Row runat="server" id="InvoiceSummariesTableControl1Row">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="SiteNameLabel1" Text="Site Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SiteName1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="AccountNumberLabel1" Text="Account Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AccountNumber1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedDateLabel1" Text="Approved Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ApprovedDate1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedByIdLabel2" Text="Approved By">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ApprovedById1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ConnectionNumberLabel1" Text="Connection Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ConnectionNumber1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDateLabel1" Text="Invoice Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceDate1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="SiteIdLabel2" Text="Site">	</asp:Literal> 
</td><td class="tableCellValue"><asp:LinkButton runat="server" id="SiteId1" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="tableCellLabel"><asp:Literal runat="server" id="CustomerNumberLabel1" Text="Customer Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="CustomerNumber1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDueDateLabel1" Text="Invoice Due Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceDueDate1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedLabel1" Text="Approved">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Approved1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceNumberLabel1" Text="Invoice Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="InvoiceNumber1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="PeriodEndLabel1" Text="Period End">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PeriodEnd1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="MonthLabel1" Text="Month">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Month1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyChargesTotalLabel1" Text="Energy Charges Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EnergyChargesTotal1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="PeriodStartLabel1" Text="Period Start">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PeriodStart1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="GSTChargesLabel1" Text="GST Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="GSTCharges1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="GstTotalLabel1" Text="GST Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="GstTotal1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceIdLabel1" Text="Invoice">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceId1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceTotalLabel1" Text="Invoice Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceTotal1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="MiscChargesTotalLabel1" Text="EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="MiscChargesTotal1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NetworkChargesTotalLabel1" Text="Network Charges Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NetworkChargesTotal1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="PercentageChangeLabel1" Text="Percentage Change">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PercentageChange1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalChargesLabel1" Text="Total Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalCharges1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalEnergyChargesLabel1" Text="Total Energy Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalEnergyCharges1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="TotalMiscChargesLabel1" Text="Total Misc Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalMiscCharges1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalNetworkChargesLabel1" Text="EvaluateFormula(&quot;= \&quot;Total Network/Line Charges\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TotalNetworkCharges1"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="YearLabel1" Text="Year">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="Year1"></asp:Literal> </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></IDE:InvoiceSummariesTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination2"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="InvoiceSummariesTableControl1_PostbackTracker" runat="server" />
</IDE:InvoiceSummariesTableControl1>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td></tr><tr><td class="tableRowDivider" colspan="9"></td></tr></IDE:EnergyPointsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="EnergyPointsTableControl_PostbackTracker" runat="server" />
</IDE:EnergyPointsTableControl>

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
                