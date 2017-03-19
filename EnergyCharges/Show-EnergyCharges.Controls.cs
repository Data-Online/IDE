
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_EnergyCharges.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IDE.UI.Controls.Show_EnergyCharges
{
  

#region "Section 1: Place your customizations here."

    
public class EnergyChargesRecordControl : BaseEnergyChargesRecordControl
{
      
        // The BaseEnergyChargesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the EnergyChargesRecordControl control on the Show_EnergyCharges page.
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

          
                    this.DialogEditButton.Click += DialogEditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = EnergyChargesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "EnergyChargesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new EnergyChargesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            EnergyChargesRecord[] recList = EnergyChargesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = EnergyChargesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetBD0004();
                SetBD0004Label();
                SetBD0004R();
                SetBD0004RLabel();
                SetBD0408();
                SetBD0408Label();
                SetBD0408R();
                SetBD0408RLabel();
                SetBD0812();
                SetBD0812Label();
                SetBD0812R();
                SetBD0812RLabel();
                SetBD1216();
                SetBD1216Label();
                SetBD1216R();
                SetBD1216RLabel();
                SetBD1620();
                SetBD1620Label();
                SetBD1620R();
                SetBD1620RLabel();
                SetBD2024();
                SetBD2024Label();
                SetBD2024R();
                SetBD2024RLabel();
                
                SetEnergyChargeId();
                SetEnergyChargeIdLabel();
                SetNBD0004();
                SetNBD0004Label();
                SetNBD0004R();
                SetNBD0004RLabel();
                SetNBD0408();
                SetNBD0408Label();
                SetNBD0408R();
                SetNBD0408RLabel();
                SetNBD0812();
                SetNBD0812Label();
                SetNBD0812R();
                SetNBD0812RLabel();
                SetNBD1216();
                SetNBD1216Label();
                SetNBD1216R();
                SetNBD1216RLabel();
                SetNBD1620();
                SetNBD1620Label();
                SetNBD1620R();
                SetNBD1620RLabel();
                SetNBD2024();
                SetNBD2024Label();
                SetNBD2024R();
                SetNBD2024RLabel();
                
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
            
        }
        
        
        public virtual void SetBD0004()
        {
            
                    
            // Set the BD0004 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0004 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004Specified) {
                								
                // If the BD0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0004.Text = EnergyChargesTable.BD0004.Format(EnergyChargesTable.BD0004.DefaultValue);
            		
            }
            
            // If the BD0004 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0004.Text == null ||
                this.BD0004.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0004.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0004R()
        {
            
                    
            // Set the BD0004R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0004R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004RSpecified) {
                								
                // If the BD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0004R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0004R.Text = EnergyChargesTable.BD0004R.Format(EnergyChargesTable.BD0004R.DefaultValue);
            		
            }
            
            // If the BD0004R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0004R.Text == null ||
                this.BD0004R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0004R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0408()
        {
            
                    
            // Set the BD0408 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0408 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408Specified) {
                								
                // If the BD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0408.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0408.Text = EnergyChargesTable.BD0408.Format(EnergyChargesTable.BD0408.DefaultValue);
            		
            }
            
            // If the BD0408 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0408.Text == null ||
                this.BD0408.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0408.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0408R()
        {
            
                    
            // Set the BD0408R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0408R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408RSpecified) {
                								
                // If the BD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0408R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0408R.Text = EnergyChargesTable.BD0408R.Format(EnergyChargesTable.BD0408R.DefaultValue);
            		
            }
            
            // If the BD0408R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0408R.Text == null ||
                this.BD0408R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0408R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0812()
        {
            
                    
            // Set the BD0812 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0812 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812Specified) {
                								
                // If the BD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0812.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0812.Text = EnergyChargesTable.BD0812.Format(EnergyChargesTable.BD0812.DefaultValue);
            		
            }
            
            // If the BD0812 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0812.Text == null ||
                this.BD0812.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0812.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0812R()
        {
            
                    
            // Set the BD0812R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0812R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812RSpecified) {
                								
                // If the BD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0812R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0812R.Text = EnergyChargesTable.BD0812R.Format(EnergyChargesTable.BD0812R.DefaultValue);
            		
            }
            
            // If the BD0812R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0812R.Text == null ||
                this.BD0812R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0812R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1216()
        {
            
                    
            // Set the BD1216 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1216 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216Specified) {
                								
                // If the BD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1216.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1216.Text = EnergyChargesTable.BD1216.Format(EnergyChargesTable.BD1216.DefaultValue);
            		
            }
            
            // If the BD1216 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1216.Text == null ||
                this.BD1216.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1216.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1216R()
        {
            
                    
            // Set the BD1216R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1216R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216RSpecified) {
                								
                // If the BD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1216R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1216R.Text = EnergyChargesTable.BD1216R.Format(EnergyChargesTable.BD1216R.DefaultValue);
            		
            }
            
            // If the BD1216R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1216R.Text == null ||
                this.BD1216R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1216R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1620()
        {
            
                    
            // Set the BD1620 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1620 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620Specified) {
                								
                // If the BD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1620.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1620.Text = EnergyChargesTable.BD1620.Format(EnergyChargesTable.BD1620.DefaultValue);
            		
            }
            
            // If the BD1620 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1620.Text == null ||
                this.BD1620.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1620.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1620R()
        {
            
                    
            // Set the BD1620R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1620R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620RSpecified) {
                								
                // If the BD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1620R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1620R.Text = EnergyChargesTable.BD1620R.Format(EnergyChargesTable.BD1620R.DefaultValue);
            		
            }
            
            // If the BD1620R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1620R.Text == null ||
                this.BD1620R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1620R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD2024()
        {
            
                    
            // Set the BD2024 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD2024 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024Specified) {
                								
                // If the BD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD2024.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD2024.Text = EnergyChargesTable.BD2024.Format(EnergyChargesTable.BD2024.DefaultValue);
            		
            }
            
            // If the BD2024 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD2024.Text == null ||
                this.BD2024.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD2024.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD2024R()
        {
            
                    
            // Set the BD2024R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD2024R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024RSpecified) {
                								
                // If the BD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD2024R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD2024R.Text = EnergyChargesTable.BD2024R.Format(EnergyChargesTable.BD2024R.DefaultValue);
            		
            }
            
            // If the BD2024R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD2024R.Text == null ||
                this.BD2024R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD2024R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEnergyChargeId()
        {
            
                    
            // Set the EnergyChargeId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.EnergyChargeId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EnergyChargeIdSpecified) {
                								
                // If the EnergyChargeId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = EnergyChargesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(EnergyChargesTable.EnergyChargeId);
               if(_isExpandableNonCompositeForeignKey &&EnergyChargesTable.EnergyChargeId.IsApplyDisplayAs)
                                  
                     formattedValue = EnergyChargesTable.GetDFKA(this.DataSource.EnergyChargeId.ToString(),EnergyChargesTable.EnergyChargeId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(EnergyChargesTable.EnergyChargeId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EnergyChargeId.Text = formattedValue;
                   
            } 
            
            else {
            
                // EnergyChargeId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EnergyChargeId.Text = EnergyChargesTable.EnergyChargeId.Format(EnergyChargesTable.EnergyChargeId.DefaultValue);
            		
            }
            
            // If the EnergyChargeId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EnergyChargeId.Text == null ||
                this.EnergyChargeId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EnergyChargeId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0004()
        {
            
                    
            // Set the NBD0004 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0004 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0004Specified) {
                								
                // If the NBD0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0004);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0004.Text = EnergyChargesTable.NBD0004.Format(EnergyChargesTable.NBD0004.DefaultValue);
            		
            }
            
            // If the NBD0004 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0004.Text == null ||
                this.NBD0004.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0004.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0004R()
        {
            
                    
            // Set the NBD0004R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0004R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0004RSpecified) {
                								
                // If the NBD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0004R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0004R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0004R.Text = EnergyChargesTable.NBD0004R.Format(EnergyChargesTable.NBD0004R.DefaultValue);
            		
            }
            
            // If the NBD0004R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0004R.Text == null ||
                this.NBD0004R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0004R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0408()
        {
            
                    
            // Set the NBD0408 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0408 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408Specified) {
                								
                // If the NBD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0408.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0408.Text = EnergyChargesTable.NBD0408.Format(EnergyChargesTable.NBD0408.DefaultValue);
            		
            }
            
            // If the NBD0408 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0408.Text == null ||
                this.NBD0408.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0408.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0408R()
        {
            
                    
            // Set the NBD0408R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0408R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408RSpecified) {
                								
                // If the NBD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0408R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0408R.Text = EnergyChargesTable.NBD0408R.Format(EnergyChargesTable.NBD0408R.DefaultValue);
            		
            }
            
            // If the NBD0408R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0408R.Text == null ||
                this.NBD0408R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0408R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0812()
        {
            
                    
            // Set the NBD0812 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0812 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812Specified) {
                								
                // If the NBD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0812.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0812.Text = EnergyChargesTable.NBD0812.Format(EnergyChargesTable.NBD0812.DefaultValue);
            		
            }
            
            // If the NBD0812 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0812.Text == null ||
                this.NBD0812.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0812.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0812R()
        {
            
                    
            // Set the NBD0812R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0812R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812RSpecified) {
                								
                // If the NBD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0812R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0812R.Text = EnergyChargesTable.NBD0812R.Format(EnergyChargesTable.NBD0812R.DefaultValue);
            		
            }
            
            // If the NBD0812R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0812R.Text == null ||
                this.NBD0812R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0812R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1216()
        {
            
                    
            // Set the NBD1216 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1216 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216Specified) {
                								
                // If the NBD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1216.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1216.Text = EnergyChargesTable.NBD1216.Format(EnergyChargesTable.NBD1216.DefaultValue);
            		
            }
            
            // If the NBD1216 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1216.Text == null ||
                this.NBD1216.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1216.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1216R()
        {
            
                    
            // Set the NBD1216R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1216R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216RSpecified) {
                								
                // If the NBD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1216R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1216R.Text = EnergyChargesTable.NBD1216R.Format(EnergyChargesTable.NBD1216R.DefaultValue);
            		
            }
            
            // If the NBD1216R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1216R.Text == null ||
                this.NBD1216R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1216R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1620()
        {
            
                    
            // Set the NBD1620 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1620 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620Specified) {
                								
                // If the NBD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1620.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1620.Text = EnergyChargesTable.NBD1620.Format(EnergyChargesTable.NBD1620.DefaultValue);
            		
            }
            
            // If the NBD1620 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1620.Text == null ||
                this.NBD1620.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1620.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1620R()
        {
            
                    
            // Set the NBD1620R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1620R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620RSpecified) {
                								
                // If the NBD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1620R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1620R.Text = EnergyChargesTable.NBD1620R.Format(EnergyChargesTable.NBD1620R.DefaultValue);
            		
            }
            
            // If the NBD1620R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1620R.Text == null ||
                this.NBD1620R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1620R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD2024()
        {
            
                    
            // Set the NBD2024 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD2024 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024Specified) {
                								
                // If the NBD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD2024.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD2024.Text = EnergyChargesTable.NBD2024.Format(EnergyChargesTable.NBD2024.DefaultValue);
            		
            }
            
            // If the NBD2024 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD2024.Text == null ||
                this.NBD2024.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD2024.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD2024R()
        {
            
                    
            // Set the NBD2024R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD2024R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024RSpecified) {
                								
                // If the NBD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD2024R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD2024R.Text = EnergyChargesTable.NBD2024R.Format(EnergyChargesTable.NBD2024R.DefaultValue);
            		
            }
            
            // If the NBD2024R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD2024R.Text == null ||
                this.NBD2024R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD2024R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0004Label()
                  {
                  
                        this.BD0004Label.Text = EvaluateFormula("\"Weekday 0000 - 0400\"");
                      
                    
        }
                
        public virtual void SetBD0004RLabel()
                  {
                  
                        this.BD0004RLabel.Text = EvaluateFormula("\"Busness Day 0004 Rate\"");
                      
                    
        }
                
        public virtual void SetBD0408Label()
                  {
                  
                        this.BD0408Label.Text = EvaluateFormula("\"Weekday 0400 - 0800\"");
                      
                    
        }
                
        public virtual void SetBD0408RLabel()
                  {
                  
                    
        }
                
        public virtual void SetBD0812Label()
                  {
                  
                        this.BD0812Label.Text = EvaluateFormula("\"Weekday 0800 - 1200\"");
                      
                    
        }
                
        public virtual void SetBD0812RLabel()
                  {
                  
                    
        }
                
        public virtual void SetBD1216Label()
                  {
                  
                        this.BD1216Label.Text = EvaluateFormula("\"Weekday 1200 - 1600\"");
                      
                    
        }
                
        public virtual void SetBD1216RLabel()
                  {
                  
                    
        }
                
        public virtual void SetBD1620Label()
                  {
                  
                        this.BD1620Label.Text = EvaluateFormula("\"Weekday 1600 - 2000\"");
                      
                    
        }
                
        public virtual void SetBD1620RLabel()
                  {
                  
                    
        }
                
        public virtual void SetBD2024Label()
                  {
                  
                        this.BD2024Label.Text = EvaluateFormula("\"Weekday 2000 - 2400\"");
                      
                    
        }
                
        public virtual void SetBD2024RLabel()
                  {
                  
                    
        }
                
        public virtual void SetEnergyChargeIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetNBD0004Label()
                  {
                  
                        this.NBD0004Label.Text = EvaluateFormula("\"Weekend 0000 - 0400\"");
                      
                    
        }
                
        public virtual void SetNBD0004RLabel()
                  {
                  
                        this.NBD0004RLabel.Text = EvaluateFormula("\"Non Business Day 0004 Rate\"");
                      
                    
        }
                
        public virtual void SetNBD0408Label()
                  {
                  
                        this.NBD0408Label.Text = EvaluateFormula("\"Weekend 0400 - 0800\"");
                      
                    
        }
                
        public virtual void SetNBD0408RLabel()
                  {
                  
                    
        }
                
        public virtual void SetNBD0812Label()
                  {
                  
                        this.NBD0812Label.Text = EvaluateFormula("\"Weekend 0800 - 1200\"");
                      
                    
        }
                
        public virtual void SetNBD0812RLabel()
                  {
                  
                    
        }
                
        public virtual void SetNBD1216Label()
                  {
                  
                        this.NBD1216Label.Text = EvaluateFormula("\"Weekend 1200 - 1600\"");
                      
                    
        }
                
        public virtual void SetNBD1216RLabel()
                  {
                  
                    
        }
                
        public virtual void SetNBD1620Label()
                  {
                  
                        this.NBD1620Label.Text = EvaluateFormula("\"Weekend 1600 - 2000\"");
                      
                    
        }
                
        public virtual void SetNBD1620RLabel()
                  {
                  
                    
        }
                
        public virtual void SetNBD2024Label()
                  {
                  
                        this.NBD2024Label.Text = EvaluateFormula("\"Weekend 2000 - 2400\"");
                      
                    
        }
                
        public virtual void SetNBD2024RLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "EnergyChargesRecordControlPanel");
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
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetBD0004();
            GetBD0004R();
            GetBD0408();
            GetBD0408R();
            GetBD0812();
            GetBD0812R();
            GetBD1216();
            GetBD1216R();
            GetBD1620();
            GetBD1620R();
            GetBD2024();
            GetBD2024R();
            GetEnergyChargeId();
            GetNBD0004();
            GetNBD0004R();
            GetNBD0408();
            GetNBD0408R();
            GetNBD0812();
            GetNBD0812R();
            GetNBD1216();
            GetNBD1216R();
            GetNBD1620();
            GetNBD1620R();
            GetNBD2024();
            GetNBD2024R();
        }
        
        
        public virtual void GetBD0004()
        {
            
        }
                
        public virtual void GetBD0004R()
        {
            
        }
                
        public virtual void GetBD0408()
        {
            
        }
                
        public virtual void GetBD0408R()
        {
            
        }
                
        public virtual void GetBD0812()
        {
            
        }
                
        public virtual void GetBD0812R()
        {
            
        }
                
        public virtual void GetBD1216()
        {
            
        }
                
        public virtual void GetBD1216R()
        {
            
        }
                
        public virtual void GetBD1620()
        {
            
        }
                
        public virtual void GetBD1620R()
        {
            
        }
                
        public virtual void GetBD2024()
        {
            
        }
                
        public virtual void GetBD2024R()
        {
            
        }
                
        public virtual void GetEnergyChargeId()
        {
            
        }
                
        public virtual void GetNBD0004()
        {
            
        }
                
        public virtual void GetNBD0004R()
        {
            
        }
                
        public virtual void GetNBD0408()
        {
            
        }
                
        public virtual void GetNBD0408R()
        {
            
        }
                
        public virtual void GetNBD0812()
        {
            
        }
                
        public virtual void GetNBD0812R()
        {
            
        }
                
        public virtual void GetNBD1216()
        {
            
        }
                
        public virtual void GetNBD1216R()
        {
            
        }
                
        public virtual void GetNBD1620()
        {
            
        }
                
        public virtual void GetNBD1620R()
        {
            
        }
                
        public virtual void GetNBD2024()
        {
            
        }
                
        public virtual void GetNBD2024R()
        {
            
        }
                

      // To customize, override this method in EnergyChargesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
            WhereClause wc;
            EnergyChargesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["EnergyCharges"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "IDE").Replace("{URL}", "EnergyCharges"));
            }
            HttpContext.Current.Session["QueryString in Show-EnergyCharges"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(EnergyChargesTable.EnergyChargeId));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            EnergyChargesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEnergyChargesRecordControl = false;
            hasFiltersEnergyChargesRecordControl = hasFiltersEnergyChargesRecordControl && false; // suppress warning
      
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
            
            string url = @"../EnergyCharges/Edit-EnergyCharges.aspx?EnergyCharges={PK}";
            
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
        
        public System.Web.UI.WebControls.Literal BD0004 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0004Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0004R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0004RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0408 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0408Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0408R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0408RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0812 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0812Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0812R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0812RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD1216 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1216Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD1216R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1216RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD1620 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1620Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD1620R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1620RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD2024 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD2024Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD2024R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD2024RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024RLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DialogEditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal EnergyChargeId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargeId");
            }
        }
            
        public System.Web.UI.WebControls.Literal EnergyChargeIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargeIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0004 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0004Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0004R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0004RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0408 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0408Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0408R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0408RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0812 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0812Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0812R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0812RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD1216 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1216Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD1216R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1216RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD1620 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1620Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD1620R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1620RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620RLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD2024 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD2024Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD2024R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD2024RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024RLabel");
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
            
              if (this.RecordUniqueId != null) {
              
                return EnergyChargesTable.GetRecord(this.RecordUniqueId, true);
              
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

  