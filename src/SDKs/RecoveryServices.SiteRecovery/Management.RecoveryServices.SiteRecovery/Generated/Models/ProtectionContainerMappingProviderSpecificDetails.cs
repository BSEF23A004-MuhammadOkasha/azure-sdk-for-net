// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container mapping provider specific details.
    /// </summary>
    public partial class ProtectionContainerMappingProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProtectionContainerMappingProviderSpecificDetails class.
        /// </summary>
        public ProtectionContainerMappingProviderSpecificDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ProtectionContainerMappingProviderSpecificDetails class.
        /// </summary>
        /// <param name="instanceType">Gets the class type. Overriden in
        /// derived classes.</param>
        public ProtectionContainerMappingProviderSpecificDetails(string instanceType = default(string))
        {
            InstanceType = instanceType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the class type. Overriden in derived classes.
        /// </summary>
        [JsonProperty(PropertyName = "instanceType")]
        public string InstanceType { get; private set; }

    }
}
