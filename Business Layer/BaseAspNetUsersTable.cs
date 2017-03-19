// This class is "generated" and will be overwritten.
// Your customizations should be made in AspNetUsersTable.cs


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
/// The generated superclass for the <see cref="AspNetUsersTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoPortal%dbo.AspNetUsers.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="AspNetUsersTable.Instance">AspNetUsersTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="AspNetUsersTable"></seealso>
[SerializableAttribute()]
public class BaseAspNetUsersTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = AspNetUsersDefinition.GetXMLString();







    protected BaseAspNetUsersTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.AspNetUsersTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.AspNetUsersRecord");
        this.ApplicationName = "IDE";
        this.DataAdapter = new AspNetUsersSqlTable();
        ((AspNetUsersSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        Id0Column.CodeName = "Id0";
        EmailColumn.CodeName = "Email";
        EmailConfirmedColumn.CodeName = "EmailConfirmed";
        PasswordHashColumn.CodeName = "PasswordHash";
        SecurityStampColumn.CodeName = "SecurityStamp";
        PhoneNumberColumn.CodeName = "PhoneNumber";
        PhoneNumberConfirmedColumn.CodeName = "PhoneNumberConfirmed";
        TwoFactorEnabledColumn.CodeName = "TwoFactorEnabled";
        LockoutEndDateUtcColumn.CodeName = "LockoutEndDateUtc";
        LockoutEnabledColumn.CodeName = "LockoutEnabled";
        AccessFailedCountColumn.CodeName = "AccessFailedCount";
        UserName0Column.CodeName = "UserName0";
        FirstNameColumn.CodeName = "FirstName";
        LastNameColumn.CodeName = "LastName";
        CompanyLogoColumn.CodeName = "CompanyLogo";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.Id column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Id0Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.Id column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Id0
    {
        get
        {
            return AspNetUsersTable.Instance.Id0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.Email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn EmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.Email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn Email
    {
        get
        {
            return AspNetUsersTable.Instance.EmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.EmailConfirmed column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn EmailConfirmedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.EmailConfirmed column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn EmailConfirmed
    {
        get
        {
            return AspNetUsersTable.Instance.EmailConfirmedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.PasswordHash column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn PasswordHashColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.PasswordHash column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn PasswordHash
    {
        get
        {
            return AspNetUsersTable.Instance.PasswordHashColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.SecurityStamp column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn SecurityStampColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.SecurityStamp column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn SecurityStamp
    {
        get
        {
            return AspNetUsersTable.Instance.SecurityStampColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.PhoneNumber column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn PhoneNumberColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.PhoneNumber column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn PhoneNumber
    {
        get
        {
            return AspNetUsersTable.Instance.PhoneNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.PhoneNumberConfirmed column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PhoneNumberConfirmedColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.PhoneNumberConfirmed column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PhoneNumberConfirmed
    {
        get
        {
            return AspNetUsersTable.Instance.PhoneNumberConfirmedColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.TwoFactorEnabled column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn TwoFactorEnabledColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.TwoFactorEnabled column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn TwoFactorEnabled
    {
        get
        {
            return AspNetUsersTable.Instance.TwoFactorEnabledColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.LockoutEndDateUtc column object.
    /// </summary>
    public BaseClasses.Data.DateColumn LockoutEndDateUtcColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.LockoutEndDateUtc column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn LockoutEndDateUtc
    {
        get
        {
            return AspNetUsersTable.Instance.LockoutEndDateUtcColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.LockoutEnabled column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn LockoutEnabledColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.LockoutEnabled column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn LockoutEnabled
    {
        get
        {
            return AspNetUsersTable.Instance.LockoutEnabledColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.AccessFailedCount column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn AccessFailedCountColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.AccessFailedCount column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn AccessFailedCount
    {
        get
        {
            return AspNetUsersTable.Instance.AccessFailedCountColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.UserName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn UserName0Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.UserName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn UserName0
    {
        get
        {
            return AspNetUsersTable.Instance.UserName0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.FirstName column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn FirstNameColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.FirstName column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn FirstName
    {
        get
        {
            return AspNetUsersTable.Instance.FirstNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.LastName column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn LastNameColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.LastName column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn LastName
    {
        get
        {
            return AspNetUsersTable.Instance.LastNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.CompanyLogo column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn CompanyLogoColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AspNetUsers_.CompanyLogo column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn CompanyLogo
    {
        get
        {
            return AspNetUsersTable.Instance.CompanyLogoColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of AspNetUsersRecord records using a where clause.
    /// </summary>
    public static AspNetUsersRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of AspNetUsersRecord records using a where clause.
    /// </summary>
    public static AspNetUsersRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of AspNetUsersRecord records using a where and order by clause.
    /// </summary>
    public static AspNetUsersRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of AspNetUsersRecord records using a where and order by clause.
    /// </summary>
    public static AspNetUsersRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of AspNetUsersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static AspNetUsersRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (AspNetUsersRecord[])recList.ToArray(Type.GetType("IDE.Business.AspNetUsersRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of AspNetUsersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static AspNetUsersRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (AspNetUsersRecord[])recList.ToArray(Type.GetType("IDE.Business.AspNetUsersRecord"));
    }   


    public static AspNetUsersRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (AspNetUsersRecord[])recList.ToArray(Type.GetType("IDE.Business.AspNetUsersRecord"));
    }

    public static AspNetUsersRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (AspNetUsersRecord[])recList.ToArray(Type.GetType("IDE.Business.AspNetUsersRecord"));
    }


    public static AspNetUsersRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (AspNetUsersRecord[])recList.ToArray(Type.GetType("IDE.Business.AspNetUsersRecord"));
    }

    public static AspNetUsersRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (AspNetUsersRecord[])recList.ToArray(Type.GetType("IDE.Business.AspNetUsersRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)AspNetUsersTable.Instance.GetCountResponseForPost(AspNetUsersTable.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of AspNetUsersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = AspNetUsersTable.Instance.GetRecordListResponseForPost(AspNetUsersTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)AspNetUsersTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)AspNetUsersTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)AspNetUsersTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)AspNetUsersTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a AspNetUsersRecord record using a where clause.
    /// </summary>
    public static AspNetUsersRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a AspNetUsersRecord record using a where clause.
    /// </summary>
    public static AspNetUsersRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a AspNetUsersRecord record using a where and order by clause.
    /// </summary>
    public static AspNetUsersRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        AspNetUsersRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (AspNetUsersRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a AspNetUsersRecord record using a where and order by clause.
    /// </summary>
    public static AspNetUsersRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = AspNetUsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        AspNetUsersRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (AspNetUsersRecord)recList[0];
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

        return AspNetUsersTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return AspNetUsersTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        AspNetUsersRecord[] recs = GetRecords(where);
        return  AspNetUsersTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        AspNetUsersRecord[] recs = GetRecords(join, where);
        return  AspNetUsersTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        AspNetUsersRecord[] recs = GetRecords(where, orderBy);
        return  AspNetUsersTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        AspNetUsersRecord[] recs = GetRecords(join, where, orderBy);
        return  AspNetUsersTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        AspNetUsersRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  AspNetUsersTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        AspNetUsersRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  AspNetUsersTable.Instance.CreateDataTable(recs, null);
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
        AspNetUsersTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  AspNetUsersTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return AspNetUsersTable.Instance.ExportRecordData(whereFilter);
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

        return AspNetUsersTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return AspNetUsersTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return AspNetUsersTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return AspNetUsersTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return AspNetUsersTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return AspNetUsersTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return AspNetUsersTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return AspNetUsersTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = AspNetUsersTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = AspNetUsersTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static AspNetUsersRecord GetRecord(string id, bool bMutable)
        {
            return (AspNetUsersRecord)AspNetUsersTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static AspNetUsersRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (AspNetUsersRecord)AspNetUsersTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string Id0Value, 
        string EmailValue, 
        string EmailConfirmedValue, 
        string PasswordHashValue, 
        string SecurityStampValue, 
        string PhoneNumberValue, 
        string PhoneNumberConfirmedValue, 
        string TwoFactorEnabledValue, 
        string LockoutEndDateUtcValue, 
        string LockoutEnabledValue, 
        string AccessFailedCountValue, 
        string UserName0Value, 
        string FirstNameValue, 
        string LastNameValue, 
        string CompanyLogoValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(Id0Value, Id0Column);
        rec.SetString(EmailValue, EmailColumn);
        rec.SetString(EmailConfirmedValue, EmailConfirmedColumn);
        rec.SetString(PasswordHashValue, PasswordHashColumn);
        rec.SetString(SecurityStampValue, SecurityStampColumn);
        rec.SetString(PhoneNumberValue, PhoneNumberColumn);
        rec.SetString(PhoneNumberConfirmedValue, PhoneNumberConfirmedColumn);
        rec.SetString(TwoFactorEnabledValue, TwoFactorEnabledColumn);
        rec.SetString(LockoutEndDateUtcValue, LockoutEndDateUtcColumn);
        rec.SetString(LockoutEnabledValue, LockoutEnabledColumn);
        rec.SetString(AccessFailedCountValue, AccessFailedCountColumn);
        rec.SetString(UserName0Value, UserName0Column);
        rec.SetString(FirstNameValue, FirstNameColumn);
        rec.SetString(LastNameValue, LastNameColumn);
        rec.SetString(CompanyLogoValue, CompanyLogoColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			AspNetUsersTable.Instance.DeleteOneRecord(kv);
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
				AspNetUsersTable.GetRecord(kv, false);
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
            if (!(AspNetUsersTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return AspNetUsersTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(AspNetUsersTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = AspNetUsersTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = AspNetUsersTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (AspNetUsersTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = AspNetUsersTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = AspNetUsersTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = AspNetUsersTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
