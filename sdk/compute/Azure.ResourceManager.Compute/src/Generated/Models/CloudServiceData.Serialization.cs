// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class CloudServiceData : IUtf8JsonSerializable, IModelJsonSerializable<CloudServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudServiceData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudServiceData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudServiceData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PackageUri))
            {
                writer.WritePropertyName("packageUrl"u8);
                writer.WriteStringValue(PackageUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteStringValue(Configuration);
            }
            if (Optional.IsDefined(ConfigurationUri))
            {
                writer.WritePropertyName("configurationUrl"u8);
                writer.WriteStringValue(ConfigurationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StartCloudService))
            {
                writer.WritePropertyName("startCloudService"u8);
                writer.WriteBooleanValue(StartCloudService.Value);
            }
            if (Optional.IsDefined(AllowModelOverride))
            {
                writer.WritePropertyName("allowModelOverride"u8);
                writer.WriteBooleanValue(AllowModelOverride.Value);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode"u8);
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(RoleProfile))
            {
                writer.WritePropertyName("roleProfile"u8);
                if (RoleProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudServiceRoleProfile>)RoleProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                if (OSProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudServiceOSProfile>)OSProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                if (NetworkProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudServiceNetworkProfile>)NetworkProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ExtensionProfile))
            {
                writer.WritePropertyName("extensionProfile"u8);
                if (ExtensionProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudServiceExtensionProfile>)ExtensionProfile).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static CloudServiceData DeserializeCloudServiceData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> zones = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> packageUrl = default;
            Optional<string> configuration = default;
            Optional<Uri> configurationUrl = default;
            Optional<bool> startCloudService = default;
            Optional<bool> allowModelOverride = default;
            Optional<CloudServiceUpgradeMode> upgradeMode = default;
            Optional<CloudServiceRoleProfile> roleProfile = default;
            Optional<CloudServiceOSProfile> osProfile = default;
            Optional<CloudServiceNetworkProfile> networkProfile = default;
            Optional<CloudServiceExtensionProfile> extensionProfile = default;
            Optional<string> provisioningState = default;
            Optional<string> uniqueId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packageUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("configuration"u8))
                        {
                            configuration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startCloudService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startCloudService = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowModelOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowModelOverride = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("upgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeMode = new CloudServiceUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("roleProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleProfile = CloudServiceRoleProfile.DeserializeCloudServiceRoleProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = CloudServiceOSProfile.DeserializeCloudServiceOSProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = CloudServiceNetworkProfile.DeserializeCloudServiceNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("extensionProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extensionProfile = CloudServiceExtensionProfile.DeserializeCloudServiceExtensionProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToList(zones), packageUrl.Value, configuration.Value, configurationUrl.Value, Optional.ToNullable(startCloudService), Optional.ToNullable(allowModelOverride), Optional.ToNullable(upgradeMode), roleProfile.Value, osProfile.Value, networkProfile.Value, extensionProfile.Value, provisioningState.Value, uniqueId.Value, rawData);
        }

        CloudServiceData IModelJsonSerializable<CloudServiceData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudServiceData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudServiceData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudServiceData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudServiceData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudServiceData IModelSerializable<CloudServiceData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudServiceData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudServiceData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CloudServiceData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CloudServiceData"/> to convert. </param>
        public static implicit operator RequestContent(CloudServiceData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CloudServiceData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CloudServiceData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudServiceData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
