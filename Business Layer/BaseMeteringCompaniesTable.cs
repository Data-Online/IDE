// This class is "generated" and will be overwritten.
// Your customizations should be made in MeteringCompaniesTable.cs


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
/// The generated superclass for the <see cref="MeteringCompaniesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoNZ%dbo.MeteringCompanies.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="MeteringCompaniesTable.Instance">MeteringCompaniesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="MeteringCompaniesTable"></seealso>
[SerializableAttribute()]
public class BaseMeteringCompaniesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = MeteringCompaniesDefinition.GetXMLString();







    protected BaseMeteringCompaniesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.MeteringCompaniesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.MeteringCompaniesRecord");
        this.ApplicationName = "IDE";
        this.DataAdapter = new MeteringCompaniesSqlTable();
        ((MeteringCompaniesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        MeteringCompanyIdColumn.CodeName = "MeteringCompanyId";
        MeteringCompanyNameColumn.CodeName = "MeteringCompanyName";
        MeteringCompanyLogoColumn.CodeName = "MeteringCompanyLogo";
        Address1Column.CodeName = "Address1";
        Address2Column.CodeName = "Address2";
        Address3Column.CodeName = "Address3";
        CityColumn.CodeName = "City";
        PostCodeColumn.CodeName = "PostCode";
        PhoneColumn.CodeName = "Phone";
        ContactColumn.CodeName = "Contact";
        eMailColumn.CodeName = "eMail";
        Enabled0Column.CodeName = "Enabled0";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.MeteringCompanyId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MeteringCompanyIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.MeteringCompanyId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MeteringCompanyId
    {
        get
        {
            return MeteringCompaniesTable.Instance.MeteringCompanyIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.MeteringCompanyName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MeteringCompanyNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.MeteringCompanyName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MeteringCompanyName
    {
        get
        {
            return MeteringCompaniesTable.Instance.MeteringCompanyNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.MeteringCompanyLogo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MeteringCompanyLogoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.MeteringCompanyLogo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MeteringCompanyLogo
    {
        get
        {
            return MeteringCompaniesTable.Instance.MeteringCompanyLogoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return MeteringCompaniesTable.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return MeteringCompaniesTable.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return MeteringCompaniesTable.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.City column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.City column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn City
    {
        get
        {
            return MeteringCompaniesTable.Instance.CityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.PostCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PostCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.PostCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PostCode
    {
        get
        {
            return MeteringCompaniesTable.Instance.PostCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Phone column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PhoneColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Phone column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Phone
    {
        get
        {
            return MeteringCompaniesTable.Instance.PhoneColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Contact column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ContactColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Contact column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Contact
    {
        get
        {
            return MeteringCompaniesTable.Instance.ContactColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.eMail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn eMailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.eMail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn eMail
    {
        get
        {
            return MeteringCompaniesTable.Instance.eMailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Enabled column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Enabled0Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeteringCompanies_.Enabled column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Enabled0
    {
        get
        {
            return MeteringCompaniesTable.Instance.Enabled0Column;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of MeteringCompaniesRecord records using a where clause.
    /// </summary>
    public static MeteringCompaniesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MeteringCompaniesRecord records using a where clause.
    /// </summary>
    public static MeteringCompaniesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of MeteringCompaniesRecord records using a where and order by clause.
    /// </summary>
    public static MeteringCompaniesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of MeteringCompaniesRecord records using a where and order by clause.
    /// </summary>
    public static MeteringCompaniesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MeteringCompaniesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static MeteringCompaniesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (MeteringCompaniesRecord[])recList.ToArray(Type.GetType("IDE.Business.MeteringCompaniesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MeteringCompaniesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static MeteringCompaniesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (MeteringCompaniesRecord[])recList.ToArray(Type.GetType("IDE.Business.MeteringCompaniesRecord"));
    }   


    public static MeteringCompaniesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (MeteringCompaniesRecord[])recList.ToArray(Type.GetType("IDE.Business.MeteringCompaniesRecord"));
    }

    public static MeteringCompaniesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (MeteringCompaniesRecord[])recList.ToArray(Type.GetType("IDE.Business.MeteringCompaniesRecord"));
    }


    public static MeteringCompaniesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (MeteringCompaniesRecord[])recList.ToArray(Type.GetType("IDE.Business.MeteringCompaniesRecord"));
    }

    public static MeteringCompaniesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (MeteringCompaniesRecord[])recList.ToArray(Type.GetType("IDE.Business.MeteringCompaniesRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)MeteringCompaniesTable.Instance.GetCountResponseForPost(MeteringCompaniesTable.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of MeteringCompaniesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = MeteringCompaniesTable.Instance.GetRecordListResponseForPost(MeteringCompaniesTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)MeteringCompaniesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)MeteringCompaniesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)MeteringCompaniesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)MeteringCompaniesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a MeteringCompaniesRecord record using a where clause.
    /// </summary>
    public static MeteringCompaniesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MeteringCompaniesRecord record using a where clause.
    /// </summary>
    public static MeteringCompaniesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a MeteringCompaniesRecord record using a where and order by clause.
    /// </summary>
    public static MeteringCompaniesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        MeteringCompaniesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (MeteringCompaniesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MeteringCompaniesRecord record using a where and order by clause.
    /// </summary>
    public static MeteringCompaniesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = MeteringCompaniesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        MeteringCompaniesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (MeteringCompaniesRecord)recList[0];
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

        return MeteringCompaniesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return MeteringCompaniesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        MeteringCompaniesRecord[] recs = GetRecords(where);
        return  MeteringCompaniesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        MeteringCompaniesRecord[] recs = GetRecords(join, where);
        return  MeteringCompaniesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        MeteringCompaniesRecord[] recs = GetRecords(where, orderBy);
        return  MeteringCompaniesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        MeteringCompaniesRecord[] recs = GetRecords(join, where, orderBy);
        return  MeteringCompaniesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        MeteringCompaniesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  MeteringCompaniesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        MeteringCompaniesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  MeteringCompaniesTable.Instance.CreateDataTable(recs, null);
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
        MeteringCompaniesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  MeteringCompaniesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return MeteringCompaniesTable.Instance.ExportRecordData(whereFilter);
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

        return MeteringCompaniesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return MeteringCompaniesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return MeteringCompaniesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return MeteringCompaniesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return MeteringCompaniesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return MeteringCompaniesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return MeteringCompaniesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return MeteringCompaniesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = MeteringCompaniesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = MeteringCompaniesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static MeteringCompaniesRecord GetRecord(string id, bool bMutable)
        {
            return (MeteringCompaniesRecord)MeteringCompaniesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static MeteringCompaniesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (MeteringCompaniesRecord)MeteringCompaniesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string MeteringCompanyNameValue, 
        string MeteringCompanyLogoValue, 
        string Address1Value, 
        string Address2Value, 
        string Address3Value, 
        string CityValue, 
        string PostCodeValue, 
        string PhoneValue, 
        string ContactValue, 
        string eMailValue, 
        string Enabled0Value
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(MeteringCompanyNameValue, MeteringCompanyNameColumn);
        rec.SetString(MeteringCompanyLogoValue, MeteringCompanyLogoColumn);
        rec.SetString(Address1Value, Address1Column);
        rec.SetString(Address2Value, Address2Column);
        rec.SetString(Address3Value, Address3Column);
        rec.SetString(CityValue, CityColumn);
        rec.SetString(PostCodeValue, PostCodeColumn);
        rec.SetString(PhoneValue, PhoneColumn);
        rec.SetString(ContactValue, ContactColumn);
        rec.SetString(eMailValue, eMailColumn);
        rec.SetString(Enabled0Value, Enabled0Column);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			MeteringCompaniesTable.Instance.DeleteOneRecord(kv);
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
				MeteringCompaniesTable.GetRecord(kv, false);
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
            if (!(MeteringCompaniesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return MeteringCompaniesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(MeteringCompaniesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = MeteringCompaniesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = MeteringCompaniesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (MeteringCompaniesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = MeteringCompaniesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = MeteringCompaniesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = MeteringCompaniesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
