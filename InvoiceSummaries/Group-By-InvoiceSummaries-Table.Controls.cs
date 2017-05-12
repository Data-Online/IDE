
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Group_By_InvoiceSummaries_Table.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;

using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;


using IDE.Business;
using IDE.Data;
using IDE.UI;
using IDE;
using Helpers;


#endregion


namespace IDE.UI.Controls.Group_By_InvoiceSummaries_Table
{


    #region "Section 1: Place your customizations here."


    public class EnergyChargesTableControlRow : BaseEnergyChargesTableControlRow
    {

        // The BaseEnergyChargesTableControlRow implements code for a ROW within the
        // the EnergyChargesTableControl table.  The BaseEnergyChargesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of EnergyChargesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.

    }



    public class EnergyChargesTableControl : BaseEnergyChargesTableControl
    {
        // The BaseEnergyChargesTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The EnergyChargesTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    }


    public class InvoiceSummariesTableControlRow : BaseInvoiceSummariesTableControlRow
    {


        //        public override void FileInvoiceButton_Click(object sender, EventArgs args)
        //        {
        //            System.Web.UI.HtmlControls.HtmlInputFile inputFile;
        //            inputFile = ((System.Web.UI.HtmlControls.HtmlInputFile)(this.Page.FindControlRecursively("inputFile")));
        //
        //            if ((!(inputFile.PostedFile == null) && (inputFile.PostedFile.ContentLength > 0)))
        //            {
        //                // Get the name of the file to be uploaded and 
        //                // the location where the file needs to be saved.
        //                string fileName = System.IO.Path.GetFileName(inputFile.PostedFile.FileName);
        //
        //                //var fs = inputFile.PostedFile.InputStream;
        //
        //
        //                string connString = ConfigurationManager.ConnectionStrings["AzureStorageAccount"].ConnectionString;
        //                string destContainer = ConfigurationManager.AppSettings["destContainer"];
        //
        //                string key = "test" + DateTime.Now.Millisecond.ToString() + ".pdf";
        //
        //                // Get ref to storage account
        //                CloudStorageAccount sa = CloudStorageAccount.Parse(connString);
        //                CloudBlobClient bc = sa.CreateCloudBlobClient();
        //
        //                // Get ref to container (creating it if required)
        //                CloudBlobContainer container = bc.GetContainerReference(destContainer);
        //
        //                container.CreateIfNotExists();
        //
        //                CloudBlockBlob b = container.GetBlockBlobReference(key);
        //
        //                using (var fs = inputFile.PostedFile.InputStream)
        //                {
        //                    System.Threading.Tasks.Task task = System.Threading.Tasks.Task.Factory.StartNew(() => b.UploadFromStream(fs));
        //                    task.Wait();
        //                }
        //
        //                //b.UploadFromStream(fs);
        //            }
        //
        //            string url = @"../InvoiceSummaries/Group-By-InvoiceSummaries-Table.aspx";
        //
        //            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
        //                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
        //
        //            bool shouldRedirect = true;
        //            string target = null;
        //            if (target == null) target = ""; // avoid warning on VS
        //
        //            try
        //            {
        //                // Enclose all database retrieval/update code within a Transaction boundary
        //                DbUtils.StartTransaction();
        //
        //                url = this.ModifyRedirectUrl(url, "", true);
        //                url = this.Page.ModifyRedirectUrl(url, "", true);
        //
        //            }
        //            catch (Exception ex)
        //            {
        //                // Upon error, rollback the transaction
        //                this.Page.RollBackTransaction(sender);
        //                shouldRedirect = false;
        //                this.Page.ErrorOnPage = true;
        //
        //                // Report the error message to the end user
        //                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
        //
        //            }
        //            finally
        //            {
        //                DbUtils.EndTransaction();
        //            }
        //            if (shouldRedirect)
        //            {
        //                this.Page.ShouldSaveControlsToSession = true;
        //                this.Page.Response.Redirect(url);
        //
        //            }
        //
        //
        //        }
        // The BaseInvoiceSummariesTableControlRow implements code for a ROW within the
        // the InvoiceSummariesTableControl table.  The BaseInvoiceSummariesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of InvoiceSummariesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        public override void SetContainerId()
        {
            //Code for the text property is generated inside the .aspx file. 
            //To override this property you can uncomment the following property and add you own value.
            this.ContainerId.Text = this.DataSource.SiteId.FormatContainerName();
            //this.PdfFileName.Text = this.DataSource.InvoiceId.ToString().PadLeft(8, '0') + ".pdf";

            if (this.DataSource.InvoiceId == 99999999)
            {
                this.FileInvButton.Visible = false;
                this.PdfFileName.Text = "tba";
            }
            else
            {
                this.PdfFileName.Text = this.DataSource.InvoiceId.FormatPdfFileName();
                this.UploadedOkImage.Visible = this.DataSource.OnFile;
            }
        }
        // try
        // {
        //   DbUtils.StartTransaction();
        //   UpdateRecord();
        //   DbUtils.CommitTransaction();
        //   this.InvoiceSummariesTableControl.DataChanged = true;
        // }
        // catch(Exception ex)
        // {
        //   DbUtils.RollBackTransaction();
        //   BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "UNIQUE_SCRIPTKEY", ex.Message);
        // }
        // finally
        // {
        //    DbUtils.EndTransaction();
        // } 
        public override void SetAlert()
        {
            this.Alert.Visible = false;
            string alertMessage = "";

            bool invOnFile = (this.Page as BaseApplicationPage).UploadToBlob(this.DataSource.InvoiceId.FormatPdfFileName(), this.DataSource.SiteId.FormatContainerName());
            //bool invOnFile = (this.Page as BaseApplicationPage).UploadToBlob(this.PdfFileName.Text, this.ContainerId.Text);
            alertMessage = (this.Page as BaseApplicationPage).CallCustomStoredProcedure("sp_ValidateInvoice", this.DataSource.InvoiceSummaryId, invOnFile);
            if (alertMessage.Length > 0)
            {
                this.Alert.Text = alertMessage;
                this.Alert.Visible = true;
            }
        }
    }



    public class InvoiceSummariesTableControl : BaseInvoiceSummariesTableControl
    {
        // The BaseInvoiceSummariesTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The InvoiceSummariesTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

        //        public override void FileInvoiceButton_Click(object sender, EventArgs args)
        //        {
        //            System.Web.UI.HtmlControls.HtmlInputFile inputFile;
        //            inputFile = ((System.Web.UI.HtmlControls.HtmlInputFile)(this.Page.FindControlRecursively("inputFileName")));
        //
        //            if ((!(inputFile.PostedFile == null) && (inputFile.PostedFile.ContentLength > 0)))
        //            {
        //                // Get the name of the file to be uploaded and 
        //                // the location where the file needs to be saved.
        //                string fileName = System.IO.Path.GetFileName(inputFile.PostedFile.FileName);
        //
        //                var fs = inputFile.PostedFile.InputStream;
        //
        //
        //                string connString = ConfigurationManager.ConnectionStrings["AzureStorageAccount"].ConnectionString;
        //                string destContainer = ConfigurationManager.AppSettings["destContainer"];
        //
        //                string key = "test.pdf";
        //
        //                // Get ref to storage account
        //                CloudStorageAccount sa = CloudStorageAccount.Parse(connString);
        //                CloudBlobClient bc = sa.CreateCloudBlobClient();
        //
        //                // Get ref to container (creating it if required)
        //                CloudBlobContainer container = bc.GetContainerReference(destContainer);
        //
        //                container.CreateIfNotExists();
        //
        //                CloudBlockBlob b = container.GetBlockBlobReference(key);
        //
        //                b.UploadFromStream(fs);
        //
        //                //string zz = Server.MapPath(inputFile.PostedFile.FileName);
        //                // string homeDirectory = System.IO.Path.GetDirectoryName(inputFile.PostedFile.);
        //                // System.Web.UI.WebControls.FileUpload zz = (System.Web.UI.WebControls.FileUpload)(this.Page.FindControlRecursively("inputFile2"));
        //            }
        //        }

        //        private static void FileInvoice(string FileName)
        //        {
        //
        //        }
        //        public override void FileUploadButton_Click(object sender, ImageClickEventArgs args)
        //        {
        //            string connString = ConfigurationManager.ConnectionStrings["AzureStorageAccount"].ConnectionString;
        //            string localFolder = ConfigurationManager.AppSettings["sourceFolder"];
        //            string destContainer = ConfigurationManager.AppSettings["destContainer"];
        //
        //
        //
        //            // Get ref to storage account
        //            CloudStorageAccount sa = CloudStorageAccount.Parse(connString);
        //            CloudBlobClient bc = sa.CreateCloudBlobClient();
        //
        //            // Get ref to container (creating it if required)
        //            CloudBlobContainer container = bc.GetContainerReference(destContainer);
        //
        //            container.CreateIfNotExists();
        //
        //            // Now upload the files
        //            string[] fileEntries = Directory.GetFiles(localFolder);
        //
        //            //var _directorylist = FilesReaderDirectory.GetNameInList(DropBoxFunction.GetDropboxFilesList().Contents.Where(w => w.IsDirectory == true).Select(s => s.Path).ToList()).Where(w => w.StartsWith("0")).ToList();
        //            //var regex = new Regex(@"\.pdf.");
        //
        //            //var _filelistdirectory = FilesReaderDirectory.GetNameInList(DropBoxFunction.GetDropboxFilesList("/").Contents.Where(w => w.IsDirectory == false).Select(s => s.Path).ToList()).Where(w => w.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) && !regex.IsMatch(w)).ToList();
        //
        //            foreach (string filePath in fileEntries)
        //            {
        //                string key = Path.GetFileName(filePath);
        //
        //                UploadBlob(container, key, filePath, false);
        //            }
        //          }

        //static void UploadBlob(CloudBlobContainer container, string key, string fileName, bool deleteAfter)
        //{
        //    // Get a blob ref to write file to
        //    CloudBlockBlob b = container.GetBlockBlobReference(key);
        //    string enteredFileDest = @"C:\Users\Graeme\Dropbox\Cloud Development\IDMsource" + @"\entered";
        //    // Write the file
        //    using (var fs = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
        //    {
        //        b.UploadFromStream(fs);
        //    }

        //    if (deleteAfter)
        //        File.Delete(fileName);

        //    //File.Move(fileName, enteredFileDest);
        //    File.Copy(fileName, enteredFileDest + @"\" + key);
        //}
    

}

    #region Custom classes
    //public class FilesReaderDirectory
    //{

    //    public static List<string> GetListOfDirectories(string _directory)
    //    {
    //        List<string> _list = Directory.GetDirectories(_directory).ToList();
    //        List<string> _returnlist = new List<string>();
    //        foreach (var s in _list)
    //        {
    //            _returnlist.Add(Path.GetFileName(s));
    //        }
    //        //List<string> _list = Directory.GetDirectories(_directory, "*", System.IO.SearchOption.AllDirectories).ToList();
    //        return _returnlist;
    //    }

    //    public static List<string> GetFilesFromDirectories(string _directory)
    //    {
    //        List<string> _list = Directory.GetFiles(_directory).ToList();
    //        List<string> _returnlist = new List<string>();
    //        foreach (var s in _list)
    //        {
    //            _returnlist.Add(Path.GetFileName(s));
    //        }
    //        //List<string> _list = Directory.GetDirectories(_directory, "*", System.IO.SearchOption.AllDirectories).ToList();
    //        return _returnlist;
    //    }


    //    public static List<string> GetNameInList(List<string> list)
    //    {
    //        List<string> _returnlist = new List<string>();
    //        foreach (var s in list)
    //        {
    //            _returnlist.Add(Path.GetFileName(s));
    //        }
    //        //List<string> _list = Directory.GetDirectories(_directory, "*", System.IO.SearchOption.AllDirectories).ToList();
    //        return _returnlist;
    //    }
    //}

    //public class DropBoxFunction
    //{
    //    public static Metadata GetDropboxFilesList(string path = null)
    //    {

    //        var contentlist = RestApiCaller<Metadata>("https://api.dropboxapi.com/1/metadata/auto" + ConfigurationManager.AppSettings["DropBoxFolderPath"] + path);
    //        return contentlist;
    //    }

    //    public static byte[] GetDropboxFilesDownload(string filepath)
    //    {
    //        string ApiUrl = "https://content.dropboxapi.com/1/files/auto" + ConfigurationManager.AppSettings["DropBoxFolderPath"] + filepath;
    //        using (var client = new System.Net.Http.HttpClient())
    //        {
    //            client.BaseAddress = new Uri(ApiUrl);
    //            client.DefaultRequestHeaders.Accept.Clear();
    //            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    //            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + ConfigurationManager.AppSettings["DropBoxAccessToken"]);
    //            using (var response = client.GetAsync("").Result)
    //            {
    //                return response.Content.ReadAsByteArrayAsync().Result;
    //            }
    //        }
    //    }

    //    public static string GetDropboxFilesDelete(string filepath)
    //    {
    //        string ApiUrl = "https://api.dropboxapi.com/1/fileops/delete";
    //        using (var client = new System.Net.Http.HttpClient())
    //        {
    //            client.BaseAddress = new Uri(ApiUrl);
    //            client.DefaultRequestHeaders.Accept.Clear();
    //            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    //            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + ConfigurationManager.AppSettings["DropBoxAccessToken"]);
    //            using (var response = client.PostAsync("?root=dropbox&path=" + ConfigurationManager.AppSettings["DropBoxFolderPath"] + filepath, null).Result)
    //            {
    //                if (response.IsSuccessStatusCode)
    //                {
    //                    return response.Content.ReadAsStringAsync().Result;
    //                }
    //                else
    //                {
    //                    return response.Content.ReadAsStringAsync().Result;
    //                }
    //            }
    //        }
    //    }
    //    public static T RestApiCaller<T>(string ApiUrl)
    //    {
    //        using (var client = new System.Net.Http.HttpClient())
    //        {
    //            client.BaseAddress = new Uri(ApiUrl);
    //            client.DefaultRequestHeaders.Accept.Clear();
    //            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    //            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + ConfigurationManager.AppSettings["DropBoxAccessToken"]);
    //            using (var response = client.PostAsync("", null).Result)
    //            {
    //                if (response.IsSuccessStatusCode)
    //                {
    //                    string contentString = response.Content.ReadAsStringAsync().Result;
    //                    var jsonReturn = JsonConvert.DeserializeObject<T>(contentString);
    //                    return jsonReturn;
    //                }
    //                else
    //                {
    //                    string contentString = response.Content.ReadAsStringAsync().Result;
    //                    var jsonReturn = JsonConvert.DeserializeObject<T>(contentString);
    //                    return jsonReturn;
    //                }
    //            }
    //        }
    //    }


    //}

    //public class Metadata
    //{
    //    [JsonProperty("path")]
    //    public string Path { get; set; }

    //    [JsonProperty("is_dir")]
    //    public bool IsDirectory { get; set; }

    //    [JsonProperty("contents")]
    //    public List<Metadata> Contents { get; set; }
    //}


    #endregion

    public class NetworkChargesTableControlRow : BaseNetworkChargesTableControlRow
    {

        // The BaseNetworkChargesTableControlRow implements code for a ROW within the
        // the NetworkChargesTableControl table.  The BaseNetworkChargesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of NetworkChargesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.

    }



    public class NetworkChargesTableControl : BaseNetworkChargesTableControl
    {
        // The BaseNetworkChargesTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The NetworkChargesTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    }



    //public class CustomersRecordControl : BaseCustomersRecordControl
    //{
    //      
    //        // The BaseCustomersRecordControl implements the LoadData, DataBind and other
    //        // methods to load and display the data in a table control.
    //
    //        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
    //        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
    //        
    //}
    //
    public class SitesRecordControl : BaseSitesRecordControl
    {

        // The BaseSitesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

    }
    //public class ScratchTableControl : BaseScratchTableControl
    //{
    //    // The BaseScratchTableControl class implements the LoadData, DataBind, CreateWhereClause
    //    // and other methods to load and display the data in a table control.
    //
    //    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    //    // The ScratchTableControlRow class offers another place where you can customize
    //    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    //    
    //}
    //
    //public class ScratchTableControlRow : BaseScratchTableControlRow
    //{
    //      
    //        // The BaseScratchTableControlRow implements code for a ROW within the
    //        // the ScratchTableControl table.  The BaseScratchTableControlRow implements the DataBind and SaveData methods.
    //        // The loading of data is actually performed by the LoadData method in the base class of ScratchTableControl.
    //
    //        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
    //        // SaveData, GetUIData, and Validate methods.
    //        
    //}
    //
    #endregion



    #region "Section 2: Do not modify this section."
    
    
// Base class for the EnergyChargesTableControlRow control on the Group_By_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in EnergyChargesTableControlRow.
public class BaseEnergyChargesTableControlRow : IDE.UI.BaseApplicationRecordControl
{
        public BaseEnergyChargesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in EnergyChargesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in EnergyChargesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.EnergyCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = EnergyChargesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseEnergyChargesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new EnergyChargesRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetBD0004();
                SetBD0004Label();
                SetBD0004R();
                SetBD0408();
                SetBD0408Label();
                SetBD0408R();
                SetBD0812();
                SetBD0812Label();
                SetBD0812R();
                SetBD1216();
                SetBD1216Label();
                SetBD1216R();
                SetBD1620();
                SetBD1620Label();
                SetBD1620R();
                SetBD2024();
                SetBD2024Label();
                SetBD2024R();
                SetNBD0004();
                SetNBD0004Label();
                SetNBD0004R();
                SetNBD0408();
                SetNBD0408Label();
                SetNBD0408R();
                SetNBD0812();
                SetNBD0812Label();
                SetNBD0812R();
                SetNBD1216();
                SetNBD1216Label();
                SetNBD1216R();
                SetNBD1620();
                SetNBD1620Label();
                SetNBD1620R();
                SetNBD2024();
                SetNBD2024Label();
                SetNBD2024R();
                
                
                
                
                
                

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetBD0004()
        {
            
                    
            // Set the BD0004 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0004 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004Specified) {
                								
                // If the BD0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0004.Text = EnergyChargesTable.BD0004.Format(EnergyChargesTable.BD0004.DefaultValue);
            		
            }
            
            // If the BD0004 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0004.Text == null ||
                this.BD0004.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0004.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0004R()
        {
            
                    
            // Set the BD0004R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0004R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0004RSpecified) {
                								
                // If the BD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0004R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0004R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0004R.Text = EnergyChargesTable.BD0004R.Format(EnergyChargesTable.BD0004R.DefaultValue);
            		
            }
            
            // If the BD0004R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0004R.Text == null ||
                this.BD0004R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0004R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0408()
        {
            
                    
            // Set the BD0408 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0408 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408Specified) {
                								
                // If the BD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0408.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0408.Text = EnergyChargesTable.BD0408.Format(EnergyChargesTable.BD0408.DefaultValue);
            		
            }
            
            // If the BD0408 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0408.Text == null ||
                this.BD0408.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0408.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0408R()
        {
            
                    
            // Set the BD0408R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0408R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0408RSpecified) {
                								
                // If the BD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0408R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0408R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0408R.Text = EnergyChargesTable.BD0408R.Format(EnergyChargesTable.BD0408R.DefaultValue);
            		
            }
            
            // If the BD0408R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0408R.Text == null ||
                this.BD0408R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0408R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0812()
        {
            
                    
            // Set the BD0812 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0812 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812Specified) {
                								
                // If the BD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0812.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0812.Text = EnergyChargesTable.BD0812.Format(EnergyChargesTable.BD0812.DefaultValue);
            		
            }
            
            // If the BD0812 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0812.Text == null ||
                this.BD0812.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0812.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0812R()
        {
            
                    
            // Set the BD0812R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD0812R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD0812RSpecified) {
                								
                // If the BD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD0812R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD0812R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD0812R.Text = EnergyChargesTable.BD0812R.Format(EnergyChargesTable.BD0812R.DefaultValue);
            		
            }
            
            // If the BD0812R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD0812R.Text == null ||
                this.BD0812R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD0812R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1216()
        {
            
                    
            // Set the BD1216 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1216 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216Specified) {
                								
                // If the BD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1216.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1216.Text = EnergyChargesTable.BD1216.Format(EnergyChargesTable.BD1216.DefaultValue);
            		
            }
            
            // If the BD1216 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1216.Text == null ||
                this.BD1216.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1216.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1216R()
        {
            
                    
            // Set the BD1216R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1216R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1216RSpecified) {
                								
                // If the BD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1216R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1216R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1216R.Text = EnergyChargesTable.BD1216R.Format(EnergyChargesTable.BD1216R.DefaultValue);
            		
            }
            
            // If the BD1216R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1216R.Text == null ||
                this.BD1216R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1216R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1620()
        {
            
                    
            // Set the BD1620 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1620 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620Specified) {
                								
                // If the BD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1620.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1620.Text = EnergyChargesTable.BD1620.Format(EnergyChargesTable.BD1620.DefaultValue);
            		
            }
            
            // If the BD1620 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1620.Text == null ||
                this.BD1620.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1620.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD1620R()
        {
            
                    
            // Set the BD1620R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD1620R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD1620RSpecified) {
                								
                // If the BD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD1620R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD1620R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD1620R.Text = EnergyChargesTable.BD1620R.Format(EnergyChargesTable.BD1620R.DefaultValue);
            		
            }
            
            // If the BD1620R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD1620R.Text == null ||
                this.BD1620R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD1620R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD2024()
        {
            
                    
            // Set the BD2024 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD2024 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024Specified) {
                								
                // If the BD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD2024.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD2024.Text = EnergyChargesTable.BD2024.Format(EnergyChargesTable.BD2024.DefaultValue);
            		
            }
            
            // If the BD2024 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD2024.Text == null ||
                this.BD2024.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD2024.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD2024R()
        {
            
                    
            // Set the BD2024R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.BD2024R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BD2024RSpecified) {
                								
                // If the BD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.BD2024R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BD2024R.Text = formattedValue;
                   
            } 
            
            else {
            
                // BD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BD2024R.Text = EnergyChargesTable.BD2024R.Format(EnergyChargesTable.BD2024R.DefaultValue);
            		
            }
            
            // If the BD2024R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BD2024R.Text == null ||
                this.BD2024R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BD2024R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0004()
        {
            
                    
            // Set the NBD0004 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0004 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0004Specified) {
                								
                // If the NBD0004 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0004);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0004.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0004 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0004.Text = EnergyChargesTable.NBD0004.Format(EnergyChargesTable.NBD0004.DefaultValue);
            		
            }
            
            // If the NBD0004 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0004.Text == null ||
                this.NBD0004.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0004.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0004R()
        {
            
                    
            // Set the NBD0004R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0004R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0004RSpecified) {
                								
                // If the NBD0004R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0004R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0004R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0004R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0004R.Text = EnergyChargesTable.NBD0004R.Format(EnergyChargesTable.NBD0004R.DefaultValue);
            		
            }
            
            // If the NBD0004R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0004R.Text == null ||
                this.NBD0004R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0004R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0408()
        {
            
                    
            // Set the NBD0408 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0408 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408Specified) {
                								
                // If the NBD0408 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0408.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0408.Text = EnergyChargesTable.NBD0408.Format(EnergyChargesTable.NBD0408.DefaultValue);
            		
            }
            
            // If the NBD0408 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0408.Text == null ||
                this.NBD0408.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0408.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0408R()
        {
            
                    
            // Set the NBD0408R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0408R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0408RSpecified) {
                								
                // If the NBD0408R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0408R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0408R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0408R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0408R.Text = EnergyChargesTable.NBD0408R.Format(EnergyChargesTable.NBD0408R.DefaultValue);
            		
            }
            
            // If the NBD0408R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0408R.Text == null ||
                this.NBD0408R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0408R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0812()
        {
            
                    
            // Set the NBD0812 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0812 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812Specified) {
                								
                // If the NBD0812 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0812.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0812.Text = EnergyChargesTable.NBD0812.Format(EnergyChargesTable.NBD0812.DefaultValue);
            		
            }
            
            // If the NBD0812 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0812.Text == null ||
                this.NBD0812.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0812.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD0812R()
        {
            
                    
            // Set the NBD0812R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD0812R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD0812RSpecified) {
                								
                // If the NBD0812R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD0812R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD0812R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD0812R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD0812R.Text = EnergyChargesTable.NBD0812R.Format(EnergyChargesTable.NBD0812R.DefaultValue);
            		
            }
            
            // If the NBD0812R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD0812R.Text == null ||
                this.NBD0812R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD0812R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1216()
        {
            
                    
            // Set the NBD1216 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1216 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216Specified) {
                								
                // If the NBD1216 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1216.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1216.Text = EnergyChargesTable.NBD1216.Format(EnergyChargesTable.NBD1216.DefaultValue);
            		
            }
            
            // If the NBD1216 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1216.Text == null ||
                this.NBD1216.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1216.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1216R()
        {
            
                    
            // Set the NBD1216R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1216R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1216RSpecified) {
                								
                // If the NBD1216R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1216R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1216R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1216R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1216R.Text = EnergyChargesTable.NBD1216R.Format(EnergyChargesTable.NBD1216R.DefaultValue);
            		
            }
            
            // If the NBD1216R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1216R.Text == null ||
                this.NBD1216R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1216R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1620()
        {
            
                    
            // Set the NBD1620 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1620 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620Specified) {
                								
                // If the NBD1620 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1620.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1620.Text = EnergyChargesTable.NBD1620.Format(EnergyChargesTable.NBD1620.DefaultValue);
            		
            }
            
            // If the NBD1620 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1620.Text == null ||
                this.NBD1620.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1620.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD1620R()
        {
            
                    
            // Set the NBD1620R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD1620R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD1620RSpecified) {
                								
                // If the NBD1620R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD1620R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD1620R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD1620R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD1620R.Text = EnergyChargesTable.NBD1620R.Format(EnergyChargesTable.NBD1620R.DefaultValue);
            		
            }
            
            // If the NBD1620R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD1620R.Text == null ||
                this.NBD1620R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD1620R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD2024()
        {
            
                    
            // Set the NBD2024 Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD2024 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024Specified) {
                								
                // If the NBD2024 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD2024.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD2024.Text = EnergyChargesTable.NBD2024.Format(EnergyChargesTable.NBD2024.DefaultValue);
            		
            }
            
            // If the NBD2024 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD2024.Text == null ||
                this.NBD2024.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD2024.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNBD2024R()
        {
            
                    
            // Set the NBD2024R Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.EnergyCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.EnergyCharges record retrieved from the database.
            // this.NBD2024R is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NBD2024RSpecified) {
                								
                // If the NBD2024R is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(EnergyChargesTable.NBD2024R);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NBD2024R.Text = formattedValue;
                   
            } 
            
            else {
            
                // NBD2024R is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NBD2024R.Text = EnergyChargesTable.NBD2024R.Format(EnergyChargesTable.NBD2024R.DefaultValue);
            		
            }
            
            // If the NBD2024R is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NBD2024R.Text == null ||
                this.NBD2024R.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NBD2024R.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBD0004Label()
                  {
                  
                        this.BD0004Label.Text = EvaluateFormula("\"Weekday 0000 - 0400\"");
                      
                    
        }
                
        public virtual void SetBD0408Label()
                  {
                  
                        this.BD0408Label.Text = EvaluateFormula("\"Weekday 0400 - 0800\"");
                      
                    
        }
                
        public virtual void SetBD0812Label()
                  {
                  
                        this.BD0812Label.Text = EvaluateFormula("\"Weekday 0800 - 1200\"");
                      
                    
        }
                
        public virtual void SetBD1216Label()
                  {
                  
                        this.BD1216Label.Text = EvaluateFormula("\"Weekday 1200 - 1600\"");
                      
                    
        }
                
        public virtual void SetBD1620Label()
                  {
                  
                        this.BD1620Label.Text = EvaluateFormula("\"Weekday 1600 - 2000\"");
                      
                    
        }
                
        public virtual void SetBD2024Label()
                  {
                  
                        this.BD2024Label.Text = EvaluateFormula("\"Weekday 2000 - 2400\"");
                      
                    
        }
                
        public virtual void SetNBD0004Label()
                  {
                  
                        this.NBD0004Label.Text = EvaluateFormula("\"Weekend 0000 - 0400\"");
                      
                    
        }
                
        public virtual void SetNBD0408Label()
                  {
                  
                        this.NBD0408Label.Text = EvaluateFormula("\"Weekend 0400 - 0800\"");
                      
                    
        }
                
        public virtual void SetNBD0812Label()
                  {
                  
                        this.NBD0812Label.Text = EvaluateFormula("\"Weekend 0800 - 1200\"");
                      
                    
        }
                
        public virtual void SetNBD1216Label()
                  {
                  
                        this.NBD1216Label.Text = EvaluateFormula("\"Weekend 1200 - 1600\"");
                      
                    
        }
                
        public virtual void SetNBD1620Label()
                  {
                  
                        this.NBD1620Label.Text = EvaluateFormula("\"Weekend 1600 - 2000\"");
                      
                    
        }
                
        public virtual void SetNBD2024Label()
                  {
                  
                        this.NBD2024Label.Text = EvaluateFormula("\"Weekend 2000 - 2400\"");
                      
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        InvoiceSummariesTableControlRow parentCtrl;
      
            parentCtrl = (InvoiceSummariesTableControlRow)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          this.DataSource.EnergyChargeId = parentCtrl.DataSource.InvoiceSummaryId;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).DataChanged = true;
                ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetBD0004();
            GetBD0004R();
            GetBD0408();
            GetBD0408R();
            GetBD0812();
            GetBD0812R();
            GetBD1216();
            GetBD1216R();
            GetBD1620();
            GetBD1620R();
            GetBD2024();
            GetBD2024R();
            GetNBD0004();
            GetNBD0004R();
            GetNBD0408();
            GetNBD0408R();
            GetNBD0812();
            GetNBD0812R();
            GetNBD1216();
            GetNBD1216R();
            GetNBD1620();
            GetNBD1620R();
            GetNBD2024();
            GetNBD2024R();
        }
        
        
        public virtual void GetBD0004()
        {
            
        }
                
        public virtual void GetBD0004R()
        {
            
        }
                
        public virtual void GetBD0408()
        {
            
        }
                
        public virtual void GetBD0408R()
        {
            
        }
                
        public virtual void GetBD0812()
        {
            
        }
                
        public virtual void GetBD0812R()
        {
            
        }
                
        public virtual void GetBD1216()
        {
            
        }
                
        public virtual void GetBD1216R()
        {
            
        }
                
        public virtual void GetBD1620()
        {
            
        }
                
        public virtual void GetBD1620R()
        {
            
        }
                
        public virtual void GetBD2024()
        {
            
        }
                
        public virtual void GetBD2024R()
        {
            
        }
                
        public virtual void GetNBD0004()
        {
            
        }
                
        public virtual void GetNBD0004R()
        {
            
        }
                
        public virtual void GetNBD0408()
        {
            
        }
                
        public virtual void GetNBD0408R()
        {
            
        }
                
        public virtual void GetNBD0812()
        {
            
        }
                
        public virtual void GetNBD0812R()
        {
            
        }
                
        public virtual void GetNBD1216()
        {
            
        }
                
        public virtual void GetNBD1216R()
        {
            
        }
                
        public virtual void GetNBD1620()
        {
            
        }
                
        public virtual void GetNBD1620R()
        {
            
        }
                
        public virtual void GetNBD2024()
        {
            
        }
                
        public virtual void GetNBD2024R()
        {
            
        }
                

      // To customize, override this method in EnergyChargesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          EnergyChargesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).DataChanged = true;
            ((EnergyChargesTableControl)MiscUtils.GetParentControlObject(this, "EnergyChargesTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseEnergyChargesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseEnergyChargesTableControlRow_Rec"] = value;
            }
        }
        
        public EnergyChargesRecord DataSource {
            get {
                return (EnergyChargesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal BD0004 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0004Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0004R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0004R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0408 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0408Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0408R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0408R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0812 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD0812Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD0812R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD0812R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1216 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1216Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD1216R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1216R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1620 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD1620Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD1620R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD1620R");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD2024 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024");
            }
        }
            
        public System.Web.UI.WebControls.Literal BD2024Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BD2024R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BD2024R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0004 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0004Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0004R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0004R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0408 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0408Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0408R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0408R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0812 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD0812Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD0812R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD0812R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1216 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1216Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD1216R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1216R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1620 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD1620Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD1620R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD1620R");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD2024 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024");
            }
        }
            
        public System.Web.UI.WebControls.Literal NBD2024Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal NBD2024R {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NBD2024R");
            }
        }
            
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        EnergyChargesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    EnergyChargesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual EnergyChargesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return EnergyChargesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the EnergyChargesTableControl control on the Group_By_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in EnergyChargesTableControl.
public class BaseEnergyChargesTableControl : IDE.UI.BaseApplicationTableControl
{
         
       public BaseEnergyChargesTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination2.FirstPage.Click += Pagination2_FirstPage_Click;
                        
                    this.Pagination2.LastPage.Click += Pagination2_LastPage_Click;
                        
                    this.Pagination2.NextPage.Click += Pagination2_NextPage_Click;
                        
                    this.Pagination2.PageSizeButton.Click += Pagination2_PageSizeButton_Click;
                        
                    this.Pagination2.PreviousPage.Click += Pagination2_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
                  
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(IDE.Business.EnergyChargesRecord);
                      this.DataSource = (EnergyChargesRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (EnergyChargesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IDE.Business.EnergyChargesRecord);
                    this.DataSource = (EnergyChargesRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual EnergyChargesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(EnergyChargesTable.Column1, true);          
            // selCols.Add(EnergyChargesTable.Column2, true);          
            // selCols.Add(EnergyChargesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return EnergyChargesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                EnergyChargesTable databaseTable = new EnergyChargesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(EnergyChargesRecord)) as EnergyChargesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(EnergyChargesTable.Column1, true);          
            // selCols.Add(EnergyChargesTable.Column2, true);          
            // selCols.Add(EnergyChargesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return EnergyChargesTable.GetRecordCount(join, where);
            else
            {
                EnergyChargesTable databaseTable = new EnergyChargesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
               

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            EnergyChargesTableControlRow recControl = (EnergyChargesTableControlRow)(repItem.FindControl("EnergyChargesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination2.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination2.CurrentPage.Text = "0";
            }
            this.Pagination2.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for EnergyChargesTableControl pagination.
        
            this.Pagination2.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination2.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination2.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination2.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination2.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination2.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination2.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination2.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (EnergyChargesTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (EnergyChargesTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            EnergyChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue invoiceSummariesRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = invoiceSummariesRecordObj;
          invoiceSummariesRecordObj = tmp;
        InvoiceSummariesTableControlRow invoiceSummariesTableControlObjRow = (MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow") as InvoiceSummariesTableControlRow);
          
              if (invoiceSummariesTableControlObjRow != null && invoiceSummariesTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesTableControlObjRow.GetRecord().InvoiceSummaryId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["EnergyChargesTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            EnergyChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesTableControl = HttpContext.Current.Session["EnergyChargesTableControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesTableControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(EnergyChargesTable.EnergyChargeId))
      {
      wc.iAND(EnergyChargesTable.EnergyChargeId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(EnergyChargesTable.EnergyChargeId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          

            return wc;
        }

        
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination2.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination2.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                EnergyChargesTableControlRow recControl = (EnergyChargesTableControlRow)(repItem.FindControl("EnergyChargesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      EnergyChargesRecord rec = new EnergyChargesRecord();
        
                        if (recControl.BD0004.Text != "") {
                            rec.Parse(recControl.BD0004.Text, EnergyChargesTable.BD0004);
                  }
                
                        if (recControl.BD0004R.Text != "") {
                            rec.Parse(recControl.BD0004R.Text, EnergyChargesTable.BD0004R);
                  }
                
                        if (recControl.BD0408.Text != "") {
                            rec.Parse(recControl.BD0408.Text, EnergyChargesTable.BD0408);
                  }
                
                        if (recControl.BD0408R.Text != "") {
                            rec.Parse(recControl.BD0408R.Text, EnergyChargesTable.BD0408R);
                  }
                
                        if (recControl.BD0812.Text != "") {
                            rec.Parse(recControl.BD0812.Text, EnergyChargesTable.BD0812);
                  }
                
                        if (recControl.BD0812R.Text != "") {
                            rec.Parse(recControl.BD0812R.Text, EnergyChargesTable.BD0812R);
                  }
                
                        if (recControl.BD1216.Text != "") {
                            rec.Parse(recControl.BD1216.Text, EnergyChargesTable.BD1216);
                  }
                
                        if (recControl.BD1216R.Text != "") {
                            rec.Parse(recControl.BD1216R.Text, EnergyChargesTable.BD1216R);
                  }
                
                        if (recControl.BD1620.Text != "") {
                            rec.Parse(recControl.BD1620.Text, EnergyChargesTable.BD1620);
                  }
                
                        if (recControl.BD1620R.Text != "") {
                            rec.Parse(recControl.BD1620R.Text, EnergyChargesTable.BD1620R);
                  }
                
                        if (recControl.BD2024.Text != "") {
                            rec.Parse(recControl.BD2024.Text, EnergyChargesTable.BD2024);
                  }
                
                        if (recControl.BD2024R.Text != "") {
                            rec.Parse(recControl.BD2024R.Text, EnergyChargesTable.BD2024R);
                  }
                
                        if (recControl.NBD0004.Text != "") {
                            rec.Parse(recControl.NBD0004.Text, EnergyChargesTable.NBD0004);
                  }
                
                        if (recControl.NBD0004R.Text != "") {
                            rec.Parse(recControl.NBD0004R.Text, EnergyChargesTable.NBD0004R);
                  }
                
                        if (recControl.NBD0408.Text != "") {
                            rec.Parse(recControl.NBD0408.Text, EnergyChargesTable.NBD0408);
                  }
                
                        if (recControl.NBD0408R.Text != "") {
                            rec.Parse(recControl.NBD0408R.Text, EnergyChargesTable.NBD0408R);
                  }
                
                        if (recControl.NBD0812.Text != "") {
                            rec.Parse(recControl.NBD0812.Text, EnergyChargesTable.NBD0812);
                  }
                
                        if (recControl.NBD0812R.Text != "") {
                            rec.Parse(recControl.NBD0812R.Text, EnergyChargesTable.NBD0812R);
                  }
                
                        if (recControl.NBD1216.Text != "") {
                            rec.Parse(recControl.NBD1216.Text, EnergyChargesTable.NBD1216);
                  }
                
                        if (recControl.NBD1216R.Text != "") {
                            rec.Parse(recControl.NBD1216R.Text, EnergyChargesTable.NBD1216R);
                  }
                
                        if (recControl.NBD1620.Text != "") {
                            rec.Parse(recControl.NBD1620.Text, EnergyChargesTable.NBD1620);
                  }
                
                        if (recControl.NBD1620R.Text != "") {
                            rec.Parse(recControl.NBD1620R.Text, EnergyChargesTable.NBD1620R);
                  }
                
                        if (recControl.NBD2024.Text != "") {
                            rec.Parse(recControl.NBD2024.Text, EnergyChargesTable.NBD2024);
                  }
                
                        if (recControl.NBD2024R.Text != "") {
                            rec.Parse(recControl.NBD2024R.Text, EnergyChargesTable.NBD2024R);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new EnergyChargesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IDE.Business.EnergyChargesRecord);
                this.DataSource = (EnergyChargesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(EnergyChargesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(EnergyChargesTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["EnergyChargesTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination2");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["EnergyChargesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
           
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination2_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination2_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination2_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination2_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination2.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination2.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination2_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = EnergyChargesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  EnergyChargesRecord[] DataSource {
             
            get {
                return (EnergyChargesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public IDE.UI.IPaginationModern Pagination2 {
            get {
                return (IDE.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination2");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                EnergyChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        EnergyChargesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                EnergyChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        EnergyChargesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual EnergyChargesTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual EnergyChargesTableControlRow[] GetSelectedRecordControls()
        {
        
            return (EnergyChargesTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IDE.UI.Controls.Group_By_InvoiceSummaries_Table.EnergyChargesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            EnergyChargesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (EnergyChargesTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual EnergyChargesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "EnergyChargesTableControlRow");
	          List<EnergyChargesTableControlRow> list = new List<EnergyChargesTableControlRow>();
	          foreach (EnergyChargesTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the InvoiceSummariesTableControlRow control on the Group_By_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in InvoiceSummariesTableControlRow.
public class BaseInvoiceSummariesTableControlRow : IDE.UI.BaseApplicationRecordControl
{
        public BaseInvoiceSummariesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in InvoiceSummariesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in InvoiceSummariesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IDE") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.EditRowButton1.Click += EditRowButton1_Click;
                        
                    this.EditRowButton2.Click += EditRowButton2_Click;
                        
                    this.ExpandRowButton.Click += ExpandRowButton_Click;
                        
                    this.FileInvButton.Button.Click += FileInvButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.InvoiceSummaries record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = InvoiceSummariesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseInvoiceSummariesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new InvoiceSummariesRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetAccountNumber();
                SetAccountNumberLabel();
                SetAlert();
                SetConnectionNumber();
                SetConnectionNumberLabel();
                SetContact();
                SetContainerId();
                SetCustomerNumber();
                SetCustomerNumberLabel();
                
                
                
                
                
                SetEnergyChargesTotal();
                SetEnergyChargesTotalLabel();
                SetEnergyPointId();
                
                
                SetGstTotal();
                SetGstTotalLabel();
                SetInvoiceDate();
                SetInvoiceDateLabel();
                SetInvoiceDueDate();
                SetInvoiceDueDateLabel();
                SetInvoiceId();
                SetInvoiceIdLabel();
                SetInvoiceNumber();
                SetInvoiceNumberLabel();
                SetInvoiceSummariesTableControlTabContainer();
                SetInvoiceTotal();
                SetInvoiceTotalLabel();
                SetKWhTotal();
                SetKWhTotalLabel();
                SetMercury();
                SetMeridian();
                SetMiscChargesTotal();
                SetMiscChargesTotalLabel();
                
                SetNetworkChargesTotal();
                SetNetworkChargesTotalLabel();
                SetPdfFileName();
                SetPeriodEnd();
                SetPeriodEndLabel();
                SetPeriodStart();
                SetPeriodStartLabel();
                SetSiteId();
                SetSiteIdLabel();
                
                SetSupplierId();
                SetSupplierIdLabel();
                
                SetDeleteRowButton();
              
                SetEditRowButton();
              
                SetEditRowButton1();
              
                SetEditRowButton2();
              
                SetExpandRowButton();
              
                SetFileInvButton();
              

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
                      
        SetEnergyChargesTableControl();

                  
        SetNetworkChargesTableControl();

                  
        SetSitesRecordControl();

        
        }
        
        
        public virtual void SetAccountNumber()
        {
            
                    
            // Set the AccountNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.AccountNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.AccountNumberSpecified) {
                								
                // If the AccountNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.AccountNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.AccountNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // AccountNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.AccountNumber.Text = InvoiceSummariesTable.AccountNumber.Format(InvoiceSummariesTable.AccountNumber.DefaultValue);
            		
            }
            
            // If the AccountNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.AccountNumber.Text == null ||
                this.AccountNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.AccountNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetConnectionNumber()
        {
            
                    
            // Set the ConnectionNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.ConnectionNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ConnectionNumberSpecified) {
                								
                // If the ConnectionNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.ConnectionNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ConnectionNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // ConnectionNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ConnectionNumber.Text = InvoiceSummariesTable.ConnectionNumber.Format(InvoiceSummariesTable.ConnectionNumber.DefaultValue);
            		
            }
            
            // If the ConnectionNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ConnectionNumber.Text == null ||
                this.ConnectionNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ConnectionNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustomerNumber()
        {
            
                    
            // Set the CustomerNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.CustomerNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustomerNumberSpecified) {
                								
                // If the CustomerNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.CustomerNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustomerNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustomerNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustomerNumber.Text = InvoiceSummariesTable.CustomerNumber.Format(InvoiceSummariesTable.CustomerNumber.DefaultValue);
            		
            }
            
            // If the CustomerNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustomerNumber.Text == null ||
                this.CustomerNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustomerNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEnergyChargesTotal()
        {
            
                    
            // Set the EnergyChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.EnergyChargesTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EnergyChargesTotalSpecified) {
                								
                // If the EnergyChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.EnergyChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EnergyChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // EnergyChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EnergyChargesTotal.Text = InvoiceSummariesTable.EnergyChargesTotal.Format(InvoiceSummariesTable.EnergyChargesTotal.DefaultValue);
            		
            }
            
            // If the EnergyChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.EnergyChargesTotal.Text == null ||
                this.EnergyChargesTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.EnergyChargesTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetEnergyPointId()
        {
            
                    
            // Set the EnergyPointId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.EnergyPointId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.EnergyPointIdSpecified) {
                								
                // If the EnergyPointId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.EnergyPointId);
               if(_isExpandableNonCompositeForeignKey &&InvoiceSummariesTable.EnergyPointId.IsApplyDisplayAs)
                                  
                     formattedValue = InvoiceSummariesTable.GetDFKA(this.DataSource.EnergyPointId.ToString(),InvoiceSummariesTable.EnergyPointId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(InvoiceSummariesTable.EnergyPointId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.EnergyPointId.Text = formattedValue;
                   
            } 
            
            else {
            
                // EnergyPointId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.EnergyPointId.Text = InvoiceSummariesTable.EnergyPointId.Format(InvoiceSummariesTable.EnergyPointId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetGstTotal()
        {
            
                    
            // Set the GstTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.GstTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GstTotalSpecified) {
                								
                // If the GstTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.GstTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.GstTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // GstTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GstTotal.Text = InvoiceSummariesTable.GstTotal.Format(InvoiceSummariesTable.GstTotal.DefaultValue);
            		
            }
            
            // If the GstTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.GstTotal.Text == null ||
                this.GstTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.GstTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceDate()
        {
            
                    
            // Set the InvoiceDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDateSpecified) {
                								
                // If the InvoiceDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDate.Text = InvoiceSummariesTable.InvoiceDate.Format(InvoiceSummariesTable.InvoiceDate.DefaultValue);
            		
            }
            
            // If the InvoiceDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceDate.Text == null ||
                this.InvoiceDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceDueDate()
        {
            
                    
            // Set the InvoiceDueDate Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceDueDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceDueDateSpecified) {
                								
                // If the InvoiceDueDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceDueDate);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceDueDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceDueDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceDueDate.Text = InvoiceSummariesTable.InvoiceDueDate.Format(InvoiceSummariesTable.InvoiceDueDate.DefaultValue);
            		
            }
            
            // If the InvoiceDueDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceDueDate.Text == null ||
                this.InvoiceDueDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceDueDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceId()
        {
            
                    
            // Set the InvoiceId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceIdSpecified) {
                								
                // If the InvoiceId is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceId);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceId.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceId.Text = InvoiceSummariesTable.InvoiceId.Format(InvoiceSummariesTable.InvoiceId.DefaultValue);
            		
            }
            
            // If the InvoiceId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceId.Text == null ||
                this.InvoiceId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceNumber()
        {
            
                    
            // Set the InvoiceNumber Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceNumberSpecified) {
                								
                // If the InvoiceNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceNumber.Text = InvoiceSummariesTable.InvoiceNumber.Format(InvoiceSummariesTable.InvoiceNumber.DefaultValue);
            		
            }
            
            // If the InvoiceNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceNumber.Text == null ||
                this.InvoiceNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetInvoiceTotal()
        {
            
                    
            // Set the InvoiceTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.InvoiceTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.InvoiceTotalSpecified) {
                								
                // If the InvoiceTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.InvoiceTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.InvoiceTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // InvoiceTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.InvoiceTotal.Text = InvoiceSummariesTable.InvoiceTotal.Format(InvoiceSummariesTable.InvoiceTotal.DefaultValue);
            		
            }
            
            // If the InvoiceTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.InvoiceTotal.Text == null ||
                this.InvoiceTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.InvoiceTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetKWhTotal()
        {
            
                    
            // Set the KWhTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.KWhTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.KwhTotalSpecified) {
                								
                // If the KWhTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.KwhTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.KWhTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // KWhTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.KWhTotal.Text = InvoiceSummariesTable.KwhTotal.Format(InvoiceSummariesTable.KwhTotal.DefaultValue);
            		
            }
            
            // If the KWhTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.KWhTotal.Text == null ||
                this.KWhTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.KWhTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetMiscChargesTotal()
        {
            
                    
            // Set the MiscChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.MiscChargesTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.MiscChargesTotalSpecified) {
                								
                // If the MiscChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.MiscChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.MiscChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // MiscChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.MiscChargesTotal.Text = InvoiceSummariesTable.MiscChargesTotal.Format(InvoiceSummariesTable.MiscChargesTotal.DefaultValue);
            		
            }
            
            // If the MiscChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.MiscChargesTotal.Text == null ||
                this.MiscChargesTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.MiscChargesTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetNetworkChargesTotal()
        {
            
                    
            // Set the NetworkChargesTotal Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.NetworkChargesTotal is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NetworkChargesTotalSpecified) {
                								
                // If the NetworkChargesTotal is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.NetworkChargesTotal);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.NetworkChargesTotal.Text = formattedValue;
                   
            } 
            
            else {
            
                // NetworkChargesTotal is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.NetworkChargesTotal.Text = InvoiceSummariesTable.NetworkChargesTotal.Format(InvoiceSummariesTable.NetworkChargesTotal.DefaultValue);
            		
            }
            
            // If the NetworkChargesTotal is NULL or blank, then use the value specified  
            // on Properties.
            if (this.NetworkChargesTotal.Text == null ||
                this.NetworkChargesTotal.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.NetworkChargesTotal.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPeriodEnd()
        {
            
                    
            // Set the PeriodEnd Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PeriodEnd is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PeriodEndSpecified) {
                								
                // If the PeriodEnd is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PeriodEnd);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PeriodEnd.Text = formattedValue;
                   
            } 
            
            else {
            
                // PeriodEnd is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PeriodEnd.Text = InvoiceSummariesTable.PeriodEnd.Format(InvoiceSummariesTable.PeriodEnd.DefaultValue);
            		
            }
            
            // If the PeriodEnd is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PeriodEnd.Text == null ||
                this.PeriodEnd.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PeriodEnd.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPeriodStart()
        {
            
                    
            // Set the PeriodStart Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.PeriodStart is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PeriodStartSpecified) {
                								
                // If the PeriodStart is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(InvoiceSummariesTable.PeriodStart);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PeriodStart.Text = formattedValue;
                   
            } 
            
            else {
            
                // PeriodStart is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PeriodStart.Text = InvoiceSummariesTable.PeriodStart.Format(InvoiceSummariesTable.PeriodStart.DefaultValue);
            		
            }
            
            // If the PeriodStart is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PeriodStart.Text == null ||
                this.PeriodStart.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PeriodStart.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSiteId()
        {
            
                    
            // Set the SiteId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SiteId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SiteIdSpecified) {
                								
                // If the SiteId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SiteId);
               if(_isExpandableNonCompositeForeignKey &&InvoiceSummariesTable.SiteId.IsApplyDisplayAs)
                                  
                     formattedValue = InvoiceSummariesTable.GetDFKA(this.DataSource.SiteId.ToString(),InvoiceSummariesTable.SiteId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(InvoiceSummariesTable.SiteId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SiteId.Text = formattedValue;
                   
            } 
            
            else {
            
                // SiteId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SiteId.Text = InvoiceSummariesTable.SiteId.Format(InvoiceSummariesTable.SiteId.DefaultValue);
            		
            }
            
            // If the SiteId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SiteId.Text == null ||
                this.SiteId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SiteId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSupplierId()
        {
            
                    
            // Set the SupplierId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.InvoiceSummaries database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.InvoiceSummaries record retrieved from the database.
            // this.SupplierId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SupplierIdSpecified) {
                								
                // If the SupplierId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SupplierId);
               if(_isExpandableNonCompositeForeignKey &&InvoiceSummariesTable.SupplierId.IsApplyDisplayAs)
                                  
                     formattedValue = InvoiceSummariesTable.GetDFKA(this.DataSource.SupplierId.ToString(),InvoiceSummariesTable.SupplierId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(InvoiceSummariesTable.SupplierId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.SupplierId.Text = formattedValue;
                   
            } 
            
            else {
            
                // SupplierId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.SupplierId.Text = InvoiceSummariesTable.SupplierId.Format(InvoiceSummariesTable.SupplierId.DefaultValue);
            		
            }
            
            // If the SupplierId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.SupplierId.Text == null ||
                this.SupplierId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.SupplierId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAccountNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetAlert()
                  {
                  
                    
        }
                
        public virtual void SetConnectionNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetContact()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Contact.Text = "Some value";
                    
                    
        }
                
        public virtual void SetContainerId()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.ContainerId.Text = "Some value";
                    
                    
        }
                
        public virtual void SetCustomerNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetEnergyChargesTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetGstTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceDueDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetKWhTotalLabel()
                  {
                  
                        this.KWhTotalLabel.Text = EvaluateFormula("\"kWh Total\"");
                      
                    
        }
                
        public virtual void SetMercury()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Mercury.Text = "Some value";
                    
                    
        }
                
        public virtual void SetMeridian()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Meridian.Text = "Some value";
                    
                    
        }
                
        public virtual void SetMiscChargesTotalLabel()
                  {
                  
                        this.MiscChargesTotalLabel.Text = EvaluateFormula("\"Other Charges Total\"");
                      
                    
        }
                
        public virtual void SetNetworkChargesTotalLabel()
                  {
                  
                    
        }
                
        public virtual void SetPdfFileName()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.PdfFileName.Text = "Some value";
                    
                    
        }
                
        public virtual void SetPeriodEndLabel()
                  {
                  
                    
        }
                
        public virtual void SetPeriodStartLabel()
                  {
                  
                    
        }
                
        public virtual void SetSiteIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetSupplierIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetInvoiceSummariesTableControlTabContainer()    
        
        {
                            
                   
            if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "true") 
                MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControlTabContainer").Visible = true;
            else if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "false") 
                MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControlTabContainer").Visible = false;
         
  
        }      
      
        public virtual void SetEnergyChargesTableControl()           
        
        {        
            if (EnergyChargesTableControl.Visible)
            {
                EnergyChargesTableControl.LoadData();
                EnergyChargesTableControl.DataBind();
            }
        }
      
        public virtual void SetNetworkChargesTableControl()           
        
        {        
            if (NetworkChargesTableControl.Visible)
            {
                NetworkChargesTableControl.LoadData();
                NetworkChargesTableControl.DataBind();
            }
        }
      
        public virtual void SetSitesRecordControl()           
        
        {        
            if (SitesRecordControl.Visible)
            {
                SitesRecordControl.LoadData();
                SitesRecordControl.DataBind();
            }
        }
      
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).DataChanged = true;
                ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          EnergyChargesTableControl recEnergyChargesTableControl = (EnergyChargesTableControl)(MiscUtils.FindControlRecursively(this, "EnergyChargesTableControl"));
        recEnergyChargesTableControl.SaveData();
        NetworkChargesTableControl recNetworkChargesTableControl = (NetworkChargesTableControl)(MiscUtils.FindControlRecursively(this, "NetworkChargesTableControl"));
        recNetworkChargesTableControl.SaveData();
        SitesRecordControl recSitesRecordControl = (SitesRecordControl)(MiscUtils.FindControlRecursively(this, "SitesRecordControl"));
        recSitesRecordControl.SaveData();
        
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetAccountNumber();
            GetConnectionNumber();
            GetCustomerNumber();
            GetEnergyChargesTotal();
            GetEnergyPointId();
            GetGstTotal();
            GetInvoiceDate();
            GetInvoiceDueDate();
            GetInvoiceId();
            GetInvoiceNumber();
            GetInvoiceTotal();
            GetKWhTotal();
            GetMiscChargesTotal();
            GetNetworkChargesTotal();
            GetPeriodEnd();
            GetPeriodStart();
            GetSiteId();
            GetSupplierId();
        }
        
        
        public virtual void GetAccountNumber()
        {
            
        }
                
        public virtual void GetConnectionNumber()
        {
            
        }
                
        public virtual void GetCustomerNumber()
        {
            
        }
                
        public virtual void GetEnergyChargesTotal()
        {
            
        }
                
        public virtual void GetEnergyPointId()
        {
            
        }
                
        public virtual void GetGstTotal()
        {
            
        }
                
        public virtual void GetInvoiceDate()
        {
            
        }
                
        public virtual void GetInvoiceDueDate()
        {
            
        }
                
        public virtual void GetInvoiceId()
        {
            
        }
                
        public virtual void GetInvoiceNumber()
        {
            
        }
                
        public virtual void GetInvoiceTotal()
        {
            
        }
                
        public virtual void GetKWhTotal()
        {
            
        }
                
        public virtual void GetMiscChargesTotal()
        {
            
        }
                
        public virtual void GetNetworkChargesTotal()
        {
            
        }
                
        public virtual void GetPeriodEnd()
        {
            
        }
                
        public virtual void GetPeriodStart()
        {
            
        }
                
        public virtual void GetSiteId()
        {
            
        }
                
        public virtual void GetSupplierId()
        {
            
        }
                

      // To customize, override this method in InvoiceSummariesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          InvoiceSummariesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).DataChanged = true;
            ((InvoiceSummariesTableControl)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton1()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton2()                
              
        {
        
   
        }
            
        public virtual void SetExpandRowButton()                
              
        {
        
   
        }
            
        public virtual void SetFileInvButton()                
              
        {
        
              try
              {
                    string url = "../InvoiceSummaries/Show-InvoiceSummaries.aspx?TabVisible=False&InvoiceSummaries={InvoiceSummariesTableControlRow:PK}";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt("null");
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(null, '" + url + "', false, event);";                                      
                       
                    this.FileInvButton.Button.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, FileInvButton_ClickFileInvButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Edit-InvoiceSummaries-Meridian.aspx?InvoiceSummaries={InvoiceSummariesTableControlRow:PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton1_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Edit-InvoiceSummaries-Contact.aspx?InvoiceSummaries={InvoiceSummariesTableControlRow:PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton2_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Edit-InvoiceSummaries-Mercury.aspx?InvoiceSummaries={InvoiceSummariesTableControlRow:PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void ExpandRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                InvoiceSummariesTableControl panelControl = (MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControl") as InvoiceSummariesTableControl);

          InvoiceSummariesTableControlRow[] repeatedRows = panelControl.GetRecordControls();
          foreach (InvoiceSummariesTableControlRow repeatedRow in repeatedRows)
          {
              System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(repeatedRow, "InvoiceSummariesTableControlAltRow") as System.Web.UI.Control);
              if (altRow != null)
              {
                  if (sender == repeatedRow.ExpandRowButton)
                      altRow.Visible = !altRow.Visible;
                  
                  if (altRow.Visible)
                  {
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'");
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'");
                           
                  }
                  else
                  {
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'");
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'");
                   
                  }
            
              }
              else
              {
                  this.Page.Response.Redirect("../Shared/ConfigureCollapseExpandRowBtn.aspx");
              }
          }
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FileInvButton_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../InvoiceSummaries/Show-InvoiceSummaries.aspx?TabVisible=False&InvoiceSummaries={InvoiceSummariesTableControlRow:PK}";
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt("null");
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(null, '" + url + "', false, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "FileInvButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseInvoiceSummariesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseInvoiceSummariesTableControlRow_Rec"] = value;
            }
        }
        
        public InvoiceSummariesRecord DataSource {
            get {
                return (InvoiceSummariesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal AccountNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal AccountNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AccountNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Alert {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Alert");
            }
        }
        
        public System.Web.UI.WebControls.Literal ConnectionNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal ConnectionNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ConnectionNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Contact {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Contact");
            }
        }
        
        public System.Web.UI.WebControls.Literal ContainerId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContainerId");
            }
        }
        
        public System.Web.UI.WebControls.Literal CustomerNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustomerNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton2 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton2");
            }
        }
        
        public EnergyChargesTableControl EnergyChargesTableControl {
            get {
                return (EnergyChargesTableControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTableControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal EnergyChargesTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal EnergyChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal EnergyPointId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EnergyPointId");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton ExpandRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpandRowButton");
            }
        }
        
        public IDE.UI.IThemeButton FileInvButton {
            get {
                return (IDE.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FileInvButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal GstTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal GstTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GstTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceDueDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceDueDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDueDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceId");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceNumberLabel");
            }
        }
        
        public AjaxControlToolkit.TabContainer InvoiceSummariesTableControlTabContainer {
            get {
                return (AjaxControlToolkit.TabContainer)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControlTabContainer");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal InvoiceTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal KWhTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KWhTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal KWhTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KWhTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Mercury {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Mercury");
            }
        }
        
        public System.Web.UI.WebControls.Literal Meridian {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Meridian");
            }
        }
        
        public System.Web.UI.WebControls.Literal MiscChargesTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal MiscChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MiscChargesTotalLabel");
            }
        }
        
        public NetworkChargesTableControl NetworkChargesTableControl {
            get {
                return (NetworkChargesTableControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTableControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal NetworkChargesTotal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotal");
            }
        }
            
        public System.Web.UI.WebControls.Literal NetworkChargesTotalLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTotalLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PdfFileName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PdfFileName");
            }
        }
        
        public System.Web.UI.WebControls.Literal PeriodEnd {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodEnd");
            }
        }
            
        public System.Web.UI.WebControls.Literal PeriodEndLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodEndLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PeriodStart {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodStart");
            }
        }
            
        public System.Web.UI.WebControls.Literal PeriodStartLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PeriodStartLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal SiteId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteId");
            }
        }
            
        public System.Web.UI.WebControls.Literal SiteIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteIdLabel");
            }
        }
        
        public SitesRecordControl SitesRecordControl {
            get {
                return (SitesRecordControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SitesRecordControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal SupplierId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SupplierId");
            }
        }
            
        public System.Web.UI.WebControls.Literal SupplierIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SupplierIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Image UploadedOkImage {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UploadedOkImage");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        InvoiceSummariesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    InvoiceSummariesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual InvoiceSummariesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return InvoiceSummariesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "IDE"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the InvoiceSummariesTableControl control on the Group_By_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in InvoiceSummariesTableControl.
public class BaseInvoiceSummariesTableControl : IDE.UI.BaseApplicationTableControl
{
         
       public BaseInvoiceSummariesTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.OrderSort)) 				
                    initialVal = this.GetFromSession(this.OrderSort);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.OrderSort.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.OrderSort.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.InvoiceDateFromFilter)) 				
                    initialVal = this.GetFromSession(this.InvoiceDateFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"InvoiceDateFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.InvoiceDateFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.InvoiceDateToFilter)) 				
                    initialVal = this.GetFromSession(this.InvoiceDateToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"InvoiceDateTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.InvoiceDateToFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SearchText)) 				
                    initialVal = this.GetFromSession(this.SearchText);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SearchText.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SiteIdFilter)) 				
                    initialVal = this.GetFromSession(this.SiteIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"SiteId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] SiteIdFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in SiteIdFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.SiteIdFilter.Items.Add(item);
                            this.SiteIdFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.SiteIdFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.SupplierIdFilter)) 				
                    initialVal = this.GetFromSession(this.SupplierIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"SupplierId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] SupplierIdFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in SupplierIdFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.SupplierIdFilter.Items.Add(item);
                            this.SupplierIdFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.SupplierIdFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.CheckedOkFilter)) 				
                    initialVal = this.GetFromSession(this.CheckedOkFilter);
                
                else
                    
                    initialVal = EvaluateFormula("0");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.CheckedOkFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.CheckedOkFilter.SelectedValue = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(InvoiceSummariesTable.InvoiceSummaryId, OrderByItem.OrderDir.Asc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.SearchButton.Click += SearchButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.OrderSort.SelectedIndexChanged += new EventHandler(OrderSort_SelectedIndexChanged);
            
              this.SiteIdFilter.SelectedIndexChanged += SiteIdFilter_SelectedIndexChanged;                  
                
              this.SupplierIdFilter.SelectedIndexChanged += SupplierIdFilter_SelectedIndexChanged;                  
                
            this.CheckedOkFilter.SelectedIndexChanged += new EventHandler(CheckedOkFilter_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + SearchText.ClientID + "\");", true);
             
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(IDE.Business.InvoiceSummariesRecord);
                      this.DataSource = (InvoiceSummariesRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (InvoiceSummariesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IDE.Business.InvoiceSummariesRecord);
                    this.DataSource = (InvoiceSummariesRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual InvoiceSummariesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(InvoiceSummariesTable.Column1, true);          
            // selCols.Add(InvoiceSummariesTable.Column2, true);          
            // selCols.Add(InvoiceSummariesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return InvoiceSummariesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                InvoiceSummariesTable databaseTable = new InvoiceSummariesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(InvoiceSummariesRecord)) as InvoiceSummariesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(InvoiceSummariesTable.Column1, true);          
            // selCols.Add(InvoiceSummariesTable.Column2, true);          
            // selCols.Add(InvoiceSummariesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return InvoiceSummariesTable.GetRecordCount(join, where);
            else
            {
                InvoiceSummariesTable databaseTable = new InvoiceSummariesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            InvoiceSummariesTableControlRow recControl = (InvoiceSummariesTableControlRow)(repItem.FindControl("InvoiceSummariesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetCheckedText();
                
                
                
                SetInvoiceDateLabel1();
                
                
                SetOrderSort();
                
                
                
                SetSearchText();
                SetSiteIdFilter();
                SetSiteIdLabel1();
                SetSortByLabel();
                SetSupplierIdFilter();
                SetSupplierIdLabel1();
                
                
                
                SetCheckedOkFilter();
                SetResetButton();
              
                SetSearchButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            bool expandFirstRow = false;          
        InvoiceSummariesTableControlRow[] recControls = this.GetRecordControls();
            for (int i = 0; i < recControls.Length; i++)
            {
                System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(recControls[i], "InvoiceSummariesTableControlAltRow") as System.Web.UI.Control);
                if (altRow != null){
                    if (expandFirstRow && i == 0){
                        altRow.Visible = true;
                   
                         recControls[i].ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'");
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'");
                   
                    }
                    else{
                        altRow.Visible = false;
                   
                         recControls[i].ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'");
                         recControls[i].ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'");
                   
                    }
                }
            }
    
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(InvoiceSummariesTable.EnergyPointId, this.DataSource);
            this.Page.PregetDfkaRecords(InvoiceSummariesTable.SiteId, this.DataSource);
            this.Page.PregetDfkaRecords(InvoiceSummariesTable.SupplierId, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.SiteIdFilter.ClearSelection();
            
            this.SupplierIdFilter.ClearSelection();
            
            this.CheckedOkFilter.ClearSelection();
            
            this.OrderSort.ClearSelection();
            
            this.InvoiceDateFromFilter.Text = "";
            
            this.InvoiceDateToFilter.Text = "";
            
            this.SearchText.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(InvoiceSummariesTable.InvoiceSummaryId, OrderByItem.OrderDir.Asc);
                 
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for InvoiceSummariesTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (InvoiceSummariesTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (InvoiceSummariesTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            InvoiceSummariesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.InvoiceDateFromFilter)) {
                string val = MiscUtils.GetSelectedValue(this.InvoiceDateFromFilter, this.GetFromSession(this.InvoiceDateFromFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "00:00:00";
                wc.iAND(InvoiceSummariesTable.InvoiceDate, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.InvoiceDateToFilter)) {
                string val = MiscUtils.GetSelectedValue(this.InvoiceDateToFilter, this.GetFromSession(this.InvoiceDateToFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "23:59:59";
                wc.iAND(InvoiceSummariesTable.InvoiceDate, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.SearchText)) {
                if (this.SearchText.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.SearchText.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.SearchText.Text.StartsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(3,this.SearchText.Text.Length-3);
                  }
                  if (this.SearchText.Text.EndsWith("...")) {
                      this.SearchText.Text = this.SearchText.Text.Substring(0,this.SearchText.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.SearchText.Text.Length - 1;
                      while (!Char.IsWhiteSpace(SearchText.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.SearchText.Text = this.SearchText.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SearchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(InvoiceSummariesTable.SiteName, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SearchText, this.GetFromSession(this.SearchText)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.SiteIdFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.SiteIdFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.SiteIdFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(InvoiceSummariesTable.SiteId, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.SupplierIdFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.SupplierIdFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.SupplierIdFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(InvoiceSummariesTable.SupplierId, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.CheckedOkFilter)) {
                        
                wc.iAND(InvoiceSummariesTable.CheckedOk, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.CheckedOkFilter, this.GetFromSession(this.CheckedOkFilter)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            InvoiceSummariesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            string InvoiceDateFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "InvoiceDateFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(InvoiceDateFromFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(InvoiceDateFromFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                InvoiceDateFromFilterSelectedValue = d.ToShortDateString() + " " + "00:00:00";
                    
                wc.iAND(InvoiceSummariesTable.InvoiceDate, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, InvoiceDateFromFilterSelectedValue, false, false);
                    
            }         
            string InvoiceDateToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "InvoiceDateToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(InvoiceDateToFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(InvoiceDateToFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                InvoiceDateToFilterSelectedValue = d.ToShortDateString() + " " + "23:59:59";
                    
                wc.iAND(InvoiceSummariesTable.InvoiceDate, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, InvoiceDateToFilterSelectedValue, false, false);
                    
            }         
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "SearchText") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
        ColumnList cols = new ColumnList();
      
      cols.Add(InvoiceSummariesTable.SiteName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(InvoiceSummariesTable.SiteName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  
      String SiteIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "SiteIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(SiteIdFilterSelectedValue)) {

              
        if (SiteIdFilterSelectedValue != null){
                        string[] SiteIdFilteritemListFromSession = SiteIdFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in SiteIdFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(InvoiceSummariesTable.SiteId, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String SupplierIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "SupplierIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(SupplierIdFilterSelectedValue)) {

              
        if (SupplierIdFilterSelectedValue != null){
                        string[] SupplierIdFilteritemListFromSession = SupplierIdFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in SupplierIdFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(InvoiceSummariesTable.SupplierId, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String CheckedOkFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CheckedOkFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CheckedOkFilterSelectedValue)) {

              
                wc.iAND(InvoiceSummariesTable.CheckedOk, BaseFilter.ComparisonOperator.EqualsTo, CheckedOkFilterSelectedValue, false, false);
                      
      }
                      

            return wc;
        }

        
        public virtual string[] GetAutoCompletionList_SearchText(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            IDE.Business.InvoiceSummariesRecord[] recordList  = InvoiceSummariesTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (InvoiceSummariesRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(InvoiceSummariesTable.SiteName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(InvoiceSummariesTable.SiteName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, InvoiceSummariesTable.SiteName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
                      
            }
              
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
        }
          
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceSummariesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                InvoiceSummariesTableControlRow recControl = (InvoiceSummariesTableControlRow)(repItem.FindControl("InvoiceSummariesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      InvoiceSummariesRecord rec = new InvoiceSummariesRecord();
        
                        if (recControl.AccountNumber.Text != "") {
                            rec.Parse(recControl.AccountNumber.Text, InvoiceSummariesTable.AccountNumber);
                  }
                
                        if (recControl.ConnectionNumber.Text != "") {
                            rec.Parse(recControl.ConnectionNumber.Text, InvoiceSummariesTable.ConnectionNumber);
                  }
                
                        if (recControl.CustomerNumber.Text != "") {
                            rec.Parse(recControl.CustomerNumber.Text, InvoiceSummariesTable.CustomerNumber);
                  }
                
                        if (recControl.EnergyChargesTotal.Text != "") {
                            rec.Parse(recControl.EnergyChargesTotal.Text, InvoiceSummariesTable.EnergyChargesTotal);
                  }
                
                        if (recControl.EnergyPointId.Text != "") {
                            rec.Parse(recControl.EnergyPointId.Text, InvoiceSummariesTable.EnergyPointId);
                  }
                
                        if (recControl.GstTotal.Text != "") {
                            rec.Parse(recControl.GstTotal.Text, InvoiceSummariesTable.GstTotal);
                  }
                
                        if (recControl.InvoiceDate.Text != "") {
                            rec.Parse(recControl.InvoiceDate.Text, InvoiceSummariesTable.InvoiceDate);
                  }
                
                        if (recControl.InvoiceDueDate.Text != "") {
                            rec.Parse(recControl.InvoiceDueDate.Text, InvoiceSummariesTable.InvoiceDueDate);
                  }
                
                        if (recControl.InvoiceId.Text != "") {
                            rec.Parse(recControl.InvoiceId.Text, InvoiceSummariesTable.InvoiceId);
                  }
                
                        if (recControl.InvoiceNumber.Text != "") {
                            rec.Parse(recControl.InvoiceNumber.Text, InvoiceSummariesTable.InvoiceNumber);
                  }
                
                        if (recControl.InvoiceTotal.Text != "") {
                            rec.Parse(recControl.InvoiceTotal.Text, InvoiceSummariesTable.InvoiceTotal);
                  }
                
                        if (recControl.KWhTotal.Text != "") {
                            rec.Parse(recControl.KWhTotal.Text, InvoiceSummariesTable.KwhTotal);
                  }
                
                        if (recControl.MiscChargesTotal.Text != "") {
                            rec.Parse(recControl.MiscChargesTotal.Text, InvoiceSummariesTable.MiscChargesTotal);
                  }
                
                        if (recControl.NetworkChargesTotal.Text != "") {
                            rec.Parse(recControl.NetworkChargesTotal.Text, InvoiceSummariesTable.NetworkChargesTotal);
                  }
                
                        if (recControl.PeriodEnd.Text != "") {
                            rec.Parse(recControl.PeriodEnd.Text, InvoiceSummariesTable.PeriodEnd);
                  }
                
                        if (recControl.PeriodStart.Text != "") {
                            rec.Parse(recControl.PeriodStart.Text, InvoiceSummariesTable.PeriodStart);
                  }
                
                        if (recControl.SiteId.Text != "") {
                            rec.Parse(recControl.SiteId.Text, InvoiceSummariesTable.SiteId);
                  }
                
                        if (recControl.SupplierId.Text != "") {
                            rec.Parse(recControl.SupplierId.Text, InvoiceSummariesTable.SupplierId);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new InvoiceSummariesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IDE.Business.InvoiceSummariesRecord);
                this.DataSource = (InvoiceSummariesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(InvoiceSummariesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(InvoiceSummariesTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetCheckedText()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.CheckedText.Text = "Some value";
                    
                    
        }
                
        public virtual void SetInvoiceDateLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSiteIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetSupplierIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetOrderSort()
        {
            
                this.PopulateOrderSort(MiscUtils.GetSelectedValue(this.OrderSort,  GetFromSession(this.OrderSort)), 500);					
                    

        }
            
        public virtual void SetSearchText()
        {
                                            
            this.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        public virtual void SetSiteIdFilter()
        {
            
            ArrayList SiteIdFilterselectedFilterItemList = new ArrayList();
            string SiteIdFilteritemsString = null;
            if (this.InSession(this.SiteIdFilter))
                SiteIdFilteritemsString = this.GetFromSession(this.SiteIdFilter);
            
            if (SiteIdFilteritemsString != null)
            {
                string[] SiteIdFilteritemListFromSession = SiteIdFilteritemsString.Split(',');
                foreach (string item in SiteIdFilteritemListFromSession)
                {
                    SiteIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateSiteIdFilter(MiscUtils.GetSelectedValueList(this.SiteIdFilter, SiteIdFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Sites/Sites-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.SiteIdFilter.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("SiteName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("SiteId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.SiteIdFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(SiteIdFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetSupplierIdFilter()
        {
            
            ArrayList SupplierIdFilterselectedFilterItemList = new ArrayList();
            string SupplierIdFilteritemsString = null;
            if (this.InSession(this.SupplierIdFilter))
                SupplierIdFilteritemsString = this.GetFromSession(this.SupplierIdFilter);
            
            if (SupplierIdFilteritemsString != null)
            {
                string[] SupplierIdFilteritemListFromSession = SupplierIdFilteritemsString.Split(',');
                foreach (string item in SupplierIdFilteritemListFromSession)
                {
                    SupplierIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateSupplierIdFilter(MiscUtils.GetSelectedValueList(this.SupplierIdFilter, SupplierIdFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../EnergySuppliers/EnergySuppliers-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.SupplierIdFilter.ClientID + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("SupplierName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("SupplierId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.SupplierIdFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(SupplierIdFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetCheckedOkFilter()
        {
            
            this.PopulateCheckedOkFilter(MiscUtils.GetSelectedValue(this.CheckedOkFilter,  GetFromSession(this.CheckedOkFilter)), 500);					
                                     
        }
            
        // Get the filters' data for OrderSort.
                
        protected virtual void PopulateOrderSort(string selectedValue, int maxItems)
                    
        {
            
              
                this.OrderSort.Items.Clear();
                
              // 1. Setup the static list items
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Account Number {Txt:Ascending}"), "AccountNumber Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Account Number {Txt:Descending}"), "AccountNumber Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved {Txt:Ascending}"), "Approved Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved {Txt:Descending}"), "Approved Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved By {Txt:Ascending}"), "ApprovedById Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved By {Txt:Descending}"), "ApprovedById Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Ascending}"), "ApprovedDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Approved Date {Txt:Descending}"), "ApprovedDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Connection Number {Txt:Ascending}"), "ConnectionNumber Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Connection Number {Txt:Descending}"), "ConnectionNumber Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Number {Txt:Ascending}"), "CustomerNumber Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Customer Number {Txt:Descending}"), "CustomerNumber Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Ascending}"), "InvoiceDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Date {Txt:Descending}"), "InvoiceDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Ascending}"), "InvoiceDueDate Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Invoice Due Date {Txt:Descending}"), "InvoiceDueDate Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site {Txt:Ascending}"), "SiteId Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site {Txt:Descending}"), "SiteId Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Name {Txt:Ascending}"), "SiteName Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Site Name {Txt:Descending}"), "SiteName Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period End {Txt:Ascending}"), "PeriodEnd Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period End {Txt:Descending}"), "PeriodEnd Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period Start {Txt:Ascending}"), "PeriodStart Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Period Start {Txt:Descending}"), "PeriodStart Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Point {Txt:Ascending}"), "EnergyPointId Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Energy Point {Txt:Descending}"), "EnergyPointId Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Supplier {Txt:Ascending}"), "SupplierId Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Supplier {Txt:Descending}"), "SupplierId Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("K Warehouse Total {Txt:Ascending}"), "KWhTotal Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("K Warehouse Total {Txt:Descending}"), "KWhTotal Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Checked OK {Txt:Ascending}"), "CheckedOk Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Checked OK {Txt:Descending}"), "CheckedOk Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("On File {Txt:Ascending}"), "OnFile Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("On File {Txt:Descending}"), "OnFile Desc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Verified {Txt:Ascending}"), "Verified Asc"));
              
                this.OrderSort.Items.Add(new ListItem(this.Page.ExpandResourceValue("Verified {Txt:Descending}"), "Verified Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.OrderSort, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.OrderSort.SelectedValue != null && this.OrderSort.Items.FindByValue(this.OrderSort.SelectedValue) == null)
                this.OrderSort.SelectedValue = null;
              
        }
            
        // Get the filters' data for SiteIdFilter.
                
        protected virtual void PopulateSiteIdFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_SiteIdFilter();            
            this.SiteIdFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_SiteIdFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IDE");

            SitesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = SitesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (SitesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.SiteIdSpecified) 
                        {
                            cvalue = itemValue.SiteId.ToString();
                            if (counter < maxItems && this.SiteIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SiteId);
                                if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.SiteId.IsApplyDisplayAs)
                                     fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.SiteId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(SitesTable.SiteName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.SiteIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.SiteIdFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.SiteIdFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.SiteIdFilter.Items.Count == 0)
                this.SiteIdFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "IDE"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.SiteIdFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for SupplierIdFilter.
                
        protected virtual void PopulateSupplierIdFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_SupplierIdFilter();            
            this.SupplierIdFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_SupplierIdFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IDE");

            EnergySuppliersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = EnergySuppliersTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (EnergySuppliersRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.SupplierIdSpecified) 
                        {
                            cvalue = itemValue.SupplierId.ToString();
                            if (counter < maxItems && this.SupplierIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = InvoiceSummariesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(InvoiceSummariesTable.SupplierId);
                                if(_isExpandableNonCompositeForeignKey && InvoiceSummariesTable.SupplierId.IsApplyDisplayAs)
                                     fvalue = InvoiceSummariesTable.GetDFKA(itemValue, InvoiceSummariesTable.SupplierId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(EnergySuppliersTable.SupplierName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.SupplierIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.SupplierIdFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.SupplierIdFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.SupplierIdFilter.Items.Count == 0)
                this.SupplierIdFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "IDE"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.SupplierIdFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for CheckedOkFilter.
                
        protected virtual void PopulateCheckedOkFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.CheckedOkFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_CheckedOkFilter();            
            		  
            // Skip load data from database and insert data
            // Setup the static list items        
            
                this.CheckedOkFilter.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:All}"), "--ANY--"));
              
                this.CheckedOkFilter.Items.Add(new ListItem(this.Page.ExpandResourceValue("Checked Okay"), "1"));
              
                this.CheckedOkFilter.Items.Add(new ListItem(this.Page.ExpandResourceValue("Incorrect"), "0"));
                    
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.CheckedOkFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.CheckedOkFilter.SelectedValue != null && this.CheckedOkFilter.Items.FindByValue(this.CheckedOkFilter.SelectedValue) == null)
                this.CheckedOkFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_SiteIdFilter()
        {
            // Create a where clause for the filter SiteIdFilter.
            // This function is called by the Populate method to load the items 
            // in the SiteIdFilterQuickSelector
        
            ArrayList SiteIdFilterselectedFilterItemList = new ArrayList();
            string SiteIdFilteritemsString = null;
            if (this.InSession(this.SiteIdFilter))
                SiteIdFilteritemsString = this.GetFromSession(this.SiteIdFilter);
            
            if (SiteIdFilteritemsString != null)
            {
                string[] SiteIdFilteritemListFromSession = SiteIdFilteritemsString.Split(',');
                foreach (string item in SiteIdFilteritemListFromSession)
                {
                    SiteIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            SiteIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SiteIdFilter, SiteIdFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (SiteIdFilterselectedFilterItemList == null || SiteIdFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in SiteIdFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(SitesTable.SiteId, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_SupplierIdFilter()
        {
            // Create a where clause for the filter SupplierIdFilter.
            // This function is called by the Populate method to load the items 
            // in the SupplierIdFilterQuickSelector
        
            ArrayList SupplierIdFilterselectedFilterItemList = new ArrayList();
            string SupplierIdFilteritemsString = null;
            if (this.InSession(this.SupplierIdFilter))
                SupplierIdFilteritemsString = this.GetFromSession(this.SupplierIdFilter);
            
            if (SupplierIdFilteritemsString != null)
            {
                string[] SupplierIdFilteritemListFromSession = SupplierIdFilteritemsString.Split(',');
                foreach (string item in SupplierIdFilteritemListFromSession)
                {
                    SupplierIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            SupplierIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SupplierIdFilter, SupplierIdFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (SupplierIdFilterselectedFilterItemList == null || SupplierIdFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in SupplierIdFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(EnergySuppliersTable.SupplierId, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_CheckedOkFilter()
        {
            // Create a where clause for the filter CheckedOkFilter.
            // This function is called by the Populate method to load the items 
            // in the CheckedOkFilterDropDownList
        CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("InvoiceSummariesTableControl.CheckedOkFilter.SelectedValue", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"IDE.Business.InvoiceSummariesTable, IDE.Business").TableDefinition.ColumnList.GetByUniqueName(@"InvoiceSummaries_.CheckedOk"), EvaluateFormula("InvoiceSummariesTableControl.CheckedOkFilter.SelectedValue", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("InvoiceSummariesTableControl.CheckedOkFilter.SelectedValue", false) == "--PLEASE_SELECT--" || EvaluateFormula("InvoiceSummariesTableControl.CheckedOkFilter.SelectedValue", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
      

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
            this.SaveToSession(this.InvoiceDateFromFilter, this.InvoiceDateFromFilter.Text);
                  
            this.SaveToSession(this.InvoiceDateToFilter, this.InvoiceDateToFilter.Text);
                  
            this.SaveToSession(this.SearchText, this.SearchText.Text);
                  
            ArrayList SiteIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SiteIdFilter, null);
            string SiteIdFilterSessionString = "";
            if (SiteIdFilterselectedFilterItemList != null){
                foreach (string item in SiteIdFilterselectedFilterItemList){
                    SiteIdFilterSessionString = String.Concat(SiteIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.SiteIdFilter, SiteIdFilterSessionString);
                  
            ArrayList SupplierIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SupplierIdFilter, null);
            string SupplierIdFilterSessionString = "";
            if (SupplierIdFilterselectedFilterItemList != null){
                foreach (string item in SupplierIdFilterselectedFilterItemList){
                    SupplierIdFilterSessionString = String.Concat(SupplierIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.SupplierIdFilter, SupplierIdFilterSessionString);
                  
            this.SaveToSession(this.CheckedOkFilter, this.CheckedOkFilter.SelectedValue);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.OrderSort, this.OrderSort.SelectedValue);
                  
      this.SaveToSession("InvoiceDateFromFilter_Ajax", this.InvoiceDateFromFilter.Text);
              
      this.SaveToSession("InvoiceDateToFilter_Ajax", this.InvoiceDateToFilter.Text);
              
      this.SaveToSession("SearchText_Ajax", this.SearchText.Text);
              
            ArrayList SiteIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SiteIdFilter, null);
            string SiteIdFilterSessionString = "";
            if (SiteIdFilterselectedFilterItemList != null){
                foreach (string item in SiteIdFilterselectedFilterItemList){
                    SiteIdFilterSessionString = String.Concat(SiteIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("SiteIdFilter_Ajax", SiteIdFilterSessionString);
          
            ArrayList SupplierIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.SupplierIdFilter, null);
            string SupplierIdFilterSessionString = "";
            if (SupplierIdFilterselectedFilterItemList != null){
                foreach (string item in SupplierIdFilterselectedFilterItemList){
                    SupplierIdFilterSessionString = String.Concat(SupplierIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("SupplierIdFilter_Ajax", SupplierIdFilterSessionString);
          
      this.SaveToSession("CheckedOkFilter_Ajax", this.CheckedOkFilter.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrderSort);
            this.RemoveFromSession(this.InvoiceDateFromFilter);
            this.RemoveFromSession(this.InvoiceDateToFilter);
            this.RemoveFromSession(this.SearchText);
            this.RemoveFromSession(this.SiteIdFilter);
            this.RemoveFromSession(this.SupplierIdFilter);
            this.RemoveFromSession(this.CheckedOkFilter);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["InvoiceSummariesTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["InvoiceSummariesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(SiteIdFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(SupplierIdFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(CheckedOkFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.SiteIdFilter.ClearSelection();
            
              this.SupplierIdFilter.ClearSelection();
            
              this.CheckedOkFilter.ClearSelection();
            
           
            this.OrderSort.ClearSelection();
          
              this.InvoiceDateFromFilter.Text = "";
            
              this.InvoiceDateToFilter.Text = "";
            
              this.SearchText.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(InvoiceSummariesTable.InvoiceSummaryId, OrderByItem.OrderDir.Asc);          
                      
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void SearchButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FiltersButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void OrderSort_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.OrderSort.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in InvoiceSummariesTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(InvoiceSummariesTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (InvoiceSummariesTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && InvoiceSummariesTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(InvoiceSummariesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(InvoiceSummariesTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void SiteIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void SupplierIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void CheckedOkFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = InvoiceSummariesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  InvoiceSummariesRecord[] DataSource {
             
            get {
                return (InvoiceSummariesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Label CheckedText {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CheckedText");
            }
        }
        
        public IDE.UI.IThemeButton FilterButton {
            get {
                return (IDE.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public IDE.UI.IThemeButtonWithArrow FiltersButton {
            get {
                return (IDE.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvoiceDateFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDateFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal InvoiceDateLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDateLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox InvoiceDateToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "InvoiceDateToFilter");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList OrderSort {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrderSort");
          }
          }
        
        public IDE.UI.IPaginationModern Pagination {
            get {
                return (IDE.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SearchText {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SearchText");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector SiteIdFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteIdFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal SiteIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SiteIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector SupplierIdFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SupplierIdFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal SupplierIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SupplierIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CheckedOkFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CheckedOkFilter");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                InvoiceSummariesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        InvoiceSummariesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                InvoiceSummariesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        InvoiceSummariesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual InvoiceSummariesTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual InvoiceSummariesTableControlRow[] GetSelectedRecordControls()
        {
        
            return (InvoiceSummariesTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IDE.UI.Controls.Group_By_InvoiceSummaries_Table.InvoiceSummariesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            InvoiceSummariesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (InvoiceSummariesTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual InvoiceSummariesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "InvoiceSummariesTableControlRow");
	          List<InvoiceSummariesTableControlRow> list = new List<InvoiceSummariesTableControlRow>();
	          foreach (InvoiceSummariesTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the NetworkChargesTableControlRow control on the Group_By_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in NetworkChargesTableControlRow.
public class BaseNetworkChargesTableControlRow : IDE.UI.BaseApplicationRecordControl
{
        public BaseNetworkChargesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in NetworkChargesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in NetworkChargesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.NetworkCharges record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = NetworkChargesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseNetworkChargesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new NetworkChargesRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetCapacityCharge();
                SetCapacityChargeLabel();
                SetDemandCharge();
                SetDemandChargeLabel();
                SetFixedCharge();
                SetFixedChargeLabel();
                SetVariableBD();
                SetVariableBDLabel();
                SetVariableNBD();
                SetVariableNBDLabel();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetCapacityCharge()
        {
            
                    
            // Set the CapacityCharge Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.CapacityCharge is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CapacityChargeSpecified) {
                								
                // If the CapacityCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.CapacityCharge);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CapacityCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // CapacityCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CapacityCharge.Text = NetworkChargesTable.CapacityCharge.Format(NetworkChargesTable.CapacityCharge.DefaultValue);
            		
            }
            
            // If the CapacityCharge is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CapacityCharge.Text == null ||
                this.CapacityCharge.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CapacityCharge.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetDemandCharge()
        {
            
                    
            // Set the DemandCharge Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.DemandCharge is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DemandChargeSpecified) {
                								
                // If the DemandCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.DemandCharge);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.DemandCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // DemandCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DemandCharge.Text = NetworkChargesTable.DemandCharge.Format(NetworkChargesTable.DemandCharge.DefaultValue);
            		
            }
            
            // If the DemandCharge is NULL or blank, then use the value specified  
            // on Properties.
            if (this.DemandCharge.Text == null ||
                this.DemandCharge.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.DemandCharge.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFixedCharge()
        {
            
                    
            // Set the FixedCharge Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.FixedCharge is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FixedChargeSpecified) {
                								
                // If the FixedCharge is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.FixedCharge);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FixedCharge.Text = formattedValue;
                   
            } 
            
            else {
            
                // FixedCharge is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FixedCharge.Text = NetworkChargesTable.FixedCharge.Format(NetworkChargesTable.FixedCharge.DefaultValue);
            		
            }
            
            // If the FixedCharge is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FixedCharge.Text == null ||
                this.FixedCharge.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FixedCharge.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVariableBD()
        {
            
                    
            // Set the VariableBD Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.VariableBD is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VariableBDSpecified) {
                								
                // If the VariableBD is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.VariableBD);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.VariableBD.Text = formattedValue;
                   
            } 
            
            else {
            
                // VariableBD is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VariableBD.Text = NetworkChargesTable.VariableBD.Format(NetworkChargesTable.VariableBD.DefaultValue);
            		
            }
            
            // If the VariableBD is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VariableBD.Text == null ||
                this.VariableBD.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VariableBD.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetVariableNBD()
        {
            
                    
            // Set the VariableNBD Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.NetworkCharges database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.NetworkCharges record retrieved from the database.
            // this.VariableNBD is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.VariableNBDSpecified) {
                								
                // If the VariableNBD is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(NetworkChargesTable.VariableNBD);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.VariableNBD.Text = formattedValue;
                   
            } 
            
            else {
            
                // VariableNBD is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.VariableNBD.Text = NetworkChargesTable.VariableNBD.Format(NetworkChargesTable.VariableNBD.DefaultValue);
            		
            }
            
            // If the VariableNBD is NULL or blank, then use the value specified  
            // on Properties.
            if (this.VariableNBD.Text == null ||
                this.VariableNBD.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.VariableNBD.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCapacityChargeLabel()
                  {
                  
                    
        }
                
        public virtual void SetDemandChargeLabel()
                  {
                  
                    
        }
                
        public virtual void SetFixedChargeLabel()
                  {
                  
                    
        }
                
        public virtual void SetVariableBDLabel()
                  {
                  
                        this.VariableBDLabel.Text = EvaluateFormula("\"Variable Charge Business/Weekday\"");
                      
                    
        }
                
        public virtual void SetVariableNBDLabel()
                  {
                  
                        this.VariableNBDLabel.Text = EvaluateFormula("\"Variable Charge Non Business / Weekend\"");
                      
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        InvoiceSummariesTableControlRow parentCtrl;
      
            parentCtrl = (InvoiceSummariesTableControlRow)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          this.DataSource.NetworkChargeId = parentCtrl.DataSource.InvoiceSummaryId;
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).DataChanged = true;
                ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetCapacityCharge();
            GetDemandCharge();
            GetFixedCharge();
            GetVariableBD();
            GetVariableNBD();
        }
        
        
        public virtual void GetCapacityCharge()
        {
            
        }
                
        public virtual void GetDemandCharge()
        {
            
        }
                
        public virtual void GetFixedCharge()
        {
            
        }
                
        public virtual void GetVariableBD()
        {
            
        }
                
        public virtual void GetVariableNBD()
        {
            
        }
                

      // To customize, override this method in NetworkChargesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          NetworkChargesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).DataChanged = true;
            ((NetworkChargesTableControl)MiscUtils.GetParentControlObject(this, "NetworkChargesTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseNetworkChargesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseNetworkChargesTableControlRow_Rec"] = value;
            }
        }
        
        public NetworkChargesRecord DataSource {
            get {
                return (NetworkChargesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal CapacityCharge {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CapacityCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal CapacityChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CapacityChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal DemandCharge {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DemandCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal DemandChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DemandChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal FixedCharge {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FixedCharge");
            }
        }
            
        public System.Web.UI.WebControls.Literal FixedChargeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FixedChargeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VariableBD {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableBD");
            }
        }
            
        public System.Web.UI.WebControls.Literal VariableBDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableBDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal VariableNBD {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableNBD");
            }
        }
            
        public System.Web.UI.WebControls.Literal VariableNBDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VariableNBDLabel");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        NetworkChargesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    NetworkChargesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual NetworkChargesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return NetworkChargesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the NetworkChargesTableControl control on the Group_By_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in NetworkChargesTableControl.
public class BaseNetworkChargesTableControl : IDE.UI.BaseApplicationTableControl
{
         
       public BaseNetworkChargesTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination1.FirstPage.Click += Pagination1_FirstPage_Click;
                        
                    this.Pagination1.LastPage.Click += Pagination1_LastPage_Click;
                        
                    this.Pagination1.NextPage.Click += Pagination1_NextPage_Click;
                        
                    this.Pagination1.PageSizeButton.Click += Pagination1_PageSizeButton_Click;
                        
                    this.Pagination1.PreviousPage.Click += Pagination1_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
                  
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(IDE.Business.NetworkChargesRecord);
                      this.DataSource = (NetworkChargesRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (NetworkChargesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IDE.Business.NetworkChargesRecord);
                    this.DataSource = (NetworkChargesRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual NetworkChargesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(NetworkChargesTable.Column1, true);          
            // selCols.Add(NetworkChargesTable.Column2, true);          
            // selCols.Add(NetworkChargesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return NetworkChargesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                NetworkChargesTable databaseTable = new NetworkChargesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(NetworkChargesRecord)) as NetworkChargesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(NetworkChargesTable.Column1, true);          
            // selCols.Add(NetworkChargesTable.Column2, true);          
            // selCols.Add(NetworkChargesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return NetworkChargesTable.GetRecordCount(join, where);
            else
            {
                NetworkChargesTable databaseTable = new NetworkChargesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
               

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            NetworkChargesTableControlRow recControl = (NetworkChargesTableControlRow)(repItem.FindControl("NetworkChargesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination1.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination1.CurrentPage.Text = "0";
            }
            this.Pagination1.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for NetworkChargesTableControl pagination.
        
            this.Pagination1.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination1.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination1.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination1.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination1.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (NetworkChargesTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (NetworkChargesTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            NetworkChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue invoiceSummariesRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = invoiceSummariesRecordObj;
          invoiceSummariesRecordObj = tmp;
        InvoiceSummariesTableControlRow invoiceSummariesTableControlObjRow = (MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow") as InvoiceSummariesTableControlRow);
          
              if (invoiceSummariesTableControlObjRow != null && invoiceSummariesTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(NetworkChargesTable.NetworkChargeId, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesTableControlObjRow.GetRecord().InvoiceSummaryId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["NetworkChargesTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            NetworkChargesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesTableControl = HttpContext.Current.Session["NetworkChargesTableControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesTableControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(NetworkChargesTable.NetworkChargeId))
      {
      wc.iAND(NetworkChargesTable.NetworkChargeId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(NetworkChargesTable.NetworkChargeId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          

            return wc;
        }

        
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination1.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination1.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NetworkChargesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                NetworkChargesTableControlRow recControl = (NetworkChargesTableControlRow)(repItem.FindControl("NetworkChargesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      NetworkChargesRecord rec = new NetworkChargesRecord();
        
                        if (recControl.CapacityCharge.Text != "") {
                            rec.Parse(recControl.CapacityCharge.Text, NetworkChargesTable.CapacityCharge);
                  }
                
                        if (recControl.DemandCharge.Text != "") {
                            rec.Parse(recControl.DemandCharge.Text, NetworkChargesTable.DemandCharge);
                  }
                
                        if (recControl.FixedCharge.Text != "") {
                            rec.Parse(recControl.FixedCharge.Text, NetworkChargesTable.FixedCharge);
                  }
                
                        if (recControl.VariableBD.Text != "") {
                            rec.Parse(recControl.VariableBD.Text, NetworkChargesTable.VariableBD);
                  }
                
                        if (recControl.VariableNBD.Text != "") {
                            rec.Parse(recControl.VariableNBD.Text, NetworkChargesTable.VariableNBD);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new NetworkChargesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IDE.Business.NetworkChargesRecord);
                this.DataSource = (NetworkChargesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(NetworkChargesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(NetworkChargesTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["NetworkChargesTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination1");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["NetworkChargesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
           
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination1_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination1_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination1.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination1.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination1_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = NetworkChargesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  NetworkChargesRecord[] DataSource {
             
            get {
                return (NetworkChargesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public IDE.UI.IPaginationModern Pagination1 {
            get {
                return (IDE.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination1");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                NetworkChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        NetworkChargesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                NetworkChargesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
                }

        NetworkChargesRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual NetworkChargesTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual NetworkChargesTableControlRow[] GetSelectedRecordControls()
        {
        
            return (NetworkChargesTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IDE.UI.Controls.Group_By_InvoiceSummaries_Table.NetworkChargesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            NetworkChargesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IDE"));
            }
            
            foreach (NetworkChargesTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual NetworkChargesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "NetworkChargesTableControlRow");
	          List<NetworkChargesTableControlRow> list = new List<NetworkChargesTableControlRow>();
	          foreach (NetworkChargesTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the SitesRecordControl control on the Group_By_InvoiceSummaries_Table page.
// Do not modify this class. Instead override any method in SitesRecordControl.
public class BaseSitesRecordControl : IDE.UI.BaseApplicationRecordControl
{
        public BaseSitesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in SitesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in SitesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseCimscoPortal%dbo.Sites record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "SitesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new SitesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            SitesRecord[] recList = SitesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = SitesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetCustomerId();
                SetCustomerIdLabel();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetCustomerId()
        {
            
                    
            // Set the CustomerId Literal on the webpage with value from the
            // DatabaseCimscoPortal%dbo.Sites database record.

            // this.DataSource is the DatabaseCimscoPortal%dbo.Sites record retrieved from the database.
            // this.CustomerId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CustomerIdSpecified) {
                								
                // If the CustomerId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = SitesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SitesTable.CustomerId);
               if(_isExpandableNonCompositeForeignKey &&SitesTable.CustomerId.IsApplyDisplayAs)
                                  
                     formattedValue = SitesTable.GetDFKA(this.DataSource.CustomerId.ToString(),SitesTable.CustomerId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(SitesTable.CustomerId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CustomerId.Text = formattedValue;
                   
            } 
            
            else {
            
                // CustomerId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CustomerId.Text = SitesTable.CustomerId.Format(SitesTable.CustomerId.DefaultValue);
            		
            }
            
            // If the CustomerId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CustomerId.Text == null ||
                this.CustomerId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CustomerId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCustomerIdLabel()
                  {
                  
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IDE"));
                }
            }
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "SitesRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
            }
          InvoiceSummariesTableControlRow parentCtrl;
      
            parentCtrl = (InvoiceSummariesTableControlRow)MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IDE"));
        }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetCustomerId();
        }
        
        
        public virtual void GetCustomerId()
        {
            
        }
                

      // To customize, override this method in SitesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            WhereClause wc;
            SitesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue invoiceSummariesRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = invoiceSummariesRecordObj;
          invoiceSummariesRecordObj = tmp;
        InvoiceSummariesTableControlRow invoiceSummariesTableControlObjRow = (MiscUtils.GetParentControlObject(this, "InvoiceSummariesTableControlRow") as InvoiceSummariesTableControlRow);
          
              if (invoiceSummariesTableControlObjRow != null && invoiceSummariesTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(SitesTable.SiteId, BaseFilter.ComparisonOperator.EqualsTo, invoiceSummariesTableControlObjRow.GetRecord().SiteId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["SitesRecordControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            SitesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersEnergyChargesTableControl = false;
            hasFiltersEnergyChargesTableControl = hasFiltersEnergyChargesTableControl && false; // suppress warning
      
            bool hasFiltersInvoiceSummariesTableControl = false;
            hasFiltersInvoiceSummariesTableControl = hasFiltersInvoiceSummariesTableControl && false; // suppress warning
      
            bool hasFiltersNetworkChargesTableControl = false;
            hasFiltersNetworkChargesTableControl = hasFiltersNetworkChargesTableControl && false; // suppress warning
      
            bool hasFiltersSitesRecordControl = false;
            hasFiltersSitesRecordControl = hasFiltersSitesRecordControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInInvoiceSummariesTableControl = HttpContext.Current.Session["SitesRecordControlWhereClause"] as string;
      
      if (selectedRecordInInvoiceSummariesTableControl != null && KeyValue.IsXmlKey(selectedRecordInInvoiceSummariesTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInInvoiceSummariesTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(SitesTable.SiteId))
      {
      wc.iAND(SitesTable.SiteId, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(SitesTable.SiteId).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          SitesTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseSitesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseSitesRecordControl_Rec"] = value;
            }
        }
        
        public SitesRecord DataSource {
            get {
                return (SitesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal CustomerId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerId");
            }
        }
            
        public System.Web.UI.WebControls.Literal CustomerIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CustomerIdLabel");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        SitesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    SitesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IDE"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual SitesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return SitesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  

#endregion


}

