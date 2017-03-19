<%@ Register Tagprefix="IDE" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Edit-InvoiceSummaries-Contact.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Edit_InvoiceSummaries_Contact" %>
<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Edit_InvoiceSummaries_Contact" Assembly="IDE" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <IDE:InvoiceSummariesRecordControl runat="server" id="InvoiceSummariesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot;&quot;,&quot; Invoice Summaries&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="InvoiceSummariesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel" style="text-align:left;color:Green;">Container/File Name</td><td class="tableCellLabel" style="text-align:left;color:Green;font-weight:bold;"><asp:Literal runat="server" id="ContainerId" Text="MyLiteral">	</asp:Literal> / 
<asp:Literal runat="server" id="PdfFileName" Text="MyLiteral">	</asp:Literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:label id="CompanyType" runat="server" text="Contact Energy Template"></asp:label></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="SupplierIdLabel" Text="Supplier">	</asp:Literal></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="SupplierId" redirecturl=""></BaseClasses:QuickSelector></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="PeriodStartLabel" Text="Period Start">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="PeriodStart" Columns="20" MaxLength="30" cssclass="field_input" dataformat="d"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="PeriodStartCalendarExtender" TargetControlID="PeriodStart" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PeriodStartTextBoxMaxLengthValidator" ControlToValidate="PeriodStart" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Period Start&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellLabel"><asp:Literal runat="server" id="PeriodEndLabel" Text="Period End">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="PeriodEnd" Columns="20" MaxLength="30" cssclass="field_input" dataformat="d"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="PeriodEndCalendarExtender" TargetControlID="PeriodEnd" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PeriodEndTextBoxMaxLengthValidator" ControlToValidate="PeriodEnd" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Period End&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NetworkChargesTotalLabel" Text="Line Charges Total" visible="False">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NetworkChargesTotal" Columns="19" MaxLength="20" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NetworkChargesTotalRequiredFieldValidator" ControlToValidate="NetworkChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Network Charges Total&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NetworkChargesTotalTextBoxMaxLengthValidator" ControlToValidate="NetworkChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Network Charges Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceNumberLabel" Text="Invoice Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="InvoiceNumber" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="InvoiceNumberRequiredFieldValidator" ControlToValidate="InvoiceNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="InvoiceNumberTextBoxMaxLengthValidator" ControlToValidate="InvoiceNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" style="color:Red;text-align:left;" rowspan="6" colspan="2"><asp:literal id="Alert" runat="server" text="AlertZZZ"></asp:literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyChargesTotalLabel" Text="Energy Charges Total" visible="False">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="EnergyChargesTotal" Columns="19" MaxLength="20" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="EnergyChargesTotalRequiredFieldValidator" ControlToValidate="EnergyChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Energy Charges Total&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EnergyChargesTotalTextBoxMaxLengthValidator" ControlToValidate="EnergyChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Energy Charges Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDateLabel" Text="Invoice Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="MiscChargesTotalLabel" Text="EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)" visible="False">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="MiscChargesTotal" Columns="19" MaxLength="20" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="MiscChargesTotalRequiredFieldValidator" ControlToValidate="MiscChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="MiscChargesTotalTextBoxMaxLengthValidator" ControlToValidate="MiscChargesTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDueDateLabel" Text="Invoice Due Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel" colspan="2"><asp:literal id="Literal" runat="server" text="(default 20th of month following inv date)"></asp:literal></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="AccountNumberLabel" Text="Account Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="AccountNumber" Columns="12" MaxLength="12" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="AccountNumberRequiredFieldValidator" ControlToValidate="AccountNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Account Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AccountNumberTextBoxMaxLengthValidator" ControlToValidate="AccountNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Account Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="GstTotalLabel" Text="GST Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
</td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceTotalLabel" Text="Total current charges">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue" style="color:Red"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="SiteIdLabel" Text="Site" visible="True">	</asp:Literal></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="SiteId" redirecturl="" visible="True"></BaseClasses:QuickSelector> </td><td class="tableCellLabel"><asp:Literal runat="server" id="ConnectionNumberLabel" Text="Connection point number">	</asp:Literal></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="EnergyPointId" redirecturl=""></BaseClasses:QuickSelector></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="CustomerNumberLabel" Text="Customer Number" visible="False">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustomerNumber" Columns="12" MaxLength="12" cssclass="field_input" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustomerNumberTextBoxMaxLengthValidator" ControlToValidate="CustomerNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="KWhTotalLabel" Text="EvaluateFormula(&quot;= \&quot;kWh Total\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="KWhTotal" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="KWhTotalTextBoxMaxLengthValidator" ControlToValidate="KWhTotal" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;kWh Total\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" colspan="2"><asp:literal id="Literal1" runat="server" text="(refer energy charges)"></asp:literal></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="InvoiceSummariesRecordControl_PostbackTracker" runat="server" />
</IDE:InvoiceSummariesRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td><BaseClasses:TabContainer runat="server" id="TabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
  
<BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Line Charges">	<ContentTemplate> 
  <IDE:NetworkChargesTableControl runat="server" id="NetworkChargesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="Actions1Div" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="AddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src=&#39;../Images/ButtonBarDelete.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarDeleteOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IDE:ThemeButtonWithArrow runat="server" id="Actions1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Actions1Div&#39;,&#39;Actions1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IDE:ThemeButtonWithArrow runat="server" id="Filters1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters1Div&#39;,&#39;Filters1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="Filters1Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel1" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;IDE&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort1" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="NetworkChargesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="2"><asp:CheckBox runat="server" id="ToggleAll1" onclick="toggleAllCheckboxes(this);" visible="False">	</asp:CheckBox></th><th class="thcnb">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="NetworkChargesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:NetworkChargesTableControlRow runat="server" id="NetworkChargesTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="4" colspan="2">
                              <asp:CheckBox runat="server" id="SelectRow1" onclick="moveToThisTableRow(this);" visible="False">	</asp:CheckBox>                              
                            </td><td class="tableRowButtonsCellVertical" rowspan="4">
                          <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                        
                          <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                        </td><td class="tableCellLabel"><asp:Literal runat="server" id="DemandChargeLabel" Text="Demand Charge">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="DemandCharge" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="DemandChargeRequiredFieldValidator" ControlToValidate="DemandCharge" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Demand Charge&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DemandChargeTextBoxMaxLengthValidator" ControlToValidate="DemandCharge" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Demand Charge&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CapacityChargeLabel" Text="Capacity Charge">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CapacityCharge" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="CapacityChargeRequiredFieldValidator" ControlToValidate="CapacityCharge" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Capacity Charge&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CapacityChargeTextBoxMaxLengthValidator" ControlToValidate="CapacityCharge" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Capacity Charge&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="FixedChargeLabel" Text="Fixed Charge">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FixedCharge" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="FixedChargeRequiredFieldValidator" ControlToValidate="FixedCharge" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fixed Charge&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FixedChargeTextBoxMaxLengthValidator" ControlToValidate="FixedCharge" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fixed Charge&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="VariableBDLabel" Text="Variable Line Charge">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="VariableBD" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="VariableBDRequiredFieldValidator" ControlToValidate="VariableBD" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Variable Charge Business/Weekday\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="VariableBDTextBoxMaxLengthValidator" ControlToValidate="VariableBD" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Variable Charge Business/Weekday\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical"></td><td class="tableCellLabel" style="font-weight:bold"><asp:label id="Total" runat="server" text="Total"></asp:label></td><td class="tableCellValue" style="font-weight:bold"><asp:literal id="LineChargeSum" runat="server" text="Text for literal goes here"></asp:literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="7"></td></tr></IDE:NetworkChargesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="NetworkChargesTableControl_PostbackTracker" runat="server" />
</IDE:NetworkChargesTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Energy Charges">	<ContentTemplate> 
  <IDE:EnergyChargesTableControl runat="server" id="EnergyChargesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="Actions2Div" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="AddButton1" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DeleteButton1" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src=&#39;../Images/ButtonBarDelete.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarDeleteOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;IDE&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IDE:ThemeButtonWithArrow runat="server" id="Actions2Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Actions2Div&#39;,&#39;Actions2Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IDE:ThemeButtonWithArrow runat="server" id="Filters2Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters2Div&#39;,&#39;Filters2Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IDE&quot;) %>"></IDE:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="Filters2Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel2" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;IDE&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="OrderSort2" autopostback="True" cssclass="Filter_Input" priorityno="2">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="EnergyChargesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="2"><asp:CheckBox runat="server" id="ToggleAll2" onclick="toggleAllCheckboxes(this);" visible="False">	</asp:CheckBox></th><th class="thcnb">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc"></th></tr><asp:Repeater runat="server" id="EnergyChargesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:EnergyChargesTableControlRow runat="server" id="EnergyChargesTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical"></td><td class="tableCellLabel" colspan="4" style="text-align:center;font-weight:bold;color:#0080FF;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;"></td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical"></td><td class="tableCellLabel" colspan="5" style="text-align:center;font-weight:bold;color:#0080FF;">Business Day (Weekday)</td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="20" colspan="2">
                              <asp:CheckBox runat="server" id="SelectRow2" onclick="moveToThisTableRow(this);" visible="False">	</asp:CheckBox>                              
                            </td><td class="tableRowButtonsCellVertical" rowspan="20">
                          <asp:ImageButton runat="server" id="EditRowButton1" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                        
                          <asp:ImageButton runat="server" id="DeleteRowButton1" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                        </td><td class="tableCellLabel" style="text-align:center;font-weight:bold;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;">kWh</td><td class="tableCellLabel" style="text-align:center;font-weight:bold;">kWh Losses</td><td class="tableCellLabel" style="text-align:center;font-weight:bold;">Rate</td><td class="tableCellLabel" style="text-align:center;font-weight:bold;">Amount</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BDQ0004" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BDQ0004TextBoxMaxLengthValidator" ControlToValidate="BDQ0004" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Quantity 00:00 - 00:04\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BDL0004" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BDL0004TextBoxMaxLengthValidator" ControlToValidate="BDL0004" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Losses 00:00 - 00:04\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0004R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0004RTextBoxMaxLengthValidator" ControlToValidate="BD0004R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Busness Day 0004 Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0004" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD0004RequiredFieldValidator" ControlToValidate="BD0004" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0004TextBoxMaxLengthValidator" ControlToValidate="BD0004" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0408R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0408RTextBoxMaxLengthValidator" ControlToValidate="BD0408R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD0408R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0408" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD0408RequiredFieldValidator" ControlToValidate="BD0408" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0408TextBoxMaxLengthValidator" ControlToValidate="BD0408" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0812R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0812RTextBoxMaxLengthValidator" ControlToValidate="BD0812R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD0812R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0812" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD0812RequiredFieldValidator" ControlToValidate="BD0812" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0812TextBoxMaxLengthValidator" ControlToValidate="BD0812" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD1216R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD1216RTextBoxMaxLengthValidator" ControlToValidate="BD1216R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD1216R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD1216" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD1216RequiredFieldValidator" ControlToValidate="BD1216" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD1216TextBoxMaxLengthValidator" ControlToValidate="BD1216" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD1620R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD1620RTextBoxMaxLengthValidator" ControlToValidate="BD1620R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD1620R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD1620" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD1620RequiredFieldValidator" ControlToValidate="BD1620" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD1620TextBoxMaxLengthValidator" ControlToValidate="BD1620" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD2024R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD2024RTextBoxMaxLengthValidator" ControlToValidate="BD2024R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD2024R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD2024" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD2024RequiredFieldValidator" ControlToValidate="BD2024" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD2024TextBoxMaxLengthValidator" ControlToValidate="BD2024" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;"></td><td class="tableCellLabel" style="font-weight:bold"><asp:label id="Total1" runat="server" text="Total"></asp:label></td><td class="tableCellLabel" style="text-align:left;"><asp:literal id="Literal5" runat="server" text="Text for literal goes here"></asp:literal></td></tr><tr><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;" colspan="4">Non Business Day/Weekend</td><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;"></td></tr><tr><td class="tableCellLabel" style="text-align:center;font-weight:bold;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;">Rate</td><td class="tableCellLabel" style="text-align:center;font-weight:bold;">Amount</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0004R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0004RTextBoxMaxLengthValidator" ControlToValidate="NBD0004R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Non Business Day 0004 Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0004" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD0004RequiredFieldValidator" ControlToValidate="NBD0004" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0004TextBoxMaxLengthValidator" ControlToValidate="NBD0004" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0408R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0408RTextBoxMaxLengthValidator" ControlToValidate="NBD0408R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD0408R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0408" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD0408RequiredFieldValidator" ControlToValidate="NBD0408" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0408TextBoxMaxLengthValidator" ControlToValidate="NBD0408" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0812R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0812RTextBoxMaxLengthValidator" ControlToValidate="NBD0812R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD0812R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0812" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD0812RequiredFieldValidator" ControlToValidate="NBD0812" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0812TextBoxMaxLengthValidator" ControlToValidate="NBD0812" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD1216R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD1216RTextBoxMaxLengthValidator" ControlToValidate="NBD1216R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD1216R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD1216" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD1216RequiredFieldValidator" ControlToValidate="NBD1216" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD1216TextBoxMaxLengthValidator" ControlToValidate="NBD1216" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD1620R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD1620RTextBoxMaxLengthValidator" ControlToValidate="NBD1620R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD1620R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD1620" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD1620RequiredFieldValidator" ControlToValidate="NBD1620" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD1620TextBoxMaxLengthValidator" ControlToValidate="NBD1620" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD2024R" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD2024RTextBoxMaxLengthValidator" ControlToValidate="NBD2024R" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD2024R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD2024" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD2024RequiredFieldValidator" ControlToValidate="NBD2024" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD2024TextBoxMaxLengthValidator" ControlToValidate="NBD2024" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellLabel" style="font-weight:bold"><asp:label id="Total2" runat="server" text="Total"></asp:label></td><td class="tableCellValue" style="text-align:left;"><asp:literal id="Literal6" runat="server" text="Text for literal goes here"></asp:literal></td></tr><tr><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td></tr><tr><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"><asp:literal id="Literal2" runat="server" text="Refer to top panel to enter kWh total"></asp:literal></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="font-weight:bold"><asp:label id="Total4" runat="server" text="Page Total"></asp:label></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;"><asp:literal id="Literal8" runat="server" text="Text for literal goes here"></asp:literal></td></tr><tr><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td><td class="tableCellLabel" style="text-align:left;font-weight:bold;color:#00FF40;"></td></tr><tr><td class="tableRowDivider" colspan="7"></td><td class="tableRowDivider"></td></tr></IDE:EnergyChargesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination1"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="EnergyChargesTableControl_PostbackTracker" runat="server" />
</IDE:EnergyChargesTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
  
 <BaseClasses:TabPanel runat="server" id="TabPanel2" HeaderText="Other Data">	<ContentTemplate> 
  <IDE:OtherChargesTableControl runat="server" id="OtherChargesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(&quot;Other Charges&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="OtherChargesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="3"><asp:CheckBox runat="server" id="ToggleAll" onclick="toggleAllCheckboxes(this);" visible="False">	</asp:CheckBox></th><th class="thcnb"></th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="OtherChargesTableControlRepeater">		<ITEMTEMPLATE>		<IDE:OtherChargesTableControlRow runat="server" id="OtherChargesTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableRowButtonsCellVertical"></td><td class="tableCellLabel" style="color:#0080FF;text-align:center;"></td><td class="tableCellLabel" style="color:#0080FF;text-align:left;"><asp:literal id="Literal4" runat="server" text="Rate"></asp:literal></td><td class="tableCellLabel" style="color:#0080FF;text-align:center;"></td><td class="tableCellLabel" style="color:#0080FF;text-align:left;"><asp:literal id="Literal3" runat="server" text="Charge"></asp:literal></td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="5" colspan="3">
                              <asp:CheckBox runat="server" id="SelectRow" onclick="moveToThisTableRow(this);" visible="False">	</asp:CheckBox>                              
                            </td><td class="tableRowButtonsCellVertical" rowspan="5">
                          <asp:ImageButton runat="server" id="ViewRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                        
                          <asp:ImageButton runat="server" id="EditRowButton2" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                        
                          <asp:ImageButton runat="server" id="DeleteRowButton2" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IDE&quot;) %>" visible="False">		
	</asp:ImageButton>
                        </td><td class="tableCellLabel"><asp:Literal runat="server" id="AdminChargeLabel" Text="Administration Charge">	</asp:Literal></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="AdminCharge" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AdminChargeTextBoxMaxLengthValidator" ControlToValidate="AdminCharge" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="EALevyRLabel1" Text="EvaluateFormula(&quot;= \&quot;Electricity Authority Rate / EA Levy Rate\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="EALevyR1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="EALevyR1RequiredFieldValidator" ControlToValidate="EALevyR1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Rate / EA Levy Rate\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EALevyR1TextBoxMaxLengthValidator" ControlToValidate="EALevyR1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Rate / EA Levy Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="EALevy1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="EALevy1RequiredFieldValidator" ControlToValidate="EALevy1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Charge / EA Levy\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EALevy1TextBoxMaxLengthValidator" ControlToValidate="EALevy1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Charge / EA Levy\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel" style="font-weight:bold"><asp:label id="Total3" runat="server" text="Total"></asp:label></td><td class="tableCellValue"><asp:literal id="Literal7" runat="server" text="Text for literal goes here"></asp:literal></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></IDE:OtherChargesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IDE:PaginationModern runat="server" id="Pagination2"></IDE:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="OtherChargesTableControl_PostbackTracker" runat="server" />
</IDE:OtherChargesTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><IDE:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;IDE&quot;) %>" postback="True"></IDE:ThemeButton></td><td><IDE:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td></tr></table>
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
                