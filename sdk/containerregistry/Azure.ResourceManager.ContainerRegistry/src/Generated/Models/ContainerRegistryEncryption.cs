// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ContainerRegistryEncryption. </summary>
    public partial class ContainerRegistryEncryption
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncryption"/>. </summary>
        public ContainerRegistryEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncryption"/>. </summary>
        /// <param name="status"> Indicates whether or not the encryption is enabled for container registry. </param>
        /// <param name="keyVaultProperties"> Key vault properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryEncryption(ContainerRegistryEncryptionStatus? status, ContainerRegistryKeyVaultProperties keyVaultProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            KeyVaultProperties = keyVaultProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether or not the encryption is enabled for container registry. </summary>
        public ContainerRegistryEncryptionStatus? Status { get; set; }
        /// <summary> Key vault properties. </summary>
        public ContainerRegistryKeyVaultProperties KeyVaultProperties { get; set; }
    }
}
