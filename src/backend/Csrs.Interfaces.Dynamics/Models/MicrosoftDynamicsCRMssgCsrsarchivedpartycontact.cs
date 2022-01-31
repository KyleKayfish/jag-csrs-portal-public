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
    /// Microsoft.Dynamics.CRM.ssg_csrsarchivedpartycontact
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgCsrsarchivedpartycontact
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsarchivedpartycontact class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsarchivedpartycontact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsarchivedpartycontact class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsarchivedpartycontact(string _createdbyValue = default(string), string ssgCity = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), string ssgStreet2 = default(string), int? statecode = default(int?), string _owneridValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), int? ssgProvinceterritory = default(int?), int? statuscode = default(int?), string ssgCsrsarchivedpartycontactid = default(string), string ssgAreapostalcode = default(string), string _owningbusinessunitValue = default(string), string ssgWorkphone = default(string), string ssgCellphone = default(string), string ssgStreet1 = default(string), string _ssgPartynameValue = default(string), int? timezoneruleversionnumber = default(int?), string ssgHomephone = default(string), string ssgArchivedpartycontacttitle = default(string), string _modifiedonbehalfbyValue = default(string), string ssgEmail = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgCsrsarchivedpartycontactSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> ssgCsrsarchivedpartycontactAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgCsrsarchivedpartycontactMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgCsrsarchivedpartycontactProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgCsrsarchivedpartycontactBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgCsrsarchivedpartycontactPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgCsrsparty ssgPartyName = default(MicrosoftDynamicsCRMssgCsrsparty), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> ssgCsrsarchivedpartycontactSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>))
        {
            this._createdbyValue = _createdbyValue;
            SsgCity = ssgCity;
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            this._owninguserValue = _owninguserValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            Versionnumber = versionnumber;
            SsgStreet2 = ssgStreet2;
            Statecode = statecode;
            this._owneridValue = _owneridValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            this._owningteamValue = _owningteamValue;
            SsgProvinceterritory = ssgProvinceterritory;
            Statuscode = statuscode;
            SsgCsrsarchivedpartycontactid = ssgCsrsarchivedpartycontactid;
            SsgAreapostalcode = ssgAreapostalcode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            SsgWorkphone = ssgWorkphone;
            SsgCellphone = ssgCellphone;
            SsgStreet1 = ssgStreet1;
            this._ssgPartynameValue = _ssgPartynameValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SsgHomephone = ssgHomephone;
            SsgArchivedpartycontacttitle = ssgArchivedpartycontacttitle;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgEmail = ssgEmail;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgCsrsarchivedpartycontactSyncErrors = ssgCsrsarchivedpartycontactSyncErrors;
            SsgCsrsarchivedpartycontactAsyncOperations = ssgCsrsarchivedpartycontactAsyncOperations;
            SsgCsrsarchivedpartycontactMailboxTrackingFolders = ssgCsrsarchivedpartycontactMailboxTrackingFolders;
            SsgCsrsarchivedpartycontactProcessSession = ssgCsrsarchivedpartycontactProcessSession;
            SsgCsrsarchivedpartycontactBulkDeleteFailures = ssgCsrsarchivedpartycontactBulkDeleteFailures;
            SsgCsrsarchivedpartycontactPrincipalObjectAttributeAccesses = ssgCsrsarchivedpartycontactPrincipalObjectAttributeAccesses;
            SsgPartyName = ssgPartyName;
            SsgCsrsarchivedpartycontactSharePointDocumentLocations = ssgCsrsarchivedpartycontactSharePointDocumentLocations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_city")]
        public string SsgCity { get; set; }

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
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_street2")]
        public string SsgStreet2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_provinceterritory")]
        public int? SsgProvinceterritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontactid")]
        public string SsgCsrsarchivedpartycontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_areapostalcode")]
        public string SsgAreapostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_workphone")]
        public string SsgWorkphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_cellphone")]
        public string SsgCellphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_street1")]
        public string SsgStreet1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_partyname_value")]
        public string _ssgPartynameValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_homephone")]
        public string SsgHomephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_archivedpartycontacttitle")]
        public string SsgArchivedpartycontacttitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_email")]
        public string SsgEmail { get; set; }

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
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontact_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgCsrsarchivedpartycontactSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontact_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgCsrsarchivedpartycontactAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontact_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgCsrsarchivedpartycontactMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontact_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgCsrsarchivedpartycontactProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontact_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgCsrsarchivedpartycontactBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontact_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgCsrsarchivedpartycontactPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_PartyName")]
        public MicrosoftDynamicsCRMssgCsrsparty SsgPartyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsarchivedpartycontact_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> SsgCsrsarchivedpartycontactSharePointDocumentLocations { get; set; }

    }
}