// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class WebApplicationRuleMatchCondition : IUtf8JsonSerializable, IJsonModel<WebApplicationRuleMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebApplicationRuleMatchCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebApplicationRuleMatchCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationRuleMatchCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable"u8);
            writer.WriteStringValue(MatchVariable.ToString());
            if (Selector != null)
            {
                writer.WritePropertyName("selector"u8);
                writer.WriteStringValue(Selector);
            }
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToString());
            if (IsNegateCondition.HasValue)
            {
                writer.WritePropertyName("negateCondition"u8);
                writer.WriteBooleanValue(IsNegateCondition.Value);
            }
            writer.WritePropertyName("matchValue"u8);
            writer.WriteStartArray();
            foreach (var item in MatchValue)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (!(Transforms is ChangeTrackingList<WebApplicationRuleMatchTransformType> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        WebApplicationRuleMatchCondition IJsonModel<WebApplicationRuleMatchCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationRuleMatchCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationRuleMatchCondition(document.RootElement, options);
        }

        internal static WebApplicationRuleMatchCondition DeserializeWebApplicationRuleMatchCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebApplicationRuleMatchVariable matchVariable = default;
            string selector = default;
            WebApplicationRuleMatchOperator @operator = default;
            bool? negateCondition = default;
            IList<string> matchValue = default;
            IList<WebApplicationRuleMatchTransformType> transforms = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"u8))
                {
                    matchVariable = new WebApplicationRuleMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new WebApplicationRuleMatchOperator(property.Value.GetString());
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
                if (property.NameEquals("matchValue"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    matchValue = array;
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebApplicationRuleMatchTransformType> array = new List<WebApplicationRuleMatchTransformType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WebApplicationRuleMatchTransformType(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebApplicationRuleMatchCondition(
                matchVariable,
                selector,
                @operator,
                negateCondition,
                matchValue,
                transforms ?? new ChangeTrackingList<WebApplicationRuleMatchTransformType>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebApplicationRuleMatchCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebApplicationRuleMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        WebApplicationRuleMatchCondition IPersistableModel<WebApplicationRuleMatchCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebApplicationRuleMatchCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebApplicationRuleMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebApplicationRuleMatchCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
