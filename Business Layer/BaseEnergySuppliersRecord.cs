// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergySuppliersRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="EnergySuppliersRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="EnergySuppliersTable"></see> class.
/// </remarks>
/// <seealso cref="EnergySuppliersTable"></seealso>
/// <seealso cref="EnergySuppliersRecord"></seealso>
public class BaseEnergySuppliersRecord : PrimaryKeyRecord
{

	public readonly static EnergySuppliersTable TableUtils = EnergySuppliersTable.Instance;

	// Constructors
 
	protected BaseEnergySuppliersRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.EnergySuppliersRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.EnergySuppliersRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.EnergySuppliersRecord_ReadRecord); 
	}

	protected BaseEnergySuppliersRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void EnergySuppliersRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                EnergySuppliersRecord EnergySuppliersRec = (EnergySuppliersRecord)sender;
        if(EnergySuppliersRec != null && !EnergySuppliersRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void EnergySuppliersRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                EnergySuppliersRecord EnergySuppliersRec = (EnergySuppliersRecord)sender;
        Validate_Inserting();
        if(EnergySuppliersRec != null && !EnergySuppliersRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void EnergySuppliersRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                EnergySuppliersRecord EnergySuppliersRec = (EnergySuppliersRecord)sender;
        Validate_Updating();
        if(EnergySuppliersRec != null && !EnergySuppliersRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplierId field.
	/// </summary>
	public ColumnValue GetSupplierIdValue()
	{
		return this.GetValue(TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplierId field.
	/// </summary>
	public Int32 GetSupplierIdFieldValue()
	{
		return this.GetValue(TableUtils.SupplierIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplierName field.
	/// </summary>
	public ColumnValue GetSupplierNameValue()
	{
		return this.GetValue(TableUtils.SupplierNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplierName field.
	/// </summary>
	public string GetSupplierNameFieldValue()
	{
		return this.GetValue(TableUtils.SupplierNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplierName field.
	/// </summary>
	public void SetSupplierNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SupplierNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplierName field.
	/// </summary>
	public void SetSupplierNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.SupplierId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplierId field.
	/// </summary>
	public string SupplierIdDefault
	{
		get
		{
			return TableUtils.SupplierIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.SupplierName field.
	/// </summary>
	public string SupplierName
	{
		get
		{
			return this.GetValue(TableUtils.SupplierNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SupplierNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SupplierNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SupplierNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplierName field.
	/// </summary>
	public string SupplierNameDefault
	{
		get
		{
			return TableUtils.SupplierNameColumn.DefaultValue;
		}
	}


#endregion
}

}
