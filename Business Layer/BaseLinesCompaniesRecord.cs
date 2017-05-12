// This class is "generated" and will be overwritten.
// Your customizations should be made in LinesCompaniesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="LinesCompaniesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LinesCompaniesTable"></see> class.
/// </remarks>
/// <seealso cref="LinesCompaniesTable"></seealso>
/// <seealso cref="LinesCompaniesRecord"></seealso>
public class BaseLinesCompaniesRecord : PrimaryKeyRecord
{

	public readonly static LinesCompaniesTable TableUtils = LinesCompaniesTable.Instance;

	// Constructors
 
	protected BaseLinesCompaniesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LinesCompaniesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LinesCompaniesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LinesCompaniesRecord_ReadRecord); 
	}

	protected BaseLinesCompaniesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LinesCompaniesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LinesCompaniesRecord LinesCompaniesRec = (LinesCompaniesRecord)sender;
        if(LinesCompaniesRec != null && !LinesCompaniesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LinesCompaniesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LinesCompaniesRecord LinesCompaniesRec = (LinesCompaniesRecord)sender;
        Validate_Inserting();
        if(LinesCompaniesRec != null && !LinesCompaniesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LinesCompaniesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LinesCompaniesRecord LinesCompaniesRec = (LinesCompaniesRecord)sender;
        Validate_Updating();
        if(LinesCompaniesRec != null && !LinesCompaniesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.LinesId field.
	/// </summary>
	public ColumnValue GetLinesIdValue()
	{
		return this.GetValue(TableUtils.LinesIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.LinesId field.
	/// </summary>
	public Int32 GetLinesIdFieldValue()
	{
		return this.GetValue(TableUtils.LinesIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.LinesCompanyName field.
	/// </summary>
	public ColumnValue GetLinesCompanyNameValue()
	{
		return this.GetValue(TableUtils.LinesCompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.LinesCompanyName field.
	/// </summary>
	public string GetLinesCompanyNameFieldValue()
	{
		return this.GetValue(TableUtils.LinesCompanyNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.LinesCompanyName field.
	/// </summary>
	public void SetLinesCompanyNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LinesCompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.LinesCompanyName field.
	/// </summary>
	public void SetLinesCompanyNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinesCompanyNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.LinesCompanyLogo field.
	/// </summary>
	public ColumnValue GetLinesCompanyLogoValue()
	{
		return this.GetValue(TableUtils.LinesCompanyLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.LinesCompanyLogo field.
	/// </summary>
	public string GetLinesCompanyLogoFieldValue()
	{
		return this.GetValue(TableUtils.LinesCompanyLogoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.LinesCompanyLogo field.
	/// </summary>
	public void SetLinesCompanyLogoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LinesCompanyLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.LinesCompanyLogo field.
	/// </summary>
	public void SetLinesCompanyLogoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinesCompanyLogoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.City field.
	/// </summary>
	public ColumnValue GetCityValue()
	{
		return this.GetValue(TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.City field.
	/// </summary>
	public string GetCityFieldValue()
	{
		return this.GetValue(TableUtils.CityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.City field.
	/// </summary>
	public void SetCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.City field.
	/// </summary>
	public void SetCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Phone field.
	/// </summary>
	public ColumnValue GetPhoneValue()
	{
		return this.GetValue(TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Phone field.
	/// </summary>
	public string GetPhoneFieldValue()
	{
		return this.GetValue(TableUtils.PhoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Contact field.
	/// </summary>
	public ColumnValue GetContactValue()
	{
		return this.GetValue(TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Contact field.
	/// </summary>
	public string GetContactFieldValue()
	{
		return this.GetValue(TableUtils.ContactColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Contact field.
	/// </summary>
	public void SetContactFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Contact field.
	/// </summary>
	public void SetContactFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Enabled field.
	/// </summary>
	public ColumnValue GetEnabled0Value()
	{
		return this.GetValue(TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinesCompanies_.Enabled field.
	/// </summary>
	public bool GetEnabled0FieldValue()
	{
		return this.GetValue(TableUtils.Enabled0Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Enabled0Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.LinesId field.
	/// </summary>
	public Int32 LinesId
	{
		get
		{
			return this.GetValue(TableUtils.LinesIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinesIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinesIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinesIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.LinesId field.
	/// </summary>
	public string LinesIdDefault
	{
		get
		{
			return TableUtils.LinesIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.LinesCompanyName field.
	/// </summary>
	public string LinesCompanyName
	{
		get
		{
			return this.GetValue(TableUtils.LinesCompanyNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinesCompanyNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinesCompanyNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinesCompanyNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.LinesCompanyName field.
	/// </summary>
	public string LinesCompanyNameDefault
	{
		get
		{
			return TableUtils.LinesCompanyNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.LinesCompanyLogo field.
	/// </summary>
	public string LinesCompanyLogo
	{
		get
		{
			return this.GetValue(TableUtils.LinesCompanyLogoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinesCompanyLogoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinesCompanyLogoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinesCompanyLogoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.LinesCompanyLogo field.
	/// </summary>
	public string LinesCompanyLogoDefault
	{
		get
		{
			return TableUtils.LinesCompanyLogoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.City field.
	/// </summary>
	public string City
	{
		get
		{
			return this.GetValue(TableUtils.CityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.City field.
	/// </summary>
	public string CityDefault
	{
		get
		{
			return TableUtils.CityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.Phone field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Phone field.
	/// </summary>
	public string PhoneDefault
	{
		get
		{
			return TableUtils.PhoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.Contact field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Contact field.
	/// </summary>
	public string ContactDefault
	{
		get
		{
			return TableUtils.ContactColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.eMail field.
	/// </summary>
	public string eMail
	{
		get
		{
			return this.GetValue(TableUtils.eMailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.eMailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool eMailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.eMailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinesCompanies_.Enabled field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinesCompanies_.Enabled field.
	/// </summary>
	public string Enabled0Default
	{
		get
		{
			return TableUtils.Enabled0Column.DefaultValue;
		}
	}


#endregion
}

}
