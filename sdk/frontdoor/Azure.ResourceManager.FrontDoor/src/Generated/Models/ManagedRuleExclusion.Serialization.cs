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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ManagedRuleExclusion : IUtf8JsonSerializable, IModelJsonSerializable<ManagedRuleExclusion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedRuleExclusion>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedRuleExclusion>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable"u8);
            writer.WriteStringValue(MatchVariable.ToString());
            writer.WritePropertyName("selectorMatchOperator"u8);
            writer.WriteStringValue(SelectorMatchOperator.ToString());
            writer.WritePropertyName("selector"u8);
            writer.WriteStringValue(Selector);
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

        internal static ManagedRuleExclusion DeserializeManagedRuleExclusion(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedRuleExclusionMatchVariable matchVariable = default;
            ManagedRuleExclusionSelectorMatchOperator selectorMatchOperator = default;
            string selector = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"u8))
                {
                    matchVariable = new ManagedRuleExclusionMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectorMatchOperator"u8))
                {
                    selectorMatchOperator = new ManagedRuleExclusionSelectorMatchOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedRuleExclusion(matchVariable, selectorMatchOperator, selector, rawData);
        }

        ManagedRuleExclusion IModelJsonSerializable<ManagedRuleExclusion>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRuleExclusion(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedRuleExclusion>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedRuleExclusion IModelSerializable<ManagedRuleExclusion>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedRuleExclusion(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedRuleExclusion"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedRuleExclusion"/> to convert. </param>
        public static implicit operator RequestContent(ManagedRuleExclusion model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedRuleExclusion"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedRuleExclusion(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedRuleExclusion(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
