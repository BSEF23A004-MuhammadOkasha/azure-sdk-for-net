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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class OrchestrationServiceSummary : IUtf8JsonSerializable, IModelJsonSerializable<OrchestrationServiceSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OrchestrationServiceSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OrchestrationServiceSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OrchestrationServiceSummary>(this, options.Format);

            writer.WriteStartObject();
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

        internal static OrchestrationServiceSummary DeserializeOrchestrationServiceSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OrchestrationServiceName> serviceName = default;
            Optional<OrchestrationServiceState> serviceState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceName = new OrchestrationServiceName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceState = new OrchestrationServiceState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OrchestrationServiceSummary(Optional.ToNullable(serviceName), Optional.ToNullable(serviceState), rawData);
        }

        OrchestrationServiceSummary IModelJsonSerializable<OrchestrationServiceSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OrchestrationServiceSummary>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOrchestrationServiceSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OrchestrationServiceSummary>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OrchestrationServiceSummary>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OrchestrationServiceSummary IModelSerializable<OrchestrationServiceSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OrchestrationServiceSummary>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOrchestrationServiceSummary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OrchestrationServiceSummary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OrchestrationServiceSummary"/> to convert. </param>
        public static implicit operator RequestContent(OrchestrationServiceSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OrchestrationServiceSummary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OrchestrationServiceSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOrchestrationServiceSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
