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
    /// Microsoft.Dynamics.CRM.ssg_famsqueuelog
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgFamsqueuelog
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgFamsqueuelog class.
        /// </summary>
        public MicrosoftDynamicsCRMssgFamsqueuelog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgFamsqueuelog class.
        /// </summary>
        public MicrosoftDynamicsCRMssgFamsqueuelog(string ssgDetails = default(string), string _owninguserValue = default(string), string versionnumber = default(string), string _owningbusinessunitValue = default(string), string _createdbyValue = default(string), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ssgFamsqueuelogid = default(string), string _owningteamValue = default(string), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _owneridValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string ssgName = default(string), int? utcconversiontimezonecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgFamsqueuelogSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgFamsqueuelogDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgFamsqueuelogDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgFamsqueuelogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgFamsqueuelogMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgFamsqueuelogProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgFamsqueuelogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgFamsqueuelogPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            SsgDetails = ssgDetails;
            this._owninguserValue = _owninguserValue;
            Versionnumber = versionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Overriddencreatedon = overriddencreatedon;
            SsgFamsqueuelogid = ssgFamsqueuelogid;
            this._owningteamValue = _owningteamValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            Statuscode = statuscode;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            SsgName = ssgName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgFamsqueuelogSyncErrors = ssgFamsqueuelogSyncErrors;
            SsgFamsqueuelogDuplicateMatchingRecord = ssgFamsqueuelogDuplicateMatchingRecord;
            SsgFamsqueuelogDuplicateBaseRecord = ssgFamsqueuelogDuplicateBaseRecord;
            SsgFamsqueuelogAsyncOperations = ssgFamsqueuelogAsyncOperations;
            SsgFamsqueuelogMailboxTrackingFolders = ssgFamsqueuelogMailboxTrackingFolders;
            SsgFamsqueuelogProcessSession = ssgFamsqueuelogProcessSession;
            SsgFamsqueuelogBulkDeleteFailures = ssgFamsqueuelogBulkDeleteFailures;
            SsgFamsqueuelogPrincipalObjectAttributeAccesses = ssgFamsqueuelogPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_details")]
        public string SsgDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelogid")]
        public string SsgFamsqueuelogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "ssg_famsqueuelog_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgFamsqueuelogSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelog_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgFamsqueuelogDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelog_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgFamsqueuelogDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgFamsqueuelogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelog_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgFamsqueuelogMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelog_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgFamsqueuelogProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgFamsqueuelogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_famsqueuelog_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgFamsqueuelogPrincipalObjectAttributeAccesses { get; set; }

    }
}