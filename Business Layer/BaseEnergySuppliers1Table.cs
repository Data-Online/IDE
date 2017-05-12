// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergySuppliers1Table.cs


using System;
using System.Data;
using System.Collections;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using IDE.Data;

namespace IDE.Business
{

/// <summary>
/// The generated superclass for the <see cref="EnergySuppliers1Table"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoNZ%dbo.EnergySuppliers.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="EnergySuppliers1Table.Instance">EnergySuppliers1Table.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="EnergySuppliers1Table"></seealso>
[SerializableAttribute()]
public class BaseEnergySuppliers1Table : PrimaryKeyTable
{

    private readonly string TableDefinitionString = EnergySuppliers1Definition.GetXMLString();







    protected BaseEnergySuppliers1Table()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.EnergySuppliers1Table");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.EnergySuppliers1Record");
        this.ApplicationName = "IDE";
        this.DataAdapter = new EnergySuppliers1SqlTable();
        ((EnergySuppliers1SqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        SupplierIdColumn.CodeName = "SupplierId";
        SupplierNameColumn.CodeName = "SupplierName";
        SupplierLogoColumn.CodeName = "SupplierLogo";
        SupplyElectricityColumn.CodeName = "SupplyElectricity";
        SupplyGasColumn.CodeName = "SupplyGas";
        SupplyOtherColumn.CodeName = "SupplyOther";
        Address1Column.CodeName = "Address1";
        Address2Column.CodeName = "Address2";
        Address3Column.CodeName = "Address3";
        CityColumn.CodeName = "City";
        PostCodeColumn.CodeName = "PostCode";
        PhoneColumn.CodeName = "Phone";
        ContactColumn.CodeName = "Contact";
        eMailColumn.CodeName = "eMail";
        NetworkVariableNBDRateColumn.CodeName = "NetworkVariableNBDRate";
        NetworkVariableBDRateColumn.CodeName = "NetworkVariableBDRate";
        Enabled0Column.CodeName = "Enabled0";
        LogoHeightColumn.CodeName = "LogoHeight";
        LogoWidthColumn.CodeName = "LogoWidth";
        NetworkDemandRateColumn.CodeName = "NetworkDemandRate";
        NetworkCapacityRateColumn.CodeName = "NetworkCapacityRate";
        NetworkFixedRateColumn.CodeName = "NetworkFixedRate";
        NetworkVariableRateColumn.CodeName = "NetworkVariableRate";
        OtherAdministrationChargeColumn.CodeName = "OtherAdministrationCharge";
        OtherCTMonthlyFeeColumn.CodeName = "OtherCTMonthlyFee";
        OtherDataReconciliationChargeColumn.CodeName = "OtherDataReconciliationCharge";
        OtherECCALevyChargeColumn.CodeName = "OtherECCALevyCharge";
        OtherMeterRentalChargeColumn.CodeName = "OtherMeterRentalCharge";
        EnergyServicesRateNBDColumn.CodeName = "EnergyServicesRateNBD";
        EnergyServicesRateBDColumn.CodeName = "EnergyServicesRateBD";
        ShortNameColumn.CodeName = "ShortName";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplierId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SupplierIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplierId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SupplierId
    {
        get
        {
            return EnergySuppliers1Table.Instance.SupplierIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplierName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SupplierNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplierName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SupplierName
    {
        get
        {
            return EnergySuppliers1Table.Instance.SupplierNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplierLogo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SupplierLogoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplierLogo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SupplierLogo
    {
        get
        {
            return EnergySuppliers1Table.Instance.SupplierLogoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplyElectricity column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn SupplyElectricityColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplyElectricity column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn SupplyElectricity
    {
        get
        {
            return EnergySuppliers1Table.Instance.SupplyElectricityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplyGas column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn SupplyGasColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplyGas column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn SupplyGas
    {
        get
        {
            return EnergySuppliers1Table.Instance.SupplyGasColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplyOther column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn SupplyOtherColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.SupplyOther column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn SupplyOther
    {
        get
        {
            return EnergySuppliers1Table.Instance.SupplyOtherColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return EnergySuppliers1Table.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return EnergySuppliers1Table.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return EnergySuppliers1Table.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.City column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.City column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn City
    {
        get
        {
            return EnergySuppliers1Table.Instance.CityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.PostCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PostCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.PostCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PostCode
    {
        get
        {
            return EnergySuppliers1Table.Instance.PostCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Phone column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PhoneColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Phone column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Phone
    {
        get
        {
            return EnergySuppliers1Table.Instance.PhoneColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Contact column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ContactColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Contact column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Contact
    {
        get
        {
            return EnergySuppliers1Table.Instance.ContactColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.eMail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn eMailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.eMail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn eMail
    {
        get
        {
            return EnergySuppliers1Table.Instance.eMailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkVariableNBDRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NetworkVariableNBDRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkVariableNBDRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NetworkVariableNBDRate
    {
        get
        {
            return EnergySuppliers1Table.Instance.NetworkVariableNBDRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkVariableBDRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NetworkVariableBDRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkVariableBDRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NetworkVariableBDRate
    {
        get
        {
            return EnergySuppliers1Table.Instance.NetworkVariableBDRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Enabled column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Enabled0Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.Enabled column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Enabled0
    {
        get
        {
            return EnergySuppliers1Table.Instance.Enabled0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.LogoHeight column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LogoHeightColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.LogoHeight column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LogoHeight
    {
        get
        {
            return EnergySuppliers1Table.Instance.LogoHeightColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.LogoWidth column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LogoWidthColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.LogoWidth column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LogoWidth
    {
        get
        {
            return EnergySuppliers1Table.Instance.LogoWidthColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkDemandRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NetworkDemandRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkDemandRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NetworkDemandRate
    {
        get
        {
            return EnergySuppliers1Table.Instance.NetworkDemandRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkCapacityRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NetworkCapacityRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkCapacityRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NetworkCapacityRate
    {
        get
        {
            return EnergySuppliers1Table.Instance.NetworkCapacityRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkFixedRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NetworkFixedRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkFixedRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NetworkFixedRate
    {
        get
        {
            return EnergySuppliers1Table.Instance.NetworkFixedRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkVariableRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NetworkVariableRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.NetworkVariableRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NetworkVariableRate
    {
        get
        {
            return EnergySuppliers1Table.Instance.NetworkVariableRateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherAdministrationCharge column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OtherAdministrationChargeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherAdministrationCharge column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OtherAdministrationCharge
    {
        get
        {
            return EnergySuppliers1Table.Instance.OtherAdministrationChargeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherCTMonthlyFee column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OtherCTMonthlyFeeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherCTMonthlyFee column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OtherCTMonthlyFee
    {
        get
        {
            return EnergySuppliers1Table.Instance.OtherCTMonthlyFeeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherDataReconciliationCharge column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OtherDataReconciliationChargeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherDataReconciliationCharge column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OtherDataReconciliationCharge
    {
        get
        {
            return EnergySuppliers1Table.Instance.OtherDataReconciliationChargeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherECCALevyCharge column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OtherECCALevyChargeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherECCALevyCharge column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OtherECCALevyCharge
    {
        get
        {
            return EnergySuppliers1Table.Instance.OtherECCALevyChargeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherMeterRentalCharge column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OtherMeterRentalChargeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.OtherMeterRentalCharge column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OtherMeterRentalCharge
    {
        get
        {
            return EnergySuppliers1Table.Instance.OtherMeterRentalChargeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.EnergyServicesRateNBD column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EnergyServicesRateNBDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.EnergyServicesRateNBD column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EnergyServicesRateNBD
    {
        get
        {
            return EnergySuppliers1Table.Instance.EnergyServicesRateNBDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.EnergyServicesRateBD column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EnergyServicesRateBDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.EnergyServicesRateBD column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EnergyServicesRateBD
    {
        get
        {
            return EnergySuppliers1Table.Instance.EnergyServicesRateBDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.ShortName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ShortNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergySuppliers_.ShortName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ShortName
    {
        get
        {
            return EnergySuppliers1Table.Instance.ShortNameColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergySuppliers1Record records using a where clause.
    /// </summary>
    public static EnergySuppliers1Record[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergySuppliers1Record records using a where clause.
    /// </summary>
    public static EnergySuppliers1Record[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergySuppliers1Record records using a where and order by clause.
    /// </summary>
    public static EnergySuppliers1Record[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of EnergySuppliers1Record records using a where and order by clause.
    /// </summary>
    public static EnergySuppliers1Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergySuppliers1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static EnergySuppliers1Record[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (EnergySuppliers1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergySuppliers1Record"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergySuppliers1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static EnergySuppliers1Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (EnergySuppliers1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergySuppliers1Record"));
    }   


    public static EnergySuppliers1Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (EnergySuppliers1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergySuppliers1Record"));
    }

    public static EnergySuppliers1Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (EnergySuppliers1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergySuppliers1Record"));
    }


    public static EnergySuppliers1Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (EnergySuppliers1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergySuppliers1Record"));
    }

    public static EnergySuppliers1Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (EnergySuppliers1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergySuppliers1Record"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)EnergySuppliers1Table.Instance.GetCountResponseForPost(EnergySuppliers1Table.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergySuppliers1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = EnergySuppliers1Table.Instance.GetRecordListResponseForPost(EnergySuppliers1Table.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
                                                                join, filter, groupBy, sortOrder, startIndex, count, ref totalCount, fromDataSource, isGetColumnValues);
        }
        else if (table != null)
        {
            recList = table.GetDataSourceResponseForPost(requestedSelection, workingSelection, distinctSelection, join, filter, 
                groupBy, sortOrder, startIndex, count, ref totalCount, true);
        }

		return recList;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)EnergySuppliers1Table.Instance.GetRecordListCount(null, whereFilter, null, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(BaseFilter join, string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)EnergySuppliers1Table.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)EnergySuppliers1Table.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)EnergySuppliers1Table.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a EnergySuppliers1Record record using a where clause.
    /// </summary>
    public static EnergySuppliers1Record GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EnergySuppliers1Record record using a where clause.
    /// </summary>
    public static EnergySuppliers1Record GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a EnergySuppliers1Record record using a where and order by clause.
    /// </summary>
    public static EnergySuppliers1Record GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        EnergySuppliers1Record rec = null;
        if (recList.Count > 0)
        {
            rec = (EnergySuppliers1Record)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EnergySuppliers1Record record using a where and order by clause.
    /// </summary>
    public static EnergySuppliers1Record GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = EnergySuppliers1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        EnergySuppliers1Record rec = null;
        if (recList.Count > 0)
        {
            rec = (EnergySuppliers1Record)recList[0];
        }

        return rec;
    }


    public static String[] GetValues(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return EnergySuppliers1Table.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }

    public static String[] GetValues(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return EnergySuppliers1Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        EnergySuppliers1Record[] recs = GetRecords(where);
        return  EnergySuppliers1Table.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        EnergySuppliers1Record[] recs = GetRecords(join, where);
        return  EnergySuppliers1Table.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        EnergySuppliers1Record[] recs = GetRecords(where, orderBy);
        return  EnergySuppliers1Table.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        EnergySuppliers1Record[] recs = GetRecords(join, where, orderBy);
        return  EnergySuppliers1Table.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        EnergySuppliers1Record[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  EnergySuppliers1Table.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        EnergySuppliers1Record[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  EnergySuppliers1Table.Instance.CreateDataTable(recs, null);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to delete records using a where clause.
    /// </summary>
    public static void DeleteRecords(string where)
    {
        if (where == null || where.Trim() == "")
        {
           return;
        }
        
        SqlFilter whereFilter = new SqlFilter(where);
        EnergySuppliers1Table.Instance.DeleteRecordList(whereFilter);
    }
    
    /// <summary>
    /// This is a shared function that can be used to export records using a where clause.
    /// </summary>
    public static string Export(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        return  EnergySuppliers1Table.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return EnergySuppliers1Table.Instance.ExportRecordData(whereFilter);
    }
    
	public static string GetSum(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return EnergySuppliers1Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
	public static string GetSum(
		BaseColumn col,
		BaseFilter join, 
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return EnergySuppliers1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }    
    
    public static string GetCount(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return EnergySuppliers1Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
    public static string GetCount(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return EnergySuppliers1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return EnergySuppliers1Table.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return EnergySuppliers1Table.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return EnergySuppliers1Table.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return EnergySuppliers1Table.Instance.CreateRecord(tempId);
    }

    /// <summary>
    /// This method checks if column is editable.
    /// </summary>
    /// <param name="columnName">Name of the column to check.</param>
    public static bool isReadOnlyColumn(string columnName) 
    {
        BaseColumn column = GetColumn(columnName);
        if (!(column == null)) 
        {
            return column.IsValuesReadOnly;
        }
        else 
        {
            return true;
        }
    }

    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    public static BaseColumn GetColumn(string uniqueColumnName) 
    {
        BaseColumn column = EnergySuppliers1Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = EnergySuppliers1Table.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static EnergySuppliers1Record GetRecord(string id, bool bMutable)
        {
            return (EnergySuppliers1Record)EnergySuppliers1Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static EnergySuppliers1Record GetRecord(KeyValue id, bool bMutable)
        {
            return (EnergySuppliers1Record)EnergySuppliers1Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string SupplierNameValue, 
        string SupplierLogoValue, 
        string SupplyElectricityValue, 
        string SupplyGasValue, 
        string SupplyOtherValue, 
        string Address1Value, 
        string Address2Value, 
        string Address3Value, 
        string CityValue, 
        string PostCodeValue, 
        string PhoneValue, 
        string ContactValue, 
        string eMailValue, 
        string NetworkVariableNBDRateValue, 
        string NetworkVariableBDRateValue, 
        string Enabled0Value, 
        string LogoHeightValue, 
        string LogoWidthValue, 
        string NetworkDemandRateValue, 
        string NetworkCapacityRateValue, 
        string NetworkFixedRateValue, 
        string NetworkVariableRateValue, 
        string OtherAdministrationChargeValue, 
        string OtherCTMonthlyFeeValue, 
        string OtherDataReconciliationChargeValue, 
        string OtherECCALevyChargeValue, 
        string OtherMeterRentalChargeValue, 
        string EnergyServicesRateNBDValue, 
        string EnergyServicesRateBDValue, 
        string ShortNameValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(SupplierNameValue, SupplierNameColumn);
        rec.SetString(SupplierLogoValue, SupplierLogoColumn);
        rec.SetString(SupplyElectricityValue, SupplyElectricityColumn);
        rec.SetString(SupplyGasValue, SupplyGasColumn);
        rec.SetString(SupplyOtherValue, SupplyOtherColumn);
        rec.SetString(Address1Value, Address1Column);
        rec.SetString(Address2Value, Address2Column);
        rec.SetString(Address3Value, Address3Column);
        rec.SetString(CityValue, CityColumn);
        rec.SetString(PostCodeValue, PostCodeColumn);
        rec.SetString(PhoneValue, PhoneColumn);
        rec.SetString(ContactValue, ContactColumn);
        rec.SetString(eMailValue, eMailColumn);
        rec.SetString(NetworkVariableNBDRateValue, NetworkVariableNBDRateColumn);
        rec.SetString(NetworkVariableBDRateValue, NetworkVariableBDRateColumn);
        rec.SetString(Enabled0Value, Enabled0Column);
        rec.SetString(LogoHeightValue, LogoHeightColumn);
        rec.SetString(LogoWidthValue, LogoWidthColumn);
        rec.SetString(NetworkDemandRateValue, NetworkDemandRateColumn);
        rec.SetString(NetworkCapacityRateValue, NetworkCapacityRateColumn);
        rec.SetString(NetworkFixedRateValue, NetworkFixedRateColumn);
        rec.SetString(NetworkVariableRateValue, NetworkVariableRateColumn);
        rec.SetString(OtherAdministrationChargeValue, OtherAdministrationChargeColumn);
        rec.SetString(OtherCTMonthlyFeeValue, OtherCTMonthlyFeeColumn);
        rec.SetString(OtherDataReconciliationChargeValue, OtherDataReconciliationChargeColumn);
        rec.SetString(OtherECCALevyChargeValue, OtherECCALevyChargeColumn);
        rec.SetString(OtherMeterRentalChargeValue, OtherMeterRentalChargeColumn);
        rec.SetString(EnergyServicesRateNBDValue, EnergyServicesRateNBDColumn);
        rec.SetString(EnergyServicesRateBDValue, EnergyServicesRateBDColumn);
        rec.SetString(ShortNameValue, ShortNameColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			EnergySuppliers1Table.Instance.DeleteOneRecord(kv);
		}

		/// <summary>
		/// This method checks if record exist in the database using the keyvalue provided.
		/// </summary>
		/// <param name="kv">Key value of the record.</param>
		public static bool DoesRecordExist(KeyValue kv)
		{
			bool recordExist = true;
			try
			{
				EnergySuppliers1Table.GetRecord(kv, false);
			}
			catch (Exception)
			{
				recordExist = false;
			}
			return recordExist;
		}

        /// <summary>
        ///  This method returns all the primary columns in the table.
        /// </summary>
        public static ColumnList GetPrimaryKeyColumns() 
        {
            if (!(EnergySuppliers1Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return EnergySuppliers1Table.Instance.TableDefinition.PrimaryKey.Columns;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This method takes a key and returns a keyvalue.
        /// </summary>
        /// <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
        public static KeyValue GetKeyValue(object key) 
        {
            KeyValue kv = null;
            if (!(EnergySuppliers1Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = EnergySuppliers1Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = EnergySuppliers1Table.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (EnergySuppliers1Table.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
                            {
                                kv.AddElement(pkColumn.UniqueName, keyString);
                            }
                            else 
                            {
                                kv.AddElement(pkColumn.InternalName, keyString);
                            }

                            index = (index + 1);
                        }
                    }
                }
                else 
                {
                    //  If the key is not composite, then get the key value.
                    kv = EnergySuppliers1Table.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = EnergySuppliers1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }
                            
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
		public static string GetDFKA(String keyValue, BaseColumn col, String formatPattern)
		{
		    if (keyValue == null)
				return null;
			ForeignKey fkColumn = EnergySuppliers1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				PrimaryKeyTable t = (PrimaryKeyTable)DatabaseObjects.GetTableObject(tableName);
				BaseRecord rec = null;
				
				if (t != null)
				{
					try
					{
						rec = (BaseRecord)t.GetRecordData(keyValue, false);
					}
					catch
					{
						rec = null;
					}
				}
				if( rec == null)
					return "";

                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }	            
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, string name)
		{
			BaseFormulaEvaluator e = new BaseFormulaEvaluator();
			if(dataSourceForEvaluate != null)
				e.Evaluator.Variables.Add(name, dataSourceForEvaluate);
			e.DataSource = dataSourceForEvaluate;
	        object resultObj = e.Evaluate(formula);
	
		    if (resultObj == null)
			    return "";
	        if (!string.IsNullOrEmpty(format))
	            return BaseFormulaUtils.Format(resultObj, format);
		    else
            return resultObj.ToString();
		}
		
		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula)
		{
			return EvaluateFormula(formula,null,null,null);
		}
		
				
	#endregion
	}

}
