// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The provider permission. </summary>
    public partial class ProviderPermission
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

        /// <summary> Initializes a new instance of <see cref="ProviderPermission"/>. </summary>
        internal ProviderPermission()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProviderPermission"/>. </summary>
        /// <param name="applicationId"> The application id. </param>
        /// <param name="roleDefinition"> Role definition properties. </param>
        /// <param name="managedByRoleDefinition"> Role definition properties. </param>
        /// <param name="providerAuthorizationConsentState"> The provider authorization consent state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderPermission(string applicationId, AzureRoleDefinition roleDefinition, AzureRoleDefinition managedByRoleDefinition, ProviderAuthorizationConsentState? providerAuthorizationConsentState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApplicationId = applicationId;
            RoleDefinition = roleDefinition;
            ManagedByRoleDefinition = managedByRoleDefinition;
            ProviderAuthorizationConsentState = providerAuthorizationConsentState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The application id. </summary>
        public string ApplicationId { get; }
        /// <summary> Role definition properties. </summary>
        public AzureRoleDefinition RoleDefinition { get; }
        /// <summary> Role definition properties. </summary>
        public AzureRoleDefinition ManagedByRoleDefinition { get; }
        /// <summary> The provider authorization consent state. </summary>
        public ProviderAuthorizationConsentState? ProviderAuthorizationConsentState { get; }
    }
}
