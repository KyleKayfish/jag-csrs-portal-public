// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.ssg_searchapirequestdataprovider
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgSearchapirequestdataprovider
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgSearchapirequestdataprovider class.
        /// </summary>
        public MicrosoftDynamicsCRMssgSearchapirequestdataprovider()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgSearchapirequestdataprovider class.
        /// </summary>
        public MicrosoftDynamicsCRMssgSearchapirequestdataprovider(int? ssgNumberoffailures = default(int?), string _modifiedonbehalfbyValue = default(string), string _owningteamValue = default(string), int? ssgNumberofdaystoretry = default(int?), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), bool? ssgAllretriesflag = default(bool?), string _ssgSearchapirequestidValue = default(string), string _owninguserValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _ssgDataprovideridValue = default(string), int? importsequencenumber = default(int?), string _owneridValue = default(string), string ssgName = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), int? statecode = default(int?), string ssgAdaptorname = default(string), int? timezoneruleversionnumber = default(int?), string versionnumber = default(string), int? utcconversiontimezonecode = default(int?), string _createdbyValue = default(string), int? ssgSuppliedbyvalue = default(int?), string ssgSearchapirequestdataproviderid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgSearchapirequestdataproviderSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgSearchapirequestdataproviderDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgSearchapirequestdataproviderDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgSearchapirequestdataproviderAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgSearchapirequestdataproviderMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgSearchapirequestdataproviderProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgSearchapirequestdataproviderBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgSearchapirequestdataproviderPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgSearchapirequest ssgSearchAPIRequestId = default(MicrosoftDynamicsCRMssgSearchapirequest), MicrosoftDynamicsCRMssgDataprovider ssgDataProviderId = default(MicrosoftDynamicsCRMssgDataprovider))
        {
            SsgNumberoffailures = ssgNumberoffailures;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            SsgNumberofdaystoretry = ssgNumberofdaystoretry;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            SsgAllretriesflag = ssgAllretriesflag;
            this._ssgSearchapirequestidValue = _ssgSearchapirequestidValue;
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            this._ssgDataprovideridValue = _ssgDataprovideridValue;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            SsgName = ssgName;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statecode = statecode;
            SsgAdaptorname = ssgAdaptorname;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdbyValue = _createdbyValue;
            SsgSuppliedbyvalue = ssgSuppliedbyvalue;
            SsgSearchapirequestdataproviderid = ssgSearchapirequestdataproviderid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgSearchapirequestdataproviderSyncErrors = ssgSearchapirequestdataproviderSyncErrors;
            SsgSearchapirequestdataproviderDuplicateMatchingRecord = ssgSearchapirequestdataproviderDuplicateMatchingRecord;
            SsgSearchapirequestdataproviderDuplicateBaseRecord = ssgSearchapirequestdataproviderDuplicateBaseRecord;
            SsgSearchapirequestdataproviderAsyncOperations = ssgSearchapirequestdataproviderAsyncOperations;
            SsgSearchapirequestdataproviderMailboxTrackingFolders = ssgSearchapirequestdataproviderMailboxTrackingFolders;
            SsgSearchapirequestdataproviderProcessSession = ssgSearchapirequestdataproviderProcessSession;
            SsgSearchapirequestdataproviderBulkDeleteFailures = ssgSearchapirequestdataproviderBulkDeleteFailures;
            SsgSearchapirequestdataproviderPrincipalObjectAttributeAccesses = ssgSearchapirequestdataproviderPrincipalObjectAttributeAccesses;
            SsgSearchAPIRequestId = ssgSearchAPIRequestId;
            SsgDataProviderId = ssgDataProviderId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_numberoffailures")]
        public int? SsgNumberoffailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_numberofdaystoretry")]
        public int? SsgNumberofdaystoretry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_allretriesflag")]
        public bool? SsgAllretriesflag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchapirequestid_value")]
        public string _ssgSearchapirequestidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_dataproviderid_value")]
        public string _ssgDataprovideridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_adaptorname")]
        public string SsgAdaptorname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbyvalue")]
        public int? SsgSuppliedbyvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataproviderid")]
        public string SsgSearchapirequestdataproviderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgSearchapirequestdataproviderSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgSearchapirequestdataproviderDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgSearchapirequestdataproviderDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgSearchapirequestdataproviderAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgSearchapirequestdataproviderMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgSearchapirequestdataproviderProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgSearchapirequestdataproviderBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchapirequestdataprovider_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgSearchapirequestdataproviderPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchAPIRequestId")]
        public MicrosoftDynamicsCRMssgSearchapirequest SsgSearchAPIRequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_DataProviderId")]
        public MicrosoftDynamicsCRMssgDataprovider SsgDataProviderId { get; set; }

    }
}
