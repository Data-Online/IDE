// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergyPoints1Table.cs


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
/// The generated superclass for the <see cref="EnergyPoints1Table"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoNZ%dbo.EnergyPoints.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="EnergyPoints1Table.Instance">EnergyPoints1Table.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="EnergyPoints1Table"></seealso>
[SerializableAttribute()]
public class BaseEnergyPoints1Table : PrimaryKeyTable
{

    private readonly string TableDefinitionString = EnergyPoints1Definition.GetXMLString();







    protected BaseEnergyPoints1Table()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.EnergyPoints1Table");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.EnergyPoints1Record");
        this.ApplicationName = "IDE";
        this.DataAdapter = new EnergyPoints1SqlTable();
        ((EnergyPoints1SqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        EnergyPointIdColumn.CodeName = "EnergyPointId";
        ConnectionNumberColumn.CodeName = "ConnectionNumber";
        SiteIdColumn.CodeName = "SiteId";
        SupplierIdColumn.CodeName = "SupplierId";
        LocationNotesColumn.CodeName = "LocationNotes";
        LinesCompanyIdColumn.CodeName = "LinesCompanyId";
        MeterIdColumn.CodeName = "MeterId";
        MeteringCompanyIdColumn.CodeName = "MeteringCompanyId";
        Enabled0Column.CodeName = "Enabled0";
        PhasesColumn.CodeName = "Phases";
        GridExitPointColumn.CodeName = "GridExitPoint";
        GridExitPointRegionColumn.CodeName = "GridExitPointRegion";
        ConnectionTypeColumn.CodeName = "ConnectionType";
        GLCodeColumn.CodeName = "GLCode";
        AssessedCapacityColumn.CodeName = "AssessedCapacity";
        WeatherStationIdColumn.CodeName = "WeatherStationId";
        NIWAStationTemperatureColumn.CodeName = "NIWAStationTemperature";
        NIWAStationRainColumn.CodeName = "NIWAStationRain";
        NIWAStationSunColumn.CodeName = "NIWAStationSun";
        ICPPOCColumn.CodeName = "ICPPOC";
        Reconcilliation_TypeColumn.CodeName = "Reconcilliation_Type";
        Price_CategoryColumn.CodeName = "Price_Category";
        Loss_CategoryColumn.CodeName = "Loss_Category";
        Chargable_CapacitoryColumn.CodeName = "Chargable_Capacitory";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.EnergyPointId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EnergyPointIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.EnergyPointId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EnergyPointId
    {
        get
        {
            return EnergyPoints1Table.Instance.EnergyPointIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.ConnectionNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ConnectionNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.ConnectionNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ConnectionNumber
    {
        get
        {
            return EnergyPoints1Table.Instance.ConnectionNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.SiteId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SiteIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.SiteId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SiteId
    {
        get
        {
            return EnergyPoints1Table.Instance.SiteIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.SupplierId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SupplierIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.SupplierId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SupplierId
    {
        get
        {
            return EnergyPoints1Table.Instance.SupplierIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.LocationNotes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LocationNotesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.LocationNotes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LocationNotes
    {
        get
        {
            return EnergyPoints1Table.Instance.LocationNotesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.LinesCompanyId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LinesCompanyIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.LinesCompanyId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LinesCompanyId
    {
        get
        {
            return EnergyPoints1Table.Instance.LinesCompanyIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.MeterId column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MeterIdColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.MeterId column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MeterId
    {
        get
        {
            return EnergyPoints1Table.Instance.MeterIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.MeteringCompanyId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MeteringCompanyIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.MeteringCompanyId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MeteringCompanyId
    {
        get
        {
            return EnergyPoints1Table.Instance.MeteringCompanyIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Enabled column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Enabled0Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Enabled column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Enabled0
    {
        get
        {
            return EnergyPoints1Table.Instance.Enabled0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Phases column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PhasesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Phases column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Phases
    {
        get
        {
            return EnergyPoints1Table.Instance.PhasesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.GridExitPoint column object.
    /// </summary>
    public BaseClasses.Data.StringColumn GridExitPointColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.GridExitPoint column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn GridExitPoint
    {
        get
        {
            return EnergyPoints1Table.Instance.GridExitPointColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.GridExitPointRegion column object.
    /// </summary>
    public BaseClasses.Data.StringColumn GridExitPointRegionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.GridExitPointRegion column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn GridExitPointRegion
    {
        get
        {
            return EnergyPoints1Table.Instance.GridExitPointRegionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.ConnectionType column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ConnectionTypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.ConnectionType column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ConnectionType
    {
        get
        {
            return EnergyPoints1Table.Instance.ConnectionTypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.GLCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn GLCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.GLCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn GLCode
    {
        get
        {
            return EnergyPoints1Table.Instance.GLCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.AssessedCapacity column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn AssessedCapacityColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.AssessedCapacity column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn AssessedCapacity
    {
        get
        {
            return EnergyPoints1Table.Instance.AssessedCapacityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.WeatherStationId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn WeatherStationIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.WeatherStationId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn WeatherStationId
    {
        get
        {
            return EnergyPoints1Table.Instance.WeatherStationIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.NIWAStationTemperature column object.
    /// </summary>
    public BaseClasses.Data.StringColumn NIWAStationTemperatureColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.NIWAStationTemperature column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn NIWAStationTemperature
    {
        get
        {
            return EnergyPoints1Table.Instance.NIWAStationTemperatureColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.NIWAStationRain column object.
    /// </summary>
    public BaseClasses.Data.StringColumn NIWAStationRainColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.NIWAStationRain column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn NIWAStationRain
    {
        get
        {
            return EnergyPoints1Table.Instance.NIWAStationRainColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.NIWAStationSun column object.
    /// </summary>
    public BaseClasses.Data.StringColumn NIWAStationSunColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.NIWAStationSun column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn NIWAStationSun
    {
        get
        {
            return EnergyPoints1Table.Instance.NIWAStationSunColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.ICPPOC column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ICPPOCColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.ICPPOC column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ICPPOC
    {
        get
        {
            return EnergyPoints1Table.Instance.ICPPOCColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Reconcilliation_Type column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Reconcilliation_TypeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Reconcilliation_Type column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Reconcilliation_Type
    {
        get
        {
            return EnergyPoints1Table.Instance.Reconcilliation_TypeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Price_Category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Price_CategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Price_Category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Price_Category
    {
        get
        {
            return EnergyPoints1Table.Instance.Price_CategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Loss_Category column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Loss_CategoryColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Loss_Category column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Loss_Category
    {
        get
        {
            return EnergyPoints1Table.Instance.Loss_CategoryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Chargable_Capacitory column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn Chargable_CapacitoryColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyPoints_.Chargable_Capacitory column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Chargable_Capacitory
    {
        get
        {
            return EnergyPoints1Table.Instance.Chargable_CapacitoryColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyPoints1Record records using a where clause.
    /// </summary>
    public static EnergyPoints1Record[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyPoints1Record records using a where clause.
    /// </summary>
    public static EnergyPoints1Record[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyPoints1Record records using a where and order by clause.
    /// </summary>
    public static EnergyPoints1Record[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of EnergyPoints1Record records using a where and order by clause.
    /// </summary>
    public static EnergyPoints1Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyPoints1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static EnergyPoints1Record[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (EnergyPoints1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergyPoints1Record"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyPoints1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static EnergyPoints1Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (EnergyPoints1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergyPoints1Record"));
    }   


    public static EnergyPoints1Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (EnergyPoints1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergyPoints1Record"));
    }

    public static EnergyPoints1Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (EnergyPoints1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergyPoints1Record"));
    }


    public static EnergyPoints1Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (EnergyPoints1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergyPoints1Record"));
    }

    public static EnergyPoints1Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (EnergyPoints1Record[])recList.ToArray(Type.GetType("IDE.Business.EnergyPoints1Record"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)EnergyPoints1Table.Instance.GetCountResponseForPost(EnergyPoints1Table.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyPoints1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = EnergyPoints1Table.Instance.GetRecordListResponseForPost(EnergyPoints1Table.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)EnergyPoints1Table.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)EnergyPoints1Table.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)EnergyPoints1Table.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)EnergyPoints1Table.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a EnergyPoints1Record record using a where clause.
    /// </summary>
    public static EnergyPoints1Record GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EnergyPoints1Record record using a where clause.
    /// </summary>
    public static EnergyPoints1Record GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a EnergyPoints1Record record using a where and order by clause.
    /// </summary>
    public static EnergyPoints1Record GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        EnergyPoints1Record rec = null;
        if (recList.Count > 0)
        {
            rec = (EnergyPoints1Record)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EnergyPoints1Record record using a where and order by clause.
    /// </summary>
    public static EnergyPoints1Record GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = EnergyPoints1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        EnergyPoints1Record rec = null;
        if (recList.Count > 0)
        {
            rec = (EnergyPoints1Record)recList[0];
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

        return EnergyPoints1Table.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return EnergyPoints1Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        EnergyPoints1Record[] recs = GetRecords(where);
        return  EnergyPoints1Table.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        EnergyPoints1Record[] recs = GetRecords(join, where);
        return  EnergyPoints1Table.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        EnergyPoints1Record[] recs = GetRecords(where, orderBy);
        return  EnergyPoints1Table.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        EnergyPoints1Record[] recs = GetRecords(join, where, orderBy);
        return  EnergyPoints1Table.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        EnergyPoints1Record[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  EnergyPoints1Table.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        EnergyPoints1Record[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  EnergyPoints1Table.Instance.CreateDataTable(recs, null);
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
        EnergyPoints1Table.Instance.DeleteRecordList(whereFilter);
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
        
        return  EnergyPoints1Table.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return EnergyPoints1Table.Instance.ExportRecordData(whereFilter);
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

        return EnergyPoints1Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return EnergyPoints1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return EnergyPoints1Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return EnergyPoints1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return EnergyPoints1Table.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return EnergyPoints1Table.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return EnergyPoints1Table.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return EnergyPoints1Table.Instance.CreateRecord(tempId);
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
        BaseColumn column = EnergyPoints1Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = EnergyPoints1Table.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static EnergyPoints1Record GetRecord(string id, bool bMutable)
        {
            return (EnergyPoints1Record)EnergyPoints1Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static EnergyPoints1Record GetRecord(KeyValue id, bool bMutable)
        {
            return (EnergyPoints1Record)EnergyPoints1Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string ConnectionNumberValue, 
        string SiteIdValue, 
        string SupplierIdValue, 
        string LocationNotesValue, 
        string LinesCompanyIdValue, 
        string MeterIdValue, 
        string MeteringCompanyIdValue, 
        string Enabled0Value, 
        string PhasesValue, 
        string GridExitPointValue, 
        string GridExitPointRegionValue, 
        string ConnectionTypeValue, 
        string GLCodeValue, 
        string AssessedCapacityValue, 
        string WeatherStationIdValue, 
        string NIWAStationTemperatureValue, 
        string NIWAStationRainValue, 
        string NIWAStationSunValue, 
        string ICPPOCValue, 
        string Reconcilliation_TypeValue, 
        string Price_CategoryValue, 
        string Loss_CategoryValue, 
        string Chargable_CapacitoryValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(ConnectionNumberValue, ConnectionNumberColumn);
        rec.SetString(SiteIdValue, SiteIdColumn);
        rec.SetString(SupplierIdValue, SupplierIdColumn);
        rec.SetString(LocationNotesValue, LocationNotesColumn);
        rec.SetString(LinesCompanyIdValue, LinesCompanyIdColumn);
        rec.SetString(MeterIdValue, MeterIdColumn);
        rec.SetString(MeteringCompanyIdValue, MeteringCompanyIdColumn);
        rec.SetString(Enabled0Value, Enabled0Column);
        rec.SetString(PhasesValue, PhasesColumn);
        rec.SetString(GridExitPointValue, GridExitPointColumn);
        rec.SetString(GridExitPointRegionValue, GridExitPointRegionColumn);
        rec.SetString(ConnectionTypeValue, ConnectionTypeColumn);
        rec.SetString(GLCodeValue, GLCodeColumn);
        rec.SetString(AssessedCapacityValue, AssessedCapacityColumn);
        rec.SetString(WeatherStationIdValue, WeatherStationIdColumn);
        rec.SetString(NIWAStationTemperatureValue, NIWAStationTemperatureColumn);
        rec.SetString(NIWAStationRainValue, NIWAStationRainColumn);
        rec.SetString(NIWAStationSunValue, NIWAStationSunColumn);
        rec.SetString(ICPPOCValue, ICPPOCColumn);
        rec.SetString(Reconcilliation_TypeValue, Reconcilliation_TypeColumn);
        rec.SetString(Price_CategoryValue, Price_CategoryColumn);
        rec.SetString(Loss_CategoryValue, Loss_CategoryColumn);
        rec.SetString(Chargable_CapacitoryValue, Chargable_CapacitoryColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			EnergyPoints1Table.Instance.DeleteOneRecord(kv);
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
				EnergyPoints1Table.GetRecord(kv, false);
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
            if (!(EnergyPoints1Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return EnergyPoints1Table.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(EnergyPoints1Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = EnergyPoints1Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = EnergyPoints1Table.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (EnergyPoints1Table.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = EnergyPoints1Table.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = EnergyPoints1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = EnergyPoints1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
