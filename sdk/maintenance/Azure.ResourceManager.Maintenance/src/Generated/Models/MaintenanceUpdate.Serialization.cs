// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    public partial class MaintenanceUpdate : IUtf8JsonSerializable, IJsonModel<MaintenanceUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaintenanceUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaintenanceUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MaintenanceScope.HasValue)
            {
                writer.WritePropertyName("maintenanceScope"u8);
                writer.WriteStringValue(MaintenanceScope.Value.ToString());
            }
            if (ImpactType.HasValue)
            {
                writer.WritePropertyName("impactType"u8);
                writer.WriteStringValue(ImpactType.Value.ToString());
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (ImpactDurationInSec.HasValue)
            {
                writer.WritePropertyName("impactDurationInSec"u8);
                writer.WriteNumberValue(ImpactDurationInSec.Value);
            }
            if (NotBefore.HasValue)
            {
                writer.WritePropertyName("notBefore"u8);
                writer.WriteStringValue(NotBefore.Value, "O");
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            writer.WriteEndObject();
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

        MaintenanceUpdate IJsonModel<MaintenanceUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceUpdate(document.RootElement, options);
        }

        internal static MaintenanceUpdate DeserializeMaintenanceUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MaintenanceScope? maintenanceScope = default;
            MaintenanceImpactType? impactType = default;
            MaintenanceUpdateStatus? status = default;
            int? impactDurationInSec = default;
            DateTimeOffset? notBefore = default;
            ResourceIdentifier resourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maintenanceScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceScope = new MaintenanceScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("impactType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    impactType = new MaintenanceImpactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MaintenanceUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("impactDurationInSec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    impactDurationInSec = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("notBefore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notBefore = property.Value.GetDateTimeOffset("O");
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
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaintenanceUpdate(
                maintenanceScope,
                impactType,
                status,
                impactDurationInSec,
                notBefore,
                resourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaintenanceUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaintenanceUpdate)} does not support '{options.Format}' format.");
            }
        }

        MaintenanceUpdate IPersistableModel<MaintenanceUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaintenanceUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaintenanceUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaintenanceUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
