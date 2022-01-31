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
    /// Microsoft.Dynamics.CRM.ssg_csrsbccourtlevel
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgCsrsbccourtlevel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsbccourtlevel class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsbccourtlevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsbccourtlevel class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsbccourtlevel(int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _modifiedonbehalfbyValue = default(string), string ssgCsrsbccourtlevelid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), string _owningbusinessunitValue = default(string), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), int? statuscode = default(int?), string _owningteamValue = default(string), string _owneridValue = default(string), int? timezoneruleversionnumber = default(int?), string ssgCourtlevellabel = default(string), int? statecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgCsrsbccourtlevelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgCsrsbccourtlevelDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgCsrsbccourtlevelDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgCsrsbccourtlevelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgCsrsbccourtlevelMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgCsrsbccourtlevelProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgCsrsbccourtlevelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgCsrsbccourtlevelPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMssgIjssbccourtlocation> ssgCsrsbccourtlevelSsgIjssbccourtlocationCSRSCourtLevelFilter = default(IList<MicrosoftDynamicsCRMssgIjssbccourtlocation>), IList<MicrosoftDynamicsCRMssgCsrsfile> ssgCsrsbccourtlevelSsgCsrsfileBCCourtLevel = default(IList<MicrosoftDynamicsCRMssgCsrsfile>))
        {
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            this._owninguserValue = _owninguserValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgCsrsbccourtlevelid = ssgCsrsbccourtlevelid;
            Createdon = createdon;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SsgCourtlevellabel = ssgCourtlevellabel;
            Statecode = statecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgCsrsbccourtlevelSyncErrors = ssgCsrsbccourtlevelSyncErrors;
            SsgCsrsbccourtlevelDuplicateMatchingRecord = ssgCsrsbccourtlevelDuplicateMatchingRecord;
            SsgCsrsbccourtlevelDuplicateBaseRecord = ssgCsrsbccourtlevelDuplicateBaseRecord;
            SsgCsrsbccourtlevelAsyncOperations = ssgCsrsbccourtlevelAsyncOperations;
            SsgCsrsbccourtlevelMailboxTrackingFolders = ssgCsrsbccourtlevelMailboxTrackingFolders;
            SsgCsrsbccourtlevelProcessSession = ssgCsrsbccourtlevelProcessSession;
            SsgCsrsbccourtlevelBulkDeleteFailures = ssgCsrsbccourtlevelBulkDeleteFailures;
            SsgCsrsbccourtlevelPrincipalObjectAttributeAccesses = ssgCsrsbccourtlevelPrincipalObjectAttributeAccesses;
            SsgCsrsbccourtlevelSsgIjssbccourtlocationCSRSCourtLevelFilter = ssgCsrsbccourtlevelSsgIjssbccourtlocationCSRSCourtLevelFilter;
            SsgCsrsbccourtlevelSsgCsrsfileBCCourtLevel = ssgCsrsbccourtlevelSsgCsrsfileBCCourtLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevelid")]
        public string SsgCsrsbccourtlevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_courtlevellabel")]
        public string SsgCourtlevellabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

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
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgCsrsbccourtlevelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgCsrsbccourtlevelDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgCsrsbccourtlevelDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgCsrsbccourtlevelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgCsrsbccourtlevelMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgCsrsbccourtlevelProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgCsrsbccourtlevelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgCsrsbccourtlevelPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_ssg_ijssbccourtlocation_CSRSCourtLevelFilter")]
        public IList<MicrosoftDynamicsCRMssgIjssbccourtlocation> SsgCsrsbccourtlevelSsgIjssbccourtlocationCSRSCourtLevelFilter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsbccourtlevel_ssg_csrsfile_BCCourtLevel")]
        public IList<MicrosoftDynamicsCRMssgCsrsfile> SsgCsrsbccourtlevelSsgCsrsfileBCCourtLevel { get; set; }

    }
}