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
    /// Microsoft.Dynamics.CRM.knowledgebaserecord
    /// </summary>
    public partial class MicrosoftDynamicsCRMknowledgebaserecord
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgebaserecord class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgebaserecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgebaserecord class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgebaserecord(string _createdbyValue = default(string), string title = default(string), decimal? exchangerate = default(decimal?), int? timezoneruleversionnumber = default(int?), string publicurl = default(string), string _modifiedbyValue = default(string), string _organizationidValue = default(string), string privateurl = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string knowledgebaserecordid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), string uniqueid = default(string), string _transactioncurrencyidValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMactivitypointer> knowledgeBaseRecordActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> knowledgeBaseRecordAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> knowledgeBaseRecordEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> knowledgeBaseRecordFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> knowledgeBaseRecordLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> knowledgeBaseRecordPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> knowledgeBaseRecordTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> knowledgeBaseRecordRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> knowledgeBaseRecordSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> knowledgeBaseRecordConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> knowledgeBaseRecordConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> knowledgeBaseRecordDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> knowledgeBaseRecordDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> knowledgeBaseRecordAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> knowledgeBaseRecordAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> knowledgeBaseRecordProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> knowledgeBaseRecordBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> knowledgeBaseRecordPrincipalObjectAttributeAccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMbulkoperation> knowledgebaserecordBulkOperations = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaignresponse> knowledgebaserecordCampaignResponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMincidentresolution> knowledgebaserecordIncidentResolutions = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> knowledgeBaseRecordServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMincident> knowledgeBaseRecordIncident = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMopportunityclose> knowledgebaserecordOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> knowledgebaserecordOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> knowledgebaserecordQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMafkWorkflowtask> knowledgebaserecordAfkWorkflowtasks = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>), IList<MicrosoftDynamicsCRMsyncerror> knowledgeBaseRecordSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._createdbyValue = _createdbyValue;
            Title = title;
            Exchangerate = exchangerate;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Publicurl = publicurl;
            this._modifiedbyValue = _modifiedbyValue;
            this._organizationidValue = _organizationidValue;
            Privateurl = privateurl;
            Modifiedon = modifiedon;
            Knowledgebaserecordid = knowledgebaserecordid;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Uniqueid = uniqueid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            KnowledgeBaseRecordActivityPointers = knowledgeBaseRecordActivityPointers;
            KnowledgeBaseRecordAppointments = knowledgeBaseRecordAppointments;
            KnowledgeBaseRecordEmails = knowledgeBaseRecordEmails;
            KnowledgeBaseRecordFaxes = knowledgeBaseRecordFaxes;
            KnowledgeBaseRecordLetters = knowledgeBaseRecordLetters;
            KnowledgeBaseRecordPhoneCalls = knowledgeBaseRecordPhoneCalls;
            KnowledgeBaseRecordTasks = knowledgeBaseRecordTasks;
            KnowledgeBaseRecordRecurringAppointmentMasters = knowledgeBaseRecordRecurringAppointmentMasters;
            KnowledgeBaseRecordSocialActivities = knowledgeBaseRecordSocialActivities;
            KnowledgeBaseRecordConnections1 = knowledgeBaseRecordConnections1;
            KnowledgeBaseRecordConnections2 = knowledgeBaseRecordConnections2;
            KnowledgeBaseRecordDuplicateMatchingRecord = knowledgeBaseRecordDuplicateMatchingRecord;
            KnowledgeBaseRecordDuplicateBaseRecord = knowledgeBaseRecordDuplicateBaseRecord;
            KnowledgeBaseRecordAnnotations = knowledgeBaseRecordAnnotations;
            KnowledgeBaseRecordAsyncOperations = knowledgeBaseRecordAsyncOperations;
            KnowledgeBaseRecordProcessSession = knowledgeBaseRecordProcessSession;
            KnowledgeBaseRecordBulkDeleteFailures = knowledgeBaseRecordBulkDeleteFailures;
            KnowledgeBaseRecordPrincipalObjectAttributeAccess = knowledgeBaseRecordPrincipalObjectAttributeAccess;
            KnowledgebaserecordBulkOperations = knowledgebaserecordBulkOperations;
            KnowledgebaserecordCampaignResponses = knowledgebaserecordCampaignResponses;
            KnowledgebaserecordIncidentResolutions = knowledgebaserecordIncidentResolutions;
            KnowledgeBaseRecordServiceAppointments = knowledgeBaseRecordServiceAppointments;
            KnowledgeBaseRecordIncident = knowledgeBaseRecordIncident;
            KnowledgebaserecordOpportunityCloses = knowledgebaserecordOpportunityCloses;
            KnowledgebaserecordOrderCloses = knowledgebaserecordOrderCloses;
            KnowledgebaserecordQuoteCloses = knowledgebaserecordQuoteCloses;
            KnowledgebaserecordAfkWorkflowtasks = knowledgebaserecordAfkWorkflowtasks;
            KnowledgeBaseRecordSyncErrors = knowledgeBaseRecordSyncErrors;
            Transactioncurrencyid = transactioncurrencyid;
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
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publicurl")]
        public string Publicurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "privateurl")]
        public string Privateurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecordid")]
        public string Knowledgebaserecordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniqueid")]
        public string Uniqueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> KnowledgeBaseRecordActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> KnowledgeBaseRecordAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Emails")]
        public IList<MicrosoftDynamicsCRMemail> KnowledgeBaseRecordEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> KnowledgeBaseRecordFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Letters")]
        public IList<MicrosoftDynamicsCRMletter> KnowledgeBaseRecordLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> KnowledgeBaseRecordPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> KnowledgeBaseRecordTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> KnowledgeBaseRecordRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> KnowledgeBaseRecordSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> KnowledgeBaseRecordConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> KnowledgeBaseRecordConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KnowledgeBaseRecordDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KnowledgeBaseRecordDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> KnowledgeBaseRecordAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> KnowledgeBaseRecordAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> KnowledgeBaseRecordProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> KnowledgeBaseRecordBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_PrincipalObjectAttributeAccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> KnowledgeBaseRecordPrincipalObjectAttributeAccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_BulkOperations")]
        public IList<MicrosoftDynamicsCRMbulkoperation> KnowledgebaserecordBulkOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_CampaignResponses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> KnowledgebaserecordCampaignResponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_IncidentResolutions")]
        public IList<MicrosoftDynamicsCRMincidentresolution> KnowledgebaserecordIncidentResolutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> KnowledgeBaseRecordServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Incident")]
        public IList<MicrosoftDynamicsCRMincident> KnowledgeBaseRecordIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_OpportunityCloses")]
        public IList<MicrosoftDynamicsCRMopportunityclose> KnowledgebaserecordOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_OrderCloses")]
        public IList<MicrosoftDynamicsCRMorderclose> KnowledgebaserecordOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_QuoteCloses")]
        public IList<MicrosoftDynamicsCRMquoteclose> KnowledgebaserecordQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_afk_workflowtasks")]
        public IList<MicrosoftDynamicsCRMafkWorkflowtask> KnowledgebaserecordAfkWorkflowtasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> KnowledgeBaseRecordSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
