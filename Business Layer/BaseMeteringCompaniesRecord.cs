// This class is "generated" and will be overwritten.
// Your customizations should be made in MeteringCompaniesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="MeteringCompaniesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MeteringCompaniesTable"></see> class.
/// </remarks>
/// <seealso cref="MeteringCompaniesTable"></seealso>
/// <seealso cref="MeteringCompaniesRecord"></seealso>
public class BaseMeteringCompaniesRecord : PrimaryKeyRecord
{

	public readonly static MeteringCompaniesTable TableUtils = MeteringCompaniesTable.Instance;

	// Constructors
 
	protected BaseMeteringCompaniesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.MeteringCompaniesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.MeteringCompaniesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.MeteringCompaniesRecord_ReadRecord); 
	}

	protected BaseMeteringCompaniesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void MeteringCompaniesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                MeteringCompaniesRecord MeteringCompaniesRec = (MeteringCompaniesRecord)sender;
        if(MeteringCompaniesRec != null && !MeteringCompaniesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void MeteringCompaniesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                MeteringCompaniesRecord MeteringCompaniesRec = (MeteringCompaniesRecord)sender;
        Validate_Inserting();
        if(MeteringCompaniesRec != null && !MeteringCompaniesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void MeteringCompaniesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                MeteringCompaniesRecord MeteringCompaniesRec = (MeteringCompaniesRecord)sender;
        Validate_Updating();
        if(MeteringCompaniesRec != null && !MeteringCompaniesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyId field.
	/// </summary>
	public ColumnValue GetMeteringCompanyIdValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyId field.
	/// </summary>
	public Int32 GetMeteringCompanyIdFieldValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyName field.
	/// </summary>
	public ColumnValue GetMeteringCompanyNameValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyName field.
	/// </summary>
	public string GetMeteringCompanyNameFieldValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.MeteringCompanyName field.
	/// </summary>
	public void SetMeteringCompanyNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeteringCompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.MeteringCompanyName field.
	/// </summary>
	public void SetMeteringCompanyNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeteringCompanyNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyLogo field.
	/// </summary>
	public ColumnValue GetMeteringCompanyLogoValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyLogo field.
	/// </summary>
	public string GetMeteringCompanyLogoFieldValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyLogoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.MeteringCompanyLogo field.
	/// </summary>
	public void SetMeteringCompanyLogoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeteringCompanyLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.MeteringCompanyLogo field.
	/// </summary>
	public void SetMeteringCompanyLogoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeteringCompanyLogoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.City field.
	/// </summary>
	public ColumnValue GetCityValue()
	{
		return this.GetValue(TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.City field.
	/// </summary>
	public string GetCityFieldValue()
	{
		return this.GetValue(TableUtils.CityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.City field.
	/// </summary>
	public void SetCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.City field.
	/// </summary>
	public void SetCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Phone field.
	/// </summary>
	public ColumnValue GetPhoneValue()
	{
		return this.GetValue(TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Phone field.
	/// </summary>
	public string GetPhoneFieldValue()
	{
		return this.GetValue(TableUtils.PhoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Contact field.
	/// </summary>
	public ColumnValue GetContactValue()
	{
		return this.GetValue(TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Contact field.
	/// </summary>
	public string GetContactFieldValue()
	{
		return this.GetValue(TableUtils.ContactColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Contact field.
	/// </summary>
	public void SetContactFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Contact field.
	/// </summary>
	public void SetContactFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Enabled field.
	/// </summary>
	public ColumnValue GetEnabled0Value()
	{
		return this.GetValue(TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeteringCompanies_.Enabled field.
	/// </summary>
	public bool GetEnabled0FieldValue()
	{
		return this.GetValue(TableUtils.Enabled0Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Enabled0Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyId field.
	/// </summary>
	public Int32 MeteringCompanyId
	{
		get
		{
			return this.GetValue(TableUtils.MeteringCompanyIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeteringCompanyIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeteringCompanyIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeteringCompanyIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.MeteringCompanyId field.
	/// </summary>
	public string MeteringCompanyIdDefault
	{
		get
		{
			return TableUtils.MeteringCompanyIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyName field.
	/// </summary>
	public string MeteringCompanyName
	{
		get
		{
			return this.GetValue(TableUtils.MeteringCompanyNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeteringCompanyNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeteringCompanyNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeteringCompanyNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.MeteringCompanyName field.
	/// </summary>
	public string MeteringCompanyNameDefault
	{
		get
		{
			return TableUtils.MeteringCompanyNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.MeteringCompanyLogo field.
	/// </summary>
	public string MeteringCompanyLogo
	{
		get
		{
			return this.GetValue(TableUtils.MeteringCompanyLogoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeteringCompanyLogoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeteringCompanyLogoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeteringCompanyLogoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.MeteringCompanyLogo field.
	/// </summary>
	public string MeteringCompanyLogoDefault
	{
		get
		{
			return TableUtils.MeteringCompanyLogoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.City field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.City field.
	/// </summary>
	public string CityDefault
	{
		get
		{
			return TableUtils.CityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.Phone field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Phone field.
	/// </summary>
	public string PhoneDefault
	{
		get
		{
			return TableUtils.PhoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.Contact field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Contact field.
	/// </summary>
	public string ContactDefault
	{
		get
		{
			return TableUtils.ContactColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.eMail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeteringCompanies_.Enabled field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeteringCompanies_.Enabled field.
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
