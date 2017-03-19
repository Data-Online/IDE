
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_EnergyPoints.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IDE.UI.Controls.Show_EnergyPoints
{
  

#region "Section 1: Place your customizations here."

    
public class InvoiceSummariesTableControl1Row : BaseInvoiceSummariesTableControl1Row
{
      
        // The BaseInvoiceSummariesTableControl1Row implements code for a ROW within the
        // the InvoiceSummariesTableControl1 table.  The BaseInvoiceSummariesTableControl1Row implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of InvoiceSummariesTableControl1.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class InvoiceSummariesTableControl1 : BaseInvoiceSummariesTableControl1
{
    // The BaseInvoiceSummariesTableControl1 class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The InvoiceSummariesTableControl1Row class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  
public class EnergyPointsRecordControl : BaseEnergyPointsRecordControl
{
      
        // The BaseEnergyPointsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the InvoiceSummariesTableControl1Row control on the Show_EnergyPoints page.
// Do not modify this class. Instead override any method in InvoiceSummariesTableControl1Row.
public class BaseInvoiceSummariesTableControl1Row : IDE.UI.BaseApplicationRecordControl
{
        public BaseInvoiceSummariesTableControl1Row()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in InvoiceSummariesTableControl1Row.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in InvoiceSummariesTableControl1Row.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton1.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IDE") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton1.Click += DeleteRowButton1_Click;
                        
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
                    this.SiteId2.Click += SiteId2_Click;
                        
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
            // LoadData method of the BaseInvoiceSummariesTableControl1 when the data for the entire
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
        
                SetAccountNumber2();
                SetAccountNumberLabel1();
                SetApproved2();
                SetApprovedById2();
                SetApprovedByIdLabel2();
                SetApprovedDate2();
                SetApprovedDateLabel1();
                SetApprovedLabel1();
                SetConnectionNumber2();
                SetConnectionNumberLabel1();
                SetCustomerNumber2();
                SetCustomerNumberLabel1();
                
                
                SetEnergyChargesTotal1();
                SetEnergyChargesTotalLabel1();
                SetGSTCharges1();
                SetGSTChargesLabel1();
                SetGstTotal1();
                SetGstTotalLabel1();
                SetInvoiceDate2();
                SetInvoiceDateLabel1();
                SetInvoiceDueDate2();
                SetInvoiceDueDateLabel1();
                SetInvoiceId1();
                SetInvoiceIdLabel1();
                SetInvoiceNumber1();
                SetInvoiceNumberLabel1();
                SetInvoiceTotal1();
                SetInvoiceTotalLabel1();
                SetMiscChargesTotal1();
                SetMiscChargesTotalLabel1();
                SetMonth1();
                SetMonthLabel1();
                SetNetworkChargesTotal1();
                SetNetworkChargesTotalLabel1();
                SetPercentageChange1();
                SetPercentageChangeLabel1();
                SetPeriodEnd1();
                SetPeriodEndLabel1();
                SetPeriodStart1();
                SetPeriodStartLabel1();
                SetSiteId2();
                SetSiteIdLabel2();
                SetSiteName2();
                SetSiteNameLabel1();
                SetTotalCharges1();
                SetTotalChargesLabel1();
                SetTotalEnergyCharges1();
                SetTotalEnergyChargesLabel1();
                SetTotalMiscCharges1();
                SetTotalMiscChargesLabel1();
                SetTotalNetworkCharges1();
                SetTotalNetworkChargesLabel1();
                SetYear1();
                SetYearLabel1();
                SetDeleteRowButton1();
              
                SetEditRowButton1();
              

      

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
        
        
        public virtual void SetAccountNumber2()
        {
            
                    
            // Set the AccountNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.AccountNumber2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AccountNumberSpecified) {
                								
                // If the AccountNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.AccountNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AccountNumber2.Text = formattedValue;
                   
            } 
            
            else {
            
                // AccountNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AccountNumber2.Text = InvoiceSummariesTable.AccountNumber.Format(InvoiceSummariesTable.AccountNumber.DefaultValue);
            		
            }
            
            // If the AccountNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AccountNumber2.Text == null ||
                this.AccountNumber2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AccountNumber2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetApproved2()
        {
            
                    
            // Set the Approved Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Approved2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ApprovedSpecified) {
                								
                // If the Approved is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.Approved);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Approved2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Approved is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Approved2.Text = InvoiceSummariesTable.Approved.Format(InvoiceSummariesTable.Approved.DefaultValue);
            		
            }
            
            // If the Approved is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Approved2.Text == null ||
                this.Approved2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Approved2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetApprovedById2()
        {
            
                    
            // Set the ApprovedById Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ApprovedById2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ApprovedByIdSpecified) {
                								
                // If the ApprovedById is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.ApprovedById);
               if(_isExpandableNonCompositeForeignKey &&InvoiceSummariesTable.ApprovedById.IsApplyDisplayAs)
                                  
                     formattedValue = InvoiceSummariesTable.GetDFKA(this.DataSource.ApprovedById.ToString(),InvoiceSummariesTable.ApprovedById, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(InvoiceSummariesTable.ApprovedById);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ApprovedById2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ApprovedById is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ApprovedById2.Text = InvoiceSummariesTable.ApprovedById.Format(InvoiceSummariesTable.ApprovedById.DefaultValue);
            		
            }
            
            // If the ApprovedById is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ApprovedById2.Text == null ||
                this.ApprovedById2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ApprovedById2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetApprovedDate2()
        {
            
                    
            // Set the ApprovedDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ApprovedDate2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ApprovedDateSpecified) {
                								
                // If the ApprovedDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.ApprovedDate, @"g");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ApprovedDate2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ApprovedDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ApprovedDate2.Text = InvoiceSummariesTable.ApprovedDate.Format(InvoiceSummariesTable.ApprovedDate.DefaultValue, @"g");
            		
            }
            
            // If the ApprovedDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ApprovedDate2.Text == null ||
                this.ApprovedDate2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ApprovedDate2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetConnectionNumber2()
        {
            
                    
            // Set the ConnectionNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ConnectionNumber2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ConnectionNumberSpecified) {
                								
                // If the ConnectionNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.ConnectionNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ConnectionNumber2.Text = formattedValue;
                   
            } 
            
            else {
            
                // ConnectionNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ConnectionNumber2.Text = InvoiceSummariesTable.ConnectionNumber.Format(InvoiceSummariesTable.ConnectionNumber.DefaultValue);
            		
            }
            
            // If the ConnectionNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ConnectionNumber2.Text == null ||
                this.ConnectionNumber2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ConnectionNumber2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustomerNumber2()
        {
            
                    
            // Set the CustomerNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.CustomerNumber2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustomerNumberSpecified) {
                								
                // If the CustomerNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.CustomerNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustomerNumber2.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustomerNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustomerNumber2.Text = InvoiceSummariesTable.CustomerNumber.Format(InvoiceSummariesTable.CustomerNumber.DefaultValue);
            		
            }
            
            // If the CustomerNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustomerNumber2.Text == null ||
                this.CustomerNumber2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustomerNumber2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEnergyChargesTotal1()
        {
            
                    
            // Set the EnergyChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.EnergyChargesTotal1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EnergyChargesTotalSpecified) {
                								
                // If the EnergyChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.EnergyChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EnergyChargesTotal1.Text = formattedValue;
                   
            } 
            
            else {
            
                // EnergyChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EnergyChargesTotal1.Text = InvoiceSummariesTable.EnergyChargesTotal.Format(InvoiceSummariesTable.EnergyChargesTotal.DefaultValue);
            		
            }
            
            // If the EnergyChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EnergyChargesTotal1.Text == null ||
                this.EnergyChargesTotal1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EnergyChargesTotal1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetGSTCharges1()
        {
            
                    
            // Set the GSTCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.GSTCharges1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GSTChargesSpecified) {
                								
                // If the GSTCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.GSTCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.GSTCharges1.Text = formattedValue;
                   
            } 
            
            else {
            
                // GSTCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GSTCharges1.Text = InvoiceSummariesTable.GSTCharges.Format(InvoiceSummariesTable.GSTCharges.DefaultValue);
            		
            }
            
            // If the GSTCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.GSTCharges1.Text == null ||
                this.GSTCharges1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.GSTCharges1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetGstTotal1()
        {
            
                    
            // Set the GstTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.GstTotal1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GstTotalSpecified) {
                								
                // If the GstTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.GstTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.GstTotal1.Text = formattedValue;
                   
            } 
            
            else {
            
                // GstTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GstTotal1.Text = InvoiceSummariesTable.GstTotal.Format(InvoiceSummariesTable.GstTotal.DefaultValue);
            		
            }
            
            // If the GstTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.GstTotal1.Text == null ||
                this.GstTotal1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.GstTotal1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceDate2()
        {
            
                    
            // Set the InvoiceDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDate2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDateSpecified) {
                								
                // If the InvoiceDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceDate2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDate2.Text = InvoiceSummariesTable.InvoiceDate.Format(InvoiceSummariesTable.InvoiceDate.DefaultValue);
            		
            }
            
            // If the InvoiceDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceDate2.Text == null ||
                this.InvoiceDate2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceDate2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceDueDate2()
        {
            
                    
            // Set the InvoiceDueDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDueDate2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDueDateSpecified) {
                								
                // If the InvoiceDueDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDueDate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceDueDate2.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDueDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDueDate2.Text = InvoiceSummariesTable.InvoiceDueDate.Format(InvoiceSummariesTable.InvoiceDueDate.DefaultValue);
            		
            }
            
            // If the InvoiceDueDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceDueDate2.Text == null ||
                this.InvoiceDueDate2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceDueDate2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceId1()
        {
            
                    
            // Set the InvoiceId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceId1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceIdSpecified) {
                								
                // If the InvoiceId is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceId);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceId1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceId1.Text = InvoiceSummariesTable.InvoiceId.Format(InvoiceSummariesTable.InvoiceId.DefaultValue);
            		
            }
            
            // If the InvoiceId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceId1.Text == null ||
                this.InvoiceId1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceId1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceNumber1()
        {
            
                    
            // Set the InvoiceNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceNumber1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceNumberSpecified) {
                								
                // If the InvoiceNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceNumber1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceNumber1.Text = InvoiceSummariesTable.InvoiceNumber.Format(InvoiceSummariesTable.InvoiceNumber.DefaultValue);
            		
            }
            
            // If the InvoiceNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceNumber1.Text == null ||
                this.InvoiceNumber1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceNumber1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceTotal1()
        {
            
                    
            // Set the InvoiceTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceTotal1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceTotalSpecified) {
                								
                // If the InvoiceTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceTotal1.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceTotal1.Text = InvoiceSummariesTable.InvoiceTotal.Format(InvoiceSummariesTable.InvoiceTotal.DefaultValue);
            		
            }
            
            // If the InvoiceTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceTotal1.Text == null ||
                this.InvoiceTotal1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceTotal1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetMiscChargesTotal1()
        {
            
                    
            // Set the MiscChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.MiscChargesTotal1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MiscChargesTotalSpecified) {
                								
                // If the MiscChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.MiscChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.MiscChargesTotal1.Text = formattedValue;
                   
            } 
            
            else {
            
                // MiscChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.MiscChargesTotal1.Text = InvoiceSummariesTable.MiscChargesTotal.Format(InvoiceSummariesTable.MiscChargesTotal.DefaultValue);
            		
            }
            
            // If the MiscChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.MiscChargesTotal1.Text == null ||
                this.MiscChargesTotal1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.MiscChargesTotal1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetMonth1()
        {
            
                    
            // Set the Month Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Month1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MonthSpecified) {
                								
                // If the Month is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.Month);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Month1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Month is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Month1.Text = InvoiceSummariesTable.Month.Format(InvoiceSummariesTable.Month.DefaultValue);
            		
            }
            
            // If the Month is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Month1.Text == null ||
                this.Month1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Month1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNetworkChargesTotal1()
        {
            
                    
            // Set the NetworkChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.NetworkChargesTotal1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NetworkChargesTotalSpecified) {
                								
                // If the NetworkChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.NetworkChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NetworkChargesTotal1.Text = formattedValue;
                   
            } 
            
            else {
            
                // NetworkChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NetworkChargesTotal1.Text = InvoiceSummariesTable.NetworkChargesTotal.Format(InvoiceSummariesTable.NetworkChargesTotal.DefaultValue);
            		
            }
            
            // If the NetworkChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NetworkChargesTotal1.Text == null ||
                this.NetworkChargesTotal1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NetworkChargesTotal1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPercentageChange1()
        {
            
                    
            // Set the PercentageChange Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PercentageChange1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PercentageChangeSpecified) {
                								
                // If the PercentageChange is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PercentageChange);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PercentageChange1.Text = formattedValue;
                   
            } 
            
            else {
            
                // PercentageChange is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PercentageChange1.Text = InvoiceSummariesTable.PercentageChange.Format(InvoiceSummariesTable.PercentageChange.DefaultValue);
            		
            }
            
            // If the PercentageChange is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PercentageChange1.Text == null ||
                this.PercentageChange1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PercentageChange1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPeriodEnd1()
        {
            
                    
            // Set the PeriodEnd Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PeriodEnd1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PeriodEndSpecified) {
                								
                // If the PeriodEnd is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PeriodEnd);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PeriodEnd1.Text = formattedValue;
                   
            } 
            
            else {
            
                // PeriodEnd is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PeriodEnd1.Text = InvoiceSummariesTable.PeriodEnd.Format(InvoiceSummariesTable.PeriodEnd.DefaultValue);
            		
            }
            
            // If the PeriodEnd is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PeriodEnd1.Text == null ||
                this.PeriodEnd1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PeriodEnd1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPeriodStart1()
        {
            
                    
            // Set the PeriodStart Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PeriodStart1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PeriodStartSpecified) {
                								
                // If the PeriodStart is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PeriodStart);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PeriodStart1.Text = formattedValue;
                   
            } 
            
            else {
            
                // PeriodStart is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PeriodStart1.Text = InvoiceSummariesTable.PeriodStart.Format(InvoiceSummariesTable.PeriodStart.DefaultValue);
            		
            }
            
            // If the PeriodStart is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PeriodStart1.Text == null ||
                this.PeriodStart1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PeriodStart1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSiteId2()
        {
            
                    
            // Set the SiteId LinkButton on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SiteId2 is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SiteIdSpecified) {
                								
                // If the SiteId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SiteId);
               if(_isExpandableNonCompositeForeignKey &&InvoiceSummariesTable.SiteId.IsApplyDisplayAs)
                                  
                     formattedValue = InvoiceSummariesTable.GetDFKA(this.DataSource.SiteId.ToString(),InvoiceSummariesTable.SiteId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(InvoiceSummariesTable.SiteId);
                                  
                                
                this.SiteId2.Text = formattedValue;
                
                  this.SiteId2.ToolTip = "Go to " + this.SiteId2.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // SiteId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SiteId2.Text = InvoiceSummariesTable.SiteId.Format(InvoiceSummariesTable.SiteId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetSiteName2()
        {
            
                    
            // Set the SiteName Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SiteName2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SiteNameSpecified) {
                								
                // If the SiteName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.SiteName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SiteName2.Text = formattedValue;
                   
            } 
            
            else {
            
                // SiteName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SiteName2.Text = InvoiceSummariesTable.SiteName.Format(InvoiceSummariesTable.SiteName.DefaultValue);
            		
            }
            
            // If the SiteName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SiteName2.Text == null ||
                this.SiteName2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SiteName2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalCharges1()
        {
            
                    
            // Set the TotalCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalCharges1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalChargesSpecified) {
                								
                // If the TotalCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalCharges1.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalCharges1.Text = InvoiceSummariesTable.TotalCharges.Format(InvoiceSummariesTable.TotalCharges.DefaultValue);
            		
            }
            
            // If the TotalCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalCharges1.Text == null ||
                this.TotalCharges1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalCharges1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalEnergyCharges1()
        {
            
                    
            // Set the TotalEnergyCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalEnergyCharges1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalEnergyChargesSpecified) {
                								
                // If the TotalEnergyCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalEnergyCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalEnergyCharges1.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalEnergyCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalEnergyCharges1.Text = InvoiceSummariesTable.TotalEnergyCharges.Format(InvoiceSummariesTable.TotalEnergyCharges.DefaultValue);
            		
            }
            
            // If the TotalEnergyCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalEnergyCharges1.Text == null ||
                this.TotalEnergyCharges1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalEnergyCharges1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalMiscCharges1()
        {
            
                    
            // Set the TotalMiscCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalMiscCharges1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalMiscChargesSpecified) {
                								
                // If the TotalMiscCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalMiscCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalMiscCharges1.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalMiscCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalMiscCharges1.Text = InvoiceSummariesTable.TotalMiscCharges.Format(InvoiceSummariesTable.TotalMiscCharges.DefaultValue);
            		
            }
            
            // If the TotalMiscCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalMiscCharges1.Text == null ||
                this.TotalMiscCharges1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalMiscCharges1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTotalNetworkCharges1()
        {
            
                    
            // Set the TotalNetworkCharges Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.TotalNetworkCharges1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TotalNetworkChargesSpecified) {
                								
                // If the TotalNetworkCharges is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.TotalNetworkCharges);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TotalNetworkCharges1.Text = formattedValue;
                   
            } 
            
            else {
            
                // TotalNetworkCharges is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TotalNetworkCharges1.Text = InvoiceSummariesTable.TotalNetworkCharges.Format(InvoiceSummariesTable.TotalNetworkCharges.DefaultValue);
            		
            }
            
            // If the TotalNetworkCharges is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TotalNetworkCharges1.Text == null ||
                this.TotalNetworkCharges1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TotalNetworkCharges1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetYear1()
        {
            
                    
            // Set the Year Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.Year1 is the ASP:Literal on the webpage.
                  
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
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"Year\\\", \\\"Year1\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IDE") + "\\\", " +
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
                
                this.Year1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Year is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Year1.Text = InvoiceSummariesTable.Year.Format(InvoiceSummariesTable.Year.DefaultValue);
            		
            }
            
            // If the Year is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Year1.Text == null ||
                this.Year1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Year1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAccountNumberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetApprovedByIdLabel2()
                  {
                  
                    
        }
                
        public virtual void SetApprovedDateLabel1()
                  {
                  
                    
        }
                
        public virtual void SetApprovedLabel1()
                  {
                  
                    
        }
                
        public virtual void SetConnectionNumberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetCustomerNumberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetEnergyChargesTotalLabel1()
                  {
                  
                    
        }
                
        public virtual void SetGSTChargesLabel1()
                  {
                  
                    
        }
                
        public virtual void SetGstTotalLabel1()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceDateLabel1()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceDueDateLabel1()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceNumberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceTotalLabel1()
                  {
                  
                    
        }
                
        public virtual void SetMiscChargesTotalLabel1()
                  {
                  
                        this.MiscChargesTotalLabel1.Text = EvaluateFormula("\"Other Charges Total\"");
                      
                    
        }
                
        public virtual void SetMonthLabel1()
                  {
                  
                    
        }
                
        public virtual void SetNetworkChargesTotalLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPercentageChangeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPeriodEndLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPeriodStartLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSiteIdLabel2()
                  {
                  
                    
        }
                
        public virtual void SetSiteNameLabel1()
                  {
                  
                    
        }
                
        public virtual void SetTotalChargesLabel1()
                  {
                  
                    
        }
                
        public virtual void SetTotalEnergyChargesLabel1()
                  {
                  
                    
        }
                
        public virtual void SetTotalMiscChargesLabel1()
                  {
                  
                    
        }
                
        public virtual void SetTotalNetworkChargesLabel1()
                  {
                  
                        this.TotalNetworkChargesLabel1.Text = EvaluateFormula("\"Total Network/Line Charges\"");
                      
                    
        }
                
        public virtual void SetYearLabel1()
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
        EnergyPointsRecordControl parentCtrl;
      
            parentCtrl = (EnergyPointsRecordControl)this.Page.FindControlRecursively("EnergyPointsRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          this.DataSource.EnergyPointId = parentCtrl.DataSource.EnergyPointId;
        
          
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
                ((InvoiceSummariesTableControl1)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl1")).DataChanged = true;
                ((InvoiceSummariesTableControl1)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl1")).ResetData = true;
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
        
            GetAccountNumber2();
            GetApproved2();
            GetApprovedById2();
            GetApprovedDate2();
            GetConnectionNumber2();
            GetCustomerNumber2();
            GetEnergyChargesTotal1();
            GetGSTCharges1();
            GetGstTotal1();
            GetInvoiceDate2();
            GetInvoiceDueDate2();
            GetInvoiceId1();
            GetInvoiceNumber1();
            GetInvoiceTotal1();
            GetMiscChargesTotal1();
            GetMonth1();
            GetNetworkChargesTotal1();
            GetPercentageChange1();
            GetPeriodEnd1();
            GetPeriodStart1();
            GetSiteId2();
            GetSiteName2();
            GetTotalCharges1();
            GetTotalEnergyCharges1();
            GetTotalMiscCharges1();
            GetTotalNetworkCharges1();
            GetYear1();
        }
        
        
        public virtual void GetAccountNumber2()
        {
            
        }
                
        public virtual void GetApproved2()
        {
            
        }
                
        public virtual void GetApprovedById2()
        {
            
        }
                
        public virtual void GetApprovedDate2()
        {
            
        }
                
        public virtual void GetConnectionNumber2()
        {
            
        }
                
        public virtual void GetCustomerNumber2()
        {
            
        }
                
        public virtual void GetEnergyChargesTotal1()
        {
            
        }
                
        public virtual void GetGSTCharges1()
        {
            
        }
                
        public virtual void GetGstTotal1()
        {
            
        }
                
        public virtual void GetInvoiceDate2()
        {
            
        }
                
        public virtual void GetInvoiceDueDate2()
        {
            
        }
                
        public virtual void GetInvoiceId1()
        {
            
        }
                
        public virtual void GetInvoiceNumber1()
        {
            
        }
                
        public virtual void GetInvoiceTotal1()
        {
            
        }
                
        public virtual void GetMiscChargesTotal1()
        {
            
        }
                
        public virtual void GetMonth1()
        {
            
        }
                
        public virtual void GetNetworkChargesTotal1()
        {
            
        }
                
        public virtual void GetPercentageChange1()
        {
            
        }
                
        public virtual void GetPeriodEnd1()
        {
            
        }
                
        public virtual void GetPeriodStart1()
        {
            
        }
                
        public virtual void GetSiteId2()
        {
            
        }
                
        public virtual void GetSiteName2()
        {
            
        }
                
        public virtual void GetTotalCharges1()
        {
            
        }
                
        public virtual void GetTotalEnergyCharges1()
        {
            
        }
                
        public virtual void GetTotalMiscCharges1()
        {
            
        }
                
        public virtual void GetTotalNetworkCharges1()
        {
            
        }
                
        public virtual void GetYear1()
        {
            
        }
                

      // To customize, override this method in InvoiceSummariesTableControl1Row.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyPointsRecordControl = false;
            hasFiltersEnergyPointsRecordControl = hasFiltersEnergyPointsRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl1 = false;
            hasFiltersInvoiceSummariesTableControl1 = hasFiltersInvoiceSummariesTableControl1 && false; // suppress warning
      
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
            ((InvoiceSummariesTableControl1)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl1")).DataChanged = true;
            ((InvoiceSummariesTableControl1)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl1")).ResetData = true;
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
        
        public virtual void SetDeleteRowButton1()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton1()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton1_Click(object sender, ImageClickEventArgs args)
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
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for LinkButton
        public virtual void SiteId2_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Sites/Show-Sites.aspx?Sites={InvoiceSummariesTableControl1Row:FK:VFK_DatabaseCimscoPortal%dbo.InvoiceSummaries_SiteId_1}";
            
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
                return (string)this.ViewState["BaseInvoiceSummariesTableControl1Row_Rec"];
            }
            set {
                this.ViewState["BaseInvoiceSummariesTableControl1Row_Rec"] = value;
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
        
        public System.Web.UI.WebControls.Literal AccountNumber2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumber2");
            }
        }
            
        public System.Web.UI.WebControls.Literal AccountNumberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Approved2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Approved2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ApprovedById2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedById2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ApprovedByIdLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedByIdLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal ApprovedDate2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedDate2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ApprovedDateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedDateLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal ApprovedLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ApprovedLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal ConnectionNumber2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumber2");
            }
        }
            
        public System.Web.UI.WebControls.Literal ConnectionNumberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustomerNumber2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerNumber2");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustomerNumberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerNumberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.Literal EnergyChargesTotal1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotal1");
            }
        }
            
        public System.Web.UI.WebControls.Literal EnergyChargesTotalLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotalLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal GSTCharges1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSTCharges1");
            }
        }
            
        public System.Web.UI.WebControls.Literal GSTChargesLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSTChargesLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal GstTotal1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotal1");
            }
        }
            
        public System.Web.UI.WebControls.Literal GstTotalLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotalLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceDate2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDate2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDateLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceDueDate2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDate2");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDueDateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDateLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceId1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceId1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceNumber1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumber1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceNumberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceTotal1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotal1");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceTotalLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotalLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal MiscChargesTotal1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotal1");
            }
        }
            
        public System.Web.UI.WebControls.Literal MiscChargesTotalLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotalLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Month1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Month1");
            }
        }
            
        public System.Web.UI.WebControls.Literal MonthLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal NetworkChargesTotal1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotal1");
            }
        }
            
        public System.Web.UI.WebControls.Literal NetworkChargesTotalLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotalLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal PercentageChange1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PercentageChange1");
            }
        }
            
        public System.Web.UI.WebControls.Literal PercentageChangeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PercentageChangeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal PeriodEnd1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodEnd1");
            }
        }
            
        public System.Web.UI.WebControls.Literal PeriodEndLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodEndLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal PeriodStart1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodStart1");
            }
        }
            
        public System.Web.UI.WebControls.Literal PeriodStartLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodStartLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton SiteId2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteId2");
            }
        }
            
        public System.Web.UI.WebControls.Literal SiteIdLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteIdLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal SiteName2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteName2");
            }
        }
            
        public System.Web.UI.WebControls.Literal SiteNameLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalCharges1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalCharges1");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalChargesLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalChargesLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalEnergyCharges1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalEnergyCharges1");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalEnergyChargesLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalEnergyChargesLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalMiscCharges1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalMiscCharges1");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalMiscChargesLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalMiscChargesLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal TotalNetworkCharges1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalNetworkCharges1");
            }
        }
            
        public System.Web.UI.WebControls.Literal TotalNetworkChargesLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TotalNetworkChargesLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Year1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Year1");
            }
        }
            
        public System.Web.UI.WebControls.Literal YearLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearLabel1");
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

  
// Base class for the InvoiceSummariesTableControl1 control on the Show_EnergyPoints page.
// Do not modify this class. Instead override any method in InvoiceSummariesTableControl1.
public class BaseInvoiceSummariesTableControl1 : IDE.UI.BaseApplicationTableControl
{
         
       public BaseInvoiceSummariesTableControl1()
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
                
                if  (this.InSession(this.OrderSort2)) 				
                    initialVal = this.GetFromSession(this.OrderSort2);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort2.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort2.SelectedValue = initialVal;
                            
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
            
                    this.Pagination1.FirstPage.Click += Pagination1_FirstPage_Click;
                        
                    this.Pagination1.LastPage.Click += Pagination1_LastPage_Click;
                        
                    this.Pagination1.NextPage.Click += Pagination1_NextPage_Click;
                        
                    this.Pagination1.PageSizeButton.Click += Pagination1_PageSizeButton_Click;
                        
                    this.Pagination1.PreviousPage.Click += Pagination1_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ExcelButton1.Click += ExcelButton1_Click;
                        
                    this.ImportButton1.Click += ImportButton1_Click;
                        
                    this.NewButton1.Click += NewButton1_Click;
                        
                    this.PDFButton1.Click += PDFButton1_Click;
                        
                    this.WordButton1.Click += WordButton1_Click;
                        
                    this.Actions2Button.Button.Click += Actions2Button_Click;
                        
                    this.Filters2Button.Button.Click += Filters2Button_Click;
                        
            this.OrderSort2.SelectedIndexChanged += new EventHandler(OrderSort2_SelectedIndexChanged);
                    
        
         //' Setup events for others
               
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
                    foreach (InvoiceSummariesTableControl1Row rc in this.GetRecordControls()) {
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl1Repeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            InvoiceSummariesTableControl1Row recControl = (InvoiceSummariesTableControl1Row)(repItem.FindControl("InvoiceSummariesTableControl1Row"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                
                SetOrderSort2();
                
                
                SetSortByLabel2();
                
                SetExcelButton1();
              
                SetImportButton1();
              
                SetNewButton1();
              
                SetPDFButton1();
              
                SetWordButton1();
              
                SetActions2Button();
              
                SetFilters2Button();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFilters2Button();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "IDE") + "'));");
        else
          this.ExcelButton1.Attributes.Remove("onClick");
      
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
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton1"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton1"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton1"));
                                
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


            
            this.OrderSort2.ClearSelection();
            
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
                this.Pagination1.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination1.CurrentPage.Text = "0";
            }
            this.Pagination1.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for InvoiceSummariesTableControl1 pagination.
        
            this.Pagination1.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination1.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (InvoiceSummariesTableControl1Row recCtl in this.GetRecordControls())
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
            foreach (InvoiceSummariesTableControl1Row recCtl in this.GetRecordControls()){
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
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    IDE.UI.Controls.Show_EnergyPoints.EnergyPointsRecordControl energyPointsRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "EnergyPointsRecordControl") as IDE.UI.Controls.Show_EnergyPoints.EnergyPointsRecordControl);
          
              if (energyPointsRecordControlObj != null && energyPointsRecordControlObj.GetRecord() != null && energyPointsRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(InvoiceSummariesTable.EnergyPointId, BaseFilter.ComparisonOperator.EqualsTo, energyPointsRecordControlObj.GetRecord().EnergyPointId.ToString());
              selectedRecordKeyValue.AddElement(InvoiceSummariesTable.EnergyPointId.InternalName, energyPointsRecordControlObj.GetRecord().EnergyPointId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["InvoiceSummariesTableControl1WhereClause"] = selectedRecordKeyValue.ToXmlString();
         
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
            
      string selectedRecordInEnergyPointsRecordControl = HttpContext.Current.Session["InvoiceSummariesTableControl1WhereClause"] as string;
      
      if (selectedRecordInEnergyPointsRecordControl != null && KeyValue.IsXmlKey(selectedRecordInEnergyPointsRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInEnergyPointsRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(InvoiceSummariesTable.EnergyPointId))
      {
      wc.iAND(InvoiceSummariesTable.EnergyPointId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(InvoiceSummariesTable.EnergyPointId).ToString());
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
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination1.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination1.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl1Repeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                InvoiceSummariesTableControl1Row recControl = (InvoiceSummariesTableControl1Row)(repItem.FindControl("InvoiceSummariesTableControl1Row"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      InvoiceSummariesRecord rec = new InvoiceSummariesRecord();
        
                        if (recControl.AccountNumber2.Text != "") {
                            rec.Parse(recControl.AccountNumber2.Text, InvoiceSummariesTable.AccountNumber);
                  }
                
                        if (recControl.Approved2.Text != "") {
                            rec.Parse(recControl.Approved2.Text, InvoiceSummariesTable.Approved);
                  }
                
                        if (recControl.ApprovedById2.Text != "") {
                            rec.Parse(recControl.ApprovedById2.Text, InvoiceSummariesTable.ApprovedById);
                  }
                
                        if (recControl.ApprovedDate2.Text != "") {
                            rec.Parse(recControl.ApprovedDate2.Text, InvoiceSummariesTable.ApprovedDate);
                  }
                
                        if (recControl.ConnectionNumber2.Text != "") {
                            rec.Parse(recControl.ConnectionNumber2.Text, InvoiceSummariesTable.ConnectionNumber);
                  }
                
                        if (recControl.CustomerNumber2.Text != "") {
                            rec.Parse(recControl.CustomerNumber2.Text, InvoiceSummariesTable.CustomerNumber);
                  }
                
                        if (recControl.EnergyChargesTotal1.Text != "") {
                            rec.Parse(recControl.EnergyChargesTotal1.Text, InvoiceSummariesTable.EnergyChargesTotal);
                  }
                
                        if (recControl.GSTCharges1.Text != "") {
                            rec.Parse(recControl.GSTCharges1.Text, InvoiceSummariesTable.GSTCharges);
                  }
                
                        if (recControl.GstTotal1.Text != "") {
                            rec.Parse(recControl.GstTotal1.Text, InvoiceSummariesTable.GstTotal);
                  }
                
                        if (recControl.InvoiceDate2.Text != "") {
                            rec.Parse(recControl.InvoiceDate2.Text, InvoiceSummariesTable.InvoiceDate);
                  }
                
                        if (recControl.InvoiceDueDate2.Text != "") {
                            rec.Parse(recControl.InvoiceDueDate2.Text, InvoiceSummariesTable.InvoiceDueDate);
                  }
                
                        if (recControl.InvoiceId1.Text != "") {
                            rec.Parse(recControl.InvoiceId1.Text, InvoiceSummariesTable.InvoiceId);
                  }
                
                        if (recControl.InvoiceNumber1.Text != "") {
                            rec.Parse(recControl.InvoiceNumber1.Text, InvoiceSummariesTable.InvoiceNumber);
                  }
                
                        if (recControl.InvoiceTotal1.Text != "") {
                            rec.Parse(recControl.InvoiceTotal1.Text, InvoiceSummariesTable.InvoiceTotal);
                  }
                
                        if (recControl.MiscChargesTotal1.Text != "") {
                            rec.Parse(recControl.MiscChargesTotal1.Text, InvoiceSummariesTable.MiscChargesTotal);
                  }
                
                        if (recControl.Month1.Text != "") {
                            rec.Parse(recControl.Month1.Text, InvoiceSummariesTable.Month);
                  }
                
                        if (recControl.NetworkChargesTotal1.Text != "") {
                            rec.Parse(recControl.NetworkChargesTotal1.Text, InvoiceSummariesTable.NetworkChargesTotal);
                  }
                
                        if (recControl.PercentageChange1.Text != "") {
                            rec.Parse(recControl.PercentageChange1.Text, InvoiceSummariesTable.PercentageChange);
                  }
                
                        if (recControl.PeriodEnd1.Text != "") {
                            rec.Parse(recControl.PeriodEnd1.Text, InvoiceSummariesTable.PeriodEnd);
                  }
                
                        if (recControl.PeriodStart1.Text != "") {
                            rec.Parse(recControl.PeriodStart1.Text, InvoiceSummariesTable.PeriodStart);
                  }
                
                        if (recControl.SiteId2.Text != "") {
                            rec.Parse(recControl.SiteId2.Text, InvoiceSummariesTable.SiteId);
                  }
                
                        if (recControl.SiteName2.Text != "") {
                            rec.Parse(recControl.SiteName2.Text, InvoiceSummariesTable.SiteName);
                  }
                
                        if (recControl.TotalCharges1.Text != "") {
                            rec.Parse(recControl.TotalCharges1.Text, InvoiceSummariesTable.TotalCharges);
                  }
                
                        if (recControl.TotalEnergyCharges1.Text != "") {
                            rec.Parse(recControl.TotalEnergyCharges1.Text, InvoiceSummariesTable.TotalEnergyCharges);
                  }
                
                        if (recControl.TotalMiscCharges1.Text != "") {
                            rec.Parse(recControl.TotalMiscCharges1.Text, InvoiceSummariesTable.TotalMiscCharges);
                  }
                
                        if (recControl.TotalNetworkCharges1.Text != "") {
                            rec.Parse(recControl.TotalNetworkCharges1.Text, InvoiceSummariesTable.TotalNetworkCharges);
                  }
                
                        if (recControl.Year1.Text != "") {
                            rec.Parse(recControl.Year1.Text, InvoiceSummariesTable.Year);
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

        
        public void AddToDeletedRecordIds(InvoiceSummariesTableControl1Row rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(InvoiceSummariesTableControl1Row rec)            
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
        
        public virtual void SetSortByLabel2()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel2.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort2()
        {
            
                this.PopulateOrderSort2(MiscUtils.GetSelectedValue(this.OrderSort2,  GetFromSession(this.OrderSort2)), 500);					
                    

        }
            
        // Get the filters' data for OrderSort2.
                
        protected virtual void PopulateOrderSort2(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort2.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Account Number {Txt:Ascending}"), "AccountNumber Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Account Number {Txt:Descending}"), "AccountNumber Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved {Txt:Ascending}"), "Approved Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved {Txt:Descending}"), "Approved Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved By {Txt:Ascending}"), "ApprovedById Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved By {Txt:Descending}"), "ApprovedById Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Ascending}"), "ApprovedDate Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Descending}"), "ApprovedDate Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Connection Number {Txt:Ascending}"), "ConnectionNumber Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Connection Number {Txt:Descending}"), "ConnectionNumber Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Number {Txt:Ascending}"), "CustomerNumber Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Number {Txt:Descending}"), "CustomerNumber Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Ascending}"), "InvoiceDate Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Descending}"), "InvoiceDate Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Ascending}"), "InvoiceDueDate Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Descending}"), "InvoiceDueDate Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site {Txt:Ascending}"), "SiteId Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site {Txt:Descending}"), "SiteId Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Name {Txt:Ascending}"), "SiteName Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Name {Txt:Descending}"), "SiteName Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Supplier {Txt:Ascending}"), "SupplierId Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Supplier {Txt:Descending}"), "SupplierId Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("K Warehouse Total {Txt:Ascending}"), "KWhTotal Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("K Warehouse Total {Txt:Descending}"), "KWhTotal Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Checked OK {Txt:Ascending}"), "CheckedOk Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Checked OK {Txt:Descending}"), "CheckedOk Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("On File {Txt:Ascending}"), "OnFile Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("On File {Txt:Descending}"), "OnFile Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Verified {Txt:Ascending}"), "Verified Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("Verified {Txt:Descending}"), "Verified Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort2, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort2.SelectedValue != null && this.OrderSort2.Items.FindByValue(this.OrderSort2.SelectedValue) == null)
                this.OrderSort2.SelectedValue = null;
              
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
        
            this.SaveToSession(this.OrderSort2, this.OrderSort2.SelectedValue);
                  
            
                    
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
          
            this.SaveToSession(this.OrderSort2, this.OrderSort2.SelectedValue);
                  
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort2);
            
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

            string orderByStr = (string)ViewState["InvoiceSummariesTableControl1_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination1");
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
                this.ViewState["InvoiceSummariesTableControl1_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton1()                
              
        {
        
   
        }
            
        public virtual void SetImportButton1()                
              
        {
        							
                    this.ImportButton1.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=InvoiceSummaries" ;
                    this.ImportButton1.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton1.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton1()                
              
        {
        
              try
              {
                    string url = "../InvoiceSummaries/Add-InvoiceSummaries.aspx?EnergyPointId={EnergyPointsRecordControl:FV:EnergyPointId}&TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl1_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl1_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton1.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton1_ClickNewButton1_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton1()                
              
        {
        
   
        }
            
        public virtual void SetWordButton1()                
              
        {
        
   
        }
            
        public virtual void SetActions2Button()                
              
        {
        
   
        }
            
        public virtual void SetFilters2Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters2Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters2Button"));
         themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination1_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination1_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination1_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination1_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination1.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination1.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ExcelButton1_Click(object sender, ImageClickEventArgs args)
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
             InvoiceSummariesTable.SiteId,
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
             InvoiceSummariesTable.ApprovedById,
             InvoiceSummariesTable.ApprovedDate,
             InvoiceSummariesTable.PercentageChange,
             InvoiceSummariesTable.PeriodStart,
             InvoiceSummariesTable.PeriodEnd,
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
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.SiteId, "Default"));
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
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.ApprovedById, "Default"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.ApprovedDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.PercentageChange, "Standard"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.PeriodStart, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(InvoiceSummariesTable.PeriodEnd, "Short Date"));


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
        public virtual void ImportButton1_Click(object sender, ImageClickEventArgs args)
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
        public virtual void NewButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Add-InvoiceSummaries.aspx?EnergyPointId={EnergyPointsRecordControl:FV:EnergyPointId}&TabVisible=False&SaveAndNewVisible=False";
            
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
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl1_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" + MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControl1_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton1_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-EnergyPoints.PDFButton1.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "InvoiceSummaries";
                // If Show-EnergyPoints.PDFButton1.report specifies a valid report template,
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
                 report.AddColumn(InvoiceSummariesTable.SiteId.Name, ReportEnum.Align.Left, "${SiteId}", ReportEnum.Align.Left, 28);
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
                 report.AddColumn(InvoiceSummariesTable.ApprovedById.Name, ReportEnum.Align.Left, "${ApprovedById}", ReportEnum.Align.Left, 28);
                 report.AddColumn(InvoiceSummariesTable.ApprovedDate.Name, ReportEnum.Align.Left, "${ApprovedDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.PercentageChange.Name, ReportEnum.Align.Right, "${PercentageChange}", ReportEnum.Align.Right, 20);
                 report.AddColumn(InvoiceSummariesTable.PeriodStart.Name, ReportEnum.Align.Left, "${PeriodStart}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.PeriodEnd.Name, ReportEnum.Align.Left, "${PeriodEnd}", ReportEnum.Align.Left, 20);

  
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
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.SiteId)){
                                 report.AddData("${SiteId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SiteId);
                                 _DFKA = InvoiceSummariesTable.GetDFKA(record.SiteId.ToString(), InvoiceSummariesTable.SiteId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  InvoiceSummariesTable.SiteId.IsApplyDisplayAs){
                                     report.AddData("${SiteId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${SiteId}", record.Format(InvoiceSummariesTable.SiteId), ReportEnum.Align.Left);
                                 }
                             }
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
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ApprovedById)){
                                 report.AddData("${ApprovedById}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.ApprovedById);
                                 _DFKA = InvoiceSummariesTable.GetDFKA(record.ApprovedById.ToString(), InvoiceSummariesTable.ApprovedById,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  InvoiceSummariesTable.ApprovedById.IsApplyDisplayAs){
                                     report.AddData("${ApprovedById}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ApprovedById}", record.Format(InvoiceSummariesTable.ApprovedById), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ApprovedDate}", record.Format(InvoiceSummariesTable.ApprovedDate), ReportEnum.Align.Left, 300);
                             report.AddData("${PercentageChange}", record.Format(InvoiceSummariesTable.PercentageChange), ReportEnum.Align.Right, 300);
                             report.AddData("${PeriodStart}", record.Format(InvoiceSummariesTable.PeriodStart), ReportEnum.Align.Left, 300);
                             report.AddData("${PeriodEnd}", record.Format(InvoiceSummariesTable.PeriodEnd), ReportEnum.Align.Left, 300);

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
        public virtual void WordButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-EnergyPoints.WordButton1.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "InvoiceSummaries";
                // If Show-EnergyPoints.WordButton1.report specifies a valid report template,
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
                 report.AddColumn(InvoiceSummariesTable.SiteId.Name, ReportEnum.Align.Left, "${SiteId}", ReportEnum.Align.Left, 28);
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
                 report.AddColumn(InvoiceSummariesTable.ApprovedById.Name, ReportEnum.Align.Left, "${ApprovedById}", ReportEnum.Align.Left, 28);
                 report.AddColumn(InvoiceSummariesTable.ApprovedDate.Name, ReportEnum.Align.Left, "${ApprovedDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.PercentageChange.Name, ReportEnum.Align.Right, "${PercentageChange}", ReportEnum.Align.Right, 20);
                 report.AddColumn(InvoiceSummariesTable.PeriodStart.Name, ReportEnum.Align.Left, "${PeriodStart}", ReportEnum.Align.Left, 20);
                 report.AddColumn(InvoiceSummariesTable.PeriodEnd.Name, ReportEnum.Align.Left, "${PeriodEnd}", ReportEnum.Align.Left, 20);

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
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.SiteId)){
                                 report.AddData("${SiteId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SiteId);
                                 _DFKA = InvoiceSummariesTable.GetDFKA(record.SiteId.ToString(), InvoiceSummariesTable.SiteId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  InvoiceSummariesTable.SiteId.IsApplyDisplayAs){
                                     report.AddData("${SiteId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${SiteId}", record.Format(InvoiceSummariesTable.SiteId), ReportEnum.Align.Left);
                                 }
                             }
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
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ApprovedById)){
                                 report.AddData("${ApprovedById}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.ApprovedById);
                                 _DFKA = InvoiceSummariesTable.GetDFKA(record.ApprovedById.ToString(), InvoiceSummariesTable.ApprovedById,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  InvoiceSummariesTable.ApprovedById.IsApplyDisplayAs){
                                     report.AddData("${ApprovedById}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${ApprovedById}", record.Format(InvoiceSummariesTable.ApprovedById), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${ApprovedDate}", record.Format(InvoiceSummariesTable.ApprovedDate), ReportEnum.Align.Left, 300);
                             report.AddData("${PercentageChange}", record.Format(InvoiceSummariesTable.PercentageChange), ReportEnum.Align.Right, 300);
                             report.AddData("${PeriodStart}", record.Format(InvoiceSummariesTable.PeriodStart), ReportEnum.Align.Left, 300);
                             report.AddData("${PeriodEnd}", record.Format(InvoiceSummariesTable.PeriodEnd), ReportEnum.Align.Left, 300);

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
        public virtual void Actions2Button_Click(object sender, EventArgs args)
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
        public virtual void Filters2Button_Click(object sender, EventArgs args)
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
        protected virtual void OrderSort2_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort2.SelectedValue.ToUpper();
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
        
        public IDE.UI.IThemeButtonWithArrow Actions2Button {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions2Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton1");
            }
        }
        
        public IDE.UI.IThemeButtonWithArrow Filters2Button {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters2Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImportButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton1");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort2 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort2");
          }
          }
        
        public IDE.UI.IPaginationModern Pagination1 {
            get {
                return (IDE.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton1");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel2 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel2");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton1");
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
                InvoiceSummariesTableControl1Row recCtl = this.GetSelectedRecordControl();
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
                InvoiceSummariesTableControl1Row recCtl = this.GetSelectedRecordControl();
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
          
        public virtual InvoiceSummariesTableControl1Row GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual InvoiceSummariesTableControl1Row[] GetSelectedRecordControls()
        {
        
            return (InvoiceSummariesTableControl1Row[])((new ArrayList()).ToArray(Type.GetType("IDE.UI.Controls.Show_EnergyPoints.InvoiceSummariesTableControl1Row")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            InvoiceSummariesTableControl1Row[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (InvoiceSummariesTableControl1Row recCtl in recordList)
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

        public virtual InvoiceSummariesTableControl1Row[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "InvoiceSummariesTableControl1Row");
	          List<InvoiceSummariesTableControl1Row> list = new List<InvoiceSummariesTableControl1Row>();
	          foreach (InvoiceSummariesTableControl1Row recCtrl in recCtrls) {
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
  
// Base class for the EnergyPointsRecordControl control on the Show_EnergyPoints page.
// Do not modify this class. Instead override any method in EnergyPointsRecordControl.
public class BaseEnergyPointsRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseEnergyPointsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in EnergyPointsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in EnergyPointsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.DialogEditButton.Click += DialogEditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.EnergyPoints record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = EnergyPointsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "EnergyPointsRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new EnergyPointsRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            EnergyPointsRecord[] recList = EnergyPointsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = EnergyPointsTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                
                SetEnergyPointNumber();
                SetEnergyPointNumberLabel();
                
                SetDialogEditButton();
              

      

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
            InvoiceSummariesTableControl1 recInvoiceSummariesTableControl1 = (InvoiceSummariesTableControl1)(MiscUtils.FindControlRecursively(this.Page, "InvoiceSummariesTableControl1"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recInvoiceSummariesTableControl1.ResetControl();
          }
                  
        this.Page.SetControl("InvoiceSummariesTableControl1");
        
        }
        
        
        public virtual void SetEnergyPointNumber()
        {
            
                    
            // Set the EnergyPointNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyPoints database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyPoints record retrieved from the database.
            // this.EnergyPointNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EnergyPointNumberSpecified) {
                								
                // If the EnergyPointNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyPointsTable.EnergyPointNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EnergyPointNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // EnergyPointNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EnergyPointNumber.Text = EnergyPointsTable.EnergyPointNumber.Format(EnergyPointsTable.EnergyPointNumber.DefaultValue);
            		
            }
            
            // If the EnergyPointNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EnergyPointNumber.Text == null ||
                this.EnergyPointNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EnergyPointNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEnergyPointNumberLabel()
                  {
                  
                        this.EnergyPointNumberLabel.Text = EvaluateFormula("\"Connection Number\"");
                      
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "EnergyPointsRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
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
          InvoiceSummariesTableControl1 recInvoiceSummariesTableControl1 = (InvoiceSummariesTableControl1)(MiscUtils.FindControlRecursively(this.Page, "InvoiceSummariesTableControl1"));
        recInvoiceSummariesTableControl1.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetEnergyPointNumber();
        }
        
        
        public virtual void GetEnergyPointNumber()
        {
            
        }
                

      // To customize, override this method in EnergyPointsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyPointsRecordControl = false;
            hasFiltersEnergyPointsRecordControl = hasFiltersEnergyPointsRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl1 = false;
            hasFiltersInvoiceSummariesTableControl1 = hasFiltersInvoiceSummariesTableControl1 && false; // suppress warning
      
            WhereClause wc;
            EnergyPointsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["EnergyPoints"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "IDE").Replace("{URL}", "EnergyPoints"));
            }
            HttpContext.Current.Session["QueryString in Show-EnergyPoints"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(EnergyPointsTable.EnergyPointId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(EnergyPointsTable.EnergyPointId));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(EnergyPointsTable.EnergyPointId, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            EnergyPointsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEnergyPointsRecordControl = false;
            hasFiltersEnergyPointsRecordControl = hasFiltersEnergyPointsRecordControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl1 = false;
            hasFiltersInvoiceSummariesTableControl1 = hasFiltersInvoiceSummariesTableControl1 && false; // suppress warning
      
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
          EnergyPointsTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetDialogEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DialogEditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../EnergyPoints/Edit-EnergyPoints.aspx?EnergyPoints={PK}";
            
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
                return (string)this.ViewState["BaseEnergyPointsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseEnergyPointsRecordControl_Rec"] = value;
            }
        }
        
        public EnergyPointsRecord DataSource {
            get {
                return (EnergyPointsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton DialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DialogEditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal EnergyPointNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyPointNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal EnergyPointNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyPointNumberLabel");
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
        EnergyPointsRecord rec = null;
             
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
    EnergyPointsRecord rec = null;
    
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

        
        public virtual EnergyPointsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return EnergyPointsTable.GetRecord(this.RecordUniqueId, true);
              
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

  

#endregion
    
  
}

  