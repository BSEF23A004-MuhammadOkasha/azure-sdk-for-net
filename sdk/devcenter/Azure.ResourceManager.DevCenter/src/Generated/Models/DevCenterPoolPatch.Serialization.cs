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

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterPoolPatch : IUtf8JsonSerializable, IModelJsonSerializable<DevCenterPoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevCenterPoolPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevCenterPoolPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DevCenterPoolPatch>(this, options.Format);

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DevBoxDefinitionName))
            {
                writer.WritePropertyName("devBoxDefinitionName"u8);
                writer.WriteStringValue(DevBoxDefinitionName);
            }
            if (Optional.IsDefined(NetworkConnectionName))
            {
                writer.WritePropertyName("networkConnectionName"u8);
                writer.WriteStringValue(NetworkConnectionName);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(LocalAdministrator))
            {
                writer.WritePropertyName("localAdministrator"u8);
                writer.WriteStringValue(LocalAdministrator.Value.ToString());
            }
            if (Optional.IsDefined(StopOnDisconnect))
            {
                writer.WritePropertyName("stopOnDisconnect"u8);
                if (StopOnDisconnect is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StopOnDisconnectConfiguration>)StopOnDisconnect).Serialize(writer, options);
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

        internal static DevCenterPoolPatch DeserializeDevCenterPoolPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<AzureLocation> location = default;
            Optional<string> devBoxDefinitionName = default;
            Optional<string> networkConnectionName = default;
            Optional<DevCenterLicenseType> licenseType = default;
            Optional<LocalAdminStatus> localAdministrator = default;
            Optional<StopOnDisconnectConfiguration> stopOnDisconnect = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("devBoxDefinitionName"u8))
                        {
                            devBoxDefinitionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkConnectionName"u8))
                        {
                            networkConnectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = new DevCenterLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("localAdministrator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localAdministrator = new LocalAdminStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stopOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stopOnDisconnect = StopOnDisconnectConfiguration.DeserializeStopOnDisconnectConfiguration(property0.Value);
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
            return new DevCenterPoolPatch(Optional.ToDictionary(tags), Optional.ToNullable(location), devBoxDefinitionName.Value, networkConnectionName.Value, Optional.ToNullable(licenseType), Optional.ToNullable(localAdministrator), stopOnDisconnect.Value, rawData);
        }

        DevCenterPoolPatch IModelJsonSerializable<DevCenterPoolPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DevCenterPoolPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterPoolPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevCenterPoolPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DevCenterPoolPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevCenterPoolPatch IModelSerializable<DevCenterPoolPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DevCenterPoolPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevCenterPoolPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevCenterPoolPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevCenterPoolPatch"/> to convert. </param>
        public static implicit operator RequestContent(DevCenterPoolPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevCenterPoolPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevCenterPoolPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevCenterPoolPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
