// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ResourceSkuRestrictions
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictions"/>. </summary>
        internal ResourceSkuRestrictions()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictions"/>. </summary>
        /// <param name="restrictionsType"> The type of restrictions. </param>
        /// <param name="values"> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </param>
        /// <param name="reasonCode"> The reason code for restriction. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceSkuRestrictions(ResourceSkuRestrictionsType? restrictionsType, IReadOnlyList<string> values, ResourceSkuRestrictionsReasonCode? reasonCode, Dictionary<string, BinaryData> rawData)
        {
            RestrictionsType = restrictionsType;
            Values = values;
            ReasonCode = reasonCode;
            _rawData = rawData;
        }

        /// <summary> The type of restrictions. </summary>
        public ResourceSkuRestrictionsType? RestrictionsType { get; }
        /// <summary> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The reason code for restriction. </summary>
        public ResourceSkuRestrictionsReasonCode? ReasonCode { get; }
    }
}
