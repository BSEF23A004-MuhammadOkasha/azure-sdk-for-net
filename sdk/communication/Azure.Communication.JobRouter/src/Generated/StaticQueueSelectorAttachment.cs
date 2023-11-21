// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a queue selector that will be attached to a job. </summary>
    public partial class StaticQueueSelectorAttachment : QueueSelectorAttachment
    {
        /// <summary> Initializes a new instance of <see cref="StaticQueueSelectorAttachment"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of QueueSelectorAttachment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="queueSelector"> The queue selector to attach. </param>
        internal StaticQueueSelectorAttachment(QueueSelectorAttachmentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, RouterQueueSelector queueSelector) : base(kind, serializedAdditionalRawData)
        {
            QueueSelector = queueSelector;
        }

        /// <summary> Initializes a new instance of <see cref="StaticQueueSelectorAttachment"/> for deserialization. </summary>
        internal StaticQueueSelectorAttachment()
        {
        }

        /// <summary> The queue selector to attach. </summary>
        public RouterQueueSelector QueueSelector { get; }
    }
}
