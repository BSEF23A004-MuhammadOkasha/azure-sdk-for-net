// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The application resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationResource class.
        /// </summary>
        public ApplicationResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationResource class.
        /// </summary>
        /// <param name="id">Azure resource identifier.</param>
        /// <param name="name">Azure resource name.</param>
        /// <param name="type">Azure resource type.</param>
        /// <param name="location">Azure resource location.</param>
        /// <param name="typeVersion">The version of the application type as
        /// defined in the application manifest.</param>
        /// <param name="parameters">List of application parameters with
        /// overridden values from their default values specified in the
        /// application manifest.</param>
        /// <param name="upgradePolicy">Describes the policy for a monitored
        /// application upgrade.</param>
        /// <param name="minimumNodes">The minimum number of nodes where
        /// Service Fabric will reserve capacity for this application. Note
        /// that this does not mean that the services of this application will
        /// be placed on all of those nodes. If this property is set to zero,
        /// no capacity will be reserved. The value of this property cannot be
        /// more than the value of the MaximumNodes property.</param>
        /// <param name="maximumNodes">The maximum number of nodes where
        /// Service Fabric will reserve capacity for this application. Note
        /// that this does not mean that the services of this application will
        /// be placed on all of those nodes. By default, the value of this
        /// property is zero and it means that the services can be placed on
        /// any node.</param>
        /// <param name="removeApplicationCapacity">Remove the current
        /// application capacity settings.</param>
        /// <param name="metrics">List of application capacity metric
        /// description.</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response</param>
        /// <param name="typeName">The application type name as defined in the
        /// application manifest.</param>
        public ApplicationResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string typeVersion = default(string), IList<ApplicationParameter> parameters = default(IList<ApplicationParameter>), ApplicationUpgradePolicy upgradePolicy = default(ApplicationUpgradePolicy), long? minimumNodes = default(long?), long? maximumNodes = default(long?), bool? removeApplicationCapacity = default(bool?), IList<ApplicationMetricDescription> metrics = default(IList<ApplicationMetricDescription>), string provisioningState = default(string), string typeName = default(string))
            : base(id, name, type, location)
        {
            TypeVersion = typeVersion;
            Parameters = parameters;
            UpgradePolicy = upgradePolicy;
            MinimumNodes = minimumNodes;
            MaximumNodes = maximumNodes;
            RemoveApplicationCapacity = removeApplicationCapacity;
            Metrics = metrics;
            ProvisioningState = provisioningState;
            TypeName = typeName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the application type as defined in the
        /// application manifest.
        /// </summary>
        [JsonProperty(PropertyName = "properties.typeVersion")]
        public string TypeVersion { get; set; }

        /// <summary>
        /// Gets or sets list of application parameters with overridden values
        /// from their default values specified in the application manifest.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IList<ApplicationParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets describes the policy for a monitored application
        /// upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradePolicy")]
        public ApplicationUpgradePolicy UpgradePolicy { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of nodes where Service Fabric will
        /// reserve capacity for this application. Note that this does not mean
        /// that the services of this application will be placed on all of
        /// those nodes. If this property is set to zero, no capacity will be
        /// reserved. The value of this property cannot be more than the value
        /// of the MaximumNodes property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumNodes")]
        public long? MinimumNodes { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of nodes where Service Fabric will
        /// reserve capacity for this application. Note that this does not mean
        /// that the services of this application will be placed on all of
        /// those nodes. By default, the value of this property is zero and it
        /// means that the services can be placed on any node.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumNodes")]
        public long? MaximumNodes { get; set; }

        /// <summary>
        /// Gets or sets remove the current application capacity settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.removeApplicationCapacity")]
        public bool? RemoveApplicationCapacity { get; set; }

        /// <summary>
        /// Gets or sets list of application capacity metric description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metrics")]
        public IList<ApplicationMetricDescription> Metrics { get; set; }

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the application type name as defined in the
        /// application manifest.
        /// </summary>
        [JsonProperty(PropertyName = "properties.typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Parameters != null)
            {
                foreach (var element in Parameters)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (UpgradePolicy != null)
            {
                UpgradePolicy.Validate();
            }
            if (MinimumNodes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinimumNodes", 0);
            }
            if (MaximumNodes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaximumNodes", 0);
            }
        }
    }
}
