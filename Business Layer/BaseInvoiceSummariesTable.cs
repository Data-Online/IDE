// This class is "generated" and will be overwritten.
// Your customizations should be made in InvoiceSummariesTable.cs


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
/// The generated superclass for the <see cref="InvoiceSummariesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoPortal%dbo.InvoiceSummaries.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="InvoiceSummariesTable.Instance">InvoiceSummariesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="InvoiceSummariesTable"></seealso>
[SerializableAttribute()]
public class BaseInvoiceSummariesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = InvoiceSummariesDefinition.GetXMLString();







    protected BaseInvoiceSummariesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.InvoiceSummariesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.InvoiceSummariesRecord");
        this.ApplicationName = "IDE";
        this.DataAdapter = new InvoiceSummariesSqlTable();
        ((InvoiceSummariesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        InvoiceSummaryIdColumn.CodeName = "InvoiceSummaryId";
        InvoiceIdColumn.CodeName = "InvoiceId";
        InvoiceIdColumn.DefaultValue = EvaluateFormula("99999999");
        InvoiceDateColumn.CodeName = "InvoiceDate";
        InvoiceNumberColumn.CodeName = "InvoiceNumber";
        GstTotalColumn.CodeName = "GstTotal";
        GstTotalColumn.DefaultValue = EvaluateFormula("0");
        InvoiceTotalColumn.CodeName = "InvoiceTotal";
        AccountNumberColumn.CodeName = "AccountNumber";
        CustomerNumberColumn.CodeName = "CustomerNumber";
        CustomerNumberColumn.DefaultValue = EvaluateFormula("\"0\"");
        SiteIdColumn.CodeName = "SiteId";
        NetworkChargesTotalColumn.CodeName = "NetworkChargesTotal";
        NetworkChargesTotalColumn.DefaultValue = EvaluateFormula("\"0\"");
        EnergyChargesTotalColumn.CodeName = "EnergyChargesTotal";
        EnergyChargesTotalColumn.DefaultValue = EvaluateFormula("\"0\"");
        MiscChargesTotalColumn.CodeName = "MiscChargesTotal";
        MiscChargesTotalColumn.DefaultValue = EvaluateFormula("\"0\"");
        MiscChargesTotalColumn.Name = EvaluateFormula("\"Other Charges Total\"");
        TotalChargesColumn.CodeName = "TotalCharges";
        TotalChargesColumn.DefaultValue = EvaluateFormula("0");
        GSTChargesColumn.CodeName = "GSTCharges";
        GSTChargesColumn.DefaultValue = EvaluateFormula("0");
        TotalNetworkChargesColumn.CodeName = "TotalNetworkCharges";
        TotalNetworkChargesColumn.DefaultValue = EvaluateFormula("0");
        TotalNetworkChargesColumn.Name = EvaluateFormula("\"Total Network/Line Charges\"");
        TotalMiscChargesColumn.CodeName = "TotalMiscCharges";
        TotalMiscChargesColumn.DefaultValue = EvaluateFormula("0");
        TotalEnergyChargesColumn.CodeName = "TotalEnergyCharges";
        TotalEnergyChargesColumn.DefaultValue = EvaluateFormula("0");
        ConnectionNumberColumn.CodeName = "ConnectionNumber";
        ConnectionNumberColumn.DefaultValue = EvaluateFormula("\" \"");
        SiteNameColumn.CodeName = "SiteName";
        SiteNameColumn.DefaultValue = EvaluateFormula("\"empty\"");
        InvoiceDueDateColumn.CodeName = "InvoiceDueDate";
        MonthColumn.CodeName = "Month";
        YearColumn.CodeName = "Year";
        ApprovedColumn.CodeName = "Approved";
        ApprovedByIdColumn.CodeName = "ApprovedById";
        ApprovedDateColumn.CodeName = "ApprovedDate";
        PercentageChangeColumn.CodeName = "PercentageChange";
        PeriodStartColumn.CodeName = "PeriodStart";
        PeriodEndColumn.CodeName = "PeriodEnd";
        EnergyPointIdColumn.CodeName = "EnergyPointId";
        SupplierIdColumn.CodeName = "SupplierId";
        KwhTotalColumn.CodeName = "KwhTotal";
        KwhTotalColumn.Name = EvaluateFormula("\"kWh Total\"");
        VerifiedColumn.CodeName = "Verified";
        OnFileColumn.CodeName = "OnFile";
        CheckedOkColumn.CodeName = "CheckedOk";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceSummaryId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvoiceSummaryIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceSummaryId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvoiceSummaryId
    {
        get
        {
            return InvoiceSummariesTable.Instance.InvoiceSummaryIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvoiceIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvoiceId
    {
        get
        {
            return InvoiceSummariesTable.Instance.InvoiceIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn InvoiceDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn InvoiceDate
    {
        get
        {
            return InvoiceSummariesTable.Instance.InvoiceDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvoiceNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvoiceNumber
    {
        get
        {
            return InvoiceSummariesTable.Instance.InvoiceNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.GstTotal column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn GstTotalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.GstTotal column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn GstTotal
    {
        get
        {
            return InvoiceSummariesTable.Instance.GstTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceTotal column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn InvoiceTotalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceTotal column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn InvoiceTotal
    {
        get
        {
            return InvoiceSummariesTable.Instance.InvoiceTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.AccountNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AccountNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.AccountNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn AccountNumber
    {
        get
        {
            return InvoiceSummariesTable.Instance.AccountNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.CustomerNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CustomerNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.CustomerNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CustomerNumber
    {
        get
        {
            return InvoiceSummariesTable.Instance.CustomerNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.SiteId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SiteIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.SiteId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SiteId
    {
        get
        {
            return InvoiceSummariesTable.Instance.SiteIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.NetworkChargesTotal column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NetworkChargesTotalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.NetworkChargesTotal column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NetworkChargesTotal
    {
        get
        {
            return InvoiceSummariesTable.Instance.NetworkChargesTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.EnergyChargesTotal column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EnergyChargesTotalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.EnergyChargesTotal column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EnergyChargesTotal
    {
        get
        {
            return InvoiceSummariesTable.Instance.EnergyChargesTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.MiscChargesTotal column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MiscChargesTotalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.MiscChargesTotal column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MiscChargesTotal
    {
        get
        {
            return InvoiceSummariesTable.Instance.MiscChargesTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalCharges column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TotalChargesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalCharges column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TotalCharges
    {
        get
        {
            return InvoiceSummariesTable.Instance.TotalChargesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.GSTCharges column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn GSTChargesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.GSTCharges column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn GSTCharges
    {
        get
        {
            return InvoiceSummariesTable.Instance.GSTChargesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalNetworkCharges column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TotalNetworkChargesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalNetworkCharges column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TotalNetworkCharges
    {
        get
        {
            return InvoiceSummariesTable.Instance.TotalNetworkChargesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalMiscCharges column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TotalMiscChargesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalMiscCharges column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TotalMiscCharges
    {
        get
        {
            return InvoiceSummariesTable.Instance.TotalMiscChargesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalEnergyCharges column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TotalEnergyChargesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.TotalEnergyCharges column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TotalEnergyCharges
    {
        get
        {
            return InvoiceSummariesTable.Instance.TotalEnergyChargesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.ConnectionNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ConnectionNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.ConnectionNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ConnectionNumber
    {
        get
        {
            return InvoiceSummariesTable.Instance.ConnectionNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.SiteName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SiteNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.SiteName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SiteName
    {
        get
        {
            return InvoiceSummariesTable.Instance.SiteNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceDueDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn InvoiceDueDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.InvoiceDueDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn InvoiceDueDate
    {
        get
        {
            return InvoiceSummariesTable.Instance.InvoiceDueDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Month column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MonthColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Month column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Month
    {
        get
        {
            return InvoiceSummariesTable.Instance.MonthColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Year column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn YearColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Year column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn Year
    {
        get
        {
            return InvoiceSummariesTable.Instance.YearColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Approved column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ApprovedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Approved column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Approved
    {
        get
        {
            return InvoiceSummariesTable.Instance.ApprovedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.ApprovedById column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ApprovedByIdColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.ApprovedById column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ApprovedById
    {
        get
        {
            return InvoiceSummariesTable.Instance.ApprovedByIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.ApprovedDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ApprovedDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.ApprovedDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ApprovedDate
    {
        get
        {
            return InvoiceSummariesTable.Instance.ApprovedDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.PercentageChange column object.
    /// </summary>
    public BaseClasses.Data.PercentageColumn PercentageChangeColumn
    {
        get
        {
            return (BaseClasses.Data.PercentageColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.PercentageChange column object.
    /// </summary>
    public static BaseClasses.Data.PercentageColumn PercentageChange
    {
        get
        {
            return InvoiceSummariesTable.Instance.PercentageChangeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.PeriodStart column object.
    /// </summary>
    public BaseClasses.Data.DateColumn PeriodStartColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.PeriodStart column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn PeriodStart
    {
        get
        {
            return InvoiceSummariesTable.Instance.PeriodStartColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.PeriodEnd column object.
    /// </summary>
    public BaseClasses.Data.DateColumn PeriodEndColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.PeriodEnd column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn PeriodEnd
    {
        get
        {
            return InvoiceSummariesTable.Instance.PeriodEndColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.EnergyPointId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EnergyPointIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.EnergyPointId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EnergyPointId
    {
        get
        {
            return InvoiceSummariesTable.Instance.EnergyPointIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.SupplierId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SupplierIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.SupplierId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SupplierId
    {
        get
        {
            return InvoiceSummariesTable.Instance.SupplierIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.KwhTotal column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn KwhTotalColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.KwhTotal column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn KwhTotal
    {
        get
        {
            return InvoiceSummariesTable.Instance.KwhTotalColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Verified column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn VerifiedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.Verified column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Verified
    {
        get
        {
            return InvoiceSummariesTable.Instance.VerifiedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.OnFile column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn OnFileColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.OnFile column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn OnFile
    {
        get
        {
            return InvoiceSummariesTable.Instance.OnFileColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.CheckedOk column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn CheckedOkColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's InvoiceSummaries_.CheckedOk column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn CheckedOk
    {
        get
        {
            return InvoiceSummariesTable.Instance.CheckedOkColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of InvoiceSummariesRecord records using a where clause.
    /// </summary>
    public static InvoiceSummariesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of InvoiceSummariesRecord records using a where clause.
    /// </summary>
    public static InvoiceSummariesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of InvoiceSummariesRecord records using a where and order by clause.
    /// </summary>
    public static InvoiceSummariesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of InvoiceSummariesRecord records using a where and order by clause.
    /// </summary>
    public static InvoiceSummariesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of InvoiceSummariesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static InvoiceSummariesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (InvoiceSummariesRecord[])recList.ToArray(Type.GetType("IDE.Business.InvoiceSummariesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of InvoiceSummariesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static InvoiceSummariesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (InvoiceSummariesRecord[])recList.ToArray(Type.GetType("IDE.Business.InvoiceSummariesRecord"));
    }   


    public static InvoiceSummariesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (InvoiceSummariesRecord[])recList.ToArray(Type.GetType("IDE.Business.InvoiceSummariesRecord"));
    }

    public static InvoiceSummariesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (InvoiceSummariesRecord[])recList.ToArray(Type.GetType("IDE.Business.InvoiceSummariesRecord"));
    }


    public static InvoiceSummariesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (InvoiceSummariesRecord[])recList.ToArray(Type.GetType("IDE.Business.InvoiceSummariesRecord"));
    }

    public static InvoiceSummariesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (InvoiceSummariesRecord[])recList.ToArray(Type.GetType("IDE.Business.InvoiceSummariesRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)InvoiceSummariesTable.Instance.GetCountResponseForPost(InvoiceSummariesTable.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of InvoiceSummariesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = InvoiceSummariesTable.Instance.GetRecordListResponseForPost(InvoiceSummariesTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)InvoiceSummariesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)InvoiceSummariesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)InvoiceSummariesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)InvoiceSummariesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a InvoiceSummariesRecord record using a where clause.
    /// </summary>
    public static InvoiceSummariesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a InvoiceSummariesRecord record using a where clause.
    /// </summary>
    public static InvoiceSummariesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a InvoiceSummariesRecord record using a where and order by clause.
    /// </summary>
    public static InvoiceSummariesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        InvoiceSummariesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (InvoiceSummariesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a InvoiceSummariesRecord record using a where and order by clause.
    /// </summary>
    public static InvoiceSummariesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = InvoiceSummariesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        InvoiceSummariesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (InvoiceSummariesRecord)recList[0];
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

        return InvoiceSummariesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return InvoiceSummariesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        InvoiceSummariesRecord[] recs = GetRecords(where);
        return  InvoiceSummariesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        InvoiceSummariesRecord[] recs = GetRecords(join, where);
        return  InvoiceSummariesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        InvoiceSummariesRecord[] recs = GetRecords(where, orderBy);
        return  InvoiceSummariesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        InvoiceSummariesRecord[] recs = GetRecords(join, where, orderBy);
        return  InvoiceSummariesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        InvoiceSummariesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  InvoiceSummariesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        InvoiceSummariesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  InvoiceSummariesTable.Instance.CreateDataTable(recs, null);
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
        InvoiceSummariesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  InvoiceSummariesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return InvoiceSummariesTable.Instance.ExportRecordData(whereFilter);
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

        return InvoiceSummariesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return InvoiceSummariesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return InvoiceSummariesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return InvoiceSummariesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return InvoiceSummariesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return InvoiceSummariesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return InvoiceSummariesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return InvoiceSummariesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = InvoiceSummariesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = InvoiceSummariesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static InvoiceSummariesRecord GetRecord(string id, bool bMutable)
        {
            return (InvoiceSummariesRecord)InvoiceSummariesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static InvoiceSummariesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (InvoiceSummariesRecord)InvoiceSummariesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string InvoiceIdValue, 
        string InvoiceDateValue, 
        string InvoiceNumberValue, 
        string GstTotalValue, 
        string InvoiceTotalValue, 
        string AccountNumberValue, 
        string CustomerNumberValue, 
        string SiteIdValue, 
        string NetworkChargesTotalValue, 
        string EnergyChargesTotalValue, 
        string MiscChargesTotalValue, 
        string TotalChargesValue, 
        string GSTChargesValue, 
        string TotalNetworkChargesValue, 
        string TotalMiscChargesValue, 
        string TotalEnergyChargesValue, 
        string ConnectionNumberValue, 
        string SiteNameValue, 
        string InvoiceDueDateValue, 
        string MonthValue, 
        string YearValue, 
        string ApprovedValue, 
        string ApprovedByIdValue, 
        string ApprovedDateValue, 
        string PercentageChangeValue, 
        string PeriodStartValue, 
        string PeriodEndValue, 
        string EnergyPointIdValue, 
        string SupplierIdValue, 
        string KwhTotalValue, 
        string VerifiedValue, 
        string OnFileValue, 
        string CheckedOkValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(InvoiceIdValue, InvoiceIdColumn);
        rec.SetString(InvoiceDateValue, InvoiceDateColumn);
        rec.SetString(InvoiceNumberValue, InvoiceNumberColumn);
        rec.SetString(GstTotalValue, GstTotalColumn);
        rec.SetString(InvoiceTotalValue, InvoiceTotalColumn);
        rec.SetString(AccountNumberValue, AccountNumberColumn);
        rec.SetString(CustomerNumberValue, CustomerNumberColumn);
        rec.SetString(SiteIdValue, SiteIdColumn);
        rec.SetString(NetworkChargesTotalValue, NetworkChargesTotalColumn);
        rec.SetString(EnergyChargesTotalValue, EnergyChargesTotalColumn);
        rec.SetString(MiscChargesTotalValue, MiscChargesTotalColumn);
        rec.SetString(TotalChargesValue, TotalChargesColumn);
        rec.SetString(GSTChargesValue, GSTChargesColumn);
        rec.SetString(TotalNetworkChargesValue, TotalNetworkChargesColumn);
        rec.SetString(TotalMiscChargesValue, TotalMiscChargesColumn);
        rec.SetString(TotalEnergyChargesValue, TotalEnergyChargesColumn);
        rec.SetString(ConnectionNumberValue, ConnectionNumberColumn);
        rec.SetString(SiteNameValue, SiteNameColumn);
        rec.SetString(InvoiceDueDateValue, InvoiceDueDateColumn);
        rec.SetString(MonthValue, MonthColumn);
        rec.SetString(YearValue, YearColumn);
        rec.SetString(ApprovedValue, ApprovedColumn);
        rec.SetString(ApprovedByIdValue, ApprovedByIdColumn);
        rec.SetString(ApprovedDateValue, ApprovedDateColumn);
        rec.SetString(PercentageChangeValue, PercentageChangeColumn);
        rec.SetString(PeriodStartValue, PeriodStartColumn);
        rec.SetString(PeriodEndValue, PeriodEndColumn);
        rec.SetString(EnergyPointIdValue, EnergyPointIdColumn);
        rec.SetString(SupplierIdValue, SupplierIdColumn);
        rec.SetString(KwhTotalValue, KwhTotalColumn);
        rec.SetString(VerifiedValue, VerifiedColumn);
        rec.SetString(OnFileValue, OnFileColumn);
        rec.SetString(CheckedOkValue, CheckedOkColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			InvoiceSummariesTable.Instance.DeleteOneRecord(kv);
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
				InvoiceSummariesTable.GetRecord(kv, false);
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
            if (!(InvoiceSummariesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return InvoiceSummariesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(InvoiceSummariesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = InvoiceSummariesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = InvoiceSummariesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (InvoiceSummariesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = InvoiceSummariesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = InvoiceSummariesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = InvoiceSummariesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
