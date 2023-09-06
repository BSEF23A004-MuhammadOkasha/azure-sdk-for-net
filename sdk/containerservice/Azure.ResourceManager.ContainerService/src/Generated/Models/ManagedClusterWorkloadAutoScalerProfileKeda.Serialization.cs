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
    internal partial class ManagedClusterWorkloadAutoScalerProfileKeda : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterWorkloadAutoScalerProfileKeda>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterWorkloadAutoScalerProfileKeda>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterWorkloadAutoScalerProfileKeda>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterWorkloadAutoScalerProfileKeda>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(Enabled);
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

        internal static ManagedClusterWorkloadAutoScalerProfileKeda DeserializeManagedClusterWorkloadAutoScalerProfileKeda(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterWorkloadAutoScalerProfileKeda(enabled, rawData);
        }

        ManagedClusterWorkloadAutoScalerProfileKeda IModelJsonSerializable<ManagedClusterWorkloadAutoScalerProfileKeda>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterWorkloadAutoScalerProfileKeda>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterWorkloadAutoScalerProfileKeda(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterWorkloadAutoScalerProfileKeda>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterWorkloadAutoScalerProfileKeda>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterWorkloadAutoScalerProfileKeda IModelSerializable<ManagedClusterWorkloadAutoScalerProfileKeda>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterWorkloadAutoScalerProfileKeda>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterWorkloadAutoScalerProfileKeda(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedClusterWorkloadAutoScalerProfileKeda"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedClusterWorkloadAutoScalerProfileKeda"/> to convert. </param>
        public static implicit operator RequestContent(ManagedClusterWorkloadAutoScalerProfileKeda model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedClusterWorkloadAutoScalerProfileKeda"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedClusterWorkloadAutoScalerProfileKeda(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterWorkloadAutoScalerProfileKeda(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
