// This class is "generated" and will be overwritten.
// Your customizations should be made in OtherChargesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="OtherChargesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="OtherChargesTable"></see> class.
/// </remarks>
/// <seealso cref="OtherChargesTable"></seealso>
/// <seealso cref="OtherChargesRecord"></seealso>
public class BaseOtherChargesRecord : PrimaryKeyRecord
{

	public readonly static OtherChargesTable TableUtils = OtherChargesTable.Instance;

	// Constructors
 
	protected BaseOtherChargesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.OtherChargesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.OtherChargesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.OtherChargesRecord_ReadRecord); 
	}

	protected BaseOtherChargesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void OtherChargesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                OtherChargesRecord OtherChargesRec = (OtherChargesRecord)sender;
        if(OtherChargesRec != null && !OtherChargesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void OtherChargesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                OtherChargesRecord OtherChargesRec = (OtherChargesRecord)sender;
        Validate_Inserting();
        if(OtherChargesRec != null && !OtherChargesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void OtherChargesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                OtherChargesRecord OtherChargesRec = (OtherChargesRecord)sender;
        Validate_Updating();
        if(OtherChargesRec != null && !OtherChargesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public ColumnValue GetOtherChargeIdValue()
	{
		return this.GetValue(TableUtils.OtherChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public Int32 GetOtherChargeIdFieldValue()
	{
		return this.GetValue(TableUtils.OtherChargeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public void SetOtherChargeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OtherChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public void SetOtherChargeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.OtherChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public void SetOtherChargeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public void SetOtherChargeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherChargeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public void SetOtherChargeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherChargeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public ColumnValue GetBDSVCValue()
	{
		return this.GetValue(TableUtils.BDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public Decimal GetBDSVCFieldValue()
	{
		return this.GetValue(TableUtils.BDSVCColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public void SetBDSVCFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public void SetBDSVCFieldValue(string val)
	{
		this.SetString(val, TableUtils.BDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public void SetBDSVCFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public void SetBDSVCFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public void SetBDSVCFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDSVCColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public ColumnValue GetBDSVCRValue()
	{
		return this.GetValue(TableUtils.BDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public Decimal GetBDSVCRFieldValue()
	{
		return this.GetValue(TableUtils.BDSVCRColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public void SetBDSVCRFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public void SetBDSVCRFieldValue(string val)
	{
		this.SetString(val, TableUtils.BDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public void SetBDSVCRFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public void SetBDSVCRFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public void SetBDSVCRFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BDSVCRColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public ColumnValue GetNBDSVCValue()
	{
		return this.GetValue(TableUtils.NBDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public Decimal GetNBDSVCFieldValue()
	{
		return this.GetValue(TableUtils.NBDSVCColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public void SetNBDSVCFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public void SetNBDSVCFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public void SetNBDSVCFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public void SetNBDSVCFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBDSVCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public void SetNBDSVCFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBDSVCColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public ColumnValue GetNBDSVCRValue()
	{
		return this.GetValue(TableUtils.NBDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public Decimal GetNBDSVCRFieldValue()
	{
		return this.GetValue(TableUtils.NBDSVCRColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public void SetNBDSVCRFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NBDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public void SetNBDSVCRFieldValue(string val)
	{
		this.SetString(val, TableUtils.NBDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public void SetNBDSVCRFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public void SetNBDSVCRFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBDSVCRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public void SetNBDSVCRFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NBDSVCRColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public ColumnValue GetEALevyValue()
	{
		return this.GetValue(TableUtils.EALevyColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public Decimal GetEALevyFieldValue()
	{
		return this.GetValue(TableUtils.EALevyColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public void SetEALevyFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EALevyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public void SetEALevyFieldValue(string val)
	{
		this.SetString(val, TableUtils.EALevyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public void SetEALevyFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EALevyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public void SetEALevyFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EALevyColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public void SetEALevyFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EALevyColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public ColumnValue GetEALevyRValue()
	{
		return this.GetValue(TableUtils.EALevyRColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public Decimal GetEALevyRFieldValue()
	{
		return this.GetValue(TableUtils.EALevyRColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public void SetEALevyRFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EALevyRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public void SetEALevyRFieldValue(string val)
	{
		this.SetString(val, TableUtils.EALevyRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public void SetEALevyRFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EALevyRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public void SetEALevyRFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EALevyRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public void SetEALevyRFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EALevyRColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public ColumnValue GetAdminChargeValue()
	{
		return this.GetValue(TableUtils.AdminChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public Decimal GetAdminChargeFieldValue()
	{
		return this.GetValue(TableUtils.AdminChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public void SetAdminChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdminChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public void SetAdminChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.AdminChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public void SetAdminChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdminChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public void SetAdminChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdminChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public void SetAdminChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdminChargeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public Int32 OtherChargeId
	{
		get
		{
			return this.GetValue(TableUtils.OtherChargeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OtherChargeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OtherChargeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OtherChargeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.OtherChargeId field.
	/// </summary>
	public string OtherChargeIdDefault
	{
		get
		{
			return TableUtils.OtherChargeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public Decimal BDSVC
	{
		get
		{
			return this.GetValue(TableUtils.BDSVCColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BDSVCColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BDSVCSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BDSVCColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVC field.
	/// </summary>
	public string BDSVCDefault
	{
		get
		{
			return TableUtils.BDSVCColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public Decimal BDSVCR
	{
		get
		{
			return this.GetValue(TableUtils.BDSVCRColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BDSVCRColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BDSVCRSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BDSVCRColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.BDSVCR field.
	/// </summary>
	public string BDSVCRDefault
	{
		get
		{
			return TableUtils.BDSVCRColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public Decimal NBDSVC
	{
		get
		{
			return this.GetValue(TableUtils.NBDSVCColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBDSVCColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBDSVCSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBDSVCColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVC field.
	/// </summary>
	public string NBDSVCDefault
	{
		get
		{
			return TableUtils.NBDSVCColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public Decimal NBDSVCR
	{
		get
		{
			return this.GetValue(TableUtils.NBDSVCRColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NBDSVCRColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NBDSVCRSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NBDSVCRColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.NBDSVCR field.
	/// </summary>
	public string NBDSVCRDefault
	{
		get
		{
			return TableUtils.NBDSVCRColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public Decimal EALevy
	{
		get
		{
			return this.GetValue(TableUtils.EALevyColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EALevyColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EALevySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EALevyColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevy field.
	/// </summary>
	public string EALevyDefault
	{
		get
		{
			return TableUtils.EALevyColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public Decimal EALevyR
	{
		get
		{
			return this.GetValue(TableUtils.EALevyRColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EALevyRColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EALevyRSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EALevyRColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.EALevyR field.
	/// </summary>
	public string EALevyRDefault
	{
		get
		{
			return TableUtils.EALevyRColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public Decimal AdminCharge
	{
		get
		{
			return this.GetValue(TableUtils.AdminChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AdminChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdminChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdminChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OtherCharges_.AdminCharge field.
	/// </summary>
	public string AdminChargeDefault
	{
		get
		{
			return TableUtils.AdminChargeColumn.DefaultValue;
		}
	}


#endregion
}

}
