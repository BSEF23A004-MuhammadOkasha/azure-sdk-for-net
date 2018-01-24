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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a monitoring event.
    /// </summary>
    public partial class EventProperties
    {
        /// <summary>
        /// Initializes a new instance of the EventProperties class.
        /// </summary>
        public EventProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventProperties class.
        /// </summary>
        /// <param name="eventCode">The Id of the monitoring event.</param>
        /// <param name="description">The event name.</param>
        /// <param name="eventType">The type of the event. for example: VM
        /// Health, Server Health, Job Failure etc.</param>
        /// <param name="affectedObjectFriendlyName">The friendly name of the
        /// source of the event on which it is raised (for example, VM, VMM
        /// etc).</param>
        /// <param name="severity">The severity of the event.</param>
        /// <param name="timeOfOccurrence">The time of occurence of the
        /// event.</param>
        /// <param name="fabricId">The ARM ID of the fabric.</param>
        /// <param name="providerSpecificDetails">The provider specific
        /// settings.</param>
        /// <param name="eventSpecificDetails">The event specific
        /// settings.</param>
        /// <param name="healthErrors">The list of errors / warnings capturing
        /// details associated with the issue(s).</param>
        public EventProperties(string eventCode = default(string), string description = default(string), string eventType = default(string), string affectedObjectFriendlyName = default(string), string severity = default(string), System.DateTime? timeOfOccurrence = default(System.DateTime?), string fabricId = default(string), EventProviderSpecificDetails providerSpecificDetails = default(EventProviderSpecificDetails), EventSpecificDetails eventSpecificDetails = default(EventSpecificDetails), IList<HealthError> healthErrors = default(IList<HealthError>))
        {
            EventCode = eventCode;
            Description = description;
            EventType = eventType;
            AffectedObjectFriendlyName = affectedObjectFriendlyName;
            Severity = severity;
            TimeOfOccurrence = timeOfOccurrence;
            FabricId = fabricId;
            ProviderSpecificDetails = providerSpecificDetails;
            EventSpecificDetails = eventSpecificDetails;
            HealthErrors = healthErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Id of the monitoring event.
        /// </summary>
        [JsonProperty(PropertyName = "eventCode")]
        public string EventCode { get; set; }

        /// <summary>
        /// Gets or sets the event name.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the event. for example: VM Health, Server
        /// Health, Job Failure etc.
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the source of the event on which
        /// it is raised (for example, VM, VMM etc).
        /// </summary>
        [JsonProperty(PropertyName = "affectedObjectFriendlyName")]
        public string AffectedObjectFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the severity of the event.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the time of occurence of the event.
        /// </summary>
        [JsonProperty(PropertyName = "timeOfOccurrence")]
        public System.DateTime? TimeOfOccurrence { get; set; }

        /// <summary>
        /// Gets or sets the ARM ID of the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "fabricId")]
        public string FabricId { get; set; }

        /// <summary>
        /// Gets or sets the provider specific settings.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public EventProviderSpecificDetails ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Gets or sets the event specific settings.
        /// </summary>
        [JsonProperty(PropertyName = "eventSpecificDetails")]
        public EventSpecificDetails EventSpecificDetails { get; set; }

        /// <summary>
        /// Gets or sets the list of errors / warnings capturing details
        /// associated with the issue(s).
        /// </summary>
        [JsonProperty(PropertyName = "healthErrors")]
        public IList<HealthError> HealthErrors { get; set; }

    }
}
