// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeTrigger data model.
    /// Trigger details.
    /// Please note <see cref="DataBoxEdgeTriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="EdgeFileEventTrigger"/> and <see cref="PeriodicTimerEventTrigger"/>.
    /// </summary>
    public partial class DataBoxEdgeTriggerData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeTriggerData"/>. </summary>
        public DataBoxEdgeTriggerData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeTriggerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Trigger Kind. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeTriggerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TriggerEventType kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Trigger Kind. </summary>
        internal TriggerEventType Kind { get; set; }
    }
}
