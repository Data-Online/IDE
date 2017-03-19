
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_EnergyCharges_Table.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IDE.UI.Controls.Edit_EnergyCharges_Table
{
  

#region "Section 1: Place your customizations here."

    
public class EnergyChargesTableControlRow : BaseEnergyChargesTableControlRow
{
      
        // The BaseEnergyChargesTableControlRow implements code for a ROW within the
        // the EnergyChargesTableControl table.  The BaseEnergyChargesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of EnergyChargesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class EnergyChargesTableControl : BaseEnergyChargesTableControl
{
    // The BaseEnergyChargesTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The EnergyChargesTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the EnergyChargesTableControlRow control on the Edit_EnergyCharges_Table page.
// Do not modify this class. Instead override any method in EnergyChargesTableControlRow.
public class BaseEnergyChargesTableControlRow : IDE.UI.BaseApplicationRecordControl
{
        public BaseEnergyChargesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in EnergyChargesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in EnergyChargesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IDE") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.EnergyChargeId.SelectedIndexChanged += EnergyChargeId_SelectedIndexChanged;                  
                
              this.BD0004.TextChanged += BD0004_TextChanged;
            
              this.BD0004R.TextChanged += BD0004R_TextChanged;
            
              this.BD0408.TextChanged += BD0408_TextChanged;
            
              this.BD0408R.TextChanged += BD0408R_TextChanged;
            
              this.BD0812.TextChanged += BD0812_TextChanged;
            
              this.BD0812R.TextChanged += BD0812R_TextChanged;
            
              this.BD1216.TextChanged += BD1216_TextChanged;
            
              this.BD1216R.TextChanged += BD1216R_TextChanged;
            
              this.BD1620.TextChanged += BD1620_TextChanged;
            
              this.BD1620R.TextChanged += BD1620R_TextChanged;
            
              this.BD2024.TextChanged += BD2024_TextChanged;
            
              this.BD2024R.TextChanged += BD2024R_TextChanged;
            
              this.NBD0004.TextChanged += NBD0004_TextChanged;
            
              this.NBD0004R.TextChanged += NBD0004R_TextChanged;
            
              this.NBD0408.TextChanged += NBD0408_TextChanged;
            
              this.NBD0408R.TextChanged += NBD0408R_TextChanged;
            
              this.NBD0812.TextChanged += NBD0812_TextChanged;
            
              this.NBD0812R.TextChanged += NBD0812R_TextChanged;
            
              this.NBD1216.TextChanged += NBD1216_TextChanged;
            
              this.NBD1216R.TextChanged += NBD1216R_TextChanged;
            
              this.NBD1620.TextChanged += NBD1620_TextChanged;
            
              this.NBD1620R.TextChanged += NBD1620R_TextChanged;
            
              this.NBD2024.TextChanged += NBD2024_TextChanged;
            
              this.NBD2024R.TextChanged += NBD2024R_TextChanged;
            
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
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseEnergyChargesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new EnergyChargesRecord();
            
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
        
        
        public virtual void SetBD0004()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD0004.ID))
            {
            
                this.BD0004.Text = this.PreviousUIData[this.BD0004.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD0004 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0004 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004Specified) {
                								
                // If the BD0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004);
                                
                this.BD0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0004.Text = EnergyChargesTable.BD0004.Format(EnergyChargesTable.BD0004.DefaultValue);
            		
            }
            
              this.BD0004.TextChanged += BD0004_TextChanged;
                               
        }
                
        public virtual void SetBD0004R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD0004R.ID))
            {
            
                this.BD0004R.Text = this.PreviousUIData[this.BD0004R.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD0004R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0004R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004RSpecified) {
                								
                // If the BD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004R);
                                
                this.BD0004R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0004R.Text = EnergyChargesTable.BD0004R.Format(EnergyChargesTable.BD0004R.DefaultValue);
            		
            }
            
              this.BD0004R.TextChanged += BD0004R_TextChanged;
                               
        }
                
        public virtual void SetBD0408()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD0408.ID))
            {
            
                this.BD0408.Text = this.PreviousUIData[this.BD0408.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD0408 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0408 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408Specified) {
                								
                // If the BD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408);
                                
                this.BD0408.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0408.Text = EnergyChargesTable.BD0408.Format(EnergyChargesTable.BD0408.DefaultValue);
            		
            }
            
              this.BD0408.TextChanged += BD0408_TextChanged;
                               
        }
                
        public virtual void SetBD0408R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD0408R.ID))
            {
            
                this.BD0408R.Text = this.PreviousUIData[this.BD0408R.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD0408R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0408R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408RSpecified) {
                								
                // If the BD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408R);
                                
                this.BD0408R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0408R.Text = EnergyChargesTable.BD0408R.Format(EnergyChargesTable.BD0408R.DefaultValue);
            		
            }
            
              this.BD0408R.TextChanged += BD0408R_TextChanged;
                               
        }
                
        public virtual void SetBD0812()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD0812.ID))
            {
            
                this.BD0812.Text = this.PreviousUIData[this.BD0812.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD0812 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0812 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812Specified) {
                								
                // If the BD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812);
                                
                this.BD0812.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0812.Text = EnergyChargesTable.BD0812.Format(EnergyChargesTable.BD0812.DefaultValue);
            		
            }
            
              this.BD0812.TextChanged += BD0812_TextChanged;
                               
        }
                
        public virtual void SetBD0812R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD0812R.ID))
            {
            
                this.BD0812R.Text = this.PreviousUIData[this.BD0812R.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD0812R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0812R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812RSpecified) {
                								
                // If the BD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812R);
                                
                this.BD0812R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0812R.Text = EnergyChargesTable.BD0812R.Format(EnergyChargesTable.BD0812R.DefaultValue);
            		
            }
            
              this.BD0812R.TextChanged += BD0812R_TextChanged;
                               
        }
                
        public virtual void SetBD1216()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD1216.ID))
            {
            
                this.BD1216.Text = this.PreviousUIData[this.BD1216.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD1216 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1216 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216Specified) {
                								
                // If the BD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216);
                                
                this.BD1216.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1216.Text = EnergyChargesTable.BD1216.Format(EnergyChargesTable.BD1216.DefaultValue);
            		
            }
            
              this.BD1216.TextChanged += BD1216_TextChanged;
                               
        }
                
        public virtual void SetBD1216R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD1216R.ID))
            {
            
                this.BD1216R.Text = this.PreviousUIData[this.BD1216R.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD1216R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1216R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216RSpecified) {
                								
                // If the BD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216R);
                                
                this.BD1216R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1216R.Text = EnergyChargesTable.BD1216R.Format(EnergyChargesTable.BD1216R.DefaultValue);
            		
            }
            
              this.BD1216R.TextChanged += BD1216R_TextChanged;
                               
        }
                
        public virtual void SetBD1620()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD1620.ID))
            {
            
                this.BD1620.Text = this.PreviousUIData[this.BD1620.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD1620 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1620 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620Specified) {
                								
                // If the BD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620);
                                
                this.BD1620.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1620.Text = EnergyChargesTable.BD1620.Format(EnergyChargesTable.BD1620.DefaultValue);
            		
            }
            
              this.BD1620.TextChanged += BD1620_TextChanged;
                               
        }
                
        public virtual void SetBD1620R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD1620R.ID))
            {
            
                this.BD1620R.Text = this.PreviousUIData[this.BD1620R.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD1620R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1620R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620RSpecified) {
                								
                // If the BD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620R);
                                
                this.BD1620R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1620R.Text = EnergyChargesTable.BD1620R.Format(EnergyChargesTable.BD1620R.DefaultValue);
            		
            }
            
              this.BD1620R.TextChanged += BD1620R_TextChanged;
                               
        }
                
        public virtual void SetBD2024()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD2024.ID))
            {
            
                this.BD2024.Text = this.PreviousUIData[this.BD2024.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD2024 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD2024 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024Specified) {
                								
                // If the BD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024);
                                
                this.BD2024.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD2024.Text = EnergyChargesTable.BD2024.Format(EnergyChargesTable.BD2024.DefaultValue);
            		
            }
            
              this.BD2024.TextChanged += BD2024_TextChanged;
                               
        }
                
        public virtual void SetBD2024R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BD2024R.ID))
            {
            
                this.BD2024R.Text = this.PreviousUIData[this.BD2024R.ID].ToString();
              
                return;
            }
            
                    
            // Set the BD2024R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD2024R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024RSpecified) {
                								
                // If the BD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024R);
                                
                this.BD2024R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD2024R.Text = EnergyChargesTable.BD2024R.Format(EnergyChargesTable.BD2024R.DefaultValue);
            		
            }
            
              this.BD2024R.TextChanged += BD2024R_TextChanged;
                               
        }
                
        public virtual void SetEnergyChargeId()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.EnergyChargeId.ID))
            {
                if (this.PreviousUIData[this.EnergyChargeId.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.EnergyChargeId.ID].ToString();
            }
            
            
            // Set the EnergyChargeId QuickSelector on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.
            
            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.EnergyChargeId is the ASP:QuickSelector on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetEnergyChargeId();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.EnergyChargeIdSpecified)
            {
                            
                // If the EnergyChargeId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.EnergyChargeId.ToString();
                
            }
            else
            {
                
                // EnergyChargeId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = EnergyChargesTable.EnergyChargeId.DefaultValue;
                				
            }			
                
            // Add the Please Select item.
            if (selectedValue == null || selectedValue == "")
                  MiscUtils.ResetSelectedItem(this.EnergyChargeId, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IDE"), "--PLEASE_SELECT--"));
                        
                  
            // Populate the item(s) to the control
            
            this.EnergyChargeId.SetFieldMaxLength(50);
            
            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object>();              
            FormulaEvaluator evaluator = new FormulaEvaluator();
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.EnergyChargeId, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.EnergyChargeId, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseCimscoPortal%dbo.InvoiceSummaries.InvoiceSummaryId = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(InvoiceSummariesTable.InvoiceSummaryId, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    InvoiceSummariesRecord[] rc = InvoiceSummariesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        InvoiceSummariesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.InvoiceSummaryIdSpecified)
                            cvalue = itemValue.InvoiceSummaryId.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = EnergyChargesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(EnergyChargesTable.EnergyChargeId);
                        if(_isExpandableNonCompositeForeignKey && EnergyChargesTable.EnergyChargeId.IsApplyDisplayAs)
                            fvalue = EnergyChargesTable.GetDFKA(itemValue, EnergyChargesTable.EnergyChargeId);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(InvoiceSummariesTable.SiteName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.EnergyChargeId, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
              string url = this.ModifyRedirectUrl("../InvoiceSummaries/InvoiceSummaries-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.EnergyChargeId.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("SiteName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("InvoiceSummaryId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--PLEASE_SELECT--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:PleaseSelect"))+ "&Mode=" + (this.Page as BaseApplicationPage).Encrypt("FieldValueSingleSelection") + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.EnergyChargeId.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(EnergyChargeId.AutoPostBack).ToLower() + ", event); return false;";
                  
                
                  
        }
                
        public virtual void SetNBD0004()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD0004.ID))
            {
            
                this.NBD0004.Text = this.PreviousUIData[this.NBD0004.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetNBD0004R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD0004R.ID))
            {
            
                this.NBD0004R.Text = this.PreviousUIData[this.NBD0004R.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD0004R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0004R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0004RSpecified) {
                								
                // If the NBD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0004R);
                                
                this.NBD0004R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0004R.Text = EnergyChargesTable.NBD0004R.Format(EnergyChargesTable.NBD0004R.DefaultValue);
            		
            }
            
              this.NBD0004R.TextChanged += NBD0004R_TextChanged;
                               
        }
                
        public virtual void SetNBD0408()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD0408.ID))
            {
            
                this.NBD0408.Text = this.PreviousUIData[this.NBD0408.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD0408 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0408 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408Specified) {
                								
                // If the NBD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408);
                                
                this.NBD0408.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0408.Text = EnergyChargesTable.NBD0408.Format(EnergyChargesTable.NBD0408.DefaultValue);
            		
            }
            
              this.NBD0408.TextChanged += NBD0408_TextChanged;
                               
        }
                
        public virtual void SetNBD0408R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD0408R.ID))
            {
            
                this.NBD0408R.Text = this.PreviousUIData[this.NBD0408R.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD0408R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0408R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408RSpecified) {
                								
                // If the NBD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408R);
                                
                this.NBD0408R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0408R.Text = EnergyChargesTable.NBD0408R.Format(EnergyChargesTable.NBD0408R.DefaultValue);
            		
            }
            
              this.NBD0408R.TextChanged += NBD0408R_TextChanged;
                               
        }
                
        public virtual void SetNBD0812()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD0812.ID))
            {
            
                this.NBD0812.Text = this.PreviousUIData[this.NBD0812.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD0812 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0812 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812Specified) {
                								
                // If the NBD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812);
                                
                this.NBD0812.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0812.Text = EnergyChargesTable.NBD0812.Format(EnergyChargesTable.NBD0812.DefaultValue);
            		
            }
            
              this.NBD0812.TextChanged += NBD0812_TextChanged;
                               
        }
                
        public virtual void SetNBD0812R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD0812R.ID))
            {
            
                this.NBD0812R.Text = this.PreviousUIData[this.NBD0812R.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD0812R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0812R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812RSpecified) {
                								
                // If the NBD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812R);
                                
                this.NBD0812R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0812R.Text = EnergyChargesTable.NBD0812R.Format(EnergyChargesTable.NBD0812R.DefaultValue);
            		
            }
            
              this.NBD0812R.TextChanged += NBD0812R_TextChanged;
                               
        }
                
        public virtual void SetNBD1216()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD1216.ID))
            {
            
                this.NBD1216.Text = this.PreviousUIData[this.NBD1216.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD1216 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1216 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216Specified) {
                								
                // If the NBD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216);
                                
                this.NBD1216.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1216.Text = EnergyChargesTable.NBD1216.Format(EnergyChargesTable.NBD1216.DefaultValue);
            		
            }
            
              this.NBD1216.TextChanged += NBD1216_TextChanged;
                               
        }
                
        public virtual void SetNBD1216R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD1216R.ID))
            {
            
                this.NBD1216R.Text = this.PreviousUIData[this.NBD1216R.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD1216R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1216R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216RSpecified) {
                								
                // If the NBD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216R);
                                
                this.NBD1216R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1216R.Text = EnergyChargesTable.NBD1216R.Format(EnergyChargesTable.NBD1216R.DefaultValue);
            		
            }
            
              this.NBD1216R.TextChanged += NBD1216R_TextChanged;
                               
        }
                
        public virtual void SetNBD1620()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD1620.ID))
            {
            
                this.NBD1620.Text = this.PreviousUIData[this.NBD1620.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD1620 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1620 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620Specified) {
                								
                // If the NBD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620);
                                
                this.NBD1620.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1620.Text = EnergyChargesTable.NBD1620.Format(EnergyChargesTable.NBD1620.DefaultValue);
            		
            }
            
              this.NBD1620.TextChanged += NBD1620_TextChanged;
                               
        }
                
        public virtual void SetNBD1620R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD1620R.ID))
            {
            
                this.NBD1620R.Text = this.PreviousUIData[this.NBD1620R.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD1620R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1620R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620RSpecified) {
                								
                // If the NBD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620R);
                                
                this.NBD1620R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1620R.Text = EnergyChargesTable.NBD1620R.Format(EnergyChargesTable.NBD1620R.DefaultValue);
            		
            }
            
              this.NBD1620R.TextChanged += NBD1620R_TextChanged;
                               
        }
                
        public virtual void SetNBD2024()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD2024.ID))
            {
            
                this.NBD2024.Text = this.PreviousUIData[this.NBD2024.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD2024 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD2024 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024Specified) {
                								
                // If the NBD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024);
                                
                this.NBD2024.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD2024.Text = EnergyChargesTable.NBD2024.Format(EnergyChargesTable.NBD2024.DefaultValue);
            		
            }
            
              this.NBD2024.TextChanged += NBD2024_TextChanged;
                               
        }
                
        public virtual void SetNBD2024R()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.NBD2024R.ID))
            {
            
                this.NBD2024R.Text = this.PreviousUIData[this.NBD2024R.ID].ToString();
              
                return;
            }
            
                    
            // Set the NBD2024R TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD2024R is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024RSpecified) {
                								
                // If the NBD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024R);
                                
                this.NBD2024R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD2024R.Text = EnergyChargesTable.NBD2024R.Format(EnergyChargesTable.NBD2024R.DefaultValue);
            		
            }
            
              this.NBD2024R.TextChanged += NBD2024R_TextChanged;
                               
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
                ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).DataChanged = true;
                ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).ResetData = true;
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
            
            // Retrieve the value entered by the user on the BD0004 ASP:TextBox, and
            // save it into the BD0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0004.Text, EnergyChargesTable.BD0004);							
                          
                      
        }
                
        public virtual void GetBD0004R()
        {
            
            // Retrieve the value entered by the user on the BD0004R ASP:TextBox, and
            // save it into the BD0004R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0004R.Text, EnergyChargesTable.BD0004R);							
                          
                      
        }
                
        public virtual void GetBD0408()
        {
            
            // Retrieve the value entered by the user on the BD0408 ASP:TextBox, and
            // save it into the BD0408 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0408.Text, EnergyChargesTable.BD0408);							
                          
                      
        }
                
        public virtual void GetBD0408R()
        {
            
            // Retrieve the value entered by the user on the BD0408R ASP:TextBox, and
            // save it into the BD0408R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0408R.Text, EnergyChargesTable.BD0408R);							
                          
                      
        }
                
        public virtual void GetBD0812()
        {
            
            // Retrieve the value entered by the user on the BD0812 ASP:TextBox, and
            // save it into the BD0812 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0812.Text, EnergyChargesTable.BD0812);							
                          
                      
        }
                
        public virtual void GetBD0812R()
        {
            
            // Retrieve the value entered by the user on the BD0812R ASP:TextBox, and
            // save it into the BD0812R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD0812R.Text, EnergyChargesTable.BD0812R);							
                          
                      
        }
                
        public virtual void GetBD1216()
        {
            
            // Retrieve the value entered by the user on the BD1216 ASP:TextBox, and
            // save it into the BD1216 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD1216.Text, EnergyChargesTable.BD1216);							
                          
                      
        }
                
        public virtual void GetBD1216R()
        {
            
            // Retrieve the value entered by the user on the BD1216R ASP:TextBox, and
            // save it into the BD1216R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD1216R.Text, EnergyChargesTable.BD1216R);							
                          
                      
        }
                
        public virtual void GetBD1620()
        {
            
            // Retrieve the value entered by the user on the BD1620 ASP:TextBox, and
            // save it into the BD1620 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD1620.Text, EnergyChargesTable.BD1620);							
                          
                      
        }
                
        public virtual void GetBD1620R()
        {
            
            // Retrieve the value entered by the user on the BD1620R ASP:TextBox, and
            // save it into the BD1620R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD1620R.Text, EnergyChargesTable.BD1620R);							
                          
                      
        }
                
        public virtual void GetBD2024()
        {
            
            // Retrieve the value entered by the user on the BD2024 ASP:TextBox, and
            // save it into the BD2024 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD2024.Text, EnergyChargesTable.BD2024);							
                          
                      
        }
                
        public virtual void GetBD2024R()
        {
            
            // Retrieve the value entered by the user on the BD2024R ASP:TextBox, and
            // save it into the BD2024R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BD2024R.Text, EnergyChargesTable.BD2024R);							
                          
                      
        }
                
        public virtual void GetEnergyChargeId()
        {
         // Retrieve the value entered by the user on the EnergyChargeId ASP:QuickSelector, and
            // save it into the EnergyChargeId field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.EnergyChargeId), EnergyChargesTable.EnergyChargeId);			
                			 
        }
                
        public virtual void GetNBD0004()
        {
            
            // Retrieve the value entered by the user on the NBD0004 ASP:TextBox, and
            // save it into the NBD0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0004.Text, EnergyChargesTable.NBD0004);							
                          
                      
        }
                
        public virtual void GetNBD0004R()
        {
            
            // Retrieve the value entered by the user on the NBD0004R ASP:TextBox, and
            // save it into the NBD0004R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0004R.Text, EnergyChargesTable.NBD0004R);							
                          
                      
        }
                
        public virtual void GetNBD0408()
        {
            
            // Retrieve the value entered by the user on the NBD0408 ASP:TextBox, and
            // save it into the NBD0408 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0408.Text, EnergyChargesTable.NBD0408);							
                          
                      
        }
                
        public virtual void GetNBD0408R()
        {
            
            // Retrieve the value entered by the user on the NBD0408R ASP:TextBox, and
            // save it into the NBD0408R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0408R.Text, EnergyChargesTable.NBD0408R);							
                          
                      
        }
                
        public virtual void GetNBD0812()
        {
            
            // Retrieve the value entered by the user on the NBD0812 ASP:TextBox, and
            // save it into the NBD0812 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0812.Text, EnergyChargesTable.NBD0812);							
                          
                      
        }
                
        public virtual void GetNBD0812R()
        {
            
            // Retrieve the value entered by the user on the NBD0812R ASP:TextBox, and
            // save it into the NBD0812R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD0812R.Text, EnergyChargesTable.NBD0812R);							
                          
                      
        }
                
        public virtual void GetNBD1216()
        {
            
            // Retrieve the value entered by the user on the NBD1216 ASP:TextBox, and
            // save it into the NBD1216 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD1216.Text, EnergyChargesTable.NBD1216);							
                          
                      
        }
                
        public virtual void GetNBD1216R()
        {
            
            // Retrieve the value entered by the user on the NBD1216R ASP:TextBox, and
            // save it into the NBD1216R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD1216R.Text, EnergyChargesTable.NBD1216R);							
                          
                      
        }
                
        public virtual void GetNBD1620()
        {
            
            // Retrieve the value entered by the user on the NBD1620 ASP:TextBox, and
            // save it into the NBD1620 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD1620.Text, EnergyChargesTable.NBD1620);							
                          
                      
        }
                
        public virtual void GetNBD1620R()
        {
            
            // Retrieve the value entered by the user on the NBD1620R ASP:TextBox, and
            // save it into the NBD1620R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD1620R.Text, EnergyChargesTable.NBD1620R);							
                          
                      
        }
                
        public virtual void GetNBD2024()
        {
            
            // Retrieve the value entered by the user on the NBD2024 ASP:TextBox, and
            // save it into the NBD2024 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD2024.Text, EnergyChargesTable.NBD2024);							
                          
                      
        }
                
        public virtual void GetNBD2024R()
        {
            
            // Retrieve the value entered by the user on the NBD2024R ASP:TextBox, and
            // save it into the NBD2024R field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.NBD2024R.Text, EnergyChargesTable.NBD2024R);							
                          
                      
        }
                

      // To customize, override this method in EnergyChargesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
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
          EnergyChargesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).DataChanged = true;
            ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).ResetData = true;
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
        EnergyChargesTableControl tc= ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((EnergyChargesTableControlRow)this);
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
            
            
        
        // event handler for ImageButton
        public virtual void ViewRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../EnergyCharges/Show-EnergyCharges.aspx?EnergyCharges={PK}";
            
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
            
            
        
        protected virtual void EnergyChargeId_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void BD0004_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0004R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0408_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0408R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0812_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0812R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD1216_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD1216R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD1620_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD1620R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD2024_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD2024R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0004_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0004R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0408_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0408R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0812_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0812R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD1216_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD1216R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD1620_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD1620R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD2024_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD2024R_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseEnergyChargesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseEnergyChargesTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.TextBox BD0004 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0004Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0004R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0004RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0408 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0408Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0408R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0408RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0812 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0812Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD0812R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0812RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD1216 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1216Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD1216R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1216RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD1620 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1620Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD1620R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1620RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD2024 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD2024Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox BD2024R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD2024RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024RLabel");
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
        
        public BaseClasses.Web.UI.WebControls.QuickSelector EnergyChargeId {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargeId");
            }
        }              
            
        public System.Web.UI.WebControls.Literal EnergyChargeIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargeIdLabel");
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
        
        public System.Web.UI.WebControls.TextBox NBD0004R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0004RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0408 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0408Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0408R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0408RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0812 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0812Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD0812R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0812RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD1216 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1216Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD1216R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1216RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD1620 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1620Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD1620R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1620RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620RLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD2024 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD2024Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox NBD2024R {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD2024RLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024RLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SelectRow {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow");
            }
        }              
            
        public System.Web.UI.WebControls.ImageButton ViewRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ViewRowButton");
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

  
// Base class for the EnergyChargesTableControl control on the Edit_EnergyCharges_Table page.
// Do not modify this class. Instead override any method in EnergyChargesTableControl.
public class BaseEnergyChargesTableControl : IDE.UI.BaseApplicationTableControl
{
         
       public BaseEnergyChargesTableControl()
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
                if  (this.InSession(this.EnergyChargeIdFilter)) 				
                    initialVal = this.GetFromSession(this.EnergyChargeIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"EnergyChargeId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] EnergyChargeIdFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in EnergyChargeIdFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.EnergyChargeIdFilter.Items.Add(item);
                            this.EnergyChargeIdFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.EnergyChargeIdFilter.Items)
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
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.EnergyChargeIdFilter.SelectedIndexChanged += EnergyChargeIdFilter_SelectedIndexChanged;                  
                        
        
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
                      Type myrec = typeof(IDE.Business.EnergyChargesRecord);
                      this.DataSource = (EnergyChargesRecord[])(alist.ToArray(myrec));
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
                    foreach (EnergyChargesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IDE.Business.EnergyChargesRecord);
                    this.DataSource = (EnergyChargesRecord[])(postdata.ToArray(myrec));
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
        
        public virtual EnergyChargesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(EnergyChargesTable.Column1, true);          
            // selCols.Add(EnergyChargesTable.Column2, true);          
            // selCols.Add(EnergyChargesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return EnergyChargesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                EnergyChargesTable databaseTable = new EnergyChargesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(EnergyChargesRecord)) as EnergyChargesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(EnergyChargesTable.Column1, true);          
            // selCols.Add(EnergyChargesTable.Column2, true);          
            // selCols.Add(EnergyChargesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return EnergyChargesTable.GetRecordCount(join, where);
            else
            {
                EnergyChargesTable databaseTable = new EnergyChargesTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            EnergyChargesTableControlRow recControl = (EnergyChargesTableControlRow)(repItem.FindControl("EnergyChargesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                SetEnergyChargeIdFilter();
                SetEnergyChargeIdLabel1();
                
                
                SetOrderSort();
                
                
                
                SetSortByLabel();
                
                
                SetAddButton();
              
                SetDeleteButton();
              
                SetResetButton();
              
                SetSaveButton();
              
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
          
            this.Page.PregetDfkaRecords(EnergyChargesTable.EnergyChargeId, this.DataSource);
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


            
            this.EnergyChargeIdFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
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
    
            // Bind the buttons for EnergyChargesTableControl pagination.
        
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
              
            foreach (EnergyChargesTableControlRow recCtl in this.GetRecordControls())
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
            foreach (EnergyChargesTableControlRow recCtl in this.GetRecordControls()){
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
            EnergyChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.EnergyChargeIdFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.EnergyChargeIdFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.EnergyChargeIdFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            EnergyChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String EnergyChargeIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "EnergyChargeIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(EnergyChargeIdFilterSelectedValue)) {

              
        if (EnergyChargeIdFilterSelectedValue != null){
                        string[] EnergyChargeIdFilteritemListFromSession = EnergyChargeIdFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in EnergyChargeIdFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      

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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                EnergyChargesTableControlRow recControl = (EnergyChargesTableControlRow)(repItem.FindControl("EnergyChargesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      EnergyChargesRecord rec = new EnergyChargesRecord();
        
                        if (recControl.BD0004.Text != "") {
                            rec.Parse(recControl.BD0004.Text, EnergyChargesTable.BD0004);
                  }
                
                        if (recControl.BD0004R.Text != "") {
                            rec.Parse(recControl.BD0004R.Text, EnergyChargesTable.BD0004R);
                  }
                
                        if (recControl.BD0408.Text != "") {
                            rec.Parse(recControl.BD0408.Text, EnergyChargesTable.BD0408);
                  }
                
                        if (recControl.BD0408R.Text != "") {
                            rec.Parse(recControl.BD0408R.Text, EnergyChargesTable.BD0408R);
                  }
                
                        if (recControl.BD0812.Text != "") {
                            rec.Parse(recControl.BD0812.Text, EnergyChargesTable.BD0812);
                  }
                
                        if (recControl.BD0812R.Text != "") {
                            rec.Parse(recControl.BD0812R.Text, EnergyChargesTable.BD0812R);
                  }
                
                        if (recControl.BD1216.Text != "") {
                            rec.Parse(recControl.BD1216.Text, EnergyChargesTable.BD1216);
                  }
                
                        if (recControl.BD1216R.Text != "") {
                            rec.Parse(recControl.BD1216R.Text, EnergyChargesTable.BD1216R);
                  }
                
                        if (recControl.BD1620.Text != "") {
                            rec.Parse(recControl.BD1620.Text, EnergyChargesTable.BD1620);
                  }
                
                        if (recControl.BD1620R.Text != "") {
                            rec.Parse(recControl.BD1620R.Text, EnergyChargesTable.BD1620R);
                  }
                
                        if (recControl.BD2024.Text != "") {
                            rec.Parse(recControl.BD2024.Text, EnergyChargesTable.BD2024);
                  }
                
                        if (recControl.BD2024R.Text != "") {
                            rec.Parse(recControl.BD2024R.Text, EnergyChargesTable.BD2024R);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.EnergyChargeId)) {
                            rec.Parse(recControl.EnergyChargeId.SelectedItem.Value, EnergyChargesTable.EnergyChargeId);
                        }
                        if (recControl.NBD0004.Text != "") {
                            rec.Parse(recControl.NBD0004.Text, EnergyChargesTable.NBD0004);
                  }
                
                        if (recControl.NBD0004R.Text != "") {
                            rec.Parse(recControl.NBD0004R.Text, EnergyChargesTable.NBD0004R);
                  }
                
                        if (recControl.NBD0408.Text != "") {
                            rec.Parse(recControl.NBD0408.Text, EnergyChargesTable.NBD0408);
                  }
                
                        if (recControl.NBD0408R.Text != "") {
                            rec.Parse(recControl.NBD0408R.Text, EnergyChargesTable.NBD0408R);
                  }
                
                        if (recControl.NBD0812.Text != "") {
                            rec.Parse(recControl.NBD0812.Text, EnergyChargesTable.NBD0812);
                  }
                
                        if (recControl.NBD0812R.Text != "") {
                            rec.Parse(recControl.NBD0812R.Text, EnergyChargesTable.NBD0812R);
                  }
                
                        if (recControl.NBD1216.Text != "") {
                            rec.Parse(recControl.NBD1216.Text, EnergyChargesTable.NBD1216);
                  }
                
                        if (recControl.NBD1216R.Text != "") {
                            rec.Parse(recControl.NBD1216R.Text, EnergyChargesTable.NBD1216R);
                  }
                
                        if (recControl.NBD1620.Text != "") {
                            rec.Parse(recControl.NBD1620.Text, EnergyChargesTable.NBD1620);
                  }
                
                        if (recControl.NBD1620R.Text != "") {
                            rec.Parse(recControl.NBD1620R.Text, EnergyChargesTable.NBD1620R);
                  }
                
                        if (recControl.NBD2024.Text != "") {
                            rec.Parse(recControl.NBD2024.Text, EnergyChargesTable.NBD2024);
                  }
                
                        if (recControl.NBD2024R.Text != "") {
                            rec.Parse(recControl.NBD2024R.Text, EnergyChargesTable.NBD2024R);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new EnergyChargesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IDE.Business.EnergyChargesRecord);
                this.DataSource = (EnergyChargesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(EnergyChargesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(EnergyChargesTableControlRow rec)            
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
        
        public virtual void SetEnergyChargeIdLabel1()
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
            
        public virtual void SetEnergyChargeIdFilter()
        {
            
            ArrayList EnergyChargeIdFilterselectedFilterItemList = new ArrayList();
            string EnergyChargeIdFilteritemsString = null;
            if (this.InSession(this.EnergyChargeIdFilter))
                EnergyChargeIdFilteritemsString = this.GetFromSession(this.EnergyChargeIdFilter);
            
            if (EnergyChargeIdFilteritemsString != null)
            {
                string[] EnergyChargeIdFilteritemListFromSession = EnergyChargeIdFilteritemsString.Split(',');
                foreach (string item in EnergyChargeIdFilteritemListFromSession)
                {
                    EnergyChargeIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateEnergyChargeIdFilter(MiscUtils.GetSelectedValueList(this.EnergyChargeIdFilter, EnergyChargeIdFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../InvoiceSummaries/InvoiceSummaries-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.EnergyChargeIdFilter.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("SiteName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("InvoiceSummaryId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.EnergyChargeIdFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(EnergyChargeIdFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for OrderSort.
                
        protected virtual void PopulateOrderSort(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004 {Txt:Ascending}"), "BD0004 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004 {Txt:Descending}"), "BD0004 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004R {Txt:Ascending}"), "BD0004R Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004R {Txt:Descending}"), "BD0004R Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408 {Txt:Ascending}"), "BD0408 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408 {Txt:Descending}"), "BD0408 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408R {Txt:Ascending}"), "BD0408R Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408R {Txt:Descending}"), "BD0408R Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812 {Txt:Ascending}"), "BD0812 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812 {Txt:Descending}"), "BD0812 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812R {Txt:Ascending}"), "BD0812R Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812R {Txt:Descending}"), "BD0812R Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216 {Txt:Ascending}"), "BD1216 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216 {Txt:Descending}"), "BD1216 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216R {Txt:Ascending}"), "BD1216R Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216R {Txt:Descending}"), "BD1216R Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1620 {Txt:Ascending}"), "BD1620 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1620 {Txt:Descending}"), "BD1620 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Charge {Txt:Ascending}"), "EnergyChargeId Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Charge {Txt:Descending}"), "EnergyChargeId Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDQ0004 {Txt:Ascending}"), "BDQ0004 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDQ0004 {Txt:Descending}"), "BDQ0004 Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDL0004 {Txt:Ascending}"), "BDL0004 Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDL0004 {Txt:Descending}"), "BDL0004 Desc"));
              
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
            
        // Get the filters' data for EnergyChargeIdFilter.
                
        protected virtual void PopulateEnergyChargeIdFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_EnergyChargeIdFilter();            
            this.EnergyChargeIdFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_EnergyChargeIdFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IDE");

            InvoiceSummariesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = InvoiceSummariesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (InvoiceSummariesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.InvoiceSummaryIdSpecified) 
                        {
                            cvalue = itemValue.InvoiceSummaryId.ToString();
                            if (counter < maxItems && this.EnergyChargeIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = EnergyChargesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(EnergyChargesTable.EnergyChargeId);
                                if(_isExpandableNonCompositeForeignKey && EnergyChargesTable.EnergyChargeId.IsApplyDisplayAs)
                                     fvalue = EnergyChargesTable.GetDFKA(itemValue, EnergyChargesTable.EnergyChargeId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(InvoiceSummariesTable.SiteName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.EnergyChargeIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.EnergyChargeIdFilter.Items.Add(newItem);

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
            
            
            this.EnergyChargeIdFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.EnergyChargeIdFilter.Items.Count == 0)
                this.EnergyChargeIdFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "IDE"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.EnergyChargeIdFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_EnergyChargeIdFilter()
        {
            // Create a where clause for the filter EnergyChargeIdFilter.
            // This function is called by the Populate method to load the items 
            // in the EnergyChargeIdFilterQuickSelector
        
            ArrayList EnergyChargeIdFilterselectedFilterItemList = new ArrayList();
            string EnergyChargeIdFilteritemsString = null;
            if (this.InSession(this.EnergyChargeIdFilter))
                EnergyChargeIdFilteritemsString = this.GetFromSession(this.EnergyChargeIdFilter);
            
            if (EnergyChargeIdFilteritemsString != null)
            {
                string[] EnergyChargeIdFilteritemListFromSession = EnergyChargeIdFilteritemsString.Split(',');
                foreach (string item in EnergyChargeIdFilteritemListFromSession)
                {
                    EnergyChargeIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            EnergyChargeIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.EnergyChargeIdFilter, EnergyChargeIdFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (EnergyChargeIdFilterselectedFilterItemList == null || EnergyChargeIdFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in EnergyChargeIdFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(InvoiceSummariesTable.InvoiceSummaryId, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("EnergyChargesTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                EnergyChargesTableControlRow recControl = (EnergyChargesTableControlRow)repItem.FindControl("EnergyChargesTableControlRow");
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
                  
            ArrayList EnergyChargeIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.EnergyChargeIdFilter, null);
            string EnergyChargeIdFilterSessionString = "";
            if (EnergyChargeIdFilterselectedFilterItemList != null){
                foreach (string item in EnergyChargeIdFilterselectedFilterItemList){
                    EnergyChargeIdFilterSessionString = String.Concat(EnergyChargeIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.EnergyChargeIdFilter, EnergyChargeIdFilterSessionString);
                  
            
                    
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
                  
            ArrayList EnergyChargeIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.EnergyChargeIdFilter, null);
            string EnergyChargeIdFilterSessionString = "";
            if (EnergyChargeIdFilterselectedFilterItemList != null){
                foreach (string item in EnergyChargeIdFilterselectedFilterItemList){
                    EnergyChargeIdFilterSessionString = String.Concat(EnergyChargeIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("EnergyChargeIdFilter_Ajax", EnergyChargeIdFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.EnergyChargeIdFilter);
            
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

            string orderByStr = (string)ViewState["EnergyChargesTableControl_OrderBy"];
          
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
                this.ViewState["EnergyChargesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
    
      
            if (MiscUtils.IsValueSelected(EnergyChargeIdFilter))
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
                
              this.EnergyChargeIdFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
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
           
                foreach (EnergyChargesTableControlRow recCtl in this.GetRecordControls()){
                     
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
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in EnergyChargesTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(EnergyChargesTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (EnergyChargesTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && EnergyChargesTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(EnergyChargesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(EnergyChargesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void EnergyChargeIdFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = EnergyChargesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  EnergyChargesRecord[] DataSource {
             
            get {
                return (EnergyChargesRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.ImageButton DeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector EnergyChargeIdFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargeIdFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal EnergyChargeIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargeIdLabel1");
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
                EnergyChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        EnergyChargesRecord rec = null;
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
                EnergyChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        EnergyChargesRecord rec = null;
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
            foreach (EnergyChargesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual EnergyChargesTableControlRow GetSelectedRecordControl()
        {
        EnergyChargesTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual EnergyChargesTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (EnergyChargesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (EnergyChargesTableControlRow[])(selectedList.ToArray(Type.GetType("IDE.UI.Controls.Edit_EnergyCharges_Table.EnergyChargesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            EnergyChargesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (EnergyChargesTableControlRow recCtl in recordList)
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

        public virtual EnergyChargesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "EnergyChargesTableControlRow");
	          List<EnergyChargesTableControlRow> list = new List<EnergyChargesTableControlRow>();
	          foreach (EnergyChargesTableControlRow recCtrl in recCtrls) {
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

  