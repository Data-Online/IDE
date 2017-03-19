// This class is "generated" and will be overwritten.
// Your customizations should be made in NetworkChargesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="NetworkChargesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="NetworkChargesTable"></see> class.
/// </remarks>
/// <seealso cref="NetworkChargesTable"></seealso>
/// <seealso cref="NetworkChargesRecord"></seealso>
public class BaseNetworkChargesRecord : PrimaryKeyRecord
{

	public readonly static NetworkChargesTable TableUtils = NetworkChargesTable.Instance;

	// Constructors
 
	protected BaseNetworkChargesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.NetworkChargesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.NetworkChargesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.NetworkChargesRecord_ReadRecord); 
	}

	protected BaseNetworkChargesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void NetworkChargesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                NetworkChargesRecord NetworkChargesRec = (NetworkChargesRecord)sender;
        if(NetworkChargesRec != null && !NetworkChargesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void NetworkChargesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                NetworkChargesRecord NetworkChargesRec = (NetworkChargesRecord)sender;
        Validate_Inserting();
        if(NetworkChargesRec != null && !NetworkChargesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void NetworkChargesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                NetworkChargesRecord NetworkChargesRec = (NetworkChargesRecord)sender;
        Validate_Updating();
        if(NetworkChargesRec != null && !NetworkChargesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public ColumnValue GetNetworkChargeIdValue()
	{
		return this.GetValue(TableUtils.NetworkChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public Int32 GetNetworkChargeIdFieldValue()
	{
		return this.GetValue(TableUtils.NetworkChargeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public void SetNetworkChargeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public void SetNetworkChargeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public void SetNetworkChargeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public void SetNetworkChargeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public void SetNetworkChargeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkChargeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public ColumnValue GetVariableBDValue()
	{
		return this.GetValue(TableUtils.VariableBDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public Decimal GetVariableBDFieldValue()
	{
		return this.GetValue(TableUtils.VariableBDColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public void SetVariableBDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VariableBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public void SetVariableBDFieldValue(string val)
	{
		this.SetString(val, TableUtils.VariableBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public void SetVariableBDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VariableBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public void SetVariableBDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VariableBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public void SetVariableBDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VariableBDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public ColumnValue GetVariableNBDValue()
	{
		return this.GetValue(TableUtils.VariableNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public Decimal GetVariableNBDFieldValue()
	{
		return this.GetValue(TableUtils.VariableNBDColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public void SetVariableNBDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.VariableNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public void SetVariableNBDFieldValue(string val)
	{
		this.SetString(val, TableUtils.VariableNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public void SetVariableNBDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VariableNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public void SetVariableNBDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VariableNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public void SetVariableNBDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.VariableNBDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public ColumnValue GetCapacityChargeValue()
	{
		return this.GetValue(TableUtils.CapacityChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public Decimal GetCapacityChargeFieldValue()
	{
		return this.GetValue(TableUtils.CapacityChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public void SetCapacityChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CapacityChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public void SetCapacityChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.CapacityChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public void SetCapacityChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CapacityChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public void SetCapacityChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CapacityChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public void SetCapacityChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CapacityChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public ColumnValue GetDemandChargeValue()
	{
		return this.GetValue(TableUtils.DemandChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public Decimal GetDemandChargeFieldValue()
	{
		return this.GetValue(TableUtils.DemandChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public void SetDemandChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DemandChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public void SetDemandChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.DemandChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public void SetDemandChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DemandChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public void SetDemandChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DemandChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public void SetDemandChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DemandChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public ColumnValue GetFixedChargeValue()
	{
		return this.GetValue(TableUtils.FixedChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public Decimal GetFixedChargeFieldValue()
	{
		return this.GetValue(TableUtils.FixedChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public void SetFixedChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FixedChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public void SetFixedChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.FixedChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public void SetFixedChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FixedChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public void SetFixedChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FixedChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public void SetFixedChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FixedChargeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public Int32 NetworkChargeId
	{
		get
		{
			return this.GetValue(TableUtils.NetworkChargeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkChargeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkChargeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkChargeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.NetworkChargeId field.
	/// </summary>
	public string NetworkChargeIdDefault
	{
		get
		{
			return TableUtils.NetworkChargeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public Decimal VariableBD
	{
		get
		{
			return this.GetValue(TableUtils.VariableBDColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VariableBDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VariableBDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VariableBDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableBD field.
	/// </summary>
	public string VariableBDDefault
	{
		get
		{
			return TableUtils.VariableBDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public Decimal VariableNBD
	{
		get
		{
			return this.GetValue(TableUtils.VariableNBDColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.VariableNBDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool VariableNBDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.VariableNBDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.VariableNBD field.
	/// </summary>
	public string VariableNBDDefault
	{
		get
		{
			return TableUtils.VariableNBDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public Decimal CapacityCharge
	{
		get
		{
			return this.GetValue(TableUtils.CapacityChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CapacityChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CapacityChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CapacityChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.CapacityCharge field.
	/// </summary>
	public string CapacityChargeDefault
	{
		get
		{
			return TableUtils.CapacityChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public Decimal DemandCharge
	{
		get
		{
			return this.GetValue(TableUtils.DemandChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DemandChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DemandChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DemandChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.DemandCharge field.
	/// </summary>
	public string DemandChargeDefault
	{
		get
		{
			return TableUtils.DemandChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public Decimal FixedCharge
	{
		get
		{
			return this.GetValue(TableUtils.FixedChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FixedChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FixedChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FixedChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's NetworkCharges_.FixedCharge field.
	/// </summary>
	public string FixedChargeDefault
	{
		get
		{
			return TableUtils.FixedChargeColumn.DefaultValue;
		}
	}


#endregion
}

}
