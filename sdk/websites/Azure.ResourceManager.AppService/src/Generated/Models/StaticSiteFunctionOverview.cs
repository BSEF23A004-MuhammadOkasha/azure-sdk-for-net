// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Static Site Function Overview ARM resource.
    /// Serialized Name: StaticSiteFunctionOverviewARMResource
    /// </summary>
    public partial class StaticSiteFunctionOverview : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSiteFunctionOverview. </summary>
        public StaticSiteFunctionOverview()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteFunctionOverview. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="functionName">
        /// The name for the function
        /// Serialized Name: StaticSiteFunctionOverviewARMResource.properties.functionName
        /// </param>
        /// <param name="triggerType">
        /// The trigger type of the function
        /// Serialized Name: StaticSiteFunctionOverviewARMResource.properties.triggerType
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal StaticSiteFunctionOverview(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string functionName, TriggerType? triggerType, string kind) : base(id, name, resourceType, systemData)
        {
            FunctionName = functionName;
            TriggerType = triggerType;
            Kind = kind;
        }

        /// <summary>
        /// The name for the function
        /// Serialized Name: StaticSiteFunctionOverviewARMResource.properties.functionName
        /// </summary>
        public string FunctionName { get; }
        /// <summary>
        /// The trigger type of the function
        /// Serialized Name: StaticSiteFunctionOverviewARMResource.properties.triggerType
        /// </summary>
        public TriggerType? TriggerType { get; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
