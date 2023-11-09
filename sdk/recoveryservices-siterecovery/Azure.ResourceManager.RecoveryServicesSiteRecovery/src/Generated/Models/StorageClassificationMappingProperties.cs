// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Storage mapping properties. </summary>
    internal partial class StorageClassificationMappingProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageClassificationMappingProperties"/>. </summary>
        internal StorageClassificationMappingProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageClassificationMappingProperties"/>. </summary>
        /// <param name="targetStorageClassificationId"> Target storage object Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageClassificationMappingProperties(ResourceIdentifier targetStorageClassificationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetStorageClassificationId = targetStorageClassificationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Target storage object Id. </summary>
        public ResourceIdentifier TargetStorageClassificationId { get; }
    }
}
