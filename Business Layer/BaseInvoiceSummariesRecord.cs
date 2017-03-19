// This class is "generated" and will be overwritten.
// Your customizations should be made in InvoiceSummariesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="InvoiceSummariesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="InvoiceSummariesTable"></see> class.
/// </remarks>
/// <seealso cref="InvoiceSummariesTable"></seealso>
/// <seealso cref="InvoiceSummariesRecord"></seealso>
public class BaseInvoiceSummariesRecord : PrimaryKeyRecord
{

	public readonly static InvoiceSummariesTable TableUtils = InvoiceSummariesTable.Instance;

	// Constructors
 
	protected BaseInvoiceSummariesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.InvoiceSummariesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.InvoiceSummariesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.InvoiceSummariesRecord_ReadRecord); 
	}

	protected BaseInvoiceSummariesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void InvoiceSummariesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                InvoiceSummariesRecord InvoiceSummariesRec = (InvoiceSummariesRecord)sender;
        if(InvoiceSummariesRec != null && !InvoiceSummariesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void InvoiceSummariesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                InvoiceSummariesRecord InvoiceSummariesRec = (InvoiceSummariesRecord)sender;
        Validate_Inserting();
        if(InvoiceSummariesRec != null && !InvoiceSummariesRec.IsReadOnly ){
               InvoiceSummariesRec.Parse(EvaluateFormula("\"empty\"",this,null),InvoiceSummariesTable.SiteName);
        }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void InvoiceSummariesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                InvoiceSummariesRecord InvoiceSummariesRec = (InvoiceSummariesRecord)sender;
        Validate_Updating();
        if(InvoiceSummariesRec != null && !InvoiceSummariesRec.IsReadOnly ){
                }
    
    }

   //Evaluates Validate when->Inserting formulas specified at the data access layer
	protected virtual void Validate_Inserting()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
 
	//Evaluates Validate when->Updating formulas specified at the data access layer
	protected virtual void Validate_Updating()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
	public virtual string EvaluateFormula(string formula, BaseRecord  dataSourceForEvaluate, string format)
    {
        Data.BaseFormulaEvaluator e = new Data.BaseFormulaEvaluator();
        
        // All variables referred to in the formula are expected to be
        // properties of the DataSource.  For example, referring to
        // UnitPrice as a variable will refer to DataSource.UnitPrice
        e.DataSource = dataSourceForEvaluate;

        Object resultObj = e.Evaluate(formula);
        if(resultObj == null) 
			return "";
        return resultObj.ToString();
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceSummaryId field.
	/// </summary>
	public ColumnValue GetInvoiceSummaryIdValue()
	{
		return this.GetValue(TableUtils.InvoiceSummaryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceSummaryId field.
	/// </summary>
	public Int32 GetInvoiceSummaryIdFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceSummaryIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public ColumnValue GetInvoiceIdValue()
	{
		return this.GetValue(TableUtils.InvoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public Int32 GetInvoiceIdFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public void SetInvoiceIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public void SetInvoiceIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public void SetInvoiceIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public void SetInvoiceIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public void SetInvoiceIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceDate field.
	/// </summary>
	public ColumnValue GetInvoiceDateValue()
	{
		return this.GetValue(TableUtils.InvoiceDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceDate field.
	/// </summary>
	public DateTime GetInvoiceDateFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDate field.
	/// </summary>
	public void SetInvoiceDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoiceDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDate field.
	/// </summary>
	public void SetInvoiceDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvoiceDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDate field.
	/// </summary>
	public void SetInvoiceDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceNumber field.
	/// </summary>
	public ColumnValue GetInvoiceNumberValue()
	{
		return this.GetValue(TableUtils.InvoiceNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceNumber field.
	/// </summary>
	public string GetInvoiceNumberFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceNumber field.
	/// </summary>
	public void SetInvoiceNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoiceNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceNumber field.
	/// </summary>
	public void SetInvoiceNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public ColumnValue GetGstTotalValue()
	{
		return this.GetValue(TableUtils.GstTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public Decimal GetGstTotalFieldValue()
	{
		return this.GetValue(TableUtils.GstTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public void SetGstTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GstTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public void SetGstTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.GstTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public void SetGstTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GstTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public void SetGstTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GstTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public void SetGstTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GstTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public ColumnValue GetInvoiceTotalValue()
	{
		return this.GetValue(TableUtils.InvoiceTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public Decimal GetInvoiceTotalFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public void SetInvoiceTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoiceTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public void SetInvoiceTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvoiceTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public void SetInvoiceTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public void SetInvoiceTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public void SetInvoiceTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.AccountNumber field.
	/// </summary>
	public ColumnValue GetAccountNumberValue()
	{
		return this.GetValue(TableUtils.AccountNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.AccountNumber field.
	/// </summary>
	public string GetAccountNumberFieldValue()
	{
		return this.GetValue(TableUtils.AccountNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.AccountNumber field.
	/// </summary>
	public void SetAccountNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AccountNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.AccountNumber field.
	/// </summary>
	public void SetAccountNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccountNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.CustomerNumber field.
	/// </summary>
	public ColumnValue GetCustomerNumberValue()
	{
		return this.GetValue(TableUtils.CustomerNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.CustomerNumber field.
	/// </summary>
	public string GetCustomerNumberFieldValue()
	{
		return this.GetValue(TableUtils.CustomerNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.CustomerNumber field.
	/// </summary>
	public void SetCustomerNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustomerNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.CustomerNumber field.
	/// </summary>
	public void SetCustomerNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public ColumnValue GetSiteIdValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public Int32 GetSiteIdFieldValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public ColumnValue GetNetworkChargesTotalValue()
	{
		return this.GetValue(TableUtils.NetworkChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public Decimal GetNetworkChargesTotalFieldValue()
	{
		return this.GetValue(TableUtils.NetworkChargesTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public void SetNetworkChargesTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public void SetNetworkChargesTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public void SetNetworkChargesTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public void SetNetworkChargesTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public void SetNetworkChargesTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkChargesTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public ColumnValue GetEnergyChargesTotalValue()
	{
		return this.GetValue(TableUtils.EnergyChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public Decimal GetEnergyChargesTotalFieldValue()
	{
		return this.GetValue(TableUtils.EnergyChargesTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public void SetEnergyChargesTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EnergyChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public void SetEnergyChargesTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.EnergyChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public void SetEnergyChargesTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public void SetEnergyChargesTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public void SetEnergyChargesTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyChargesTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public ColumnValue GetMiscChargesTotalValue()
	{
		return this.GetValue(TableUtils.MiscChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public Decimal GetMiscChargesTotalFieldValue()
	{
		return this.GetValue(TableUtils.MiscChargesTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public void SetMiscChargesTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MiscChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public void SetMiscChargesTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.MiscChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public void SetMiscChargesTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MiscChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public void SetMiscChargesTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MiscChargesTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public void SetMiscChargesTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MiscChargesTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public ColumnValue GetTotalChargesValue()
	{
		return this.GetValue(TableUtils.TotalChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public Decimal GetTotalChargesFieldValue()
	{
		return this.GetValue(TableUtils.TotalChargesColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public void SetTotalChargesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TotalChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public void SetTotalChargesFieldValue(string val)
	{
		this.SetString(val, TableUtils.TotalChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public void SetTotalChargesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public void SetTotalChargesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public void SetTotalChargesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalChargesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public ColumnValue GetGSTChargesValue()
	{
		return this.GetValue(TableUtils.GSTChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public Decimal GetGSTChargesFieldValue()
	{
		return this.GetValue(TableUtils.GSTChargesColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public void SetGSTChargesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GSTChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public void SetGSTChargesFieldValue(string val)
	{
		this.SetString(val, TableUtils.GSTChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public void SetGSTChargesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GSTChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public void SetGSTChargesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GSTChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public void SetGSTChargesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GSTChargesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public ColumnValue GetTotalNetworkChargesValue()
	{
		return this.GetValue(TableUtils.TotalNetworkChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public Decimal GetTotalNetworkChargesFieldValue()
	{
		return this.GetValue(TableUtils.TotalNetworkChargesColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public void SetTotalNetworkChargesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TotalNetworkChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public void SetTotalNetworkChargesFieldValue(string val)
	{
		this.SetString(val, TableUtils.TotalNetworkChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public void SetTotalNetworkChargesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalNetworkChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public void SetTotalNetworkChargesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalNetworkChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public void SetTotalNetworkChargesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalNetworkChargesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public ColumnValue GetTotalMiscChargesValue()
	{
		return this.GetValue(TableUtils.TotalMiscChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public Decimal GetTotalMiscChargesFieldValue()
	{
		return this.GetValue(TableUtils.TotalMiscChargesColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public void SetTotalMiscChargesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TotalMiscChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public void SetTotalMiscChargesFieldValue(string val)
	{
		this.SetString(val, TableUtils.TotalMiscChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public void SetTotalMiscChargesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalMiscChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public void SetTotalMiscChargesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalMiscChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public void SetTotalMiscChargesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalMiscChargesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public ColumnValue GetTotalEnergyChargesValue()
	{
		return this.GetValue(TableUtils.TotalEnergyChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public Decimal GetTotalEnergyChargesFieldValue()
	{
		return this.GetValue(TableUtils.TotalEnergyChargesColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public void SetTotalEnergyChargesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TotalEnergyChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public void SetTotalEnergyChargesFieldValue(string val)
	{
		this.SetString(val, TableUtils.TotalEnergyChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public void SetTotalEnergyChargesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalEnergyChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public void SetTotalEnergyChargesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalEnergyChargesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public void SetTotalEnergyChargesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalEnergyChargesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.ConnectionNumber field.
	/// </summary>
	public ColumnValue GetConnectionNumberValue()
	{
		return this.GetValue(TableUtils.ConnectionNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.ConnectionNumber field.
	/// </summary>
	public string GetConnectionNumberFieldValue()
	{
		return this.GetValue(TableUtils.ConnectionNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ConnectionNumber field.
	/// </summary>
	public void SetConnectionNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ConnectionNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ConnectionNumber field.
	/// </summary>
	public void SetConnectionNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ConnectionNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.SiteName field.
	/// </summary>
	public ColumnValue GetSiteNameValue()
	{
		return this.GetValue(TableUtils.SiteNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.SiteName field.
	/// </summary>
	public string GetSiteNameFieldValue()
	{
		return this.GetValue(TableUtils.SiteNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteName field.
	/// </summary>
	public void SetSiteNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiteNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteName field.
	/// </summary>
	public void SetSiteNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceDueDate field.
	/// </summary>
	public ColumnValue GetInvoiceDueDateValue()
	{
		return this.GetValue(TableUtils.InvoiceDueDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.InvoiceDueDate field.
	/// </summary>
	public DateTime GetInvoiceDueDateFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceDueDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDueDate field.
	/// </summary>
	public void SetInvoiceDueDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoiceDueDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDueDate field.
	/// </summary>
	public void SetInvoiceDueDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.InvoiceDueDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDueDate field.
	/// </summary>
	public void SetInvoiceDueDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceDueDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Month field.
	/// </summary>
	public ColumnValue GetMonthValue()
	{
		return this.GetValue(TableUtils.MonthColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Month field.
	/// </summary>
	public string GetMonthFieldValue()
	{
		return this.GetValue(TableUtils.MonthColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Month field.
	/// </summary>
	public void SetMonthFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MonthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Month field.
	/// </summary>
	public void SetMonthFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MonthColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Year field.
	/// </summary>
	public ColumnValue GetYearValue()
	{
		return this.GetValue(TableUtils.YearColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Year field.
	/// </summary>
	public string GetYearFieldValue()
	{
		return this.GetValue(TableUtils.YearColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Year field.
	/// </summary>
	public void SetYearFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YearColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Year field.
	/// </summary>
	public void SetYearFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YearColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Approved field.
	/// </summary>
	public ColumnValue GetApprovedValue()
	{
		return this.GetValue(TableUtils.ApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Approved field.
	/// </summary>
	public bool GetApprovedFieldValue()
	{
		return this.GetValue(TableUtils.ApprovedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Approved field.
	/// </summary>
	public void SetApprovedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Approved field.
	/// </summary>
	public void SetApprovedFieldValue(string val)
	{
		this.SetString(val, TableUtils.ApprovedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Approved field.
	/// </summary>
	public void SetApprovedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ApprovedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.ApprovedById field.
	/// </summary>
	public ColumnValue GetApprovedByIdValue()
	{
		return this.GetValue(TableUtils.ApprovedByIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.ApprovedById field.
	/// </summary>
	public string GetApprovedByIdFieldValue()
	{
		return this.GetValue(TableUtils.ApprovedByIdColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ApprovedById field.
	/// </summary>
	public void SetApprovedByIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ApprovedByIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ApprovedById field.
	/// </summary>
	public void SetApprovedByIdFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ApprovedByIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.ApprovedDate field.
	/// </summary>
	public ColumnValue GetApprovedDateValue()
	{
		return this.GetValue(TableUtils.ApprovedDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.ApprovedDate field.
	/// </summary>
	public DateTime GetApprovedDateFieldValue()
	{
		return this.GetValue(TableUtils.ApprovedDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ApprovedDate field.
	/// </summary>
	public void SetApprovedDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ApprovedDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ApprovedDate field.
	/// </summary>
	public void SetApprovedDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ApprovedDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ApprovedDate field.
	/// </summary>
	public void SetApprovedDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ApprovedDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public ColumnValue GetPercentageChangeValue()
	{
		return this.GetValue(TableUtils.PercentageChangeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public Decimal GetPercentageChangeFieldValue()
	{
		return this.GetValue(TableUtils.PercentageChangeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public void SetPercentageChangeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PercentageChangeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public void SetPercentageChangeFieldValue(string val)
	{
		this.SetString(val, TableUtils.PercentageChangeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public void SetPercentageChangeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PercentageChangeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public void SetPercentageChangeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PercentageChangeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public void SetPercentageChangeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PercentageChangeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.PeriodStart field.
	/// </summary>
	public ColumnValue GetPeriodStartValue()
	{
		return this.GetValue(TableUtils.PeriodStartColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.PeriodStart field.
	/// </summary>
	public DateTime GetPeriodStartFieldValue()
	{
		return this.GetValue(TableUtils.PeriodStartColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodStart field.
	/// </summary>
	public void SetPeriodStartFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PeriodStartColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodStart field.
	/// </summary>
	public void SetPeriodStartFieldValue(string val)
	{
		this.SetString(val, TableUtils.PeriodStartColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodStart field.
	/// </summary>
	public void SetPeriodStartFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PeriodStartColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.PeriodEnd field.
	/// </summary>
	public ColumnValue GetPeriodEndValue()
	{
		return this.GetValue(TableUtils.PeriodEndColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.PeriodEnd field.
	/// </summary>
	public DateTime GetPeriodEndFieldValue()
	{
		return this.GetValue(TableUtils.PeriodEndColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodEnd field.
	/// </summary>
	public void SetPeriodEndFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PeriodEndColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodEnd field.
	/// </summary>
	public void SetPeriodEndFieldValue(string val)
	{
		this.SetString(val, TableUtils.PeriodEndColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodEnd field.
	/// </summary>
	public void SetPeriodEndFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PeriodEndColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public ColumnValue GetEnergyPointIdValue()
	{
		return this.GetValue(TableUtils.EnergyPointIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public Int32 GetEnergyPointIdFieldValue()
	{
		return this.GetValue(TableUtils.EnergyPointIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public void SetEnergyPointIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EnergyPointIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public void SetEnergyPointIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EnergyPointIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public void SetEnergyPointIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyPointIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public void SetEnergyPointIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyPointIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public void SetEnergyPointIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyPointIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public ColumnValue GetSupplierIdValue()
	{
		return this.GetValue(TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public Int32 GetSupplierIdFieldValue()
	{
		return this.GetValue(TableUtils.SupplierIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public ColumnValue GetKwhTotalValue()
	{
		return this.GetValue(TableUtils.KwhTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public Decimal GetKwhTotalFieldValue()
	{
		return this.GetValue(TableUtils.KwhTotalColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public void SetKwhTotalFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KwhTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public void SetKwhTotalFieldValue(string val)
	{
		this.SetString(val, TableUtils.KwhTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public void SetKwhTotalFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KwhTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public void SetKwhTotalFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KwhTotalColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public void SetKwhTotalFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KwhTotalColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Verified field.
	/// </summary>
	public ColumnValue GetVerifiedValue()
	{
		return this.GetValue(TableUtils.VerifiedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.Verified field.
	/// </summary>
	public bool GetVerifiedFieldValue()
	{
		return this.GetValue(TableUtils.VerifiedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Verified field.
	/// </summary>
	public void SetVerifiedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VerifiedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Verified field.
	/// </summary>
	public void SetVerifiedFieldValue(string val)
	{
		this.SetString(val, TableUtils.VerifiedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Verified field.
	/// </summary>
	public void SetVerifiedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VerifiedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.OnFile field.
	/// </summary>
	public ColumnValue GetOnFileValue()
	{
		return this.GetValue(TableUtils.OnFileColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.OnFile field.
	/// </summary>
	public bool GetOnFileFieldValue()
	{
		return this.GetValue(TableUtils.OnFileColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.OnFile field.
	/// </summary>
	public void SetOnFileFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnFileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.OnFile field.
	/// </summary>
	public void SetOnFileFieldValue(string val)
	{
		this.SetString(val, TableUtils.OnFileColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.OnFile field.
	/// </summary>
	public void SetOnFileFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnFileColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.CheckedOk field.
	/// </summary>
	public ColumnValue GetCheckedOkValue()
	{
		return this.GetValue(TableUtils.CheckedOkColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's InvoiceSummaries_.CheckedOk field.
	/// </summary>
	public bool GetCheckedOkFieldValue()
	{
		return this.GetValue(TableUtils.CheckedOkColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.CheckedOk field.
	/// </summary>
	public void SetCheckedOkFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CheckedOkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.CheckedOk field.
	/// </summary>
	public void SetCheckedOkFieldValue(string val)
	{
		this.SetString(val, TableUtils.CheckedOkColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.CheckedOk field.
	/// </summary>
	public void SetCheckedOkFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CheckedOkColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.InvoiceSummaryId field.
	/// </summary>
	public Int32 InvoiceSummaryId
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceSummaryIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceSummaryIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceSummaryIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceSummaryIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceSummaryId field.
	/// </summary>
	public string InvoiceSummaryIdDefault
	{
		get
		{
			return TableUtils.InvoiceSummaryIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public Int32 InvoiceId
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceId field.
	/// </summary>
	public string InvoiceIdDefault
	{
		get
		{
			return TableUtils.InvoiceIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.InvoiceDate field.
	/// </summary>
	public DateTime InvoiceDate
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDate field.
	/// </summary>
	public string InvoiceDateDefault
	{
		get
		{
			return TableUtils.InvoiceDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.InvoiceNumber field.
	/// </summary>
	public string InvoiceNumber
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceNumber field.
	/// </summary>
	public string InvoiceNumberDefault
	{
		get
		{
			return TableUtils.InvoiceNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public Decimal GstTotal
	{
		get
		{
			return this.GetValue(TableUtils.GstTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GstTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GstTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GstTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GstTotal field.
	/// </summary>
	public string GstTotalDefault
	{
		get
		{
			return TableUtils.GstTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public Decimal InvoiceTotal
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceTotal field.
	/// </summary>
	public string InvoiceTotalDefault
	{
		get
		{
			return TableUtils.InvoiceTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.AccountNumber field.
	/// </summary>
	public string AccountNumber
	{
		get
		{
			return this.GetValue(TableUtils.AccountNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AccountNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AccountNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AccountNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.AccountNumber field.
	/// </summary>
	public string AccountNumberDefault
	{
		get
		{
			return TableUtils.AccountNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.CustomerNumber field.
	/// </summary>
	public string CustomerNumber
	{
		get
		{
			return this.GetValue(TableUtils.CustomerNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustomerNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustomerNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustomerNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.CustomerNumber field.
	/// </summary>
	public string CustomerNumberDefault
	{
		get
		{
			return TableUtils.CustomerNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public Int32 SiteId
	{
		get
		{
			return this.GetValue(TableUtils.SiteIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SiteIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SiteIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SiteIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteId field.
	/// </summary>
	public string SiteIdDefault
	{
		get
		{
			return TableUtils.SiteIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public Decimal NetworkChargesTotal
	{
		get
		{
			return this.GetValue(TableUtils.NetworkChargesTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkChargesTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkChargesTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkChargesTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.NetworkChargesTotal field.
	/// </summary>
	public string NetworkChargesTotalDefault
	{
		get
		{
			return TableUtils.NetworkChargesTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public Decimal EnergyChargesTotal
	{
		get
		{
			return this.GetValue(TableUtils.EnergyChargesTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EnergyChargesTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EnergyChargesTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EnergyChargesTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyChargesTotal field.
	/// </summary>
	public string EnergyChargesTotalDefault
	{
		get
		{
			return TableUtils.EnergyChargesTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public Decimal MiscChargesTotal
	{
		get
		{
			return this.GetValue(TableUtils.MiscChargesTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MiscChargesTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MiscChargesTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MiscChargesTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.MiscChargesTotal field.
	/// </summary>
	public string MiscChargesTotalDefault
	{
		get
		{
			return TableUtils.MiscChargesTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public Decimal TotalCharges
	{
		get
		{
			return this.GetValue(TableUtils.TotalChargesColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TotalChargesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TotalChargesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TotalChargesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalCharges field.
	/// </summary>
	public string TotalChargesDefault
	{
		get
		{
			return TableUtils.TotalChargesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public Decimal GSTCharges
	{
		get
		{
			return this.GetValue(TableUtils.GSTChargesColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GSTChargesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GSTChargesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GSTChargesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.GSTCharges field.
	/// </summary>
	public string GSTChargesDefault
	{
		get
		{
			return TableUtils.GSTChargesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public Decimal TotalNetworkCharges
	{
		get
		{
			return this.GetValue(TableUtils.TotalNetworkChargesColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TotalNetworkChargesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TotalNetworkChargesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TotalNetworkChargesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalNetworkCharges field.
	/// </summary>
	public string TotalNetworkChargesDefault
	{
		get
		{
			return TableUtils.TotalNetworkChargesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public Decimal TotalMiscCharges
	{
		get
		{
			return this.GetValue(TableUtils.TotalMiscChargesColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TotalMiscChargesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TotalMiscChargesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TotalMiscChargesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalMiscCharges field.
	/// </summary>
	public string TotalMiscChargesDefault
	{
		get
		{
			return TableUtils.TotalMiscChargesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public Decimal TotalEnergyCharges
	{
		get
		{
			return this.GetValue(TableUtils.TotalEnergyChargesColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TotalEnergyChargesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TotalEnergyChargesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TotalEnergyChargesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.TotalEnergyCharges field.
	/// </summary>
	public string TotalEnergyChargesDefault
	{
		get
		{
			return TableUtils.TotalEnergyChargesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.ConnectionNumber field.
	/// </summary>
	public string ConnectionNumber
	{
		get
		{
			return this.GetValue(TableUtils.ConnectionNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ConnectionNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ConnectionNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ConnectionNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ConnectionNumber field.
	/// </summary>
	public string ConnectionNumberDefault
	{
		get
		{
			return TableUtils.ConnectionNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.SiteName field.
	/// </summary>
	public string SiteName
	{
		get
		{
			return this.GetValue(TableUtils.SiteNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SiteNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SiteNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SiteNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SiteName field.
	/// </summary>
	public string SiteNameDefault
	{
		get
		{
			return TableUtils.SiteNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.InvoiceDueDate field.
	/// </summary>
	public DateTime InvoiceDueDate
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceDueDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceDueDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceDueDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceDueDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.InvoiceDueDate field.
	/// </summary>
	public string InvoiceDueDateDefault
	{
		get
		{
			return TableUtils.InvoiceDueDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.Month field.
	/// </summary>
	public string Month
	{
		get
		{
			return this.GetValue(TableUtils.MonthColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MonthColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MonthSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MonthColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Month field.
	/// </summary>
	public string MonthDefault
	{
		get
		{
			return TableUtils.MonthColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.Year field.
	/// </summary>
	public string Year
	{
		get
		{
			return this.GetValue(TableUtils.YearColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YearColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YearSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YearColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Year field.
	/// </summary>
	public string YearDefault
	{
		get
		{
			return TableUtils.YearColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.Approved field.
	/// </summary>
	public bool Approved
	{
		get
		{
			return this.GetValue(TableUtils.ApprovedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ApprovedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ApprovedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ApprovedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Approved field.
	/// </summary>
	public string ApprovedDefault
	{
		get
		{
			return TableUtils.ApprovedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.ApprovedById field.
	/// </summary>
	public string ApprovedById
	{
		get
		{
			return this.GetValue(TableUtils.ApprovedByIdColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ApprovedByIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ApprovedByIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ApprovedByIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ApprovedById field.
	/// </summary>
	public string ApprovedByIdDefault
	{
		get
		{
			return TableUtils.ApprovedByIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.ApprovedDate field.
	/// </summary>
	public DateTime ApprovedDate
	{
		get
		{
			return this.GetValue(TableUtils.ApprovedDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ApprovedDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ApprovedDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ApprovedDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.ApprovedDate field.
	/// </summary>
	public string ApprovedDateDefault
	{
		get
		{
			return TableUtils.ApprovedDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public Decimal PercentageChange
	{
		get
		{
			return this.GetValue(TableUtils.PercentageChangeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PercentageChangeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PercentageChangeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PercentageChangeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PercentageChange field.
	/// </summary>
	public string PercentageChangeDefault
	{
		get
		{
			return TableUtils.PercentageChangeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.PeriodStart field.
	/// </summary>
	public DateTime PeriodStart
	{
		get
		{
			return this.GetValue(TableUtils.PeriodStartColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PeriodStartColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PeriodStartSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PeriodStartColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodStart field.
	/// </summary>
	public string PeriodStartDefault
	{
		get
		{
			return TableUtils.PeriodStartColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.PeriodEnd field.
	/// </summary>
	public DateTime PeriodEnd
	{
		get
		{
			return this.GetValue(TableUtils.PeriodEndColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PeriodEndColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PeriodEndSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PeriodEndColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.PeriodEnd field.
	/// </summary>
	public string PeriodEndDefault
	{
		get
		{
			return TableUtils.PeriodEndColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public Int32 EnergyPointId
	{
		get
		{
			return this.GetValue(TableUtils.EnergyPointIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EnergyPointIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EnergyPointIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EnergyPointIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.EnergyPointId field.
	/// </summary>
	public string EnergyPointIdDefault
	{
		get
		{
			return TableUtils.EnergyPointIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public Int32 SupplierId
	{
		get
		{
			return this.GetValue(TableUtils.SupplierIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SupplierIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SupplierIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SupplierIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.SupplierId field.
	/// </summary>
	public string SupplierIdDefault
	{
		get
		{
			return TableUtils.SupplierIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public Decimal KwhTotal
	{
		get
		{
			return this.GetValue(TableUtils.KwhTotalColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KwhTotalColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KwhTotalSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KwhTotalColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.KwhTotal field.
	/// </summary>
	public string KwhTotalDefault
	{
		get
		{
			return TableUtils.KwhTotalColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.Verified field.
	/// </summary>
	public bool Verified
	{
		get
		{
			return this.GetValue(TableUtils.VerifiedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.VerifiedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VerifiedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VerifiedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.Verified field.
	/// </summary>
	public string VerifiedDefault
	{
		get
		{
			return TableUtils.VerifiedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.OnFile field.
	/// </summary>
	public bool OnFile
	{
		get
		{
			return this.GetValue(TableUtils.OnFileColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.OnFileColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OnFileSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OnFileColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.OnFile field.
	/// </summary>
	public string OnFileDefault
	{
		get
		{
			return TableUtils.OnFileColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's InvoiceSummaries_.CheckedOk field.
	/// </summary>
	public bool CheckedOk
	{
		get
		{
			return this.GetValue(TableUtils.CheckedOkColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.CheckedOkColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CheckedOkSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CheckedOkColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's InvoiceSummaries_.CheckedOk field.
	/// </summary>
	public string CheckedOkDefault
	{
		get
		{
			return TableUtils.CheckedOkColumn.DefaultValue;
		}
	}


#endregion
}

}
