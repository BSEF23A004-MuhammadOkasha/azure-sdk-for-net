// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IoT alert
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IotAlertModel
    {
        /// <summary>
        /// Initializes a new instance of the IotAlertModel class.
        /// </summary>
        public IotAlertModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotAlertModel class.
        /// </summary>
        /// <param name="systemAlertId">Holds the product canonical identifier
        /// of the alert within the scope of a product</param>
        /// <param name="compromisedEntity">Display name of the main entity
        /// being reported on</param>
        /// <param name="alertType">The type name of the alert</param>
        /// <param name="startTimeUtc">The impact start time of the alert (the
        /// time of the first event or activity included in the alert)</param>
        /// <param name="endTimeUtc">The impact end time of the alert (the time
        /// of the last event or activity included in the alert)</param>
        /// <param name="entities">A list of entities related to the
        /// alert</param>
        /// <param name="extendedProperties">A bag of fields which extends the
        /// alert information</param>
        public IotAlertModel(string systemAlertId = default(string), string compromisedEntity = default(string), string alertType = default(string), string startTimeUtc = default(string), string endTimeUtc = default(string), IList<object> entities = default(IList<object>), object extendedProperties = default(object))
        {
            SystemAlertId = systemAlertId;
            CompromisedEntity = compromisedEntity;
            AlertType = alertType;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            Entities = entities;
            ExtendedProperties = extendedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets holds the product canonical identifier of the alert within the
        /// scope of a product
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemAlertId")]
        public string SystemAlertId { get; private set; }

        /// <summary>
        /// Gets display name of the main entity being reported on
        /// </summary>
        [JsonProperty(PropertyName = "properties.compromisedEntity")]
        public string CompromisedEntity { get; private set; }

        /// <summary>
        /// Gets the type name of the alert
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertType")]
        public string AlertType { get; private set; }

        /// <summary>
        /// Gets the impact start time of the alert (the time of the first
        /// event or activity included in the alert)
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTimeUtc")]
        public string StartTimeUtc { get; private set; }

        /// <summary>
        /// Gets the impact end time of the alert (the time of the last event
        /// or activity included in the alert)
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTimeUtc")]
        public string EndTimeUtc { get; private set; }

        /// <summary>
        /// Gets or sets a list of entities related to the alert
        /// </summary>
        [JsonProperty(PropertyName = "properties.entities")]
        public IList<object> Entities { get; set; }

        /// <summary>
        /// Gets or sets a bag of fields which extends the alert information
        /// </summary>
        [JsonProperty(PropertyName = "properties.extendedProperties")]
        public object ExtendedProperties { get; set; }

    }
}
