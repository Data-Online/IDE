// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergyChargesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="EnergyChargesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="EnergyChargesTable"></see> class.
/// </remarks>
/// <seealso cref="EnergyChargesTable"></seealso>
/// <seealso cref="EnergyChargesRecord"></seealso>
public class BaseEnergyChargesRecord : PrimaryKeyRecord
{

	public readonly static EnergyChargesTable TableUtils = EnergyChargesTable.Instance;

	// Constructors
 
	protected BaseEnergyChargesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.EnergyChargesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.EnergyChargesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.EnergyChargesRecord_ReadRecord); 
	}

	protected BaseEnergyChargesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void EnergyChargesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                EnergyChargesRecord EnergyChargesRec = (EnergyChargesRecord)sender;
        if(EnergyChargesRec != null && !EnergyChargesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void EnergyChargesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                EnergyChargesRecord EnergyChargesRec = (EnergyChargesRecord)sender;
        Validate_Inserting();
        if(EnergyChargesRec != null && !EnergyChargesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void EnergyChargesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                EnergyChargesRecord EnergyChargesRec = (EnergyChargesRecord)sender;
        Validate_Updating();
        if(EnergyChargesRec != null && !EnergyChargesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public ColumnValue GetEnergyChargeIdValue()
	{
		return this.GetValue(TableUtils.EnergyChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public Int32 GetEnergyChargeIdFieldValue()
	{
		return this.GetValue(TableUtils.EnergyChargeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public void SetEnergyChargeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EnergyChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public void SetEnergyChargeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.EnergyChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public void SetEnergyChargeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public void SetEnergyChargeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public void SetEnergyChargeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyChargeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public ColumnValue GetBD0004Value()
	{
		return this.GetValue(TableUtils.BD0004Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public Decimal GetBD0004FieldValue()
	{
		return this.GetValue(TableUtils.BD0004Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public void SetBD0004FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public void SetBD0004FieldValue(string val)
	{
		this.SetString(val, TableUtils.BD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public void SetBD0004FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public void SetBD0004FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public void SetBD0004FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0004Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public ColumnValue GetBD0408Value()
	{
		return this.GetValue(TableUtils.BD0408Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public Decimal GetBD0408FieldValue()
	{
		return this.GetValue(TableUtils.BD0408Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public void SetBD0408FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public void SetBD0408FieldValue(string val)
	{
		this.SetString(val, TableUtils.BD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public void SetBD0408FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public void SetBD0408FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public void SetBD0408FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0408Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public ColumnValue GetBD0812Value()
	{
		return this.GetValue(TableUtils.BD0812Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public Decimal GetBD0812FieldValue()
	{
		return this.GetValue(TableUtils.BD0812Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public void SetBD0812FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public void SetBD0812FieldValue(string val)
	{
		this.SetString(val, TableUtils.BD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public void SetBD0812FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public void SetBD0812FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public void SetBD0812FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0812Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public ColumnValue GetBD1216Value()
	{
		return this.GetValue(TableUtils.BD1216Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public Decimal GetBD1216FieldValue()
	{
		return this.GetValue(TableUtils.BD1216Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public void SetBD1216FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public void SetBD1216FieldValue(string val)
	{
		this.SetString(val, TableUtils.BD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public void SetBD1216FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public void SetBD1216FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public void SetBD1216FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1216Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public ColumnValue GetBD1620Value()
	{
		return this.GetValue(TableUtils.BD1620Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public Decimal GetBD1620FieldValue()
	{
		return this.GetValue(TableUtils.BD1620Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public void SetBD1620FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public void SetBD1620FieldValue(string val)
	{
		this.SetString(val, TableUtils.BD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public void SetBD1620FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public void SetBD1620FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public void SetBD1620FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1620Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public ColumnValue GetBD2024Value()
	{
		return this.GetValue(TableUtils.BD2024Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public Decimal GetBD2024FieldValue()
	{
		return this.GetValue(TableUtils.BD2024Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public void SetBD2024FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public void SetBD2024FieldValue(string val)
	{
		this.SetString(val, TableUtils.BD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public void SetBD2024FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public void SetBD2024FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public void SetBD2024FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD2024Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public ColumnValue GetNBD0004Value()
	{
		return this.GetValue(TableUtils.NBD0004Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public Decimal GetNBD0004FieldValue()
	{
		return this.GetValue(TableUtils.NBD0004Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public void SetNBD0004FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public void SetNBD0004FieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public void SetNBD0004FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public void SetNBD0004FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public void SetNBD0004FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0004Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public ColumnValue GetNBD0408Value()
	{
		return this.GetValue(TableUtils.NBD0408Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public Decimal GetNBD0408FieldValue()
	{
		return this.GetValue(TableUtils.NBD0408Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public void SetNBD0408FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public void SetNBD0408FieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public void SetNBD0408FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public void SetNBD0408FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0408Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public void SetNBD0408FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0408Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public ColumnValue GetNBD0812Value()
	{
		return this.GetValue(TableUtils.NBD0812Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public Decimal GetNBD0812FieldValue()
	{
		return this.GetValue(TableUtils.NBD0812Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public void SetNBD0812FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public void SetNBD0812FieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public void SetNBD0812FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public void SetNBD0812FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0812Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public void SetNBD0812FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0812Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public ColumnValue GetNBD1216Value()
	{
		return this.GetValue(TableUtils.NBD1216Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public Decimal GetNBD1216FieldValue()
	{
		return this.GetValue(TableUtils.NBD1216Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public void SetNBD1216FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public void SetNBD1216FieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public void SetNBD1216FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public void SetNBD1216FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1216Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public void SetNBD1216FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1216Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public ColumnValue GetNBD1620Value()
	{
		return this.GetValue(TableUtils.NBD1620Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public Decimal GetNBD1620FieldValue()
	{
		return this.GetValue(TableUtils.NBD1620Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public void SetNBD1620FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public void SetNBD1620FieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public void SetNBD1620FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public void SetNBD1620FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1620Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public void SetNBD1620FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1620Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public ColumnValue GetNBD2024Value()
	{
		return this.GetValue(TableUtils.NBD2024Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public Decimal GetNBD2024FieldValue()
	{
		return this.GetValue(TableUtils.NBD2024Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public void SetNBD2024FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public void SetNBD2024FieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public void SetNBD2024FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public void SetNBD2024FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD2024Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public void SetNBD2024FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD2024Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public ColumnValue GetBD0004RValue()
	{
		return this.GetValue(TableUtils.BD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public Decimal GetBD0004RFieldValue()
	{
		return this.GetValue(TableUtils.BD0004RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public void SetBD0004RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public void SetBD0004RFieldValue(string val)
	{
		this.SetString(val, TableUtils.BD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public void SetBD0004RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public void SetBD0004RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public void SetBD0004RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0004RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public ColumnValue GetBD0408RValue()
	{
		return this.GetValue(TableUtils.BD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public Decimal GetBD0408RFieldValue()
	{
		return this.GetValue(TableUtils.BD0408RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public void SetBD0408RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public void SetBD0408RFieldValue(string val)
	{
		this.SetString(val, TableUtils.BD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public void SetBD0408RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public void SetBD0408RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public void SetBD0408RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0408RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public ColumnValue GetBD0812RValue()
	{
		return this.GetValue(TableUtils.BD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public Decimal GetBD0812RFieldValue()
	{
		return this.GetValue(TableUtils.BD0812RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public void SetBD0812RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public void SetBD0812RFieldValue(string val)
	{
		this.SetString(val, TableUtils.BD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public void SetBD0812RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public void SetBD0812RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public void SetBD0812RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD0812RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public ColumnValue GetBD1216RValue()
	{
		return this.GetValue(TableUtils.BD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public Decimal GetBD1216RFieldValue()
	{
		return this.GetValue(TableUtils.BD1216RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public void SetBD1216RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public void SetBD1216RFieldValue(string val)
	{
		this.SetString(val, TableUtils.BD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public void SetBD1216RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public void SetBD1216RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public void SetBD1216RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1216RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public ColumnValue GetBD1620RValue()
	{
		return this.GetValue(TableUtils.BD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public Decimal GetBD1620RFieldValue()
	{
		return this.GetValue(TableUtils.BD1620RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public void SetBD1620RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public void SetBD1620RFieldValue(string val)
	{
		this.SetString(val, TableUtils.BD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public void SetBD1620RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public void SetBD1620RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public void SetBD1620RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD1620RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public ColumnValue GetBD2024RValue()
	{
		return this.GetValue(TableUtils.BD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public Decimal GetBD2024RFieldValue()
	{
		return this.GetValue(TableUtils.BD2024RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public void SetBD2024RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public void SetBD2024RFieldValue(string val)
	{
		this.SetString(val, TableUtils.BD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public void SetBD2024RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public void SetBD2024RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public void SetBD2024RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BD2024RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public ColumnValue GetNBD0004RValue()
	{
		return this.GetValue(TableUtils.NBD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public Decimal GetNBD0004RFieldValue()
	{
		return this.GetValue(TableUtils.NBD0004RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public void SetNBD0004RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public void SetNBD0004RFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public void SetNBD0004RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public void SetNBD0004RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0004RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public void SetNBD0004RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0004RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public ColumnValue GetNBD0408RValue()
	{
		return this.GetValue(TableUtils.NBD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public Decimal GetNBD0408RFieldValue()
	{
		return this.GetValue(TableUtils.NBD0408RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public void SetNBD0408RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public void SetNBD0408RFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public void SetNBD0408RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public void SetNBD0408RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0408RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public void SetNBD0408RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0408RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public ColumnValue GetNBD0812RValue()
	{
		return this.GetValue(TableUtils.NBD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public Decimal GetNBD0812RFieldValue()
	{
		return this.GetValue(TableUtils.NBD0812RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public void SetNBD0812RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public void SetNBD0812RFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public void SetNBD0812RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public void SetNBD0812RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0812RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public void SetNBD0812RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD0812RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public ColumnValue GetNBD1216RValue()
	{
		return this.GetValue(TableUtils.NBD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public Decimal GetNBD1216RFieldValue()
	{
		return this.GetValue(TableUtils.NBD1216RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public void SetNBD1216RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public void SetNBD1216RFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public void SetNBD1216RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public void SetNBD1216RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1216RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public void SetNBD1216RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1216RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public ColumnValue GetNBD1620RValue()
	{
		return this.GetValue(TableUtils.NBD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public Decimal GetNBD1620RFieldValue()
	{
		return this.GetValue(TableUtils.NBD1620RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public void SetNBD1620RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public void SetNBD1620RFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public void SetNBD1620RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public void SetNBD1620RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1620RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public void SetNBD1620RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD1620RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public ColumnValue GetNBD2024RValue()
	{
		return this.GetValue(TableUtils.NBD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public Decimal GetNBD2024RFieldValue()
	{
		return this.GetValue(TableUtils.NBD2024RColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public void SetNBD2024RFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public void SetNBD2024RFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public void SetNBD2024RFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public void SetNBD2024RFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD2024RColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public void SetNBD2024RFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBD2024RColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public ColumnValue GetBDQ0004Value()
	{
		return this.GetValue(TableUtils.BDQ0004Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public Decimal GetBDQ0004FieldValue()
	{
		return this.GetValue(TableUtils.BDQ0004Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public void SetBDQ0004FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BDQ0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public void SetBDQ0004FieldValue(string val)
	{
		this.SetString(val, TableUtils.BDQ0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public void SetBDQ0004FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDQ0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public void SetBDQ0004FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDQ0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public void SetBDQ0004FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDQ0004Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public ColumnValue GetBDL0004Value()
	{
		return this.GetValue(TableUtils.BDL0004Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public Decimal GetBDL0004FieldValue()
	{
		return this.GetValue(TableUtils.BDL0004Column).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public void SetBDL0004FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BDL0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public void SetBDL0004FieldValue(string val)
	{
		this.SetString(val, TableUtils.BDL0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public void SetBDL0004FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDL0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public void SetBDL0004FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDL0004Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public void SetBDL0004FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDL0004Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public Int32 EnergyChargeId
	{
		get
		{
			return this.GetValue(TableUtils.EnergyChargeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EnergyChargeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EnergyChargeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EnergyChargeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.EnergyChargeId field.
	/// </summary>
	public string EnergyChargeIdDefault
	{
		get
		{
			return TableUtils.EnergyChargeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public Decimal BD0004
	{
		get
		{
			return this.GetValue(TableUtils.BD0004Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD0004Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD0004Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD0004Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004 field.
	/// </summary>
	public string BD0004Default
	{
		get
		{
			return TableUtils.BD0004Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public Decimal BD0408
	{
		get
		{
			return this.GetValue(TableUtils.BD0408Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD0408Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD0408Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD0408Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408 field.
	/// </summary>
	public string BD0408Default
	{
		get
		{
			return TableUtils.BD0408Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public Decimal BD0812
	{
		get
		{
			return this.GetValue(TableUtils.BD0812Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD0812Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD0812Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD0812Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812 field.
	/// </summary>
	public string BD0812Default
	{
		get
		{
			return TableUtils.BD0812Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public Decimal BD1216
	{
		get
		{
			return this.GetValue(TableUtils.BD1216Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD1216Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD1216Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD1216Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216 field.
	/// </summary>
	public string BD1216Default
	{
		get
		{
			return TableUtils.BD1216Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public Decimal BD1620
	{
		get
		{
			return this.GetValue(TableUtils.BD1620Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD1620Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD1620Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD1620Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620 field.
	/// </summary>
	public string BD1620Default
	{
		get
		{
			return TableUtils.BD1620Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public Decimal BD2024
	{
		get
		{
			return this.GetValue(TableUtils.BD2024Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD2024Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD2024Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD2024Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024 field.
	/// </summary>
	public string BD2024Default
	{
		get
		{
			return TableUtils.BD2024Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public Decimal NBD0004
	{
		get
		{
			return this.GetValue(TableUtils.NBD0004Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD0004Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD0004Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD0004Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004 field.
	/// </summary>
	public string NBD0004Default
	{
		get
		{
			return TableUtils.NBD0004Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public Decimal NBD0408
	{
		get
		{
			return this.GetValue(TableUtils.NBD0408Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD0408Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD0408Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD0408Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408 field.
	/// </summary>
	public string NBD0408Default
	{
		get
		{
			return TableUtils.NBD0408Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public Decimal NBD0812
	{
		get
		{
			return this.GetValue(TableUtils.NBD0812Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD0812Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD0812Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD0812Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812 field.
	/// </summary>
	public string NBD0812Default
	{
		get
		{
			return TableUtils.NBD0812Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public Decimal NBD1216
	{
		get
		{
			return this.GetValue(TableUtils.NBD1216Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD1216Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD1216Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD1216Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216 field.
	/// </summary>
	public string NBD1216Default
	{
		get
		{
			return TableUtils.NBD1216Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public Decimal NBD1620
	{
		get
		{
			return this.GetValue(TableUtils.NBD1620Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD1620Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD1620Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD1620Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620 field.
	/// </summary>
	public string NBD1620Default
	{
		get
		{
			return TableUtils.NBD1620Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public Decimal NBD2024
	{
		get
		{
			return this.GetValue(TableUtils.NBD2024Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD2024Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD2024Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD2024Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024 field.
	/// </summary>
	public string NBD2024Default
	{
		get
		{
			return TableUtils.NBD2024Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public Decimal BD0004R
	{
		get
		{
			return this.GetValue(TableUtils.BD0004RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD0004RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD0004RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD0004RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0004R field.
	/// </summary>
	public string BD0004RDefault
	{
		get
		{
			return TableUtils.BD0004RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public Decimal BD0408R
	{
		get
		{
			return this.GetValue(TableUtils.BD0408RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD0408RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD0408RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD0408RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0408R field.
	/// </summary>
	public string BD0408RDefault
	{
		get
		{
			return TableUtils.BD0408RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public Decimal BD0812R
	{
		get
		{
			return this.GetValue(TableUtils.BD0812RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD0812RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD0812RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD0812RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD0812R field.
	/// </summary>
	public string BD0812RDefault
	{
		get
		{
			return TableUtils.BD0812RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public Decimal BD1216R
	{
		get
		{
			return this.GetValue(TableUtils.BD1216RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD1216RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD1216RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD1216RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1216R field.
	/// </summary>
	public string BD1216RDefault
	{
		get
		{
			return TableUtils.BD1216RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public Decimal BD1620R
	{
		get
		{
			return this.GetValue(TableUtils.BD1620RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD1620RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD1620RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD1620RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD1620R field.
	/// </summary>
	public string BD1620RDefault
	{
		get
		{
			return TableUtils.BD1620RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public Decimal BD2024R
	{
		get
		{
			return this.GetValue(TableUtils.BD2024RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BD2024RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BD2024RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BD2024RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BD2024R field.
	/// </summary>
	public string BD2024RDefault
	{
		get
		{
			return TableUtils.BD2024RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public Decimal NBD0004R
	{
		get
		{
			return this.GetValue(TableUtils.NBD0004RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD0004RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD0004RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD0004RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0004R field.
	/// </summary>
	public string NBD0004RDefault
	{
		get
		{
			return TableUtils.NBD0004RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public Decimal NBD0408R
	{
		get
		{
			return this.GetValue(TableUtils.NBD0408RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD0408RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD0408RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD0408RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0408R field.
	/// </summary>
	public string NBD0408RDefault
	{
		get
		{
			return TableUtils.NBD0408RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public Decimal NBD0812R
	{
		get
		{
			return this.GetValue(TableUtils.NBD0812RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD0812RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD0812RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD0812RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD0812R field.
	/// </summary>
	public string NBD0812RDefault
	{
		get
		{
			return TableUtils.NBD0812RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public Decimal NBD1216R
	{
		get
		{
			return this.GetValue(TableUtils.NBD1216RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD1216RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD1216RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD1216RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1216R field.
	/// </summary>
	public string NBD1216RDefault
	{
		get
		{
			return TableUtils.NBD1216RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public Decimal NBD1620R
	{
		get
		{
			return this.GetValue(TableUtils.NBD1620RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD1620RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD1620RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD1620RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD1620R field.
	/// </summary>
	public string NBD1620RDefault
	{
		get
		{
			return TableUtils.NBD1620RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public Decimal NBD2024R
	{
		get
		{
			return this.GetValue(TableUtils.NBD2024RColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBD2024RColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBD2024RSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBD2024RColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.NBD2024R field.
	/// </summary>
	public string NBD2024RDefault
	{
		get
		{
			return TableUtils.NBD2024RColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public Decimal BDQ0004
	{
		get
		{
			return this.GetValue(TableUtils.BDQ0004Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BDQ0004Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BDQ0004Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BDQ0004Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDQ0004 field.
	/// </summary>
	public string BDQ0004Default
	{
		get
		{
			return TableUtils.BDQ0004Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public Decimal BDL0004
	{
		get
		{
			return this.GetValue(TableUtils.BDL0004Column).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BDL0004Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BDL0004Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BDL0004Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyCharges_.BDL0004 field.
	/// </summary>
	public string BDL0004Default
	{
		get
		{
			return TableUtils.BDL0004Column.DefaultValue;
		}
	}


#endregion
}

}
