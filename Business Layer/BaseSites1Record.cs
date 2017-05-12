// This class is "generated" and will be overwritten.
// Your customizations should be made in Sites1Record.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="Sites1Record"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Sites1Table"></see> class.
/// </remarks>
/// <seealso cref="Sites1Table"></seealso>
/// <seealso cref="Sites1Record"></seealso>
public class BaseSites1Record : PrimaryKeyRecord
{

	public readonly static Sites1Table TableUtils = Sites1Table.Instance;

	// Constructors
 
	protected BaseSites1Record() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Sites1Record_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Sites1Record_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Sites1Record_ReadRecord); 
	}

	protected BaseSites1Record(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Sites1Record_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Sites1Record Sites1Rec = (Sites1Record)sender;
        if(Sites1Rec != null && !Sites1Rec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Sites1Record_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Sites1Record Sites1Rec = (Sites1Record)sender;
        Validate_Inserting();
        if(Sites1Rec != null && !Sites1Rec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Sites1Record_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Sites1Record Sites1Rec = (Sites1Record)sender;
        Validate_Updating();
        if(Sites1Rec != null && !Sites1Rec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteId field.
	/// </summary>
	public ColumnValue GetSiteIdValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteId field.
	/// </summary>
	public Int32 GetSiteIdFieldValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteLogo field.
	/// </summary>
	public ColumnValue GetSiteLogoValue()
	{
		return this.GetValue(TableUtils.SiteLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteLogo field.
	/// </summary>
	public string GetSiteLogoFieldValue()
	{
		return this.GetValue(TableUtils.SiteLogoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteLogo field.
	/// </summary>
	public void SetSiteLogoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiteLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteLogo field.
	/// </summary>
	public void SetSiteLogoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteLogoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteName field.
	/// </summary>
	public ColumnValue GetSiteNameValue()
	{
		return this.GetValue(TableUtils.SiteNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteName field.
	/// </summary>
	public string GetSiteNameFieldValue()
	{
		return this.GetValue(TableUtils.SiteNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteName field.
	/// </summary>
	public void SetSiteNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiteNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteName field.
	/// </summary>
	public void SetSiteNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CityId field.
	/// </summary>
	public ColumnValue GetCityIdValue()
	{
		return this.GetValue(TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CityId field.
	/// </summary>
	public Int32 GetCityIdFieldValue()
	{
		return this.GetValue(TableUtils.CityIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Phone field.
	/// </summary>
	public ColumnValue GetPhoneValue()
	{
		return this.GetValue(TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Phone field.
	/// </summary>
	public string GetPhoneFieldValue()
	{
		return this.GetValue(TableUtils.PhoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Contact field.
	/// </summary>
	public ColumnValue GetContactValue()
	{
		return this.GetValue(TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Contact field.
	/// </summary>
	public string GetContactFieldValue()
	{
		return this.GetValue(TableUtils.ContactColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Contact field.
	/// </summary>
	public void SetContactFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Contact field.
	/// </summary>
	public void SetContactFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Email field.
	/// </summary>
	public ColumnValue GetEmailValue()
	{
		return this.GetValue(TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Email field.
	/// </summary>
	public string GetEmailFieldValue()
	{
		return this.GetValue(TableUtils.EmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Email field.
	/// </summary>
	public void SetEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Email field.
	/// </summary>
	public void SetEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CustomerId field.
	/// </summary>
	public ColumnValue GetCustomerIdValue()
	{
		return this.GetValue(TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CustomerId field.
	/// </summary>
	public Int32 GetCustomerIdFieldValue()
	{
		return this.GetValue(TableUtils.CustomerIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Enabled field.
	/// </summary>
	public ColumnValue GetEnabled0Value()
	{
		return this.GetValue(TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Enabled field.
	/// </summary>
	public bool GetEnabled0FieldValue()
	{
		return this.GetValue(TableUtils.Enabled0Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Enabled0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoiceApproverName field.
	/// </summary>
	public ColumnValue GetInvoiceApproverNameValue()
	{
		return this.GetValue(TableUtils.InvoiceApproverNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoiceApproverName field.
	/// </summary>
	public string GetInvoiceApproverNameFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceApproverNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoiceApproverName field.
	/// </summary>
	public void SetInvoiceApproverNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoiceApproverNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoiceApproverName field.
	/// </summary>
	public void SetInvoiceApproverNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceApproverNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoiceApproverEmail field.
	/// </summary>
	public ColumnValue GetInvoiceApproverEmailValue()
	{
		return this.GetValue(TableUtils.InvoiceApproverEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoiceApproverEmail field.
	/// </summary>
	public string GetInvoiceApproverEmailFieldValue()
	{
		return this.GetValue(TableUtils.InvoiceApproverEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoiceApproverEmail field.
	/// </summary>
	public void SetInvoiceApproverEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoiceApproverEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoiceApproverEmail field.
	/// </summary>
	public void SetInvoiceApproverEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoiceApproverEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoicePayerName field.
	/// </summary>
	public ColumnValue GetInvoicePayerNameValue()
	{
		return this.GetValue(TableUtils.InvoicePayerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoicePayerName field.
	/// </summary>
	public string GetInvoicePayerNameFieldValue()
	{
		return this.GetValue(TableUtils.InvoicePayerNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoicePayerName field.
	/// </summary>
	public void SetInvoicePayerNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoicePayerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoicePayerName field.
	/// </summary>
	public void SetInvoicePayerNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoicePayerNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoicePayerEmail field.
	/// </summary>
	public ColumnValue GetInvoicePayerEmailValue()
	{
		return this.GetValue(TableUtils.InvoicePayerEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.InvoicePayerEmail field.
	/// </summary>
	public string GetInvoicePayerEmailFieldValue()
	{
		return this.GetValue(TableUtils.InvoicePayerEmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoicePayerEmail field.
	/// </summary>
	public void SetInvoicePayerEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.InvoicePayerEmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoicePayerEmail field.
	/// </summary>
	public void SetInvoicePayerEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.InvoicePayerEmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.IndustryId field.
	/// </summary>
	public ColumnValue GetIndustryIdValue()
	{
		return this.GetValue(TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.IndustryId field.
	/// </summary>
	public Int32 GetIndustryIdFieldValue()
	{
		return this.GetValue(TableUtils.IndustryIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IndustryIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public ColumnValue GetLandSqMetersValue()
	{
		return this.GetValue(TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public Int32 GetLandSqMetersFieldValue()
	{
		return this.GetValue(TableUtils.LandSqMetersColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(string val)
	{
		this.SetString(val, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LandSqMetersColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public ColumnValue GetTotalFloorSpaceSqMetersValue()
	{
		return this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public Int32 GetTotalFloorSpaceSqMetersFieldValue()
	{
		return this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(string val)
	{
		this.SetString(val, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public ColumnValue GetProductiveFloorSpaceSqMetersValue()
	{
		return this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public Int32 GetProductiveFloorSpaceSqMetersFieldValue()
	{
		return this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.BusinessDayStartTime field.
	/// </summary>
	public ColumnValue GetBusinessDayStartTimeValue()
	{
		return this.GetValue(TableUtils.BusinessDayStartTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.BusinessDayStartTime field.
	/// </summary>
	public DateTime GetBusinessDayStartTimeFieldValue()
	{
		return this.GetValue(TableUtils.BusinessDayStartTimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayStartTime field.
	/// </summary>
	public void SetBusinessDayStartTimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BusinessDayStartTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayStartTime field.
	/// </summary>
	public void SetBusinessDayStartTimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.BusinessDayStartTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayStartTime field.
	/// </summary>
	public void SetBusinessDayStartTimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BusinessDayStartTimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.BusinessDayEndTime field.
	/// </summary>
	public ColumnValue GetBusinessDayEndTimeValue()
	{
		return this.GetValue(TableUtils.BusinessDayEndTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.BusinessDayEndTime field.
	/// </summary>
	public DateTime GetBusinessDayEndTimeFieldValue()
	{
		return this.GetValue(TableUtils.BusinessDayEndTimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayEndTime field.
	/// </summary>
	public void SetBusinessDayEndTimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BusinessDayEndTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayEndTime field.
	/// </summary>
	public void SetBusinessDayEndTimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.BusinessDayEndTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayEndTime field.
	/// </summary>
	public void SetBusinessDayEndTimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BusinessDayEndTimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.NonBusinessDayStartTime field.
	/// </summary>
	public ColumnValue GetNonBusinessDayStartTimeValue()
	{
		return this.GetValue(TableUtils.NonBusinessDayStartTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.NonBusinessDayStartTime field.
	/// </summary>
	public DateTime GetNonBusinessDayStartTimeFieldValue()
	{
		return this.GetValue(TableUtils.NonBusinessDayStartTimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayStartTime field.
	/// </summary>
	public void SetNonBusinessDayStartTimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NonBusinessDayStartTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayStartTime field.
	/// </summary>
	public void SetNonBusinessDayStartTimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.NonBusinessDayStartTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayStartTime field.
	/// </summary>
	public void SetNonBusinessDayStartTimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NonBusinessDayStartTimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.NonBusinessDayEndTime field.
	/// </summary>
	public ColumnValue GetNonBusinessDayEndTimeValue()
	{
		return this.GetValue(TableUtils.NonBusinessDayEndTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.NonBusinessDayEndTime field.
	/// </summary>
	public DateTime GetNonBusinessDayEndTimeFieldValue()
	{
		return this.GetValue(TableUtils.NonBusinessDayEndTimeColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayEndTime field.
	/// </summary>
	public void SetNonBusinessDayEndTimeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NonBusinessDayEndTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayEndTime field.
	/// </summary>
	public void SetNonBusinessDayEndTimeFieldValue(string val)
	{
		this.SetString(val, TableUtils.NonBusinessDayEndTimeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayEndTime field.
	/// </summary>
	public void SetNonBusinessDayEndTimeFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NonBusinessDayEndTimeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public ColumnValue GetSiteCategoryIdValue()
	{
		return this.GetValue(TableUtils.SiteCategoryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public Int32 GetSiteCategoryIdFieldValue()
	{
		return this.GetValue(TableUtils.SiteCategoryIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public void SetSiteCategoryIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiteCategoryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public void SetSiteCategoryIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.SiteCategoryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public void SetSiteCategoryIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteCategoryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public void SetSiteCategoryIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteCategoryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public void SetSiteCategoryIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteCategoryIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public ColumnValue GetCustomerDivisionIdValue()
	{
		return this.GetValue(TableUtils.CustomerDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public Int32 GetCustomerDivisionIdFieldValue()
	{
		return this.GetValue(TableUtils.CustomerDivisionIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public void SetCustomerDivisionIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustomerDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public void SetCustomerDivisionIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustomerDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public void SetCustomerDivisionIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public void SetCustomerDivisionIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public void SetCustomerDivisionIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerDivisionIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public ColumnValue GetGroupDivisionIdValue()
	{
		return this.GetValue(TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public Int32 GetGroupDivisionIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupDivisionIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.RegionId field.
	/// </summary>
	public ColumnValue GetRegionIdValue()
	{
		return this.GetValue(TableUtils.RegionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.RegionId field.
	/// </summary>
	public Int32 GetRegionIdFieldValue()
	{
		return this.GetValue(TableUtils.RegionIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.RegionId field.
	/// </summary>
	public void SetRegionIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.RegionId field.
	/// </summary>
	public void SetRegionIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.RegionId field.
	/// </summary>
	public void SetRegionIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.RegionId field.
	/// </summary>
	public void SetRegionIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.RegionId field.
	/// </summary>
	public void SetRegionIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.JoinedGroupDate field.
	/// </summary>
	public ColumnValue GetJoinedGroupDateValue()
	{
		return this.GetValue(TableUtils.JoinedGroupDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.JoinedGroupDate field.
	/// </summary>
	public DateTime GetJoinedGroupDateFieldValue()
	{
		return this.GetValue(TableUtils.JoinedGroupDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.JoinedGroupDate field.
	/// </summary>
	public void SetJoinedGroupDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.JoinedGroupDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.JoinedGroupDate field.
	/// </summary>
	public void SetJoinedGroupDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.JoinedGroupDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.JoinedGroupDate field.
	/// </summary>
	public void SetJoinedGroupDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.JoinedGroupDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ParticipationStartDate field.
	/// </summary>
	public ColumnValue GetParticipationStartDateValue()
	{
		return this.GetValue(TableUtils.ParticipationStartDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ParticipationStartDate field.
	/// </summary>
	public DateTime GetParticipationStartDateFieldValue()
	{
		return this.GetValue(TableUtils.ParticipationStartDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationStartDate field.
	/// </summary>
	public void SetParticipationStartDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ParticipationStartDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationStartDate field.
	/// </summary>
	public void SetParticipationStartDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ParticipationStartDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationStartDate field.
	/// </summary>
	public void SetParticipationStartDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParticipationStartDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ParticipationEndDate field.
	/// </summary>
	public ColumnValue GetParticipationEndDateValue()
	{
		return this.GetValue(TableUtils.ParticipationEndDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ParticipationEndDate field.
	/// </summary>
	public DateTime GetParticipationEndDateFieldValue()
	{
		return this.GetValue(TableUtils.ParticipationEndDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationEndDate field.
	/// </summary>
	public void SetParticipationEndDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ParticipationEndDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationEndDate field.
	/// </summary>
	public void SetParticipationEndDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ParticipationEndDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationEndDate field.
	/// </summary>
	public void SetParticipationEndDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParticipationEndDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public ColumnValue GetParticipationRateValue()
	{
		return this.GetValue(TableUtils.ParticipationRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public Decimal GetParticipationRateFieldValue()
	{
		return this.GetValue(TableUtils.ParticipationRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public void SetParticipationRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ParticipationRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public void SetParticipationRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ParticipationRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public void SetParticipationRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParticipationRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public void SetParticipationRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParticipationRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public void SetParticipationRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParticipationRateColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.SiteId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteId field.
	/// </summary>
	public string SiteIdDefault
	{
		get
		{
			return TableUtils.SiteIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.SiteLogo field.
	/// </summary>
	public string SiteLogo
	{
		get
		{
			return this.GetValue(TableUtils.SiteLogoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SiteLogoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SiteLogoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SiteLogoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteLogo field.
	/// </summary>
	public string SiteLogoDefault
	{
		get
		{
			return TableUtils.SiteLogoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.SiteName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteName field.
	/// </summary>
	public string SiteNameDefault
	{
		get
		{
			return TableUtils.SiteNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Address1 field.
	/// </summary>
	public string Address1
	{
		get
		{
			return this.GetValue(TableUtils.Address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Address2 field.
	/// </summary>
	public string Address2
	{
		get
		{
			return this.GetValue(TableUtils.Address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Address3 field.
	/// </summary>
	public string Address3
	{
		get
		{
			return this.GetValue(TableUtils.Address3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.CityId field.
	/// </summary>
	public Int32 CityId
	{
		get
		{
			return this.GetValue(TableUtils.CityIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CityIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CityIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CityIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CityId field.
	/// </summary>
	public string CityIdDefault
	{
		get
		{
			return TableUtils.CityIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.PostCode field.
	/// </summary>
	public string PostCode
	{
		get
		{
			return this.GetValue(TableUtils.PostCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PostCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PostCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PostCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Phone field.
	/// </summary>
	public string Phone
	{
		get
		{
			return this.GetValue(TableUtils.PhoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PhoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PhoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PhoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Phone field.
	/// </summary>
	public string PhoneDefault
	{
		get
		{
			return TableUtils.PhoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Contact field.
	/// </summary>
	public string Contact
	{
		get
		{
			return this.GetValue(TableUtils.ContactColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Contact field.
	/// </summary>
	public string ContactDefault
	{
		get
		{
			return TableUtils.ContactColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Email field.
	/// </summary>
	public string Email
	{
		get
		{
			return this.GetValue(TableUtils.EmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Email field.
	/// </summary>
	public string EmailDefault
	{
		get
		{
			return TableUtils.EmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.CustomerId field.
	/// </summary>
	public Int32 CustomerId
	{
		get
		{
			return this.GetValue(TableUtils.CustomerIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustomerIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustomerIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustomerIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public string CustomerIdDefault
	{
		get
		{
			return TableUtils.CustomerIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.GroupId field.
	/// </summary>
	public Int32 GroupId
	{
		get
		{
			return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GroupIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GroupIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GroupIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Enabled field.
	/// </summary>
	public bool Enabled0
	{
		get
		{
			return this.GetValue(TableUtils.Enabled0Column).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.Enabled0Column);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Enabled0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Enabled0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Enabled field.
	/// </summary>
	public string Enabled0Default
	{
		get
		{
			return TableUtils.Enabled0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.InvoiceApproverName field.
	/// </summary>
	public string InvoiceApproverName
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceApproverNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceApproverNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceApproverNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceApproverNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoiceApproverName field.
	/// </summary>
	public string InvoiceApproverNameDefault
	{
		get
		{
			return TableUtils.InvoiceApproverNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.InvoiceApproverEmail field.
	/// </summary>
	public string InvoiceApproverEmail
	{
		get
		{
			return this.GetValue(TableUtils.InvoiceApproverEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoiceApproverEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoiceApproverEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoiceApproverEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoiceApproverEmail field.
	/// </summary>
	public string InvoiceApproverEmailDefault
	{
		get
		{
			return TableUtils.InvoiceApproverEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.InvoicePayerName field.
	/// </summary>
	public string InvoicePayerName
	{
		get
		{
			return this.GetValue(TableUtils.InvoicePayerNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoicePayerNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoicePayerNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoicePayerNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoicePayerName field.
	/// </summary>
	public string InvoicePayerNameDefault
	{
		get
		{
			return TableUtils.InvoicePayerNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.InvoicePayerEmail field.
	/// </summary>
	public string InvoicePayerEmail
	{
		get
		{
			return this.GetValue(TableUtils.InvoicePayerEmailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.InvoicePayerEmailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool InvoicePayerEmailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.InvoicePayerEmailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.InvoicePayerEmail field.
	/// </summary>
	public string InvoicePayerEmailDefault
	{
		get
		{
			return TableUtils.InvoicePayerEmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.IndustryId field.
	/// </summary>
	public Int32 IndustryId
	{
		get
		{
			return this.GetValue(TableUtils.IndustryIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IndustryIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IndustryIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IndustryIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public string IndustryIdDefault
	{
		get
		{
			return TableUtils.IndustryIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public Int32 LandSqMeters
	{
		get
		{
			return this.GetValue(TableUtils.LandSqMetersColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LandSqMetersColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LandSqMetersSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LandSqMetersColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public string LandSqMetersDefault
	{
		get
		{
			return TableUtils.LandSqMetersColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public Int32 TotalFloorSpaceSqMeters
	{
		get
		{
			return this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TotalFloorSpaceSqMetersSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public string TotalFloorSpaceSqMetersDefault
	{
		get
		{
			return TableUtils.TotalFloorSpaceSqMetersColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public Int32 ProductiveFloorSpaceSqMeters
	{
		get
		{
			return this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProductiveFloorSpaceSqMetersSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public string ProductiveFloorSpaceSqMetersDefault
	{
		get
		{
			return TableUtils.ProductiveFloorSpaceSqMetersColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.BusinessDayStartTime field.
	/// </summary>
	public DateTime BusinessDayStartTime
	{
		get
		{
			return this.GetValue(TableUtils.BusinessDayStartTimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BusinessDayStartTimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BusinessDayStartTimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BusinessDayStartTimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayStartTime field.
	/// </summary>
	public string BusinessDayStartTimeDefault
	{
		get
		{
			return TableUtils.BusinessDayStartTimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.BusinessDayEndTime field.
	/// </summary>
	public DateTime BusinessDayEndTime
	{
		get
		{
			return this.GetValue(TableUtils.BusinessDayEndTimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BusinessDayEndTimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BusinessDayEndTimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BusinessDayEndTimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.BusinessDayEndTime field.
	/// </summary>
	public string BusinessDayEndTimeDefault
	{
		get
		{
			return TableUtils.BusinessDayEndTimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.NonBusinessDayStartTime field.
	/// </summary>
	public DateTime NonBusinessDayStartTime
	{
		get
		{
			return this.GetValue(TableUtils.NonBusinessDayStartTimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NonBusinessDayStartTimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NonBusinessDayStartTimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NonBusinessDayStartTimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayStartTime field.
	/// </summary>
	public string NonBusinessDayStartTimeDefault
	{
		get
		{
			return TableUtils.NonBusinessDayStartTimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.NonBusinessDayEndTime field.
	/// </summary>
	public DateTime NonBusinessDayEndTime
	{
		get
		{
			return this.GetValue(TableUtils.NonBusinessDayEndTimeColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NonBusinessDayEndTimeColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NonBusinessDayEndTimeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NonBusinessDayEndTimeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.NonBusinessDayEndTime field.
	/// </summary>
	public string NonBusinessDayEndTimeDefault
	{
		get
		{
			return TableUtils.NonBusinessDayEndTimeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public Int32 SiteCategoryId
	{
		get
		{
			return this.GetValue(TableUtils.SiteCategoryIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SiteCategoryIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SiteCategoryIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SiteCategoryIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteCategoryId field.
	/// </summary>
	public string SiteCategoryIdDefault
	{
		get
		{
			return TableUtils.SiteCategoryIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public Int32 CustomerDivisionId
	{
		get
		{
			return this.GetValue(TableUtils.CustomerDivisionIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustomerDivisionIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustomerDivisionIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustomerDivisionIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerDivisionId field.
	/// </summary>
	public string CustomerDivisionIdDefault
	{
		get
		{
			return TableUtils.CustomerDivisionIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public Int32 GroupDivisionId
	{
		get
		{
			return this.GetValue(TableUtils.GroupDivisionIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GroupDivisionIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GroupDivisionIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public string GroupDivisionIdDefault
	{
		get
		{
			return TableUtils.GroupDivisionIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.RegionId field.
	/// </summary>
	public Int32 RegionId
	{
		get
		{
			return this.GetValue(TableUtils.RegionIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegionIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegionIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegionIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.RegionId field.
	/// </summary>
	public string RegionIdDefault
	{
		get
		{
			return TableUtils.RegionIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.JoinedGroupDate field.
	/// </summary>
	public DateTime JoinedGroupDate
	{
		get
		{
			return this.GetValue(TableUtils.JoinedGroupDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.JoinedGroupDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool JoinedGroupDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.JoinedGroupDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.JoinedGroupDate field.
	/// </summary>
	public string JoinedGroupDateDefault
	{
		get
		{
			return TableUtils.JoinedGroupDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.ParticipationStartDate field.
	/// </summary>
	public DateTime ParticipationStartDate
	{
		get
		{
			return this.GetValue(TableUtils.ParticipationStartDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ParticipationStartDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ParticipationStartDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ParticipationStartDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationStartDate field.
	/// </summary>
	public string ParticipationStartDateDefault
	{
		get
		{
			return TableUtils.ParticipationStartDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.ParticipationEndDate field.
	/// </summary>
	public DateTime ParticipationEndDate
	{
		get
		{
			return this.GetValue(TableUtils.ParticipationEndDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ParticipationEndDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ParticipationEndDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ParticipationEndDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationEndDate field.
	/// </summary>
	public string ParticipationEndDateDefault
	{
		get
		{
			return TableUtils.ParticipationEndDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public Decimal ParticipationRate
	{
		get
		{
			return this.GetValue(TableUtils.ParticipationRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ParticipationRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ParticipationRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ParticipationRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ParticipationRate field.
	/// </summary>
	public string ParticipationRateDefault
	{
		get
		{
			return TableUtils.ParticipationRateColumn.DefaultValue;
		}
	}


#endregion
}

}
