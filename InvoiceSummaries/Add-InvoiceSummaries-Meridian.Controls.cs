
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Add_InvoiceSummaries_Meridian.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;

        
using IDE.Business;
using IDE.Data;
using IDE.UI;
using IDE;
		

#endregion

  
namespace IDE.UI.Controls.Add_InvoiceSummaries_Meridian
{
  

#region "Section 1: Place your customizations here."

    
//public class EnergyChargesTableControlRow : BaseEnergyChargesTableControlRow
//{
//      
//        // The BaseEnergyChargesTableControlRow implements code for a ROW within the
//        // the EnergyChargesTableControl table.  The BaseEnergyChargesTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of EnergyChargesTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class EnergyChargesTableControl : BaseEnergyChargesTableControl
//{
//    // The BaseEnergyChargesTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The EnergyChargesTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//

  
//public class NetworkChargesTableControlRow : BaseNetworkChargesTableControlRow
//{
//      
//        // The BaseNetworkChargesTableControlRow implements code for a ROW within the
//        // the NetworkChargesTableControl table.  The BaseNetworkChargesTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of NetworkChargesTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//}
//

  

//public class NetworkChargesTableControl : BaseNetworkChargesTableControl
//{
//    // The BaseNetworkChargesTableControl class implements the LoadData, DataBind, CreateWhereClause
//    // and other methods to load and display the data in a table control.
//
//    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//    // The NetworkChargesTableControlRow class offers another place where you can customize
//    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//    
//}
//

  
public class InvoiceSummariesRecordControl : BaseInvoiceSummariesRecordControl
{
public InvoiceSummariesRecordControl()
{
#region "Code Customization"

    // The following line will be inserted inside the
    // constructor for page class.
    this.Init += new EventHandler(MultipleDropdown_MyInit);
    
#endregion
}
      
        // The BaseInvoiceSummariesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

    //public override void Validate()
    //{
    //    // Add custom validation for any control within this panel.
    //    // Example.  If you have a State ASP:Textbox control
    //    // if (this.State.Text != "CA")
    //    //    throw new Exception("State must be CA (California).");
    //    // The Validate method is common across all controls within
    //    // this panel so you can validate multiple fields, but report
    //    // one error message.

    //    string validationFormula = "";
    //    string fullValidationMessage = "";
    //    string validationMessage = "";

    //    // Validate InvoiceDate Control
    //    validationMessage = EvaluateFormula("IF(ParseDate(InvoiceSummariesRecordControl.InvoiceDate.Text) <= ParseDate(InvoiceSummariesRecordControl.PeriodEnd.Text), \"Error: Invoice date before billing period\", \"\")", this.DataSource);
    //    if (validationMessage != "" && validationMessage.ToLower() != "true")
    //        fullValidationMessage += validationMessage + "\r\n";

    //    // Validate InvoiceDueDate Control
    //    validationMessage = EvaluateFormula("IF(ParseDate(InvoiceSummariesRecordControl.InvoiceDueDate.Text) < ParseDate(InvoiceSummariesRecordControl.InvoiceDate.Text), \"Error: Invoice Due Date before Invoice Date\", \"\")", this.DataSource);
    //    if (validationMessage != "" && validationMessage.ToLower() != "true")
    //        fullValidationMessage += validationMessage + "\r\n";

    //    // Validate InvoiceTotal Control
    //    validationFormula = "IF(ParseDecimal(InvoiceSummariesRecordControl.InvoiceTotal.Text)";
    //    validationFormula += " <> (ParseDecimal(InvoiceSummariesRecordControl.EnergyChargesTotal.Text)";
    //    validationFormula += " +   ParseDecimal(InvoiceSummariesRecordControl.MiscChargesTotal.Text)";
    //    validationFormula += " +   ParseDecimal(InvoiceSummariesRecordControl.NetworkChargesTotal.Text)";
    //    validationFormula += " +   ParseDecimal(InvoiceSummariesRecordControl,GstTotal.Text))";
    //    validationFormula += ", \"Error: Bill charges do not sum correctly, please check values.\", \"\")";
    //    validationMessage = EvaluateFormula(validationFormula, this.DataSource);
    //    if (validationMessage != "" && validationMessage.ToLower() != "true")
    //        fullValidationMessage += validationMessage + "\r\n";

    //    // Validate PeriodEnd Control
    //    validationMessage = EvaluateFormula("IF(ParseDate(InvoiceSummariesRecordControl.PeriodEnd.Text) <= ParseDate(InvoiceSummariesRecordControl.PeriodStart.Text), \"Error: Period End Date before Period Start\", \"\")", this.DataSource);
    //    if (validationMessage != "" && validationMessage.ToLower() != "true")
    //        fullValidationMessage += validationMessage + "\r\n";

    //    if (fullValidationMessage != "")
    //        throw new Exception(fullValidationMessage);



    //}       

		public override void SetSupplierId()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the SupplierId QuickSelector on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.
            
            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SupplierId is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetSupplierId();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.SupplierId.ToString();
                
            }
            else
            {
                
            
                selectedValue = "2"; //EvaluateFormula("URL(\"SupplierId\")");
                
            }

            
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.SupplierId, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.SupplierId.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.SupplierId, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.SupplierId, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseCimscoPortal%dbo.EnergySuppliers.SupplierId = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(EnergySuppliersTable.SupplierId, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    EnergySuppliersRecord[] rc = EnergySuppliersTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        EnergySuppliersRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.SupplierIdSpecified)
                            cvalue = itemValue.SupplierId.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SupplierId);
                        if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.SupplierId.IsApplyDisplayAs)
                            fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.SupplierId);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(EnergySuppliersTable.SupplierName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.SupplierId, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../EnergySuppliers/EnergySuppliers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.SupplierId.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("SupplierName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("SupplierId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.SupplierId.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(SupplierId.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }

#region "Code Customization"

/// <summary>
/// This method sets the AutoPostBack property of the field that triggers a change.
/// </summary>
/// <param name="sender">The object that raised the init event.</param>
/// <param name="e">The object that contains the event data of the init event.</param>
private void MultipleDropdown_MyInit(object sender, System.EventArgs e) 
{   
	// AutoPostBack sets or retrieves a value that indicates whether or not the control
	// posts back to the server each time a user interacts with the control. 
	// if change in second drop down list updates the first then set
	// AutoPostback of the second dropdown list to true and implement 
	EnergyPointId.AutoPostBack = true;
	SiteId.AutoPostBack = true;
    

    // Define selected index changed event handlers
    // for first Dropdown list.
    this.EnergyPointId.SelectedIndexChanged += 
    new EventHandler(EnergyPointId_SelectedIndexChanged);
    
    SiteId.Enabled = false;
}

#endregion

#region "Code Customization"

/// <summary>
/// This method is called when selected index changes in EnergyPointId.
/// </summary>
protected override void EnergyPointId_SelectedIndexChanged(object sender, System.EventArgs e) 
{ 
    SiteId.Enabled = true;   

    // SiteId DropDownList will display 100 items.
    // You can set the number of items displayed in the DropDownList.
    this.PopulateSiteIdDropDown(100);    
} 
    
#endregion

#region "Code Customization"

/// <summary>
/// Override this method to filter the  SiteIdDropDownList
/// based on the value selected for the EnergyPointIdDropDownList
/// </summary>
protected void PopulateSiteIdDropDown(int maxItems)
{
    // Set up the WHERE clause.
    // Create the WHERE clause to filter the second dropdown list based on the 
    // selected value in the first dropdown list.
    WhereClause wc = new WhereClause();
    string selectedValue = EnergyPointId.SelectedValue;  
    string selectedText = EnergyPointId.SelectedItem.Text;   
    wc.iAND(InvoiceSummariesTable.EnergyPointId, BaseFilter.ComparisonOperator.EqualsTo, selectedValue);

    // Clear the contents of second dropdown list.
    this.SiteId.Items.Clear();    
    
    // Add "Please Select" string to second dropdown list.   
    this.SiteId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));                      
    
    if(BaseClasses.Utils.StringUtils.InvariantUCase(selectedText).Equals(BaseClasses.Utils.StringUtils.InvariantUCase(Page.GetResourceValue("Txt:PleaseSelect", "IDE"))))
    {
        // if "Please Select" string is selected for first dropdown list,
        // then do not continue populating the second dropdown list.
        return;
    }    
    
    // Get the records using the created where clause.
    foreach ( InvoiceSummariesRecord itemValue in InvoiceSummariesTable.GetRecords(wc, null, 0, maxItems))
    {
        if(itemValue.SiteIdSpecified)
        {
            // In each record, obtain the value of second dropdown field if value exists,
            // create an item for it and add it to the list.
            string cvalue = itemValue.SiteId.ToString();
            string fvalue  = itemValue.Format(InvoiceSummariesTable.SiteId);
            ListItem item  = new ListItem(fvalue, cvalue);
            if (! this.SiteId.Items.Contains(item))
            {
                this.SiteId.Items.Add(item);        
            }
        }        
    }                    

    // Select "Please Select" string in the second dropdown list.
    this.SiteId.SelectedIndex = 0;
}
   
#endregion
}

  

public class OtherChargesRecordControl : BaseOtherChargesRecordControl
{
      
        // The BaseOtherChargesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
public class NetworkChargesRecordControl : BaseNetworkChargesRecordControl
{
      
        // The BaseNetworkChargesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
public class EnergyChargesRecordControl : BaseEnergyChargesRecordControl
{
      
        // The BaseEnergyChargesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}
#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the EnergyChargesRecordControl control on the Add_InvoiceSummaries_Meridian page.
// Do not modify this class. Instead override any method in EnergyChargesRecordControl.
public class BaseEnergyChargesRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseEnergyChargesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in EnergyChargesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in EnergyChargesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.BD00041.TextChanged += BD00041_TextChanged;
            
              this.BD0004R1.TextChanged += BD0004R1_TextChanged;
            
              this.BD04081.TextChanged += BD04081_TextChanged;
            
              this.BD0408R1.TextChanged += BD0408R1_TextChanged;
            
              this.BD08121.TextChanged += BD08121_TextChanged;
            
              this.BD0812R1.TextChanged += BD0812R1_TextChanged;
            
              this.BD12161.TextChanged += BD12161_TextChanged;
            
              this.BD1216R1.TextChanged += BD1216R1_TextChanged;
            
              this.BD16201.TextChanged += BD16201_TextChanged;
            
              this.BD1620R1.TextChanged += BD1620R1_TextChanged;
            
              this.BD20241.TextChanged += BD20241_TextChanged;
            
              this.BD2024R1.TextChanged += BD2024R1_TextChanged;
            
              this.BDL00041.TextChanged += BDL00041_TextChanged;
            
              this.BDQ00041.TextChanged += BDQ00041_TextChanged;
            
              this.NBD0004.TextChanged += NBD0004_TextChanged;
            
              this.NBD0004R1.TextChanged += NBD0004R1_TextChanged;
            
              this.NBD04081.TextChanged += NBD04081_TextChanged;
            
              this.NBD0408R1.TextChanged += NBD0408R1_TextChanged;
            
              this.NBD08121.TextChanged += NBD08121_TextChanged;
            
              this.NBD0812R1.TextChanged += NBD0812R1_TextChanged;
            
              this.NBD12161.TextChanged += NBD12161_TextChanged;
            
              this.NBD1216R1.TextChanged += NBD1216R1_TextChanged;
            
              this.NBD16201.TextChanged += NBD16201_TextChanged;
            
              this.NBD1620R1.TextChanged += NBD1620R1_TextChanged;
            
              this.NBD20241.TextChanged += NBD20241_TextChanged;
            
              this.NBD2024R1.TextChanged += NBD2024R1_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new EnergyChargesRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            EnergyChargesRecord[] recList = EnergyChargesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (EnergyChargesRecord)EnergyChargesRecord.Copy(recList[0], false);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetBD00041();
                SetBD0004Label1();
                SetBD0004R1();
                SetBD04081();
                SetBD0408Label1();
                SetBD0408R1();
                SetBD08121();
                SetBD0812Label1();
                SetBD0812R1();
                SetBD12161();
                SetBD1216Label1();
                SetBD1216R1();
                SetBD16201();
                SetBD1620Label1();
                SetBD1620R1();
                SetBD20241();
                SetBD2024Label1();
                SetBD2024R1();
                SetBDL00041();
                SetBDL0004Label1();
                SetBDQ00041();
                SetBDQ0004Label1();
                SetNBD0004();
                SetNBD0004Label();
                SetNBD0004R1();
                SetNBD04081();
                SetNBD0408Label1();
                SetNBD0408R1();
                SetNBD08121();
                SetNBD0812Label1();
                SetNBD0812R1();
                SetNBD12161();
                SetNBD1216Label1();
                SetNBD1216R1();
                SetNBD16201();
                SetNBD1620Label1();
                SetNBD1620R1();
                SetNBD20241();
                SetNBD2024Label1();
                SetNBD2024R1();
                
                
                
                
                
                
                

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetBD00041()
        {
            
                    
            // Set the BD0004 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD00041 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004Specified) {
                								
                // If the BD0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004);
                                
                this.BD00041.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD00041.Text = EnergyChargesTable.BD0004.Format(EnergyChargesTable.BD0004.DefaultValue);
            		
            }
            
              this.BD00041.TextChanged += BD00041_TextChanged;
                               
        }
                
        public virtual void SetBD0004R1()
        {
            
                    
            // Set the BD0004R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0004R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004RSpecified) {
                								
                // If the BD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004R);
                                
                this.BD0004R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0004R1.Text = EnergyChargesTable.BD0004R.Format(EnergyChargesTable.BD0004R.DefaultValue);
            		
            }
            
              this.BD0004R1.TextChanged += BD0004R1_TextChanged;
                               
        }
                
        public virtual void SetBD04081()
        {
            
                    
            // Set the BD0408 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD04081 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408Specified) {
                								
                // If the BD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408);
                                
                this.BD04081.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD04081.Text = EnergyChargesTable.BD0408.Format(EnergyChargesTable.BD0408.DefaultValue);
            		
            }
            
              this.BD04081.TextChanged += BD04081_TextChanged;
                               
        }
                
        public virtual void SetBD0408R1()
        {
            
                    
            // Set the BD0408R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0408R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408RSpecified) {
                								
                // If the BD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408R);
                                
                this.BD0408R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0408R1.Text = EnergyChargesTable.BD0408R.Format(EnergyChargesTable.BD0408R.DefaultValue);
            		
            }
            
              this.BD0408R1.TextChanged += BD0408R1_TextChanged;
                               
        }
                
        public virtual void SetBD08121()
        {
            
                    
            // Set the BD0812 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD08121 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812Specified) {
                								
                // If the BD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812);
                                
                this.BD08121.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD08121.Text = EnergyChargesTable.BD0812.Format(EnergyChargesTable.BD0812.DefaultValue);
            		
            }
            
              this.BD08121.TextChanged += BD08121_TextChanged;
                               
        }
                
        public virtual void SetBD0812R1()
        {
            
                    
            // Set the BD0812R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0812R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812RSpecified) {
                								
                // If the BD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812R);
                                
                this.BD0812R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0812R1.Text = EnergyChargesTable.BD0812R.Format(EnergyChargesTable.BD0812R.DefaultValue);
            		
            }
            
              this.BD0812R1.TextChanged += BD0812R1_TextChanged;
                               
        }
                
        public virtual void SetBD12161()
        {
            
                    
            // Set the BD1216 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD12161 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216Specified) {
                								
                // If the BD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216);
                                
                this.BD12161.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD12161.Text = EnergyChargesTable.BD1216.Format(EnergyChargesTable.BD1216.DefaultValue);
            		
            }
            
              this.BD12161.TextChanged += BD12161_TextChanged;
                               
        }
                
        public virtual void SetBD1216R1()
        {
            
                    
            // Set the BD1216R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1216R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216RSpecified) {
                								
                // If the BD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216R);
                                
                this.BD1216R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1216R1.Text = EnergyChargesTable.BD1216R.Format(EnergyChargesTable.BD1216R.DefaultValue);
            		
            }
            
              this.BD1216R1.TextChanged += BD1216R1_TextChanged;
                               
        }
                
        public virtual void SetBD16201()
        {
            
                    
            // Set the BD1620 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD16201 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620Specified) {
                								
                // If the BD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620);
                                
                this.BD16201.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD16201.Text = EnergyChargesTable.BD1620.Format(EnergyChargesTable.BD1620.DefaultValue);
            		
            }
            
              this.BD16201.TextChanged += BD16201_TextChanged;
                               
        }
                
        public virtual void SetBD1620R1()
        {
            
                    
            // Set the BD1620R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1620R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620RSpecified) {
                								
                // If the BD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620R);
                                
                this.BD1620R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1620R1.Text = EnergyChargesTable.BD1620R.Format(EnergyChargesTable.BD1620R.DefaultValue);
            		
            }
            
              this.BD1620R1.TextChanged += BD1620R1_TextChanged;
                               
        }
                
        public virtual void SetBD20241()
        {
            
                    
            // Set the BD2024 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD20241 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024Specified) {
                								
                // If the BD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024);
                                
                this.BD20241.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD20241.Text = EnergyChargesTable.BD2024.Format(EnergyChargesTable.BD2024.DefaultValue);
            		
            }
            
              this.BD20241.TextChanged += BD20241_TextChanged;
                               
        }
                
        public virtual void SetBD2024R1()
        {
            
                    
            // Set the BD2024R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD2024R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024RSpecified) {
                								
                // If the BD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024R);
                                
                this.BD2024R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD2024R1.Text = EnergyChargesTable.BD2024R.Format(EnergyChargesTable.BD2024R.DefaultValue);
            		
            }
            
              this.BD2024R1.TextChanged += BD2024R1_TextChanged;
                               
        }
                
        public virtual void SetBDL00041()
        {
            
                    
            // Set the BDL0004 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BDL00041 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BDL0004Specified) {
                								
                // If the BDL0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BDL0004);
                                
                this.BDL00041.Text = formattedValue;
                   
            } 
            
            else {
            
                // BDL0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BDL00041.Text = EnergyChargesTable.BDL0004.Format(EnergyChargesTable.BDL0004.DefaultValue);
            		
            }
            
              this.BDL00041.TextChanged += BDL00041_TextChanged;
                               
        }
                
        public virtual void SetBDQ00041()
        {
            
                    
            // Set the BDQ0004 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BDQ00041 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BDQ0004Specified) {
                								
                // If the BDQ0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BDQ0004);
                                
                this.BDQ00041.Text = formattedValue;
                   
            } 
            
            else {
            
                // BDQ0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BDQ00041.Text = EnergyChargesTable.BDQ0004.Format(EnergyChargesTable.BDQ0004.DefaultValue);
            		
            }
            
              this.BDQ00041.TextChanged += BDQ00041_TextChanged;
                               
        }
                
        public virtual void SetNBD0004()
        {
            
                    
            // Set the NBD0004 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0004 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0004Specified) {
                								
                // If the NBD0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0004);
                                
                this.NBD0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0004.Text = EnergyChargesTable.NBD0004.Format(EnergyChargesTable.NBD0004.DefaultValue);
            		
            }
            
              this.NBD0004.TextChanged += NBD0004_TextChanged;
                               
        }
                
        public virtual void SetNBD0004R1()
        {
            
                    
            // Set the NBD0004R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0004R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0004RSpecified) {
                								
                // If the NBD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0004R);
                                
                this.NBD0004R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0004R1.Text = EnergyChargesTable.NBD0004R.Format(EnergyChargesTable.NBD0004R.DefaultValue);
            		
            }
            
              this.NBD0004R1.TextChanged += NBD0004R1_TextChanged;
                               
        }
                
        public virtual void SetNBD04081()
        {
            
                    
            // Set the NBD0408 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD04081 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408Specified) {
                								
                // If the NBD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408);
                                
                this.NBD04081.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD04081.Text = EnergyChargesTable.NBD0408.Format(EnergyChargesTable.NBD0408.DefaultValue);
            		
            }
            
              this.NBD04081.TextChanged += NBD04081_TextChanged;
                               
        }
                
        public virtual void SetNBD0408R1()
        {
            
                    
            // Set the NBD0408R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0408R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408RSpecified) {
                								
                // If the NBD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408R);
                                
                this.NBD0408R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0408R1.Text = EnergyChargesTable.NBD0408R.Format(EnergyChargesTable.NBD0408R.DefaultValue);
            		
            }
            
              this.NBD0408R1.TextChanged += NBD0408R1_TextChanged;
                               
        }
                
        public virtual void SetNBD08121()
        {
            
                    
            // Set the NBD0812 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD08121 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812Specified) {
                								
                // If the NBD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812);
                                
                this.NBD08121.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD08121.Text = EnergyChargesTable.NBD0812.Format(EnergyChargesTable.NBD0812.DefaultValue);
            		
            }
            
              this.NBD08121.TextChanged += NBD08121_TextChanged;
                               
        }
                
        public virtual void SetNBD0812R1()
        {
            
                    
            // Set the NBD0812R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0812R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812RSpecified) {
                								
                // If the NBD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812R);
                                
                this.NBD0812R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0812R1.Text = EnergyChargesTable.NBD0812R.Format(EnergyChargesTable.NBD0812R.DefaultValue);
            		
            }
            
              this.NBD0812R1.TextChanged += NBD0812R1_TextChanged;
                               
        }
                
        public virtual void SetNBD12161()
        {
            
                    
            // Set the NBD1216 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD12161 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216Specified) {
                								
                // If the NBD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216);
                                
                this.NBD12161.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD12161.Text = EnergyChargesTable.NBD1216.Format(EnergyChargesTable.NBD1216.DefaultValue);
            		
            }
            
              this.NBD12161.TextChanged += NBD12161_TextChanged;
                               
        }
                
        public virtual void SetNBD1216R1()
        {
            
                    
            // Set the NBD1216R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1216R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216RSpecified) {
                								
                // If the NBD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216R);
                                
                this.NBD1216R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1216R1.Text = EnergyChargesTable.NBD1216R.Format(EnergyChargesTable.NBD1216R.DefaultValue);
            		
            }
            
              this.NBD1216R1.TextChanged += NBD1216R1_TextChanged;
                               
        }
                
        public virtual void SetNBD16201()
        {
            
                    
            // Set the NBD1620 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD16201 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620Specified) {
                								
                // If the NBD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620);
                                
                this.NBD16201.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD16201.Text = EnergyChargesTable.NBD1620.Format(EnergyChargesTable.NBD1620.DefaultValue);
            		
            }
            
              this.NBD16201.TextChanged += NBD16201_TextChanged;
                               
        }
                
        public virtual void SetNBD1620R1()
        {
            
                    
            // Set the NBD1620R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1620R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620RSpecified) {
                								
                // If the NBD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620R);
                                
                this.NBD1620R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1620R1.Text = EnergyChargesTable.NBD1620R.Format(EnergyChargesTable.NBD1620R.DefaultValue);
            		
            }
            
              this.NBD1620R1.TextChanged += NBD1620R1_TextChanged;
                               
        }
                
        public virtual void SetNBD20241()
        {
            
                    
            // Set the NBD2024 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD20241 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024Specified) {
                								
                // If the NBD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024);
                                
                this.NBD20241.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD20241.Text = EnergyChargesTable.NBD2024.Format(EnergyChargesTable.NBD2024.DefaultValue);
            		
            }
            
              this.NBD20241.TextChanged += NBD20241_TextChanged;
                               
        }
                
        public virtual void SetNBD2024R1()
        {
            
                    
            // Set the NBD2024R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD2024R1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024RSpecified) {
                								
                // If the NBD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024R);
                                
                this.NBD2024R1.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD2024R1.Text = EnergyChargesTable.NBD2024R.Format(EnergyChargesTable.NBD2024R.DefaultValue);
            		
            }
            
              this.NBD2024R1.TextChanged += NBD2024R1_TextChanged;
                               
        }
                
        public virtual void SetBD0004Label1()
                  {
                  
                        this.BD0004Label1.Text = EvaluateFormula("\"Weekday 0000 - 0400\"");
                      
                    
        }
                
        public virtual void SetBD0408Label1()
                  {
                  
                        this.BD0408Label1.Text = EvaluateFormula("\"Weekday 0400 - 0800\"");
                      
                    
        }
                
        public virtual void SetBD0812Label1()
                  {
                  
                        this.BD0812Label1.Text = EvaluateFormula("\"Weekday 0800 - 1200\"");
                      
                    
        }
                
        public virtual void SetBD1216Label1()
                  {
                  
                        this.BD1216Label1.Text = EvaluateFormula("\"Weekday 1200 - 1600\"");
                      
                    
        }
                
        public virtual void SetBD1620Label1()
                  {
                  
                        this.BD1620Label1.Text = EvaluateFormula("\"Weekday 1600 - 2000\"");
                      
                    
        }
                
        public virtual void SetBD2024Label1()
                  {
                  
                        this.BD2024Label1.Text = EvaluateFormula("\"Weekday 2000 - 2400\"");
                      
                    
        }
                
        public virtual void SetBDL0004Label1()
                  {
                  
                        this.BDL0004Label1.Text = EvaluateFormula("\"Losses 00:00 - 00:04\"");
                      
                    
        }
                
        public virtual void SetBDQ0004Label1()
                  {
                  
                        this.BDQ0004Label1.Text = EvaluateFormula("\"Quantity 00:00 - 00:04\"");
                      
                    
        }
                
        public virtual void SetNBD0004Label()
                  {
                  
                        this.NBD0004Label.Text = EvaluateFormula("\"Weekend 0000 - 0400\"");
                      
                    
        }
                
        public virtual void SetNBD0408Label1()
                  {
                  
                        this.NBD0408Label1.Text = EvaluateFormula("\"Weekend 0400 - 0800\"");
                      
                    
        }
                
        public virtual void SetNBD0812Label1()
                  {
                  
                        this.NBD0812Label1.Text = EvaluateFormula("\"Weekend 0800 - 1200\"");
                      
                    
        }
                
        public virtual void SetNBD1216Label1()
                  {
                  
                        this.NBD1216Label1.Text = EvaluateFormula("\"Weekend 1200 - 1600\"");
                      
                    
        }
                
        public virtual void SetNBD1620Label1()
                  {
                  
                        this.NBD1620Label1.Text = EvaluateFormula("\"Weekend 1600 - 2000\"");
                      
                    
        }
                
        public virtual void SetNBD2024Label1()
                  {
                  
                        this.NBD2024Label1.Text = EvaluateFormula("\"Weekend 2000 - 2400\"");
                      
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        InvoiceSummariesRecordControl parentCtrl;
      
            parentCtrl = (InvoiceSummariesRecordControl)this.Page.FindControlRecursively("InvoiceSummariesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          this.DataSource.EnergyChargeId = parentCtrl.DataSource.InvoiceSummaryId;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetBD00041();
            GetBD0004R1();
            GetBD04081();
            GetBD0408R1();
            GetBD08121();
            GetBD0812R1();
            GetBD12161();
            GetBD1216R1();
            GetBD16201();
            GetBD1620R1();
            GetBD20241();
            GetBD2024R1();
            GetBDL00041();
            GetBDQ00041();
            GetNBD0004();
            GetNBD0004R1();
            GetNBD04081();
            GetNBD0408R1();
            GetNBD08121();
            GetNBD0812R1();
            GetNBD12161();
            GetNBD1216R1();
            GetNBD16201();
            GetNBD1620R1();
            GetNBD20241();
            GetNBD2024R1();
        }
        
        
        public virtual void GetBD00041()
        {
            
            // Retrieve the value entered by the user on the BD0004 ASP:TextBox, and
            // save it into the BD0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD00041.Text, EnergyChargesTable.BD0004);							
                          
                      
        }
                
        public virtual void GetBD0004R1()
        {
            
            // Retrieve the value entered by the user on the BD0004R ASP:TextBox, and
            // save it into the BD0004R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0004R1.Text, EnergyChargesTable.BD0004R);							
                          
                      
        }
                
        public virtual void GetBD04081()
        {
            
            // Retrieve the value entered by the user on the BD0408 ASP:TextBox, and
            // save it into the BD0408 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD04081.Text, EnergyChargesTable.BD0408);							
                          
                      
        }
                
        public virtual void GetBD0408R1()
        {
            
            // Retrieve the value entered by the user on the BD0408R ASP:TextBox, and
            // save it into the BD0408R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0408R1.Text, EnergyChargesTable.BD0408R);							
                          
                      
        }
                
        public virtual void GetBD08121()
        {
            
            // Retrieve the value entered by the user on the BD0812 ASP:TextBox, and
            // save it into the BD0812 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD08121.Text, EnergyChargesTable.BD0812);							
                          
                      
        }
                
        public virtual void GetBD0812R1()
        {
            
            // Retrieve the value entered by the user on the BD0812R ASP:TextBox, and
            // save it into the BD0812R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0812R1.Text, EnergyChargesTable.BD0812R);							
                          
                      
        }
                
        public virtual void GetBD12161()
        {
            
            // Retrieve the value entered by the user on the BD1216 ASP:TextBox, and
            // save it into the BD1216 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD12161.Text, EnergyChargesTable.BD1216);							
                          
                      
        }
                
        public virtual void GetBD1216R1()
        {
            
            // Retrieve the value entered by the user on the BD1216R ASP:TextBox, and
            // save it into the BD1216R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD1216R1.Text, EnergyChargesTable.BD1216R);							
                          
                      
        }
                
        public virtual void GetBD16201()
        {
            
            // Retrieve the value entered by the user on the BD1620 ASP:TextBox, and
            // save it into the BD1620 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD16201.Text, EnergyChargesTable.BD1620);							
                          
                      
        }
                
        public virtual void GetBD1620R1()
        {
            
            // Retrieve the value entered by the user on the BD1620R ASP:TextBox, and
            // save it into the BD1620R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD1620R1.Text, EnergyChargesTable.BD1620R);							
                          
                      
        }
                
        public virtual void GetBD20241()
        {
            
            // Retrieve the value entered by the user on the BD2024 ASP:TextBox, and
            // save it into the BD2024 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD20241.Text, EnergyChargesTable.BD2024);							
                          
                      
        }
                
        public virtual void GetBD2024R1()
        {
            
            // Retrieve the value entered by the user on the BD2024R ASP:TextBox, and
            // save it into the BD2024R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD2024R1.Text, EnergyChargesTable.BD2024R);							
                          
                      
        }
                
        public virtual void GetBDL00041()
        {
            
            // Retrieve the value entered by the user on the BDL0004 ASP:TextBox, and
            // save it into the BDL0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BDL00041.Text, EnergyChargesTable.BDL0004);							
                          
                      
        }
                
        public virtual void GetBDQ00041()
        {
            
            // Retrieve the value entered by the user on the BDQ0004 ASP:TextBox, and
            // save it into the BDQ0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BDQ00041.Text, EnergyChargesTable.BDQ0004);							
                          
                      
        }
                
        public virtual void GetNBD0004()
        {
            
            // Retrieve the value entered by the user on the NBD0004 ASP:TextBox, and
            // save it into the NBD0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0004.Text, EnergyChargesTable.NBD0004);							
                          
                      
        }
                
        public virtual void GetNBD0004R1()
        {
            
            // Retrieve the value entered by the user on the NBD0004R ASP:TextBox, and
            // save it into the NBD0004R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0004R1.Text, EnergyChargesTable.NBD0004R);							
                          
                      
        }
                
        public virtual void GetNBD04081()
        {
            
            // Retrieve the value entered by the user on the NBD0408 ASP:TextBox, and
            // save it into the NBD0408 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD04081.Text, EnergyChargesTable.NBD0408);							
                          
                      
        }
                
        public virtual void GetNBD0408R1()
        {
            
            // Retrieve the value entered by the user on the NBD0408R ASP:TextBox, and
            // save it into the NBD0408R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0408R1.Text, EnergyChargesTable.NBD0408R);							
                          
                      
        }
                
        public virtual void GetNBD08121()
        {
            
            // Retrieve the value entered by the user on the NBD0812 ASP:TextBox, and
            // save it into the NBD0812 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD08121.Text, EnergyChargesTable.NBD0812);							
                          
                      
        }
                
        public virtual void GetNBD0812R1()
        {
            
            // Retrieve the value entered by the user on the NBD0812R ASP:TextBox, and
            // save it into the NBD0812R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0812R1.Text, EnergyChargesTable.NBD0812R);							
                          
                      
        }
                
        public virtual void GetNBD12161()
        {
            
            // Retrieve the value entered by the user on the NBD1216 ASP:TextBox, and
            // save it into the NBD1216 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD12161.Text, EnergyChargesTable.NBD1216);							
                          
                      
        }
                
        public virtual void GetNBD1216R1()
        {
            
            // Retrieve the value entered by the user on the NBD1216R ASP:TextBox, and
            // save it into the NBD1216R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD1216R1.Text, EnergyChargesTable.NBD1216R);							
                          
                      
        }
                
        public virtual void GetNBD16201()
        {
            
            // Retrieve the value entered by the user on the NBD1620 ASP:TextBox, and
            // save it into the NBD1620 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD16201.Text, EnergyChargesTable.NBD1620);							
                          
                      
        }
                
        public virtual void GetNBD1620R1()
        {
            
            // Retrieve the value entered by the user on the NBD1620R ASP:TextBox, and
            // save it into the NBD1620R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD1620R1.Text, EnergyChargesTable.NBD1620R);							
                          
                      
        }
                
        public virtual void GetNBD20241()
        {
            
            // Retrieve the value entered by the user on the NBD2024 ASP:TextBox, and
            // save it into the NBD2024 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD20241.Text, EnergyChargesTable.NBD2024);							
                          
                      
        }
                
        public virtual void GetNBD2024R1()
        {
            
            // Retrieve the value entered by the user on the NBD2024R ASP:TextBox, and
            // save it into the NBD2024R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD2024R1.Text, EnergyChargesTable.NBD2024R);							
                          
                      
        }
                

      // To customize, override this method in EnergyChargesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            WhereClause wc;
            EnergyChargesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            return null;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            EnergyChargesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesRecordControl = HttpContext.Current.Session["EnergyChargesRecordControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(EnergyChargesTable.EnergyChargeId))
      {
      wc.iAND(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(EnergyChargesTable.EnergyChargeId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          EnergyChargesTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
        protected virtual void BD00041_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0004R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD04081_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0408R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD08121_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0812R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD12161_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD1216R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD16201_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD1620R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD20241_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD2024R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BDL00041_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BDQ00041_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0004_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0004R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD04081_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0408R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD08121_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0812R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD12161_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD1216R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD16201_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD1620R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD20241_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD2024R1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseEnergyChargesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEnergyChargesRecordControl_Rec"] = value;
            }
        }
        
        public EnergyChargesRecord DataSource {
            get {
                return (EnergyChargesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.TextBox BD00041 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD00041");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0004Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0004R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox BD04081 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD04081");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0408Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0408R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox BD08121 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD08121");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0812Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0812R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox BD12161 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD12161");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1216Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD1216R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox BD16201 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD16201");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1620Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD1620R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox BD20241 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD20241");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD2024Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD2024R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox BDL00041 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDL00041");
            }
        }
            
        public System.Web.UI.WebControls.Literal BDL0004Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDL0004Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BDQ00041 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDQ00041");
            }
        }
            
        public System.Web.UI.WebControls.Literal BDQ0004Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDQ0004Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0004 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0004Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0004R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox NBD04081 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD04081");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0408Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0408R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox NBD08121 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD08121");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0812Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0812R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox NBD12161 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD12161");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1216Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD1216R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox NBD16201 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD16201");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1620Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD1620R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620R1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox NBD20241 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD20241");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD2024Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD2024R1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024R1");
            }
        }
            
        public System.Web.UI.WebControls.Literal Title2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title2");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        EnergyChargesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    EnergyChargesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual EnergyChargesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new EnergyChargesRecord();
            
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the InvoiceSummariesRecordControl control on the Add_InvoiceSummaries_Meridian page.
// Do not modify this class. Instead override any method in InvoiceSummariesRecordControl.
public class BaseInvoiceSummariesRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseInvoiceSummariesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in InvoiceSummariesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in InvoiceSummariesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.EnergyPointId.SelectedIndexChanged += EnergyPointId_SelectedIndexChanged;                  
                
              this.SupplierId.SelectedIndexChanged += SupplierId_SelectedIndexChanged;                  
                
              this.SiteId.SelectedIndexChanged += SiteId_SelectedIndexChanged;
            
              this.AccountNumber.TextChanged += AccountNumber_TextChanged;
            
              this.ConnectionNumber.TextChanged += ConnectionNumber_TextChanged;
            
              this.CustomerNumber.TextChanged += CustomerNumber_TextChanged;
            
              this.EnergyChargesTotal.TextChanged += EnergyChargesTotal_TextChanged;
            
              this.GstTotal.TextChanged += GstTotal_TextChanged;
            
              this.InvoiceDate.TextChanged += InvoiceDate_TextChanged;
            
              this.InvoiceDueDate.TextChanged += InvoiceDueDate_TextChanged;
            
              this.InvoiceNumber.TextChanged += InvoiceNumber_TextChanged;
            
              this.InvoiceTotal.TextChanged += InvoiceTotal_TextChanged;
            
              this.KWhTotal.TextChanged += KWhTotal_TextChanged;
            
              this.MiscChargesTotal.TextChanged += MiscChargesTotal_TextChanged;
            
              this.NetworkChargesTotal.TextChanged += NetworkChargesTotal_TextChanged;
            
              this.PeriodEnd.TextChanged += PeriodEnd_TextChanged;
            
              this.PeriodStart.TextChanged += PeriodStart_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = InvoiceSummariesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new InvoiceSummariesRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            InvoiceSummariesRecord[] recList = InvoiceSummariesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (InvoiceSummariesRecord)InvoiceSummariesRecord.Copy(recList[0], false);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetAccountNumber();
                SetAccountNumberLabel();
                SetCompanyType();
                SetConnectionNumber();
                SetConnectionNumberLabel();
                SetCustomerNumber();
                SetCustomerNumberLabel();
                SetEnergyChargesTotal();
                SetEnergyPointId();
                SetGstTotal();
                SetGstTotalLabel();
                SetInvoiceDate();
                SetInvoiceDateLabel();
                SetInvoiceDueDate();
                SetInvoiceDueDateLabel();
                SetInvoiceNumber();
                SetInvoiceNumberLabel();
                SetInvoiceTotal();
                SetInvoiceTotalLabel();
                SetKWhTotal();
                SetKWhTotalLabel();
                SetMiscChargesTotal();
                SetNetworkChargesTotal();
                SetPeriodEnd();
                SetPeriodEndLabel();
                SetPeriodStart();
                SetPeriodStartLabel();
                SetSiteId();
                SetSiteIdLabel();
                SetSupplierId();
                SetSupplierIdLabel();
                

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            EnergyChargesRecordControl recEnergyChargesRecordControl = (EnergyChargesRecordControl)(MiscUtils.FindControlRecursively(this.Page, "EnergyChargesRecordControl"));
                  
        this.Page.SetControl("EnergyChargesRecordControl");
        NetworkChargesRecordControl recNetworkChargesRecordControl = (NetworkChargesRecordControl)(MiscUtils.FindControlRecursively(this.Page, "NetworkChargesRecordControl"));
                  
        this.Page.SetControl("NetworkChargesRecordControl");
        OtherChargesRecordControl recOtherChargesRecordControl = (OtherChargesRecordControl)(MiscUtils.FindControlRecursively(this.Page, "OtherChargesRecordControl"));
                  
        this.Page.SetControl("OtherChargesRecordControl");
        
        }
        
        
        public virtual void SetAccountNumber()
        {
            
                    
            // Set the AccountNumber TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.AccountNumber is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AccountNumberSpecified) {
                								
                // If the AccountNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.AccountNumber);
                                
                this.AccountNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // AccountNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AccountNumber.Text = InvoiceSummariesTable.AccountNumber.Format(InvoiceSummariesTable.AccountNumber.DefaultValue);
            		
            }
            
              this.AccountNumber.TextChanged += AccountNumber_TextChanged;
                               
        }
                
        public virtual void SetConnectionNumber()
        {
            
                    
            // Set the ConnectionNumber TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ConnectionNumber is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ConnectionNumberSpecified) {
                								
                // If the ConnectionNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.ConnectionNumber);
                                
                this.ConnectionNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // ConnectionNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ConnectionNumber.Text = InvoiceSummariesTable.ConnectionNumber.Format(InvoiceSummariesTable.ConnectionNumber.DefaultValue);
            		
            }
            
              this.ConnectionNumber.TextChanged += ConnectionNumber_TextChanged;
                               
        }
                
        public virtual void SetCustomerNumber()
        {
            
                    
            // Set the CustomerNumber TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.CustomerNumber is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustomerNumberSpecified) {
                								
                // If the CustomerNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.CustomerNumber);
                                
                this.CustomerNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustomerNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustomerNumber.Text = InvoiceSummariesTable.CustomerNumber.Format(InvoiceSummariesTable.CustomerNumber.DefaultValue);
            		
            }
            
              this.CustomerNumber.TextChanged += CustomerNumber_TextChanged;
                               
        }
                
        public virtual void SetEnergyChargesTotal()
        {
            
                    
            // Set the EnergyChargesTotal TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.EnergyChargesTotal is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EnergyChargesTotalSpecified) {
                								
                // If the EnergyChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.EnergyChargesTotal);
                                
                this.EnergyChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // EnergyChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EnergyChargesTotal.Text = InvoiceSummariesTable.EnergyChargesTotal.Format(InvoiceSummariesTable.EnergyChargesTotal.DefaultValue);
            		
            }
            
              this.EnergyChargesTotal.TextChanged += EnergyChargesTotal_TextChanged;
                               
        }
                
        public virtual void SetEnergyPointId()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the EnergyPointId QuickSelector on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.
            
            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.EnergyPointId is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetEnergyPointId();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.EnergyPointId.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"EnergyPointId\")");
                
            }

            
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.EnergyPointId, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.EnergyPointId.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.EnergyPointId, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.EnergyPointId, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseCimscoPortal%dbo.EnergyPoints.EnergyPointId = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(EnergyPointsTable.EnergyPointId, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    EnergyPointsRecord[] rc = EnergyPointsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        EnergyPointsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.EnergyPointIdSpecified)
                            cvalue = itemValue.EnergyPointId.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.EnergyPointId);
                        if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.EnergyPointId.IsApplyDisplayAs)
                            fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.EnergyPointId);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(EnergyPointsTable.EnergyPointId);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.EnergyPointId, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../EnergyPoints/EnergyPoints-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.EnergyPointId.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= EnergyPoints.EnergyPointNumber")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("EnergyPointId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.EnergyPointId.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(EnergyPointId.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetGstTotal()
        {
            
                    
            // Set the GstTotal TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.GstTotal is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GstTotalSpecified) {
                								
                // If the GstTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.GstTotal);
                                
                this.GstTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // GstTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GstTotal.Text = InvoiceSummariesTable.GstTotal.Format(InvoiceSummariesTable.GstTotal.DefaultValue);
            		
            }
            
              this.GstTotal.TextChanged += GstTotal_TextChanged;
                               
        }
                
        public virtual void SetInvoiceDate()
        {
            
                    
            // Set the InvoiceDate TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDateSpecified) {
                								
                // If the InvoiceDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDate);
                                
                this.InvoiceDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDate.Text = InvoiceSummariesTable.InvoiceDate.Format(InvoiceSummariesTable.InvoiceDate.DefaultValue);
            		
            }
            
              this.InvoiceDate.TextChanged += InvoiceDate_TextChanged;
                               
        }
                
        public virtual void SetInvoiceDueDate()
        {
            
                    
            // Set the InvoiceDueDate TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDueDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDueDateSpecified) {
                								
                // If the InvoiceDueDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDueDate);
                                
                this.InvoiceDueDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDueDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDueDate.Text = InvoiceSummariesTable.InvoiceDueDate.Format(InvoiceSummariesTable.InvoiceDueDate.DefaultValue);
            		
            }
            
              this.InvoiceDueDate.TextChanged += InvoiceDueDate_TextChanged;
                               
        }
                
        public virtual void SetInvoiceNumber()
        {
            
                    
            // Set the InvoiceNumber TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceNumber is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceNumberSpecified) {
                								
                // If the InvoiceNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceNumber);
                                
                this.InvoiceNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceNumber.Text = InvoiceSummariesTable.InvoiceNumber.Format(InvoiceSummariesTable.InvoiceNumber.DefaultValue);
            		
            }
            
              this.InvoiceNumber.TextChanged += InvoiceNumber_TextChanged;
                               
        }
                
        public virtual void SetInvoiceTotal()
        {
            
                    
            // Set the InvoiceTotal TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceTotal is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceTotalSpecified) {
                								
                // If the InvoiceTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceTotal);
                                
                this.InvoiceTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceTotal.Text = InvoiceSummariesTable.InvoiceTotal.Format(InvoiceSummariesTable.InvoiceTotal.DefaultValue);
            		
            }
            
              this.InvoiceTotal.TextChanged += InvoiceTotal_TextChanged;
                               
        }
                
        public virtual void SetKWhTotal()
        {
            
                    
            // Set the KWhTotal TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.KWhTotal is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.KwhTotalSpecified) {
                								
                // If the KWhTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.KwhTotal);
                                
                this.KWhTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // KWhTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.KWhTotal.Text = InvoiceSummariesTable.KwhTotal.Format(InvoiceSummariesTable.KwhTotal.DefaultValue);
            		
            }
            
              this.KWhTotal.TextChanged += KWhTotal_TextChanged;
                               
        }
                
        public virtual void SetMiscChargesTotal()
        {
            
                    
            // Set the MiscChargesTotal TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.MiscChargesTotal is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MiscChargesTotalSpecified) {
                								
                // If the MiscChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.MiscChargesTotal);
                                
                this.MiscChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // MiscChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.MiscChargesTotal.Text = InvoiceSummariesTable.MiscChargesTotal.Format(InvoiceSummariesTable.MiscChargesTotal.DefaultValue);
            		
            }
            
              this.MiscChargesTotal.TextChanged += MiscChargesTotal_TextChanged;
                               
        }
                
        public virtual void SetNetworkChargesTotal()
        {
            
                    
            // Set the NetworkChargesTotal TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.NetworkChargesTotal is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NetworkChargesTotalSpecified) {
                								
                // If the NetworkChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.NetworkChargesTotal);
                                
                this.NetworkChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // NetworkChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NetworkChargesTotal.Text = InvoiceSummariesTable.NetworkChargesTotal.Format(InvoiceSummariesTable.NetworkChargesTotal.DefaultValue);
            		
            }
            
              this.NetworkChargesTotal.TextChanged += NetworkChargesTotal_TextChanged;
                               
        }
                
        public virtual void SetPeriodEnd()
        {
            
                    
            // Set the PeriodEnd TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PeriodEnd is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PeriodEndSpecified) {
                								
                // If the PeriodEnd is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PeriodEnd);
                                
                this.PeriodEnd.Text = formattedValue;
                   
            } 
            
            else {
            
                // PeriodEnd is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PeriodEnd.Text = InvoiceSummariesTable.PeriodEnd.Format(InvoiceSummariesTable.PeriodEnd.DefaultValue);
            		
            }
            
              this.PeriodEnd.TextChanged += PeriodEnd_TextChanged;
                               
        }
                
        public virtual void SetPeriodStart()
        {
            
                    
            // Set the PeriodStart TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PeriodStart is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PeriodStartSpecified) {
                								
                // If the PeriodStart is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PeriodStart);
                                
                this.PeriodStart.Text = formattedValue;
                   
            } 
            
            else {
            
                // PeriodStart is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PeriodStart.Text = InvoiceSummariesTable.PeriodStart.Format(InvoiceSummariesTable.PeriodStart.DefaultValue);
            		
            }
            
              this.PeriodStart.TextChanged += PeriodStart_TextChanged;
                               
        }
                
        public virtual void SetSiteId()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the SiteId DropDownList on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.
            
            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SiteId is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetSiteId();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.SiteId.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"SiteId\")");
                
            }

                        
                  
            // Populate the item(s) to the control
            
            this.PopulateSiteIdDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetSupplierId()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the SupplierId QuickSelector on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.
            
            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SupplierId is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetSupplierId();
            // and add your own custom code before or after the call to the base function.

            
            // Default Value could also be NULL.
            if (this.DataSource != null && this.DataSource.IsCreated)
            {
                
                selectedValue = this.DataSource.SupplierId.ToString();
                
            }
            else
            {
                
            
                selectedValue = EvaluateFormula("URL(\"SupplierId\")");
                
            }

            
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.SupplierId, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.SupplierId.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.SupplierId, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.SupplierId, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseCimscoPortal%dbo.EnergySuppliers.SupplierId = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(EnergySuppliersTable.SupplierId, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    EnergySuppliersRecord[] rc = EnergySuppliersTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        EnergySuppliersRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.SupplierIdSpecified)
                            cvalue = itemValue.SupplierId.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SupplierId);
                        if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.SupplierId.IsApplyDisplayAs)
                            fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.SupplierId);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(EnergySuppliersTable.SupplierName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.SupplierId, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../EnergySuppliers/EnergySuppliers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.SupplierId.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("SupplierName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("SupplierId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.SupplierId.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(SupplierId.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetAccountNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetCompanyType()
                  {
                  
                    
        }
                
        public virtual void SetConnectionNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustomerNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetGstTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceDueDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetKWhTotalLabel()
                  {
                  
                        this.KWhTotalLabel.Text = EvaluateFormula("\"kWh Total\"");
                      
                    
        }
                
        public virtual void SetPeriodEndLabel()
                  {
                  
                    
        }
                
        public virtual void SetPeriodStartLabel()
                  {
                  
                    
        }
                
        public virtual void SetSiteIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetSupplierIdLabel()
                  {
                  
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          EnergyChargesRecordControl recEnergyChargesRecordControl = (EnergyChargesRecordControl)(MiscUtils.FindControlRecursively(this.Page, "EnergyChargesRecordControl"));
        recEnergyChargesRecordControl.SaveData();
          NetworkChargesRecordControl recNetworkChargesRecordControl = (NetworkChargesRecordControl)(MiscUtils.FindControlRecursively(this.Page, "NetworkChargesRecordControl"));
        recNetworkChargesRecordControl.SaveData();
          OtherChargesRecordControl recOtherChargesRecordControl = (OtherChargesRecordControl)(MiscUtils.FindControlRecursively(this.Page, "OtherChargesRecordControl"));
        recOtherChargesRecordControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetAccountNumber();
            GetConnectionNumber();
            GetCustomerNumber();
            GetEnergyChargesTotal();
            GetEnergyPointId();
            GetGstTotal();
            GetInvoiceDate();
            GetInvoiceDueDate();
            GetInvoiceNumber();
            GetInvoiceTotal();
            GetKWhTotal();
            GetMiscChargesTotal();
            GetNetworkChargesTotal();
            GetPeriodEnd();
            GetPeriodStart();
            GetSiteId();
            GetSupplierId();
        }
        
        
        public virtual void GetAccountNumber()
        {
            
            // Retrieve the value entered by the user on the AccountNumber ASP:TextBox, and
            // save it into the AccountNumber field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.AccountNumber.Text, InvoiceSummariesTable.AccountNumber);							
                          
                      
        }
                
        public virtual void GetConnectionNumber()
        {
            
            // Retrieve the value entered by the user on the ConnectionNumber ASP:TextBox, and
            // save it into the ConnectionNumber field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ConnectionNumber.Text, InvoiceSummariesTable.ConnectionNumber);							
                          
                      
        }
                
        public virtual void GetCustomerNumber()
        {
            
            // Retrieve the value entered by the user on the CustomerNumber ASP:TextBox, and
            // save it into the CustomerNumber field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CustomerNumber.Text, InvoiceSummariesTable.CustomerNumber);							
                          
                      
        }
                
        public virtual void GetEnergyChargesTotal()
        {
            
            // Retrieve the value entered by the user on the EnergyChargesTotal ASP:TextBox, and
            // save it into the EnergyChargesTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.EnergyChargesTotal.Text, InvoiceSummariesTable.EnergyChargesTotal);							
                          
                      
        }
                
        public virtual void GetEnergyPointId()
        {
         // Retrieve the value entered by the user on the EnergyPointId ASP:QuickSelector, and
            // save it into the EnergyPointId field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.EnergyPointId), InvoiceSummariesTable.EnergyPointId);			
                			 
        }
                
        public virtual void GetGstTotal()
        {
            
            // Retrieve the value entered by the user on the GstTotal ASP:TextBox, and
            // save it into the GstTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.GstTotal.Text, InvoiceSummariesTable.GstTotal);							
                          
                      
        }
                
        public virtual void GetInvoiceDate()
        {
            
            // Retrieve the value entered by the user on the InvoiceDate ASP:TextBox, and
            // save it into the InvoiceDate field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvoiceDate.Text, InvoiceSummariesTable.InvoiceDate);							
                          
                      
        }
                
        public virtual void GetInvoiceDueDate()
        {
            
            // Retrieve the value entered by the user on the InvoiceDueDate ASP:TextBox, and
            // save it into the InvoiceDueDate field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvoiceDueDate.Text, InvoiceSummariesTable.InvoiceDueDate);							
                          
                      
        }
                
        public virtual void GetInvoiceNumber()
        {
            
            // Retrieve the value entered by the user on the InvoiceNumber ASP:TextBox, and
            // save it into the InvoiceNumber field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvoiceNumber.Text, InvoiceSummariesTable.InvoiceNumber);							
                          
                      
        }
                
        public virtual void GetInvoiceTotal()
        {
            
            // Retrieve the value entered by the user on the InvoiceTotal ASP:TextBox, and
            // save it into the InvoiceTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvoiceTotal.Text, InvoiceSummariesTable.InvoiceTotal);							
                          
                      
        }
                
        public virtual void GetKWhTotal()
        {
            
            // Retrieve the value entered by the user on the KWhTotal ASP:TextBox, and
            // save it into the KWhTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.KWhTotal.Text, InvoiceSummariesTable.KwhTotal);							
                          
                      
        }
                
        public virtual void GetMiscChargesTotal()
        {
            
            // Retrieve the value entered by the user on the MiscChargesTotal ASP:TextBox, and
            // save it into the MiscChargesTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.MiscChargesTotal.Text, InvoiceSummariesTable.MiscChargesTotal);							
                          
                      
        }
                
        public virtual void GetNetworkChargesTotal()
        {
            
            // Retrieve the value entered by the user on the NetworkChargesTotal ASP:TextBox, and
            // save it into the NetworkChargesTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NetworkChargesTotal.Text, InvoiceSummariesTable.NetworkChargesTotal);							
                          
                      
        }
                
        public virtual void GetPeriodEnd()
        {
            
            // Retrieve the value entered by the user on the PeriodEnd ASP:TextBox, and
            // save it into the PeriodEnd field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.PeriodEnd.Text, InvoiceSummariesTable.PeriodEnd);							
                          
                      
        }
                
        public virtual void GetPeriodStart()
        {
            
            // Retrieve the value entered by the user on the PeriodStart ASP:TextBox, and
            // save it into the PeriodStart field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.PeriodStart.Text, InvoiceSummariesTable.PeriodStart);							
                          
                      
        }
                
        public virtual void GetSiteId()
        {
         // Retrieve the value entered by the user on the SiteId ASP:DropDownList, and
            // save it into the SiteId field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.SiteId), InvoiceSummariesTable.SiteId);			
                			 
        }
                
        public virtual void GetSupplierId()
        {
         // Retrieve the value entered by the user on the SupplierId ASP:QuickSelector, and
            // save it into the SupplierId field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.SupplierId), InvoiceSummariesTable.SupplierId);			
                			 
        }
                

      // To customize, override this method in InvoiceSummariesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            WhereClause wc;
            InvoiceSummariesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["InvoiceSummaries"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in Add-InvoiceSummaries-Meridian"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(InvoiceSummariesTable.InvoiceSummaryId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(InvoiceSummariesTable.InvoiceSummaryId));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(InvoiceSummariesTable.InvoiceSummaryId, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            InvoiceSummariesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          InvoiceSummariesTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
        public virtual WhereClause CreateWhereClause_SiteIdDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseCimscoPortal%dbo.Sites table.
            // Examples:
            // wc.iAND(SitesTable.SiteName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(SitesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the SiteId list.
        protected virtual void PopulateSiteIdDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.SiteId.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.SiteId.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_SiteIdDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_SiteIdDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(SitesTable.SiteName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the SiteIdDropDownList.
            SitesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = SitesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (SitesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.SiteIdSpecified) 
                        {
                            cvalue = itemValue.SiteId.ToString().ToString();
                            if (counter < maxItems && this.SiteId.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SiteId);
                                if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.SiteId.IsApplyDisplayAs)
                                    fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.SiteId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(SitesTable.SiteName);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.SiteId.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.SiteId.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.SiteId, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.SiteId, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseCimscoPortal%dbo.Sites.SiteId = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(SitesTable.SiteId, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    SitesRecord[] rc = SitesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        SitesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.SiteIdSpecified)
                            cvalue = itemValue.SiteId.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SiteId);
                        if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.SiteId.IsApplyDisplayAs)
                            fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.SiteId);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(SitesTable.SiteName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.SiteId, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        protected virtual void EnergyPointId_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void SupplierId_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void SiteId_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[SiteId.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[SiteId.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.SiteId.Items.Add(new ListItem(displayText, val));
	            this.SiteId.SelectedIndex = this.SiteId.Items.Count - 1;
	            this.Page.Session.Remove(SiteId.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(SiteId.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void AccountNumber_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ConnectionNumber_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CustomerNumber_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void EnergyChargesTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void GstTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvoiceDate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvoiceDueDate_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvoiceNumber_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvoiceTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void KWhTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void MiscChargesTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NetworkChargesTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void PeriodEnd_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void PeriodStart_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseInvoiceSummariesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseInvoiceSummariesRecordControl_Rec"] = value;
            }
        }
        
        public InvoiceSummariesRecord DataSource {
            get {
                return (InvoiceSummariesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.TextBox AccountNumber {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal AccountNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Label CompanyType {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyType");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ConnectionNumber {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal ConnectionNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CustomerNumber {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustomerNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox EnergyChargesTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotal");
            }
        }
            
        public BaseClasses.Web.UI.WebControls.QuickSelector EnergyPointId {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyPointId");
            }
        }              
            
        public System.Web.UI.WebControls.TextBox GstTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal GstTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvoiceDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvoiceDueDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDueDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvoiceNumber {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvoiceTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox KWhTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KWhTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal KWhTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KWhTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox MiscChargesTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.TextBox NetworkChargesTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.TextBox PeriodEnd {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodEnd");
            }
        }
            
        public System.Web.UI.WebControls.Literal PeriodEndLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodEndLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox PeriodStart {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodStart");
            }
        }
            
        public System.Web.UI.WebControls.Literal PeriodStartLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodStartLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList SiteId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteId");
            }
        }
            
        public System.Web.UI.WebControls.Literal SiteIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteIdLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector SupplierId {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SupplierId");
            }
        }              
            
        public System.Web.UI.WebControls.Literal SupplierIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SupplierIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        InvoiceSummariesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    InvoiceSummariesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual InvoiceSummariesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new InvoiceSummariesRecord();
            
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the NetworkChargesRecordControl control on the Add_InvoiceSummaries_Meridian page.
// Do not modify this class. Instead override any method in NetworkChargesRecordControl.
public class BaseNetworkChargesRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseNetworkChargesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in NetworkChargesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in NetworkChargesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.CapacityCharge1.TextChanged += CapacityCharge1_TextChanged;
            
              this.DemandCharge1.TextChanged += DemandCharge1_TextChanged;
            
              this.FixedCharge1.TextChanged += FixedCharge1_TextChanged;
            
              this.VariableBD1.TextChanged += VariableBD1_TextChanged;
            
              this.VariableNBD1.TextChanged += VariableNBD1_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new NetworkChargesRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            NetworkChargesRecord[] recList = NetworkChargesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (NetworkChargesRecord)NetworkChargesRecord.Copy(recList[0], false);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetCapacityCharge1();
                SetCapacityChargeLabel1();
                SetDemandCharge1();
                SetDemandChargeLabel1();
                SetFixedCharge1();
                SetFixedChargeLabel1();
                
                
                
                SetVariableBD1();
                SetVariableBDLabel1();
                SetVariableNBD1();
                SetVariableNBDLabel1();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetCapacityCharge1()
        {
            
                    
            // Set the CapacityCharge TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.CapacityCharge1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CapacityChargeSpecified) {
                								
                // If the CapacityCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.CapacityCharge);
                                
                this.CapacityCharge1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CapacityCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CapacityCharge1.Text = NetworkChargesTable.CapacityCharge.Format(NetworkChargesTable.CapacityCharge.DefaultValue);
            		
            }
            
              this.CapacityCharge1.TextChanged += CapacityCharge1_TextChanged;
                               
        }
                
        public virtual void SetDemandCharge1()
        {
            
                    
            // Set the DemandCharge TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.DemandCharge1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DemandChargeSpecified) {
                								
                // If the DemandCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.DemandCharge);
                                
                this.DemandCharge1.Text = formattedValue;
                   
            } 
            
            else {
            
                // DemandCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DemandCharge1.Text = NetworkChargesTable.DemandCharge.Format(NetworkChargesTable.DemandCharge.DefaultValue);
            		
            }
            
              this.DemandCharge1.TextChanged += DemandCharge1_TextChanged;
                               
        }
                
        public virtual void SetFixedCharge1()
        {
            
                    
            // Set the FixedCharge TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.FixedCharge1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FixedChargeSpecified) {
                								
                // If the FixedCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.FixedCharge);
                                
                this.FixedCharge1.Text = formattedValue;
                   
            } 
            
            else {
            
                // FixedCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FixedCharge1.Text = NetworkChargesTable.FixedCharge.Format(NetworkChargesTable.FixedCharge.DefaultValue);
            		
            }
            
              this.FixedCharge1.TextChanged += FixedCharge1_TextChanged;
                               
        }
                
        public virtual void SetVariableBD1()
        {
            
                    
            // Set the VariableBD TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.VariableBD1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VariableBDSpecified) {
                								
                // If the VariableBD is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.VariableBD);
                                
                this.VariableBD1.Text = formattedValue;
                   
            } 
            
            else {
            
                // VariableBD is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VariableBD1.Text = NetworkChargesTable.VariableBD.Format(NetworkChargesTable.VariableBD.DefaultValue);
            		
            }
            
              this.VariableBD1.TextChanged += VariableBD1_TextChanged;
                               
        }
                
        public virtual void SetVariableNBD1()
        {
            
                    
            // Set the VariableNBD TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.VariableNBD1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VariableNBDSpecified) {
                								
                // If the VariableNBD is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.VariableNBD);
                                
                this.VariableNBD1.Text = formattedValue;
                   
            } 
            
            else {
            
                // VariableNBD is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VariableNBD1.Text = NetworkChargesTable.VariableNBD.Format(NetworkChargesTable.VariableNBD.DefaultValue);
            		
            }
            
              this.VariableNBD1.TextChanged += VariableNBD1_TextChanged;
                               
        }
                
        public virtual void SetCapacityChargeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetDemandChargeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetFixedChargeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetVariableBDLabel1()
                  {
                  
                        this.VariableBDLabel1.Text = EvaluateFormula("\"Variable Charge Business/Weekday\"");
                      
                    
        }
                
        public virtual void SetVariableNBDLabel1()
                  {
                  
                        this.VariableNBDLabel1.Text = EvaluateFormula("\"Variable Charge Non Business / Weekend\"");
                      
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        InvoiceSummariesRecordControl parentCtrl;
      
            parentCtrl = (InvoiceSummariesRecordControl)this.Page.FindControlRecursively("InvoiceSummariesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          this.DataSource.NetworkChargeId = parentCtrl.DataSource.InvoiceSummaryId;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetCapacityCharge1();
            GetDemandCharge1();
            GetFixedCharge1();
            GetVariableBD1();
            GetVariableNBD1();
        }
        
        
        public virtual void GetCapacityCharge1()
        {
            
            // Retrieve the value entered by the user on the CapacityCharge ASP:TextBox, and
            // save it into the CapacityCharge field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CapacityCharge1.Text, NetworkChargesTable.CapacityCharge);							
                          
                      
        }
                
        public virtual void GetDemandCharge1()
        {
            
            // Retrieve the value entered by the user on the DemandCharge ASP:TextBox, and
            // save it into the DemandCharge field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.DemandCharge1.Text, NetworkChargesTable.DemandCharge);							
                          
                      
        }
                
        public virtual void GetFixedCharge1()
        {
            
            // Retrieve the value entered by the user on the FixedCharge ASP:TextBox, and
            // save it into the FixedCharge field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.FixedCharge1.Text, NetworkChargesTable.FixedCharge);							
                          
                      
        }
                
        public virtual void GetVariableBD1()
        {
            
            // Retrieve the value entered by the user on the VariableBD ASP:TextBox, and
            // save it into the VariableBD field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VariableBD1.Text, NetworkChargesTable.VariableBD);							
                          
                      
        }
                
        public virtual void GetVariableNBD1()
        {
            
            // Retrieve the value entered by the user on the VariableNBD ASP:TextBox, and
            // save it into the VariableNBD field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VariableNBD1.Text, NetworkChargesTable.VariableNBD);							
                          
                      
        }
                

      // To customize, override this method in NetworkChargesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            WhereClause wc;
            NetworkChargesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            return null;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            NetworkChargesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesRecordControl = HttpContext.Current.Session["NetworkChargesRecordControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(NetworkChargesTable.NetworkChargeId))
      {
      wc.iAND(NetworkChargesTable.NetworkChargeId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(NetworkChargesTable.NetworkChargeId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          NetworkChargesTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
        protected virtual void CapacityCharge1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void DemandCharge1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void FixedCharge1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VariableBD1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VariableNBD1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseNetworkChargesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseNetworkChargesRecordControl_Rec"] = value;
            }
        }
        
        public NetworkChargesRecord DataSource {
            get {
                return (NetworkChargesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.TextBox CapacityCharge1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CapacityCharge1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CapacityChargeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CapacityChargeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox DemandCharge1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DemandCharge1");
            }
        }
            
        public System.Web.UI.WebControls.Literal DemandChargeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DemandChargeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox FixedCharge1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FixedCharge1");
            }
        }
            
        public System.Web.UI.WebControls.Literal FixedChargeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FixedChargeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title3");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VariableBD1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableBD1");
            }
        }
            
        public System.Web.UI.WebControls.Literal VariableBDLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableBDLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VariableNBD1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableNBD1");
            }
        }
            
        public System.Web.UI.WebControls.Literal VariableNBDLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableNBDLabel1");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        NetworkChargesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    NetworkChargesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual NetworkChargesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new NetworkChargesRecord();
            
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the OtherChargesRecordControl control on the Add_InvoiceSummaries_Meridian page.
// Do not modify this class. Instead override any method in OtherChargesRecordControl.
public class BaseOtherChargesRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseOtherChargesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in OtherChargesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in OtherChargesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.AdminCharge.TextChanged += AdminCharge_TextChanged;
            
              this.BDSVC.TextChanged += BDSVC_TextChanged;
            
              this.BDSVCR.TextChanged += BDSVCR_TextChanged;
            
              this.EALevy.TextChanged += EALevy_TextChanged;
            
              this.EALevyR.TextChanged += EALevyR_TextChanged;
            
              this.NBDSVC.TextChanged += NBDSVC_TextChanged;
            
              this.NBDSVCR.TextChanged += NBDSVCR_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new OtherChargesRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            OtherChargesRecord[] recList = OtherChargesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (OtherChargesRecord)OtherChargesRecord.Copy(recList[0], false);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetAdminCharge();
                SetAdminChargeLabel();
                SetBDSVC();
                SetBDSVCLabel();
                SetBDSVCR();
                SetEALevy();
                SetEALevyR();
                SetEALevyRLabel();
                SetLiteral3();
                SetLiteral4();
                SetNBDSVC();
                SetNBDSVCLabel();
                SetNBDSVCR();
                

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetAdminCharge()
        {
            
                    
            // Set the AdminCharge TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.AdminCharge is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AdminChargeSpecified) {
                								
                // If the AdminCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.AdminCharge);
                                
                this.AdminCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // AdminCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AdminCharge.Text = OtherChargesTable.AdminCharge.Format(OtherChargesTable.AdminCharge.DefaultValue);
            		
            }
            
              this.AdminCharge.TextChanged += AdminCharge_TextChanged;
                               
        }
                
        public virtual void SetBDSVC()
        {
            
                    
            // Set the BDSVC TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.BDSVC is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BDSVCSpecified) {
                								
                // If the BDSVC is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.BDSVC);
                                
                this.BDSVC.Text = formattedValue;
                   
            } 
            
            else {
            
                // BDSVC is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BDSVC.Text = OtherChargesTable.BDSVC.Format(OtherChargesTable.BDSVC.DefaultValue);
            		
            }
            
              this.BDSVC.TextChanged += BDSVC_TextChanged;
                               
        }
                
        public virtual void SetBDSVCR()
        {
            
                    
            // Set the BDSVCR TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.BDSVCR is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BDSVCRSpecified) {
                								
                // If the BDSVCR is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.BDSVCR);
                                
                this.BDSVCR.Text = formattedValue;
                   
            } 
            
            else {
            
                // BDSVCR is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BDSVCR.Text = OtherChargesTable.BDSVCR.Format(OtherChargesTable.BDSVCR.DefaultValue);
            		
            }
            
              this.BDSVCR.TextChanged += BDSVCR_TextChanged;
                               
        }
                
        public virtual void SetEALevy()
        {
            
                    
            // Set the EALevy TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.EALevy is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EALevySpecified) {
                								
                // If the EALevy is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.EALevy);
                                
                this.EALevy.Text = formattedValue;
                   
            } 
            
            else {
            
                // EALevy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EALevy.Text = OtherChargesTable.EALevy.Format(OtherChargesTable.EALevy.DefaultValue);
            		
            }
            
              this.EALevy.TextChanged += EALevy_TextChanged;
                               
        }
                
        public virtual void SetEALevyR()
        {
            
                    
            // Set the EALevyR TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.EALevyR is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EALevyRSpecified) {
                								
                // If the EALevyR is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.EALevyR);
                                
                this.EALevyR.Text = formattedValue;
                   
            } 
            
            else {
            
                // EALevyR is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EALevyR.Text = OtherChargesTable.EALevyR.Format(OtherChargesTable.EALevyR.DefaultValue);
            		
            }
            
              this.EALevyR.TextChanged += EALevyR_TextChanged;
                               
        }
                
        public virtual void SetNBDSVC()
        {
            
                    
            // Set the NBDSVC TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.NBDSVC is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBDSVCSpecified) {
                								
                // If the NBDSVC is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.NBDSVC);
                                
                this.NBDSVC.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBDSVC is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBDSVC.Text = OtherChargesTable.NBDSVC.Format(OtherChargesTable.NBDSVC.DefaultValue);
            		
            }
            
              this.NBDSVC.TextChanged += NBDSVC_TextChanged;
                               
        }
                
        public virtual void SetNBDSVCR()
        {
            
                    
            // Set the NBDSVCR TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.NBDSVCR is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBDSVCRSpecified) {
                								
                // If the NBDSVCR is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.NBDSVCR);
                                
                this.NBDSVCR.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBDSVCR is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBDSVCR.Text = OtherChargesTable.NBDSVCR.Format(OtherChargesTable.NBDSVCR.DefaultValue);
            		
            }
            
              this.NBDSVCR.TextChanged += NBDSVCR_TextChanged;
                               
        }
                
        public virtual void SetAdminChargeLabel()
                  {
                  
                        this.AdminChargeLabel.Text = EvaluateFormula("\"Other Charges Total\"");
                      
                    
        }
                
        public virtual void SetBDSVCLabel()
                  {
                  
                        this.BDSVCLabel.Text = EvaluateFormula("\"Energy Service Charge Business Day (Weekday)\"");
                      
                    
        }
                
        public virtual void SetEALevyRLabel()
                  {
                  
                        this.EALevyRLabel.Text = EvaluateFormula("\"Electricity Authority Rate / EA Levy Rate\"");
                      
                    
        }
                
        public virtual void SetLiteral3()
                  {
                  
                    
        }
                
        public virtual void SetLiteral4()
                  {
                  
                    
        }
                
        public virtual void SetNBDSVCLabel()
                  {
                  
                        this.NBDSVCLabel.Text = EvaluateFormula("\"Energy Service Charge NON Business Day (Weekend)\"");
                      
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        InvoiceSummariesRecordControl parentCtrl;
      
            parentCtrl = (InvoiceSummariesRecordControl)this.Page.FindControlRecursively("InvoiceSummariesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          this.DataSource.OtherChargeId = parentCtrl.DataSource.InvoiceSummaryId;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetAdminCharge();
            GetBDSVC();
            GetBDSVCR();
            GetEALevy();
            GetEALevyR();
            GetNBDSVC();
            GetNBDSVCR();
        }
        
        
        public virtual void GetAdminCharge()
        {
            
            // Retrieve the value entered by the user on the AdminCharge ASP:TextBox, and
            // save it into the AdminCharge field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.AdminCharge.Text, OtherChargesTable.AdminCharge);							
                          
                      
        }
                
        public virtual void GetBDSVC()
        {
            
            // Retrieve the value entered by the user on the BDSVC ASP:TextBox, and
            // save it into the BDSVC field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BDSVC.Text, OtherChargesTable.BDSVC);							
                          
                      
        }
                
        public virtual void GetBDSVCR()
        {
            
            // Retrieve the value entered by the user on the BDSVCR ASP:TextBox, and
            // save it into the BDSVCR field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BDSVCR.Text, OtherChargesTable.BDSVCR);							
                          
                      
        }
                
        public virtual void GetEALevy()
        {
            
            // Retrieve the value entered by the user on the EALevy ASP:TextBox, and
            // save it into the EALevy field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.EALevy.Text, OtherChargesTable.EALevy);							
                          
                      
        }
                
        public virtual void GetEALevyR()
        {
            
            // Retrieve the value entered by the user on the EALevyR ASP:TextBox, and
            // save it into the EALevyR field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.EALevyR.Text, OtherChargesTable.EALevyR);							
                          
                      
        }
                
        public virtual void GetNBDSVC()
        {
            
            // Retrieve the value entered by the user on the NBDSVC ASP:TextBox, and
            // save it into the NBDSVC field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBDSVC.Text, OtherChargesTable.NBDSVC);							
                          
                      
        }
                
        public virtual void GetNBDSVCR()
        {
            
            // Retrieve the value entered by the user on the NBDSVCR ASP:TextBox, and
            // save it into the NBDSVCR field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBDSVCR.Text, OtherChargesTable.NBDSVCR);							
                          
                      
        }
                

      // To customize, override this method in OtherChargesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            WhereClause wc;
            OtherChargesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            return null;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            OtherChargesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesRecordControl = false;
            hasFiltersNetworkChargesRecordControl = hasFiltersNetworkChargesRecordControl && false; // suppress warning
      
            bool hasFiltersOtherChargesRecordControl = false;
            hasFiltersOtherChargesRecordControl = hasFiltersOtherChargesRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesRecordControl = HttpContext.Current.Session["OtherChargesRecordControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(OtherChargesTable.OtherChargeId))
      {
      wc.iAND(OtherChargesTable.OtherChargeId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(OtherChargesTable.OtherChargeId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          OtherChargesTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
        protected virtual void AdminCharge_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BDSVC_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BDSVCR_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void EALevy_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void EALevyR_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBDSVC_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBDSVCR_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseOtherChargesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseOtherChargesRecordControl_Rec"] = value;
            }
        }
        
        public OtherChargesRecord DataSource {
            get {
                return (OtherChargesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.TextBox AdminCharge {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdminCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal AdminChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdminChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BDSVC {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDSVC");
            }
        }
            
        public System.Web.UI.WebControls.Literal BDSVCLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDSVCLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BDSVCR {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDSVCR");
            }
        }
            
        public System.Web.UI.WebControls.TextBox EALevy {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EALevy");
            }
        }
            
        public System.Web.UI.WebControls.TextBox EALevyR {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EALevyR");
            }
        }
            
        public System.Web.UI.WebControls.Literal EALevyRLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EALevyRLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Literal3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal3");
            }
        }
        
        public System.Web.UI.WebControls.Literal Literal4 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal4");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBDSVC {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBDSVC");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBDSVCLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBDSVCLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBDSVCR {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBDSVCR");
            }
        }
            
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        OtherChargesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    OtherChargesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual OtherChargesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new OtherChargesRecord();
            
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  

#endregion
    
  
}

  