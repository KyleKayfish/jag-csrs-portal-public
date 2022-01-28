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
    /// Microsoft.Dynamics.CRM.ssg_asset_bankinginformation
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgAssetBankinginformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetBankinginformation class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetBankinginformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetBankinginformation class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetBankinginformation(int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? ssgPersondateofbirth = default(System.DateTimeOffset?), bool? ssgRespcommentupdated = default(bool?), string ssgBranch = default(string), string ssgInstitutionname = default(string), int? statecode = default(int?), bool? ssgAddtoresponse = default(bool?), string ssgConfirmcomment = default(string), string ssgBankingassetdetails = default(string), string _owninguserValue = default(string), System.DateTimeOffset? ssgAddedtocpon = default(System.DateTimeOffset?), string ssgBranchnumber = default(string), string _ssgPersonValue = default(string), string _ssgSearchrequestValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), bool? ssgCouldnotlocate = default(bool?), string ssgResponsecomment = default(string), bool? ssgCopycpcomment = default(bool?), string ssgOldbankinginformationid = default(string), string _owningteamValue = default(string), int? ssgSuppliedbyuser = default(int?), string ssgDatadatelabel = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), bool? ssgAddtocp = default(bool?), string ssgAddedtoresponseindicator = default(string), string ssgAccountnumber = default(string), string ssgTransitnumber = default(string), string _ssgResponsedatasummaryValue = default(string), System.DateTimeOffset? ssgDatadate = default(System.DateTimeOffset?), string ssgNotes = default(string), int? utcconversiontimezonecode = default(int?), string ssgFams2searchfileid = default(string), string ssgSuppliedbytext = default(string), int? ssgDatastatus = default(int?), string _ssgNotetemplateValue = default(string), string _owneridValue = default(string), string _ssgResponseValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? ssgDatadate2 = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), bool? ssgCpcommentupdated = default(bool?), string ssgAddedtocpbyuser = default(string), string ssgPersonsname = default(string), string ssgDescription = default(string), string _ssgConfirmedprofileValue = default(string), string ssgAssetBankinginformationid = default(string), string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? ssgBankaccounttype = default(int?), string ssgDatadatelabel2 = default(string), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), string ssgSuppliertypecode = default(string), int? ssgSuppliedby = default(int?), string ssgSearchrequesttext = default(string), string _createdbyValue = default(string), string _ssgCopycptosridValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgAssetBankinginformationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetBankinginformationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetBankinginformationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgAssetBankinginformationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgAssetBankinginformationMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgAssetBankinginformationProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgAssetBankinginformationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgAssetBankinginformationPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgNotestemplates ssgNoteTemplate = default(MicrosoftDynamicsCRMssgNotestemplates), MicrosoftDynamicsCRMssgConfirmedprofile ssgConfirmedProfile = default(MicrosoftDynamicsCRMssgConfirmedprofile), MicrosoftDynamicsCRMssgSearchrequestresponse ssgResponse = default(MicrosoftDynamicsCRMssgSearchrequestresponse), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgPerson ssgPerson = default(MicrosoftDynamicsCRMssgPerson), MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold ssgCopyCPtoSRID = default(MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold), IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> ssgBankinginformationResulttransaction = default(IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction>), MicrosoftDynamicsCRMssgResponsedatasummary ssgResponseDataSummary = default(MicrosoftDynamicsCRMssgResponsedatasummary), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgAssetBankinginformationSsgRequestforinformationletterTemplateEntityBankingInformation = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>), IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim> ssgSsgAssetBankinginformationSsgAssetWorksafebcclaimBankingInformationId = default(IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SsgPersondateofbirth = ssgPersondateofbirth;
            SsgRespcommentupdated = ssgRespcommentupdated;
            SsgBranch = ssgBranch;
            SsgInstitutionname = ssgInstitutionname;
            Statecode = statecode;
            SsgAddtoresponse = ssgAddtoresponse;
            SsgConfirmcomment = ssgConfirmcomment;
            SsgBankingassetdetails = ssgBankingassetdetails;
            this._owninguserValue = _owninguserValue;
            SsgAddedtocpon = ssgAddedtocpon;
            SsgBranchnumber = ssgBranchnumber;
            this._ssgPersonValue = _ssgPersonValue;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            SsgCouldnotlocate = ssgCouldnotlocate;
            SsgResponsecomment = ssgResponsecomment;
            SsgCopycpcomment = ssgCopycpcomment;
            SsgOldbankinginformationid = ssgOldbankinginformationid;
            this._owningteamValue = _owningteamValue;
            SsgSuppliedbyuser = ssgSuppliedbyuser;
            SsgDatadatelabel = ssgDatadatelabel;
            Createdon = createdon;
            Statuscode = statuscode;
            SsgAddtocp = ssgAddtocp;
            SsgAddedtoresponseindicator = ssgAddedtoresponseindicator;
            SsgAccountnumber = ssgAccountnumber;
            SsgTransitnumber = ssgTransitnumber;
            this._ssgResponsedatasummaryValue = _ssgResponsedatasummaryValue;
            SsgDatadate = ssgDatadate;
            SsgNotes = ssgNotes;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SsgFams2searchfileid = ssgFams2searchfileid;
            SsgSuppliedbytext = ssgSuppliedbytext;
            SsgDatastatus = ssgDatastatus;
            this._ssgNotetemplateValue = _ssgNotetemplateValue;
            this._owneridValue = _owneridValue;
            this._ssgResponseValue = _ssgResponseValue;
            Importsequencenumber = importsequencenumber;
            SsgDatadate2 = ssgDatadate2;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgCpcommentupdated = ssgCpcommentupdated;
            SsgAddedtocpbyuser = ssgAddedtocpbyuser;
            SsgPersonsname = ssgPersonsname;
            SsgDescription = ssgDescription;
            this._ssgConfirmedprofileValue = _ssgConfirmedprofileValue;
            SsgAssetBankinginformationid = ssgAssetBankinginformationid;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            SsgBankaccounttype = ssgBankaccounttype;
            SsgDatadatelabel2 = ssgDatadatelabel2;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            SsgSuppliertypecode = ssgSuppliertypecode;
            SsgSuppliedby = ssgSuppliedby;
            SsgSearchrequesttext = ssgSearchrequesttext;
            this._createdbyValue = _createdbyValue;
            this._ssgCopycptosridValue = _ssgCopycptosridValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgAssetBankinginformationSyncErrors = ssgAssetBankinginformationSyncErrors;
            SsgAssetBankinginformationDuplicateMatchingRecord = ssgAssetBankinginformationDuplicateMatchingRecord;
            SsgAssetBankinginformationDuplicateBaseRecord = ssgAssetBankinginformationDuplicateBaseRecord;
            SsgAssetBankinginformationAsyncOperations = ssgAssetBankinginformationAsyncOperations;
            SsgAssetBankinginformationMailboxTrackingFolders = ssgAssetBankinginformationMailboxTrackingFolders;
            SsgAssetBankinginformationProcessSession = ssgAssetBankinginformationProcessSession;
            SsgAssetBankinginformationBulkDeleteFailures = ssgAssetBankinginformationBulkDeleteFailures;
            SsgAssetBankinginformationPrincipalObjectAttributeAccesses = ssgAssetBankinginformationPrincipalObjectAttributeAccesses;
            SsgNoteTemplate = ssgNoteTemplate;
            SsgConfirmedProfile = ssgConfirmedProfile;
            SsgResponse = ssgResponse;
            SsgSearchRequest = ssgSearchRequest;
            SsgPerson = ssgPerson;
            SsgCopyCPtoSRID = ssgCopyCPtoSRID;
            SsgBankinginformationResulttransaction = ssgBankinginformationResulttransaction;
            SsgResponseDataSummary = ssgResponseDataSummary;
            SsgSsgAssetBankinginformationSsgRequestforinformationletterTemplateEntityBankingInformation = ssgSsgAssetBankinginformationSsgRequestforinformationletterTemplateEntityBankingInformation;
            SsgSsgAssetBankinginformationSsgAssetWorksafebcclaimBankingInformationId = ssgSsgAssetBankinginformationSsgAssetWorksafebcclaimBankingInformationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persondateofbirth")]
        public System.DateTimeOffset? SsgPersondateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_respcommentupdated")]
        public bool? SsgRespcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_branch")]
        public string SsgBranch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_institutionname")]
        public string SsgInstitutionname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtoresponse")]
        public bool? SsgAddtoresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_confirmcomment")]
        public string SsgConfirmcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_bankingassetdetails")]
        public string SsgBankingassetdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtocpon")]
        public System.DateTimeOffset? SsgAddedtocpon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_branchnumber")]
        public string SsgBranchnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_person_value")]
        public string _ssgPersonValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequest_value")]
        public string _ssgSearchrequestValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_couldnotlocate")]
        public bool? SsgCouldnotlocate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsecomment")]
        public string SsgResponsecomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_copycpcomment")]
        public bool? SsgCopycpcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_oldbankinginformationid")]
        public string SsgOldbankinginformationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbyuser")]
        public int? SsgSuppliedbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel")]
        public string SsgDatadatelabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtocp")]
        public bool? SsgAddtocp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoresponseindicator")]
        public string SsgAddedtoresponseindicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_accountnumber")]
        public string SsgAccountnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_transitnumber")]
        public string SsgTransitnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responsedatasummary_value")]
        public string _ssgResponsedatasummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate")]
        public System.DateTimeOffset? SsgDatadate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notes")]
        public string SsgNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fams2searchfileid")]
        public string SsgFams2searchfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbytext")]
        public string SsgSuppliedbytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datastatus")]
        public int? SsgDatastatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_notetemplate_value")]
        public string _ssgNotetemplateValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_response_value")]
        public string _ssgResponseValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2")]
        public System.DateTimeOffset? SsgDatadate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_cpcommentupdated")]
        public bool? SsgCpcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtocpbyuser")]
        public string SsgAddedtocpbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personsname")]
        public string SsgPersonsname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_description")]
        public string SsgDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_confirmedprofile_value")]
        public string _ssgConfirmedprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformationid")]
        public string SsgAssetBankinginformationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_bankaccounttype")]
        public int? SsgBankaccounttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel2")]
        public string SsgDatadatelabel2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliertypecode")]
        public string SsgSuppliertypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedby")]
        public int? SsgSuppliedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequesttext")]
        public string SsgSearchrequesttext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_copycptosrid_value")]
        public string _ssgCopycptosridValue { get; set; }

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
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgAssetBankinginformationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetBankinginformationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetBankinginformationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgAssetBankinginformationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgAssetBankinginformationMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgAssetBankinginformationProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgAssetBankinginformationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_bankinginformation_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgAssetBankinginformationPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_NoteTemplate")]
        public MicrosoftDynamicsCRMssgNotestemplates SsgNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ConfirmedProfile")]
        public MicrosoftDynamicsCRMssgConfirmedprofile SsgConfirmedProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_Response")]
        public MicrosoftDynamicsCRMssgSearchrequestresponse SsgResponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_Person")]
        public MicrosoftDynamicsCRMssgPerson SsgPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_CopyCPtoSRID")]
        public MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold SsgCopyCPtoSRID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_bankinginformation__resulttransaction")]
        public IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> SsgBankinginformationResulttransaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseDataSummary")]
        public MicrosoftDynamicsCRMssgResponsedatasummary SsgResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_asset_bankinginformation_ssg_requestforinformationletter_TemplateEntity_BankingInformation")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgAssetBankinginformationSsgRequestforinformationletterTemplateEntityBankingInformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_asset_bankinginformation_ssg_asset_worksafebcclaim_BankingInformationId")]
        public IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim> SsgSsgAssetBankinginformationSsgAssetWorksafebcclaimBankingInformationId { get; set; }

    }
}
