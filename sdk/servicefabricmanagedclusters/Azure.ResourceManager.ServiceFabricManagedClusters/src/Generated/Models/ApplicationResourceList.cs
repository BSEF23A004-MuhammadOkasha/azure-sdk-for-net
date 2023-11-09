// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabricManagedClusters;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The list of application resources. </summary>
    internal partial class ApplicationResourceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationResourceList"/>. </summary>
        internal ApplicationResourceList()
        {
            Value = new ChangeTrackingList<ServiceFabricManagedApplicationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationResourceList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of application list results if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationResourceList(IReadOnlyList<ServiceFabricManagedApplicationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ServiceFabricManagedApplicationData> Value { get; }
        /// <summary> URL to get the next set of application list results if there are any. </summary>
        public string NextLink { get; }
    }
}
