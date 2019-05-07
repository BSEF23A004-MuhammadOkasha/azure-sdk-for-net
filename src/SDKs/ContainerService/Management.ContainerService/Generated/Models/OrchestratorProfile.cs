// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about orchestrator.
    /// </summary>
    public partial class OrchestratorProfile
    {
        /// <summary>
        /// Initializes a new instance of the OrchestratorProfile class.
        /// </summary>
        public OrchestratorProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrchestratorProfile class.
        /// </summary>
        /// <param name="orchestratorVersion">Orchestrator version (major,
        /// minor, patch).</param>
        /// <param name="orchestratorType">Orchestrator type.</param>
        /// <param name="isPreview">Whether Kubernetes version is currently in
        /// preview.</param>
        public OrchestratorProfile(string orchestratorVersion, string orchestratorType = default(string), bool? isPreview = default(bool?))
        {
            OrchestratorType = orchestratorType;
            OrchestratorVersion = orchestratorVersion;
            IsPreview = isPreview;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets orchestrator type.
        /// </summary>
        [JsonProperty(PropertyName = "orchestratorType")]
        public string OrchestratorType { get; set; }

        /// <summary>
        /// Gets or sets orchestrator version (major, minor, patch).
        /// </summary>
        [JsonProperty(PropertyName = "orchestratorVersion")]
        public string OrchestratorVersion { get; set; }

        /// <summary>
        /// Gets or sets whether Kubernetes version is currently in preview.
        /// </summary>
        [JsonProperty(PropertyName = "isPreview")]
        public bool? IsPreview { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OrchestratorVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrchestratorVersion");
            }
        }
    }
}
