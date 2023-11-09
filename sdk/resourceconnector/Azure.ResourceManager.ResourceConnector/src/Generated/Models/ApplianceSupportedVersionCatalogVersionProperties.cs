// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> The SupportedVersionCatalogVersionData object for appliance. </summary>
    public partial class ApplianceSupportedVersionCatalogVersionProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplianceSupportedVersionCatalogVersionProperties"/>. </summary>
        internal ApplianceSupportedVersionCatalogVersionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceSupportedVersionCatalogVersionProperties"/>. </summary>
        /// <param name="audience"> The image audience name for the version available for upgrade. </param>
        /// <param name="catalog"> The image catalog name for the version available for upgrade. </param>
        /// <param name="offer"> The image offer name for the version available for upgrade. </param>
        /// <param name="version"> The image version for the version available for upgrade. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplianceSupportedVersionCatalogVersionProperties(string audience, string catalog, string offer, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Audience = audience;
            Catalog = catalog;
            Offer = offer;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The image audience name for the version available for upgrade. </summary>
        public string Audience { get; }
        /// <summary> The image catalog name for the version available for upgrade. </summary>
        public string Catalog { get; }
        /// <summary> The image offer name for the version available for upgrade. </summary>
        public string Offer { get; }
        /// <summary> The image version for the version available for upgrade. </summary>
        public string Version { get; }
    }
}
