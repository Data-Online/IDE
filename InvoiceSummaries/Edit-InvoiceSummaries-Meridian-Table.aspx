<%@ Register Tagprefix="IDE" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Edit-InvoiceSummaries-Meridian-Table.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Edit_InvoiceSummaries_Meridian_Table" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Edit_InvoiceSummaries_Meridian_Table" Assembly="IDE" %>

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
                        <IDE:InvoiceSummariesTableControl runat="server" id="InvoiceSummariesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Invoice Summaries&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="AddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src=&#39;../Images/ButtonBarDelete.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarDeleteOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="SaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/ButtonBarSave.gif" onmouseout="this.src=&#39;../Images/ButtonBarSave.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarSaveOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

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
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ApprovedByIdLabel1" Text="Approved By">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="ApprovedByIdFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><IDE:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;IDE&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="InvoiceSummariesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="3"><asp:CheckBox runat="server" id="ToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thcnb">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="InvoiceSummariesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:InvoiceSummariesTableControlRow runat="server" id="InvoiceSummariesTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="14" colspan="3">
                              <asp:CheckBox runat="server" id="SelectRow" onclick="moveToThisTableRow(this);">	</asp:CheckBox>                              
                            </td><td class="tableRowButtonsCellVertical" rowspan="14">
                          <asp:ImageButton runat="server" id="ViewRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                        
                          <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                        
                          <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                        </td><td class="tableCellLabel"><asp:Literal runat="server" id="SiteNameLabel" Text="Site Name">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SiteName" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="SiteNameRequiredFieldValidator" ControlToValidate="SiteName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Site Name&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SiteNameTextBoxMaxLengthValidator" ControlToValidate="SiteName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Site Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedDateLabel" Text="Approved Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="ApprovedDate" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="ApprovedDateCalendarExtender" TargetControlID="ApprovedDate" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ApprovedDateTextBoxMaxLengthValidator" ControlToValidate="ApprovedDate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Approved Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedByIdLabel" Text="Approved By">	</asp:Literal> 
</td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="ApprovedById" redirecturl=""></BaseClasses:QuickSelector> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDateLabel" Text="Invoice Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="InvoiceDate" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="InvoiceDateCalendarExtender" TargetControlID="InvoiceDate" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<asp:RequiredFieldValidator runat="server" id="InvoiceDateRequiredFieldValidator" ControlToValidate="InvoiceDate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Date&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="InvoiceDateTextBoxMaxLengthValidator" ControlToValidate="InvoiceDate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="SiteIdLabel" Text="Site">	</asp:Literal> 
</td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="SiteId" redirecturl=""></BaseClasses:QuickSelector> </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDueDateLabel" Text="Invoice Due Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="InvoiceDueDate" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="InvoiceDueDateCalendarExtender" TargetControlID="InvoiceDueDate" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="InvoiceDueDateTextBoxMaxLengthValidator" ControlToValidate="InvoiceDueDate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Due Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ApprovedLabel" Text="Approved">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="Approved"></asp:CheckBox> </td><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyChargesTotalLabel" Text="Energy Charges Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="EnergyChargesTotal" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="EnergyChargesTotalRequiredFieldValidator" ControlToValidate="EnergyChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Energy Charges Total&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EnergyChargesTotalTextBoxMaxLengthValidator" ControlToValidate="EnergyChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Energy Charges Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="AccountNumberLabel" Text="Account Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="AccountNumber" Columns="12" MaxLength="12" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="AccountNumberRequiredFieldValidator" ControlToValidate="AccountNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Account Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AccountNumberTextBoxMaxLengthValidator" ControlToValidate="AccountNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Account Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"> 
</td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="ConnectionNumberLabel" Text="Connection Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ConnectionNumber" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="ConnectionNumberRequiredFieldValidator" ControlToValidate="ConnectionNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Connection Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ConnectionNumberTextBoxMaxLengthValidator" ControlToValidate="ConnectionNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Connection Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="GSTChargesLabel" Text="GST Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="GSTCharges" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="GSTChargesRequiredFieldValidator" ControlToValidate="GSTCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;GST Charges&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="GSTChargesTextBoxMaxLengthValidator" ControlToValidate="GSTCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;GST Charges&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustomerNumberLabel" Text="Customer Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustomerNumber" Columns="12" MaxLength="12" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="CustomerNumberRequiredFieldValidator" ControlToValidate="CustomerNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustomerNumberTextBoxMaxLengthValidator" ControlToValidate="CustomerNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="GstTotalLabel" Text="GST Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="GstTotal" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="GstTotalRequiredFieldValidator" ControlToValidate="GstTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;GST Total&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="GstTotalTextBoxMaxLengthValidator" ControlToValidate="GstTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;GST Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceNumberLabel" Text="Invoice Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="InvoiceNumber" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="InvoiceNumberRequiredFieldValidator" ControlToValidate="InvoiceNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="InvoiceNumberTextBoxMaxLengthValidator" ControlToValidate="InvoiceNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceIdLabel" Text="Invoice">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="InvoiceId" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="InvoiceIdRequiredFieldValidator" ControlToValidate="InvoiceId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="InvoiceIdTextBoxMaxLengthValidator" ControlToValidate="InvoiceId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="MonthLabel" Text="Month">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Month" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="MonthTextBoxMaxLengthValidator" ControlToValidate="Month" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceTotalLabel" Text="Invoice Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="InvoiceTotal" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="InvoiceTotalRequiredFieldValidator" ControlToValidate="InvoiceTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Total&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="InvoiceTotalTextBoxMaxLengthValidator" ControlToValidate="InvoiceTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="MiscChargesTotalLabel" Text="EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="MiscChargesTotal" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="MiscChargesTotalRequiredFieldValidator" ControlToValidate="MiscChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="MiscChargesTotalTextBoxMaxLengthValidator" ControlToValidate="MiscChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NetworkChargesTotalLabel" Text="Network Charges Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NetworkChargesTotal" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NetworkChargesTotalRequiredFieldValidator" ControlToValidate="NetworkChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Network Charges Total&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NetworkChargesTotalTextBoxMaxLengthValidator" ControlToValidate="NetworkChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Network Charges Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="PercentageChangeLabel" Text="Percentage Change">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="PercentageChange" Columns="20" MaxLength="22" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PercentageChangeTextBoxMaxLengthValidator" ControlToValidate="PercentageChange" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Percentage Change&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalChargesLabel" Text="Total Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="TotalCharges" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="TotalChargesRequiredFieldValidator" ControlToValidate="TotalCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Total Charges&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TotalChargesTextBoxMaxLengthValidator" ControlToValidate="TotalCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Total Charges&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="TotalEnergyChargesLabel" Text="Total Energy Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="TotalEnergyCharges" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="TotalEnergyChargesRequiredFieldValidator" ControlToValidate="TotalEnergyCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Total Energy Charges&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TotalEnergyChargesTextBoxMaxLengthValidator" ControlToValidate="TotalEnergyCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Total Energy Charges&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TotalMiscChargesLabel" Text="Total Misc Charges">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="TotalMiscCharges" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="TotalMiscChargesRequiredFieldValidator" ControlToValidate="TotalMiscCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Total Misc Charges&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TotalMiscChargesTextBoxMaxLengthValidator" ControlToValidate="TotalMiscCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Total Misc Charges&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="TotalNetworkChargesLabel" Text="EvaluateFormula(&quot;= \&quot;Total Network/Line Charges\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="TotalNetworkCharges" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="TotalNetworkChargesRequiredFieldValidator" ControlToValidate="TotalNetworkCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Total Network/Line Charges\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TotalNetworkChargesTextBoxMaxLengthValidator" ControlToValidate="TotalNetworkCharges" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Total Network/Line Charges\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="YearLabel" Text="Year">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><asp:TextBox runat="server" id="Year" MaxLength="1073741823" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="YearTextBoxMaxLengthValidator" ControlToValidate="Year" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></IDE:InvoiceSummariesTableControlRow>
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
                