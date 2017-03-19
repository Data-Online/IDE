<%@ Register Tagprefix="IDE" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Add_InvoiceSummaries_Meridian" Assembly="IDE" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Add-InvoiceSummaries-Meridian.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Add_InvoiceSummaries_Meridian" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Invoice Summaries&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="InvoiceSummariesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:label id="CompanyType" runat="server" text="Meridian Energy Template"></asp:label></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="SupplierIdLabel" Text="Supplier">	</asp:Literal></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="SupplierId" redirecturl=""></BaseClasses:QuickSelector></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceTotalLabel" Text="Invoice Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellValue"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ConnectionNumber" Columns="30" MaxLength="30" cssclass="field_input" visible="False"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="ConnectionNumberRequiredFieldValidator" ControlToValidate="ConnectionNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Connection Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ConnectionNumberTextBoxMaxLengthValidator" ControlToValidate="ConnectionNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Connection Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDueDateLabel" Text="Invoice Due Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellValue"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CustomerNumberLabel" Text="Customer Number" visible="False">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="CustomerNumber" Columns="12" MaxLength="12" cssclass="field_input" visible="False"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="CustomerNumberRequiredFieldValidator" ControlToValidate="CustomerNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CustomerNumberTextBoxMaxLengthValidator" ControlToValidate="CustomerNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Customer Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="GstTotalLabel" Text="GST Total">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceDateLabel" Text="Invoice Date">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
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
</td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="AccountNumberLabel" Text="Account Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="AccountNumber" Columns="12" MaxLength="12" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="AccountNumberRequiredFieldValidator" ControlToValidate="AccountNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Account Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AccountNumberTextBoxMaxLengthValidator" ControlToValidate="AccountNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Account Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellValue"></td><td class="tableCellLabel"></td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
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
</td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="InvoiceNumberLabel" Text="Invoice Number">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="InvoiceNumber" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="InvoiceNumberRequiredFieldValidator" ControlToValidate="InvoiceNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="InvoiceNumberTextBoxMaxLengthValidator" ControlToValidate="InvoiceNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
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
</td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="SiteIdLabel" Text="Site" visible="True">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="SiteId" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="True"></asp:DropDownList></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="ConnectionNumberLabel" Text="Connection Number">	</asp:Literal></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="EnergyPointId" redirecturl=""></BaseClasses:QuickSelector></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="KWhTotalLabel" Text="EvaluateFormula(&quot;= \&quot;kWh Total\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
</td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"><asp:Literal runat="server" id="PeriodStartLabel" Text="Period Start">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="PeriodStart" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
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
<asp:TextBox runat="server" id="PeriodEnd" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="PeriodEndCalendarExtender" TargetControlID="PeriodEnd" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PeriodEndTextBoxMaxLengthValidator" ControlToValidate="PeriodEnd" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Period End&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr></table></asp:panel>
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
</td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<BaseClasses:TabContainer runat="server" id="TabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="EnergyCharges">	<ContentTemplate> 
  <IDE:EnergyChargesRecordControl runat="server" id="EnergyChargesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title2" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Energy Charges&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="EnergyChargesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel" colspan="4" style="text-align:center;font-weight:bold;color:#0080FF;">Non Business Day</td></tr><tr><td class="tableCellLabel" colspan="2" style="text-align:center;font-weight:bold;">Rate</td><td class="tableCellLabel" colspan="2" style="text-align:center;font-weight:bold;">Amount</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0004R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0004R1TextBoxMaxLengthValidator" ControlToValidate="NBD0004R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Non Business Day 0004 Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408Label1" Text="EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0408R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0408R1TextBoxMaxLengthValidator" ControlToValidate="NBD0408R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD0408R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD04081" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD04081RequiredFieldValidator" ControlToValidate="NBD04081" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD04081TextBoxMaxLengthValidator" ControlToValidate="NBD04081" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812Label1" Text="EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD0812R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD0812R1TextBoxMaxLengthValidator" ControlToValidate="NBD0812R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD0812R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD08121" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD08121RequiredFieldValidator" ControlToValidate="NBD08121" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD08121TextBoxMaxLengthValidator" ControlToValidate="NBD08121" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216Label1" Text="EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD1216R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD1216R1TextBoxMaxLengthValidator" ControlToValidate="NBD1216R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD1216R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD12161" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD12161RequiredFieldValidator" ControlToValidate="NBD12161" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD12161TextBoxMaxLengthValidator" ControlToValidate="NBD12161" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620Label1" Text="EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD1620R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD1620R1TextBoxMaxLengthValidator" ControlToValidate="NBD1620R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD1620R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD16201" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD16201RequiredFieldValidator" ControlToValidate="NBD16201" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD16201TextBoxMaxLengthValidator" ControlToValidate="NBD16201" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024Label1" Text="EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD2024R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD2024R1TextBoxMaxLengthValidator" ControlToValidate="NBD2024R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;NBD2024R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBD20241" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBD20241RequiredFieldValidator" ControlToValidate="NBD20241" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBD20241TextBoxMaxLengthValidator" ControlToValidate="NBD20241" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" colspan="4" style="text-align:center;font-weight:bold;color:#0080FF;">Business Day</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BDQ0004Label1" Text="EvaluateFormula(&quot;= \&quot;Quantity 00:00 - 00:04\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BDQ00041" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BDQ00041TextBoxMaxLengthValidator" ControlToValidate="BDQ00041" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Quantity 00:00 - 00:04\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BDL0004Label1" Text="EvaluateFormula(&quot;= \&quot;Losses 00:00 - 00:04\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BDL00041" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BDL00041TextBoxMaxLengthValidator" ControlToValidate="BDL00041" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Losses 00:00 - 00:04\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" colspan="2" style="text-align:center;font-weight:bold;">Rate</td><td class="tableCellLabel" colspan="2" style="text-align:center;font-weight:bold;">Amount</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004Label1" Text="EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0004R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0004R1TextBoxMaxLengthValidator" ControlToValidate="BD0004R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Busness Day 0004 Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD00041" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD00041RequiredFieldValidator" ControlToValidate="BD00041" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD00041TextBoxMaxLengthValidator" ControlToValidate="BD00041" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408Label1" Text="EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0408R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0408R1TextBoxMaxLengthValidator" ControlToValidate="BD0408R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD0408R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD04081" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD04081RequiredFieldValidator" ControlToValidate="BD04081" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD04081TextBoxMaxLengthValidator" ControlToValidate="BD04081" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812Label1" Text="EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD0812R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD0812R1TextBoxMaxLengthValidator" ControlToValidate="BD0812R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD0812R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD08121" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD08121RequiredFieldValidator" ControlToValidate="BD08121" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD08121TextBoxMaxLengthValidator" ControlToValidate="BD08121" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216Label1" Text="EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD1216R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD1216R1TextBoxMaxLengthValidator" ControlToValidate="BD1216R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD1216R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD12161" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD12161RequiredFieldValidator" ControlToValidate="BD12161" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD12161TextBoxMaxLengthValidator" ControlToValidate="BD12161" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620Label1" Text="EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD1620R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD1620R1TextBoxMaxLengthValidator" ControlToValidate="BD1620R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD1620R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD16201" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD16201RequiredFieldValidator" ControlToValidate="BD16201" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD16201TextBoxMaxLengthValidator" ControlToValidate="BD16201" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024Label1" Text="EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD2024R1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD2024R1TextBoxMaxLengthValidator" ControlToValidate="BD2024R1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;BD2024R&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BD20241" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BD20241RequiredFieldValidator" ControlToValidate="BD20241" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BD20241TextBoxMaxLengthValidator" ControlToValidate="BD20241" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="EnergyChargesRecordControl_PostbackTracker" runat="server" />
</IDE:EnergyChargesRecordControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="NetworkCharges">	<ContentTemplate> 
  <IDE:NetworkChargesRecordControl runat="server" id="NetworkChargesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title3" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Network Charges&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion5" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="NetworkChargesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;" colspan="2">Network Charges Variable</td><td class="tableCellLabel" style="text-align:center;"></td><td class="tableCellLabel" style="text-align:center;font-weight:bold;color:#0080FF;" colspan="2">Network Charges Fixed</td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="VariableNBDLabel1" Text="EvaluateFormula(&quot;= \&quot;Variable Charge Non Business / Weekend\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="VariableNBD1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="VariableNBD1RequiredFieldValidator" ControlToValidate="VariableNBD1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Variable Charge Non Business / Weekend\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="VariableNBD1TextBoxMaxLengthValidator" ControlToValidate="VariableNBD1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Variable Charge Non Business / Weekend\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="CapacityChargeLabel1" Text="Capacity Charge">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CapacityCharge1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="CapacityCharge1RequiredFieldValidator" ControlToValidate="CapacityCharge1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Capacity Charge&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CapacityCharge1TextBoxMaxLengthValidator" ControlToValidate="CapacityCharge1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Capacity Charge&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="VariableBDLabel1" Text="EvaluateFormula(&quot;= \&quot;Variable Charge Business/Weekday\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="VariableBD1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="VariableBD1TextBoxMaxLengthValidator" ControlToValidate="VariableBD1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Variable Charge Business/Weekday\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="DemandChargeLabel1" Text="Demand Charge">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="DemandCharge1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="DemandCharge1RequiredFieldValidator" ControlToValidate="DemandCharge1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Demand Charge&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DemandCharge1TextBoxMaxLengthValidator" ControlToValidate="DemandCharge1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Demand Charge&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellLabel"><asp:Literal runat="server" id="FixedChargeLabel1" Text="Fixed Charge">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FixedCharge1" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FixedCharge1TextBoxMaxLengthValidator" ControlToValidate="FixedCharge1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fixed Charge&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="NetworkChargesRecordControl_PostbackTracker" runat="server" />
</IDE:NetworkChargesRecordControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel2" HeaderText="OtherCharges">	<ContentTemplate> 
  <IDE:OtherChargesRecordControl runat="server" id="OtherChargesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Other Charges&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="OtherChargesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel" colspan="2" style="color:#0080FF;text-align:center;"><asp:literal id="Literal4" runat="server" text="Rate"></asp:literal></td><td class="tableCellLabel" colspan="2" style="color:#0080FF;text-align:center;"><asp:literal id="Literal3" runat="server" text="Charge"></asp:literal></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BDSVCLabel" Text="EvaluateFormula(&quot;= \&quot;Energy Service Charge Business Day (Weekday)\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BDSVCR" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BDSVCRRequiredFieldValidator" ControlToValidate="BDSVCR" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Business Day (Weekday) Service Rate\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BDSVCRTextBoxMaxLengthValidator" ControlToValidate="BDSVCR" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Business Day (Weekday) Service Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="BDSVC" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="BDSVCRequiredFieldValidator" ControlToValidate="BDSVC" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Energy Service Charge Business Day (Weekday)\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BDSVCTextBoxMaxLengthValidator" ControlToValidate="BDSVC" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Energy Service Charge Business Day (Weekday)\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="AdminChargeLabel" Text="EvaluateFormula(&quot;= \&quot;Other Charges Total\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBDSVCLabel" Text="EvaluateFormula(&quot;= \&quot;Energy Service Charge NON Business Day (Weekend)\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBDSVCR" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBDSVCRRequiredFieldValidator" ControlToValidate="NBDSVCR" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Non Business Day (Weekend) Service Rate\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBDSVCRTextBoxMaxLengthValidator" ControlToValidate="NBDSVCR" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Non Business Day (Weekend) Service Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="NBDSVC" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="NBDSVCRequiredFieldValidator" ControlToValidate="NBDSVC" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Energy Service Charge NON Business Day (Weekend)\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NBDSVCTextBoxMaxLengthValidator" ControlToValidate="NBDSVC" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Energy Service Charge NON Business Day (Weekend)\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="EALevyRLabel" Text="EvaluateFormula(&quot;= \&quot;Electricity Authority Rate / EA Levy Rate\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="EALevyR" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="EALevyRRequiredFieldValidator" ControlToValidate="EALevyR" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Rate / EA Levy Rate\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EALevyRTextBoxMaxLengthValidator" ControlToValidate="EALevyR" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Rate / EA Levy Rate\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="EALevy" Columns="19" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="EALevyRequiredFieldValidator" ControlToValidate="EALevy" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Charge / EA Levy\&quot;&quot;, true)) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EALevyTextBoxMaxLengthValidator" ControlToValidate="EALevy" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IDE&quot;).Replace(&quot;{FieldName}&quot;, EvaluateFormula(&quot;= \&quot;Electricity Authority Charge / EA Levy\&quot;&quot;, true)) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellLabel"></td><td class="tableCellLabel"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="OtherChargesRecordControl_PostbackTracker" runat="server" />
</IDE:OtherChargesRecordControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0" class="pageButtonsContainer"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td><IDE:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;IDE&quot;) %>" postback="True"></IDE:ThemeButton></td><td><IDE:ThemeButton runat="server" id="SaveAndNewButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;IDE&quot;) %>" postback="True"></IDE:ThemeButton></td><td><IDE:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;IDE&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;IDE&quot;) %>" postback="False"></IDE:ThemeButton></td></tr></table>
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
                