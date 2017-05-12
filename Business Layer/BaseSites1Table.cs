// This class is "generated" and will be overwritten.
// Your customizations should be made in Sites1Table.cs


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
/// The generated superclass for the <see cref="Sites1Table"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseCimscoNZ%dbo.Sites.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="Sites1Table.Instance">Sites1Table.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="Sites1Table"></seealso>
[SerializableAttribute()]
public class BaseSites1Table : PrimaryKeyTable
{

    private readonly string TableDefinitionString = Sites1Definition.GetXMLString();







    protected BaseSites1Table()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.Sites1Table");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IDE.Business", "IDE.Business.Sites1Record");
        this.ApplicationName = "IDE";
        this.DataAdapter = new Sites1SqlTable();
        ((Sites1SqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        SiteIdColumn.CodeName = "SiteId";
        SiteLogoColumn.CodeName = "SiteLogo";
        SiteNameColumn.CodeName = "SiteName";
        Address1Column.CodeName = "Address1";
        Address2Column.CodeName = "Address2";
        Address3Column.CodeName = "Address3";
        CityIdColumn.CodeName = "CityId";
        PostCodeColumn.CodeName = "PostCode";
        PhoneColumn.CodeName = "Phone";
        ContactColumn.CodeName = "Contact";
        EmailColumn.CodeName = "Email";
        CustomerIdColumn.CodeName = "CustomerId";
        GroupIdColumn.CodeName = "GroupId";
        Enabled0Column.CodeName = "Enabled0";
        InvoiceApproverNameColumn.CodeName = "InvoiceApproverName";
        InvoiceApproverEmailColumn.CodeName = "InvoiceApproverEmail";
        InvoicePayerNameColumn.CodeName = "InvoicePayerName";
        InvoicePayerEmailColumn.CodeName = "InvoicePayerEmail";
        IndustryIdColumn.CodeName = "IndustryId";
        LandSqMetersColumn.CodeName = "LandSqMeters";
        TotalFloorSpaceSqMetersColumn.CodeName = "TotalFloorSpaceSqMeters";
        ProductiveFloorSpaceSqMetersColumn.CodeName = "ProductiveFloorSpaceSqMeters";
        BusinessDayStartTimeColumn.CodeName = "BusinessDayStartTime";
        BusinessDayEndTimeColumn.CodeName = "BusinessDayEndTime";
        NonBusinessDayStartTimeColumn.CodeName = "NonBusinessDayStartTime";
        NonBusinessDayEndTimeColumn.CodeName = "NonBusinessDayEndTime";
        SiteCategoryIdColumn.CodeName = "SiteCategoryId";
        CustomerDivisionIdColumn.CodeName = "CustomerDivisionId";
        GroupDivisionIdColumn.CodeName = "GroupDivisionId";
        RegionIdColumn.CodeName = "RegionId";
        JoinedGroupDateColumn.CodeName = "JoinedGroupDate";
        ParticipationStartDateColumn.CodeName = "ParticipationStartDate";
        ParticipationEndDateColumn.CodeName = "ParticipationEndDate";
        ParticipationRateColumn.CodeName = "ParticipationRate";

        
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
            return Sites1Table.Instance.SiteIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteLogo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SiteLogoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteLogo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SiteLogo
    {
        get
        {
            return Sites1Table.Instance.SiteLogoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SiteNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn SiteName
    {
        get
        {
            return Sites1Table.Instance.SiteNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return Sites1Table.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return Sites1Table.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return Sites1Table.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CityId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CityIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CityId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CityId
    {
        get
        {
            return Sites1Table.Instance.CityIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.PostCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PostCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.PostCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PostCode
    {
        get
        {
            return Sites1Table.Instance.PostCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Phone column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PhoneColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Phone column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Phone
    {
        get
        {
            return Sites1Table.Instance.PhoneColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Contact column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ContactColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Contact column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Contact
    {
        get
        {
            return Sites1Table.Instance.ContactColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Email column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn EmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Email column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn Email
    {
        get
        {
            return Sites1Table.Instance.EmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CustomerId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustomerIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CustomerId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustomerId
    {
        get
        {
            return Sites1Table.Instance.CustomerIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn GroupIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn GroupId
    {
        get
        {
            return Sites1Table.Instance.GroupIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Enabled column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn Enabled0Column
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.Enabled column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Enabled0
    {
        get
        {
            return Sites1Table.Instance.Enabled0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoiceApproverName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvoiceApproverNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoiceApproverName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvoiceApproverName
    {
        get
        {
            return Sites1Table.Instance.InvoiceApproverNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoiceApproverEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn InvoiceApproverEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoiceApproverEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn InvoiceApproverEmail
    {
        get
        {
            return Sites1Table.Instance.InvoiceApproverEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoicePayerName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn InvoicePayerNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoicePayerName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn InvoicePayerName
    {
        get
        {
            return Sites1Table.Instance.InvoicePayerNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoicePayerEmail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn InvoicePayerEmailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.InvoicePayerEmail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn InvoicePayerEmail
    {
        get
        {
            return Sites1Table.Instance.InvoicePayerEmailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.IndustryId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IndustryIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.IndustryId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IndustryId
    {
        get
        {
            return Sites1Table.Instance.IndustryIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.LandSqMeters column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LandSqMetersColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.LandSqMeters column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LandSqMeters
    {
        get
        {
            return Sites1Table.Instance.LandSqMetersColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.TotalFloorSpaceSqMeters column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TotalFloorSpaceSqMetersColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.TotalFloorSpaceSqMeters column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TotalFloorSpaceSqMeters
    {
        get
        {
            return Sites1Table.Instance.TotalFloorSpaceSqMetersColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ProductiveFloorSpaceSqMeters column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ProductiveFloorSpaceSqMetersColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ProductiveFloorSpaceSqMeters column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ProductiveFloorSpaceSqMeters
    {
        get
        {
            return Sites1Table.Instance.ProductiveFloorSpaceSqMetersColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.BusinessDayStartTime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn BusinessDayStartTimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.BusinessDayStartTime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn BusinessDayStartTime
    {
        get
        {
            return Sites1Table.Instance.BusinessDayStartTimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.BusinessDayEndTime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn BusinessDayEndTimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.BusinessDayEndTime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn BusinessDayEndTime
    {
        get
        {
            return Sites1Table.Instance.BusinessDayEndTimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.NonBusinessDayStartTime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn NonBusinessDayStartTimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.NonBusinessDayStartTime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn NonBusinessDayStartTime
    {
        get
        {
            return Sites1Table.Instance.NonBusinessDayStartTimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.NonBusinessDayEndTime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn NonBusinessDayEndTimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.NonBusinessDayEndTime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn NonBusinessDayEndTime
    {
        get
        {
            return Sites1Table.Instance.NonBusinessDayEndTimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteCategoryId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SiteCategoryIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.SiteCategoryId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SiteCategoryId
    {
        get
        {
            return Sites1Table.Instance.SiteCategoryIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CustomerDivisionId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CustomerDivisionIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.CustomerDivisionId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CustomerDivisionId
    {
        get
        {
            return Sites1Table.Instance.CustomerDivisionIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupDivisionId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn GroupDivisionIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.GroupDivisionId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn GroupDivisionId
    {
        get
        {
            return Sites1Table.Instance.GroupDivisionIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.RegionId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn RegionIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.RegionId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn RegionId
    {
        get
        {
            return Sites1Table.Instance.RegionIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.JoinedGroupDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn JoinedGroupDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.JoinedGroupDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn JoinedGroupDate
    {
        get
        {
            return Sites1Table.Instance.JoinedGroupDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ParticipationStartDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ParticipationStartDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ParticipationStartDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ParticipationStartDate
    {
        get
        {
            return Sites1Table.Instance.ParticipationStartDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ParticipationEndDate column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ParticipationEndDateColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ParticipationEndDate column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ParticipationEndDate
    {
        get
        {
            return Sites1Table.Instance.ParticipationEndDateColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ParticipationRate column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ParticipationRateColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Sites_.ParticipationRate column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ParticipationRate
    {
        get
        {
            return Sites1Table.Instance.ParticipationRateColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of Sites1Record records using a where clause.
    /// </summary>
    public static Sites1Record[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Sites1Record records using a where clause.
    /// </summary>
    public static Sites1Record[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of Sites1Record records using a where and order by clause.
    /// </summary>
    public static Sites1Record[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of Sites1Record records using a where and order by clause.
    /// </summary>
    public static Sites1Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Sites1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static Sites1Record[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Sites1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Sites1Record[])recList.ToArray(Type.GetType("IDE.Business.Sites1Record"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of Sites1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static Sites1Record[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = Sites1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (Sites1Record[])recList.ToArray(Type.GetType("IDE.Business.Sites1Record"));
    }   


    public static Sites1Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Sites1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Sites1Record[])recList.ToArray(Type.GetType("IDE.Business.Sites1Record"));
    }

    public static Sites1Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = Sites1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (Sites1Record[])recList.ToArray(Type.GetType("IDE.Business.Sites1Record"));
    }


    public static Sites1Record[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = Sites1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Sites1Record[])recList.ToArray(Type.GetType("IDE.Business.Sites1Record"));
    }

    public static Sites1Record[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = Sites1Table.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (Sites1Record[])recList.ToArray(Type.GetType("IDE.Business.Sites1Record"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)Sites1Table.Instance.GetCountResponseForPost(Sites1Table.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of Sites1Record records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = Sites1Table.Instance.GetRecordListResponseForPost(Sites1Table.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)Sites1Table.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)Sites1Table.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)Sites1Table.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)Sites1Table.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Sites1Record record using a where clause.
    /// </summary>
    public static Sites1Record GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Sites1Record record using a where clause.
    /// </summary>
    public static Sites1Record GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a Sites1Record record using a where and order by clause.
    /// </summary>
    public static Sites1Record GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = Sites1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Sites1Record rec = null;
        if (recList.Count > 0)
        {
            rec = (Sites1Record)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a Sites1Record record using a where and order by clause.
    /// </summary>
    public static Sites1Record GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = Sites1Table.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        Sites1Record rec = null;
        if (recList.Count > 0)
        {
            rec = (Sites1Record)recList[0];
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

        return Sites1Table.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return Sites1Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        Sites1Record[] recs = GetRecords(where);
        return  Sites1Table.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        Sites1Record[] recs = GetRecords(join, where);
        return  Sites1Table.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        Sites1Record[] recs = GetRecords(where, orderBy);
        return  Sites1Table.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        Sites1Record[] recs = GetRecords(join, where, orderBy);
        return  Sites1Table.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Sites1Record[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  Sites1Table.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        Sites1Record[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  Sites1Table.Instance.CreateDataTable(recs, null);
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
        Sites1Table.Instance.DeleteRecordList(whereFilter);
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
        
        return  Sites1Table.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return Sites1Table.Instance.ExportRecordData(whereFilter);
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

        return Sites1Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Sites1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Sites1Table.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return Sites1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return Sites1Table.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return Sites1Table.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return Sites1Table.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return Sites1Table.Instance.CreateRecord(tempId);
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
        BaseColumn column = Sites1Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = Sites1Table.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static Sites1Record GetRecord(string id, bool bMutable)
        {
            return (Sites1Record)Sites1Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static Sites1Record GetRecord(KeyValue id, bool bMutable)
        {
            return (Sites1Record)Sites1Table.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string SiteLogoValue, 
        string SiteNameValue, 
        string Address1Value, 
        string Address2Value, 
        string Address3Value, 
        string CityIdValue, 
        string PostCodeValue, 
        string PhoneValue, 
        string ContactValue, 
        string EmailValue, 
        string CustomerIdValue, 
        string GroupIdValue, 
        string Enabled0Value, 
        string InvoiceApproverNameValue, 
        string InvoiceApproverEmailValue, 
        string InvoicePayerNameValue, 
        string InvoicePayerEmailValue, 
        string IndustryIdValue, 
        string LandSqMetersValue, 
        string TotalFloorSpaceSqMetersValue, 
        string ProductiveFloorSpaceSqMetersValue, 
        string BusinessDayStartTimeValue, 
        string BusinessDayEndTimeValue, 
        string NonBusinessDayStartTimeValue, 
        string NonBusinessDayEndTimeValue, 
        string SiteCategoryIdValue, 
        string CustomerDivisionIdValue, 
        string GroupDivisionIdValue, 
        string RegionIdValue, 
        string JoinedGroupDateValue, 
        string ParticipationStartDateValue, 
        string ParticipationEndDateValue, 
        string ParticipationRateValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(SiteLogoValue, SiteLogoColumn);
        rec.SetString(SiteNameValue, SiteNameColumn);
        rec.SetString(Address1Value, Address1Column);
        rec.SetString(Address2Value, Address2Column);
        rec.SetString(Address3Value, Address3Column);
        rec.SetString(CityIdValue, CityIdColumn);
        rec.SetString(PostCodeValue, PostCodeColumn);
        rec.SetString(PhoneValue, PhoneColumn);
        rec.SetString(ContactValue, ContactColumn);
        rec.SetString(EmailValue, EmailColumn);
        rec.SetString(CustomerIdValue, CustomerIdColumn);
        rec.SetString(GroupIdValue, GroupIdColumn);
        rec.SetString(Enabled0Value, Enabled0Column);
        rec.SetString(InvoiceApproverNameValue, InvoiceApproverNameColumn);
        rec.SetString(InvoiceApproverEmailValue, InvoiceApproverEmailColumn);
        rec.SetString(InvoicePayerNameValue, InvoicePayerNameColumn);
        rec.SetString(InvoicePayerEmailValue, InvoicePayerEmailColumn);
        rec.SetString(IndustryIdValue, IndustryIdColumn);
        rec.SetString(LandSqMetersValue, LandSqMetersColumn);
        rec.SetString(TotalFloorSpaceSqMetersValue, TotalFloorSpaceSqMetersColumn);
        rec.SetString(ProductiveFloorSpaceSqMetersValue, ProductiveFloorSpaceSqMetersColumn);
        rec.SetString(BusinessDayStartTimeValue, BusinessDayStartTimeColumn);
        rec.SetString(BusinessDayEndTimeValue, BusinessDayEndTimeColumn);
        rec.SetString(NonBusinessDayStartTimeValue, NonBusinessDayStartTimeColumn);
        rec.SetString(NonBusinessDayEndTimeValue, NonBusinessDayEndTimeColumn);
        rec.SetString(SiteCategoryIdValue, SiteCategoryIdColumn);
        rec.SetString(CustomerDivisionIdValue, CustomerDivisionIdColumn);
        rec.SetString(GroupDivisionIdValue, GroupDivisionIdColumn);
        rec.SetString(RegionIdValue, RegionIdColumn);
        rec.SetString(JoinedGroupDateValue, JoinedGroupDateColumn);
        rec.SetString(ParticipationStartDateValue, ParticipationStartDateColumn);
        rec.SetString(ParticipationEndDateValue, ParticipationEndDateColumn);
        rec.SetString(ParticipationRateValue, ParticipationRateColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			Sites1Table.Instance.DeleteOneRecord(kv);
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
				Sites1Table.GetRecord(kv, false);
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
            if (!(Sites1Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return Sites1Table.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(Sites1Table.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = Sites1Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = Sites1Table.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (Sites1Table.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = Sites1Table.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = Sites1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = Sites1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
