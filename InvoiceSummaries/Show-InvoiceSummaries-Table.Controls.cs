
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_InvoiceSummaries_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IDE.UI.Controls.Show_InvoiceSummaries_Table
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

  
public class AspNetUsersRecordControl : BaseAspNetUsersRecordControl
{
      
        // The BaseAspNetUsersRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  
public class SitesRecordControl : BaseSitesRecordControl
{
      
        // The BaseSitesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the InvoiceSummariesTableControlRow control on the Show_InvoiceSummaries_Table page.
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
                        
                    this.ExpandRowButton.Click += ExpandRowButton_Click;
                        
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
                SetInvoiceSummariesTabContainer();
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
              
                SetExpandRowButton();
              

      

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
                      
        SetAspNetUsersRecordControl();

                  
        SetSitesRecordControl();

        
        }
        
        
        public virtual void SetAccountNumber()
        {
            
                    
            // Set the AccountNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.AccountNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AccountNumberSpecified) {
                								
                // If the AccountNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.AccountNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AccountNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // AccountNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AccountNumber.Text = InvoiceSummariesTable.AccountNumber.Format(InvoiceSummariesTable.AccountNumber.DefaultValue);
            		
            }
            
            // If the AccountNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AccountNumber.Text == null ||
                this.AccountNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AccountNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetApproved()
        {
            
                    
            // Set the Approved Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Approved is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ApprovedSpecified) {
                								
                // If the Approved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.Approved);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Approved.Text = formattedValue;
                   
            } 
            
            else {
            
                // Approved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Approved.Text = InvoiceSummariesTable.Approved.Format(InvoiceSummariesTable.Approved.DefaultValue);
            		
            }
            
            // If the Approved is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Approved.Text == null ||
                this.Approved.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Approved.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetApprovedDate()
        {
            
                    
            // Set the ApprovedDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ApprovedDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ApprovedDateSpecified) {
                								
                // If the ApprovedDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.ApprovedDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ApprovedDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ApprovedDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ApprovedDate.Text = InvoiceSummariesTable.ApprovedDate.Format(InvoiceSummariesTable.ApprovedDate.DefaultValue, @"g");
            		
            }
            
            // If the ApprovedDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ApprovedDate.Text == null ||
                this.ApprovedDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ApprovedDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetConnectionNumber()
        {
            
                    
            // Set the ConnectionNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ConnectionNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ConnectionNumberSpecified) {
                								
                // If the ConnectionNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.ConnectionNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ConnectionNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // ConnectionNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ConnectionNumber.Text = InvoiceSummariesTable.ConnectionNumber.Format(InvoiceSummariesTable.ConnectionNumber.DefaultValue);
            		
            }
            
            // If the ConnectionNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ConnectionNumber.Text == null ||
                this.ConnectionNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ConnectionNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustomerNumber()
        {
            
                    
            // Set the CustomerNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.CustomerNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustomerNumberSpecified) {
                								
                // If the CustomerNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.CustomerNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustomerNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustomerNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustomerNumber.Text = InvoiceSummariesTable.CustomerNumber.Format(InvoiceSummariesTable.CustomerNumber.DefaultValue);
            		
            }
            
            // If the CustomerNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustomerNumber.Text == null ||
                this.CustomerNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustomerNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEnergyChargesTotal()
        {
            
                    
            // Set the EnergyChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.EnergyChargesTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EnergyChargesTotalSpecified) {
                								
                // If the EnergyChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.EnergyChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EnergyChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // EnergyChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EnergyChargesTotal.Text = InvoiceSummariesTable.EnergyChargesTotal.Format(InvoiceSummariesTable.EnergyChargesTotal.DefaultValue);
            		
            }
            
            // If the EnergyChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EnergyChargesTotal.Text == null ||
                this.EnergyChargesTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EnergyChargesTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetGSTCharges()
        {
            
                    
            // Set the GSTCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.GSTCharges is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GSTChargesSpecified) {
                								
                // If the GSTCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.GSTCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.GSTCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // GSTCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GSTCharges.Text = InvoiceSummariesTable.GSTCharges.Format(InvoiceSummariesTable.GSTCharges.DefaultValue);
            		
            }
            
            // If the GSTCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.GSTCharges.Text == null ||
                this.GSTCharges.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.GSTCharges.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetGstTotal()
        {
            
                    
            // Set the GstTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.GstTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GstTotalSpecified) {
                								
                // If the GstTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.GstTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.GstTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // GstTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GstTotal.Text = InvoiceSummariesTable.GstTotal.Format(InvoiceSummariesTable.GstTotal.DefaultValue);
            		
            }
            
            // If the GstTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.GstTotal.Text == null ||
                this.GstTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.GstTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceDate()
        {
            
                    
            // Set the InvoiceDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDateSpecified) {
                								
                // If the InvoiceDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDate.Text = InvoiceSummariesTable.InvoiceDate.Format(InvoiceSummariesTable.InvoiceDate.DefaultValue);
            		
            }
            
            // If the InvoiceDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceDate.Text == null ||
                this.InvoiceDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceDueDate()
        {
            
                    
            // Set the InvoiceDueDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDueDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDueDateSpecified) {
                								
                // If the InvoiceDueDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDueDate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceDueDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDueDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDueDate.Text = InvoiceSummariesTable.InvoiceDueDate.Format(InvoiceSummariesTable.InvoiceDueDate.DefaultValue);
            		
            }
            
            // If the InvoiceDueDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceDueDate.Text == null ||
                this.InvoiceDueDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceDueDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceId()
        {
            
                    
            // Set the InvoiceId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceIdSpecified) {
                								
                // If the InvoiceId is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceId);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceId.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceId.Text = InvoiceSummariesTable.InvoiceId.Format(InvoiceSummariesTable.InvoiceId.DefaultValue);
            		
            }
            
            // If the InvoiceId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceId.Text == null ||
                this.InvoiceId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceNumber()
        {
            
                    
            // Set the InvoiceNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceNumberSpecified) {
                								
                // If the InvoiceNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceNumber.Text = InvoiceSummariesTable.InvoiceNumber.Format(InvoiceSummariesTable.InvoiceNumber.DefaultValue);
            		
            }
            
            // If the InvoiceNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceNumber.Text == null ||
                this.InvoiceNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceTotal()
        {
            
                    
            // Set the InvoiceTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceTotalSpecified) {
                								
                // If the InvoiceTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceTotal.Text = InvoiceSummariesTable.InvoiceTotal.Format(InvoiceSummariesTable.InvoiceTotal.DefaultValue);
            		
            }
            
            // If the InvoiceTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceTotal.Text == null ||
                this.InvoiceTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetMiscChargesTotal()
        {
            
                    
            // Set the MiscChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.MiscChargesTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MiscChargesTotalSpecified) {
                								
                // If the MiscChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.MiscChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.MiscChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // MiscChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.MiscChargesTotal.Text = InvoiceSummariesTable.MiscChargesTotal.Format(InvoiceSummariesTable.MiscChargesTotal.DefaultValue);
            		
            }
            
            // If the MiscChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.MiscChargesTotal.Text == null ||
                this.MiscChargesTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.MiscChargesTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetMonth()
        {
            
                    
            // Set the Month Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Month is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MonthSpecified) {
                								
                // If the Month is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.Month);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Month.Text = formattedValue;
                   
            } 
            
            else {
            
                // Month is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Month.Text = InvoiceSummariesTable.Month.Format(InvoiceSummariesTable.Month.DefaultValue);
            		
            }
            
            // If the Month is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Month.Text == null ||
                this.Month.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Month.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNetworkChargesTotal()
        {
            
                    
            // Set the NetworkChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.NetworkChargesTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NetworkChargesTotalSpecified) {
                								
                // If the NetworkChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.NetworkChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NetworkChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // NetworkChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NetworkChargesTotal.Text = InvoiceSummariesTable.NetworkChargesTotal.Format(InvoiceSummariesTable.NetworkChargesTotal.DefaultValue);
            		
            }
            
            // If the NetworkChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NetworkChargesTotal.Text == null ||
                this.NetworkChargesTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NetworkChargesTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPercentageChange()
        {
            
                    
            // Set the PercentageChange Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PercentageChange is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PercentageChangeSpecified) {
                								
                // If the PercentageChange is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PercentageChange);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PercentageChange.Text = formattedValue;
                   
            } 
            
            else {
            
                // PercentageChange is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PercentageChange.Text = InvoiceSummariesTable.PercentageChange.Format(InvoiceSummariesTable.PercentageChange.DefaultValue);
            		
            }
            
            // If the PercentageChange is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PercentageChange.Text == null ||
                this.PercentageChange.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PercentageChange.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSiteName()
        {
            
                    
            // Set the SiteName Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SiteName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SiteNameSpecified) {
                								
                // If the SiteName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.SiteName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SiteName.Text = formattedValue;
                   
            } 
            
            else {
            
                // SiteName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SiteName.Text = InvoiceSummariesTable.SiteName.Format(InvoiceSummariesTable.SiteName.DefaultValue);
            		
            }
            
            // If the SiteName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SiteName.Text == null ||
                this.SiteName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SiteName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalCharges()
        {
            
                    
            // Set the TotalCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalCharges is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalChargesSpecified) {
                								
                // If the TotalCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalCharges.Text = InvoiceSummariesTable.TotalCharges.Format(InvoiceSummariesTable.TotalCharges.DefaultValue);
            		
            }
            
            // If the TotalCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalCharges.Text == null ||
                this.TotalCharges.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalCharges.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalEnergyCharges()
        {
            
                    
            // Set the TotalEnergyCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalEnergyCharges is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalEnergyChargesSpecified) {
                								
                // If the TotalEnergyCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalEnergyCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalEnergyCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalEnergyCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalEnergyCharges.Text = InvoiceSummariesTable.TotalEnergyCharges.Format(InvoiceSummariesTable.TotalEnergyCharges.DefaultValue);
            		
            }
            
            // If the TotalEnergyCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalEnergyCharges.Text == null ||
                this.TotalEnergyCharges.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalEnergyCharges.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalMiscCharges()
        {
            
                    
            // Set the TotalMiscCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalMiscCharges is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalMiscChargesSpecified) {
                								
                // If the TotalMiscCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalMiscCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalMiscCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalMiscCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalMiscCharges.Text = InvoiceSummariesTable.TotalMiscCharges.Format(InvoiceSummariesTable.TotalMiscCharges.DefaultValue);
            		
            }
            
            // If the TotalMiscCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalMiscCharges.Text == null ||
                this.TotalMiscCharges.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalMiscCharges.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalNetworkCharges()
        {
            
                    
            // Set the TotalNetworkCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalNetworkCharges is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalNetworkChargesSpecified) {
                								
                // If the TotalNetworkCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalNetworkCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalNetworkCharges.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalNetworkCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalNetworkCharges.Text = InvoiceSummariesTable.TotalNetworkCharges.Format(InvoiceSummariesTable.TotalNetworkCharges.DefaultValue);
            		
            }
            
            // If the TotalNetworkCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalNetworkCharges.Text == null ||
                this.TotalNetworkCharges.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalNetworkCharges.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetYear()
        {
            
                    
            // Set the Year Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Year is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.YearSpecified) {
                								
                // If the Year is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.Year);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(InvoiceSummariesTable.Year.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IDE.Business.InvoiceSummariesTable, IDE.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"Year\\\", \\\"Year\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.Year.Text = formattedValue;
                   
            } 
            
            else {
            
                // Year is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Year.Text = InvoiceSummariesTable.Year.Format(InvoiceSummariesTable.Year.DefaultValue);
            		
            }
            
            // If the Year is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Year.Text == null ||
                this.Year.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Year.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAccountNumberLabel()
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
                
        public virtual void SetInvoiceSummariesTabContainer()    
        
        {
                            
                   
            if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "true") 
                MiscUtils.FindControlRecursively(this, "InvoiceSummariesTabContainer").Visible = true;
            else if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "false") 
                MiscUtils.FindControlRecursively(this, "InvoiceSummariesTabContainer").Visible = false;
         
  
        }      
      
        public virtual void SetAspNetUsersRecordControl()           
        
        {        
            if (AspNetUsersRecordControl.Visible)
            {
                AspNetUsersRecordControl.LoadData();
                AspNetUsersRecordControl.DataBind();
            }
        }
      
        public virtual void SetSitesRecordControl()           
        
        {        
            if (SitesRecordControl.Visible)
            {
                SitesRecordControl.LoadData();
                SitesRecordControl.DataBind();
            }
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
          AspNetUsersRecordControl recAspNetUsersRecordControl = (AspNetUsersRecordControl)(MiscUtils.FindControlRecursively(this, "AspNetUsersRecordControl"));
        recAspNetUsersRecordControl.SaveData();
        SitesRecordControl recSitesRecordControl = (SitesRecordControl)(MiscUtils.FindControlRecursively(this, "SitesRecordControl"));
        recSitesRecordControl.SaveData();
        
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
            GetSiteName();
            GetTotalCharges();
            GetTotalEnergyCharges();
            GetTotalMiscCharges();
            GetTotalNetworkCharges();
            GetYear();
        }
        
        
        public virtual void GetAccountNumber()
        {
            
        }
                
        public virtual void GetApproved()
        {
            
        }
                
        public virtual void GetApprovedDate()
        {
            
        }
                
        public virtual void GetConnectionNumber()
        {
            
        }
                
        public virtual void GetCustomerNumber()
        {
            
        }
                
        public virtual void GetEnergyChargesTotal()
        {
            
        }
                
        public virtual void GetGSTCharges()
        {
            
        }
                
        public virtual void GetGstTotal()
        {
            
        }
                
        public virtual void GetInvoiceDate()
        {
            
        }
                
        public virtual void GetInvoiceDueDate()
        {
            
        }
                
        public virtual void GetInvoiceId()
        {
            
        }
                
        public virtual void GetInvoiceNumber()
        {
            
        }
                
        public virtual void GetInvoiceTotal()
        {
            
        }
                
        public virtual void GetMiscChargesTotal()
        {
            
        }
                
        public virtual void GetMonth()
        {
            
        }
                
        public virtual void GetNetworkChargesTotal()
        {
            
        }
                
        public virtual void GetPercentageChange()
        {
            
        }
                
        public virtual void GetSiteName()
        {
            
        }
                
        public virtual void GetTotalCharges()
        {
            
        }
                
        public virtual void GetTotalEnergyCharges()
        {
            
        }
                
        public virtual void GetTotalMiscCharges()
        {
            
        }
                
        public virtual void GetTotalNetworkCharges()
        {
            
        }
                
        public virtual void GetYear()
        {
            
        }
                

      // To customize, override this method in InvoiceSummariesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAspNetUsersRecordControl = false;
            hasFiltersAspNetUsersRecordControl = hasFiltersAspNetUsersRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
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
            
        public virtual void SetExpandRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
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
        public virtual void ExpandRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                InvoiceSummariesTableControl panelControl = (MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl") as InvoiceSummariesTableControl);

          InvoiceSummariesTableControlRow[] repeatedRows = panelControl.GetRecordControls();
          foreach (InvoiceSummariesTableControlRow repeatedRow in repeatedRows)
          {
              System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(repeatedRow, "InvoiceSummariesTableControlAltRow") as System.Web.UI.Control);
              if (altRow != null)
              {
                  if (sender == repeatedRow.ExpandRowButton)
                      altRow.Visible = !altRow.Visible;
                  
                  if (altRow.Visible)
                  {
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'");
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'");
                           
                  }
                  else
                  {
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'");
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'");
                   
                  }
            
              }
              else
              {
                  this.Page.Response.Redirect("../Shared/ConfigureCollapseExpandRowBtn.aspx");
              }
          }
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
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
        
        public System.Web.UI.WebControls.Literal AccountNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal AccountNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Approved {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Approved");
            }
        }
            
        public System.Web.UI.WebControls.Literal ApprovedDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedDate");
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
        
        public AspNetUsersRecordControl AspNetUsersRecordControl {
            get {
                return (AspNetUsersRecordControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AspNetUsersRecordControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal ConnectionNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal ConnectionNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustomerNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerNumber");
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
        
        public System.Web.UI.WebControls.Literal EnergyChargesTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal EnergyChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExpandRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpandRowButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal GSTCharges {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSTCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal GSTChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSTChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal GstTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal GstTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceDueDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDueDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceId");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumberLabel");
            }
        }
        
        public AjaxControlToolkit.TabContainer InvoiceSummariesTabContainer {
            get {
                return (AjaxControlToolkit.TabContainer)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTabContainer");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal MiscChargesTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal MiscChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Month {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Month");
            }
        }
            
        public System.Web.UI.WebControls.Literal MonthLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal NetworkChargesTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal NetworkChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PercentageChange {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PercentageChange");
            }
        }
            
        public System.Web.UI.WebControls.Literal PercentageChangeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PercentageChangeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal SiteName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteName");
            }
        }
            
        public System.Web.UI.WebControls.Literal SiteNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteNameLabel");
            }
        }
        
        public SitesRecordControl SitesRecordControl {
            get {
                return (SitesRecordControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SitesRecordControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalCharges {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalEnergyCharges {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalEnergyCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalEnergyChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalEnergyChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalMiscCharges {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalMiscCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalMiscChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalMiscChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalNetworkCharges {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalNetworkCharges");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalNetworkChargesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalNetworkChargesLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Year {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Year");
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

  
// Base class for the InvoiceSummariesTableControl control on the Show_InvoiceSummaries_Table page.
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
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SiteNameFilter)) 				
                    initialVal = this.GetFromSession(this.SiteNameFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"SiteName\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] SiteNameFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in SiteNameFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.SiteNameFilter.Items.Add(item);
                            this.SiteNameFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.SiteNameFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
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
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.SiteNameFilter.SelectedIndexChanged += SiteNameFilter_SelectedIndexChanged;                  
                        
        
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
        
                
                
                
                
                
                
                SetOrderSort();
                
                
                
                
                SetSearchText();
                SetSiteNameFilter();
                SetSiteNameLabel1();
                SetSortByLabel();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetSearchButton();
              
                SetWordButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            bool expandFirstRow = true;
        InvoiceSummariesTableControlRow[] recControls = this.GetRecordControls();
            for (int i = 0; i < recControls.Length; i++)
            {
                System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(recControls[i], "InvoiceSummariesTableControlAltRow") as System.Web.UI.Control);
                if (altRow != null){
                    if (expandFirstRow && i == 0){
                        altRow.Visible = true;
                   
                         recControls[i].ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'");
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'");
                   
                    }
                    else{
                        altRow.Visible = false;
                   
                         recControls[i].ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'");
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'");
                   
                    }
                }
            }
    
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

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "IDE") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton"));
                                
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


            
            this.SiteNameFilter.ClearSelection();
            
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
                  
            if (MiscUtils.IsValueSelected(this.SiteNameFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.SiteNameFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.SiteNameFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(InvoiceSummariesTable.SiteName, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
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
                  
      String SiteNameFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "SiteNameFilter_Ajax"];
            if (MiscUtils.IsValueSelected(SiteNameFilterSelectedValue)) {

              
        if (SiteNameFilterSelectedValue != null){
                        string[] SiteNameFilteritemListFromSession = SiteNameFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in SiteNameFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(InvoiceSummariesTable.SiteName, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
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
                
                        if (recControl.Approved.Text != "") {
                            rec.Parse(recControl.Approved.Text, InvoiceSummariesTable.Approved);
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
        
        public virtual void SetSiteNameLabel1()
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
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        public virtual void SetSiteNameFilter()
        {
            
            ArrayList SiteNameFilterselectedFilterItemList = new ArrayList();
            string SiteNameFilteritemsString = null;
            if (this.InSession(this.SiteNameFilter))
                SiteNameFilteritemsString = this.GetFromSession(this.SiteNameFilter);
            
            if (SiteNameFilteritemsString != null)
            {
                string[] SiteNameFilteritemListFromSession = SiteNameFilteritemsString.Split(',');
                foreach (string item in SiteNameFilteritemListFromSession)
                {
                    SiteNameFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateSiteNameFilter(MiscUtils.GetSelectedValueList(this.SiteNameFilter, SiteNameFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../InvoiceSummaries/InvoiceSummaries-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.SiteNameFilter.ClientID + "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("SiteName")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.SiteNameFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(SiteNameFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
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
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Ascending}"), "ApprovedDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Descending}"), "ApprovedDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Connection Number {Txt:Ascending}"), "ConnectionNumber Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Connection Number {Txt:Descending}"), "ConnectionNumber Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Number {Txt:Ascending}"), "CustomerNumber Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Number {Txt:Descending}"), "CustomerNumber Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Ascending}"), "InvoiceDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Descending}"), "InvoiceDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Ascending}"), "InvoiceDueDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Descending}"), "InvoiceDueDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Number {Txt:Ascending}"), "InvoiceNumber Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Number {Txt:Descending}"), "InvoiceNumber Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Month {Txt:Ascending}"), "Month Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Month {Txt:Descending}"), "Month Desc"));
              
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
            
        // Get the filters' data for SiteNameFilter.
                
        protected virtual void PopulateSiteNameFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_SiteNameFilter();            
            this.SiteNameFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_SiteNameFilter function.
            // It is better to customize the where clause there.
             
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(InvoiceSummariesTable.SiteName, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = InvoiceSummariesTable.GetValues(InvoiceSummariesTable.SiteName, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( InvoiceSummariesTable.SiteName.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = InvoiceSummariesTable.SiteName.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.SiteNameFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.SiteNameFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.SiteNameFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.SiteNameFilter.Items.Count == 0)
                this.SiteNameFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "IDE"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.SiteNameFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_SiteNameFilter()
        {
            // Create a where clause for the filter SiteNameFilter.
            // This function is called by the Populate method to load the items 
            // in the SiteNameFilterQuickSelector
        
            ArrayList SiteNameFilterselectedFilterItemList = new ArrayList();
            string SiteNameFilteritemsString = null;
            if (this.InSession(this.SiteNameFilter))
                SiteNameFilteritemsString = this.GetFromSession(this.SiteNameFilter);
            
            if (SiteNameFilteritemsString != null)
            {
                string[] SiteNameFilteritemListFromSession = SiteNameFilteritemsString.Split(',');
                foreach (string item in SiteNameFilteritemListFromSession)
                {
                    SiteNameFilterselectedFilterItemList.Add(item);
                }
            }
              
            SiteNameFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SiteNameFilter, SiteNameFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (SiteNameFilterselectedFilterItemList == null || SiteNameFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in SiteNameFilterselectedFilterItemList)
                {
            
      
   
                    wc.iOR(InvoiceSummariesTable.SiteName, BaseFilter.ComparisonOperator.EqualsTo, item);

                                
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
            // Save filter controls to values to session.
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            this.SaveToSession(this.SearchText, this.SearchText.Text);
                  
            ArrayList SiteNameFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SiteNameFilter, null);
            string SiteNameFilterSessionString = "";
            if (SiteNameFilterselectedFilterItemList != null){
                foreach (string item in SiteNameFilterselectedFilterItemList){
                    SiteNameFilterSessionString = String.Concat(SiteNameFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.SiteNameFilter, SiteNameFilterSessionString);
                  
            
                    
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
                  
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
            ArrayList SiteNameFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SiteNameFilter, null);
            string SiteNameFilterSessionString = "";
            if (SiteNameFilterselectedFilterItemList != null){
                foreach (string item in SiteNameFilterselectedFilterItemList){
                    SiteNameFilterSessionString = String.Concat(SiteNameFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("SiteNameFilter_Ajax", SiteNameFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.SearchText);
            this.RemoveFromSession(this.SiteNameFilter);
            
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
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=InvoiceSummaries" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../InvoiceSummaries/Add-InvoiceSummaries.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
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
    
      
            if (MiscUtils.IsValueSelected(SiteNameFilter))
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
        public virtual void ExcelButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = null;
                wc = CreateWhereClause();
                OrderBy orderBy = null;
              
                orderBy = CreateOrderBy();
              
              bool done = false;
              object val = "";
              CompoundFilter join = CreateCompoundJoinFilter();
              
              // Read pageSize records at a time and write out the Excel file.
              int totalRowsReturned = 0;


              this.TotalRecords = InvoiceSummariesTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             InvoiceSummariesTable.InvoiceId,
             InvoiceSummariesTable.InvoiceDate,
             InvoiceSummariesTable.InvoiceNumber,
             InvoiceSummariesTable.GstTotal,
             InvoiceSummariesTable.InvoiceTotal,
             InvoiceSummariesTable.AccountNumber,
             InvoiceSummariesTable.CustomerNumber,
             InvoiceSummariesTable.NetworkChargesTotal,
             InvoiceSummariesTable.EnergyChargesTotal,
             InvoiceSummariesTable.MiscChargesTotal,
             InvoiceSummariesTable.TotalCharges,
             InvoiceSummariesTable.GSTCharges,
             InvoiceSummariesTable.TotalNetworkCharges,
             InvoiceSummariesTable.TotalMiscCharges,
             InvoiceSummariesTable.TotalEnergyCharges,
             InvoiceSummariesTable.ConnectionNumber,
             InvoiceSummariesTable.SiteName,
             InvoiceSummariesTable.InvoiceDueDate,
             InvoiceSummariesTable.Month,
             InvoiceSummariesTable.Year,
             InvoiceSummariesTable.Approved,
             InvoiceSummariesTable.ApprovedDate,
             InvoiceSummariesTable.PercentageChange,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(InvoiceSummariesTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(InvoiceSummariesTable.Instance, wc, orderBy, columns,join);

                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = dataForCSV.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in dataForCSV.ColumnList)
                {
                if (col == null)
                continue;

                if (!dataForCSV.IncludeInExport(col))
                continue;

                val = rec.GetValue(col).ToString();
                exportData.WriteColumnData(val, dataForCSV.IsString(col));
                }
                exportData.WriteNewRow();
                }

                //  If we already are below the pageSize, then we are done.
                if (totalRowsReturned < exportData.pageSize)
                {
                done = true;
                }
                }
                exportData.FinishExport(this.Page.Response);
              
              }
              else
              {
              // Create an instance of the ExportDataToExcel class with the table class, where clause and order by.
              ExportDataToExcel excelReport = new ExportDataToExcel(InvoiceSummariesTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(InvoiceSummariesTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.InvoiceId, "0"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.InvoiceDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.InvoiceNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.GstTotal, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.InvoiceTotal, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.AccountNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.CustomerNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.NetworkChargesTotal, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.EnergyChargesTotal, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.MiscChargesTotal, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.TotalCharges, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.GSTCharges, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.TotalNetworkCharges, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.TotalMiscCharges, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.TotalEnergyCharges, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.ConnectionNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.SiteName, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.InvoiceDueDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.Month, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.Year, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.Approved, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.ApprovedDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.PercentageChange, "Standard"));


              //  First write out the Column Headers
              foreach (ExcelColumn col in data.ColumnList)
              {
              width = excelReport.GetExcelCellWidth(col);
              if (data.IncludeInExport(col))
              {
              excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col));
              columnCounter++;
              }
              }
              
              while (!done)
              {
              ArrayList recList = data.GetRows(excelReport.pageSize);

              if (recList == null)
              {
              break;
              }
              totalRowsReturned = recList.Count;

              foreach (BaseRecord rec in recList)
              {
              excelReport.AddRowToExcelBook();
              columnCounter = 0;
              foreach (ExcelColumn col in data.ColumnList)
              {
              if (!data.IncludeInExport(col))
              continue;

              Boolean _isExpandableNonCompositeForeignKey = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn);
              if (_isExpandableNonCompositeForeignKey && col.DisplayColumn.IsApplyDisplayAs)
              {
                val = InvoiceSummariesTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
                if (String.IsNullOrEmpty(val as string))
                {
                  val = rec.Format(col.DisplayColumn);
                }
              }
              else
                val = excelReport.GetValueForExcelExport(col, rec);
              
              excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat);

              columnCounter++;
              }
              }

              // If we already are below the pageSize, then we are done.
              if (totalRowsReturned < excelReport.pageSize)
              {
              done = true;
              }
              }
              excelReport.SaveExcelBook(this.Page.Response);
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
        public virtual void ImportButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
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
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Add-InvoiceSummaries.aspx?TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-InvoiceSummaries-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "InvoiceSummaries";
                // If Show-InvoiceSummaries-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(InvoiceSummariesTable.InvoiceId.Name, ReportEnum.Align.Right, "${InvoiceId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(InvoiceSummariesTable.InvoiceDate.Name, ReportEnum.Align.Left, "${InvoiceDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.InvoiceNumber.Name, ReportEnum.Align.Left, "${InvoiceNumber}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.GstTotal.Name, ReportEnum.Align.Right, "${GstTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.InvoiceTotal.Name, ReportEnum.Align.Right, "${InvoiceTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.AccountNumber.Name, ReportEnum.Align.Left, "${AccountNumber}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.CustomerNumber.Name, ReportEnum.Align.Left, "${CustomerNumber}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.NetworkChargesTotal.Name, ReportEnum.Align.Right, "${NetworkChargesTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.EnergyChargesTotal.Name, ReportEnum.Align.Right, "${EnergyChargesTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.MiscChargesTotal.Name, ReportEnum.Align.Right, "${MiscChargesTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalCharges.Name, ReportEnum.Align.Right, "${TotalCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.GSTCharges.Name, ReportEnum.Align.Right, "${GSTCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalNetworkCharges.Name, ReportEnum.Align.Right, "${TotalNetworkCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalMiscCharges.Name, ReportEnum.Align.Right, "${TotalMiscCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalEnergyCharges.Name, ReportEnum.Align.Right, "${TotalEnergyCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.ConnectionNumber.Name, ReportEnum.Align.Left, "${ConnectionNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(InvoiceSummariesTable.SiteName.Name, ReportEnum.Align.Left, "${SiteName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(InvoiceSummariesTable.InvoiceDueDate.Name, ReportEnum.Align.Left, "${InvoiceDueDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.Month.Name, ReportEnum.Align.Left, "${Month}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.Year.Name, ReportEnum.Align.Left, "${Year}", ReportEnum.Align.Left, 28);
                 report.AddColumn(InvoiceSummariesTable.Approved.Name, ReportEnum.Align.Left, "${Approved}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.ApprovedDate.Name, ReportEnum.Align.Left, "${ApprovedDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.PercentageChange.Name, ReportEnum.Align.Right, "${PercentageChange}", ReportEnum.Align.Right, 20);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "IDE");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = InvoiceSummariesTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = InvoiceSummariesTable.GetRecordCount(joinFilter,whereClause);
                InvoiceSummariesRecord[] records = null;
                
                do
                {
                    
                    records = InvoiceSummariesTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( InvoiceSummariesRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${InvoiceId}", record.Format(InvoiceSummariesTable.InvoiceId), ReportEnum.Align.Right, 300);
                             report.AddData("${InvoiceDate}", record.Format(InvoiceSummariesTable.InvoiceDate), ReportEnum.Align.Left, 300);
                             report.AddData("${InvoiceNumber}", record.Format(InvoiceSummariesTable.InvoiceNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${GstTotal}", record.Format(InvoiceSummariesTable.GstTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${InvoiceTotal}", record.Format(InvoiceSummariesTable.InvoiceTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${AccountNumber}", record.Format(InvoiceSummariesTable.AccountNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${CustomerNumber}", record.Format(InvoiceSummariesTable.CustomerNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${NetworkChargesTotal}", record.Format(InvoiceSummariesTable.NetworkChargesTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${EnergyChargesTotal}", record.Format(InvoiceSummariesTable.EnergyChargesTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${MiscChargesTotal}", record.Format(InvoiceSummariesTable.MiscChargesTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalCharges}", record.Format(InvoiceSummariesTable.TotalCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${GSTCharges}", record.Format(InvoiceSummariesTable.GSTCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalNetworkCharges}", record.Format(InvoiceSummariesTable.TotalNetworkCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalMiscCharges}", record.Format(InvoiceSummariesTable.TotalMiscCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalEnergyCharges}", record.Format(InvoiceSummariesTable.TotalEnergyCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${ConnectionNumber}", record.Format(InvoiceSummariesTable.ConnectionNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${SiteName}", record.Format(InvoiceSummariesTable.SiteName), ReportEnum.Align.Left, 300);
                             report.AddData("${InvoiceDueDate}", record.Format(InvoiceSummariesTable.InvoiceDueDate), ReportEnum.Align.Left, 300);
                             report.AddData("${Month}", record.Format(InvoiceSummariesTable.Month), ReportEnum.Align.Left, 300);
                             report.AddData("${Year}", record.Format(InvoiceSummariesTable.Year), ReportEnum.Align.Left, 300);
                             report.AddData("${Approved}", record.Format(InvoiceSummariesTable.Approved), ReportEnum.Align.Left, 300);
                             report.AddData("${ApprovedDate}", record.Format(InvoiceSummariesTable.ApprovedDate), ReportEnum.Align.Left, 300);
                             report.AddData("${PercentageChange}", record.Format(InvoiceSummariesTable.PercentageChange), ReportEnum.Align.Right, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
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
                
              this.SiteNameFilter.ClearSelection();
            
           
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
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-InvoiceSummaries-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "InvoiceSummaries";
                // If Show-InvoiceSummaries-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(InvoiceSummariesTable.InvoiceId.Name, ReportEnum.Align.Right, "${InvoiceId}", ReportEnum.Align.Right, 15);
                 report.AddColumn(InvoiceSummariesTable.InvoiceDate.Name, ReportEnum.Align.Left, "${InvoiceDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.InvoiceNumber.Name, ReportEnum.Align.Left, "${InvoiceNumber}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.GstTotal.Name, ReportEnum.Align.Right, "${GstTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.InvoiceTotal.Name, ReportEnum.Align.Right, "${InvoiceTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.AccountNumber.Name, ReportEnum.Align.Left, "${AccountNumber}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.CustomerNumber.Name, ReportEnum.Align.Left, "${CustomerNumber}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.NetworkChargesTotal.Name, ReportEnum.Align.Right, "${NetworkChargesTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.EnergyChargesTotal.Name, ReportEnum.Align.Right, "${EnergyChargesTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.MiscChargesTotal.Name, ReportEnum.Align.Right, "${MiscChargesTotal}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalCharges.Name, ReportEnum.Align.Right, "${TotalCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.GSTCharges.Name, ReportEnum.Align.Right, "${GSTCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalNetworkCharges.Name, ReportEnum.Align.Right, "${TotalNetworkCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalMiscCharges.Name, ReportEnum.Align.Right, "${TotalMiscCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.TotalEnergyCharges.Name, ReportEnum.Align.Right, "${TotalEnergyCharges}", ReportEnum.Align.Right, 19);
                 report.AddColumn(InvoiceSummariesTable.ConnectionNumber.Name, ReportEnum.Align.Left, "${ConnectionNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(InvoiceSummariesTable.SiteName.Name, ReportEnum.Align.Left, "${SiteName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(InvoiceSummariesTable.InvoiceDueDate.Name, ReportEnum.Align.Left, "${InvoiceDueDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.Month.Name, ReportEnum.Align.Left, "${Month}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.Year.Name, ReportEnum.Align.Left, "${Year}", ReportEnum.Align.Left, 28);
                 report.AddColumn(InvoiceSummariesTable.Approved.Name, ReportEnum.Align.Left, "${Approved}", ReportEnum.Align.Left, 15);
                 report.AddColumn(InvoiceSummariesTable.ApprovedDate.Name, ReportEnum.Align.Left, "${ApprovedDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.PercentageChange.Name, ReportEnum.Align.Right, "${PercentageChange}", ReportEnum.Align.Right, 20);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = InvoiceSummariesTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "IDE");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = InvoiceSummariesTable.GetColumnList();
                InvoiceSummariesRecord[] records = null;
                do
                {
                    records = InvoiceSummariesTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( InvoiceSummariesRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${InvoiceId}", record.Format(InvoiceSummariesTable.InvoiceId), ReportEnum.Align.Right, 300);
                             report.AddData("${InvoiceDate}", record.Format(InvoiceSummariesTable.InvoiceDate), ReportEnum.Align.Left, 300);
                             report.AddData("${InvoiceNumber}", record.Format(InvoiceSummariesTable.InvoiceNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${GstTotal}", record.Format(InvoiceSummariesTable.GstTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${InvoiceTotal}", record.Format(InvoiceSummariesTable.InvoiceTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${AccountNumber}", record.Format(InvoiceSummariesTable.AccountNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${CustomerNumber}", record.Format(InvoiceSummariesTable.CustomerNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${NetworkChargesTotal}", record.Format(InvoiceSummariesTable.NetworkChargesTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${EnergyChargesTotal}", record.Format(InvoiceSummariesTable.EnergyChargesTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${MiscChargesTotal}", record.Format(InvoiceSummariesTable.MiscChargesTotal), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalCharges}", record.Format(InvoiceSummariesTable.TotalCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${GSTCharges}", record.Format(InvoiceSummariesTable.GSTCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalNetworkCharges}", record.Format(InvoiceSummariesTable.TotalNetworkCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalMiscCharges}", record.Format(InvoiceSummariesTable.TotalMiscCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${TotalEnergyCharges}", record.Format(InvoiceSummariesTable.TotalEnergyCharges), ReportEnum.Align.Right, 300);
                             report.AddData("${ConnectionNumber}", record.Format(InvoiceSummariesTable.ConnectionNumber), ReportEnum.Align.Left, 300);
                             report.AddData("${SiteName}", record.Format(InvoiceSummariesTable.SiteName), ReportEnum.Align.Left, 300);
                             report.AddData("${InvoiceDueDate}", record.Format(InvoiceSummariesTable.InvoiceDueDate), ReportEnum.Align.Left, 300);
                             report.AddData("${Month}", record.Format(InvoiceSummariesTable.Month), ReportEnum.Align.Left, 300);
                             report.AddData("${Year}", record.Format(InvoiceSummariesTable.Year), ReportEnum.Align.Left, 300);
                             report.AddData("${Approved}", record.Format(InvoiceSummariesTable.Approved), ReportEnum.Align.Left, 300);
                             report.AddData("${ApprovedDate}", record.Format(InvoiceSummariesTable.ApprovedDate), ReportEnum.Align.Left, 300);
                             report.AddData("${PercentageChange}", record.Format(InvoiceSummariesTable.PercentageChange), ReportEnum.Align.Right, 300);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
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
        protected virtual void SiteNameFilter_SelectedIndexChanged(object sender, EventArgs args)
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
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
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
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
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
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector SiteNameFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteNameFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal SiteNameLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteNameLabel1");
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
        
        public System.Web.UI.WebControls.ImageButton WordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton");
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
          
        public virtual InvoiceSummariesTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual InvoiceSummariesTableControlRow[] GetSelectedRecordControls()
        {
        
            return (InvoiceSummariesTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IDE.UI.Controls.Show_InvoiceSummaries_Table.InvoiceSummariesTableControlRow")));
          
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
  
// Base class for the AspNetUsersRecordControl control on the Show_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in AspNetUsersRecordControl.
public class BaseAspNetUsersRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseAspNetUsersRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in AspNetUsersRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in AspNetUsersRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.AspNetUsers record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "AspNetUsersRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new AspNetUsersRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            AspNetUsersRecord[] recList = AspNetUsersTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = AspNetUsersTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetAccessFailedCount();
                SetAccessFailedCountLabel();
                SetCompanyLogo();
                SetCompanyLogoLabel();
                SetEmail();
                SetEmailConfirmed();
                SetEmailConfirmedLabel();
                SetEmailLabel();
                SetFirstName();
                SetFirstNameLabel();
                SetId0();
                SetIdLabel();
                SetLastName();
                SetLastNameLabel();
                SetLockoutEnabled();
                SetLockoutEnabledLabel();
                SetLockoutEndDateUtc();
                SetLockoutEndDateUtcLabel();
                SetPasswordHash();
                SetPasswordHashLabel();
                SetPhoneNumber();
                SetPhoneNumberConfirmed();
                SetPhoneNumberConfirmedLabel();
                SetPhoneNumberLabel();
                SetSecurityStamp();
                SetSecurityStampLabel();
                SetTwoFactorEnabled();
                SetTwoFactorEnabledLabel();
                SetUserName0();
                SetUserNameLabel();

      

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
        
        
        public virtual void SetAccessFailedCount()
        {
            
                    
            // Set the AccessFailedCount Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.AccessFailedCount is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AccessFailedCountSpecified) {
                								
                // If the AccessFailedCount is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.AccessFailedCount);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AccessFailedCount.Text = formattedValue;
                   
            } 
            
            else {
            
                // AccessFailedCount is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AccessFailedCount.Text = AspNetUsersTable.AccessFailedCount.Format(AspNetUsersTable.AccessFailedCount.DefaultValue);
            		
            }
            
            // If the AccessFailedCount is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AccessFailedCount.Text == null ||
                this.AccessFailedCount.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AccessFailedCount.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCompanyLogo()
        {
            
                    
            // Set the CompanyLogo Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.CompanyLogo is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CompanyLogoSpecified) {
                								
                // If the CompanyLogo is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.CompanyLogo);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(AspNetUsersTable.CompanyLogo.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IDE.Business.AspNetUsersTable, IDE.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"CompanyLogo\\\", \\\"CompanyLogo\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.CompanyLogo.Text = formattedValue;
                   
            } 
            
            else {
            
                // CompanyLogo is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CompanyLogo.Text = AspNetUsersTable.CompanyLogo.Format(AspNetUsersTable.CompanyLogo.DefaultValue);
            		
            }
            
            // If the CompanyLogo is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CompanyLogo.Text == null ||
                this.CompanyLogo.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CompanyLogo.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEmail()
        {
            
                    
            // Set the Email Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.Email is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EmailSpecified) {
                								
                // If the Email is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.Email);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Email.Text = formattedValue;
                   
            } 
            
            else {
            
                // Email is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Email.Text = AspNetUsersTable.Email.Format(AspNetUsersTable.Email.DefaultValue);
            		
            }
            
            // If the Email is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Email.Text == null ||
                this.Email.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Email.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEmailConfirmed()
        {
            
                    
            // Set the EmailConfirmed Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.EmailConfirmed is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EmailConfirmedSpecified) {
                								
                // If the EmailConfirmed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.EmailConfirmed);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EmailConfirmed.Text = formattedValue;
                   
            } 
            
            else {
            
                // EmailConfirmed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EmailConfirmed.Text = AspNetUsersTable.EmailConfirmed.Format(AspNetUsersTable.EmailConfirmed.DefaultValue);
            		
            }
            
            // If the EmailConfirmed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EmailConfirmed.Text == null ||
                this.EmailConfirmed.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EmailConfirmed.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFirstName()
        {
            
                    
            // Set the FirstName Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.FirstName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstNameSpecified) {
                								
                // If the FirstName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.FirstName);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(AspNetUsersTable.FirstName.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IDE.Business.AspNetUsersTable, IDE.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"FirstName\\\", \\\"FirstName\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.FirstName.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName.Text = AspNetUsersTable.FirstName.Format(AspNetUsersTable.FirstName.DefaultValue);
            		
            }
            
            // If the FirstName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FirstName.Text == null ||
                this.FirstName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FirstName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetId0()
        {
            
                    
            // Set the Id Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.Id0 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Id0Specified) {
                								
                // If the Id is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.Id0);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Id0.Text = formattedValue;
                   
            } 
            
            else {
            
                // Id is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Id0.Text = AspNetUsersTable.Id0.Format(AspNetUsersTable.Id0.DefaultValue);
            		
            }
            
            // If the Id is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Id0.Text == null ||
                this.Id0.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Id0.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastName()
        {
            
                    
            // Set the LastName Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.LastName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastNameSpecified) {
                								
                // If the LastName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.LastName);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(AspNetUsersTable.LastName.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IDE.Business.AspNetUsersTable, IDE.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"LastName\\\", \\\"LastName\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.LastName.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName.Text = AspNetUsersTable.LastName.Format(AspNetUsersTable.LastName.DefaultValue);
            		
            }
            
            // If the LastName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastName.Text == null ||
                this.LastName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLockoutEnabled()
        {
            
                    
            // Set the LockoutEnabled Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.LockoutEnabled is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LockoutEnabledSpecified) {
                								
                // If the LockoutEnabled is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.LockoutEnabled);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LockoutEnabled.Text = formattedValue;
                   
            } 
            
            else {
            
                // LockoutEnabled is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LockoutEnabled.Text = AspNetUsersTable.LockoutEnabled.Format(AspNetUsersTable.LockoutEnabled.DefaultValue);
            		
            }
            
            // If the LockoutEnabled is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LockoutEnabled.Text == null ||
                this.LockoutEnabled.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LockoutEnabled.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLockoutEndDateUtc()
        {
            
                    
            // Set the LockoutEndDateUtc Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.LockoutEndDateUtc is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LockoutEndDateUtcSpecified) {
                								
                // If the LockoutEndDateUtc is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.LockoutEndDateUtc, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LockoutEndDateUtc.Text = formattedValue;
                   
            } 
            
            else {
            
                // LockoutEndDateUtc is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LockoutEndDateUtc.Text = AspNetUsersTable.LockoutEndDateUtc.Format(AspNetUsersTable.LockoutEndDateUtc.DefaultValue, @"g");
            		
            }
            
            // If the LockoutEndDateUtc is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LockoutEndDateUtc.Text == null ||
                this.LockoutEndDateUtc.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LockoutEndDateUtc.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPasswordHash()
        {
            
                    
            // Set the PasswordHash Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.PasswordHash is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PasswordHashSpecified) {
                								
                // If the PasswordHash is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.PasswordHash);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(AspNetUsersTable.PasswordHash.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IDE.Business.AspNetUsersTable, IDE.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"PasswordHash\\\", \\\"PasswordHash\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.PasswordHash.Text = formattedValue;
                   
            } 
            
            else {
            
                // PasswordHash is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PasswordHash.Text = AspNetUsersTable.PasswordHash.Format(AspNetUsersTable.PasswordHash.DefaultValue);
            		
            }
            
            // If the PasswordHash is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PasswordHash.Text == null ||
                this.PasswordHash.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PasswordHash.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPhoneNumber()
        {
            
                    
            // Set the PhoneNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.PhoneNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PhoneNumberSpecified) {
                								
                // If the PhoneNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.PhoneNumber);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(AspNetUsersTable.PhoneNumber.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IDE.Business.AspNetUsersTable, IDE.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"PhoneNumber\\\", \\\"PhoneNumber\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.PhoneNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // PhoneNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PhoneNumber.Text = AspNetUsersTable.PhoneNumber.Format(AspNetUsersTable.PhoneNumber.DefaultValue);
            		
            }
            
            // If the PhoneNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PhoneNumber.Text == null ||
                this.PhoneNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PhoneNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPhoneNumberConfirmed()
        {
            
                    
            // Set the PhoneNumberConfirmed Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.PhoneNumberConfirmed is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PhoneNumberConfirmedSpecified) {
                								
                // If the PhoneNumberConfirmed is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.PhoneNumberConfirmed);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PhoneNumberConfirmed.Text = formattedValue;
                   
            } 
            
            else {
            
                // PhoneNumberConfirmed is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PhoneNumberConfirmed.Text = AspNetUsersTable.PhoneNumberConfirmed.Format(AspNetUsersTable.PhoneNumberConfirmed.DefaultValue);
            		
            }
            
            // If the PhoneNumberConfirmed is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PhoneNumberConfirmed.Text == null ||
                this.PhoneNumberConfirmed.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PhoneNumberConfirmed.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSecurityStamp()
        {
            
                    
            // Set the SecurityStamp Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.SecurityStamp is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SecurityStampSpecified) {
                								
                // If the SecurityStamp is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.SecurityStamp);
                                
                if(formattedValue != null){
                    int popupThreshold = (int)(300);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue); 
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(AspNetUsersTable.SecurityStamp.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IDE.Business.AspNetUsersTable, IDE.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"SecurityStamp\\\", \\\"SecurityStamp\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                            formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                        else
                        {
                          formattedValue = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>" + formattedValue + "</td></tr></table>";
                        }
                          
                    }
                }
                
                this.SecurityStamp.Text = formattedValue;
                   
            } 
            
            else {
            
                // SecurityStamp is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SecurityStamp.Text = AspNetUsersTable.SecurityStamp.Format(AspNetUsersTable.SecurityStamp.DefaultValue);
            		
            }
            
            // If the SecurityStamp is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SecurityStamp.Text == null ||
                this.SecurityStamp.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SecurityStamp.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTwoFactorEnabled()
        {
            
                    
            // Set the TwoFactorEnabled Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.TwoFactorEnabled is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TwoFactorEnabledSpecified) {
                								
                // If the TwoFactorEnabled is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.TwoFactorEnabled);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TwoFactorEnabled.Text = formattedValue;
                   
            } 
            
            else {
            
                // TwoFactorEnabled is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TwoFactorEnabled.Text = AspNetUsersTable.TwoFactorEnabled.Format(AspNetUsersTable.TwoFactorEnabled.DefaultValue);
            		
            }
            
            // If the TwoFactorEnabled is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TwoFactorEnabled.Text == null ||
                this.TwoFactorEnabled.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TwoFactorEnabled.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetUserName0()
        {
            
                    
            // Set the UserName Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.AspNetUsers database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.AspNetUsers record retrieved from the database.
            // this.UserName0 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.UserName0Specified) {
                								
                // If the UserName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(AspNetUsersTable.UserName0);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.UserName0.Text = formattedValue;
                   
            } 
            
            else {
            
                // UserName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.UserName0.Text = AspNetUsersTable.UserName0.Format(AspNetUsersTable.UserName0.DefaultValue);
            		
            }
            
            // If the UserName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.UserName0.Text == null ||
                this.UserName0.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.UserName0.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAccessFailedCountLabel()
                  {
                  
                    
        }
                
        public virtual void SetCompanyLogoLabel()
                  {
                  
                    
        }
                
        public virtual void SetEmailConfirmedLabel()
                  {
                  
                    
        }
                
        public virtual void SetEmailLabel()
                  {
                  
                    
        }
                
        public virtual void SetFirstNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetLockoutEnabledLabel()
                  {
                  
                    
        }
                
        public virtual void SetLockoutEndDateUtcLabel()
                  {
                  
                    
        }
                
        public virtual void SetPasswordHashLabel()
                  {
                  
                    
        }
                
        public virtual void SetPhoneNumberConfirmedLabel()
                  {
                  
                    
        }
                
        public virtual void SetPhoneNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetSecurityStampLabel()
                  {
                  
                    
        }
                
        public virtual void SetTwoFactorEnabledLabel()
                  {
                  
                    
        }
                
        public virtual void SetUserNameLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "AspNetUsersRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
            }
          InvoiceSummariesTableControlRow parentCtrl;
      
            parentCtrl = (InvoiceSummariesTableControlRow)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          this.DataSource.Id0 = parentCtrl.DataSource.ApprovedById;
        
          
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
        
            GetAccessFailedCount();
            GetCompanyLogo();
            GetEmail();
            GetEmailConfirmed();
            GetFirstName();
            GetId0();
            GetLastName();
            GetLockoutEnabled();
            GetLockoutEndDateUtc();
            GetPasswordHash();
            GetPhoneNumber();
            GetPhoneNumberConfirmed();
            GetSecurityStamp();
            GetTwoFactorEnabled();
            GetUserName0();
        }
        
        
        public virtual void GetAccessFailedCount()
        {
            
        }
                
        public virtual void GetCompanyLogo()
        {
            
        }
                
        public virtual void GetEmail()
        {
            
        }
                
        public virtual void GetEmailConfirmed()
        {
            
        }
                
        public virtual void GetFirstName()
        {
            
        }
                
        public virtual void GetId0()
        {
            
        }
                
        public virtual void GetLastName()
        {
            
        }
                
        public virtual void GetLockoutEnabled()
        {
            
        }
                
        public virtual void GetLockoutEndDateUtc()
        {
            
        }
                
        public virtual void GetPasswordHash()
        {
            
        }
                
        public virtual void GetPhoneNumber()
        {
            
        }
                
        public virtual void GetPhoneNumberConfirmed()
        {
            
        }
                
        public virtual void GetSecurityStamp()
        {
            
        }
                
        public virtual void GetTwoFactorEnabled()
        {
            
        }
                
        public virtual void GetUserName0()
        {
            
        }
                

      // To customize, override this method in AspNetUsersRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAspNetUsersRecordControl = false;
            hasFiltersAspNetUsersRecordControl = hasFiltersAspNetUsersRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            WhereClause wc;
            AspNetUsersTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue invoiceSummariesRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = invoiceSummariesRecordObj;
          invoiceSummariesRecordObj = tmp;
        InvoiceSummariesTableControlRow invoiceSummariesTableControlObjRow = (MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow") as InvoiceSummariesTableControlRow);
          
              if (invoiceSummariesTableControlObjRow != null && invoiceSummariesTableControlObjRow.GetRecord() != null && invoiceSummariesTableControlObjRow.GetRecord().ApprovedById != null)
              {
              wc.iAND(AspNetUsersTable.Id0, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesTableControlObjRow.GetRecord().ApprovedById.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["AspNetUsersRecordControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            AspNetUsersTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersAspNetUsersRecordControl = false;
            hasFiltersAspNetUsersRecordControl = hasFiltersAspNetUsersRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesTableControl = HttpContext.Current.Session["AspNetUsersRecordControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesTableControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(AspNetUsersTable.Id0))
      {
      wc.iAND(AspNetUsersTable.Id0, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(AspNetUsersTable.Id0).ToString());
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
          AspNetUsersTable.DeleteRecord(pkValue);
          
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
                return (string)this.ViewState["BaseAspNetUsersRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseAspNetUsersRecordControl_Rec"] = value;
            }
        }
        
        public AspNetUsersRecord DataSource {
            get {
                return (AspNetUsersRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal AccessFailedCount {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccessFailedCount");
            }
        }
            
        public System.Web.UI.WebControls.Literal AccessFailedCountLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccessFailedCountLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CompanyLogo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyLogo");
            }
        }
            
        public System.Web.UI.WebControls.Literal CompanyLogoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyLogoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Email {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Email");
            }
        }
            
        public System.Web.UI.WebControls.Literal EmailConfirmed {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EmailConfirmed");
            }
        }
            
        public System.Web.UI.WebControls.Literal EmailConfirmedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EmailConfirmedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal EmailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EmailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirstName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName");
            }
        }
            
        public System.Web.UI.WebControls.Literal FirstNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Id0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Id0");
            }
        }
            
        public System.Web.UI.WebControls.Literal IdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LastName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LockoutEnabled {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LockoutEnabled");
            }
        }
            
        public System.Web.UI.WebControls.Literal LockoutEnabledLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LockoutEnabledLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LockoutEndDateUtc {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LockoutEndDateUtc");
            }
        }
            
        public System.Web.UI.WebControls.Literal LockoutEndDateUtcLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LockoutEndDateUtcLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PasswordHash {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PasswordHash");
            }
        }
            
        public System.Web.UI.WebControls.Literal PasswordHashLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PasswordHashLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PhoneNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal PhoneNumberConfirmed {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumberConfirmed");
            }
        }
            
        public System.Web.UI.WebControls.Literal PhoneNumberConfirmedLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumberConfirmedLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PhoneNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal SecurityStamp {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SecurityStamp");
            }
        }
            
        public System.Web.UI.WebControls.Literal SecurityStampLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SecurityStampLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TwoFactorEnabled {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TwoFactorEnabled");
            }
        }
            
        public System.Web.UI.WebControls.Literal TwoFactorEnabledLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TwoFactorEnabledLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal UserName0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserName0");
            }
        }
            
        public System.Web.UI.WebControls.Literal UserNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserNameLabel");
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
        AspNetUsersRecord rec = null;
             
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
    AspNetUsersRecord rec = null;
    
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

        
        public virtual AspNetUsersRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return AspNetUsersTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the SitesRecordControl control on the Show_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in SitesRecordControl.
public class BaseSitesRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseSitesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in SitesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in SitesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.Sites record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "SitesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new SitesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            SitesRecord[] recList = SitesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = SitesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetSiteName2();
                SetSiteNameLabel2();

      

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
        
        
        public virtual void SetSiteName2()
        {
            
                    
            // Set the SiteName Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.Sites database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.Sites record retrieved from the database.
            // this.SiteName2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SiteNameSpecified) {
                								
                // If the SiteName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SitesTable.SiteName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SiteName2.Text = formattedValue;
                   
            } 
            
            else {
            
                // SiteName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SiteName2.Text = SitesTable.SiteName.Format(SitesTable.SiteName.DefaultValue);
            		
            }
            
            // If the SiteName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SiteName2.Text == null ||
                this.SiteName2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SiteName2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSiteNameLabel2()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "SitesRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
            }
          InvoiceSummariesTableControlRow parentCtrl;
      
            parentCtrl = (InvoiceSummariesTableControlRow)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
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
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetSiteName2();
        }
        
        
        public virtual void GetSiteName2()
        {
            
        }
                

      // To customize, override this method in SitesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersAspNetUsersRecordControl = false;
            hasFiltersAspNetUsersRecordControl = hasFiltersAspNetUsersRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            WhereClause wc;
            SitesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue invoiceSummariesRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = invoiceSummariesRecordObj;
          invoiceSummariesRecordObj = tmp;
        InvoiceSummariesTableControlRow invoiceSummariesTableControlObjRow = (MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow") as InvoiceSummariesTableControlRow);
          
              if (invoiceSummariesTableControlObjRow != null && invoiceSummariesTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(SitesTable.SiteId, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesTableControlObjRow.GetRecord().SiteId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["SitesRecordControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            SitesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersAspNetUsersRecordControl = false;
            hasFiltersAspNetUsersRecordControl = hasFiltersAspNetUsersRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesTableControl = HttpContext.Current.Session["SitesRecordControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesTableControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(SitesTable.SiteId))
      {
      wc.iAND(SitesTable.SiteId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(SitesTable.SiteId).ToString());
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
          SitesTable.DeleteRecord(pkValue);
          
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
                return (string)this.ViewState["BaseSitesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseSitesRecordControl_Rec"] = value;
            }
        }
        
        public SitesRecord DataSource {
            get {
                return (SitesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal SiteName2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteName2");
            }
        }
            
        public System.Web.UI.WebControls.Literal SiteNameLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteNameLabel2");
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
        SitesRecord rec = null;
             
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
    SitesRecord rec = null;
    
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

        
        public virtual SitesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return SitesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
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

  