// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// An attachment of queue selectors to resolve a queue to a job from a classification policy
    /// Please note <see cref="QueueSelectorAttachment"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConditionalQueueSelectorAttachment"/>, <see cref="PassThroughQueueSelectorAttachment"/>, <see cref="RuleEngineQueueSelectorAttachment"/>, <see cref="StaticQueueSelectorAttachment"/> and <see cref="WeightedAllocationQueueSelectorAttachment"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownQueueSelectorAttachment))]
    public abstract partial class QueueSelectorAttachment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueueSelectorAttachment"/>. </summary>
        /// <param name="kind"> The type discriminator describing the type of queue selector attachment. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueueSelectorAttachment(string kind, Dictionary<string, BinaryData> rawData)
        {
            Kind = kind;
            _rawData = rawData;
        }
    }
}
