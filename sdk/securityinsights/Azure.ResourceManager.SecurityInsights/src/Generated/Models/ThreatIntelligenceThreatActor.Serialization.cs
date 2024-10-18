// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceThreatActor : IUtf8JsonSerializable, IJsonModel<ThreatIntelligenceThreatActor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreatIntelligenceThreatActor>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ThreatIntelligenceThreatActor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceThreatActor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceThreatActor)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ThreatIntelligenceThreatActor IJsonModel<ThreatIntelligenceThreatActor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceThreatActor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceThreatActor)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceThreatActor(document.RootElement, options);
        }

        internal static ThreatIntelligenceThreatActor DeserializeThreatIntelligenceThreatActor(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TIObjectKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyDictionary<string, BinaryData> data = default;
            ThreatIntelligenceUserInfo createdBy = default;
            string source = default;
            DateTimeOffset? firstIngestedTimeUtc = default;
            DateTimeOffset? lastIngestedTimeUtc = default;
            Guid? ingestionRulesVersion = default;
            string lastUpdateMethod = default;
            ThreatIntelligenceUserInfo lastModifiedBy = default;
            DateTimeOffset? lastUpdatedDateTimeUtc = default;
            IReadOnlyList<RelationshipHint> relationshipHints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new TIObjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("data"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            data = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = ThreatIntelligenceUserInfo.DeserializeThreatIntelligenceUserInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firstIngestedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstIngestedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastIngestedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastIngestedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("ingestionRulesVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingestionRulesVersion = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateMethod"u8))
                        {
                            lastUpdateMethod = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedBy = ThreatIntelligenceUserInfo.DeserializeThreatIntelligenceUserInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedDateTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedDateTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("relationshipHints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RelationshipHint> array = new List<RelationshipHint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RelationshipHint.DeserializeRelationshipHint(item, options));
                            }
                            relationshipHints = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ThreatIntelligenceThreatActor(
                id,
                name,
                type,
                systemData,
                kind,
                data ?? new ChangeTrackingDictionary<string, BinaryData>(),
                createdBy,
                source,
                firstIngestedTimeUtc,
                lastIngestedTimeUtc,
                ingestionRulesVersion,
                lastUpdateMethod,
                lastModifiedBy,
                lastUpdatedDateTimeUtc,
                relationshipHints ?? new ChangeTrackingList<RelationshipHint>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  kind: ");
                builder.AppendLine($"'{Kind.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Data), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    data: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Data))
                {
                    if (Data.Any())
                    {
                        builder.Append("    data: ");
                        builder.AppendLine("{");
                        foreach (var item in Data)
                        {
                            builder.Append($"        '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"'{item.Value.ToString()}'");
                        }
                        builder.AppendLine("    }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    createdBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedBy))
                {
                    builder.Append("    createdBy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CreatedBy, options, 4, false, "    createdBy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Source), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    source: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Source))
                {
                    builder.Append("    source: ");
                    if (Source.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Source}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Source}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FirstIngestedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    firstIngestedTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FirstIngestedOn))
                {
                    builder.Append("    firstIngestedTimeUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(FirstIngestedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastIngestedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastIngestedTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastIngestedOn))
                {
                    builder.Append("    lastIngestedTimeUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastIngestedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IngestionRulesVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    ingestionRulesVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IngestionRulesVersion))
                {
                    builder.Append("    ingestionRulesVersion: ");
                    builder.AppendLine($"'{IngestionRulesVersion.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastUpdateMethod), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastUpdateMethod: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastUpdateMethod))
                {
                    builder.Append("    lastUpdateMethod: ");
                    if (LastUpdateMethod.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastUpdateMethod}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastUpdateMethod}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastModifiedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastModifiedBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastModifiedBy))
                {
                    builder.Append("    lastModifiedBy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LastModifiedBy, options, 4, false, "    lastModifiedBy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastUpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastUpdatedDateTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastUpdatedOn))
                {
                    builder.Append("    lastUpdatedDateTimeUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RelationshipHints), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    relationshipHints: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RelationshipHints))
                {
                    if (RelationshipHints.Any())
                    {
                        builder.Append("    relationshipHints: ");
                        builder.AppendLine("[");
                        foreach (var item in RelationshipHints)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    relationshipHints: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ThreatIntelligenceThreatActor>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceThreatActor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceThreatActor)} does not support writing '{options.Format}' format.");
            }
        }

        ThreatIntelligenceThreatActor IPersistableModel<ThreatIntelligenceThreatActor>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceThreatActor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreatIntelligenceThreatActor(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceThreatActor)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreatIntelligenceThreatActor>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
