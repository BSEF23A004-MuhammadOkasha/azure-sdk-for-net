// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactoryTrigger data model.
    /// Trigger resource type.
    /// </summary>
    public partial class DataFactoryTriggerData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryTriggerData"/>. </summary>
        /// <param name="properties">
        /// Properties of the trigger.
        /// Please note <see cref="DataFactoryTriggerProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryBlobEventsTrigger"/>, <see cref="DataFactoryBlobTrigger"/>, <see cref="ChainingTrigger"/>, <see cref="CustomEventsTrigger"/>, <see cref="MultiplePipelineTrigger"/>, <see cref="RerunTumblingWindowTrigger"/>, <see cref="DataFactoryScheduleTrigger"/> and <see cref="TumblingWindowTrigger"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryTriggerData(DataFactoryTriggerProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryTriggerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of the trigger.
        /// Please note <see cref="DataFactoryTriggerProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryBlobEventsTrigger"/>, <see cref="DataFactoryBlobTrigger"/>, <see cref="ChainingTrigger"/>, <see cref="CustomEventsTrigger"/>, <see cref="MultiplePipelineTrigger"/>, <see cref="RerunTumblingWindowTrigger"/>, <see cref="DataFactoryScheduleTrigger"/> and <see cref="TumblingWindowTrigger"/>.
        /// </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryTriggerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataFactoryTriggerProperties properties, ETag? eTag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryTriggerData"/> for deserialization. </summary>
        internal DataFactoryTriggerData()
        {
        }

        /// <summary>
        /// Properties of the trigger.
        /// Please note <see cref="DataFactoryTriggerProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryBlobEventsTrigger"/>, <see cref="DataFactoryBlobTrigger"/>, <see cref="ChainingTrigger"/>, <see cref="CustomEventsTrigger"/>, <see cref="MultiplePipelineTrigger"/>, <see cref="RerunTumblingWindowTrigger"/>, <see cref="DataFactoryScheduleTrigger"/> and <see cref="TumblingWindowTrigger"/>.
        /// </summary>
        public DataFactoryTriggerProperties Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
