// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Properties for a Connection Setting Item. </summary>
    public partial class BotConnectionSettingProperties
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

        /// <summary> Initializes a new instance of <see cref="BotConnectionSettingProperties"/>. </summary>
        public BotConnectionSettingProperties()
        {
            Parameters = new ChangeTrackingList<BotConnectionSettingParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="BotConnectionSettingProperties"/>. </summary>
        /// <param name="clientId"> Client Id associated with the Connection Setting. </param>
        /// <param name="settingId"> Setting Id set by the service for the Connection Setting. </param>
        /// <param name="clientSecret"> Client Secret associated with the Connection Setting. </param>
        /// <param name="scopes"> Scopes associated with the Connection Setting. </param>
        /// <param name="serviceProviderId"> Service Provider Id associated with the Connection Setting. </param>
        /// <param name="serviceProviderDisplayName"> Service Provider Display Name associated with the Connection Setting. </param>
        /// <param name="parameters"> Service Provider Parameters associated with the Connection Setting. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotConnectionSettingProperties(string clientId, string settingId, string clientSecret, string scopes, string serviceProviderId, string serviceProviderDisplayName, IList<BotConnectionSettingParameter> parameters, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClientId = clientId;
            SettingId = settingId;
            ClientSecret = clientSecret;
            Scopes = scopes;
            ServiceProviderId = serviceProviderId;
            ServiceProviderDisplayName = serviceProviderDisplayName;
            Parameters = parameters;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Client Id associated with the Connection Setting. </summary>
        public string ClientId { get; set; }
        /// <summary> Setting Id set by the service for the Connection Setting. </summary>
        public string SettingId { get; }
        /// <summary> Client Secret associated with the Connection Setting. </summary>
        public string ClientSecret { get; set; }
        /// <summary> Scopes associated with the Connection Setting. </summary>
        public string Scopes { get; set; }
        /// <summary> Service Provider Id associated with the Connection Setting. </summary>
        public string ServiceProviderId { get; set; }
        /// <summary> Service Provider Display Name associated with the Connection Setting. </summary>
        public string ServiceProviderDisplayName { get; set; }
        /// <summary> Service Provider Parameters associated with the Connection Setting. </summary>
        public IList<BotConnectionSettingParameter> Parameters { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public string ProvisioningState { get; set; }
    }
}
