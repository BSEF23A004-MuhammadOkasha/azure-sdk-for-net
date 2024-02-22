// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseTableLevelSharingProperties : IUtf8JsonSerializable, IJsonModel<SynapseTableLevelSharingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseTableLevelSharingProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseTableLevelSharingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseTableLevelSharingProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(TablesToInclude is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TablesToExclude is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("tablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExternalTablesToInclude is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("externalTablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExternalTablesToExclude is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("externalTablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(MaterializedViewsToInclude is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("materializedViewsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(MaterializedViewsToExclude is ChangeTrackingList<string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("materializedViewsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToExclude)
                {
                    writer.WriteStringValue(item);
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

        SynapseTableLevelSharingProperties IJsonModel<SynapseTableLevelSharingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseTableLevelSharingProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseTableLevelSharingProperties(document.RootElement, options);
        }

        internal static SynapseTableLevelSharingProperties DeserializeSynapseTableLevelSharingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> tablesToInclude = default;
            Optional<IList<string>> tablesToExclude = default;
            Optional<IList<string>> externalTablesToInclude = default;
            Optional<IList<string>> externalTablesToExclude = default;
            Optional<IList<string>> materializedViewsToInclude = default;
            Optional<IList<string>> materializedViewsToExclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tablesToInclude"u8))
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
                    tablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("tablesToExclude"u8))
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
                    tablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToInclude"u8))
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
                    externalTablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToExclude"u8))
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
                    externalTablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToInclude"u8))
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
                    materializedViewsToInclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToExclude"u8))
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
                    materializedViewsToExclude = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseTableLevelSharingProperties(Optional.ToList(tablesToInclude), Optional.ToList(tablesToExclude), Optional.ToList(externalTablesToInclude), Optional.ToList(externalTablesToExclude), Optional.ToList(materializedViewsToInclude), Optional.ToList(materializedViewsToExclude), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseTableLevelSharingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseTableLevelSharingProperties)} does not support '{options.Format}' format.");
            }
        }

        SynapseTableLevelSharingProperties IPersistableModel<SynapseTableLevelSharingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseTableLevelSharingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseTableLevelSharingProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseTableLevelSharingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
