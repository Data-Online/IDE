// This class is "generated" and will be overwritten.
// Your customizations should be made in SitesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="SitesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SitesTable"></see> class.
/// </remarks>
/// <seealso cref="SitesTable"></seealso>
/// <seealso cref="SitesRecord"></seealso>
public class BaseSitesRecord : PrimaryKeyRecord
{

	public readonly static SitesTable TableUtils = SitesTable.Instance;

	// Constructors
 
	protected BaseSitesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.SitesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.SitesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.SitesRecord_ReadRecord); 
	}

	protected BaseSitesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void SitesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                SitesRecord SitesRec = (SitesRecord)sender;
        if(SitesRec != null && !SitesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void SitesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                SitesRecord SitesRec = (SitesRecord)sender;
        Validate_Inserting();
        if(SitesRec != null && !SitesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void SitesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                SitesRecord SitesRec = (SitesRecord)sender;
        Validate_Updating();
        if(SitesRec != null && !SitesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteId field.
	/// </summary>
	public ColumnValue GetSiteIdValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteId field.
	/// </summary>
	public Int32 GetSiteIdFieldValue()
	{
		return this.GetValue(TableUtils.SiteIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteName field.
	/// </summary>
	public ColumnValue GetSiteNameValue()
	{
		return this.GetValue(TableUtils.SiteNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.SiteName field.
	/// </summary>
	public string GetSiteNameFieldValue()
	{
		return this.GetValue(TableUtils.SiteNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteName field.
	/// </summary>
	public void SetSiteNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiteNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteName field.
	/// </summary>
	public void SetSiteNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiteNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CustomerId field.
	/// </summary>
	public ColumnValue GetCustomerIdValue()
	{
		return this.GetValue(TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.CustomerId field.
	/// </summary>
	public Int32 GetCustomerIdFieldValue()
	{
		return this.GetValue(TableUtils.CustomerIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public void SetCustomerIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CustomerIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public ColumnValue GetTotalFloorSpaceSqMetersValue()
	{
		return this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public Int32 GetTotalFloorSpaceSqMetersFieldValue()
	{
		return this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(string val)
	{
		this.SetString(val, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public void SetTotalFloorSpaceSqMetersFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public ColumnValue GetLandSqMetersValue()
	{
		return this.GetValue(TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public Int32 GetLandSqMetersFieldValue()
	{
		return this.GetValue(TableUtils.LandSqMetersColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(string val)
	{
		this.SetString(val, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LandSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public void SetLandSqMetersFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LandSqMetersColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public ColumnValue GetProductiveFloorSpaceSqMetersValue()
	{
		return this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public Int32 GetProductiveFloorSpaceSqMetersFieldValue()
	{
		return this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public void SetProductiveFloorSpaceSqMetersFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public ColumnValue GetGroupDivisionIdValue()
	{
		return this.GetValue(TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public Int32 GetGroupDivisionIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupDivisionIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public void SetGroupDivisionIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.IndustryId field.
	/// </summary>
	public ColumnValue GetIndustryIdValue()
	{
		return this.GetValue(TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.IndustryId field.
	/// </summary>
	public Int32 GetIndustryIdFieldValue()
	{
		return this.GetValue(TableUtils.IndustryIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IndustryIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public void SetIndustryIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IndustryIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public ColumnValue GetFiledInvoiceCountValue()
	{
		return this.GetValue(TableUtils.FiledInvoiceCountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public Int32 GetFiledInvoiceCountFieldValue()
	{
		return this.GetValue(TableUtils.FiledInvoiceCountColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public void SetFiledInvoiceCountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FiledInvoiceCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public void SetFiledInvoiceCountFieldValue(string val)
	{
		this.SetString(val, TableUtils.FiledInvoiceCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public void SetFiledInvoiceCountFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FiledInvoiceCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public void SetFiledInvoiceCountFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FiledInvoiceCountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public void SetFiledInvoiceCountFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FiledInvoiceCountColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.SiteId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteId field.
	/// </summary>
	public string SiteIdDefault
	{
		get
		{
			return TableUtils.SiteIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.SiteName field.
	/// </summary>
	public string SiteName
	{
		get
		{
			return this.GetValue(TableUtils.SiteNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SiteNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SiteNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SiteNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.SiteName field.
	/// </summary>
	public string SiteNameDefault
	{
		get
		{
			return TableUtils.SiteNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.GroupId field.
	/// </summary>
	public Int32 GroupId
	{
		get
		{
			return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GroupIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GroupIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GroupIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.CustomerId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.CustomerId field.
	/// </summary>
	public string CustomerIdDefault
	{
		get
		{
			return TableUtils.CustomerIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public Int32 TotalFloorSpaceSqMeters
	{
		get
		{
			return this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TotalFloorSpaceSqMetersColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TotalFloorSpaceSqMetersSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TotalFloorSpaceSqMetersColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.TotalFloorSpaceSqMeters field.
	/// </summary>
	public string TotalFloorSpaceSqMetersDefault
	{
		get
		{
			return TableUtils.TotalFloorSpaceSqMetersColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public Int32 LandSqMeters
	{
		get
		{
			return this.GetValue(TableUtils.LandSqMetersColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LandSqMetersColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LandSqMetersSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LandSqMetersColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.LandSqMeters field.
	/// </summary>
	public string LandSqMetersDefault
	{
		get
		{
			return TableUtils.LandSqMetersColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public Int32 ProductiveFloorSpaceSqMeters
	{
		get
		{
			return this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProductiveFloorSpaceSqMetersColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProductiveFloorSpaceSqMetersSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProductiveFloorSpaceSqMetersColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.ProductiveFloorSpaceSqMeters field.
	/// </summary>
	public string ProductiveFloorSpaceSqMetersDefault
	{
		get
		{
			return TableUtils.ProductiveFloorSpaceSqMetersColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public Int32 GroupDivisionId
	{
		get
		{
			return this.GetValue(TableUtils.GroupDivisionIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GroupDivisionIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GroupDivisionIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GroupDivisionIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.GroupDivisionId field.
	/// </summary>
	public string GroupDivisionIdDefault
	{
		get
		{
			return TableUtils.GroupDivisionIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.IndustryId field.
	/// </summary>
	public Int32 IndustryId
	{
		get
		{
			return this.GetValue(TableUtils.IndustryIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IndustryIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IndustryIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IndustryIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.IndustryId field.
	/// </summary>
	public string IndustryIdDefault
	{
		get
		{
			return TableUtils.IndustryIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public Int32 FiledInvoiceCount
	{
		get
		{
			return this.GetValue(TableUtils.FiledInvoiceCountColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FiledInvoiceCountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FiledInvoiceCountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FiledInvoiceCountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sites_.FiledInvoiceCount field.
	/// </summary>
	public string FiledInvoiceCountDefault
	{
		get
		{
			return TableUtils.FiledInvoiceCountColumn.DefaultValue;
		}
	}


#endregion
}

}
