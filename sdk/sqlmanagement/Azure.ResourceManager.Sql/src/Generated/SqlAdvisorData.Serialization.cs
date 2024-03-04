// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlAdvisorData : IUtf8JsonSerializable, IJsonModel<SqlAdvisorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlAdvisorData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlAdvisorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAdvisorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAdvisorData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AdvisorStatus))
            {
                writer.WritePropertyName("advisorStatus"u8);
                writer.WriteStringValue(AdvisorStatus.Value.ToSerialString());
            }
            if (Optional.IsDefined(AutoExecuteStatus))
            {
                writer.WritePropertyName("autoExecuteStatus"u8);
                writer.WriteStringValue(AutoExecuteStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(AutoExecuteStatusInheritedFrom))
            {
                writer.WritePropertyName("autoExecuteStatusInheritedFrom"u8);
                writer.WriteStringValue(AutoExecuteStatusInheritedFrom.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(RecommendationsStatus))
            {
                writer.WritePropertyName("recommendationsStatus"u8);
                writer.WriteStringValue(RecommendationsStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(LastCheckedOn))
            {
                writer.WritePropertyName("lastChecked"u8);
                writer.WriteStringValue(LastCheckedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RecommendedActions))
            {
                writer.WritePropertyName("recommendedActions"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendedActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SqlAdvisorData IJsonModel<SqlAdvisorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAdvisorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAdvisorData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAdvisorData(document.RootElement, options);
        }

        internal static SqlAdvisorData DeserializeSqlAdvisorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SqlAdvisorStatus? advisorStatus = default;
            AutoExecuteStatus? autoExecuteStatus = default;
            AutoExecuteStatusInheritedFrom? autoExecuteStatusInheritedFrom = default;
            string recommendationsStatus = default;
            DateTimeOffset? lastChecked = default;
            IReadOnlyList<RecommendedActionData> recommendedActions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("advisorStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            advisorStatus = property0.Value.GetString().ToSqlAdvisorStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoExecuteStatus = property0.Value.GetString().ToAutoExecuteStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatusInheritedFrom"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoExecuteStatusInheritedFrom = property0.Value.GetString().ToAutoExecuteStatusInheritedFrom();
                            continue;
                        }
                        if (property0.NameEquals("recommendationsStatus"u8))
                        {
                            recommendationsStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastChecked"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastChecked = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recommendedActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendedActionData> array = new List<RecommendedActionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionData.DeserializeRecommendedActionData(item, options));
                            }
                            recommendedActions = array;
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
            return new SqlAdvisorData(
                id,
                name,
                type,
                systemData,
                kind,
                location,
                advisorStatus,
                autoExecuteStatus,
                autoExecuteStatusInheritedFrom,
                recommendationsStatus,
                lastChecked,
                recommendedActions ?? new ChangeTrackingList<RecommendedActionData>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlAdvisorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAdvisorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlAdvisorData)} does not support '{options.Format}' format.");
            }
        }

        SqlAdvisorData IPersistableModel<SqlAdvisorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAdvisorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlAdvisorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlAdvisorData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlAdvisorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
