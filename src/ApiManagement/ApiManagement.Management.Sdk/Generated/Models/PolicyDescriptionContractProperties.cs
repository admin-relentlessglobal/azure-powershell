// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Policy description properties.
    /// </summary>
    public partial class PolicyDescriptionContractProperties
    {
        /// <summary>
        /// Initializes a new instance of the PolicyDescriptionContractProperties class.
        /// </summary>
        public PolicyDescriptionContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyDescriptionContractProperties class.
        /// </summary>

        /// <param name="description">Policy description.
        /// </param>

        /// <param name="scope">Binary OR value of the Snippet scope.
        /// </param>
        public PolicyDescriptionContractProperties(string description = default(string), long? scope = default(long?))

        {
            this.Description = description;
            this.Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets policy description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; private set; }

        /// <summary>
        /// Gets binary OR value of the Snippet scope.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scope")]
        public long? Scope {get; private set; }
    }
}