<%@ Register Tagprefix="IDE" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Group-By-InvoiceSummaries-Table.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Group_By_InvoiceSummaries_Table" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="IDE" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Group_By_InvoiceSummaries_Table" Assembly="IDE" %>

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
                        <IDE:InvoiceSummariesTableControl runat="server" id="InvoiceSummariesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Invoice Summaries&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IDE:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IDE:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton"))%>

                <asp:TextBox runat="server" id="SearchText" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="SearchTextAutoCompleteExtender" runat="server" TargetControlID="SearchText" ServiceMethod="GetAutoCompletionList_SearchText" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton"))%>
</td><td>
                <asp:ImageButton runat="server" id="SearchButton" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="InvoiceDateLabel1" Text="Invoice Date">	</asp:Literal></td><td class="popupTableCellValue"><asp:TextBox runat="server" id="InvoiceDateFromFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;dd/mm/yyyy&#39;)" timestring="&quot;00:00:00&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="InvoiceDateFromFilterCalenderExtender" TargetControlID="InvoiceDateFromFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> <span class="rft"><%# GetResourceValue("Txt:To", "IDE") %></span> <asp:TextBox runat="server" id="InvoiceDateToFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;dd/mm/yyyy&#39;)" timestring="&quot;23:59:59&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="InvoiceDateToFilterCalenderExtender" TargetControlID="InvoiceDateToFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"><IDE:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellValue"><asp:Literal runat="server" id="SiteIdLabel1" Text="Site">	</asp:Literal></td><td class="popupTableCellValue"><BaseClasses:QuickSelector runat="server" id="SiteIdFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="SupplierIdLabel1" Text="Supplier">	</asp:Literal></td><td class="popupTableCellValue"><BaseClasses:QuickSelector runat="server" id="SupplierIdFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector> </td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;IDE&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="InvoiceSummariesTableControlGrid" cellpadding="0" cellspacing="0" border="0" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"><asp:Label runat="server" id="CheckedText" Text="Show : ">	</asp:Label></th><th class="thc"><asp:DropDownList runat="server" id="CheckedOkFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="InvoiceSummariesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:InvoiceSummariesTableControlRow runat="server" id="InvoiceSummariesTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"></td><td class="tableCellLabel" style="text-align:left;color:Green;"></td><td class="tableCellLabel" style="text-align:left;color:Green;">Container/File Name</td><td class="tableCellLabel" style="text-align:left;color:Green;font-weight:bold;"><asp:Literal runat="server" id="ContainerId" Text="MyLiteral">	</asp:Literal> / 
<asp:Literal runat="server" id="PdfFileName" Text="MyLiteral">	</asp:Literal></td><td class="tableCellLabel"><asp:Image runat="server" id="UploadedOkImage" imageurl="../Images/uploadedOk.png" tooltip="File uploaded OK" visible="False">		
	</asp:Image></td><td></td><td></td><td class="tableCellLabel"><IDE:ThemeButton runat="server" id="FileInvButton" button-causesvalidation="False" button-commandname="Redirect" button-text="Upload PDF" button-tooltip="Upload the PDF file to the server" redirectstyle="Popup"></IDE:ThemeButton></td></tr><tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"></td><td class="tableCellLabel" style="text-align:left;color:Green;"></td><td class="tableCellLabel" style="text-align:left;color:Green;"></td><td class="tableCellLabel" style="text-align:left;color:Green;font-weight:bold;"></td><td colspan="3"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<IDE:SitesRecordControl runat="server" id="SitesRecordControl">	<table cellpadding="0" cellspacing="0" border="0" width="300px"><tr><td><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="SitesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustomerIdLabel" Text="Customer">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="CustomerId"></asp:Literal> </td></tr></table></asp:panel>

                  </td></tr></table>
</td></tr></table>
	<asp:hiddenfield id="SitesRecordControl_PostbackTracker" runat="server" />
</IDE:SitesRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td><td class="tableCellLabel"></td></tr><tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="10" colspan="3"><asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="Edit Using Meridian Template">		
	</asp:ImageButton>   <asp:ImageButton runat="server" id="EditRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="Edit Using Contact Template">		
	</asp:ImageButton> 
<asp:ImageButton runat="server" id="EditRowButton2" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="Edit Using Mercury Template">		
	</asp:ImageButton> 
<asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                                  
                                    <br /><br />
                                 </td><td class="tableCellLabel" style="font-size:10pt"><asp:Literal runat="server" id="Literal" Text="Meridian">	</asp:Literal><br><br>
<asp:Literal runat="server" id="Literal1" Text="Contact">	</asp:Literal><br><br>
<asp:Literal runat="server" id="Literal2" Text="Mercury">	</asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="SiteIdLabel" Text="Site" visible="True">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SiteId" visible="True"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="AccountNumberLabel" Text="Account Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AccountNumber"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="SupplierIdLabel" Text="Supplier">	</asp:Literal></td><td class="tableCellValue" style="text-align:left;"><asp:Literal runat="server" id="SupplierId"></asp:Literal></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceIdLabel" Text="Invoice" visible="False">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceId" visible="False"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ConnectionNumberLabel" Text="Connection Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EnergyPointId"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="ConnectionNumber" visible="False"></asp:Literal></td><td class="tableCellValue" style="color:Red" rowspan="6"><asp:literal id="Alert" runat="server" text="AlertZZZ"></asp:literal></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="KWhTotalLabel" Text="EvaluateFormula(&quot;= \&quot;kWh Total\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="KWhTotal"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="CustomerNumberLabel" Text="Customer Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="CustomerNumber"></asp:Literal> </td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceNumberLabel" Text="Invoice Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="InvoiceNumber"></asp:Literal> </td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyChargesTotalLabel" Text="Energy Charges Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EnergyChargesTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="NetworkChargesTotalLabel" Text="Network Charges Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NetworkChargesTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDateLabel" Text="Invoice Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceDate"></asp:Literal></span>
 </td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="MiscChargesTotalLabel" Text="EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="MiscChargesTotal"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDueDateLabel" Text="Invoice Due Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceDueDate"></asp:Literal></span>
 </td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="GstTotalLabel" Text="GST Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="GstTotal"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="PeriodStartLabel" Text="Period Start">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PeriodStart"></asp:Literal></span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="PeriodEndLabel" Text="Period End">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PeriodEnd"></asp:Literal></span>
</td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceTotalLabel" Text="Invoice Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="InvoiceTotal"></asp:Literal></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr id="InvoiceSummariesTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue"></td><td class="tableCellValue" colspan="6"><BaseClasses:TabContainer runat="server" id="InvoiceSummariesTableControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="EnergyCharges">	<ContentTemplate> 
  <IDE:EnergyChargesTableControl runat="server" id="EnergyChargesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="EnergyChargesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="EnergyChargesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:EnergyChargesTableControlRow runat="server" id="EnergyChargesTableControlRow">
<tr><td class="tableCellLabel" colspan="4" style="text-align:center;">Business Day</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" colspan="2" style="text-align:center;">Amount</td><td class="tableCellLabel" colspan="2" style="text-align:center;">Rate</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0004"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0004R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0408"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0408R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0812"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD0812R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1216"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1216R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1620"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD1620R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD2024"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="BD2024R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" colspan="4" style="text-align:center;">Non Business Day</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" colspan="2" style="text-align:center;">Amount</td><td class="tableCellLabel" colspan="2" style="text-align:center;">Rate</td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0004"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0004R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0408"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0408R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0812"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD0812R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1216"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1216R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1620"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD1620R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD2024"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NBD2024R"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></IDE:EnergyChargesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination2"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="EnergyChargesTableControl_PostbackTracker" runat="server" />
</IDE:EnergyChargesTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="NetworkCharges">	<ContentTemplate> 
  <IDE:NetworkChargesTableControl runat="server" id="NetworkChargesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="NetworkChargesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="NetworkChargesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:NetworkChargesTableControlRow runat="server" id="NetworkChargesTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="CapacityChargeLabel" Text="Capacity Charge">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CapacityCharge"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="DemandChargeLabel" Text="Demand Charge">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DemandCharge"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="FixedChargeLabel" Text="Fixed Charge">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FixedCharge"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="VariableBDLabel" Text="EvaluateFormula(&quot;= \&quot;Variable Charge Business/Weekday\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="VariableBD"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="VariableNBDLabel" Text="EvaluateFormula(&quot;= \&quot;Variable Charge Non Business / Weekend\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="VariableNBD"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></IDE:NetworkChargesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination1"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="NetworkChargesTableControl_PostbackTracker" runat="server" />
</IDE:NetworkChargesTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
  
</BaseClasses:TabContainer></td></tr><tr><td class="tableRowDivider" colspan="10"></td></tr></IDE:InvoiceSummariesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="InvoiceSummariesTableControl_PostbackTracker" runat="server" />
</IDE:InvoiceSummariesTableControl>

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
                