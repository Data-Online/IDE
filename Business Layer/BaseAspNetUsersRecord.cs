// This class is "generated" and will be overwritten.
// Your customizations should be made in AspNetUsersRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="AspNetUsersRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AspNetUsersTable"></see> class.
/// </remarks>
/// <seealso cref="AspNetUsersTable"></seealso>
/// <seealso cref="AspNetUsersRecord"></seealso>
public class BaseAspNetUsersRecord : PrimaryKeyRecord
{

	public readonly static AspNetUsersTable TableUtils = AspNetUsersTable.Instance;

	// Constructors
 
	protected BaseAspNetUsersRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AspNetUsersRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AspNetUsersRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AspNetUsersRecord_ReadRecord); 
	}

	protected BaseAspNetUsersRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AspNetUsersRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AspNetUsersRecord AspNetUsersRec = (AspNetUsersRecord)sender;
        if(AspNetUsersRec != null && !AspNetUsersRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AspNetUsersRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AspNetUsersRecord AspNetUsersRec = (AspNetUsersRecord)sender;
        Validate_Inserting();
        if(AspNetUsersRec != null && !AspNetUsersRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AspNetUsersRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AspNetUsersRecord AspNetUsersRec = (AspNetUsersRecord)sender;
        Validate_Updating();
        if(AspNetUsersRec != null && !AspNetUsersRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.Id field.
	/// </summary>
	public ColumnValue GetId0Value()
	{
		return this.GetValue(TableUtils.Id0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.Id field.
	/// </summary>
	public string GetId0FieldValue()
	{
		return this.GetValue(TableUtils.Id0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.Id field.
	/// </summary>
	public void SetId0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Id0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.Id field.
	/// </summary>
	public void SetId0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Id0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.Email field.
	/// </summary>
	public ColumnValue GetEmailValue()
	{
		return this.GetValue(TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.Email field.
	/// </summary>
	public string GetEmailFieldValue()
	{
		return this.GetValue(TableUtils.EmailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.Email field.
	/// </summary>
	public void SetEmailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EmailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.Email field.
	/// </summary>
	public void SetEmailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EmailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.EmailConfirmed field.
	/// </summary>
	public ColumnValue GetEmailConfirmedValue()
	{
		return this.GetValue(TableUtils.EmailConfirmedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.EmailConfirmed field.
	/// </summary>
	public bool GetEmailConfirmedFieldValue()
	{
		return this.GetValue(TableUtils.EmailConfirmedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.EmailConfirmed field.
	/// </summary>
	public void SetEmailConfirmedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EmailConfirmedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.EmailConfirmed field.
	/// </summary>
	public void SetEmailConfirmedFieldValue(string val)
	{
		this.SetString(val, TableUtils.EmailConfirmedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.EmailConfirmed field.
	/// </summary>
	public void SetEmailConfirmedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EmailConfirmedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.PasswordHash field.
	/// </summary>
	public ColumnValue GetPasswordHashValue()
	{
		return this.GetValue(TableUtils.PasswordHashColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.PasswordHash field.
	/// </summary>
	public string GetPasswordHashFieldValue()
	{
		return this.GetValue(TableUtils.PasswordHashColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PasswordHash field.
	/// </summary>
	public void SetPasswordHashFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PasswordHashColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PasswordHash field.
	/// </summary>
	public void SetPasswordHashFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PasswordHashColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.SecurityStamp field.
	/// </summary>
	public ColumnValue GetSecurityStampValue()
	{
		return this.GetValue(TableUtils.SecurityStampColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.SecurityStamp field.
	/// </summary>
	public string GetSecurityStampFieldValue()
	{
		return this.GetValue(TableUtils.SecurityStampColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.SecurityStamp field.
	/// </summary>
	public void SetSecurityStampFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SecurityStampColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.SecurityStamp field.
	/// </summary>
	public void SetSecurityStampFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SecurityStampColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.PhoneNumber field.
	/// </summary>
	public ColumnValue GetPhoneNumberValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.PhoneNumber field.
	/// </summary>
	public string GetPhoneNumberFieldValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.PhoneNumberConfirmed field.
	/// </summary>
	public ColumnValue GetPhoneNumberConfirmedValue()
	{
		return this.GetValue(TableUtils.PhoneNumberConfirmedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.PhoneNumberConfirmed field.
	/// </summary>
	public bool GetPhoneNumberConfirmedFieldValue()
	{
		return this.GetValue(TableUtils.PhoneNumberConfirmedColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PhoneNumberConfirmed field.
	/// </summary>
	public void SetPhoneNumberConfirmedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneNumberConfirmedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PhoneNumberConfirmed field.
	/// </summary>
	public void SetPhoneNumberConfirmedFieldValue(string val)
	{
		this.SetString(val, TableUtils.PhoneNumberConfirmedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PhoneNumberConfirmed field.
	/// </summary>
	public void SetPhoneNumberConfirmedFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneNumberConfirmedColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.TwoFactorEnabled field.
	/// </summary>
	public ColumnValue GetTwoFactorEnabledValue()
	{
		return this.GetValue(TableUtils.TwoFactorEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.TwoFactorEnabled field.
	/// </summary>
	public bool GetTwoFactorEnabledFieldValue()
	{
		return this.GetValue(TableUtils.TwoFactorEnabledColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.TwoFactorEnabled field.
	/// </summary>
	public void SetTwoFactorEnabledFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TwoFactorEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.TwoFactorEnabled field.
	/// </summary>
	public void SetTwoFactorEnabledFieldValue(string val)
	{
		this.SetString(val, TableUtils.TwoFactorEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.TwoFactorEnabled field.
	/// </summary>
	public void SetTwoFactorEnabledFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TwoFactorEnabledColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.LockoutEndDateUtc field.
	/// </summary>
	public ColumnValue GetLockoutEndDateUtcValue()
	{
		return this.GetValue(TableUtils.LockoutEndDateUtcColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.LockoutEndDateUtc field.
	/// </summary>
	public DateTime GetLockoutEndDateUtcFieldValue()
	{
		return this.GetValue(TableUtils.LockoutEndDateUtcColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEndDateUtc field.
	/// </summary>
	public void SetLockoutEndDateUtcFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LockoutEndDateUtcColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEndDateUtc field.
	/// </summary>
	public void SetLockoutEndDateUtcFieldValue(string val)
	{
		this.SetString(val, TableUtils.LockoutEndDateUtcColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEndDateUtc field.
	/// </summary>
	public void SetLockoutEndDateUtcFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LockoutEndDateUtcColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.LockoutEnabled field.
	/// </summary>
	public ColumnValue GetLockoutEnabledValue()
	{
		return this.GetValue(TableUtils.LockoutEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.LockoutEnabled field.
	/// </summary>
	public bool GetLockoutEnabledFieldValue()
	{
		return this.GetValue(TableUtils.LockoutEnabledColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEnabled field.
	/// </summary>
	public void SetLockoutEnabledFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LockoutEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEnabled field.
	/// </summary>
	public void SetLockoutEnabledFieldValue(string val)
	{
		this.SetString(val, TableUtils.LockoutEnabledColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEnabled field.
	/// </summary>
	public void SetLockoutEnabledFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LockoutEnabledColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public ColumnValue GetAccessFailedCountValue()
	{
		return this.GetValue(TableUtils.AccessFailedCountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public Int32 GetAccessFailedCountFieldValue()
	{
		return this.GetValue(TableUtils.AccessFailedCountColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public void SetAccessFailedCountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AccessFailedCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public void SetAccessFailedCountFieldValue(string val)
	{
		this.SetString(val, TableUtils.AccessFailedCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public void SetAccessFailedCountFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccessFailedCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public void SetAccessFailedCountFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccessFailedCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public void SetAccessFailedCountFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AccessFailedCountColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.UserName field.
	/// </summary>
	public ColumnValue GetUserName0Value()
	{
		return this.GetValue(TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.UserName field.
	/// </summary>
	public string GetUserName0FieldValue()
	{
		return this.GetValue(TableUtils.UserName0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.UserName field.
	/// </summary>
	public void SetUserName0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.UserName field.
	/// </summary>
	public void SetUserName0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserName0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.CompanyLogo field.
	/// </summary>
	public ColumnValue GetCompanyLogoValue()
	{
		return this.GetValue(TableUtils.CompanyLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AspNetUsers_.CompanyLogo field.
	/// </summary>
	public string GetCompanyLogoFieldValue()
	{
		return this.GetValue(TableUtils.CompanyLogoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.CompanyLogo field.
	/// </summary>
	public void SetCompanyLogoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CompanyLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.CompanyLogo field.
	/// </summary>
	public void SetCompanyLogoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CompanyLogoColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.Id field.
	/// </summary>
	public string Id0
	{
		get
		{
			return this.GetValue(TableUtils.Id0Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Id0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Id0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Id0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.Id field.
	/// </summary>
	public string Id0Default
	{
		get
		{
			return TableUtils.Id0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.Email field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.Email field.
	/// </summary>
	public string EmailDefault
	{
		get
		{
			return TableUtils.EmailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.EmailConfirmed field.
	/// </summary>
	public bool EmailConfirmed
	{
		get
		{
			return this.GetValue(TableUtils.EmailConfirmedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.EmailConfirmedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EmailConfirmedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EmailConfirmedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.EmailConfirmed field.
	/// </summary>
	public string EmailConfirmedDefault
	{
		get
		{
			return TableUtils.EmailConfirmedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.PasswordHash field.
	/// </summary>
	public string PasswordHash
	{
		get
		{
			return this.GetValue(TableUtils.PasswordHashColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PasswordHashColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PasswordHashSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PasswordHashColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PasswordHash field.
	/// </summary>
	public string PasswordHashDefault
	{
		get
		{
			return TableUtils.PasswordHashColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.SecurityStamp field.
	/// </summary>
	public string SecurityStamp
	{
		get
		{
			return this.GetValue(TableUtils.SecurityStampColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SecurityStampColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SecurityStampSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SecurityStampColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.SecurityStamp field.
	/// </summary>
	public string SecurityStampDefault
	{
		get
		{
			return TableUtils.SecurityStampColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.PhoneNumber field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PhoneNumber field.
	/// </summary>
	public string PhoneNumberDefault
	{
		get
		{
			return TableUtils.PhoneNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.PhoneNumberConfirmed field.
	/// </summary>
	public bool PhoneNumberConfirmed
	{
		get
		{
			return this.GetValue(TableUtils.PhoneNumberConfirmedColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PhoneNumberConfirmedColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PhoneNumberConfirmedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PhoneNumberConfirmedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.PhoneNumberConfirmed field.
	/// </summary>
	public string PhoneNumberConfirmedDefault
	{
		get
		{
			return TableUtils.PhoneNumberConfirmedColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.TwoFactorEnabled field.
	/// </summary>
	public bool TwoFactorEnabled
	{
		get
		{
			return this.GetValue(TableUtils.TwoFactorEnabledColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.TwoFactorEnabledColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TwoFactorEnabledSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TwoFactorEnabledColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.TwoFactorEnabled field.
	/// </summary>
	public string TwoFactorEnabledDefault
	{
		get
		{
			return TableUtils.TwoFactorEnabledColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.LockoutEndDateUtc field.
	/// </summary>
	public DateTime LockoutEndDateUtc
	{
		get
		{
			return this.GetValue(TableUtils.LockoutEndDateUtcColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LockoutEndDateUtcColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LockoutEndDateUtcSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LockoutEndDateUtcColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEndDateUtc field.
	/// </summary>
	public string LockoutEndDateUtcDefault
	{
		get
		{
			return TableUtils.LockoutEndDateUtcColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.LockoutEnabled field.
	/// </summary>
	public bool LockoutEnabled
	{
		get
		{
			return this.GetValue(TableUtils.LockoutEnabledColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.LockoutEnabledColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LockoutEnabledSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LockoutEnabledColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LockoutEnabled field.
	/// </summary>
	public string LockoutEnabledDefault
	{
		get
		{
			return TableUtils.LockoutEnabledColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public Int32 AccessFailedCount
	{
		get
		{
			return this.GetValue(TableUtils.AccessFailedCountColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AccessFailedCountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AccessFailedCountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AccessFailedCountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.AccessFailedCount field.
	/// </summary>
	public string AccessFailedCountDefault
	{
		get
		{
			return TableUtils.AccessFailedCountColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.UserName field.
	/// </summary>
	public string UserName0
	{
		get
		{
			return this.GetValue(TableUtils.UserName0Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserName0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserName0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserName0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.UserName field.
	/// </summary>
	public string UserName0Default
	{
		get
		{
			return TableUtils.UserName0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.FirstName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.LastName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AspNetUsers_.CompanyLogo field.
	/// </summary>
	public string CompanyLogo
	{
		get
		{
			return this.GetValue(TableUtils.CompanyLogoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CompanyLogoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CompanyLogoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CompanyLogoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AspNetUsers_.CompanyLogo field.
	/// </summary>
	public string CompanyLogoDefault
	{
		get
		{
			return TableUtils.CompanyLogoColumn.DefaultValue;
		}
	}


#endregion
}

}
