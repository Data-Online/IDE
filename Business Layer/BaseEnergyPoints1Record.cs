// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergyPoints1Record.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="EnergyPoints1Record"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="EnergyPoints1Table"></see> class.
/// </remarks>
/// <seealso cref="EnergyPoints1Table"></seealso>
/// <seealso cref="EnergyPoints1Record"></seealso>
public class BaseEnergyPoints1Record : PrimaryKeyRecord
{

	public readonly static EnergyPoints1Table TableUtils = EnergyPoints1Table.Instance;

	// Constructors
 
	protected BaseEnergyPoints1Record() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.EnergyPoints1Record_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.EnergyPoints1Record_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.EnergyPoints1Record_ReadRecord); 
	}

	protected BaseEnergyPoints1Record(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void EnergyPoints1Record_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                EnergyPoints1Record EnergyPoints1Rec = (EnergyPoints1Record)sender;
        if(EnergyPoints1Rec != null && !EnergyPoints1Rec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void EnergyPoints1Record_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                EnergyPoints1Record EnergyPoints1Rec = (EnergyPoints1Record)sender;
        Validate_Inserting();
        if(EnergyPoints1Rec != null && !EnergyPoints1Rec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void EnergyPoints1Record_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                EnergyPoints1Record EnergyPoints1Rec = (EnergyPoints1Record)sender;
        Validate_Updating();
        if(EnergyPoints1Rec != null && !EnergyPoints1Rec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.ConnectionNumber field.
	/// </summary>
	public ColumnValue GetConnectionNumberValue()
	{
		return this.GetValue(TableUtils.ConnectionNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.ConnectionNumber field.
	/// </summary>
	public string GetConnectionNumberFieldValue()
	{
		return this.GetValue(TableUtils.ConnectionNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ConnectionNumber field.
	/// </summary>
	public void SetConnectionNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ConnectionNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ConnectionNumber field.
	/// </summary>
	public void SetConnectionNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ConnectionNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public ColumnValue GetSiteIdValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public Int32 GetSiteIdFieldValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public void SetSiteIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public ColumnValue GetSupplierIdValue()
	{
		return this.GetValue(TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public Int32 GetSupplierIdFieldValue()
	{
		return this.GetValue(TableUtils.SupplierIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public void SetSupplierIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.LocationNotes field.
	/// </summary>
	public ColumnValue GetLocationNotesValue()
	{
		return this.GetValue(TableUtils.LocationNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.LocationNotes field.
	/// </summary>
	public string GetLocationNotesFieldValue()
	{
		return this.GetValue(TableUtils.LocationNotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LocationNotes field.
	/// </summary>
	public void SetLocationNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LocationNotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LocationNotes field.
	/// </summary>
	public void SetLocationNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationNotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public ColumnValue GetLinesCompanyIdValue()
	{
		return this.GetValue(TableUtils.LinesCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public Int32 GetLinesCompanyIdFieldValue()
	{
		return this.GetValue(TableUtils.LinesCompanyIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public void SetLinesCompanyIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LinesCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public void SetLinesCompanyIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.LinesCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public void SetLinesCompanyIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinesCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public void SetLinesCompanyIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinesCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public void SetLinesCompanyIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinesCompanyIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.MeterId field.
	/// </summary>
	public ColumnValue GetMeterIdValue()
	{
		return this.GetValue(TableUtils.MeterIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.MeterId field.
	/// </summary>
	public string GetMeterIdFieldValue()
	{
		return this.GetValue(TableUtils.MeterIdColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeterId field.
	/// </summary>
	public void SetMeterIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeterIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeterId field.
	/// </summary>
	public void SetMeterIdFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeterIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public ColumnValue GetMeteringCompanyIdValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public Int32 GetMeteringCompanyIdFieldValue()
	{
		return this.GetValue(TableUtils.MeteringCompanyIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public void SetMeteringCompanyIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeteringCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public void SetMeteringCompanyIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.MeteringCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public void SetMeteringCompanyIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeteringCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public void SetMeteringCompanyIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeteringCompanyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public void SetMeteringCompanyIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeteringCompanyIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Enabled field.
	/// </summary>
	public ColumnValue GetEnabled0Value()
	{
		return this.GetValue(TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Enabled field.
	/// </summary>
	public bool GetEnabled0FieldValue()
	{
		return this.GetValue(TableUtils.Enabled0Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Enabled0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public ColumnValue GetPhasesValue()
	{
		return this.GetValue(TableUtils.PhasesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public Int32 GetPhasesFieldValue()
	{
		return this.GetValue(TableUtils.PhasesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public void SetPhasesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhasesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public void SetPhasesFieldValue(string val)
	{
		this.SetString(val, TableUtils.PhasesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public void SetPhasesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhasesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public void SetPhasesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhasesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public void SetPhasesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhasesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.GridExitPoint field.
	/// </summary>
	public ColumnValue GetGridExitPointValue()
	{
		return this.GetValue(TableUtils.GridExitPointColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.GridExitPoint field.
	/// </summary>
	public string GetGridExitPointFieldValue()
	{
		return this.GetValue(TableUtils.GridExitPointColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GridExitPoint field.
	/// </summary>
	public void SetGridExitPointFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GridExitPointColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GridExitPoint field.
	/// </summary>
	public void SetGridExitPointFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GridExitPointColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.GridExitPointRegion field.
	/// </summary>
	public ColumnValue GetGridExitPointRegionValue()
	{
		return this.GetValue(TableUtils.GridExitPointRegionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.GridExitPointRegion field.
	/// </summary>
	public string GetGridExitPointRegionFieldValue()
	{
		return this.GetValue(TableUtils.GridExitPointRegionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GridExitPointRegion field.
	/// </summary>
	public void SetGridExitPointRegionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GridExitPointRegionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GridExitPointRegion field.
	/// </summary>
	public void SetGridExitPointRegionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GridExitPointRegionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.ConnectionType field.
	/// </summary>
	public ColumnValue GetConnectionTypeValue()
	{
		return this.GetValue(TableUtils.ConnectionTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.ConnectionType field.
	/// </summary>
	public string GetConnectionTypeFieldValue()
	{
		return this.GetValue(TableUtils.ConnectionTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ConnectionType field.
	/// </summary>
	public void SetConnectionTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ConnectionTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ConnectionType field.
	/// </summary>
	public void SetConnectionTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ConnectionTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.GLCode field.
	/// </summary>
	public ColumnValue GetGLCodeValue()
	{
		return this.GetValue(TableUtils.GLCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.GLCode field.
	/// </summary>
	public string GetGLCodeFieldValue()
	{
		return this.GetValue(TableUtils.GLCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GLCode field.
	/// </summary>
	public void SetGLCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GLCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GLCode field.
	/// </summary>
	public void SetGLCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GLCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public ColumnValue GetAssessedCapacityValue()
	{
		return this.GetValue(TableUtils.AssessedCapacityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public Int32 GetAssessedCapacityFieldValue()
	{
		return this.GetValue(TableUtils.AssessedCapacityColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public void SetAssessedCapacityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AssessedCapacityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public void SetAssessedCapacityFieldValue(string val)
	{
		this.SetString(val, TableUtils.AssessedCapacityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public void SetAssessedCapacityFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AssessedCapacityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public void SetAssessedCapacityFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AssessedCapacityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public void SetAssessedCapacityFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AssessedCapacityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public ColumnValue GetWeatherStationIdValue()
	{
		return this.GetValue(TableUtils.WeatherStationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public Int32 GetWeatherStationIdFieldValue()
	{
		return this.GetValue(TableUtils.WeatherStationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public void SetWeatherStationIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.WeatherStationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public void SetWeatherStationIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.WeatherStationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public void SetWeatherStationIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.WeatherStationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public void SetWeatherStationIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.WeatherStationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public void SetWeatherStationIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.WeatherStationIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.NIWAStationTemperature field.
	/// </summary>
	public ColumnValue GetNIWAStationTemperatureValue()
	{
		return this.GetValue(TableUtils.NIWAStationTemperatureColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.NIWAStationTemperature field.
	/// </summary>
	public string GetNIWAStationTemperatureFieldValue()
	{
		return this.GetValue(TableUtils.NIWAStationTemperatureColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationTemperature field.
	/// </summary>
	public void SetNIWAStationTemperatureFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NIWAStationTemperatureColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationTemperature field.
	/// </summary>
	public void SetNIWAStationTemperatureFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NIWAStationTemperatureColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.NIWAStationRain field.
	/// </summary>
	public ColumnValue GetNIWAStationRainValue()
	{
		return this.GetValue(TableUtils.NIWAStationRainColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.NIWAStationRain field.
	/// </summary>
	public string GetNIWAStationRainFieldValue()
	{
		return this.GetValue(TableUtils.NIWAStationRainColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationRain field.
	/// </summary>
	public void SetNIWAStationRainFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NIWAStationRainColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationRain field.
	/// </summary>
	public void SetNIWAStationRainFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NIWAStationRainColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.NIWAStationSun field.
	/// </summary>
	public ColumnValue GetNIWAStationSunValue()
	{
		return this.GetValue(TableUtils.NIWAStationSunColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.NIWAStationSun field.
	/// </summary>
	public string GetNIWAStationSunFieldValue()
	{
		return this.GetValue(TableUtils.NIWAStationSunColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationSun field.
	/// </summary>
	public void SetNIWAStationSunFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NIWAStationSunColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationSun field.
	/// </summary>
	public void SetNIWAStationSunFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NIWAStationSunColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.ICPPOC field.
	/// </summary>
	public ColumnValue GetICPPOCValue()
	{
		return this.GetValue(TableUtils.ICPPOCColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.ICPPOC field.
	/// </summary>
	public string GetICPPOCFieldValue()
	{
		return this.GetValue(TableUtils.ICPPOCColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ICPPOC field.
	/// </summary>
	public void SetICPPOCFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ICPPOCColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ICPPOC field.
	/// </summary>
	public void SetICPPOCFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ICPPOCColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Reconcilliation_Type field.
	/// </summary>
	public ColumnValue GetReconcilliation_TypeValue()
	{
		return this.GetValue(TableUtils.Reconcilliation_TypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Reconcilliation_Type field.
	/// </summary>
	public string GetReconcilliation_TypeFieldValue()
	{
		return this.GetValue(TableUtils.Reconcilliation_TypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Reconcilliation_Type field.
	/// </summary>
	public void SetReconcilliation_TypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Reconcilliation_TypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Reconcilliation_Type field.
	/// </summary>
	public void SetReconcilliation_TypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Reconcilliation_TypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Price_Category field.
	/// </summary>
	public ColumnValue GetPrice_CategoryValue()
	{
		return this.GetValue(TableUtils.Price_CategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Price_Category field.
	/// </summary>
	public string GetPrice_CategoryFieldValue()
	{
		return this.GetValue(TableUtils.Price_CategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Price_Category field.
	/// </summary>
	public void SetPrice_CategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Price_CategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Price_Category field.
	/// </summary>
	public void SetPrice_CategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Price_CategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Loss_Category field.
	/// </summary>
	public ColumnValue GetLoss_CategoryValue()
	{
		return this.GetValue(TableUtils.Loss_CategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Loss_Category field.
	/// </summary>
	public string GetLoss_CategoryFieldValue()
	{
		return this.GetValue(TableUtils.Loss_CategoryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Loss_Category field.
	/// </summary>
	public void SetLoss_CategoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Loss_CategoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Loss_Category field.
	/// </summary>
	public void SetLoss_CategoryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Loss_CategoryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public ColumnValue GetChargable_CapacitoryValue()
	{
		return this.GetValue(TableUtils.Chargable_CapacitoryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public Decimal GetChargable_CapacitoryFieldValue()
	{
		return this.GetValue(TableUtils.Chargable_CapacitoryColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public void SetChargable_CapacitoryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Chargable_CapacitoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public void SetChargable_CapacitoryFieldValue(string val)
	{
		this.SetString(val, TableUtils.Chargable_CapacitoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public void SetChargable_CapacitoryFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Chargable_CapacitoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public void SetChargable_CapacitoryFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Chargable_CapacitoryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public void SetChargable_CapacitoryFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Chargable_CapacitoryColumn);
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
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.ConnectionNumber field.
	/// </summary>
	public string ConnectionNumber
	{
		get
		{
			return this.GetValue(TableUtils.ConnectionNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ConnectionNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ConnectionNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ConnectionNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ConnectionNumber field.
	/// </summary>
	public string ConnectionNumberDefault
	{
		get
		{
			return TableUtils.ConnectionNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public Int32 SiteId
	{
		get
		{
			return this.GetValue(TableUtils.SiteIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SiteIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SiteIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SiteIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SiteId field.
	/// </summary>
	public string SiteIdDefault
	{
		get
		{
			return TableUtils.SiteIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.SupplierId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.SupplierId field.
	/// </summary>
	public string SupplierIdDefault
	{
		get
		{
			return TableUtils.SupplierIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.LocationNotes field.
	/// </summary>
	public string LocationNotes
	{
		get
		{
			return this.GetValue(TableUtils.LocationNotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LocationNotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LocationNotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LocationNotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LocationNotes field.
	/// </summary>
	public string LocationNotesDefault
	{
		get
		{
			return TableUtils.LocationNotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public Int32 LinesCompanyId
	{
		get
		{
			return this.GetValue(TableUtils.LinesCompanyIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinesCompanyIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinesCompanyIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinesCompanyIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.LinesCompanyId field.
	/// </summary>
	public string LinesCompanyIdDefault
	{
		get
		{
			return TableUtils.LinesCompanyIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.MeterId field.
	/// </summary>
	public string MeterId
	{
		get
		{
			return this.GetValue(TableUtils.MeterIdColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeterIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeterIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeterIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeterId field.
	/// </summary>
	public string MeterIdDefault
	{
		get
		{
			return TableUtils.MeterIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.MeteringCompanyId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.MeteringCompanyId field.
	/// </summary>
	public string MeteringCompanyIdDefault
	{
		get
		{
			return TableUtils.MeteringCompanyIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.Enabled field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Enabled field.
	/// </summary>
	public string Enabled0Default
	{
		get
		{
			return TableUtils.Enabled0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public Int32 Phases
	{
		get
		{
			return this.GetValue(TableUtils.PhasesColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PhasesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PhasesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PhasesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Phases field.
	/// </summary>
	public string PhasesDefault
	{
		get
		{
			return TableUtils.PhasesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.GridExitPoint field.
	/// </summary>
	public string GridExitPoint
	{
		get
		{
			return this.GetValue(TableUtils.GridExitPointColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GridExitPointColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GridExitPointSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GridExitPointColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GridExitPoint field.
	/// </summary>
	public string GridExitPointDefault
	{
		get
		{
			return TableUtils.GridExitPointColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.GridExitPointRegion field.
	/// </summary>
	public string GridExitPointRegion
	{
		get
		{
			return this.GetValue(TableUtils.GridExitPointRegionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GridExitPointRegionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GridExitPointRegionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GridExitPointRegionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GridExitPointRegion field.
	/// </summary>
	public string GridExitPointRegionDefault
	{
		get
		{
			return TableUtils.GridExitPointRegionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.ConnectionType field.
	/// </summary>
	public string ConnectionType
	{
		get
		{
			return this.GetValue(TableUtils.ConnectionTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ConnectionTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ConnectionTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ConnectionTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ConnectionType field.
	/// </summary>
	public string ConnectionTypeDefault
	{
		get
		{
			return TableUtils.ConnectionTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.GLCode field.
	/// </summary>
	public string GLCode
	{
		get
		{
			return this.GetValue(TableUtils.GLCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GLCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GLCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GLCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.GLCode field.
	/// </summary>
	public string GLCodeDefault
	{
		get
		{
			return TableUtils.GLCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public Int32 AssessedCapacity
	{
		get
		{
			return this.GetValue(TableUtils.AssessedCapacityColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AssessedCapacityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AssessedCapacitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AssessedCapacityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.AssessedCapacity field.
	/// </summary>
	public string AssessedCapacityDefault
	{
		get
		{
			return TableUtils.AssessedCapacityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public Int32 WeatherStationId
	{
		get
		{
			return this.GetValue(TableUtils.WeatherStationIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.WeatherStationIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool WeatherStationIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.WeatherStationIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.WeatherStationId field.
	/// </summary>
	public string WeatherStationIdDefault
	{
		get
		{
			return TableUtils.WeatherStationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.NIWAStationTemperature field.
	/// </summary>
	public string NIWAStationTemperature
	{
		get
		{
			return this.GetValue(TableUtils.NIWAStationTemperatureColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NIWAStationTemperatureColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NIWAStationTemperatureSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NIWAStationTemperatureColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationTemperature field.
	/// </summary>
	public string NIWAStationTemperatureDefault
	{
		get
		{
			return TableUtils.NIWAStationTemperatureColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.NIWAStationRain field.
	/// </summary>
	public string NIWAStationRain
	{
		get
		{
			return this.GetValue(TableUtils.NIWAStationRainColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NIWAStationRainColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NIWAStationRainSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NIWAStationRainColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationRain field.
	/// </summary>
	public string NIWAStationRainDefault
	{
		get
		{
			return TableUtils.NIWAStationRainColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.NIWAStationSun field.
	/// </summary>
	public string NIWAStationSun
	{
		get
		{
			return this.GetValue(TableUtils.NIWAStationSunColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NIWAStationSunColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NIWAStationSunSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NIWAStationSunColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.NIWAStationSun field.
	/// </summary>
	public string NIWAStationSunDefault
	{
		get
		{
			return TableUtils.NIWAStationSunColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.ICPPOC field.
	/// </summary>
	public string ICPPOC
	{
		get
		{
			return this.GetValue(TableUtils.ICPPOCColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ICPPOCColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ICPPOCSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ICPPOCColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.ICPPOC field.
	/// </summary>
	public string ICPPOCDefault
	{
		get
		{
			return TableUtils.ICPPOCColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.Reconcilliation_Type field.
	/// </summary>
	public string Reconcilliation_Type
	{
		get
		{
			return this.GetValue(TableUtils.Reconcilliation_TypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Reconcilliation_TypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Reconcilliation_TypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Reconcilliation_TypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Reconcilliation_Type field.
	/// </summary>
	public string Reconcilliation_TypeDefault
	{
		get
		{
			return TableUtils.Reconcilliation_TypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.Price_Category field.
	/// </summary>
	public string Price_Category
	{
		get
		{
			return this.GetValue(TableUtils.Price_CategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Price_CategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Price_CategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Price_CategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Price_Category field.
	/// </summary>
	public string Price_CategoryDefault
	{
		get
		{
			return TableUtils.Price_CategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.Loss_Category field.
	/// </summary>
	public string Loss_Category
	{
		get
		{
			return this.GetValue(TableUtils.Loss_CategoryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Loss_CategoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Loss_CategorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Loss_CategoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Loss_Category field.
	/// </summary>
	public string Loss_CategoryDefault
	{
		get
		{
			return TableUtils.Loss_CategoryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public Decimal Chargable_Capacitory
	{
		get
		{
			return this.GetValue(TableUtils.Chargable_CapacitoryColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Chargable_CapacitoryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Chargable_CapacitorySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Chargable_CapacitoryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergyPoints_.Chargable_Capacitory field.
	/// </summary>
	public string Chargable_CapacitoryDefault
	{
		get
		{
			return TableUtils.Chargable_CapacitoryColumn.DefaultValue;
		}
	}


#endregion
}

}
