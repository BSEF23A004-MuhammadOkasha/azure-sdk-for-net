// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkAnalytics;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> The type used for update operations of the DataProduct. </summary>
    public partial class DataProductPatch
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

        /// <summary> Initializes a new instance of <see cref="DataProductPatch"/>. </summary>
        public DataProductPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Owners = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataProductPatch"/>. </summary>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="owners"> List of name or email associated with data product resource deployment. </param>
        /// <param name="purviewAccount"> Purview account url for data product to connect to. </param>
        /// <param name="purviewCollection"> Purview collection url for data product to connect to. </param>
        /// <param name="privateLinksEnabled"> Flag to enable or disable private link for data product resource. </param>
        /// <param name="currentMinorVersion"> Current configured minor version of the data product resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataProductPatch(ManagedServiceIdentity identity, IDictionary<string, string> tags, IList<string> owners, string purviewAccount, string purviewCollection, DataProductControlState? privateLinksEnabled, string currentMinorVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Tags = tags;
            Owners = owners;
            PurviewAccount = purviewAccount;
            PurviewCollection = purviewCollection;
            PrivateLinksEnabled = privateLinksEnabled;
            CurrentMinorVersion = currentMinorVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> List of name or email associated with data product resource deployment. </summary>
        public IList<string> Owners { get; }
        /// <summary> Purview account url for data product to connect to. </summary>
        public string PurviewAccount { get; set; }
        /// <summary> Purview collection url for data product to connect to. </summary>
        public string PurviewCollection { get; set; }
        /// <summary> Flag to enable or disable private link for data product resource. </summary>
        public DataProductControlState? PrivateLinksEnabled { get; set; }
        /// <summary> Current configured minor version of the data product resource. </summary>
        public string CurrentMinorVersion { get; set; }
    }
}
