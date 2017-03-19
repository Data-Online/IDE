// This class is "generated" and will be overwritten.
// Your customizations should be made in UsersRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="UsersRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="UsersTable"></see> class.
/// </remarks>
/// <seealso cref="UsersTable"></seealso>
/// <seealso cref="UsersRecord"></seealso>
public class BaseUsersRecord : PrimaryKeyRecord, IUserIdentityRecord
{

	public readonly static UsersTable TableUtils = UsersTable.Instance;

	// Constructors
 
	protected BaseUsersRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.UsersRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.UsersRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.UsersRecord_ReadRecord); 
	}

	protected BaseUsersRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void UsersRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                UsersRecord UsersRec = (UsersRecord)sender;
        if(UsersRec != null && !UsersRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void UsersRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                UsersRecord UsersRec = (UsersRecord)sender;
        Validate_Inserting();
        if(UsersRec != null && !UsersRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void UsersRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                UsersRecord UsersRec = (UsersRecord)sender;
        Validate_Updating();
        if(UsersRec != null && !UsersRec.IsReadOnly ){
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

#region "IUserRecord Members"

	//Get the user's unique identifier
	public string GetUserId()
	{
		return this.GetString(((BaseClasses.IUserTable)this.TableAccess).UserIdColumn);
	}

#endregion


#region "IUserIdentityRecord Members"

	//Get the user's name
	public string GetUserName()
	{
		return this.GetString(((BaseClasses.IUserIdentityTable)this.TableAccess).UserNameColumn);
	}

	//Get the user's password
	public string GetUserPassword()
	{
		return this.GetString(((BaseClasses.IUserIdentityTable)this.TableAccess).UserPasswordColumn);
	}

	//Get the user's email address
	public string GetUserEmail()
	{
		return this.GetString(((BaseClasses.IUserIdentityTable)this.TableAccess).UserEmailColumn);
	}

	//Get a list of roles to which the user belongs
	public string[] GetUserRoles()
	{
		string[] roles;
		if ((this as BaseClasses.IUserRoleRecord) != null)
		{
			string role = ((BaseClasses.IUserRoleRecord)this).GetUserRole();
			roles = new string[]{role};
		}
		else
		{
			BaseClasses.IUserRoleTable roleTable = 
				((BaseClasses.IUserIdentityTable)this.TableAccess).GetUserRoleTable();
			if (roleTable == null)
			{
				return null;
			}
			else
			{
				ColumnValueFilter filter = BaseFilter.CreateUserIdFilter(roleTable, this.GetUserId());
				BaseClasses.Data.OrderBy order = new BaseClasses.Data.OrderBy(false, false);
				BaseClasses.Data.BaseFilter join = null;
				ArrayList roleRecords = roleTable.GetRecordList(
					join, 
					filter, 
					null, 
					order, 
					BaseClasses.Data.BaseTable.MIN_PAGE_NUMBER, 
					BaseClasses.Data.BaseTable.MAX_BATCH_SIZE);
				ArrayList roleList = new ArrayList(roleRecords.Count);
				foreach (BaseClasses.IUserRoleRecord roleRecord in roleRecords)
				{
					roleList.Add(roleRecord.GetUserRole());
				}
				roles = (string[])roleList.ToArray(typeof(string));
			}
		}
		return roles;
	}

#endregion




#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_.UserId field.
	/// </summary>
	public ColumnValue GetUserId0Value()
	{
		return this.GetValue(TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_.UserId field.
	/// </summary>
	public Int32 GetUserId0FieldValue()
	{
		return this.GetValue(TableUtils.UserId0Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_.UserName field.
	/// </summary>
	public ColumnValue GetUserName0Value()
	{
		return this.GetValue(TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_.UserName field.
	/// </summary>
	public string GetUserName0FieldValue()
	{
		return this.GetValue(TableUtils.UserName0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_.UserName field.
	/// </summary>
	public void SetUserName0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_.UserName field.
	/// </summary>
	public void SetUserName0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserName0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_.Password field.
	/// </summary>
	public ColumnValue GetPasswordValue()
	{
		return this.GetValue(TableUtils.PasswordColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_.Password field.
	/// </summary>
	public string GetPasswordFieldValue()
	{
		return this.GetValue(TableUtils.PasswordColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_.Password field.
	/// </summary>
	public void SetPasswordFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PasswordColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_.Password field.
	/// </summary>
	public void SetPasswordFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PasswordColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Users_.UserId field.
	/// </summary>
	public Int32 UserId0
	{
		get
		{
			return this.GetValue(TableUtils.UserId0Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserId0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserId0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserId0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_.UserId field.
	/// </summary>
	public string UserId0Default
	{
		get
		{
			return TableUtils.UserId0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Users_.UserName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Users_.UserName field.
	/// </summary>
	public string UserName0Default
	{
		get
		{
			return TableUtils.UserName0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Users_.Password field.
	/// </summary>
	public string Password
	{
		get
		{
			return this.GetValue(TableUtils.PasswordColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PasswordColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PasswordSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PasswordColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_.Password field.
	/// </summary>
	public string PasswordDefault
	{
		get
		{
			return TableUtils.PasswordColumn.DefaultValue;
		}
	}


#endregion
}

}
