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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfileDefender : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterSecurityProfileDefender>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterSecurityProfileDefender>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterSecurityProfileDefender>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterSecurityProfileDefender>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LogAnalyticsWorkspaceResourceId))
            {
                writer.WritePropertyName("logAnalyticsWorkspaceResourceId"u8);
                writer.WriteStringValue(LogAnalyticsWorkspaceResourceId);
            }
            if (Optional.IsDefined(SecurityMonitoring))
            {
                writer.WritePropertyName("securityMonitoring"u8);
                if (SecurityMonitoring is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedClusterSecurityProfileDefenderSecurityMonitoring>)SecurityMonitoring).Serialize(writer, options);
                }
            }
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

        internal static ManagedClusterSecurityProfileDefender DeserializeManagedClusterSecurityProfileDefender(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> logAnalyticsWorkspaceResourceId = default;
            Optional<ManagedClusterSecurityProfileDefenderSecurityMonitoring> securityMonitoring = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logAnalyticsWorkspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsWorkspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("securityMonitoring"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityMonitoring = ManagedClusterSecurityProfileDefenderSecurityMonitoring.DeserializeManagedClusterSecurityProfileDefenderSecurityMonitoring(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterSecurityProfileDefender(logAnalyticsWorkspaceResourceId.Value, securityMonitoring.Value, rawData);
        }

        ManagedClusterSecurityProfileDefender IModelJsonSerializable<ManagedClusterSecurityProfileDefender>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterSecurityProfileDefender>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfileDefender(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterSecurityProfileDefender>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterSecurityProfileDefender>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterSecurityProfileDefender IModelSerializable<ManagedClusterSecurityProfileDefender>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterSecurityProfileDefender>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterSecurityProfileDefender(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedClusterSecurityProfileDefender"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedClusterSecurityProfileDefender"/> to convert. </param>
        public static implicit operator RequestContent(ManagedClusterSecurityProfileDefender model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedClusterSecurityProfileDefender"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedClusterSecurityProfileDefender(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterSecurityProfileDefender(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
