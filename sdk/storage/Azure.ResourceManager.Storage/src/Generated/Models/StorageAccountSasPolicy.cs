// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> SasPolicy assigned to the storage account. </summary>
    public partial class StorageAccountSasPolicy
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

        /// <summary> Initializes a new instance of <see cref="StorageAccountSasPolicy"/>. </summary>
        /// <param name="sasExpirationPeriod"> The SAS expiration period, DD.HH:MM:SS. </param>
        /// <param name="expirationAction"> The SAS expiration action. Can only be Log. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasExpirationPeriod"/> is null. </exception>
        public StorageAccountSasPolicy(string sasExpirationPeriod, ExpirationAction expirationAction)
        {
            Argument.AssertNotNull(sasExpirationPeriod, nameof(sasExpirationPeriod));

            SasExpirationPeriod = sasExpirationPeriod;
            ExpirationAction = expirationAction;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountSasPolicy"/>. </summary>
        /// <param name="sasExpirationPeriod"> The SAS expiration period, DD.HH:MM:SS. </param>
        /// <param name="expirationAction"> The SAS expiration action. Can only be Log. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountSasPolicy(string sasExpirationPeriod, ExpirationAction expirationAction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SasExpirationPeriod = sasExpirationPeriod;
            ExpirationAction = expirationAction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountSasPolicy"/> for deserialization. </summary>
        internal StorageAccountSasPolicy()
        {
        }

        /// <summary> The SAS expiration period, DD.HH:MM:SS. </summary>
        [WirePath("sasExpirationPeriod")]
        public string SasExpirationPeriod { get; set; }
        /// <summary> The SAS expiration action. Can only be Log. </summary>
        [WirePath("expirationAction")]
        public ExpirationAction ExpirationAction { get; set; }
    }
}
