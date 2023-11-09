// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> The move custom error info. </summary>
    internal partial class MoveErrorInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoveErrorInfo"/>. </summary>
        internal MoveErrorInfo()
        {
            InfoMoverResources = new ChangeTrackingList<AffectedMoverResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="MoveErrorInfo"/>. </summary>
        /// <param name="infoMoverResources"> The affected move resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoveErrorInfo(IReadOnlyList<AffectedMoverResourceInfo> infoMoverResources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InfoMoverResources = infoMoverResources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The affected move resources. </summary>
        public IReadOnlyList<AffectedMoverResourceInfo> InfoMoverResources { get; }
    }
}
