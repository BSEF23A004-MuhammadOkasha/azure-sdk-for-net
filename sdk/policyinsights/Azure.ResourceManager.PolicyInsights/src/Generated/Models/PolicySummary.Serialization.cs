// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicySummary : IUtf8JsonSerializable, IJsonModel<PolicySummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicySummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicySummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ODataId != null)
            {
                writer.WritePropertyName("@odata.id"u8);
                writer.WriteStringValue(ODataId);
            }
            if (ODataContext != null)
            {
                writer.WritePropertyName("@odata.context"u8);
                writer.WriteStringValue(ODataContext);
            }
            if (Results != null)
            {
                writer.WritePropertyName("results"u8);
                writer.WriteObjectValue(Results);
            }
            if (!(PolicyAssignments is ChangeTrackingList<PolicyAssignmentSummary> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("policyAssignments"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyAssignments)
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

        PolicySummary IJsonModel<PolicySummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicySummary(document.RootElement, options);
        }

        internal static PolicySummary DeserializePolicySummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataId = default;
            string odataContext = default;
            PolicySummaryResults results = default;
            IReadOnlyList<PolicyAssignmentSummary> policyAssignments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.id"u8))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = PolicySummaryResults.DeserializePolicySummaryResults(property.Value, options);
                    continue;
                }
                if (property.NameEquals("policyAssignments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyAssignmentSummary> array = new List<PolicyAssignmentSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyAssignmentSummary.DeserializePolicyAssignmentSummary(item, options));
                    }
                    policyAssignments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicySummary(odataId, odataContext, results, policyAssignments ?? new ChangeTrackingList<PolicyAssignmentSummary>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicySummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicySummary)} does not support '{options.Format}' format.");
            }
        }

        PolicySummary IPersistableModel<PolicySummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicySummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicySummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicySummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
