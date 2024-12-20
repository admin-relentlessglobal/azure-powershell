// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Recovery point.
    /// </summary>
    public partial class RecoveryPoint : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPoint class.
        /// </summary>
        public RecoveryPoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPoint class.
        /// </summary>

        /// <param name="id">Resource Id
        /// </param>

        /// <param name="name">Resource Name
        /// </param>

        /// <param name="type">Resource Type
        /// </param>

        /// <param name="location">Resource Location
        /// </param>

        /// <param name="properties">The recovery point properties.
        /// </param>
        public RecoveryPoint(string id = default(string), string name = default(string), string type = default(string), string location = default(string), RecoveryPointProperties properties = default(RecoveryPointProperties))

        : base(id, name, type, location)
        {
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the recovery point properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public RecoveryPointProperties Properties {get; set; }
    }
}