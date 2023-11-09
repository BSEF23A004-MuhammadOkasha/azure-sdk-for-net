// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Storage object properties. </summary>
    internal partial class StorageClassificationProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageClassificationProperties"/>. </summary>
        internal StorageClassificationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageClassificationProperties"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the Storage classification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageClassificationProperties(string friendlyName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FriendlyName = friendlyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Friendly name of the Storage classification. </summary>
        public string FriendlyName { get; }
    }
}
