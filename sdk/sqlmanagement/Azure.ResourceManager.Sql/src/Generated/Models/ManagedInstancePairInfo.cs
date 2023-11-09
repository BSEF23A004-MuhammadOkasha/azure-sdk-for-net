// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Pairs of Managed Instances in the failover group. </summary>
    public partial class ManagedInstancePairInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePairInfo"/>. </summary>
        public ManagedInstancePairInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePairInfo"/>. </summary>
        /// <param name="primaryManagedInstanceId"> Id of Primary Managed Instance in pair. </param>
        /// <param name="partnerManagedInstanceId"> Id of Partner Managed Instance in pair. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstancePairInfo(ResourceIdentifier primaryManagedInstanceId, ResourceIdentifier partnerManagedInstanceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryManagedInstanceId = primaryManagedInstanceId;
            PartnerManagedInstanceId = partnerManagedInstanceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Id of Primary Managed Instance in pair. </summary>
        public ResourceIdentifier PrimaryManagedInstanceId { get; set; }
        /// <summary> Id of Partner Managed Instance in pair. </summary>
        public ResourceIdentifier PartnerManagedInstanceId { get; set; }
    }
}
