// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityHealthReportIssue : IUtf8JsonSerializable, IJsonModel<SecurityHealthReportIssue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityHealthReportIssue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityHealthReportIssue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportIssue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityHealthReportIssue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("issueKey"u8);
            writer.WriteStringValue(IssueKey);
            if (Optional.IsDefined(IssueName))
            {
                writer.WritePropertyName("issueName"u8);
                writer.WriteStringValue(IssueName);
            }
            if (Optional.IsCollectionDefined(SecurityValues))
            {
                writer.WritePropertyName("securityValues"u8);
                writer.WriteStartArray();
                foreach (var item in SecurityValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IssueDescription))
            {
                writer.WritePropertyName("issueDescription"u8);
                writer.WriteStringValue(IssueDescription);
            }
            if (Optional.IsDefined(RemediationSteps))
            {
                writer.WritePropertyName("remediationSteps"u8);
                writer.WriteStringValue(RemediationSteps);
            }
            if (Optional.IsDefined(RemediationScript))
            {
                writer.WritePropertyName("remediationScript"u8);
                writer.WriteStringValue(RemediationScript);
            }
            if (Optional.IsCollectionDefined(IssueAdditionalData))
            {
                writer.WritePropertyName("issueAdditionalData"u8);
                writer.WriteStartObject();
                foreach (var item in IssueAdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        SecurityHealthReportIssue IJsonModel<SecurityHealthReportIssue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportIssue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityHealthReportIssue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityHealthReportIssue(document.RootElement, options);
        }

        internal static SecurityHealthReportIssue DeserializeSecurityHealthReportIssue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string issueKey = default;
            Optional<string> issueName = default;
            Optional<IList<string>> securityValues = default;
            Optional<string> issueDescription = default;
            Optional<string> remediationSteps = default;
            Optional<string> remediationScript = default;
            Optional<IDictionary<string, string>> issueAdditionalData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issueKey"u8))
                {
                    issueKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issueName"u8))
                {
                    issueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    securityValues = array;
                    continue;
                }
                if (property.NameEquals("issueDescription"u8))
                {
                    issueDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediationSteps"u8))
                {
                    remediationSteps = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediationScript"u8))
                {
                    remediationScript = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issueAdditionalData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    issueAdditionalData = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityHealthReportIssue(issueKey, issueName.Value, Optional.ToList(securityValues), issueDescription.Value, remediationSteps.Value, remediationScript.Value, Optional.ToDictionary(issueAdditionalData), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityHealthReportIssue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportIssue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityHealthReportIssue)} does not support '{options.Format}' format.");
            }
        }

        SecurityHealthReportIssue IPersistableModel<SecurityHealthReportIssue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportIssue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityHealthReportIssue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityHealthReportIssue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityHealthReportIssue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
