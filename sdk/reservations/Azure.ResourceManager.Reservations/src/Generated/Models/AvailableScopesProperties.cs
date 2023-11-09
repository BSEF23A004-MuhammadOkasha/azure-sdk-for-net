// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The response of available scope api containing scopes and their eligibilities. </summary>
    public partial class AvailableScopesProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailableScopesProperties"/>. </summary>
        internal AvailableScopesProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailableScopesProperties"/>. </summary>
        /// <param name="properties"> The scopes checked by the available scope api. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableScopesProperties(SubscriptionScopeProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The scopes checked by the available scope api. </summary>
        internal SubscriptionScopeProperties Properties { get; }
        /// <summary> Gets the scopes. </summary>
        public IReadOnlyList<ScopeProperties> Scopes
        {
            get => Properties?.Scopes;
        }
    }
}
