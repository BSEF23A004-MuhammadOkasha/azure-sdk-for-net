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
    public partial class RulesEngineMatchCondition : IUtf8JsonSerializable, IModelJsonSerializable<RulesEngineMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RulesEngineMatchCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RulesEngineMatchCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("rulesEngineMatchVariable"u8);
            writer.WriteStringValue(RulesEngineMatchVariable.ToString());
            if (Optional.IsDefined(Selector))
            {
                writer.WritePropertyName("selector"u8);
                writer.WriteStringValue(Selector);
            }
            writer.WritePropertyName("rulesEngineOperator"u8);
            writer.WriteStringValue(RulesEngineOperator.ToString());
            if (Optional.IsDefined(IsNegateCondition))
            {
                writer.WritePropertyName("negateCondition"u8);
                writer.WriteBooleanValue(IsNegateCondition.Value);
            }
            writer.WritePropertyName("rulesEngineMatchValue"u8);
            writer.WriteStartArray();
            foreach (var item in RulesEngineMatchValue)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        internal static RulesEngineMatchCondition DeserializeRulesEngineMatchCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RulesEngineMatchVariable rulesEngineMatchVariable = default;
            Optional<string> selector = default;
            RulesEngineOperator rulesEngineOperator = default;
            Optional<bool> negateCondition = default;
            IList<string> rulesEngineMatchValue = default;
            Optional<IList<RulesEngineMatchTransform>> transforms = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rulesEngineMatchVariable"u8))
                {
                    rulesEngineMatchVariable = new RulesEngineMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rulesEngineOperator"u8))
                {
                    rulesEngineOperator = new RulesEngineOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rulesEngineMatchValue"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    rulesEngineMatchValue = array;
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RulesEngineMatchTransform> array = new List<RulesEngineMatchTransform>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RulesEngineMatchTransform(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RulesEngineMatchCondition(rulesEngineMatchVariable, selector.Value, rulesEngineOperator, Optional.ToNullable(negateCondition), rulesEngineMatchValue, Optional.ToList(transforms), rawData);
        }

        RulesEngineMatchCondition IModelJsonSerializable<RulesEngineMatchCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRulesEngineMatchCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RulesEngineMatchCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RulesEngineMatchCondition IModelSerializable<RulesEngineMatchCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRulesEngineMatchCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RulesEngineMatchCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RulesEngineMatchCondition"/> to convert. </param>
        public static implicit operator RequestContent(RulesEngineMatchCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RulesEngineMatchCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RulesEngineMatchCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRulesEngineMatchCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
