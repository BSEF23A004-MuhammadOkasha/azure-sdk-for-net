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

namespace Azure.ResourceManager.ContainerInstance.Models
{
    internal partial class ContainerGroupDiagnostics : IUtf8JsonSerializable, IModelJsonSerializable<ContainerGroupDiagnostics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerGroupDiagnostics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerGroupDiagnostics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupDiagnostics>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LogAnalytics))
            {
                writer.WritePropertyName("logAnalytics"u8);
                if (LogAnalytics is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerGroupLogAnalytics>)LogAnalytics).Serialize(writer, options);
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

        internal static ContainerGroupDiagnostics DeserializeContainerGroupDiagnostics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerGroupLogAnalytics> logAnalytics = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logAnalytics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalytics = ContainerGroupLogAnalytics.DeserializeContainerGroupLogAnalytics(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerGroupDiagnostics(logAnalytics.Value, rawData);
        }

        ContainerGroupDiagnostics IModelJsonSerializable<ContainerGroupDiagnostics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupDiagnostics>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupDiagnostics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerGroupDiagnostics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupDiagnostics>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerGroupDiagnostics IModelSerializable<ContainerGroupDiagnostics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupDiagnostics>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerGroupDiagnostics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerGroupDiagnostics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerGroupDiagnostics"/> to convert. </param>
        public static implicit operator RequestContent(ContainerGroupDiagnostics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerGroupDiagnostics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerGroupDiagnostics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerGroupDiagnostics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
