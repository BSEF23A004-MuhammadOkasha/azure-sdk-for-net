// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create hybrid runbook worker group
    /// operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HybridRunbookWorkerGroupCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HybridRunbookWorkerGroupCreateOrUpdateParameters class.
        /// </summary>
        public HybridRunbookWorkerGroupCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HybridRunbookWorkerGroupCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="credential">Sets the credential of a worker
        /// group.</param>
        /// <param name="name">Gets or sets the name of the resource.</param>
        public HybridRunbookWorkerGroupCreateOrUpdateParameters(RunAsCredentialAssociationProperty credential = default(RunAsCredentialAssociationProperty), string name = default(string))
        {
            Credential = credential;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sets the credential of a worker group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.credential")]
        public RunAsCredentialAssociationProperty Credential { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
