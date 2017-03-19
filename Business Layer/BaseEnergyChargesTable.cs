// This class is "generated" and will be overwritten.
// Your customizations should be made in EnergyChargesTable.cs


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
/// The generated superclass for the <see cref="EnergyChargesTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoPortal%dbo.EnergyCharges.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="EnergyChargesTable.Instance">EnergyChargesTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="EnergyChargesTable"></seealso>
[SerializableAttribute()]
public class BaseEnergyChargesTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = EnergyChargesDefinition.GetXMLString();







    protected BaseEnergyChargesTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.EnergyChargesTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.EnergyChargesRecord");
        this.ApplicationName = "IDE";
        this.DataAdapter = new EnergyChargesSqlTable();
        ((EnergyChargesSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        EnergyChargeIdColumn.CodeName = "EnergyChargeId";
        BD0004Column.CodeName = "BD0004";
        BD0004Column.DefaultValue = EvaluateFormula("0");
        BD0004Column.Name = EvaluateFormula("\"Weekday 0000 - 0400\"");
        BD0408Column.CodeName = "BD0408";
        BD0408Column.DefaultValue = EvaluateFormula("0");
        BD0408Column.Name = EvaluateFormula("\"Weekday 0400 - 0800\"");
        BD0812Column.CodeName = "BD0812";
        BD0812Column.DefaultValue = EvaluateFormula("0");
        BD0812Column.Name = EvaluateFormula("\"Weekday 0800 - 1200\"");
        BD1216Column.CodeName = "BD1216";
        BD1216Column.DefaultValue = EvaluateFormula("0");
        BD1216Column.Name = EvaluateFormula("\"Weekday 1200 - 1600\"");
        BD1620Column.CodeName = "BD1620";
        BD1620Column.DefaultValue = EvaluateFormula("0");
        BD1620Column.Name = EvaluateFormula("\"Weekday 1600 - 2000\"");
        BD2024Column.CodeName = "BD2024";
        BD2024Column.DefaultValue = EvaluateFormula("0");
        BD2024Column.Name = EvaluateFormula("\"Weekday 2000 - 2400\"");
        NBD0004Column.CodeName = "NBD0004";
        NBD0004Column.DefaultValue = EvaluateFormula("0");
        NBD0004Column.Name = EvaluateFormula("\"Weekend 0000 - 0400\"");
        NBD0408Column.CodeName = "NBD0408";
        NBD0408Column.DefaultValue = EvaluateFormula("0");
        NBD0408Column.Name = EvaluateFormula("\"Weekend 0400 - 0800\"");
        NBD0812Column.CodeName = "NBD0812";
        NBD0812Column.DefaultValue = EvaluateFormula("0");
        NBD0812Column.Name = EvaluateFormula("\"Weekend 0800 - 1200\"");
        NBD1216Column.CodeName = "NBD1216";
        NBD1216Column.DefaultValue = EvaluateFormula("0");
        NBD1216Column.Name = EvaluateFormula("\"Weekend 1200 - 1600\"");
        NBD1620Column.CodeName = "NBD1620";
        NBD1620Column.DefaultValue = EvaluateFormula("0");
        NBD1620Column.Name = EvaluateFormula("\"Weekend 1600 - 2000\"");
        NBD2024Column.CodeName = "NBD2024";
        NBD2024Column.DefaultValue = EvaluateFormula("0");
        NBD2024Column.Name = EvaluateFormula("\"Weekend 2000 - 2400\"");
        BD0004RColumn.CodeName = "BD0004R";
        BD0004RColumn.Name = EvaluateFormula("\"Busness Day 0004 Rate\"");
        BD0408RColumn.CodeName = "BD0408R";
        BD0812RColumn.CodeName = "BD0812R";
        BD1216RColumn.CodeName = "BD1216R";
        BD1620RColumn.CodeName = "BD1620R";
        BD2024RColumn.CodeName = "BD2024R";
        NBD0004RColumn.CodeName = "NBD0004R";
        NBD0004RColumn.Name = EvaluateFormula("\"Non Business Day 0004 Rate\"");
        NBD0408RColumn.CodeName = "NBD0408R";
        NBD0812RColumn.CodeName = "NBD0812R";
        NBD1216RColumn.CodeName = "NBD1216R";
        NBD1620RColumn.CodeName = "NBD1620R";
        NBD2024RColumn.CodeName = "NBD2024R";
        BDQ0004Column.CodeName = "BDQ0004";
        BDQ0004Column.Name = EvaluateFormula("\"Quantity 00:00 - 00:04\"");
        BDL0004Column.CodeName = "BDL0004";
        BDL0004Column.Name = EvaluateFormula("\"Losses 00:00 - 00:04\"");

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.EnergyChargeId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EnergyChargeIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.EnergyChargeId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EnergyChargeId
    {
        get
        {
            return EnergyChargesTable.Instance.EnergyChargeIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0004 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD0004Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0004 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD0004
    {
        get
        {
            return EnergyChargesTable.Instance.BD0004Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0408 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD0408Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0408 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD0408
    {
        get
        {
            return EnergyChargesTable.Instance.BD0408Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0812 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD0812Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0812 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD0812
    {
        get
        {
            return EnergyChargesTable.Instance.BD0812Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1216 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD1216Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1216 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD1216
    {
        get
        {
            return EnergyChargesTable.Instance.BD1216Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1620 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD1620Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1620 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD1620
    {
        get
        {
            return EnergyChargesTable.Instance.BD1620Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD2024 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD2024Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD2024 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD2024
    {
        get
        {
            return EnergyChargesTable.Instance.BD2024Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0004 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD0004Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0004 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD0004
    {
        get
        {
            return EnergyChargesTable.Instance.NBD0004Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0408 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD0408Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0408 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD0408
    {
        get
        {
            return EnergyChargesTable.Instance.NBD0408Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0812 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD0812Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0812 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD0812
    {
        get
        {
            return EnergyChargesTable.Instance.NBD0812Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1216 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD1216Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1216 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD1216
    {
        get
        {
            return EnergyChargesTable.Instance.NBD1216Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1620 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD1620Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1620 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD1620
    {
        get
        {
            return EnergyChargesTable.Instance.NBD1620Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD2024 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD2024Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD2024 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD2024
    {
        get
        {
            return EnergyChargesTable.Instance.NBD2024Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0004R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD0004RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0004R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD0004R
    {
        get
        {
            return EnergyChargesTable.Instance.BD0004RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0408R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD0408RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0408R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD0408R
    {
        get
        {
            return EnergyChargesTable.Instance.BD0408RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0812R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD0812RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD0812R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD0812R
    {
        get
        {
            return EnergyChargesTable.Instance.BD0812RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1216R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD1216RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1216R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD1216R
    {
        get
        {
            return EnergyChargesTable.Instance.BD1216RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1620R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD1620RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD1620R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD1620R
    {
        get
        {
            return EnergyChargesTable.Instance.BD1620RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD2024R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BD2024RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BD2024R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BD2024R
    {
        get
        {
            return EnergyChargesTable.Instance.BD2024RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0004R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD0004RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0004R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD0004R
    {
        get
        {
            return EnergyChargesTable.Instance.NBD0004RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0408R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD0408RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0408R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD0408R
    {
        get
        {
            return EnergyChargesTable.Instance.NBD0408RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0812R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD0812RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD0812R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD0812R
    {
        get
        {
            return EnergyChargesTable.Instance.NBD0812RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1216R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD1216RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1216R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD1216R
    {
        get
        {
            return EnergyChargesTable.Instance.NBD1216RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1620R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD1620RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD1620R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD1620R
    {
        get
        {
            return EnergyChargesTable.Instance.NBD1620RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD2024R column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn NBD2024RColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.NBD2024R column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn NBD2024R
    {
        get
        {
            return EnergyChargesTable.Instance.NBD2024RColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BDQ0004 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BDQ0004Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BDQ0004 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BDQ0004
    {
        get
        {
            return EnergyChargesTable.Instance.BDQ0004Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BDL0004 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn BDL0004Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's EnergyCharges_.BDL0004 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn BDL0004
    {
        get
        {
            return EnergyChargesTable.Instance.BDL0004Column;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyChargesRecord records using a where clause.
    /// </summary>
    public static EnergyChargesRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyChargesRecord records using a where clause.
    /// </summary>
    public static EnergyChargesRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyChargesRecord records using a where and order by clause.
    /// </summary>
    public static EnergyChargesRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of EnergyChargesRecord records using a where and order by clause.
    /// </summary>
    public static EnergyChargesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyChargesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static EnergyChargesRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (EnergyChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.EnergyChargesRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyChargesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static EnergyChargesRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (EnergyChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.EnergyChargesRecord"));
    }   


    public static EnergyChargesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (EnergyChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.EnergyChargesRecord"));
    }

    public static EnergyChargesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (EnergyChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.EnergyChargesRecord"));
    }


    public static EnergyChargesRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (EnergyChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.EnergyChargesRecord"));
    }

    public static EnergyChargesRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (EnergyChargesRecord[])recList.ToArray(Type.GetType("IDE.Business.EnergyChargesRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)EnergyChargesTable.Instance.GetCountResponseForPost(EnergyChargesTable.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of EnergyChargesRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = EnergyChargesTable.Instance.GetRecordListResponseForPost(EnergyChargesTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)EnergyChargesTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)EnergyChargesTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)EnergyChargesTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)EnergyChargesTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a EnergyChargesRecord record using a where clause.
    /// </summary>
    public static EnergyChargesRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EnergyChargesRecord record using a where clause.
    /// </summary>
    public static EnergyChargesRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a EnergyChargesRecord record using a where and order by clause.
    /// </summary>
    public static EnergyChargesRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        EnergyChargesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (EnergyChargesRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EnergyChargesRecord record using a where and order by clause.
    /// </summary>
    public static EnergyChargesRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = EnergyChargesTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        EnergyChargesRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (EnergyChargesRecord)recList[0];
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

        return EnergyChargesTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return EnergyChargesTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        EnergyChargesRecord[] recs = GetRecords(where);
        return  EnergyChargesTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        EnergyChargesRecord[] recs = GetRecords(join, where);
        return  EnergyChargesTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        EnergyChargesRecord[] recs = GetRecords(where, orderBy);
        return  EnergyChargesTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        EnergyChargesRecord[] recs = GetRecords(join, where, orderBy);
        return  EnergyChargesTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        EnergyChargesRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  EnergyChargesTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        EnergyChargesRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  EnergyChargesTable.Instance.CreateDataTable(recs, null);
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
        EnergyChargesTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  EnergyChargesTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return EnergyChargesTable.Instance.ExportRecordData(whereFilter);
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

        return EnergyChargesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return EnergyChargesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return EnergyChargesTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return EnergyChargesTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return EnergyChargesTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return EnergyChargesTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return EnergyChargesTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return EnergyChargesTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = EnergyChargesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = EnergyChargesTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static EnergyChargesRecord GetRecord(string id, bool bMutable)
        {
            return (EnergyChargesRecord)EnergyChargesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static EnergyChargesRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (EnergyChargesRecord)EnergyChargesTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string EnergyChargeIdValue, 
        string BD0004Value, 
        string BD0408Value, 
        string BD0812Value, 
        string BD1216Value, 
        string BD1620Value, 
        string BD2024Value, 
        string NBD0004Value, 
        string NBD0408Value, 
        string NBD0812Value, 
        string NBD1216Value, 
        string NBD1620Value, 
        string NBD2024Value, 
        string BD0004RValue, 
        string BD0408RValue, 
        string BD0812RValue, 
        string BD1216RValue, 
        string BD1620RValue, 
        string BD2024RValue, 
        string NBD0004RValue, 
        string NBD0408RValue, 
        string NBD0812RValue, 
        string NBD1216RValue, 
        string NBD1620RValue, 
        string NBD2024RValue, 
        string BDQ0004Value, 
        string BDL0004Value
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(EnergyChargeIdValue, EnergyChargeIdColumn);
        rec.SetString(BD0004Value, BD0004Column);
        rec.SetString(BD0408Value, BD0408Column);
        rec.SetString(BD0812Value, BD0812Column);
        rec.SetString(BD1216Value, BD1216Column);
        rec.SetString(BD1620Value, BD1620Column);
        rec.SetString(BD2024Value, BD2024Column);
        rec.SetString(NBD0004Value, NBD0004Column);
        rec.SetString(NBD0408Value, NBD0408Column);
        rec.SetString(NBD0812Value, NBD0812Column);
        rec.SetString(NBD1216Value, NBD1216Column);
        rec.SetString(NBD1620Value, NBD1620Column);
        rec.SetString(NBD2024Value, NBD2024Column);
        rec.SetString(BD0004RValue, BD0004RColumn);
        rec.SetString(BD0408RValue, BD0408RColumn);
        rec.SetString(BD0812RValue, BD0812RColumn);
        rec.SetString(BD1216RValue, BD1216RColumn);
        rec.SetString(BD1620RValue, BD1620RColumn);
        rec.SetString(BD2024RValue, BD2024RColumn);
        rec.SetString(NBD0004RValue, NBD0004RColumn);
        rec.SetString(NBD0408RValue, NBD0408RColumn);
        rec.SetString(NBD0812RValue, NBD0812RColumn);
        rec.SetString(NBD1216RValue, NBD1216RColumn);
        rec.SetString(NBD1620RValue, NBD1620RColumn);
        rec.SetString(NBD2024RValue, NBD2024RColumn);
        rec.SetString(BDQ0004Value, BDQ0004Column);
        rec.SetString(BDL0004Value, BDL0004Column);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			EnergyChargesTable.Instance.DeleteOneRecord(kv);
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
				EnergyChargesTable.GetRecord(kv, false);
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
            if (!(EnergyChargesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return EnergyChargesTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(EnergyChargesTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = EnergyChargesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = EnergyChargesTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (EnergyChargesTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = EnergyChargesTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = EnergyChargesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = EnergyChargesTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
