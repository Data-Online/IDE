// This class is "generated" and will be overwritten.
// Your customizations should be made in OtherChargesTable.cs


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
/// The generated superclass for the <see cref="OtherChargesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoPortal%dbo.OtherCharges.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="OtherChargesTable.Instance">OtherChargesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="OtherChargesTable"></seealso>
[SerializableAttribute()]
public class BaseOtherChargesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = OtherChargesDefinition.GetXMLString();







    protected BaseOtherChargesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.OtherChargesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.OtherChargesRecord");
        this.ApplicationName = "IDE";
        this.DataAdapter = new OtherChargesSqlTable();
        ((OtherChargesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        OtherChargeIdColumn.CodeName = "OtherChargeId";
        BDSVCColumn.CodeName = "BDSVC";
        BDSVCColumn.DefaultValue = EvaluateFormula("0");
        BDSVCColumn.Name = EvaluateFormula("\"Energy Service Charge Business Day (Weekday)\"");
        BDSVCRColumn.CodeName = "BDSVCR";
        BDSVCRColumn.DefaultValue = EvaluateFormula("0");
        BDSVCRColumn.Name = EvaluateFormula("\"Business Day (Weekday) Service Rate\"");
        NBDSVCColumn.CodeName = "NBDSVC";
        NBDSVCColumn.DefaultValue = EvaluateFormula("0");
        NBDSVCColumn.Name = EvaluateFormula("\"Energy Service Charge NON Business Day (Weekend)\"");
        NBDSVCRColumn.CodeName = "NBDSVCR";
        NBDSVCRColumn.DefaultValue = EvaluateFormula("0");
        NBDSVCRColumn.Name = EvaluateFormula("\"Non Business Day (Weekend) Service Rate\"");
        EALevyColumn.CodeName = "EALevy";
        EALevyColumn.DefaultValue = EvaluateFormula("0");
        EALevyColumn.Name = EvaluateFormula("\"Electricity Authority Charge / EA Levy\"");
        EALevyRColumn.CodeName = "EALevyR";
        EALevyRColumn.DefaultValue = EvaluateFormula("0");
        EALevyRColumn.Name = EvaluateFormula("\"Electricity Authority Rate / EA Levy Rate\"");
        AdminChargeColumn.CodeName = "AdminCharge";
        AdminChargeColumn.DefaultValue = EvaluateFormula("\"0\"");
        AdminChargeColumn.Name = EvaluateFormula("\"Other Charges Total\"");

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.OtherChargeId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OtherChargeIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.OtherChargeId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OtherChargeId
    {
        get
        {
            return OtherChargesTable.Instance.OtherChargeIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.BDSVC column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BDSVCColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.BDSVC column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BDSVC
    {
        get
        {
            return OtherChargesTable.Instance.BDSVCColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.BDSVCR column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BDSVCRColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.BDSVCR column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BDSVCR
    {
        get
        {
            return OtherChargesTable.Instance.BDSVCRColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.NBDSVC column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBDSVCColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.NBDSVC column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBDSVC
    {
        get
        {
            return OtherChargesTable.Instance.NBDSVCColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.NBDSVCR column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBDSVCRColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.NBDSVCR column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBDSVCR
    {
        get
        {
            return OtherChargesTable.Instance.NBDSVCRColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.EALevy column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EALevyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.EALevy column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EALevy
    {
        get
        {
            return OtherChargesTable.Instance.EALevyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.EALevyR column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EALevyRColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.EALevyR column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EALevyR
    {
        get
        {
            return OtherChargesTable.Instance.EALevyRColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.AdminCharge column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn AdminChargeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OtherCharges_.AdminCharge column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn AdminCharge
    {
        get
        {
            return OtherChargesTable.Instance.AdminChargeColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of OtherChargesRecord records using a where clause.
    /// </summary>
    public static OtherChargesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of OtherChargesRecord records using a where clause.
    /// </summary>
    public static OtherChargesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of OtherChargesRecord records using a where and order by clause.
    /// </summary>
    public static OtherChargesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of OtherChargesRecord records using a where and order by clause.
    /// </summary>
    public static OtherChargesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of OtherChargesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static OtherChargesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (OtherChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.OtherChargesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of OtherChargesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static OtherChargesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (OtherChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.OtherChargesRecord"));
    }   


    public static OtherChargesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (OtherChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.OtherChargesRecord"));
    }

    public static OtherChargesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (OtherChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.OtherChargesRecord"));
    }


    public static OtherChargesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (OtherChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.OtherChargesRecord"));
    }

    public static OtherChargesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (OtherChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.OtherChargesRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)OtherChargesTable.Instance.GetCountResponseForPost(OtherChargesTable.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of OtherChargesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = OtherChargesTable.Instance.GetRecordListResponseForPost(OtherChargesTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)OtherChargesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)OtherChargesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)OtherChargesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)OtherChargesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a OtherChargesRecord record using a where clause.
    /// </summary>
    public static OtherChargesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a OtherChargesRecord record using a where clause.
    /// </summary>
    public static OtherChargesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a OtherChargesRecord record using a where and order by clause.
    /// </summary>
    public static OtherChargesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        OtherChargesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (OtherChargesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a OtherChargesRecord record using a where and order by clause.
    /// </summary>
    public static OtherChargesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = OtherChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        OtherChargesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (OtherChargesRecord)recList[0];
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

        return OtherChargesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return OtherChargesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        OtherChargesRecord[] recs = GetRecords(where);
        return  OtherChargesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        OtherChargesRecord[] recs = GetRecords(join, where);
        return  OtherChargesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        OtherChargesRecord[] recs = GetRecords(where, orderBy);
        return  OtherChargesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        OtherChargesRecord[] recs = GetRecords(join, where, orderBy);
        return  OtherChargesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        OtherChargesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  OtherChargesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        OtherChargesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  OtherChargesTable.Instance.CreateDataTable(recs, null);
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
        OtherChargesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  OtherChargesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return OtherChargesTable.Instance.ExportRecordData(whereFilter);
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

        return OtherChargesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return OtherChargesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return OtherChargesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return OtherChargesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return OtherChargesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return OtherChargesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return OtherChargesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return OtherChargesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = OtherChargesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = OtherChargesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static OtherChargesRecord GetRecord(string id, bool bMutable)
        {
            return (OtherChargesRecord)OtherChargesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static OtherChargesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (OtherChargesRecord)OtherChargesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string OtherChargeIdValue, 
        string BDSVCValue, 
        string BDSVCRValue, 
        string NBDSVCValue, 
        string NBDSVCRValue, 
        string EALevyValue, 
        string EALevyRValue, 
        string AdminChargeValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(OtherChargeIdValue, OtherChargeIdColumn);
        rec.SetString(BDSVCValue, BDSVCColumn);
        rec.SetString(BDSVCRValue, BDSVCRColumn);
        rec.SetString(NBDSVCValue, NBDSVCColumn);
        rec.SetString(NBDSVCRValue, NBDSVCRColumn);
        rec.SetString(EALevyValue, EALevyColumn);
        rec.SetString(EALevyRValue, EALevyRColumn);
        rec.SetString(AdminChargeValue, AdminChargeColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			OtherChargesTable.Instance.DeleteOneRecord(kv);
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
				OtherChargesTable.GetRecord(kv, false);
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
            if (!(OtherChargesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return OtherChargesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(OtherChargesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = OtherChargesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = OtherChargesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (OtherChargesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = OtherChargesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = OtherChargesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = OtherChargesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
