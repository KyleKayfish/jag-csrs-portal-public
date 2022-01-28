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
    /// Microsoft.Dynamics.CRM.ssg_asset_realestateproperty
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgAssetRealestateproperty
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetRealestateproperty class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetRealestateproperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetRealestateproperty class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetRealestateproperty(string ssgAssetRealestatepropertyid = default(string), string ssgPropertypostalcode = default(string), string _ssgPersonidValue = default(string), string _ssgOwnerprovinceValue = default(string), string ssgNotes = default(string), string ssgDatadatelabel2 = default(string), string ssgOwneraddressline1 = default(string), int? importsequencenumber = default(int?), int? statuscode = default(int?), System.DateTimeOffset? ssgPersondateofbirth = default(System.DateTimeOffset?), string ssgAddedtoresponseindicator = default(string), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), string ssgPropertyid = default(string), string ssgAdditionalowners = default(string), string _ssgNotetemplateValue = default(string), string _ssgResponseidValue = default(string), int? ssgSuppliedby = default(int?), string ssgTitlenumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ssgDatadatelabel = default(string), string ssgOwnername = default(string), string ssgSuppliedbytext = default(string), bool? ssgCpcommentupdated = default(bool?), string ssgPropertycity = default(string), string ssgPersonname = default(string), bool? ssgAddtocp = default(bool?), string ssgPropertyaddressline3 = default(string), string _owningteamValue = default(string), bool? ssgCopycpcomment = default(bool?), string _modifiedbyValue = default(string), bool? ssgAddtoresponse = default(bool?), string ssgDatadatetext = default(string), string _ssgPropertyprovinceValue = default(string), string _ssgResponsedatasummaryValue = default(string), string ssgOwnercity = default(string), string ssgResponsecomment = default(string), bool? ssgCouldnotlocate = default(bool?), string ssgOwnerpostalcode = default(string), string _owneridValue = default(string), string ssgAddedtoconfirmedprofileby = default(string), System.DateTimeOffset? ssgDatadate = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string ssgPropertyaddressline1 = default(string), string ssgOwneraddressline2 = default(string), string ssgName = default(string), string _ssgCopycptosridValue = default(string), System.DateTimeOffset? ssgDatadate2 = default(System.DateTimeOffset?), string ssgLegaldescription = default(string), bool? ssgRespcommentupdated = default(bool?), string _ssgOwnercountryValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _ssgPropertycountryValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string ssgConfirmcomment = default(string), string versionnumber = default(string), string ssgDatadate2text = default(string), string ssgPropertyaddressline2 = default(string), string ssgOwneraddressline3 = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? ssgAddedtoconfirmedprofileon = default(System.DateTimeOffset?), string ssgFiletext = default(string), int? ssgSuppliedbyuser = default(int?), int? ssgDatastatus = default(int?), string _owninguserValue = default(string), string ssgNumberofowners = default(string), string ssgDescription = default(string), string _createdbyValue = default(string), string ssgSuppliertypecode = default(string), int? timezoneruleversionnumber = default(int?), string ssgLandtitledistrict = default(string), string _ssgConfirmedprofileValue = default(string), string _ssgSearchrequestValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgAssetRealestatepropertySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetRealestatepropertyDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetRealestatepropertyDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgAssetRealestatepropertyAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgAssetRealestatepropertyMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgAssetRealestatepropertyProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgAssetRealestatepropertyBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgAssetRealestatepropertyPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgConfirmedprofile ssgConfirmedProfile = default(MicrosoftDynamicsCRMssgConfirmedprofile), MicrosoftDynamicsCRMssgNotestemplates ssgNoteTemplate = default(MicrosoftDynamicsCRMssgNotestemplates), MicrosoftDynamicsCRMssgPerson ssgPersonId = default(MicrosoftDynamicsCRMssgPerson), MicrosoftDynamicsCRMssgSearchrequestresponse ssgResponseId = default(MicrosoftDynamicsCRMssgSearchrequestresponse), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgCountry ssgPropertyCountry = default(MicrosoftDynamicsCRMssgCountry), MicrosoftDynamicsCRMssgCountrysubdivision ssgOwnerProvince = default(MicrosoftDynamicsCRMssgCountrysubdivision), MicrosoftDynamicsCRMssgCountry ssgOwnerCountry = default(MicrosoftDynamicsCRMssgCountry), MicrosoftDynamicsCRMssgCountrysubdivision ssgPropertyProvince = default(MicrosoftDynamicsCRMssgCountrysubdivision), MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold ssgCopyCpToSrId = default(MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold), IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> ssgRealestatepropertyResulttransaction = default(IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction>), MicrosoftDynamicsCRMssgResponsedatasummary ssgResponseDataSummary = default(MicrosoftDynamicsCRMssgResponsedatasummary), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgAssetRealestatepropertySsgRequestforinformationletterTemplateEntityRealEstateProperty = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>))
        {
            SsgAssetRealestatepropertyid = ssgAssetRealestatepropertyid;
            SsgPropertypostalcode = ssgPropertypostalcode;
            this._ssgPersonidValue = _ssgPersonidValue;
            this._ssgOwnerprovinceValue = _ssgOwnerprovinceValue;
            SsgNotes = ssgNotes;
            SsgDatadatelabel2 = ssgDatadatelabel2;
            SsgOwneraddressline1 = ssgOwneraddressline1;
            Importsequencenumber = importsequencenumber;
            Statuscode = statuscode;
            SsgPersondateofbirth = ssgPersondateofbirth;
            SsgAddedtoresponseindicator = ssgAddedtoresponseindicator;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SsgPropertyid = ssgPropertyid;
            SsgAdditionalowners = ssgAdditionalowners;
            this._ssgNotetemplateValue = _ssgNotetemplateValue;
            this._ssgResponseidValue = _ssgResponseidValue;
            SsgSuppliedby = ssgSuppliedby;
            SsgTitlenumber = ssgTitlenumber;
            Modifiedon = modifiedon;
            SsgDatadatelabel = ssgDatadatelabel;
            SsgOwnername = ssgOwnername;
            SsgSuppliedbytext = ssgSuppliedbytext;
            SsgCpcommentupdated = ssgCpcommentupdated;
            SsgPropertycity = ssgPropertycity;
            SsgPersonname = ssgPersonname;
            SsgAddtocp = ssgAddtocp;
            SsgPropertyaddressline3 = ssgPropertyaddressline3;
            this._owningteamValue = _owningteamValue;
            SsgCopycpcomment = ssgCopycpcomment;
            this._modifiedbyValue = _modifiedbyValue;
            SsgAddtoresponse = ssgAddtoresponse;
            SsgDatadatetext = ssgDatadatetext;
            this._ssgPropertyprovinceValue = _ssgPropertyprovinceValue;
            this._ssgResponsedatasummaryValue = _ssgResponsedatasummaryValue;
            SsgOwnercity = ssgOwnercity;
            SsgResponsecomment = ssgResponsecomment;
            SsgCouldnotlocate = ssgCouldnotlocate;
            SsgOwnerpostalcode = ssgOwnerpostalcode;
            this._owneridValue = _owneridValue;
            SsgAddedtoconfirmedprofileby = ssgAddedtoconfirmedprofileby;
            SsgDatadate = ssgDatadate;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgPropertyaddressline1 = ssgPropertyaddressline1;
            SsgOwneraddressline2 = ssgOwneraddressline2;
            SsgName = ssgName;
            this._ssgCopycptosridValue = _ssgCopycptosridValue;
            SsgDatadate2 = ssgDatadate2;
            SsgLegaldescription = ssgLegaldescription;
            SsgRespcommentupdated = ssgRespcommentupdated;
            this._ssgOwnercountryValue = _ssgOwnercountryValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            this._ssgPropertycountryValue = _ssgPropertycountryValue;
            Createdon = createdon;
            SsgConfirmcomment = ssgConfirmcomment;
            Versionnumber = versionnumber;
            SsgDatadate2text = ssgDatadate2text;
            SsgPropertyaddressline2 = ssgPropertyaddressline2;
            SsgOwneraddressline3 = ssgOwneraddressline3;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SsgAddedtoconfirmedprofileon = ssgAddedtoconfirmedprofileon;
            SsgFiletext = ssgFiletext;
            SsgSuppliedbyuser = ssgSuppliedbyuser;
            SsgDatastatus = ssgDatastatus;
            this._owninguserValue = _owninguserValue;
            SsgNumberofowners = ssgNumberofowners;
            SsgDescription = ssgDescription;
            this._createdbyValue = _createdbyValue;
            SsgSuppliertypecode = ssgSuppliertypecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SsgLandtitledistrict = ssgLandtitledistrict;
            this._ssgConfirmedprofileValue = _ssgConfirmedprofileValue;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgAssetRealestatepropertySyncErrors = ssgAssetRealestatepropertySyncErrors;
            SsgAssetRealestatepropertyDuplicateMatchingRecord = ssgAssetRealestatepropertyDuplicateMatchingRecord;
            SsgAssetRealestatepropertyDuplicateBaseRecord = ssgAssetRealestatepropertyDuplicateBaseRecord;
            SsgAssetRealestatepropertyAsyncOperations = ssgAssetRealestatepropertyAsyncOperations;
            SsgAssetRealestatepropertyMailboxTrackingFolders = ssgAssetRealestatepropertyMailboxTrackingFolders;
            SsgAssetRealestatepropertyProcessSession = ssgAssetRealestatepropertyProcessSession;
            SsgAssetRealestatepropertyBulkDeleteFailures = ssgAssetRealestatepropertyBulkDeleteFailures;
            SsgAssetRealestatepropertyPrincipalObjectAttributeAccesses = ssgAssetRealestatepropertyPrincipalObjectAttributeAccesses;
            SsgConfirmedProfile = ssgConfirmedProfile;
            SsgNoteTemplate = ssgNoteTemplate;
            SsgPersonId = ssgPersonId;
            SsgResponseId = ssgResponseId;
            SsgSearchRequest = ssgSearchRequest;
            SsgPropertyCountry = ssgPropertyCountry;
            SsgOwnerProvince = ssgOwnerProvince;
            SsgOwnerCountry = ssgOwnerCountry;
            SsgPropertyProvince = ssgPropertyProvince;
            SsgCopyCpToSrId = ssgCopyCpToSrId;
            SsgRealestatepropertyResulttransaction = ssgRealestatepropertyResulttransaction;
            SsgResponseDataSummary = ssgResponseDataSummary;
            SsgSsgAssetRealestatepropertySsgRequestforinformationletterTemplateEntityRealEstateProperty = ssgSsgAssetRealestatepropertySsgRequestforinformationletterTemplateEntityRealEstateProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestatepropertyid")]
        public string SsgAssetRealestatepropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_propertypostalcode")]
        public string SsgPropertypostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_personid_value")]
        public string _ssgPersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_ownerprovince_value")]
        public string _ssgOwnerprovinceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notes")]
        public string SsgNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel2")]
        public string SsgDatadatelabel2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_owneraddressline1")]
        public string SsgOwneraddressline1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persondateofbirth")]
        public System.DateTimeOffset? SsgPersondateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoresponseindicator")]
        public string SsgAddedtoresponseindicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_propertyid")]
        public string SsgPropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_additionalowners")]
        public string SsgAdditionalowners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_notetemplate_value")]
        public string _ssgNotetemplateValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responseid_value")]
        public string _ssgResponseidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedby")]
        public int? SsgSuppliedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_titlenumber")]
        public string SsgTitlenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel")]
        public string SsgDatadatelabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ownername")]
        public string SsgOwnername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbytext")]
        public string SsgSuppliedbytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_cpcommentupdated")]
        public bool? SsgCpcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_propertycity")]
        public string SsgPropertycity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personname")]
        public string SsgPersonname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtocp")]
        public bool? SsgAddtocp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_propertyaddressline3")]
        public string SsgPropertyaddressline3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_copycpcomment")]
        public bool? SsgCopycpcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtoresponse")]
        public bool? SsgAddtoresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatetext")]
        public string SsgDatadatetext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_propertyprovince_value")]
        public string _ssgPropertyprovinceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responsedatasummary_value")]
        public string _ssgResponsedatasummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ownercity")]
        public string SsgOwnercity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsecomment")]
        public string SsgResponsecomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_couldnotlocate")]
        public bool? SsgCouldnotlocate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ownerpostalcode")]
        public string SsgOwnerpostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoconfirmedprofileby")]
        public string SsgAddedtoconfirmedprofileby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate")]
        public System.DateTimeOffset? SsgDatadate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_propertyaddressline1")]
        public string SsgPropertyaddressline1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_owneraddressline2")]
        public string SsgOwneraddressline2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_copycptosrid_value")]
        public string _ssgCopycptosridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2")]
        public System.DateTimeOffset? SsgDatadate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_legaldescription")]
        public string SsgLegaldescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_respcommentupdated")]
        public bool? SsgRespcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_ownercountry_value")]
        public string _ssgOwnercountryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_propertycountry_value")]
        public string _ssgPropertycountryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_confirmcomment")]
        public string SsgConfirmcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2text")]
        public string SsgDatadate2text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_propertyaddressline2")]
        public string SsgPropertyaddressline2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_owneraddressline3")]
        public string SsgOwneraddressline3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoconfirmedprofileon")]
        public System.DateTimeOffset? SsgAddedtoconfirmedprofileon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_filetext")]
        public string SsgFiletext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbyuser")]
        public int? SsgSuppliedbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datastatus")]
        public int? SsgDatastatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_numberofowners")]
        public string SsgNumberofowners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_description")]
        public string SsgDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliertypecode")]
        public string SsgSuppliertypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_landtitledistrict")]
        public string SsgLandtitledistrict { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_confirmedprofile_value")]
        public string _ssgConfirmedprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequest_value")]
        public string _ssgSearchrequestValue { get; set; }

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
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgAssetRealestatepropertySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetRealestatepropertyDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetRealestatepropertyDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgAssetRealestatepropertyAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgAssetRealestatepropertyMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgAssetRealestatepropertyProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgAssetRealestatepropertyBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_realestateproperty_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgAssetRealestatepropertyPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ConfirmedProfile")]
        public MicrosoftDynamicsCRMssgConfirmedprofile SsgConfirmedProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_NoteTemplate")]
        public MicrosoftDynamicsCRMssgNotestemplates SsgNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_PersonId")]
        public MicrosoftDynamicsCRMssgPerson SsgPersonId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseId")]
        public MicrosoftDynamicsCRMssgSearchrequestresponse SsgResponseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_PropertyCountry")]
        public MicrosoftDynamicsCRMssgCountry SsgPropertyCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_OwnerProvince")]
        public MicrosoftDynamicsCRMssgCountrysubdivision SsgOwnerProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_OwnerCountry")]
        public MicrosoftDynamicsCRMssgCountry SsgOwnerCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_PropertyProvince")]
        public MicrosoftDynamicsCRMssgCountrysubdivision SsgPropertyProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_CopyCpToSrId")]
        public MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold SsgCopyCpToSrId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_realestateproperty__resulttransaction")]
        public IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> SsgRealestatepropertyResulttransaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseDataSummary")]
        public MicrosoftDynamicsCRMssgResponsedatasummary SsgResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_asset_realestateproperty_ssg_requestforinformationletter_TemplateEntity_RealEstateProperty")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgAssetRealestatepropertySsgRequestforinformationletterTemplateEntityRealEstateProperty { get; set; }

    }
}
