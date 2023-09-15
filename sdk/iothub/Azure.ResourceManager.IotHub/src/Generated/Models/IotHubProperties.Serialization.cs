// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AuthorizationPolicies))
            {
                writer.WritePropertyName("authorizationPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(DisableDeviceSas))
            {
                writer.WritePropertyName("disableDeviceSAS"u8);
                writer.WriteBooleanValue(DisableDeviceSas.Value);
            }
            if (Optional.IsDefined(DisableModuleSas))
            {
                writer.WritePropertyName("disableModuleSAS"u8);
                writer.WriteBooleanValue(DisableModuleSas.Value);
            }
            if (Optional.IsDefined(RestrictOutboundNetworkAccess))
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess"u8);
                writer.WriteBooleanValue(RestrictOutboundNetworkAccess.Value);
            }
            if (Optional.IsCollectionDefined(AllowedFqdns))
            {
                writer.WritePropertyName("allowedFqdnList"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedFqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPFilterRules))
            {
                writer.WritePropertyName("ipFilterRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPFilterRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkRuleSets))
            {
                writer.WritePropertyName("networkRuleSets"u8);
                writer.WriteObjectValue(NetworkRuleSets);
            }
            if (Optional.IsDefined(MinTlsVersion))
            {
                writer.WritePropertyName("minTlsVersion"u8);
                writer.WriteStringValue(MinTlsVersion);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EventHubEndpoints))
            {
                writer.WritePropertyName("eventHubEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in EventHubEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Routing))
            {
                writer.WritePropertyName("routing"u8);
                writer.WriteObjectValue(Routing);
            }
            if (Optional.IsCollectionDefined(StorageEndpoints))
            {
                writer.WritePropertyName("storageEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in StorageEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(MessagingEndpoints))
            {
                writer.WritePropertyName("messagingEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in MessagingEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EnableFileUploadNotifications))
            {
                writer.WritePropertyName("enableFileUploadNotifications"u8);
                writer.WriteBooleanValue(EnableFileUploadNotifications.Value);
            }
            if (Optional.IsDefined(CloudToDevice))
            {
                writer.WritePropertyName("cloudToDevice"u8);
                writer.WriteObjectValue(CloudToDevice);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(DeviceStreams))
            {
                writer.WritePropertyName("deviceStreams"u8);
                writer.WriteObjectValue(DeviceStreams);
            }
            if (Optional.IsDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStringValue(Features.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(EnableDataResidency))
            {
                writer.WritePropertyName("enableDataResidency"u8);
                writer.WriteBooleanValue(EnableDataResidency.Value);
            }
            if (Optional.IsDefined(RootCertificate))
            {
                writer.WritePropertyName("rootCertificate"u8);
                writer.WriteObjectValue(RootCertificate);
            }
            if (Optional.IsDefined(IPVersion))
            {
                writer.WritePropertyName("ipVersion"u8);
                writer.WriteStringValue(IPVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static IotHubProperties DeserializeIotHubProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<SharedAccessSignatureAuthorizationRule>> authorizationPolicies = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> disableDeviceSas = default;
            Optional<bool> disableModuleSas = default;
            Optional<bool> restrictOutboundNetworkAccess = default;
            Optional<IList<string>> allowedFqdnList = default;
            Optional<IotHubPublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<IotHubIPFilterRule>> ipFilterRules = default;
            Optional<IotHubNetworkRuleSetProperties> networkRuleSets = default;
            Optional<string> minTlsVersion = default;
            Optional<IList<IotHubPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<string> provisioningState = default;
            Optional<string> state = default;
            Optional<string> hostName = default;
            Optional<IDictionary<string, EventHubCompatibleEndpointProperties>> eventHubEndpoints = default;
            Optional<IotHubRoutingProperties> routing = default;
            Optional<IDictionary<string, IotHubStorageEndpointProperties>> storageEndpoints = default;
            Optional<IDictionary<string, MessagingEndpointProperties>> messagingEndpoints = default;
            Optional<bool> enableFileUploadNotifications = default;
            Optional<CloudToDeviceProperties> cloudToDevice = default;
            Optional<string> comments = default;
            Optional<IotHubPropertiesDeviceStreams> deviceStreams = default;
            Optional<IotHubCapability> features = default;
            Optional<EncryptionPropertiesDescription> encryption = default;
            Optional<IReadOnlyList<IotHubLocationDescription>> locations = default;
            Optional<bool> enableDataResidency = default;
            Optional<RootCertificateProperties> rootCertificate = default;
            Optional<IotHubIPVersion> ipVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SharedAccessSignatureAuthorizationRule> array = new List<SharedAccessSignatureAuthorizationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SharedAccessSignatureAuthorizationRule.DeserializeSharedAccessSignatureAuthorizationRule(item));
                    }
                    authorizationPolicies = array;
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableDeviceSAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableDeviceSas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableModuleSAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableModuleSas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restrictOutboundNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictOutboundNetworkAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedFqdnList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedFqdnList = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new IotHubPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipFilterRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubIPFilterRule> array = new List<IotHubIPFilterRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubIPFilterRule.DeserializeIotHubIPFilterRule(item));
                    }
                    ipFilterRules = array;
                    continue;
                }
                if (property.NameEquals("networkRuleSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkRuleSets = IotHubNetworkRuleSetProperties.DeserializeIotHubNetworkRuleSetProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("minTlsVersion"u8))
                {
                    minTlsVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubPrivateEndpointConnectionData> array = new List<IotHubPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubPrivateEndpointConnectionData.DeserializeIotHubPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EventHubCompatibleEndpointProperties> dictionary = new Dictionary<string, EventHubCompatibleEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EventHubCompatibleEndpointProperties.DeserializeEventHubCompatibleEndpointProperties(property0.Value));
                    }
                    eventHubEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("routing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routing = IotHubRoutingProperties.DeserializeIotHubRoutingProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("storageEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IotHubStorageEndpointProperties> dictionary = new Dictionary<string, IotHubStorageEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, IotHubStorageEndpointProperties.DeserializeIotHubStorageEndpointProperties(property0.Value));
                    }
                    storageEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("messagingEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MessagingEndpointProperties> dictionary = new Dictionary<string, MessagingEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MessagingEndpointProperties.DeserializeMessagingEndpointProperties(property0.Value));
                    }
                    messagingEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("enableFileUploadNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableFileUploadNotifications = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudToDevice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDevice = CloudToDeviceProperties.DeserializeCloudToDeviceProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("comments"u8))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceStreams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceStreams = IotHubPropertiesDeviceStreams.DeserializeIotHubPropertiesDeviceStreams(property.Value);
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    features = new IotHubCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = EncryptionPropertiesDescription.DeserializeEncryptionPropertiesDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubLocationDescription> array = new List<IotHubLocationDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubLocationDescription.DeserializeIotHubLocationDescription(item));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("enableDataResidency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDataResidency = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rootCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rootCertificate = RootCertificateProperties.DeserializeRootCertificateProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("ipVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipVersion = new IotHubIPVersion(property.Value.GetString());
                    continue;
                }
            }
            return new IotHubProperties(Optional.ToList(authorizationPolicies), Optional.ToNullable(disableLocalAuth), Optional.ToNullable(disableDeviceSas), Optional.ToNullable(disableModuleSas), Optional.ToNullable(restrictOutboundNetworkAccess), Optional.ToList(allowedFqdnList), Optional.ToNullable(publicNetworkAccess), Optional.ToList(ipFilterRules), networkRuleSets.Value, minTlsVersion.Value, Optional.ToList(privateEndpointConnections), provisioningState.Value, state.Value, hostName.Value, Optional.ToDictionary(eventHubEndpoints), routing.Value, Optional.ToDictionary(storageEndpoints), Optional.ToDictionary(messagingEndpoints), Optional.ToNullable(enableFileUploadNotifications), cloudToDevice.Value, comments.Value, deviceStreams.Value, Optional.ToNullable(features), encryption.Value, Optional.ToList(locations), Optional.ToNullable(enableDataResidency), rootCertificate.Value, Optional.ToNullable(ipVersion));
        }
    }
}
