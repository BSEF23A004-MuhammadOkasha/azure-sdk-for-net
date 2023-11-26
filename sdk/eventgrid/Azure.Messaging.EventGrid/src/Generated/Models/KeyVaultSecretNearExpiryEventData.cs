// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.KeyVault.SecretNearExpiry event. </summary>
    public partial class KeyVaultSecretNearExpiryEventData
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

        /// <summary> Initializes a new instance of <see cref="KeyVaultSecretNearExpiryEventData"/>. </summary>
        internal KeyVaultSecretNearExpiryEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultSecretNearExpiryEventData"/>. </summary>
        /// <param name="id"> The id of the object that triggered this event. </param>
        /// <param name="vaultName"> Key vault name of the object that triggered this event. </param>
        /// <param name="objectType"> The type of the object that triggered this event. </param>
        /// <param name="objectName"> The name of the object that triggered this event. </param>
        /// <param name="version"> The version of the object that triggered this event. </param>
        /// <param name="nbf"> Not before date of the object that triggered this event. </param>
        /// <param name="exp"> The expiration date of the object that triggered this event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultSecretNearExpiryEventData(string id, string vaultName, string objectType, string objectName, string version, float? nbf, float? exp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            VaultName = vaultName;
            ObjectType = objectType;
            ObjectName = objectName;
            Version = version;
            Nbf = nbf;
            Exp = exp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id of the object that triggered this event. </summary>
        public string Id { get; }
        /// <summary> Key vault name of the object that triggered this event. </summary>
        public string VaultName { get; }
        /// <summary> The type of the object that triggered this event. </summary>
        public string ObjectType { get; }
        /// <summary> The name of the object that triggered this event. </summary>
        public string ObjectName { get; }
        /// <summary> The version of the object that triggered this event. </summary>
        public string Version { get; }
        /// <summary> Not before date of the object that triggered this event. </summary>
        public float? Nbf { get; }
        /// <summary> The expiration date of the object that triggered this event. </summary>
        public float? Exp { get; }
    }
}
