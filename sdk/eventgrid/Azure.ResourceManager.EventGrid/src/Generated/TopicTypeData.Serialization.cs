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
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class TopicTypeData : IUtf8JsonSerializable, IJsonModel<TopicTypeData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TopicTypeData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TopicTypeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicTypeData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ResourceRegionType))
            {
                writer.WritePropertyName("resourceRegionType"u8);
                writer.WriteStringValue(ResourceRegionType.Value.ToString());
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SupportedLocations))
            {
                writer.WritePropertyName("supportedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedLocations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SourceResourceFormat))
            {
                writer.WritePropertyName("sourceResourceFormat"u8);
                writer.WriteStringValue(SourceResourceFormat);
            }
            if (Optional.IsCollectionDefined(SupportedScopesForSource))
            {
                writer.WritePropertyName("supportedScopesForSource"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedScopesForSource)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AreRegionalAndGlobalSourcesSupported))
            {
                writer.WritePropertyName("areRegionalAndGlobalSourcesSupported"u8);
                writer.WriteBooleanValue(AreRegionalAndGlobalSourcesSupported.Value);
            }
            if (Optional.IsCollectionDefined(AdditionalEnforcedPermissions))
            {
                writer.WritePropertyName("additionalEnforcedPermissions"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalEnforcedPermissions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        TopicTypeData IJsonModel<TopicTypeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopicTypeData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTopicTypeData(document.RootElement, options);
        }

        internal static TopicTypeData DeserializeTopicTypeData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string provider = default;
            string displayName = default;
            string description = default;
            EventGridResourceRegionType? resourceRegionType = default;
            TopicTypeProvisioningState? provisioningState = default;
            IList<string> supportedLocations = default;
            string sourceResourceFormat = default;
            IList<TopicTypeSourceScope> supportedScopesForSource = default;
            bool? areRegionalAndGlobalSourcesSupported = default;
            IList<TopicTypeAdditionalEnforcedPermission> additionalEnforcedPermissions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceRegionType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceRegionType = new EventGridResourceRegionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new TopicTypeProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportedLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            supportedLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceFormat"u8))
                        {
                            sourceResourceFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportedScopesForSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TopicTypeSourceScope> array = new List<TopicTypeSourceScope>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new TopicTypeSourceScope(item.GetString()));
                            }
                            supportedScopesForSource = array;
                            continue;
                        }
                        if (property0.NameEquals("areRegionalAndGlobalSourcesSupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            areRegionalAndGlobalSourcesSupported = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("additionalEnforcedPermissions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TopicTypeAdditionalEnforcedPermission> array = new List<TopicTypeAdditionalEnforcedPermission>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TopicTypeAdditionalEnforcedPermission.DeserializeTopicTypeAdditionalEnforcedPermission(item, options));
                            }
                            additionalEnforcedPermissions = array;
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
            return new TopicTypeData(
                id,
                name,
                type,
                systemData,
                provider,
                displayName,
                description,
                resourceRegionType,
                provisioningState,
                supportedLocations ?? new ChangeTrackingList<string>(),
                sourceResourceFormat,
                supportedScopesForSource ?? new ChangeTrackingList<TopicTypeSourceScope>(),
                areRegionalAndGlobalSourcesSupported,
                additionalEnforcedPermissions ?? new ChangeTrackingList<TopicTypeAdditionalEnforcedPermission>(),
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Provider), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provider: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Provider))
                {
                    builder.Append("    provider: ");
                    if (Provider.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Provider}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Provider}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("    displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceRegionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceRegionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceRegionType))
                {
                    builder.Append("    resourceRegionType: ");
                    builder.AppendLine($"'{ResourceRegionType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedLocations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    supportedLocations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedLocations))
                {
                    if (SupportedLocations.Any())
                    {
                        builder.Append("    supportedLocations: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedLocations)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceResourceFormat), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sourceResourceFormat: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceResourceFormat))
                {
                    builder.Append("    sourceResourceFormat: ");
                    if (SourceResourceFormat.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceResourceFormat}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceResourceFormat}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedScopesForSource), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    supportedScopesForSource: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedScopesForSource))
                {
                    if (SupportedScopesForSource.Any())
                    {
                        builder.Append("    supportedScopesForSource: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedScopesForSource)
                        {
                            builder.AppendLine($"      '{item.ToString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AreRegionalAndGlobalSourcesSupported), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    areRegionalAndGlobalSourcesSupported: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AreRegionalAndGlobalSourcesSupported))
                {
                    builder.Append("    areRegionalAndGlobalSourcesSupported: ");
                    var boolValue = AreRegionalAndGlobalSourcesSupported.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdditionalEnforcedPermissions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    additionalEnforcedPermissions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AdditionalEnforcedPermissions))
                {
                    if (AdditionalEnforcedPermissions.Any())
                    {
                        builder.Append("    additionalEnforcedPermissions: ");
                        builder.AppendLine("[");
                        foreach (var item in AdditionalEnforcedPermissions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    additionalEnforcedPermissions: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<TopicTypeData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TopicTypeData)} does not support writing '{options.Format}' format.");
            }
        }

        TopicTypeData IPersistableModel<TopicTypeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopicTypeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTopicTypeData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TopicTypeData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TopicTypeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
