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
    /// Collection of ssg_csrsbccourtlevel
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.ssg_csrsbccourtlevelCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMssgCsrsbccourtlevelCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsbccourtlevelCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsbccourtlevelCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsbccourtlevelCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsbccourtlevelCollection(IList<MicrosoftDynamicsCRMssgCsrsbccourtlevel> value = default(IList<MicrosoftDynamicsCRMssgCsrsbccourtlevel>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMssgCsrsbccourtlevel> Value { get; set; }

    }
}