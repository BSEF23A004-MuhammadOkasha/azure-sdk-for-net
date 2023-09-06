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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class TriggerSupportPackageContent : IUtf8JsonSerializable, IModelJsonSerializable<TriggerSupportPackageContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TriggerSupportPackageContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TriggerSupportPackageContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerSupportPackageContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MinimumTimeStamp))
            {
                writer.WritePropertyName("minimumTimeStamp"u8);
                writer.WriteStringValue(MinimumTimeStamp.Value, "O");
            }
            if (Optional.IsDefined(MaximumTimeStamp))
            {
                writer.WritePropertyName("maximumTimeStamp"u8);
                writer.WriteStringValue(MaximumTimeStamp.Value, "O");
            }
            if (Optional.IsDefined(Include))
            {
                writer.WritePropertyName("include"u8);
                writer.WriteStringValue(Include);
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

        internal static TriggerSupportPackageContent DeserializeTriggerSupportPackageContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> minimumTimeStamp = default;
            Optional<DateTimeOffset> maximumTimeStamp = default;
            Optional<string> include = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("minimumTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maximumTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("include"u8))
                        {
                            include = property0.Value.GetString();
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
            return new TriggerSupportPackageContent(id, name, type, systemData.Value, Optional.ToNullable(minimumTimeStamp), Optional.ToNullable(maximumTimeStamp), include.Value, rawData);
        }

        TriggerSupportPackageContent IModelJsonSerializable<TriggerSupportPackageContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerSupportPackageContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerSupportPackageContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TriggerSupportPackageContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerSupportPackageContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TriggerSupportPackageContent IModelSerializable<TriggerSupportPackageContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerSupportPackageContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTriggerSupportPackageContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TriggerSupportPackageContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TriggerSupportPackageContent"/> to convert. </param>
        public static implicit operator RequestContent(TriggerSupportPackageContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TriggerSupportPackageContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TriggerSupportPackageContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTriggerSupportPackageContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
