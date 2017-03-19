// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergyPointsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="EnergyPointsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="EnergyPointsTable"></see> class.
/// </remarks>
/// <seealso cref="EnergyPointsTable"></seealso>
/// <seealso cref="EnergyPointsRecord"></seealso>
public class BaseEnergyPointsRecord : PrimaryKeyRecord
{

	public readonly static EnergyPointsTable TableUtils = EnergyPointsTable.Instance;

	// Constructors
 
	protected BaseEnergyPointsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.EnergyPointsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.EnergyPointsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.EnergyPointsRecord_ReadRecord); 
	}

	protected BaseEnergyPointsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void EnergyPointsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                EnergyPointsRecord EnergyPointsRec = (EnergyPointsRecord)sender;
        if(EnergyPointsRec != null && !EnergyPointsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void EnergyPointsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                EnergyPointsRecord EnergyPointsRec = (EnergyPointsRecord)sender;
        Validate_Inserting();
        if(EnergyPointsRec != null && !EnergyPointsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void EnergyPointsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                EnergyPointsRecord EnergyPointsRec = (EnergyPointsRecord)sender;
        Validate_Updating();
        if(EnergyPointsRec != null && !EnergyPointsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.EnergyPointId field.
	/// </summary>
	public ColumnValue GetEnergyPointIdValue()
	{
		return this.GetValue(TableUtils.EnergyPointIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.EnergyPointId field.
	/// </summary>
	public Int32 GetEnergyPointIdFieldValue()
	{
		return this.GetValue(TableUtils.EnergyPointIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.EnergyPointNumber field.
	/// </summary>
	public ColumnValue GetEnergyPointNumberValue()
	{
		return this.GetValue(TableUtils.EnergyPointNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.EnergyPointNumber field.
	/// </summary>
	public string GetEnergyPointNumberFieldValue()
	{
		return this.GetValue(TableUtils.EnergyPointNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.EnergyPointNumber field.
	/// </summary>
	public void SetEnergyPointNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EnergyPointNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.EnergyPointNumber field.
	/// </summary>
	public void SetEnergyPointNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyPointNumberColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.EnergyPointId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.EnergyPointId field.
	/// </summary>
	public string EnergyPointIdDefault
	{
		get
		{
			return TableUtils.EnergyPointIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.EnergyPointNumber field.
	/// </summary>
	public string EnergyPointNumber
	{
		get
		{
			return this.GetValue(TableUtils.EnergyPointNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EnergyPointNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EnergyPointNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EnergyPointNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.EnergyPointNumber field.
	/// </summary>
	public string EnergyPointNumberDefault
	{
		get
		{
			return TableUtils.EnergyPointNumberColumn.DefaultValue;
		}
	}


#endregion
}

}
