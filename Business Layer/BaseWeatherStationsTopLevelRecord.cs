// This class is "generated" and will be overwritten.
// Your customizations should be made in WeatherStationsTopLevelRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="WeatherStationsTopLevelRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="WeatherStationsTopLevelTable"></see> class.
/// </remarks>
/// <seealso cref="WeatherStationsTopLevelTable"></seealso>
/// <seealso cref="WeatherStationsTopLevelRecord"></seealso>
public class BaseWeatherStationsTopLevelRecord : PrimaryKeyRecord
{

	public readonly static WeatherStationsTopLevelTable TableUtils = WeatherStationsTopLevelTable.Instance;

	// Constructors
 
	protected BaseWeatherStationsTopLevelRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.WeatherStationsTopLevelRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.WeatherStationsTopLevelRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.WeatherStationsTopLevelRecord_ReadRecord); 
	}

	protected BaseWeatherStationsTopLevelRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void WeatherStationsTopLevelRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                WeatherStationsTopLevelRecord WeatherStationsTopLevelRec = (WeatherStationsTopLevelRecord)sender;
        if(WeatherStationsTopLevelRec != null && !WeatherStationsTopLevelRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void WeatherStationsTopLevelRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                WeatherStationsTopLevelRecord WeatherStationsTopLevelRec = (WeatherStationsTopLevelRecord)sender;
        Validate_Inserting();
        if(WeatherStationsTopLevelRec != null && !WeatherStationsTopLevelRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void WeatherStationsTopLevelRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                WeatherStationsTopLevelRecord WeatherStationsTopLevelRec = (WeatherStationsTopLevelRecord)sender;
        Validate_Updating();
        if(WeatherStationsTopLevelRec != null && !WeatherStationsTopLevelRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.StationId field.
	/// </summary>
	public ColumnValue GetStationIdValue()
	{
		return this.GetValue(TableUtils.StationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.StationId field.
	/// </summary>
	public Int32 GetStationIdFieldValue()
	{
		return this.GetValue(TableUtils.StationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.Latitude field.
	/// </summary>
	public ColumnValue GetLatitudeValue()
	{
		return this.GetValue(TableUtils.LatitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.Latitude field.
	/// </summary>
	public string GetLatitudeFieldValue()
	{
		return this.GetValue(TableUtils.LatitudeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Latitude field.
	/// </summary>
	public void SetLatitudeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LatitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Latitude field.
	/// </summary>
	public void SetLatitudeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatitudeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.Longtude field.
	/// </summary>
	public ColumnValue GetLongtudeValue()
	{
		return this.GetValue(TableUtils.LongtudeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.Longtude field.
	/// </summary>
	public string GetLongtudeFieldValue()
	{
		return this.GetValue(TableUtils.LongtudeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Longtude field.
	/// </summary>
	public void SetLongtudeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LongtudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Longtude field.
	/// </summary>
	public void SetLongtudeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LongtudeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.Location field.
	/// </summary>
	public ColumnValue GetLocationValue()
	{
		return this.GetValue(TableUtils.LocationColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's WeatherStationsTopLevel_.Location field.
	/// </summary>
	public string GetLocationFieldValue()
	{
		return this.GetValue(TableUtils.LocationColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Location field.
	/// </summary>
	public void SetLocationFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LocationColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Location field.
	/// </summary>
	public void SetLocationFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's WeatherStationsTopLevel_.StationId field.
	/// </summary>
	public Int32 StationId
	{
		get
		{
			return this.GetValue(TableUtils.StationIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.StationIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool StationIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.StationIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.StationId field.
	/// </summary>
	public string StationIdDefault
	{
		get
		{
			return TableUtils.StationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WeatherStationsTopLevel_.Latitude field.
	/// </summary>
	public string Latitude
	{
		get
		{
			return this.GetValue(TableUtils.LatitudeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LatitudeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LatitudeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LatitudeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Latitude field.
	/// </summary>
	public string LatitudeDefault
	{
		get
		{
			return TableUtils.LatitudeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WeatherStationsTopLevel_.Longtude field.
	/// </summary>
	public string Longtude
	{
		get
		{
			return this.GetValue(TableUtils.LongtudeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LongtudeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LongtudeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LongtudeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Longtude field.
	/// </summary>
	public string LongtudeDefault
	{
		get
		{
			return TableUtils.LongtudeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's WeatherStationsTopLevel_.Location field.
	/// </summary>
	public string Location
	{
		get
		{
			return this.GetValue(TableUtils.LocationColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LocationColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LocationSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LocationColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's WeatherStationsTopLevel_.Location field.
	/// </summary>
	public string LocationDefault
	{
		get
		{
			return TableUtils.LocationColumn.DefaultValue;
		}
	}


#endregion
}

}
