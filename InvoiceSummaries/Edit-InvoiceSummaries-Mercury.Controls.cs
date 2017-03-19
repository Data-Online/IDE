
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Edit_InvoiceSummaries_Mercury.aspx page.  The Row or RecordControl classes are the 
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


namespace IDE.UI.Controls.Edit_InvoiceSummaries_Mercury
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


    public class NetworkChargesTableControlRow : BaseNetworkChargesTableControlRow
    {

        // The BaseNetworkChargesTableControlRow implements code for a ROW within the
        // the NetworkChargesTableControl table.  The BaseNetworkChargesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of NetworkChargesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.

    }



    public class NetworkChargesTableControl : BaseNetworkChargesTableControl
    {
        // The BaseNetworkChargesTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The NetworkChargesTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    }


    public class OtherChargesTableControlRow : BaseOtherChargesTableControlRow
    {

        // The BaseOtherChargesTableControlRow implements code for a ROW within the
        // the OtherChargesTableControl table.  The BaseOtherChargesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of OtherChargesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.

    }



    public class OtherChargesTableControl : BaseOtherChargesTableControl
    {
        // The BaseOtherChargesTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The OtherChargesTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    }


    public class InvoiceSummariesRecordControl : BaseInvoiceSummariesRecordControl
    {

        // The BaseInvoiceSummariesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        public override void SetContainerId()
        {

            //Code for the text property is generated inside the .aspx file. 
            //To override this property you can uncomment the following property and add you own value.
            this.ContainerId.Text = this.DataSource.SiteId.ToString().PadLeft(6, '0');
            this.PdfFileName.Text = this.DataSource.InvoiceSummaryId.ToString().PadLeft(8, '0') + ".pdf";
        }

        public override void SetAlert()
        {
            this.Alert.Visible = false;
            string alertMessage = "";

            bool invOnFile = (this.Page as BaseApplicationPage).UploadToBlob(this.DataSource.InvoiceId, this.DataSource.SiteId);

            alertMessage = (this.Page as BaseApplicationPage).CallCustomStoredProcedure("sp_ValidateInvoice", this.DataSource.InvoiceSummaryId, invOnFile);
            if (alertMessage.Length > 0)
            {
                this.Alert.Text = alertMessage;
                this.Alert.Visible = true;

            }
        }
    }



    #endregion



    #region "Section 2: Do not modify this section."
    
    
// Base class for the EnergyChargesTableControlRow control on the Edit_InvoiceSummaries_Mercury page.
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
              this.DeleteRowButton1.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IDE") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton1.Click += DeleteRowButton1_Click;
                        
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
              this.BD0004.TextChanged += BD0004_TextChanged;
            
              this.BD0004R.TextChanged += BD0004R_TextChanged;
            
              this.BD0812.TextChanged += BD0812_TextChanged;
            
              this.BD0812R.TextChanged += BD0812R_TextChanged;
            
              this.BDL0004.TextChanged += BDL0004_TextChanged;
            
              this.BDQ0004.TextChanged += BDQ0004_TextChanged;
            
              this.NBD0004.TextChanged += NBD0004_TextChanged;
            
              this.NBD0004R.TextChanged += NBD0004R_TextChanged;
            
              this.NBD0812.TextChanged += NBD0812_TextChanged;
            
              this.NBD0812R.TextChanged += NBD0812R_TextChanged;
            
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
                SetBD0812();
                SetBD0812Label();
                SetBD0812R();
                SetBDL0004();
                SetBDQ0004();
                SetBDQ0004Label();
                
                
                SetLiteral1();
                SetLiteral2();
                SetLiteral8();
                SetNBD0004();
                SetNBD0004Label();
                SetNBD0004R();
                SetNBD0812();
                SetNBD0812Label();
                SetNBD0812R();
                
                
                
                
                
                
                SetTotal4();
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
                
        public virtual void SetBDL0004()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BDL0004.ID))
            {
            
                this.BDL0004.Text = this.PreviousUIData[this.BDL0004.ID].ToString();
              
                return;
            }
            
                    
            // Set the BDL0004 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BDL0004 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BDL0004Specified) {
                								
                // If the BDL0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BDL0004);
                                
                this.BDL0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // BDL0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BDL0004.Text = EnergyChargesTable.BDL0004.Format(EnergyChargesTable.BDL0004.DefaultValue);
            		
            }
            
              this.BDL0004.TextChanged += BDL0004_TextChanged;
                               
        }
                
        public virtual void SetBDQ0004()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.BDQ0004.ID))
            {
            
                this.BDQ0004.Text = this.PreviousUIData[this.BDQ0004.ID].ToString();
              
                return;
            }
            
                    
            // Set the BDQ0004 TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BDQ0004 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BDQ0004Specified) {
                								
                // If the BDQ0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BDQ0004);
                                
                this.BDQ0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // BDQ0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BDQ0004.Text = EnergyChargesTable.BDQ0004.Format(EnergyChargesTable.BDQ0004.DefaultValue);
            		
            }
            
              this.BDQ0004.TextChanged += BDQ0004_TextChanged;
                               
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
                
        public virtual void SetBD0004Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.BD0004Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetBD0812Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.BD0812Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetBDQ0004Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.BDQ0004Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetLiteral1()
                  {
                  
                    
        }
                
        public virtual void SetLiteral2()
                  {
                  
                    
        }
                
        public virtual void SetLiteral8()
                  {
                  
                        this.Literal8.Text = EvaluateFormula("BD0004 + BD0408 + BD0812 + BD1216 + BD1620 + BD2024 + NBD0004 + NBD0408 + NBD0812 + NBD1216 + NBD1620 + NBD2024");
                    
                    
        }
                
        public virtual void SetNBD0004Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.NBD0004Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetNBD0812Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.NBD0812Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetTotal4()
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
            GetBD0812();
            GetBD0812R();
            GetBDL0004();
            GetBDQ0004();
            GetNBD0004();
            GetNBD0004R();
            GetNBD0812();
            GetNBD0812R();
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
                
        public virtual void GetBDL0004()
        {
            
            // Retrieve the value entered by the user on the BDL0004 ASP:TextBox, and
            // save it into the BDL0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BDL0004.Text, EnergyChargesTable.BDL0004);							
                          
                      
        }
                
        public virtual void GetBDQ0004()
        {
            
            // Retrieve the value entered by the user on the BDQ0004 ASP:TextBox, and
            // save it into the BDQ0004 field in DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.BDQ0004.Text, EnergyChargesTable.BDQ0004);							
                          
                      
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
                

      // To customize, override this method in EnergyChargesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersOtherChargesTableControl = false;
            hasFiltersOtherChargesTableControl = hasFiltersOtherChargesTableControl && false; // suppress warning
      
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
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        protected virtual void BD0004_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0004R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0812_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BD0812R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BDL0004_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void BDQ0004_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0004_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0004R_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0812_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void NBD0812R_TextChanged(object sender, EventArgs args)
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
            
        public System.Web.UI.WebControls.TextBox BDL0004 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDL0004");
            }
        }
            
        public System.Web.UI.WebControls.TextBox BDQ0004 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDQ0004");
            }
        }
            
        public System.Web.UI.WebControls.Literal BDQ0004Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BDQ0004Label");
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
        
        public System.Web.UI.WebControls.Literal Literal1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Literal2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal2");
            }
        }
        
        public System.Web.UI.WebControls.Literal Literal8 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal8");
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
            
        public System.Web.UI.WebControls.CheckBox SelectRow2 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow2");
            }
        }              
            
        public System.Web.UI.WebControls.Label Total4 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Total4");
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

  
// Base class for the EnergyChargesTableControl control on the Edit_InvoiceSummaries_Mercury page.
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
        
              // Show confirmation message on Click
              this.DeleteButton1.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "IDE") + "\"));");
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
          
                    this.AddButton1.Click += AddButton1_Click;
                        
                    this.DeleteButton1.Click += DeleteButton1_Click;
                        
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
        
                
                
                
                
                SetOrderSort2();
                
                SetSortByLabel2();
                
                SetAddButton1();
              
                SetDeleteButton1();
              
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

        

        public virtual void RegisterPostback()
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
    
            // Bind the buttons for EnergyChargesTableControl pagination.
        
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
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.InvoiceSummariesRecordControl invoiceSummariesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "InvoiceSummariesRecordControl") as IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.InvoiceSummariesRecordControl);
          
              if (invoiceSummariesRecordControlObj != null && invoiceSummariesRecordControlObj.GetRecord() != null && invoiceSummariesRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesRecordControlObj.GetRecord().InvoiceSummaryId.ToString());
              selectedRecordKeyValue.AddElement(EnergyChargesTable.EnergyChargeId.InternalName, invoiceSummariesRecordControlObj.GetRecord().InvoiceSummaryId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["EnergyChargesTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
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
            
      string selectedRecordInInvoiceSummariesRecordControl = HttpContext.Current.Session["EnergyChargesTableControlWhereClause"] as string;
      
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
                
                        if (recControl.BD0812.Text != "") {
                            rec.Parse(recControl.BD0812.Text, EnergyChargesTable.BD0812);
                  }
                
                        if (recControl.BD0812R.Text != "") {
                            rec.Parse(recControl.BD0812R.Text, EnergyChargesTable.BD0812R);
                  }
                
                        if (recControl.BDL0004.Text != "") {
                            rec.Parse(recControl.BDL0004.Text, EnergyChargesTable.BDL0004);
                  }
                
                        if (recControl.BDQ0004.Text != "") {
                            rec.Parse(recControl.BDQ0004.Text, EnergyChargesTable.BDQ0004);
                  }
                
                        if (recControl.NBD0004.Text != "") {
                            rec.Parse(recControl.NBD0004.Text, EnergyChargesTable.NBD0004);
                  }
                
                        if (recControl.NBD0004R.Text != "") {
                            rec.Parse(recControl.NBD0004R.Text, EnergyChargesTable.NBD0004R);
                  }
                
                        if (recControl.NBD0812.Text != "") {
                            rec.Parse(recControl.NBD0812.Text, EnergyChargesTable.NBD0812);
                  }
                
                        if (recControl.NBD0812R.Text != "") {
                            rec.Parse(recControl.NBD0812R.Text, EnergyChargesTable.NBD0812R);
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
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004 {Txt:Ascending}"), "BD0004 Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004 {Txt:Descending}"), "BD0004 Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004R {Txt:Ascending}"), "BD0004R Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0004R {Txt:Descending}"), "BD0004R Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408 {Txt:Ascending}"), "BD0408 Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408 {Txt:Descending}"), "BD0408 Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408R {Txt:Ascending}"), "BD0408R Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0408R {Txt:Descending}"), "BD0408R Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812 {Txt:Ascending}"), "BD0812 Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812 {Txt:Descending}"), "BD0812 Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812R {Txt:Ascending}"), "BD0812R Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD0812R {Txt:Descending}"), "BD0812R Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216 {Txt:Ascending}"), "BD1216 Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216 {Txt:Descending}"), "BD1216 Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216R {Txt:Ascending}"), "BD1216R Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1216R {Txt:Descending}"), "BD1216R Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1620 {Txt:Ascending}"), "BD1620 Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1620 {Txt:Descending}"), "BD1620 Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1620R {Txt:Ascending}"), "BD1620R Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BD1620R {Txt:Descending}"), "BD1620R Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDQ0004 {Txt:Ascending}"), "BDQ0004 Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDQ0004 {Txt:Descending}"), "BDQ0004 Desc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDL0004 {Txt:Ascending}"), "BDL0004 Asc"));
              
                this.OrderSort2.Items.Add(new ListItem(this.Page.ExpandResourceValue("BDL0004 {Txt:Descending}"), "BDL0004 Desc"));
              
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

            string orderByStr = (string)ViewState["EnergyChargesTableControl_OrderBy"];
          
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
                this.ViewState["EnergyChargesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetAddButton1()                
              
        {
        
   
        }
            
        public virtual void SetDeleteButton1()                
              
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
        public virtual void AddButton1_Click(object sender, ImageClickEventArgs args)
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
        public virtual void DeleteButton1_Click(object sender, ImageClickEventArgs args)
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
        
        public IDE.UI.IThemeButtonWithArrow Actions2Button {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions2Button");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton AddButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AddButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteButton1");
            }
        }
        
        public IDE.UI.IThemeButtonWithArrow Filters2Button {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters2Button");
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
        
        public System.Web.UI.WebControls.Label SortByLabel2 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel2");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ToggleAll2 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ToggleAll2");
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
                if (recControl.SelectRow2.Checked) {
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
                if (recControl.SelectRow2 != null && recControl.SelectRow2.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (EnergyChargesTableControlRow[])(selectedList.ToArray(Type.GetType("IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.EnergyChargesTableControlRow")));
          
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
                
                    recCtl.SelectRow2.Checked = false;
                
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
  
// Base class for the NetworkChargesTableControlRow control on the Edit_InvoiceSummaries_Mercury page.
// Do not modify this class. Instead override any method in NetworkChargesTableControlRow.
public class BaseNetworkChargesTableControlRow : IDE.UI.BaseApplicationRecordControl
{
        public BaseNetworkChargesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in NetworkChargesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in NetworkChargesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IDE") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
              this.CapacityCharge.TextChanged += CapacityCharge_TextChanged;
            
              this.DemandCharge.TextChanged += DemandCharge_TextChanged;
            
              this.FixedCharge.TextChanged += FixedCharge_TextChanged;
            
              this.VariableBD.TextChanged += VariableBD_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = NetworkChargesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseNetworkChargesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new NetworkChargesRecord();
            
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
        
                SetCapacityCharge();
                SetCapacityChargeLabel();
                
                SetDemandCharge();
                SetDemandChargeLabel();
                
                SetFixedCharge();
                SetFixedChargeLabel();
                SetLineChargeSum();
                
                SetTotal();
                SetVariableBD();
                SetVariableBDLabel();
                SetDeleteRowButton();
              
                SetEditRowButton();
              

      

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
        
        
        public virtual void SetCapacityCharge()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CapacityCharge.ID))
            {
            
                this.CapacityCharge.Text = this.PreviousUIData[this.CapacityCharge.ID].ToString();
              
                return;
            }
            
                    
            // Set the CapacityCharge TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.CapacityCharge is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CapacityChargeSpecified) {
                								
                // If the CapacityCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.CapacityCharge);
                                
                this.CapacityCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // CapacityCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CapacityCharge.Text = NetworkChargesTable.CapacityCharge.Format(NetworkChargesTable.CapacityCharge.DefaultValue);
            		
            }
            
              this.CapacityCharge.TextChanged += CapacityCharge_TextChanged;
                               
        }
                
        public virtual void SetDemandCharge()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.DemandCharge.ID))
            {
            
                this.DemandCharge.Text = this.PreviousUIData[this.DemandCharge.ID].ToString();
              
                return;
            }
            
                    
            // Set the DemandCharge TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.DemandCharge is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DemandChargeSpecified) {
                								
                // If the DemandCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.DemandCharge);
                                
                this.DemandCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // DemandCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DemandCharge.Text = NetworkChargesTable.DemandCharge.Format(NetworkChargesTable.DemandCharge.DefaultValue);
            		
            }
            
              this.DemandCharge.TextChanged += DemandCharge_TextChanged;
                               
        }
                
        public virtual void SetFixedCharge()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.FixedCharge.ID))
            {
            
                this.FixedCharge.Text = this.PreviousUIData[this.FixedCharge.ID].ToString();
              
                return;
            }
            
                    
            // Set the FixedCharge TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.FixedCharge is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FixedChargeSpecified) {
                								
                // If the FixedCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.FixedCharge);
                                
                this.FixedCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // FixedCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FixedCharge.Text = NetworkChargesTable.FixedCharge.Format(NetworkChargesTable.FixedCharge.DefaultValue);
            		
            }
            
              this.FixedCharge.TextChanged += FixedCharge_TextChanged;
                               
        }
                
        public virtual void SetVariableBD()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.VariableBD.ID))
            {
            
                this.VariableBD.Text = this.PreviousUIData[this.VariableBD.ID].ToString();
              
                return;
            }
            
                    
            // Set the VariableBD TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.VariableBD is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VariableBDSpecified) {
                								
                // If the VariableBD is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.VariableBD);
                                
                this.VariableBD.Text = formattedValue;
                   
            } 
            
            else {
            
                // VariableBD is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VariableBD.Text = NetworkChargesTable.VariableBD.Format(NetworkChargesTable.VariableBD.DefaultValue);
            		
            }
            
              this.VariableBD.TextChanged += VariableBD_TextChanged;
                               
        }
                
        public virtual void SetCapacityChargeLabel()
                  {
                  
                    
        }
                
        public virtual void SetDemandChargeLabel()
                  {
                  
                    
        }
                
        public virtual void SetFixedChargeLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.FixedChargeLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetLineChargeSum()
                  {
                  
                        this.LineChargeSum.Text = EvaluateFormula("DemandCharge + CapacityCharge + FixedCharge + VariableBD + VariableNBD");
                    
                    
        }
                
        public virtual void SetTotal()
                  {
                  
                    
        }
                
        public virtual void SetVariableBDLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.VariableBDLabel.Text = "Some value";
                    
                    
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
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).DataChanged = true;
                ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).ResetData = true;
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
        
            GetCapacityCharge();
            GetDemandCharge();
            GetFixedCharge();
            GetVariableBD();
        }
        
        
        public virtual void GetCapacityCharge()
        {
            
            // Retrieve the value entered by the user on the CapacityCharge ASP:TextBox, and
            // save it into the CapacityCharge field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CapacityCharge.Text, NetworkChargesTable.CapacityCharge);							
                          
                      
        }
                
        public virtual void GetDemandCharge()
        {
            
            // Retrieve the value entered by the user on the DemandCharge ASP:TextBox, and
            // save it into the DemandCharge field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.DemandCharge.Text, NetworkChargesTable.DemandCharge);							
                          
                      
        }
                
        public virtual void GetFixedCharge()
        {
            
            // Retrieve the value entered by the user on the FixedCharge ASP:TextBox, and
            // save it into the FixedCharge field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.FixedCharge.Text, NetworkChargesTable.FixedCharge);							
                          
                      
        }
                
        public virtual void GetVariableBD()
        {
            
            // Retrieve the value entered by the user on the VariableBD ASP:TextBox, and
            // save it into the VariableBD field in DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.VariableBD.Text, NetworkChargesTable.VariableBD);							
                          
                      
        }
                

      // To customize, override this method in NetworkChargesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersOtherChargesTableControl = false;
            hasFiltersOtherChargesTableControl = hasFiltersOtherChargesTableControl && false; // suppress warning
      
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
          NetworkChargesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).DataChanged = true;
            ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).ResetData = true;
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
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        NetworkChargesTableControl tc= ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((NetworkChargesTableControlRow)this);
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
            
            string url = @"../Shared/ConfigureEditRecord.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
            
            
        
        protected virtual void CapacityCharge_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void DemandCharge_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void FixedCharge_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void VariableBD_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseNetworkChargesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseNetworkChargesTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.TextBox CapacityCharge {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CapacityCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal CapacityChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CapacityChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox DemandCharge {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DemandCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal DemandChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DemandChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox FixedCharge {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FixedCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal FixedChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FixedChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LineChargeSum {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LineChargeSum");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SelectRow1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow1");
            }
        }              
            
        public System.Web.UI.WebControls.Label Total {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Total");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VariableBD {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableBD");
            }
        }
            
        public System.Web.UI.WebControls.Literal VariableBDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableBDLabel");
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
            
              if (this.RecordUniqueId != null) {
              
                return NetworkChargesTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the NetworkChargesTableControl control on the Edit_InvoiceSummaries_Mercury page.
// Do not modify this class. Instead override any method in NetworkChargesTableControl.
public class BaseNetworkChargesTableControl : IDE.UI.BaseApplicationTableControl
{
         
       public BaseNetworkChargesTableControl()
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
                
                if  (this.InSession(this.OrderSort1)) 				
                    initialVal = this.GetFromSession(this.OrderSort1);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort1.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort1.SelectedValue = initialVal;
                            
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
                        
                    this.Actions1Button.Button.Click += Actions1Button_Click;
                        
                    this.Filters1Button.Button.Click += Filters1Button_Click;
                        
            this.OrderSort1.SelectedIndexChanged += new EventHandler(OrderSort1_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(IDE.Business.NetworkChargesRecord);
                      this.DataSource = (NetworkChargesRecord[])(alist.ToArray(myrec));
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
                    foreach (NetworkChargesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IDE.Business.NetworkChargesRecord);
                    this.DataSource = (NetworkChargesRecord[])(postdata.ToArray(myrec));
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
        
        public virtual NetworkChargesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(NetworkChargesTable.Column1, true);          
            // selCols.Add(NetworkChargesTable.Column2, true);          
            // selCols.Add(NetworkChargesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return NetworkChargesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                NetworkChargesTable databaseTable = new NetworkChargesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(NetworkChargesRecord)) as NetworkChargesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(NetworkChargesTable.Column1, true);          
            // selCols.Add(NetworkChargesTable.Column2, true);          
            // selCols.Add(NetworkChargesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return NetworkChargesTable.GetRecordCount(join, where);
            else
            {
                NetworkChargesTable databaseTable = new NetworkChargesTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            NetworkChargesTableControlRow recControl = (NetworkChargesTableControlRow)(repItem.FindControl("NetworkChargesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
                
                SetOrderSort1();
                
                SetSortByLabel1();
                
                SetAddButton();
              
                SetDeleteButton();
              
                SetActions1Button();
              
                SetFilters1Button();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFilters1Button();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        

        public virtual void RegisterPostback()
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


            
            this.OrderSort1.ClearSelection();
            
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
    
            // Bind the buttons for NetworkChargesTableControl pagination.
        
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
              
            foreach (NetworkChargesTableControlRow recCtl in this.GetRecordControls())
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
            foreach (NetworkChargesTableControlRow recCtl in this.GetRecordControls()){
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
            NetworkChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.InvoiceSummariesRecordControl invoiceSummariesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "InvoiceSummariesRecordControl") as IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.InvoiceSummariesRecordControl);
          
              if (invoiceSummariesRecordControlObj != null && invoiceSummariesRecordControlObj.GetRecord() != null && invoiceSummariesRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(NetworkChargesTable.NetworkChargeId, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesRecordControlObj.GetRecord().InvoiceSummaryId.ToString());
              selectedRecordKeyValue.AddElement(NetworkChargesTable.NetworkChargeId.InternalName, invoiceSummariesRecordControlObj.GetRecord().InvoiceSummaryId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["NetworkChargesTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            NetworkChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesRecordControl = HttpContext.Current.Session["NetworkChargesTableControlWhereClause"] as string;
      
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                NetworkChargesTableControlRow recControl = (NetworkChargesTableControlRow)(repItem.FindControl("NetworkChargesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      NetworkChargesRecord rec = new NetworkChargesRecord();
        
                        if (recControl.CapacityCharge.Text != "") {
                            rec.Parse(recControl.CapacityCharge.Text, NetworkChargesTable.CapacityCharge);
                  }
                
                        if (recControl.DemandCharge.Text != "") {
                            rec.Parse(recControl.DemandCharge.Text, NetworkChargesTable.DemandCharge);
                  }
                
                        if (recControl.FixedCharge.Text != "") {
                            rec.Parse(recControl.FixedCharge.Text, NetworkChargesTable.FixedCharge);
                  }
                
                        if (recControl.VariableBD.Text != "") {
                            rec.Parse(recControl.VariableBD.Text, NetworkChargesTable.VariableBD);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new NetworkChargesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IDE.Business.NetworkChargesRecord);
                this.DataSource = (NetworkChargesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(NetworkChargesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(NetworkChargesTableControlRow rec)            
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
        
        public virtual void SetSortByLabel1()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel1.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOrderSort1()
        {
            
                this.PopulateOrderSort1(MiscUtils.GetSelectedValue(this.OrderSort1,  GetFromSession(this.OrderSort1)), 500);					
                    

        }
            
        // Get the filters' data for OrderSort1.
                
        protected virtual void PopulateOrderSort1(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort1.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Capacity Charge {Txt:Ascending}"), "CapacityCharge Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Capacity Charge {Txt:Descending}"), "CapacityCharge Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Demand Charge {Txt:Ascending}"), "DemandCharge Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Demand Charge {Txt:Descending}"), "DemandCharge Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fixed Charge {Txt:Ascending}"), "FixedCharge Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Fixed Charge {Txt:Descending}"), "FixedCharge Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Variable BD {Txt:Ascending}"), "VariableBD Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Variable BD {Txt:Descending}"), "VariableBD Desc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Variable NBD {Txt:Ascending}"), "VariableNBD Asc"));
              
                this.OrderSort1.Items.Add(new ListItem(this.Page.ExpandResourceValue("Variable NBD {Txt:Descending}"), "VariableNBD Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort1, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort1.SelectedValue != null && this.OrderSort1.Items.FindByValue(this.OrderSort1.SelectedValue) == null)
                this.OrderSort1.SelectedValue = null;
              
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("NetworkChargesTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                NetworkChargesTableControlRow recControl = (NetworkChargesTableControlRow)repItem.FindControl("NetworkChargesTableControlRow");
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
        
            this.SaveToSession(this.OrderSort1, this.OrderSort1.SelectedValue);
                  
            
                    
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
          
            this.SaveToSession(this.OrderSort1, this.OrderSort1.SelectedValue);
                  
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort1);
            
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

            string orderByStr = (string)ViewState["NetworkChargesTableControl_OrderBy"];
          
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
                this.ViewState["NetworkChargesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
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
            
        public virtual void SetActions1Button()                
              
        {
        
   
        }
            
        public virtual void SetFilters1Button()                
              
        {
                
         IThemeButtonWithArrow themeButtonFilters1Button = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Filters1Button"));
         themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
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
            
            
        
        // event handler for Button
        public virtual void Actions1Button_Click(object sender, EventArgs args)
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
        public virtual void Filters1Button_Click(object sender, EventArgs args)
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
        protected virtual void OrderSort1_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort1.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in NetworkChargesTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(NetworkChargesTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (NetworkChargesTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && NetworkChargesTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(NetworkChargesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(NetworkChargesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
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
                    _TotalRecords = NetworkChargesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  NetworkChargesRecord[] DataSource {
             
            get {
                return (NetworkChargesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public IDE.UI.IThemeButtonWithArrow Actions1Button {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actions1Button");
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
        
        public IDE.UI.IThemeButtonWithArrow Filters1Button {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Filters1Button");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort1 {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort1");
          }
          }
        
        public IDE.UI.IPaginationModern Pagination {
            get {
                return (IDE.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel1");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ToggleAll1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ToggleAll1");
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
                NetworkChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        NetworkChargesRecord rec = null;
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
                NetworkChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        NetworkChargesRecord rec = null;
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
            foreach (NetworkChargesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow1.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual NetworkChargesTableControlRow GetSelectedRecordControl()
        {
        NetworkChargesTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual NetworkChargesTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (NetworkChargesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow1 != null && recControl.SelectRow1.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (NetworkChargesTableControlRow[])(selectedList.ToArray(Type.GetType("IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.NetworkChargesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            NetworkChargesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (NetworkChargesTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.SelectRow1.Checked = false;
                
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

        public virtual NetworkChargesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "NetworkChargesTableControlRow");
	          List<NetworkChargesTableControlRow> list = new List<NetworkChargesTableControlRow>();
	          foreach (NetworkChargesTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the OtherChargesTableControlRow control on the Edit_InvoiceSummaries_Mercury page.
// Do not modify this class. Instead override any method in OtherChargesTableControlRow.
public class BaseOtherChargesTableControlRow : IDE.UI.BaseApplicationRecordControl
{
        public BaseOtherChargesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in OtherChargesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in OtherChargesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton2.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IDE") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton2.Click += DeleteRowButton2_Click;
                        
                    this.EditRowButton2.Click += EditRowButton2_Click;
                        
                    this.ViewRowButton.Click += ViewRowButton_Click;
                        
              this.AdminCharge.TextChanged += AdminCharge_TextChanged;
            
              this.EALevy1.TextChanged += EALevy1_TextChanged;
            
              this.EALevyR1.TextChanged += EALevyR1_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = OtherChargesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseOtherChargesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new OtherChargesRecord();
            
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
                
                SetEALevy1();
                SetEALevyR1();
                SetEALevyRLabel1();
                
                SetLiteral3();
                SetLiteral4();
                SetLiteral7();
                
                SetTotal3();
                
                SetDeleteRowButton2();
              
                SetEditRowButton2();
              
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
        
        
        public virtual void SetAdminCharge()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.AdminCharge.ID))
            {
            
                this.AdminCharge.Text = this.PreviousUIData[this.AdminCharge.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetEALevy1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.EALevy1.ID))
            {
            
                this.EALevy1.Text = this.PreviousUIData[this.EALevy1.ID].ToString();
              
                return;
            }
            
                    
            // Set the EALevy TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.EALevy1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EALevySpecified) {
                								
                // If the EALevy is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.EALevy);
                                
                this.EALevy1.Text = formattedValue;
                   
            } 
            
            else {
            
                // EALevy is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EALevy1.Text = OtherChargesTable.EALevy.Format(OtherChargesTable.EALevy.DefaultValue);
            		
            }
            
              this.EALevy1.TextChanged += EALevy1_TextChanged;
                               
        }
                
        public virtual void SetEALevyR1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.EALevyR1.ID))
            {
            
                this.EALevyR1.Text = this.PreviousUIData[this.EALevyR1.ID].ToString();
              
                return;
            }
            
                    
            // Set the EALevyR TextBox on the webpage with value from the
            // DatabaseCimscoPortal%dbo.OtherCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.OtherCharges record retrieved from the database.
            // this.EALevyR1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EALevyRSpecified) {
                								
                // If the EALevyR is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(OtherChargesTable.EALevyR);
                                
                this.EALevyR1.Text = formattedValue;
                   
            } 
            
            else {
            
                // EALevyR is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EALevyR1.Text = OtherChargesTable.EALevyR.Format(OtherChargesTable.EALevyR.DefaultValue);
            		
            }
            
              this.EALevyR1.TextChanged += EALevyR1_TextChanged;
                               
        }
                
        public virtual void SetAdminChargeLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.AdminChargeLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetEALevyRLabel1()
                  {
                  
                        this.EALevyRLabel1.Text = EvaluateFormula("\"Electricity Authority Rate / EA Levy Rate\"");
                      
                    
        }
                
        public virtual void SetLiteral3()
                  {
                  
                    
        }
                
        public virtual void SetLiteral4()
                  {
                  
                    
        }
                
        public virtual void SetLiteral7()
                  {
                  
                        this.Literal7.Text = EvaluateFormula("AdminCharge + EALevy + BDSVC + NBDSVC");
                    
                    
        }
                
        public virtual void SetTotal3()
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
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((OtherChargesTableControl)MiscUtils.GetParentControlObject(this, "OtherChargesTableControl")).DataChanged = true;
                ((OtherChargesTableControl)MiscUtils.GetParentControlObject(this, "OtherChargesTableControl")).ResetData = true;
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
            GetEALevy1();
            GetEALevyR1();
        }
        
        
        public virtual void GetAdminCharge()
        {
            
            // Retrieve the value entered by the user on the AdminCharge ASP:TextBox, and
            // save it into the AdminCharge field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.AdminCharge.Text, OtherChargesTable.AdminCharge);							
                          
                      
        }
                
        public virtual void GetEALevy1()
        {
            
            // Retrieve the value entered by the user on the EALevy ASP:TextBox, and
            // save it into the EALevy field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.EALevy1.Text, OtherChargesTable.EALevy);							
                          
                      
        }
                
        public virtual void GetEALevyR1()
        {
            
            // Retrieve the value entered by the user on the EALevyR ASP:TextBox, and
            // save it into the EALevyR field in DataSource DatabaseCimscoPortal%dbo.OtherCharges record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.EALevyR1.Text, OtherChargesTable.EALevyR);							
                          
                      
        }
                

      // To customize, override this method in OtherChargesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersOtherChargesTableControl = false;
            hasFiltersOtherChargesTableControl = hasFiltersOtherChargesTableControl && false; // suppress warning
      
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
          OtherChargesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((OtherChargesTableControl)MiscUtils.GetParentControlObject(this, "OtherChargesTableControl")).DataChanged = true;
            ((OtherChargesTableControl)MiscUtils.GetParentControlObject(this, "OtherChargesTableControl")).ResetData = true;
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
        
        public virtual void SetDeleteRowButton2()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton2()                
              
        {
        
   
        }
            
        public virtual void SetViewRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        OtherChargesTableControl tc= ((OtherChargesTableControl)MiscUtils.GetParentControlObject(this, "OtherChargesTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((OtherChargesTableControlRow)this);
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
        public virtual void EditRowButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Shared/ConfigureEditRecord.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
            
            string url = @"../Shared/ConfigureViewRecord.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
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
            
            
        
        protected virtual void AdminCharge_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void EALevy1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void EALevyR1_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseOtherChargesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseOtherChargesTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton2");
            }
        }
        
        public System.Web.UI.WebControls.TextBox EALevy1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EALevy1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox EALevyR1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EALevyR1");
            }
        }
            
        public System.Web.UI.WebControls.Literal EALevyRLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EALevyRLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton2");
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
        
        public System.Web.UI.WebControls.Literal Literal7 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal7");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SelectRow {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SelectRow");
            }
        }              
            
        public System.Web.UI.WebControls.Label Total3 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Total3");
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
            
              if (this.RecordUniqueId != null) {
              
                return OtherChargesTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the OtherChargesTableControl control on the Edit_InvoiceSummaries_Mercury page.
// Do not modify this class. Instead override any method in OtherChargesTableControl.
public class BaseOtherChargesTableControl : IDE.UI.BaseApplicationTableControl
{
         
       public BaseOtherChargesTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
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
            
                    this.Pagination2.FirstPage.Click += Pagination2_FirstPage_Click;
                        
                    this.Pagination2.LastPage.Click += Pagination2_LastPage_Click;
                        
                    this.Pagination2.NextPage.Click += Pagination2_NextPage_Click;
                        
                    this.Pagination2.PageSizeButton.Click += Pagination2_PageSizeButton_Click;
                        
                    this.Pagination2.PreviousPage.Click += Pagination2_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
                  
        
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
                      Type myrec = typeof(IDE.Business.OtherChargesRecord);
                      this.DataSource = (OtherChargesRecord[])(alist.ToArray(myrec));
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
                    foreach (OtherChargesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IDE.Business.OtherChargesRecord);
                    this.DataSource = (OtherChargesRecord[])(postdata.ToArray(myrec));
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
        
        public virtual OtherChargesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(OtherChargesTable.Column1, true);          
            // selCols.Add(OtherChargesTable.Column2, true);          
            // selCols.Add(OtherChargesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return OtherChargesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                OtherChargesTable databaseTable = new OtherChargesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(OtherChargesRecord)) as OtherChargesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(OtherChargesTable.Column1, true);          
            // selCols.Add(OtherChargesTable.Column2, true);          
            // selCols.Add(OtherChargesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return OtherChargesTable.GetRecordCount(join, where);
            else
            {
                OtherChargesTable databaseTable = new OtherChargesTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OtherChargesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            OtherChargesTableControlRow recControl = (OtherChargesTableControlRow)(repItem.FindControl("OtherChargesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        

        public virtual void RegisterPostback()
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
                this.Pagination2.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination2.CurrentPage.Text = "0";
            }
            this.Pagination2.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for OtherChargesTableControl pagination.
        
            this.Pagination2.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination2.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination2.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination2.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination2.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination2.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination2.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination2.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (OtherChargesTableControlRow recCtl in this.GetRecordControls())
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
            foreach (OtherChargesTableControlRow recCtl in this.GetRecordControls()){
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
            OtherChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.InvoiceSummariesRecordControl invoiceSummariesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "InvoiceSummariesRecordControl") as IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.InvoiceSummariesRecordControl);
          
              if (invoiceSummariesRecordControlObj != null && invoiceSummariesRecordControlObj.GetRecord() != null && invoiceSummariesRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(OtherChargesTable.OtherChargeId, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesRecordControlObj.GetRecord().InvoiceSummaryId.ToString());
              selectedRecordKeyValue.AddElement(OtherChargesTable.OtherChargeId.InternalName, invoiceSummariesRecordControlObj.GetRecord().InvoiceSummaryId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["OtherChargesTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            OtherChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesRecordControl = HttpContext.Current.Session["OtherChargesTableControlWhereClause"] as string;
      
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
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination2.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination2.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OtherChargesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                OtherChargesTableControlRow recControl = (OtherChargesTableControlRow)(repItem.FindControl("OtherChargesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      OtherChargesRecord rec = new OtherChargesRecord();
        
                        if (recControl.AdminCharge.Text != "") {
                            rec.Parse(recControl.AdminCharge.Text, OtherChargesTable.AdminCharge);
                  }
                
                        if (recControl.EALevy1.Text != "") {
                            rec.Parse(recControl.EALevy1.Text, OtherChargesTable.EALevy);
                  }
                
                        if (recControl.EALevyR1.Text != "") {
                            rec.Parse(recControl.EALevyR1.Text, OtherChargesTable.EALevyR);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new OtherChargesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IDE.Business.OtherChargesRecord);
                this.DataSource = (OtherChargesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(OtherChargesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(OtherChargesTableControlRow rec)            
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("OtherChargesTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                OtherChargesTableControlRow recControl = (OtherChargesTableControlRow)repItem.FindControl("OtherChargesTableControlRow");
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
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
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

            string orderByStr = (string)ViewState["OtherChargesTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination2");
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
                this.ViewState["OtherChargesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
           
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination2_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination2_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination2_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Pagination2_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination2.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination2.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination2_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = OtherChargesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  OtherChargesRecord[] DataSource {
             
            get {
                return (OtherChargesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public IDE.UI.IPaginationModern Pagination2 {
            get {
                return (IDE.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination2");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
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
                OtherChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        OtherChargesRecord rec = null;
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
                OtherChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        OtherChargesRecord rec = null;
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
            foreach (OtherChargesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual OtherChargesTableControlRow GetSelectedRecordControl()
        {
        OtherChargesTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual OtherChargesTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (OtherChargesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SelectRow != null && recControl.SelectRow.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (OtherChargesTableControlRow[])(selectedList.ToArray(Type.GetType("IDE.UI.Controls.Edit_InvoiceSummaries_Mercury.OtherChargesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            OtherChargesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (OtherChargesTableControlRow recCtl in recordList)
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

        public virtual OtherChargesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "OtherChargesTableControlRow");
	          List<OtherChargesTableControlRow> list = new List<OtherChargesTableControlRow>();
	          foreach (OtherChargesTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the InvoiceSummariesRecordControl control on the Edit_InvoiceSummaries_Mercury page.
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
                
              this.SiteId.SelectedIndexChanged += SiteId_SelectedIndexChanged;                  
                
              this.SupplierId.SelectedIndexChanged += SupplierId_SelectedIndexChanged;                  
                
              this.AccountNumber.TextChanged += AccountNumber_TextChanged;
            
              this.ConnectionNumber.TextChanged += ConnectionNumber_TextChanged;
            
              this.CustomerNumber.TextChanged += CustomerNumber_TextChanged;
            
              this.GstTotal.TextChanged += GstTotal_TextChanged;
            
              this.InvoiceDate.TextChanged += InvoiceDate_TextChanged;
            
              this.InvoiceDueDate.TextChanged += InvoiceDueDate_TextChanged;
            
              this.InvoiceNumber.TextChanged += InvoiceNumber_TextChanged;
            
              this.InvoiceTotal.TextChanged += InvoiceTotal_TextChanged;
            
              this.KWhTotal.TextChanged += KWhTotal_TextChanged;
            
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
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "InvoiceSummariesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new InvoiceSummariesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            InvoiceSummariesRecord[] recList = InvoiceSummariesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = InvoiceSummariesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
                SetAlert();
                SetCompanyType();
                SetConnectionNumber();
                SetConnectionNumberLabel();
                SetContainerId();
                SetCustomerNumber();
                SetCustomerNumberLabel();
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
                SetLiteral();
                SetPdfFileName();
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
            EnergyChargesTableControl recEnergyChargesTableControl = (EnergyChargesTableControl)(MiscUtils.FindControlRecursively(this.Page, "EnergyChargesTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recEnergyChargesTableControl.ResetControl();
          }
                  
        this.Page.SetControl("EnergyChargesTableControl");
        NetworkChargesTableControl recNetworkChargesTableControl = (NetworkChargesTableControl)(MiscUtils.FindControlRecursively(this.Page, "NetworkChargesTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recNetworkChargesTableControl.ResetControl();
          }
                  
        this.Page.SetControl("NetworkChargesTableControl");
        OtherChargesTableControl recOtherChargesTableControl = (OtherChargesTableControl)(MiscUtils.FindControlRecursively(this.Page, "OtherChargesTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recOtherChargesTableControl.ResetControl();
          }
                  
        this.Page.SetControl("OtherChargesTableControl");
        
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

            
            if (this.DataSource != null && this.DataSource.EnergyPointIdSpecified)
            {
                            
                // If the EnergyPointId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.EnergyPointId.ToString();
                
            }
            else
            {
                
                // EnergyPointId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = InvoiceSummariesTable.EnergyPointId.DefaultValue;
                				
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
                
        public virtual void SetAlert()
                  {
                  
                    
        }
                
        public virtual void SetCompanyType()
                  {
                  
                    
        }
                
        public virtual void SetConnectionNumberLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ConnectionNumberLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetContainerId()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ContainerId.Text = "Some value";
                    
                    
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
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.InvoiceTotalLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetKWhTotalLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.KWhTotalLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetLiteral()
                  {
                  
                    
        }
                
        public virtual void SetPdfFileName()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.PdfFileName.Text = "Some value";
                    
                    
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "InvoiceSummariesRecordControlPanel");
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
          EnergyChargesTableControl recEnergyChargesTableControl = (EnergyChargesTableControl)(MiscUtils.FindControlRecursively(this.Page, "EnergyChargesTableControl"));
        recEnergyChargesTableControl.SaveData();
          NetworkChargesTableControl recNetworkChargesTableControl = (NetworkChargesTableControl)(MiscUtils.FindControlRecursively(this.Page, "NetworkChargesTableControl"));
        recNetworkChargesTableControl.SaveData();
          OtherChargesTableControl recOtherChargesTableControl = (OtherChargesTableControl)(MiscUtils.FindControlRecursively(this.Page, "OtherChargesTableControl"));
        recOtherChargesTableControl.SaveData();
          
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
            GetEnergyPointId();
            GetGstTotal();
            GetInvoiceDate();
            GetInvoiceDueDate();
            GetInvoiceNumber();
            GetInvoiceTotal();
            GetKWhTotal();
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
         // Retrieve the value entered by the user on the SiteId ASP:QuickSelector, and
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
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersOtherChargesTableControl = false;
            hasFiltersOtherChargesTableControl = hasFiltersOtherChargesTableControl && false; // suppress warning
      
            WhereClause wc;
            InvoiceSummariesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["InvoiceSummaries"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "IDE").Replace("{URL}", "InvoiceSummaries"));
            }
            HttpContext.Current.Session["QueryString in Edit-InvoiceSummaries-Mercury"] = recId;
                  
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
        
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesRecordControl = false;
            hasFiltersInvoiceSummariesRecordControl = hasFiltersInvoiceSummariesRecordControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersOtherChargesTableControl = false;
            hasFiltersOtherChargesTableControl = hasFiltersOtherChargesTableControl && false; // suppress warning
      
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
        
        protected virtual void EnergyPointId_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void SiteId_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

        }
                      
                    
        protected virtual void SupplierId_SelectedIndexChanged(object sender, EventArgs args)
        {
          									

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
        
        public System.Web.UI.WebControls.Literal Alert {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Alert");
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
        
        public System.Web.UI.WebControls.Literal ContainerId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContainerId");
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
        
        public System.Web.UI.WebControls.Literal Literal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal");
            }
        }
        
        public System.Web.UI.WebControls.Literal PdfFileName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PdfFileName");
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

  

#endregion


}

