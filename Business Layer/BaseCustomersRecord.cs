// This class is "generated" and will be overwritten.
// Your customizations should be made in CustomersRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="CustomersRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CustomersTable"></see> class.
/// </remarks>
/// <seealso cref="CustomersTable"></seealso>
/// <seealso cref="CustomersRecord"></seealso>
public class BaseCustomersRecord : PrimaryKeyRecord
{

	public readonly static CustomersTable TableUtils = CustomersTable.Instance;

	// Constructors
 
	protected BaseCustomersRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CustomersRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CustomersRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CustomersRecord_ReadRecord); 
	}

	protected BaseCustomersRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CustomersRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CustomersRecord CustomersRec = (CustomersRecord)sender;
        if(CustomersRec != null && !CustomersRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CustomersRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CustomersRecord CustomersRec = (CustomersRecord)sender;
        Validate_Inserting();
        if(CustomersRec != null && !CustomersRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CustomersRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CustomersRecord CustomersRec = (CustomersRecord)sender;
        Validate_Updating();
        if(CustomersRec != null && !CustomersRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustomerId field.
	/// </summary>
	public ColumnValue GetCustomerIdValue()
	{
		return this.GetValue(TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustomerId field.
	/// </summary>
	public Int32 GetCustomerIdFieldValue()
	{
		return this.GetValue(TableUtils.CustomerIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustomerName field.
	/// </summary>
	public ColumnValue GetCustomerNameValue()
	{
		return this.GetValue(TableUtils.CustomerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CustomerName field.
	/// </summary>
	public string GetCustomerNameFieldValue()
	{
		return this.GetValue(TableUtils.CustomerNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustomerName field.
	/// </summary>
	public void SetCustomerNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustomerNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustomerName field.
	/// </summary>
	public void SetCustomerNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.AddressId field.
	/// </summary>
	public ColumnValue GetAddressIdValue()
	{
		return this.GetValue(TableUtils.AddressIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.AddressId field.
	/// </summary>
	public Int32 GetAddressIdFieldValue()
	{
		return this.GetValue(TableUtils.AddressIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.AddressId field.
	/// </summary>
	public void SetAddressIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AddressIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.AddressId field.
	/// </summary>
	public void SetAddressIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.AddressIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.AddressId field.
	/// </summary>
	public void SetAddressIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AddressIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.AddressId field.
	/// </summary>
	public void SetAddressIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AddressIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.AddressId field.
	/// </summary>
	public void SetAddressIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AddressIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public ColumnValue GetContact_ContactIdValue()
	{
		return this.GetValue(TableUtils.Contact_ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public Int32 GetContact_ContactIdFieldValue()
	{
		return this.GetValue(TableUtils.Contact_ContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public void SetContact_ContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Contact_ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public void SetContact_ContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.Contact_ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public void SetContact_ContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Contact_ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public void SetContact_ContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Contact_ContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public void SetContact_ContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Contact_ContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CityId field.
	/// </summary>
	public ColumnValue GetCityIdValue()
	{
		return this.GetValue(TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Customers_.CityId field.
	/// </summary>
	public Int32 GetCityIdFieldValue()
	{
		return this.GetValue(TableUtils.CityIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CityId field.
	/// </summary>
	public void SetCityIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustomerId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustomerId field.
	/// </summary>
	public string CustomerIdDefault
	{
		get
		{
			return TableUtils.CustomerIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CustomerName field.
	/// </summary>
	public string CustomerName
	{
		get
		{
			return this.GetValue(TableUtils.CustomerNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CustomerNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CustomerNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CustomerNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CustomerName field.
	/// </summary>
	public string CustomerNameDefault
	{
		get
		{
			return TableUtils.CustomerNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.AddressId field.
	/// </summary>
	public Int32 AddressId
	{
		get
		{
			return this.GetValue(TableUtils.AddressIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AddressIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AddressIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AddressIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.AddressId field.
	/// </summary>
	public string AddressIdDefault
	{
		get
		{
			return TableUtils.AddressIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public Int32 Contact_ContactId
	{
		get
		{
			return this.GetValue(TableUtils.Contact_ContactIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Contact_ContactIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Contact_ContactIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Contact_ContactIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Contact_ContactId field.
	/// </summary>
	public string Contact_ContactIdDefault
	{
		get
		{
			return TableUtils.Contact_ContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Customers_.CityId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Customers_.CityId field.
	/// </summary>
	public string CityIdDefault
	{
		get
		{
			return TableUtils.CityIdColumn.DefaultValue;
		}
	}


#endregion
}

}
