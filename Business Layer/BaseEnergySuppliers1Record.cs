// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergySuppliers1Record.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="EnergySuppliers1Record"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="EnergySuppliers1Table"></see> class.
/// </remarks>
/// <seealso cref="EnergySuppliers1Table"></seealso>
/// <seealso cref="EnergySuppliers1Record"></seealso>
public class BaseEnergySuppliers1Record : PrimaryKeyRecord
{

	public readonly static EnergySuppliers1Table TableUtils = EnergySuppliers1Table.Instance;

	// Constructors
 
	protected BaseEnergySuppliers1Record() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.EnergySuppliers1Record_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.EnergySuppliers1Record_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.EnergySuppliers1Record_ReadRecord); 
	}

	protected BaseEnergySuppliers1Record(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void EnergySuppliers1Record_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                EnergySuppliers1Record EnergySuppliers1Rec = (EnergySuppliers1Record)sender;
        if(EnergySuppliers1Rec != null && !EnergySuppliers1Rec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void EnergySuppliers1Record_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                EnergySuppliers1Record EnergySuppliers1Rec = (EnergySuppliers1Record)sender;
        Validate_Inserting();
        if(EnergySuppliers1Rec != null && !EnergySuppliers1Rec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void EnergySuppliers1Record_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                EnergySuppliers1Record EnergySuppliers1Rec = (EnergySuppliers1Record)sender;
        Validate_Updating();
        if(EnergySuppliers1Rec != null && !EnergySuppliers1Rec.IsReadOnly ){
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
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplierLogo field.
	/// </summary>
	public ColumnValue GetSupplierLogoValue()
	{
		return this.GetValue(TableUtils.SupplierLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplierLogo field.
	/// </summary>
	public string GetSupplierLogoFieldValue()
	{
		return this.GetValue(TableUtils.SupplierLogoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplierLogo field.
	/// </summary>
	public void SetSupplierLogoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SupplierLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplierLogo field.
	/// </summary>
	public void SetSupplierLogoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplierLogoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplyElectricity field.
	/// </summary>
	public ColumnValue GetSupplyElectricityValue()
	{
		return this.GetValue(TableUtils.SupplyElectricityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplyElectricity field.
	/// </summary>
	public bool GetSupplyElectricityFieldValue()
	{
		return this.GetValue(TableUtils.SupplyElectricityColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyElectricity field.
	/// </summary>
	public void SetSupplyElectricityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SupplyElectricityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyElectricity field.
	/// </summary>
	public void SetSupplyElectricityFieldValue(string val)
	{
		this.SetString(val, TableUtils.SupplyElectricityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyElectricity field.
	/// </summary>
	public void SetSupplyElectricityFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplyElectricityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplyGas field.
	/// </summary>
	public ColumnValue GetSupplyGasValue()
	{
		return this.GetValue(TableUtils.SupplyGasColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplyGas field.
	/// </summary>
	public bool GetSupplyGasFieldValue()
	{
		return this.GetValue(TableUtils.SupplyGasColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyGas field.
	/// </summary>
	public void SetSupplyGasFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SupplyGasColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyGas field.
	/// </summary>
	public void SetSupplyGasFieldValue(string val)
	{
		this.SetString(val, TableUtils.SupplyGasColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyGas field.
	/// </summary>
	public void SetSupplyGasFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplyGasColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplyOther field.
	/// </summary>
	public ColumnValue GetSupplyOtherValue()
	{
		return this.GetValue(TableUtils.SupplyOtherColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.SupplyOther field.
	/// </summary>
	public bool GetSupplyOtherFieldValue()
	{
		return this.GetValue(TableUtils.SupplyOtherColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyOther field.
	/// </summary>
	public void SetSupplyOtherFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SupplyOtherColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyOther field.
	/// </summary>
	public void SetSupplyOtherFieldValue(string val)
	{
		this.SetString(val, TableUtils.SupplyOtherColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyOther field.
	/// </summary>
	public void SetSupplyOtherFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SupplyOtherColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.City field.
	/// </summary>
	public ColumnValue GetCityValue()
	{
		return this.GetValue(TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.City field.
	/// </summary>
	public string GetCityFieldValue()
	{
		return this.GetValue(TableUtils.CityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.City field.
	/// </summary>
	public void SetCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.City field.
	/// </summary>
	public void SetCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Phone field.
	/// </summary>
	public ColumnValue GetPhoneValue()
	{
		return this.GetValue(TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Phone field.
	/// </summary>
	public string GetPhoneFieldValue()
	{
		return this.GetValue(TableUtils.PhoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Phone field.
	/// </summary>
	public void SetPhoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Contact field.
	/// </summary>
	public ColumnValue GetContactValue()
	{
		return this.GetValue(TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Contact field.
	/// </summary>
	public string GetContactFieldValue()
	{
		return this.GetValue(TableUtils.ContactColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Contact field.
	/// </summary>
	public void SetContactFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Contact field.
	/// </summary>
	public void SetContactFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public ColumnValue GetNetworkVariableNBDRateValue()
	{
		return this.GetValue(TableUtils.NetworkVariableNBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public Decimal GetNetworkVariableNBDRateFieldValue()
	{
		return this.GetValue(TableUtils.NetworkVariableNBDRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public void SetNetworkVariableNBDRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkVariableNBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public void SetNetworkVariableNBDRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkVariableNBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public void SetNetworkVariableNBDRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableNBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public void SetNetworkVariableNBDRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableNBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public void SetNetworkVariableNBDRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableNBDRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public ColumnValue GetNetworkVariableBDRateValue()
	{
		return this.GetValue(TableUtils.NetworkVariableBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public Decimal GetNetworkVariableBDRateFieldValue()
	{
		return this.GetValue(TableUtils.NetworkVariableBDRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public void SetNetworkVariableBDRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkVariableBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public void SetNetworkVariableBDRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkVariableBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public void SetNetworkVariableBDRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public void SetNetworkVariableBDRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableBDRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public void SetNetworkVariableBDRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableBDRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Enabled field.
	/// </summary>
	public ColumnValue GetEnabled0Value()
	{
		return this.GetValue(TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.Enabled field.
	/// </summary>
	public bool GetEnabled0FieldValue()
	{
		return this.GetValue(TableUtils.Enabled0Column).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Enabled0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Enabled field.
	/// </summary>
	public void SetEnabled0FieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Enabled0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public ColumnValue GetLogoHeightValue()
	{
		return this.GetValue(TableUtils.LogoHeightColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public Int32 GetLogoHeightFieldValue()
	{
		return this.GetValue(TableUtils.LogoHeightColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public void SetLogoHeightFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LogoHeightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public void SetLogoHeightFieldValue(string val)
	{
		this.SetString(val, TableUtils.LogoHeightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public void SetLogoHeightFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LogoHeightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public void SetLogoHeightFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LogoHeightColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public void SetLogoHeightFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LogoHeightColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public ColumnValue GetLogoWidthValue()
	{
		return this.GetValue(TableUtils.LogoWidthColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public Int32 GetLogoWidthFieldValue()
	{
		return this.GetValue(TableUtils.LogoWidthColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public void SetLogoWidthFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LogoWidthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public void SetLogoWidthFieldValue(string val)
	{
		this.SetString(val, TableUtils.LogoWidthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public void SetLogoWidthFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LogoWidthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public void SetLogoWidthFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LogoWidthColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public void SetLogoWidthFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LogoWidthColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public ColumnValue GetNetworkDemandRateValue()
	{
		return this.GetValue(TableUtils.NetworkDemandRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public Decimal GetNetworkDemandRateFieldValue()
	{
		return this.GetValue(TableUtils.NetworkDemandRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public void SetNetworkDemandRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkDemandRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public void SetNetworkDemandRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkDemandRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public void SetNetworkDemandRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkDemandRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public void SetNetworkDemandRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkDemandRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public void SetNetworkDemandRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkDemandRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public ColumnValue GetNetworkCapacityRateValue()
	{
		return this.GetValue(TableUtils.NetworkCapacityRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public Decimal GetNetworkCapacityRateFieldValue()
	{
		return this.GetValue(TableUtils.NetworkCapacityRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public void SetNetworkCapacityRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkCapacityRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public void SetNetworkCapacityRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkCapacityRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public void SetNetworkCapacityRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkCapacityRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public void SetNetworkCapacityRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkCapacityRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public void SetNetworkCapacityRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkCapacityRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public ColumnValue GetNetworkFixedRateValue()
	{
		return this.GetValue(TableUtils.NetworkFixedRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public Decimal GetNetworkFixedRateFieldValue()
	{
		return this.GetValue(TableUtils.NetworkFixedRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public void SetNetworkFixedRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkFixedRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public void SetNetworkFixedRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkFixedRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public void SetNetworkFixedRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkFixedRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public void SetNetworkFixedRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkFixedRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public void SetNetworkFixedRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkFixedRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public ColumnValue GetNetworkVariableRateValue()
	{
		return this.GetValue(TableUtils.NetworkVariableRateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public Decimal GetNetworkVariableRateFieldValue()
	{
		return this.GetValue(TableUtils.NetworkVariableRateColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public void SetNetworkVariableRateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NetworkVariableRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public void SetNetworkVariableRateFieldValue(string val)
	{
		this.SetString(val, TableUtils.NetworkVariableRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public void SetNetworkVariableRateFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public void SetNetworkVariableRateFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableRateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public void SetNetworkVariableRateFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NetworkVariableRateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public ColumnValue GetOtherAdministrationChargeValue()
	{
		return this.GetValue(TableUtils.OtherAdministrationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public Decimal GetOtherAdministrationChargeFieldValue()
	{
		return this.GetValue(TableUtils.OtherAdministrationChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public void SetOtherAdministrationChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OtherAdministrationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public void SetOtherAdministrationChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.OtherAdministrationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public void SetOtherAdministrationChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherAdministrationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public void SetOtherAdministrationChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherAdministrationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public void SetOtherAdministrationChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherAdministrationChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public ColumnValue GetOtherCTMonthlyFeeValue()
	{
		return this.GetValue(TableUtils.OtherCTMonthlyFeeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public Decimal GetOtherCTMonthlyFeeFieldValue()
	{
		return this.GetValue(TableUtils.OtherCTMonthlyFeeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public void SetOtherCTMonthlyFeeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OtherCTMonthlyFeeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public void SetOtherCTMonthlyFeeFieldValue(string val)
	{
		this.SetString(val, TableUtils.OtherCTMonthlyFeeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public void SetOtherCTMonthlyFeeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherCTMonthlyFeeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public void SetOtherCTMonthlyFeeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherCTMonthlyFeeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public void SetOtherCTMonthlyFeeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherCTMonthlyFeeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public ColumnValue GetOtherDataReconciliationChargeValue()
	{
		return this.GetValue(TableUtils.OtherDataReconciliationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public Decimal GetOtherDataReconciliationChargeFieldValue()
	{
		return this.GetValue(TableUtils.OtherDataReconciliationChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public void SetOtherDataReconciliationChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OtherDataReconciliationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public void SetOtherDataReconciliationChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.OtherDataReconciliationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public void SetOtherDataReconciliationChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherDataReconciliationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public void SetOtherDataReconciliationChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherDataReconciliationChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public void SetOtherDataReconciliationChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherDataReconciliationChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public ColumnValue GetOtherECCALevyChargeValue()
	{
		return this.GetValue(TableUtils.OtherECCALevyChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public Decimal GetOtherECCALevyChargeFieldValue()
	{
		return this.GetValue(TableUtils.OtherECCALevyChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public void SetOtherECCALevyChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OtherECCALevyChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public void SetOtherECCALevyChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.OtherECCALevyChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public void SetOtherECCALevyChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherECCALevyChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public void SetOtherECCALevyChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherECCALevyChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public void SetOtherECCALevyChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherECCALevyChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public ColumnValue GetOtherMeterRentalChargeValue()
	{
		return this.GetValue(TableUtils.OtherMeterRentalChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public Decimal GetOtherMeterRentalChargeFieldValue()
	{
		return this.GetValue(TableUtils.OtherMeterRentalChargeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public void SetOtherMeterRentalChargeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OtherMeterRentalChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public void SetOtherMeterRentalChargeFieldValue(string val)
	{
		this.SetString(val, TableUtils.OtherMeterRentalChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public void SetOtherMeterRentalChargeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherMeterRentalChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public void SetOtherMeterRentalChargeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherMeterRentalChargeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public void SetOtherMeterRentalChargeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OtherMeterRentalChargeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public ColumnValue GetEnergyServicesRateNBDValue()
	{
		return this.GetValue(TableUtils.EnergyServicesRateNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public Decimal GetEnergyServicesRateNBDFieldValue()
	{
		return this.GetValue(TableUtils.EnergyServicesRateNBDColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public void SetEnergyServicesRateNBDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EnergyServicesRateNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public void SetEnergyServicesRateNBDFieldValue(string val)
	{
		this.SetString(val, TableUtils.EnergyServicesRateNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public void SetEnergyServicesRateNBDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyServicesRateNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public void SetEnergyServicesRateNBDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyServicesRateNBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public void SetEnergyServicesRateNBDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyServicesRateNBDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public ColumnValue GetEnergyServicesRateBDValue()
	{
		return this.GetValue(TableUtils.EnergyServicesRateBDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public Decimal GetEnergyServicesRateBDFieldValue()
	{
		return this.GetValue(TableUtils.EnergyServicesRateBDColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public void SetEnergyServicesRateBDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EnergyServicesRateBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public void SetEnergyServicesRateBDFieldValue(string val)
	{
		this.SetString(val, TableUtils.EnergyServicesRateBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public void SetEnergyServicesRateBDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyServicesRateBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public void SetEnergyServicesRateBDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyServicesRateBDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public void SetEnergyServicesRateBDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EnergyServicesRateBDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.ShortName field.
	/// </summary>
	public ColumnValue GetShortNameValue()
	{
		return this.GetValue(TableUtils.ShortNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's EnergySuppliers_.ShortName field.
	/// </summary>
	public string GetShortNameFieldValue()
	{
		return this.GetValue(TableUtils.ShortNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.ShortName field.
	/// </summary>
	public void SetShortNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ShortNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.ShortName field.
	/// </summary>
	public void SetShortNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ShortNameColumn);
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
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.SupplierLogo field.
	/// </summary>
	public string SupplierLogo
	{
		get
		{
			return this.GetValue(TableUtils.SupplierLogoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SupplierLogoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SupplierLogoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SupplierLogoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplierLogo field.
	/// </summary>
	public string SupplierLogoDefault
	{
		get
		{
			return TableUtils.SupplierLogoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.SupplyElectricity field.
	/// </summary>
	public bool SupplyElectricity
	{
		get
		{
			return this.GetValue(TableUtils.SupplyElectricityColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.SupplyElectricityColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SupplyElectricitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SupplyElectricityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyElectricity field.
	/// </summary>
	public string SupplyElectricityDefault
	{
		get
		{
			return TableUtils.SupplyElectricityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.SupplyGas field.
	/// </summary>
	public bool SupplyGas
	{
		get
		{
			return this.GetValue(TableUtils.SupplyGasColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.SupplyGasColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SupplyGasSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SupplyGasColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyGas field.
	/// </summary>
	public string SupplyGasDefault
	{
		get
		{
			return TableUtils.SupplyGasColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.SupplyOther field.
	/// </summary>
	public bool SupplyOther
	{
		get
		{
			return this.GetValue(TableUtils.SupplyOtherColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.SupplyOtherColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SupplyOtherSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SupplyOtherColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.SupplyOther field.
	/// </summary>
	public string SupplyOtherDefault
	{
		get
		{
			return TableUtils.SupplyOtherColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.City field.
	/// </summary>
	public string City
	{
		get
		{
			return this.GetValue(TableUtils.CityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.City field.
	/// </summary>
	public string CityDefault
	{
		get
		{
			return TableUtils.CityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.Phone field.
	/// </summary>
	public string Phone
	{
		get
		{
			return this.GetValue(TableUtils.PhoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PhoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PhoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PhoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Phone field.
	/// </summary>
	public string PhoneDefault
	{
		get
		{
			return TableUtils.PhoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.Contact field.
	/// </summary>
	public string Contact
	{
		get
		{
			return this.GetValue(TableUtils.ContactColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Contact field.
	/// </summary>
	public string ContactDefault
	{
		get
		{
			return TableUtils.ContactColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.eMail field.
	/// </summary>
	public string eMail
	{
		get
		{
			return this.GetValue(TableUtils.eMailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.eMailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool eMailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.eMailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public Decimal NetworkVariableNBDRate
	{
		get
		{
			return this.GetValue(TableUtils.NetworkVariableNBDRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkVariableNBDRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkVariableNBDRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkVariableNBDRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableNBDRate field.
	/// </summary>
	public string NetworkVariableNBDRateDefault
	{
		get
		{
			return TableUtils.NetworkVariableNBDRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public Decimal NetworkVariableBDRate
	{
		get
		{
			return this.GetValue(TableUtils.NetworkVariableBDRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkVariableBDRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkVariableBDRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkVariableBDRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableBDRate field.
	/// </summary>
	public string NetworkVariableBDRateDefault
	{
		get
		{
			return TableUtils.NetworkVariableBDRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.Enabled field.
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
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.Enabled field.
	/// </summary>
	public string Enabled0Default
	{
		get
		{
			return TableUtils.Enabled0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public Int32 LogoHeight
	{
		get
		{
			return this.GetValue(TableUtils.LogoHeightColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LogoHeightColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LogoHeightSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LogoHeightColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoHeight field.
	/// </summary>
	public string LogoHeightDefault
	{
		get
		{
			return TableUtils.LogoHeightColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public Int32 LogoWidth
	{
		get
		{
			return this.GetValue(TableUtils.LogoWidthColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LogoWidthColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LogoWidthSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LogoWidthColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.LogoWidth field.
	/// </summary>
	public string LogoWidthDefault
	{
		get
		{
			return TableUtils.LogoWidthColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public Decimal NetworkDemandRate
	{
		get
		{
			return this.GetValue(TableUtils.NetworkDemandRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkDemandRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkDemandRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkDemandRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkDemandRate field.
	/// </summary>
	public string NetworkDemandRateDefault
	{
		get
		{
			return TableUtils.NetworkDemandRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public Decimal NetworkCapacityRate
	{
		get
		{
			return this.GetValue(TableUtils.NetworkCapacityRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkCapacityRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkCapacityRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkCapacityRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkCapacityRate field.
	/// </summary>
	public string NetworkCapacityRateDefault
	{
		get
		{
			return TableUtils.NetworkCapacityRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public Decimal NetworkFixedRate
	{
		get
		{
			return this.GetValue(TableUtils.NetworkFixedRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkFixedRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkFixedRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkFixedRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkFixedRate field.
	/// </summary>
	public string NetworkFixedRateDefault
	{
		get
		{
			return TableUtils.NetworkFixedRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public Decimal NetworkVariableRate
	{
		get
		{
			return this.GetValue(TableUtils.NetworkVariableRateColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NetworkVariableRateColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NetworkVariableRateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NetworkVariableRateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.NetworkVariableRate field.
	/// </summary>
	public string NetworkVariableRateDefault
	{
		get
		{
			return TableUtils.NetworkVariableRateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public Decimal OtherAdministrationCharge
	{
		get
		{
			return this.GetValue(TableUtils.OtherAdministrationChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OtherAdministrationChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OtherAdministrationChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OtherAdministrationChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherAdministrationCharge field.
	/// </summary>
	public string OtherAdministrationChargeDefault
	{
		get
		{
			return TableUtils.OtherAdministrationChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public Decimal OtherCTMonthlyFee
	{
		get
		{
			return this.GetValue(TableUtils.OtherCTMonthlyFeeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OtherCTMonthlyFeeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OtherCTMonthlyFeeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OtherCTMonthlyFeeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherCTMonthlyFee field.
	/// </summary>
	public string OtherCTMonthlyFeeDefault
	{
		get
		{
			return TableUtils.OtherCTMonthlyFeeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public Decimal OtherDataReconciliationCharge
	{
		get
		{
			return this.GetValue(TableUtils.OtherDataReconciliationChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OtherDataReconciliationChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OtherDataReconciliationChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OtherDataReconciliationChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherDataReconciliationCharge field.
	/// </summary>
	public string OtherDataReconciliationChargeDefault
	{
		get
		{
			return TableUtils.OtherDataReconciliationChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public Decimal OtherECCALevyCharge
	{
		get
		{
			return this.GetValue(TableUtils.OtherECCALevyChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OtherECCALevyChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OtherECCALevyChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OtherECCALevyChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherECCALevyCharge field.
	/// </summary>
	public string OtherECCALevyChargeDefault
	{
		get
		{
			return TableUtils.OtherECCALevyChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public Decimal OtherMeterRentalCharge
	{
		get
		{
			return this.GetValue(TableUtils.OtherMeterRentalChargeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OtherMeterRentalChargeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OtherMeterRentalChargeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OtherMeterRentalChargeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.OtherMeterRentalCharge field.
	/// </summary>
	public string OtherMeterRentalChargeDefault
	{
		get
		{
			return TableUtils.OtherMeterRentalChargeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public Decimal EnergyServicesRateNBD
	{
		get
		{
			return this.GetValue(TableUtils.EnergyServicesRateNBDColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EnergyServicesRateNBDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EnergyServicesRateNBDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EnergyServicesRateNBDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateNBD field.
	/// </summary>
	public string EnergyServicesRateNBDDefault
	{
		get
		{
			return TableUtils.EnergyServicesRateNBDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public Decimal EnergyServicesRateBD
	{
		get
		{
			return this.GetValue(TableUtils.EnergyServicesRateBDColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EnergyServicesRateBDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EnergyServicesRateBDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EnergyServicesRateBDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.EnergyServicesRateBD field.
	/// </summary>
	public string EnergyServicesRateBDDefault
	{
		get
		{
			return TableUtils.EnergyServicesRateBDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's EnergySuppliers_.ShortName field.
	/// </summary>
	public string ShortName
	{
		get
		{
			return this.GetValue(TableUtils.ShortNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ShortNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ShortNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ShortNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's EnergySuppliers_.ShortName field.
	/// </summary>
	public string ShortNameDefault
	{
		get
		{
			return TableUtils.ShortNameColumn.DefaultValue;
		}
	}


#endregion
}

}
