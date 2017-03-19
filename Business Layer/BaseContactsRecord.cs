// This class is "generated" and will be overwritten.
// Your customizations should be made in ContactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="ContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ContactsTable"></see> class.
/// </remarks>
/// <seealso cref="ContactsTable"></seealso>
/// <seealso cref="ContactsRecord"></seealso>
public class BaseContactsRecord : PrimaryKeyRecord
{

	public readonly static ContactsTable TableUtils = ContactsTable.Instance;

	// Constructors
 
	protected BaseContactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ContactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ContactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ContactsRecord_ReadRecord); 
	}

	protected BaseContactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        Validate_Inserting();
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ContactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        Validate_Updating();
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.ContactId field.
	/// </summary>
	public ColumnValue GetContactIdValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.ContactId field.
	/// </summary>
	public Int32 GetContactIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.MiddleName field.
	/// </summary>
	public ColumnValue GetMiddleNameValue()
	{
		return this.GetValue(TableUtils.MiddleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.MiddleName field.
	/// </summary>
	public string GetMiddleNameFieldValue()
	{
		return this.GetValue(TableUtils.MiddleNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MiddleName field.
	/// </summary>
	public void SetMiddleNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MiddleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MiddleName field.
	/// </summary>
	public void SetMiddleNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MiddleNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Salutation field.
	/// </summary>
	public ColumnValue GetSalutationValue()
	{
		return this.GetValue(TableUtils.SalutationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Salutation field.
	/// </summary>
	public string GetSalutationFieldValue()
	{
		return this.GetValue(TableUtils.SalutationColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Salutation field.
	/// </summary>
	public void SetSalutationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SalutationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Salutation field.
	/// </summary>
	public void SetSalutationFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SalutationColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PreferredName field.
	/// </summary>
	public ColumnValue GetPreferredNameValue()
	{
		return this.GetValue(TableUtils.PreferredNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PreferredName field.
	/// </summary>
	public string GetPreferredNameFieldValue()
	{
		return this.GetValue(TableUtils.PreferredNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PreferredName field.
	/// </summary>
	public void SetPreferredNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PreferredNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PreferredName field.
	/// </summary>
	public void SetPreferredNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PreferredNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public ColumnValue GetPhoneNumberValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public string GetPhoneNumberFieldValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.ContactId field.
	/// </summary>
	public Int32 ContactId
	{
		get
		{
			return this.GetValue(TableUtils.ContactIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.ContactId field.
	/// </summary>
	public string ContactIdDefault
	{
		get
		{
			return TableUtils.ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string FirstName
	{
		get
		{
			return this.GetValue(TableUtils.FirstNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirstNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirstNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirstNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.MiddleName field.
	/// </summary>
	public string MiddleName
	{
		get
		{
			return this.GetValue(TableUtils.MiddleNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MiddleNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MiddleNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MiddleNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.MiddleName field.
	/// </summary>
	public string MiddleNameDefault
	{
		get
		{
			return TableUtils.MiddleNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public string LastName
	{
		get
		{
			return this.GetValue(TableUtils.LastNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LastNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LastNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LastNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Salutation field.
	/// </summary>
	public string Salutation
	{
		get
		{
			return this.GetValue(TableUtils.SalutationColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SalutationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SalutationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SalutationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Salutation field.
	/// </summary>
	public string SalutationDefault
	{
		get
		{
			return TableUtils.SalutationColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.PreferredName field.
	/// </summary>
	public string PreferredName
	{
		get
		{
			return this.GetValue(TableUtils.PreferredNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PreferredNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PreferredNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PreferredNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PreferredName field.
	/// </summary>
	public string PreferredNameDefault
	{
		get
		{
			return TableUtils.PreferredNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public string PhoneNumber
	{
		get
		{
			return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PhoneNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PhoneNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PhoneNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public string PhoneNumberDefault
	{
		get
		{
			return TableUtils.PhoneNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.eMail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}


#endregion
}

}
