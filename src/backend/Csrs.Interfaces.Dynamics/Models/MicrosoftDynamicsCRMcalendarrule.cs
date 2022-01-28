// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.calendarrule
    /// </summary>
    public partial class MicrosoftDynamicsCRMcalendarrule
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcalendarrule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcalendarrule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcalendarrule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcalendarrule(string groupdesignator = default(string), int? rank = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? starttime = default(System.DateTimeOffset?), string _serviceidValue = default(string), string organizationid = default(string), bool? isselected = default(bool?), int? duration = default(int?), int? offset = default(int?), int? timecode = default(int?), string _innercalendaridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? extentcode = default(int?), int? subcode = default(int?), bool? isvaried = default(bool?), System.DateTimeOffset? effectiveintervalstart = default(System.DateTimeOffset?), string name = default(string), System.DateTimeOffset? endtime = default(System.DateTimeOffset?), string _createdbyValue = default(string), bool? issimple = default(bool?), string calendarruleid = default(string), int? timezonecode = default(int?), string pattern = default(string), decimal? effort = default(decimal?), string description = default(string), bool? ismodified = default(bool?), string _modifiedbyValue = default(string), string _calendaridValue = default(string), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), System.DateTimeOffset? effectiveintervalend = default(System.DateTimeOffset?), string businessunitid = default(string), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMcalendar calendarid = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcalendar innercalendarid = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Groupdesignator = groupdesignator;
            Rank = rank;
            Createdon = createdon;
            Starttime = starttime;
            this._serviceidValue = _serviceidValue;
            Organizationid = organizationid;
            Isselected = isselected;
            Duration = duration;
            Offset = offset;
            Timecode = timecode;
            this._innercalendaridValue = _innercalendaridValue;
            Modifiedon = modifiedon;
            Extentcode = extentcode;
            Subcode = subcode;
            Isvaried = isvaried;
            Effectiveintervalstart = effectiveintervalstart;
            Name = name;
            Endtime = endtime;
            this._createdbyValue = _createdbyValue;
            Issimple = issimple;
            Calendarruleid = calendarruleid;
            Timezonecode = timezonecode;
            Pattern = pattern;
            Effort = effort;
            Description = description;
            Ismodified = ismodified;
            this._modifiedbyValue = _modifiedbyValue;
            this._calendaridValue = _calendaridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Effectiveintervalend = effectiveintervalend;
            Businessunitid = businessunitid;
            Serviceid = serviceid;
            Calendarid = calendarid;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Innercalendarid = innercalendarid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groupdesignator")]
        public string Groupdesignator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public System.DateTimeOffset? Starttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_serviceid_value")]
        public string _serviceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isselected")]
        public bool? Isselected { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timecode")]
        public int? Timecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_innercalendarid_value")]
        public string _innercalendaridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extentcode")]
        public int? Extentcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcode")]
        public int? Subcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isvaried")]
        public bool? Isvaried { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveintervalstart")]
        public System.DateTimeOffset? Effectiveintervalstart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endtime")]
        public System.DateTimeOffset? Endtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issimple")]
        public bool? Issimple { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarruleid")]
        public string Calendarruleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonecode")]
        public int? Timezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effort")]
        public decimal? Effort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismodified")]
        public bool? Ismodified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_calendarid_value")]
        public string _calendaridValue { get; set; }

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
        [JsonProperty(PropertyName = "effectiveintervalend")]
        public System.DateTimeOffset? Effectiveintervalend { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public string Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid")]
        public MicrosoftDynamicsCRMservice Serviceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public MicrosoftDynamicsCRMcalendar Calendarid { get; set; }

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
        [JsonProperty(PropertyName = "innercalendarid")]
        public MicrosoftDynamicsCRMcalendar Innercalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
