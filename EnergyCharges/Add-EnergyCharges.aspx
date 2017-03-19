<%@ Register Tagprefix="IDE" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IDE" Assembly="IDE" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="IDE" Namespace="IDE.UI.Controls.Add_EnergyCharges" Assembly="IDE" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Add-EnergyCharges.aspx.cs" Culture="en-GB" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IDE.UI.Add_EnergyCharges" %>
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

                        <IDE:EnergyChargesRecordControl runat="server" id="EnergyChargesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot;&quot;,&quot; Energy Charges&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="EnergyChargesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tableCellLabel"><asp:Literal runat="server" id="EnergyChargeIdLabel" Text="Energy Charge">	</asp:Literal></td><td class="tableCellValue"><BaseClasses:QuickSelector runat="server" id="EnergyChargeId" redirecturl=""></BaseClasses:QuickSelector> </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0000 - 0400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0004RLabel" Text="EvaluateFormula(&quot;= \&quot;Busness Day 0004 Rate\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0400 - 0800\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0408RLabel" Text="BD0408R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 0800 - 1200\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD0812RLabel" Text="BD0812R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1200 - 1600\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1216RLabel" Text="BD1216R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 1600 - 2000\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD1620RLabel" Text="BD1620R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekday 2000 - 2400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BD2024RLabel" Text="BD2024R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"> </td><td class="tableCellLabel"></td><td class="tableCellValue"> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0000 - 0400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0004RLabel" Text="EvaluateFormula(&quot;= \&quot;Non Business Day 0004 Rate\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0400 - 0800\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0408RLabel" Text="NBD0408R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 0800 - 1200\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD0812RLabel" Text="NBD0812R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1200 - 1600\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1216RLabel" Text="NBD1216R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 1600 - 2000\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD1620RLabel" Text="NBD1620R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024Label" Text="EvaluateFormula(&quot;= \&quot;Weekend 2000 - 2400\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="NBD2024RLabel" Text="NBD2024R">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
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
                