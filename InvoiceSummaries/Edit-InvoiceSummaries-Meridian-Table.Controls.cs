
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_InvoiceSummaries_Meridian_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IDE.UI.Controls.Edit_InvoiceSummaries_Meridian_Table
{
  

#region "Section 1: Place your customizations here."

    
public class InvoiceSummariesTableControlRow : BaseInvoiceSummariesTableControlRow
{
      
        // The BaseInvoiceSummariesTableControlRow implements code for a ROW within the
        // the InvoiceSummariesTableControl table.  The BaseInvoiceSummariesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of InvoiceSummariesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class InvoiceSummariesTableControl : BaseInvoiceSummariesTableControl
{
    // The BaseInvoiceSummariesTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The InvoiceSummariesTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the InvoiceSummariesTableControlRow control on the Edit_InvoiceSummaries_Meridian_Table page.
// Do not modify this class. Instead override any method in InvoiceSummariesTableControlRow.
public class BaseInvoiceSummariesTableControlRow : IDE.UI.BaseApplicationRecordControl
{
        public BaseInvoiceSummariesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in InvoiceSummariesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in InvoiceSummariesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IDE") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.ApprovedById.SelectedIndexChanged += ApprovedById_SelectedIndexChanged;                  
                
              this.SiteId.SelectedIndexChanged += SiteId_SelectedIndexChanged;                  
                
              this.Approved.CheckedChanged += Approved_CheckedChanged;
            
              this.AccountNumber.TextChanged += AccountNumber_TextChanged;
            
              this.ApprovedDate.TextChanged += ApprovedDate_TextChanged;
            
              this.ConnectionNumber.TextChanged += ConnectionNumber_TextChanged;
            
              this.CustomerNumber.TextChanged += CustomerNumber_TextChanged;
            
              this.EnergyChargesTotal.TextChanged += EnergyChargesTotal_TextChanged;
            
              this.GSTCharges.TextChanged += GSTCharges_TextChanged;
            
              this.GstTotal.TextChanged += GstTotal_TextChanged;
            
              this.InvoiceDate.TextChanged += InvoiceDate_TextChanged;
            
              this.InvoiceDueDate.TextChanged += InvoiceDueDate_TextChanged;
            
              this.InvoiceId.TextChanged += InvoiceId_TextChanged;
            
              this.InvoiceNumber.TextChanged += InvoiceNumber_TextChanged;
            
              this.InvoiceTotal.TextChanged += InvoiceTotal_TextChanged;
            
              this.MiscChargesTotal.TextChanged += MiscChargesTotal_TextChanged;
            
              this.Month.TextChanged += Month_TextChanged;
            
              this.NetworkChargesTotal.TextChanged += NetworkChargesTotal_TextChanged;
            
              this.PercentageChange.TextChanged += PercentageChange_TextChanged;
            
              this.SiteName.TextChanged += SiteName_TextChanged;
            
              this.TotalCharges.TextChanged += TotalCharges_TextChanged;
            
              this.TotalEnergyCharges.TextChanged += TotalEnergyCharges_TextChanged;
            
              this.TotalMiscCharges.TextChanged += TotalMiscCharges_TextChanged;
            
              this.TotalNetworkCharges.TextChanged += TotalNetworkCharges_TextChanged;
            
              this.Year.TextChanged += Year_TextChanged;
            
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
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseInvoiceSummariesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new InvoiceSummariesRecord();
            
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
                SetApproved();
                SetApprovedById();
                SetApprovedByIdLabel();
                SetApprovedDate();
                SetApprovedDateLabel();
                SetApprovedLabel();
                SetConnectionNumber();
                SetConnectionNumberLabel();
                SetCustomerNumber();
                SetCustomerNumberLabel();
                
                
                SetEnergyChargesTotal();
                SetEnergyChargesTotalLabel();
                SetGSTCharges();
                SetGSTChargesLabel();
                SetGstTotal();
                SetGstTotalLabel();
                SetInvoiceDate();
                SetInvoiceDateLabel();
                SetInvoiceDueDate();
                SetInvoiceDueDateLabel();
                SetInvoiceId();
                SetInvoiceIdLabel();
                SetInvoiceNumber();
                SetInvoiceNumberLabel();
                SetInvoiceTotal();
                SetInvoiceTotalLabel();
                SetMiscChargesTotal();
                SetMiscChargesTotalLabel();
                SetMonth();
                SetMonthLabel();
                SetNetworkChargesTotal();
                SetNetworkChargesTotalLabel();
                SetPercentageChange();
                SetPercentageChangeLabel();
                
                SetSiteId();
                SetSiteIdLabel();
                SetSiteName();
                SetSiteNameLabel();
                SetTotalCharges();
                SetTotalChargesLabel();
                SetTotalEnergyCharges();
                SetTotalEnergyChargesLabel();
                SetTotalMiscCharges();
                SetTotalMiscChargesLabel();
                SetTotalNetworkCharges();
                SetTotalNetworkChargesLabel();
                
                SetYear();
                SetYearLabel();
                SetDeleteRowButton();
              
                SetEditRowButton();
              
                SetViewRowButton();
              

      

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
        
        
        public virtual void SetAccountNumber()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.AccountNumber.ID))
            {
            
                this.AccountNumber.Text = this.PreviousUIData[this.AccountNumber.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetApproved()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Approved.ID))
            {
                this.Approved.Checked = Convert.ToBoolean(this.PreviousUIData[this.Approved.ID]);
                return;
            }	
            
                    
            // Set the Approved CheckBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Approved is the ASP:CheckBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ApprovedSpecified) {
                							
                // If the Approved is non-NULL, then format the value.
                // The Format method will use the Display Format
                this.Approved.Checked = this.DataSource.Approved;
                    				
            } else {
            
                // Approved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (!this.DataSource.IsCreated) 
                    this.Approved.Checked = InvoiceSummariesTable.Approved.ParseValue(InvoiceSummariesTable.Approved.DefaultValue).ToBoolean();                
                    									
            }
            
        }
                
        public virtual void SetApprovedById()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ApprovedById.ID))
            {
                if (this.PreviousUIData[this.ApprovedById.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ApprovedById.ID].ToString();
            }
            
            
            // Set the ApprovedById QuickSelector on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.
            
            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ApprovedById is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetApprovedById();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ApprovedByIdSpecified)
            {
                            
                // If the ApprovedById is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ApprovedById;
                
            }
            else
            {
                
                // ApprovedById is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = InvoiceSummariesTable.ApprovedById.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.ApprovedById, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.ApprovedById.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ApprovedById, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ApprovedById, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseCimscoPortal%dbo.AspNetUsers.Id = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(AspNetUsersTable.Id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    AspNetUsersRecord[] rc = AspNetUsersTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        AspNetUsersRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.Id0Specified)
                            cvalue = itemValue.Id0.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.ApprovedById);
                        if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.ApprovedById.IsApplyDisplayAs)
                            fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.ApprovedById);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(AspNetUsersTable.Email);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ApprovedById, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../AspNetUsers/AspNetUsers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ApprovedById.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("Email")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ApprovedById.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ApprovedById.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetApprovedDate()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ApprovedDate.ID))
            {
            
                this.ApprovedDate.Text = this.PreviousUIData[this.ApprovedDate.ID].ToString();
              
                return;
            }
            
                    
            // Set the ApprovedDate TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ApprovedDate is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ApprovedDateSpecified) {
                								
                // If the ApprovedDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.ApprovedDate, @"g");
                                
                this.ApprovedDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ApprovedDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ApprovedDate.Text = InvoiceSummariesTable.ApprovedDate.Format(InvoiceSummariesTable.ApprovedDate.DefaultValue, @"g");
            		
            }
            
              this.ApprovedDate.TextChanged += ApprovedDate_TextChanged;
                               
        }
                
        public virtual void SetConnectionNumber()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ConnectionNumber.ID))
            {
            
                this.ConnectionNumber.Text = this.PreviousUIData[this.ConnectionNumber.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CustomerNumber.ID))
            {
            
                this.CustomerNumber.Text = this.PreviousUIData[this.CustomerNumber.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.EnergyChargesTotal.ID))
            {
            
                this.EnergyChargesTotal.Text = this.PreviousUIData[this.EnergyChargesTotal.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetGSTCharges()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.GSTCharges.ID))
            {
            
                this.GSTCharges.Text = this.PreviousUIData[this.GSTCharges.ID].ToString();
              
                return;
            }
            
                    
            // Set the GSTCharges TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.GSTCharges is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GSTChargesSpecified) {
                								
                // If the GSTCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.GSTCharges);
                                
                this.GSTCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // GSTCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GSTCharges.Text = InvoiceSummariesTable.GSTCharges.Format(InvoiceSummariesTable.GSTCharges.DefaultValue);
            		
            }
            
              this.GSTCharges.TextChanged += GSTCharges_TextChanged;
                               
        }
                
        public virtual void SetGstTotal()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.GstTotal.ID))
            {
            
                this.GstTotal.Text = this.PreviousUIData[this.GstTotal.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvoiceDate.ID))
            {
            
                this.InvoiceDate.Text = this.PreviousUIData[this.InvoiceDate.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvoiceDueDate.ID))
            {
            
                this.InvoiceDueDate.Text = this.PreviousUIData[this.InvoiceDueDate.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetInvoiceId()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvoiceId.ID))
            {
            
                this.InvoiceId.Text = this.PreviousUIData[this.InvoiceId.ID].ToString();
              
                return;
            }
            
                    
            // Set the InvoiceId TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceId is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceIdSpecified) {
                								
                // If the InvoiceId is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceId);
                                
                this.InvoiceId.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceId.Text = InvoiceSummariesTable.InvoiceId.Format(InvoiceSummariesTable.InvoiceId.DefaultValue);
            		
            }
            
              this.InvoiceId.TextChanged += InvoiceId_TextChanged;
                               
        }
                
        public virtual void SetInvoiceNumber()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvoiceNumber.ID))
            {
            
                this.InvoiceNumber.Text = this.PreviousUIData[this.InvoiceNumber.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.InvoiceTotal.ID))
            {
            
                this.InvoiceTotal.Text = this.PreviousUIData[this.InvoiceTotal.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetMiscChargesTotal()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.MiscChargesTotal.ID))
            {
            
                this.MiscChargesTotal.Text = this.PreviousUIData[this.MiscChargesTotal.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetMonth()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Month.ID))
            {
            
                this.Month.Text = this.PreviousUIData[this.Month.ID].ToString();
              
                return;
            }
            
                    
            // Set the Month TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Month is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MonthSpecified) {
                								
                // If the Month is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.Month);
                                
                this.Month.Text = formattedValue;
                   
            } 
            
            else {
            
                // Month is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Month.Text = InvoiceSummariesTable.Month.Format(InvoiceSummariesTable.Month.DefaultValue);
            		
            }
            
              this.Month.TextChanged += Month_TextChanged;
                               
        }
                
        public virtual void SetNetworkChargesTotal()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NetworkChargesTotal.ID))
            {
            
                this.NetworkChargesTotal.Text = this.PreviousUIData[this.NetworkChargesTotal.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetPercentageChange()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.PercentageChange.ID))
            {
            
                this.PercentageChange.Text = this.PreviousUIData[this.PercentageChange.ID].ToString();
              
                return;
            }
            
                    
            // Set the PercentageChange TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PercentageChange is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PercentageChangeSpecified) {
                								
                // If the PercentageChange is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PercentageChange);
                                
                this.PercentageChange.Text = formattedValue;
                   
            } 
            
            else {
            
                // PercentageChange is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PercentageChange.Text = InvoiceSummariesTable.PercentageChange.Format(InvoiceSummariesTable.PercentageChange.DefaultValue);
            		
            }
            
              this.PercentageChange.TextChanged += PercentageChange_TextChanged;
                               
        }
                
        public virtual void SetSiteId()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.SiteId.ID))
            {
                if (this.PreviousUIData[this.SiteId.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.SiteId.ID].ToString();
            }
            
            
            // Set the SiteId QuickSelector on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.
            
            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SiteId is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetSiteId();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.SiteIdSpecified)
            {
                            
                // If the SiteId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.SiteId.ToString();
                
            }
            else
            {
                
                // SiteId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = InvoiceSummariesTable.SiteId.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.SiteId, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.SiteId.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
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
                        
              string url = this.ModifyRedirectUrl("../Sites/Sites-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.SiteId.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("SiteName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("SiteId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.SiteId.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(SiteId.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetSiteName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.SiteName.ID))
            {
            
                this.SiteName.Text = this.PreviousUIData[this.SiteName.ID].ToString();
              
                return;
            }
            
                    
            // Set the SiteName TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SiteName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SiteNameSpecified) {
                								
                // If the SiteName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.SiteName);
                                
                this.SiteName.Text = formattedValue;
                   
            } 
            
            else {
            
                // SiteName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SiteName.Text = InvoiceSummariesTable.SiteName.Format(InvoiceSummariesTable.SiteName.DefaultValue);
            		
            }
            
              this.SiteName.TextChanged += SiteName_TextChanged;
                               
        }
                
        public virtual void SetTotalCharges()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.TotalCharges.ID))
            {
            
                this.TotalCharges.Text = this.PreviousUIData[this.TotalCharges.ID].ToString();
              
                return;
            }
            
                    
            // Set the TotalCharges TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalCharges is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalChargesSpecified) {
                								
                // If the TotalCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalCharges);
                                
                this.TotalCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalCharges.Text = InvoiceSummariesTable.TotalCharges.Format(InvoiceSummariesTable.TotalCharges.DefaultValue);
            		
            }
            
              this.TotalCharges.TextChanged += TotalCharges_TextChanged;
                               
        }
                
        public virtual void SetTotalEnergyCharges()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.TotalEnergyCharges.ID))
            {
            
                this.TotalEnergyCharges.Text = this.PreviousUIData[this.TotalEnergyCharges.ID].ToString();
              
                return;
            }
            
                    
            // Set the TotalEnergyCharges TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalEnergyCharges is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalEnergyChargesSpecified) {
                								
                // If the TotalEnergyCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalEnergyCharges);
                                
                this.TotalEnergyCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalEnergyCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalEnergyCharges.Text = InvoiceSummariesTable.TotalEnergyCharges.Format(InvoiceSummariesTable.TotalEnergyCharges.DefaultValue);
            		
            }
            
              this.TotalEnergyCharges.TextChanged += TotalEnergyCharges_TextChanged;
                               
        }
                
        public virtual void SetTotalMiscCharges()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.TotalMiscCharges.ID))
            {
            
                this.TotalMiscCharges.Text = this.PreviousUIData[this.TotalMiscCharges.ID].ToString();
              
                return;
            }
            
                    
            // Set the TotalMiscCharges TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalMiscCharges is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalMiscChargesSpecified) {
                								
                // If the TotalMiscCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalMiscCharges);
                                
                this.TotalMiscCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalMiscCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalMiscCharges.Text = InvoiceSummariesTable.TotalMiscCharges.Format(InvoiceSummariesTable.TotalMiscCharges.DefaultValue);
            		
            }
            
              this.TotalMiscCharges.TextChanged += TotalMiscCharges_TextChanged;
                               
        }
                
        public virtual void SetTotalNetworkCharges()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.TotalNetworkCharges.ID))
            {
            
                this.TotalNetworkCharges.Text = this.PreviousUIData[this.TotalNetworkCharges.ID].ToString();
              
                return;
            }
            
                    
            // Set the TotalNetworkCharges TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalNetworkCharges is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalNetworkChargesSpecified) {
                								
                // If the TotalNetworkCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalNetworkCharges);
                                
                this.TotalNetworkCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalNetworkCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalNetworkCharges.Text = InvoiceSummariesTable.TotalNetworkCharges.Format(InvoiceSummariesTable.TotalNetworkCharges.DefaultValue);
            		
            }
            
              this.TotalNetworkCharges.TextChanged += TotalNetworkCharges_TextChanged;
                               
        }
                
        public virtual void SetYear()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Year.ID))
            {
            
                this.Year.Text = this.PreviousUIData[this.Year.ID].ToString();
              
                return;
            }
            
                    
            // Set the Year TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Year is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.YearSpecified) {
                								
                // If the Year is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.Year);
                                
                this.Year.Text = formattedValue;
                   
            } 
            
            else {
            
                // Year is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Year.Text = InvoiceSummariesTable.Year.Format(InvoiceSummariesTable.Year.DefaultValue);
            		
            }
            
              this.Year.TextChanged += Year_TextChanged;
                               
        }
                
        public virtual void SetAccountNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetApprovedByIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetApprovedDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetApprovedLabel()
                  {
                  
                    
        }
                
        public virtual void SetConnectionNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetCustomerNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetEnergyChargesTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetGSTChargesLabel()
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
                
        public virtual void SetInvoiceIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetMiscChargesTotalLabel()
                  {
                  
                        this.MiscChargesTotalLabel.Text = EvaluateFormula("\"Other Charges Total\"");
                      
                    
        }
                
        public virtual void SetMonthLabel()
                  {
                  
                    
        }
                
        public virtual void SetNetworkChargesTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetPercentageChangeLabel()
                  {
                  
                    
        }
                
        public virtual void SetSiteIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetSiteNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetTotalChargesLabel()
                  {
                  
                    
        }
                
        public virtual void SetTotalEnergyChargesLabel()
                  {
                  
                    
        }
                
        public virtual void SetTotalMiscChargesLabel()
                  {
                  
                    
        }
                
        public virtual void SetTotalNetworkChargesLabel()
                  {
                  
                        this.TotalNetworkChargesLabel.Text = EvaluateFormula("\"Total Network/Line Charges\"");
                      
                    
        }
                
        public virtual void SetYearLabel()
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
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).DataChanged = true;
                ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).ResetData = true;
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
        
            GetAccountNumber();
            GetApproved();
            GetApprovedById();
            GetApprovedDate();
            GetConnectionNumber();
            GetCustomerNumber();
            GetEnergyChargesTotal();
            GetGSTCharges();
            GetGstTotal();
            GetInvoiceDate();
            GetInvoiceDueDate();
            GetInvoiceId();
            GetInvoiceNumber();
            GetInvoiceTotal();
            GetMiscChargesTotal();
            GetMonth();
            GetNetworkChargesTotal();
            GetPercentageChange();
            GetSiteId();
            GetSiteName();
            GetTotalCharges();
            GetTotalEnergyCharges();
            GetTotalMiscCharges();
            GetTotalNetworkCharges();
            GetYear();
        }
        
        
        public virtual void GetAccountNumber()
        {
            
            // Retrieve the value entered by the user on the AccountNumber ASP:TextBox, and
            // save it into the AccountNumber field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.AccountNumber.Text, InvoiceSummariesTable.AccountNumber);							
                          
                      
        }
                
        public virtual void GetApproved()
        {	
        		
            // Retrieve the value entered by the user on the Approved ASP:CheckBox, and
            // save it into the Approved field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Approved = this.Approved.Checked;						
                    
        }
                
        public virtual void GetApprovedById()
        {
         // Retrieve the value entered by the user on the ApprovedById ASP:QuickSelector, and
            // save it into the ApprovedById field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ApprovedById), InvoiceSummariesTable.ApprovedById);			
                			 
        }
                
        public virtual void GetApprovedDate()
        {
            
            // Retrieve the value entered by the user on the ApprovedDate ASP:TextBox, and
            // save it into the ApprovedDate field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // Parse will also validate the date to ensure it is of the proper format
            // and a valid date.  The format is verified based on the current culture 
            // settings including the order of month, day and year and the separator character.
            // Parse throws an exception if the date is invalid.
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ApprovedDate.Text, InvoiceSummariesTable.ApprovedDate);							
                          
                      
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
                
        public virtual void GetGSTCharges()
        {
            
            // Retrieve the value entered by the user on the GSTCharges ASP:TextBox, and
            // save it into the GSTCharges field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.GSTCharges.Text, InvoiceSummariesTable.GSTCharges);							
                          
                      
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
                
        public virtual void GetInvoiceId()
        {
            
            // Retrieve the value entered by the user on the InvoiceId ASP:TextBox, and
            // save it into the InvoiceId field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.InvoiceId.Text, InvoiceSummariesTable.InvoiceId);							
                          
                      
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
                
        public virtual void GetMiscChargesTotal()
        {
            
            // Retrieve the value entered by the user on the MiscChargesTotal ASP:TextBox, and
            // save it into the MiscChargesTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.MiscChargesTotal.Text, InvoiceSummariesTable.MiscChargesTotal);							
                          
                      
        }
                
        public virtual void GetMonth()
        {
            
            // Retrieve the value entered by the user on the Month ASP:TextBox, and
            // save it into the Month field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Month.Text, InvoiceSummariesTable.Month);							
                          
                      
        }
                
        public virtual void GetNetworkChargesTotal()
        {
            
            // Retrieve the value entered by the user on the NetworkChargesTotal ASP:TextBox, and
            // save it into the NetworkChargesTotal field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NetworkChargesTotal.Text, InvoiceSummariesTable.NetworkChargesTotal);							
                          
                      
        }
                
        public virtual void GetPercentageChange()
        {
            
            // Retrieve the value entered by the user on the PercentageChange ASP:TextBox, and
            // save it into the PercentageChange field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.PercentageChange.Text, InvoiceSummariesTable.PercentageChange);							
                          
                      
        }
                
        public virtual void GetSiteId()
        {
         // Retrieve the value entered by the user on the SiteId ASP:QuickSelector, and
            // save it into the SiteId field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.SiteId), InvoiceSummariesTable.SiteId);			
                			 
        }
                
        public virtual void GetSiteName()
        {
            
            // Retrieve the value entered by the user on the SiteName ASP:TextBox, and
            // save it into the SiteName field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.SiteName.Text, InvoiceSummariesTable.SiteName);							
                          
                      
        }
                
        public virtual void GetTotalCharges()
        {
            
            // Retrieve the value entered by the user on the TotalCharges ASP:TextBox, and
            // save it into the TotalCharges field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.TotalCharges.Text, InvoiceSummariesTable.TotalCharges);							
                          
                      
        }
                
        public virtual void GetTotalEnergyCharges()
        {
            
            // Retrieve the value entered by the user on the TotalEnergyCharges ASP:TextBox, and
            // save it into the TotalEnergyCharges field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.TotalEnergyCharges.Text, InvoiceSummariesTable.TotalEnergyCharges);							
                          
                      
        }
                
        public virtual void GetTotalMiscCharges()
        {
            
            // Retrieve the value entered by the user on the TotalMiscCharges ASP:TextBox, and
            // save it into the TotalMiscCharges field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.TotalMiscCharges.Text, InvoiceSummariesTable.TotalMiscCharges);							
                          
                      
        }
                
        public virtual void GetTotalNetworkCharges()
        {
            
            // Retrieve the value entered by the user on the TotalNetworkCharges ASP:TextBox, and
            // save it into the TotalNetworkCharges field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.TotalNetworkCharges.Text, InvoiceSummariesTable.TotalNetworkCharges);							
                          
                      
        }
                
        public virtual void GetYear()
        {
            
            // Retrieve the value entered by the user on the Year ASP:TextBox, and
            // save it into the Year field in DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Year.Text, InvoiceSummariesTable.Year);							
                          
                      
        }
                

      // To customize, override this method in InvoiceSummariesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            return null;
        
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
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).DataChanged = true;
            ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).ResetData = true;
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

        
    
        // Generate set method for buttons
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        public virtual void SetViewRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        InvoiceSummariesTableControl tc= ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((InvoiceSummariesTableControlRow)this);
                    }
                    this.Visible = false;
                    tc.SetFormulaControls();                    
                }
              
            }
      
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Edit-InvoiceSummaries.aspx?InvoiceSummaries={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void ViewRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Show-InvoiceSummaries.aspx?InvoiceSummaries={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        protected virtual void ApprovedById_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void SiteId_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void Approved_CheckedChanged(object sender, EventArgs args)
        {
           						
        }
            
        protected virtual void AccountNumber_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ApprovedDate_TextChanged(object sender, EventArgs args)
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
            
        protected virtual void GSTCharges_TextChanged(object sender, EventArgs args)
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
            
        protected virtual void InvoiceId_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvoiceNumber_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void InvoiceTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void MiscChargesTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Month_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NetworkChargesTotal_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void PercentageChange_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void SiteName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void TotalCharges_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void TotalEnergyCharges_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void TotalMiscCharges_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void TotalNetworkCharges_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Year_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseInvoiceSummariesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseInvoiceSummariesTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.CheckBox Approved {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Approved");
            }
        }
            
        public BaseClasses.Web.UI.WebControls.QuickSelector ApprovedById {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedById");
            }
        }              
            
        public System.Web.UI.WebControls.Literal ApprovedByIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedByIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ApprovedDate {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ApprovedDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ApprovedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedLabel");
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox EnergyChargesTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal EnergyChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox GSTCharges {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSTCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal GSTChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSTChargesLabel");
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
        
        public System.Web.UI.WebControls.TextBox InvoiceId {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceId");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceIdLabel");
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
        
        public System.Web.UI.WebControls.TextBox MiscChargesTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal MiscChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Month {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Month");
            }
        }
            
        public System.Web.UI.WebControls.Literal MonthLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NetworkChargesTotal {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal NetworkChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox PercentageChange {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PercentageChange");
            }
        }
            
        public System.Web.UI.WebControls.Literal PercentageChangeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PercentageChangeLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SelectRow {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow");
            }
        }              
            
        public BaseClasses.Web.UI.WebControls.QuickSelector SiteId {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteId");
            }
        }              
            
        public System.Web.UI.WebControls.Literal SiteIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SiteName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteName");
            }
        }
            
        public System.Web.UI.WebControls.Literal SiteNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox TotalCharges {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox TotalEnergyCharges {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalEnergyCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalEnergyChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalEnergyChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox TotalMiscCharges {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalMiscCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalMiscChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalMiscChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox TotalNetworkCharges {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalNetworkCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalNetworkChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalNetworkChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ViewRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ViewRowButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Year {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Year");
            }
        }
            
        public System.Web.UI.WebControls.Literal YearLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearLabel");
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
            
              if (this.RecordUniqueId != null) {
              
                return InvoiceSummariesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "IDE"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the InvoiceSummariesTableControl control on the Edit_InvoiceSummaries_Meridian_Table page.
// Do not modify this class. Instead override any method in InvoiceSummariesTableControl.
public class BaseInvoiceSummariesTableControl : IDE.UI.BaseApplicationTableControl
{
         
       public BaseInvoiceSummariesTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.OrderSort)) 				
                    initialVal = this.GetFromSession(this.OrderSort);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ApprovedByIdFilter)) 				
                    initialVal = this.GetFromSession(this.ApprovedByIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ApprovedById\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] ApprovedByIdFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in ApprovedByIdFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.ApprovedByIdFilter.Items.Add(item);
                            this.ApprovedByIdFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.ApprovedByIdFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SearchText)) 				
                    initialVal = this.GetFromSession(this.SearchText);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SearchText.Text = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
              // Show confirmation message on Click
              this.DeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "IDE") + "\"));");
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.AddButton.Click += AddButton_Click;
                        
                    this.DeleteButton.Click += DeleteButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SaveButton.Click += SaveButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.ApprovedByIdFilter.SelectedIndexChanged += ApprovedByIdFilter_SelectedIndexChanged;                  
                        
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + SearchText.ClientID + "\");", true);
             
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(IDE.Business.InvoiceSummariesRecord);
                      this.DataSource = (InvoiceSummariesRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (InvoiceSummariesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IDE.Business.InvoiceSummariesRecord);
                    this.DataSource = (InvoiceSummariesRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual InvoiceSummariesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(InvoiceSummariesTable.Column1, true);          
            // selCols.Add(InvoiceSummariesTable.Column2, true);          
            // selCols.Add(InvoiceSummariesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return InvoiceSummariesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                InvoiceSummariesTable databaseTable = new InvoiceSummariesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(InvoiceSummariesRecord)) as InvoiceSummariesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(InvoiceSummariesTable.Column1, true);          
            // selCols.Add(InvoiceSummariesTable.Column2, true);          
            // selCols.Add(InvoiceSummariesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return InvoiceSummariesTable.GetRecordCount(join, where);
            else
            {
                InvoiceSummariesTable databaseTable = new InvoiceSummariesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            InvoiceSummariesTableControlRow recControl = (InvoiceSummariesTableControlRow)(repItem.FindControl("InvoiceSummariesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                SetApprovedByIdFilter();
                SetApprovedByIdLabel1();
                
                
                
                SetOrderSort();
                
                
                
                
                SetSearchText();
                SetSortByLabel();
                
                
                SetAddButton();
              
                SetDeleteButton();
              
                SetResetButton();
              
                SetSaveButton();
              
                SetSearchButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(InvoiceSummariesTable.ApprovedById, this.DataSource);
            this.Page.PregetDfkaRecords(InvoiceSummariesTable.SiteId, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SaveButton"));
                                
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


            
            this.ApprovedByIdFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.SearchText.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for InvoiceSummariesTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (InvoiceSummariesTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (InvoiceSummariesTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            InvoiceSummariesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.ApprovedByIdFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.ApprovedByIdFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.ApprovedByIdFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(InvoiceSummariesTable.ApprovedById, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.SearchText)) {
                if (this.SearchText.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.SearchText.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.SearchText.Text.StartsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(3,this.SearchText.Text.Length-3);
                  }
                  if (this.SearchText.Text.EndsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(0,this.SearchText.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.SearchText.Text.Length - 1;
                      while (!Char.IsWhiteSpace(SearchText.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.SearchText.Text = this.SearchText.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SearchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(InvoiceSummariesTable.SiteName, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            InvoiceSummariesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String ApprovedByIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ApprovedByIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ApprovedByIdFilterSelectedValue)) {

              
        if (ApprovedByIdFilterSelectedValue != null){
                        string[] ApprovedByIdFilteritemListFromSession = ApprovedByIdFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in ApprovedByIdFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(InvoiceSummariesTable.ApprovedById, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "SearchText") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
        ColumnList cols = new ColumnList();
      
      cols.Add(InvoiceSummariesTable.SiteName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(InvoiceSummariesTable.SiteName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  

            return wc;
        }

        
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            IDE.Business.InvoiceSummariesRecord[] recordList  = InvoiceSummariesTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (InvoiceSummariesRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(InvoiceSummariesTable.SiteName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(InvoiceSummariesTable.SiteName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, InvoiceSummariesTable.SiteName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
                      
            }
              
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
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
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                InvoiceSummariesTableControlRow recControl = (InvoiceSummariesTableControlRow)(repItem.FindControl("InvoiceSummariesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      InvoiceSummariesRecord rec = new InvoiceSummariesRecord();
        
                        if (recControl.AccountNumber.Text != "") {
                            rec.Parse(recControl.AccountNumber.Text, InvoiceSummariesTable.AccountNumber);
                  }
                
                        rec.Approved = recControl.Approved.Checked;
                
                        if (MiscUtils.IsValueSelected(recControl.ApprovedById)) {
                            rec.Parse(recControl.ApprovedById.SelectedItem.Value, InvoiceSummariesTable.ApprovedById);
                        }
                        if (recControl.ApprovedDate.Text != "") {
                            rec.Parse(recControl.ApprovedDate.Text, InvoiceSummariesTable.ApprovedDate);
                  }
                
                        if (recControl.ConnectionNumber.Text != "") {
                            rec.Parse(recControl.ConnectionNumber.Text, InvoiceSummariesTable.ConnectionNumber);
                  }
                
                        if (recControl.CustomerNumber.Text != "") {
                            rec.Parse(recControl.CustomerNumber.Text, InvoiceSummariesTable.CustomerNumber);
                  }
                
                        if (recControl.EnergyChargesTotal.Text != "") {
                            rec.Parse(recControl.EnergyChargesTotal.Text, InvoiceSummariesTable.EnergyChargesTotal);
                  }
                
                        if (recControl.GSTCharges.Text != "") {
                            rec.Parse(recControl.GSTCharges.Text, InvoiceSummariesTable.GSTCharges);
                  }
                
                        if (recControl.GstTotal.Text != "") {
                            rec.Parse(recControl.GstTotal.Text, InvoiceSummariesTable.GstTotal);
                  }
                
                        if (recControl.InvoiceDate.Text != "") {
                            rec.Parse(recControl.InvoiceDate.Text, InvoiceSummariesTable.InvoiceDate);
                  }
                
                        if (recControl.InvoiceDueDate.Text != "") {
                            rec.Parse(recControl.InvoiceDueDate.Text, InvoiceSummariesTable.InvoiceDueDate);
                  }
                
                        if (recControl.InvoiceId.Text != "") {
                            rec.Parse(recControl.InvoiceId.Text, InvoiceSummariesTable.InvoiceId);
                  }
                
                        if (recControl.InvoiceNumber.Text != "") {
                            rec.Parse(recControl.InvoiceNumber.Text, InvoiceSummariesTable.InvoiceNumber);
                  }
                
                        if (recControl.InvoiceTotal.Text != "") {
                            rec.Parse(recControl.InvoiceTotal.Text, InvoiceSummariesTable.InvoiceTotal);
                  }
                
                        if (recControl.MiscChargesTotal.Text != "") {
                            rec.Parse(recControl.MiscChargesTotal.Text, InvoiceSummariesTable.MiscChargesTotal);
                  }
                
                        if (recControl.Month.Text != "") {
                            rec.Parse(recControl.Month.Text, InvoiceSummariesTable.Month);
                  }
                
                        if (recControl.NetworkChargesTotal.Text != "") {
                            rec.Parse(recControl.NetworkChargesTotal.Text, InvoiceSummariesTable.NetworkChargesTotal);
                  }
                
                        if (recControl.PercentageChange.Text != "") {
                            rec.Parse(recControl.PercentageChange.Text, InvoiceSummariesTable.PercentageChange);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.SiteId)) {
                            rec.Parse(recControl.SiteId.SelectedItem.Value, InvoiceSummariesTable.SiteId);
                        }
                        if (recControl.SiteName.Text != "") {
                            rec.Parse(recControl.SiteName.Text, InvoiceSummariesTable.SiteName);
                  }
                
                        if (recControl.TotalCharges.Text != "") {
                            rec.Parse(recControl.TotalCharges.Text, InvoiceSummariesTable.TotalCharges);
                  }
                
                        if (recControl.TotalEnergyCharges.Text != "") {
                            rec.Parse(recControl.TotalEnergyCharges.Text, InvoiceSummariesTable.TotalEnergyCharges);
                  }
                
                        if (recControl.TotalMiscCharges.Text != "") {
                            rec.Parse(recControl.TotalMiscCharges.Text, InvoiceSummariesTable.TotalMiscCharges);
                  }
                
                        if (recControl.TotalNetworkCharges.Text != "") {
                            rec.Parse(recControl.TotalNetworkCharges.Text, InvoiceSummariesTable.TotalNetworkCharges);
                  }
                
                        if (recControl.Year.Text != "") {
                            rec.Parse(recControl.Year.Text, InvoiceSummariesTable.Year);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new InvoiceSummariesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IDE.Business.InvoiceSummariesRecord);
                this.DataSource = (InvoiceSummariesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(InvoiceSummariesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(InvoiceSummariesTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetApprovedByIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort()
        {
            
                this.PopulateOrderSort(MiscUtils.GetSelectedValue(this.OrderSort,  GetFromSession(this.OrderSort)), 500);					
                    

        }
            
        public virtual void SetApprovedByIdFilter()
        {
            
            ArrayList ApprovedByIdFilterselectedFilterItemList = new ArrayList();
            string ApprovedByIdFilteritemsString = null;
            if (this.InSession(this.ApprovedByIdFilter))
                ApprovedByIdFilteritemsString = this.GetFromSession(this.ApprovedByIdFilter);
            
            if (ApprovedByIdFilteritemsString != null)
            {
                string[] ApprovedByIdFilteritemListFromSession = ApprovedByIdFilteritemsString.Split(',');
                foreach (string item in ApprovedByIdFilteritemListFromSession)
                {
                    ApprovedByIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateApprovedByIdFilter(MiscUtils.GetSelectedValueList(this.ApprovedByIdFilter, ApprovedByIdFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../AspNetUsers/AspNetUsers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ApprovedByIdFilter.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("Email")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("Id")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ApprovedByIdFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ApprovedByIdFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for OrderSort.
                
        protected virtual void PopulateOrderSort(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Account Number {Txt:Ascending}"), "AccountNumber Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Account Number {Txt:Descending}"), "AccountNumber Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved {Txt:Ascending}"), "Approved Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved {Txt:Descending}"), "Approved Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved By {Txt:Ascending}"), "ApprovedById Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved By {Txt:Descending}"), "ApprovedById Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Ascending}"), "ApprovedDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Descending}"), "ApprovedDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Charges Total {Txt:Ascending}"), "EnergyChargesTotal Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Charges Total {Txt:Descending}"), "EnergyChargesTotal Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Ascending}"), "InvoiceDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Descending}"), "InvoiceDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Ascending}"), "InvoiceDueDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Descending}"), "InvoiceDueDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site {Txt:Ascending}"), "SiteId Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site {Txt:Descending}"), "SiteId Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Name {Txt:Ascending}"), "SiteName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Name {Txt:Descending}"), "SiteName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period End {Txt:Ascending}"), "PeriodEnd Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period End {Txt:Descending}"), "PeriodEnd Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period Start {Txt:Ascending}"), "PeriodStart Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period Start {Txt:Descending}"), "PeriodStart Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Point {Txt:Ascending}"), "EnergyPointId Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Point {Txt:Descending}"), "EnergyPointId Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Supplier {Txt:Ascending}"), "SupplierId Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Supplier {Txt:Descending}"), "SupplierId Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("K Warehouse Total {Txt:Ascending}"), "KWhTotal Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("K Warehouse Total {Txt:Descending}"), "KWhTotal Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Checked OK {Txt:Ascending}"), "CheckedOk Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Checked OK {Txt:Descending}"), "CheckedOk Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("On File {Txt:Ascending}"), "OnFile Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("On File {Txt:Descending}"), "OnFile Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Verified {Txt:Ascending}"), "Verified Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Verified {Txt:Descending}"), "Verified Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort.SelectedValue != null && this.OrderSort.Items.FindByValue(this.OrderSort.SelectedValue) == null)
                this.OrderSort.SelectedValue = null;
              
        }
            
        // Get the filters' data for ApprovedByIdFilter.
                
        protected virtual void PopulateApprovedByIdFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_ApprovedByIdFilter();            
            this.ApprovedByIdFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ApprovedByIdFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IDE");

            AspNetUsersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = AspNetUsersTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (AspNetUsersRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.Id0Specified) 
                        {
                            cvalue = itemValue.Id0.ToString();
                            if (counter < maxItems && this.ApprovedByIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.ApprovedById);
                                if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.ApprovedById.IsApplyDisplayAs)
                                     fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.ApprovedById);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(AspNetUsersTable.Email);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ApprovedByIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ApprovedByIdFilter.Items.Add(newItem);

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
        
                      
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.ApprovedByIdFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.ApprovedByIdFilter.Items.Count == 0)
                this.ApprovedByIdFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "IDE"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.ApprovedByIdFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_ApprovedByIdFilter()
        {
            // Create a where clause for the filter ApprovedByIdFilter.
            // This function is called by the Populate method to load the items 
            // in the ApprovedByIdFilterQuickSelector
        
            ArrayList ApprovedByIdFilterselectedFilterItemList = new ArrayList();
            string ApprovedByIdFilteritemsString = null;
            if (this.InSession(this.ApprovedByIdFilter))
                ApprovedByIdFilteritemsString = this.GetFromSession(this.ApprovedByIdFilter);
            
            if (ApprovedByIdFilteritemsString != null)
            {
                string[] ApprovedByIdFilteritemListFromSession = ApprovedByIdFilteritemsString.Split(',');
                foreach (string item in ApprovedByIdFilteritemListFromSession)
                {
                    ApprovedByIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            ApprovedByIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ApprovedByIdFilter, ApprovedByIdFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (ApprovedByIdFilterselectedFilterItemList == null || ApprovedByIdFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in ApprovedByIdFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(AspNetUsersTable.Id0, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
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
                    bool added = (this.AddNewRecord > 0);
                    this.LoadData();
                    this.DataBind();					
                    
                    if (added) this.SetFocusToAddedRow();
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("InvoiceSummariesTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                InvoiceSummariesTableControlRow recControl = (InvoiceSummariesTableControlRow)repItem.FindControl("InvoiceSummariesTableControlRow");
                if(recControl.IsNewRecord) {
                    foreach (Control field in recControl.Controls) {
                    if (field.Visible && this.Page.IsControlEditable(field, false)) {
                        //set focus on the first editable field in the new row
                        field.Focus();
                        UpdatePanel updPan = (UpdatePanel)this.Page.FindControlRecursively("UpdatePanel1");
                        if (updPan != null) updPan.Update();
                        return;
                        }
                    }
                    return;
                }
            }
        }
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            ArrayList ApprovedByIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ApprovedByIdFilter, null);
            string ApprovedByIdFilterSessionString = "";
            if (ApprovedByIdFilterselectedFilterItemList != null){
                foreach (string item in ApprovedByIdFilterselectedFilterItemList){
                    ApprovedByIdFilterSessionString = String.Concat(ApprovedByIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.ApprovedByIdFilter, ApprovedByIdFilterSessionString);
                  
            this.SaveToSession(this.SearchText, this.SearchText.Text);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            ArrayList ApprovedByIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ApprovedByIdFilter, null);
            string ApprovedByIdFilterSessionString = "";
            if (ApprovedByIdFilterselectedFilterItemList != null){
                foreach (string item in ApprovedByIdFilterselectedFilterItemList){
                    ApprovedByIdFilterSessionString = String.Concat(ApprovedByIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("ApprovedByIdFilter_Ajax", ApprovedByIdFilterSessionString);
          
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.ApprovedByIdFilter);
            this.RemoveFromSession(this.SearchText);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["InvoiceSummariesTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["InvoiceSummariesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetAddButton()                
              
        {
        
   
        }
            
        public virtual void SetDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSaveButton()                
              
        {
        
                    this.SaveButton.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.Page.GetResourceValue("Txt:SaveRecord", "IDE") + "\");");
                  
   
        }
            
        public virtual void SetSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(ApprovedByIdFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void AddButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void DeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
                this.SetFormulaControls();
          
            }
      
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.ApprovedByIdFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
              this.SearchText.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
                  
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void SaveButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
        
              if (!this.Page.IsPageRefresh)
              {
                  this.SaveData();
              }

          this.Page.CommitTransaction(sender);
          // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
           
                foreach (InvoiceSummariesTableControlRow recCtl in this.GetRecordControls()){
                     
                    recCtl.IsNewRecord = false;
                }
      
          // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
          
                this.DeletedRecordIds = null;
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void SearchButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void ActionsButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FiltersButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void OrderSort_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in InvoiceSummariesTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(InvoiceSummariesTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (InvoiceSummariesTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && InvoiceSummariesTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(InvoiceSummariesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(InvoiceSummariesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void ApprovedByIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = InvoiceSummariesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  InvoiceSummariesRecord[] DataSource {
             
            get {
                return (InvoiceSummariesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public IDE.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton AddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AddButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ApprovedByIdFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedByIdFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal ApprovedByIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedByIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton");
            }
        }
        
        public IDE.UI.IThemeButton FilterButton {
            get {
                return (IDE.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public IDE.UI.IThemeButtonWithArrow FiltersButton {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort");
          }
          }
        
        public IDE.UI.IPaginationModern Pagination {
            get {
                return (IDE.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SaveButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SaveButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SearchText {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchText");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ToggleAll");
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
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                InvoiceSummariesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        InvoiceSummariesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                InvoiceSummariesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        InvoiceSummariesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (InvoiceSummariesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual InvoiceSummariesTableControlRow GetSelectedRecordControl()
        {
        InvoiceSummariesTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual InvoiceSummariesTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (InvoiceSummariesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (InvoiceSummariesTableControlRow[])(selectedList.ToArray(Type.GetType("IDE.UI.Controls.Edit_InvoiceSummaries_Meridian_Table.InvoiceSummariesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            InvoiceSummariesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (InvoiceSummariesTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.SelectRow.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual InvoiceSummariesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "InvoiceSummariesTableControlRow");
	          List<InvoiceSummariesTableControlRow> list = new List<InvoiceSummariesTableControlRow>();
	          foreach (InvoiceSummariesTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
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

  