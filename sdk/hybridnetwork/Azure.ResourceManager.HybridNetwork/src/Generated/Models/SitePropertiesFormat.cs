// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HybridNetwork;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Site properties. </summary>
    public partial class SitePropertiesFormat
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SitePropertiesFormat"/>. </summary>
        public SitePropertiesFormat()
        {
            Nfvis = new ChangeTrackingList<NFVIs>();
            SiteNetworkServiceReferences = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="SitePropertiesFormat"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the site resource. **TODO**: Confirm if this is needed. </param>
        /// <param name="nfvis">
        /// List of NFVIs
        /// Please note <see cref="NFVIs"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureArcK8SClusterNfviDetails"/>, <see cref="AzureCoreNfviDetails"/> and <see cref="AzureOperatorNexusClusterNfviDetails"/>.
        /// </param>
        /// <param name="siteNetworkServiceReferences"> The list of site network services on the site. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SitePropertiesFormat(ProvisioningState? provisioningState, IList<NFVIs> nfvis, IReadOnlyList<WritableSubResource> siteNetworkServiceReferences, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Nfvis = nfvis;
            SiteNetworkServiceReferences = siteNetworkServiceReferences;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the site resource. **TODO**: Confirm if this is needed. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// List of NFVIs
        /// Please note <see cref="NFVIs"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureArcK8SClusterNfviDetails"/>, <see cref="AzureCoreNfviDetails"/> and <see cref="AzureOperatorNexusClusterNfviDetails"/>.
        /// </summary>
        public IList<NFVIs> Nfvis { get; }
        /// <summary> The list of site network services on the site. </summary>
        public IReadOnlyList<WritableSubResource> SiteNetworkServiceReferences { get; }
    }
}
