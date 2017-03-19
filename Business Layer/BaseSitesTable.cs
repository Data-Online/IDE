// This class is "generated" and will be overwritten.
// Your customizations should be made in SitesTable.cs


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
/// The generated superclass for the <see cref="SitesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoPortal%dbo.Sites.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="SitesTable.Instance">SitesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="SitesTable"></seealso>
[SerializableAttribute()]
public class BaseSitesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = SitesDefinition.GetXMLString();







    protected BaseSitesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.SitesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.SitesRecord");
        this.ApplicationName = "IDE";
        this.DataAdapter = new SitesSqlTable();
        ((SitesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        SiteIdColumn.CodeName = "SiteId";
        SiteNameColumn.CodeName = "SiteName";
        GroupIdColumn.CodeName = "GroupId";
        CustomerIdColumn.CodeName = "CustomerId";
        TotalFloorSpaceSqMetersColumn.CodeName = "TotalFloorSpaceSqMeters";
        LandSqMetersColumn.CodeName = "LandSqMeters";
        ProductiveFloorSpaceSqMetersColumn.CodeName = "ProductiveFloorSpaceSqMeters";
        Address1Column.CodeName = "Address1";
        Address2Column.CodeName = "Address2";
        Address3Column.CodeName = "Address3";
        GroupDivisionIdColumn.CodeName = "GroupDivisionId";
        IndustryIdColumn.CodeName = "IndustryId";
        FiledInvoiceCountColumn.CodeName = "FiledInvoiceCount";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SiteIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SiteId
    {
        get
        {
            return SitesTable.Instance.SiteIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SiteNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SiteName
    {
        get
        {
            return SitesTable.Instance.SiteNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn GroupIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn GroupId
    {
        get
        {
            return SitesTable.Instance.GroupIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CustomerId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustomerIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CustomerId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustomerId
    {
        get
        {
            return SitesTable.Instance.CustomerIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.TotalFloorSpaceSqMeters column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TotalFloorSpaceSqMetersColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.TotalFloorSpaceSqMeters column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TotalFloorSpaceSqMeters
    {
        get
        {
            return SitesTable.Instance.TotalFloorSpaceSqMetersColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.LandSqMeters column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LandSqMetersColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.LandSqMeters column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LandSqMeters
    {
        get
        {
            return SitesTable.Instance.LandSqMetersColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ProductiveFloorSpaceSqMeters column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ProductiveFloorSpaceSqMetersColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ProductiveFloorSpaceSqMeters column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ProductiveFloorSpaceSqMeters
    {
        get
        {
            return SitesTable.Instance.ProductiveFloorSpaceSqMetersColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return SitesTable.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return SitesTable.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return SitesTable.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupDivisionId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn GroupDivisionIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupDivisionId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn GroupDivisionId
    {
        get
        {
            return SitesTable.Instance.GroupDivisionIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.IndustryId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IndustryIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.IndustryId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IndustryId
    {
        get
        {
            return SitesTable.Instance.IndustryIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.FiledInvoiceCount column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FiledInvoiceCountColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.FiledInvoiceCount column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FiledInvoiceCount
    {
        get
        {
            return SitesTable.Instance.FiledInvoiceCountColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of SitesRecord records using a where clause.
    /// </summary>
    public static SitesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of SitesRecord records using a where clause.
    /// </summary>
    public static SitesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of SitesRecord records using a where and order by clause.
    /// </summary>
    public static SitesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of SitesRecord records using a where and order by clause.
    /// </summary>
    public static SitesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of SitesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static SitesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = SitesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (SitesRecord[])recList.ToArray(Type.GetType("IDE.Business.SitesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of SitesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static SitesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = SitesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (SitesRecord[])recList.ToArray(Type.GetType("IDE.Business.SitesRecord"));
    }   


    public static SitesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = SitesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (SitesRecord[])recList.ToArray(Type.GetType("IDE.Business.SitesRecord"));
    }

    public static SitesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = SitesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (SitesRecord[])recList.ToArray(Type.GetType("IDE.Business.SitesRecord"));
    }


    public static SitesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = SitesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (SitesRecord[])recList.ToArray(Type.GetType("IDE.Business.SitesRecord"));
    }

    public static SitesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = SitesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (SitesRecord[])recList.ToArray(Type.GetType("IDE.Business.SitesRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)SitesTable.Instance.GetCountResponseForPost(SitesTable.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of SitesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = SitesTable.Instance.GetRecordListResponseForPost(SitesTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)SitesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)SitesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)SitesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)SitesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a SitesRecord record using a where clause.
    /// </summary>
    public static SitesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a SitesRecord record using a where clause.
    /// </summary>
    public static SitesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a SitesRecord record using a where and order by clause.
    /// </summary>
    public static SitesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = SitesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        SitesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (SitesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a SitesRecord record using a where and order by clause.
    /// </summary>
    public static SitesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = SitesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        SitesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (SitesRecord)recList[0];
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

        return SitesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return SitesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        SitesRecord[] recs = GetRecords(where);
        return  SitesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        SitesRecord[] recs = GetRecords(join, where);
        return  SitesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        SitesRecord[] recs = GetRecords(where, orderBy);
        return  SitesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        SitesRecord[] recs = GetRecords(join, where, orderBy);
        return  SitesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SitesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  SitesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SitesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  SitesTable.Instance.CreateDataTable(recs, null);
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
        SitesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  SitesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return SitesTable.Instance.ExportRecordData(whereFilter);
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

        return SitesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return SitesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return SitesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return SitesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return SitesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return SitesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return SitesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return SitesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = SitesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = SitesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static SitesRecord GetRecord(string id, bool bMutable)
        {
            return (SitesRecord)SitesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static SitesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (SitesRecord)SitesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string SiteNameValue, 
        string GroupIdValue, 
        string CustomerIdValue, 
        string TotalFloorSpaceSqMetersValue, 
        string LandSqMetersValue, 
        string ProductiveFloorSpaceSqMetersValue, 
        string Address1Value, 
        string Address2Value, 
        string Address3Value, 
        string GroupDivisionIdValue, 
        string IndustryIdValue, 
        string FiledInvoiceCountValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(SiteNameValue, SiteNameColumn);
        rec.SetString(GroupIdValue, GroupIdColumn);
        rec.SetString(CustomerIdValue, CustomerIdColumn);
        rec.SetString(TotalFloorSpaceSqMetersValue, TotalFloorSpaceSqMetersColumn);
        rec.SetString(LandSqMetersValue, LandSqMetersColumn);
        rec.SetString(ProductiveFloorSpaceSqMetersValue, ProductiveFloorSpaceSqMetersColumn);
        rec.SetString(Address1Value, Address1Column);
        rec.SetString(Address2Value, Address2Column);
        rec.SetString(Address3Value, Address3Column);
        rec.SetString(GroupDivisionIdValue, GroupDivisionIdColumn);
        rec.SetString(IndustryIdValue, IndustryIdColumn);
        rec.SetString(FiledInvoiceCountValue, FiledInvoiceCountColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			SitesTable.Instance.DeleteOneRecord(kv);
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
				SitesTable.GetRecord(kv, false);
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
            if (!(SitesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return SitesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(SitesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = SitesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = SitesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (SitesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = SitesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = SitesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = SitesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
