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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class LoadBasedConfig : IUtf8JsonSerializable, IModelJsonSerializable<LoadBasedConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadBasedConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadBasedConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("minNodes"u8);
            writer.WriteNumberValue(MinNodes);
            writer.WritePropertyName("maxNodes"u8);
            writer.WriteNumberValue(MaxNodes);
            if (Optional.IsDefined(PollIntervalInSeconds))
            {
                writer.WritePropertyName("pollInterval"u8);
                writer.WriteNumberValue(PollIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(CooldownPeriod))
            {
                writer.WritePropertyName("cooldownPeriod"u8);
                writer.WriteNumberValue(CooldownPeriod.Value);
            }
            writer.WritePropertyName("scalingRules"u8);
            writer.WriteStartArray();
            foreach (var item in ScalingRules)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ScalingRule>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static LoadBasedConfig DeserializeLoadBasedConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minNodes = default;
            int maxNodes = default;
            Optional<int> pollInterval = default;
            Optional<int> cooldownPeriod = default;
            IList<ScalingRule> scalingRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minNodes"u8))
                {
                    minNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxNodes"u8))
                {
                    maxNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pollInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pollInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cooldownPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cooldownPeriod = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scalingRules"u8))
                {
                    List<ScalingRule> array = new List<ScalingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScalingRule.DeserializeScalingRule(item));
                    }
                    scalingRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoadBasedConfig(minNodes, maxNodes, Optional.ToNullable(pollInterval), Optional.ToNullable(cooldownPeriod), scalingRules, rawData);
        }

        LoadBasedConfig IModelJsonSerializable<LoadBasedConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBasedConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadBasedConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadBasedConfig IModelSerializable<LoadBasedConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadBasedConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoadBasedConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoadBasedConfig"/> to convert. </param>
        public static implicit operator RequestContent(LoadBasedConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoadBasedConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoadBasedConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadBasedConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
