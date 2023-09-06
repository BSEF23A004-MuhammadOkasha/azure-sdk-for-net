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
    public partial class AutomaticRepairsPolicy : IUtf8JsonSerializable, IModelJsonSerializable<AutomaticRepairsPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomaticRepairsPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomaticRepairsPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomaticRepairsPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(GracePeriod))
            {
                writer.WritePropertyName("gracePeriod"u8);
                writer.WriteStringValue(GracePeriod);
            }
            if (Optional.IsDefined(RepairAction))
            {
                writer.WritePropertyName("repairAction"u8);
                writer.WriteStringValue(RepairAction.Value.ToString());
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

        internal static AutomaticRepairsPolicy DeserializeAutomaticRepairsPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> gracePeriod = default;
            Optional<RepairAction> repairAction = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gracePeriod"u8))
                {
                    gracePeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repairAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repairAction = new RepairAction(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomaticRepairsPolicy(Optional.ToNullable(enabled), gracePeriod.Value, Optional.ToNullable(repairAction), rawData);
        }

        AutomaticRepairsPolicy IModelJsonSerializable<AutomaticRepairsPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomaticRepairsPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomaticRepairsPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomaticRepairsPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomaticRepairsPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomaticRepairsPolicy IModelSerializable<AutomaticRepairsPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomaticRepairsPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomaticRepairsPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomaticRepairsPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomaticRepairsPolicy"/> to convert. </param>
        public static implicit operator RequestContent(AutomaticRepairsPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomaticRepairsPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomaticRepairsPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomaticRepairsPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
