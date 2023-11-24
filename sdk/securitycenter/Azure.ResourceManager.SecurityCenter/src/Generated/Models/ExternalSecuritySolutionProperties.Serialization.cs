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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class ExternalSecuritySolutionProperties : IUtf8JsonSerializable, IJsonModel<ExternalSecuritySolutionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExternalSecuritySolutionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExternalSecuritySolutionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolutionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ExternalSecuritySolutionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceVendor))
            {
                writer.WritePropertyName("deviceVendor"u8);
                writer.WriteStringValue(DeviceVendor);
            }
            if (Optional.IsDefined(DeviceType))
            {
                writer.WritePropertyName("deviceType"u8);
                writer.WriteStringValue(DeviceType);
            }
            if (Optional.IsDefined(Workspace))
            {
                writer.WritePropertyName("workspace"u8);
                JsonSerializer.Serialize(writer, Workspace);
            }
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
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

        ExternalSecuritySolutionProperties IJsonModel<ExternalSecuritySolutionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolutionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ExternalSecuritySolutionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExternalSecuritySolutionProperties(document.RootElement, options);
        }

        internal static ExternalSecuritySolutionProperties DeserializeExternalSecuritySolutionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceVendor = default;
            Optional<string> deviceType = default;
            Optional<WritableSubResource> workspace = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceVendor"u8))
                {
                    deviceVendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceType"u8))
                {
                    deviceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspace = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExternalSecuritySolutionProperties(deviceVendor.Value, deviceType.Value, workspace, additionalProperties);
        }

        BinaryData IPersistableModel<ExternalSecuritySolutionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolutionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ExternalSecuritySolutionProperties)} does not support '{options.Format}' format.");
            }
        }

        ExternalSecuritySolutionProperties IPersistableModel<ExternalSecuritySolutionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolutionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExternalSecuritySolutionProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ExternalSecuritySolutionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExternalSecuritySolutionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
