// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAutomationRuleTriggeringLogic : IUtf8JsonSerializable, IJsonModel<SecurityInsightsAutomationRuleTriggeringLogic>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsAutomationRuleTriggeringLogic>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsAutomationRuleTriggeringLogic>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleTriggeringLogic>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecurityInsightsAutomationRuleTriggeringLogic)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeUtc"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            writer.WritePropertyName("triggersOn"u8);
            writer.WriteStringValue(TriggersOn.ToString());
            writer.WritePropertyName("triggersWhen"u8);
            writer.WriteStringValue(TriggersWhen.ToString());
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions"u8);
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteObjectValue(item);
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

        SecurityInsightsAutomationRuleTriggeringLogic IJsonModel<SecurityInsightsAutomationRuleTriggeringLogic>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleTriggeringLogic>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecurityInsightsAutomationRuleTriggeringLogic)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAutomationRuleTriggeringLogic(document.RootElement, options);
        }

        internal static SecurityInsightsAutomationRuleTriggeringLogic DeserializeSecurityInsightsAutomationRuleTriggeringLogic(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isEnabled = default;
            Optional<DateTimeOffset> expirationTimeUtc = default;
            TriggersOn triggersOn = default;
            TriggersWhen triggersWhen = default;
            Optional<IList<SecurityInsightsAutomationRuleCondition>> conditions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("expirationTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("triggersOn"u8))
                {
                    triggersOn = new TriggersOn(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggersWhen"u8))
                {
                    triggersWhen = new TriggersWhen(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("conditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAutomationRuleCondition> array = new List<SecurityInsightsAutomationRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsAutomationRuleCondition.DeserializeSecurityInsightsAutomationRuleCondition(item));
                    }
                    conditions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsAutomationRuleTriggeringLogic(isEnabled, Optional.ToNullable(expirationTimeUtc), triggersOn, triggersWhen, Optional.ToList(conditions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsAutomationRuleTriggeringLogic>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleTriggeringLogic>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SecurityInsightsAutomationRuleTriggeringLogic)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsAutomationRuleTriggeringLogic IPersistableModel<SecurityInsightsAutomationRuleTriggeringLogic>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleTriggeringLogic>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsAutomationRuleTriggeringLogic(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SecurityInsightsAutomationRuleTriggeringLogic)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsAutomationRuleTriggeringLogic>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
