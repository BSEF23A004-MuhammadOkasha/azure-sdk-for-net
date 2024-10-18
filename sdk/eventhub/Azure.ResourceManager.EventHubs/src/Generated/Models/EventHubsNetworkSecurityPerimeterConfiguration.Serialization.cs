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

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNetworkSecurityPerimeterConfiguration : IUtf8JsonSerializable, IJsonModel<EventHubsNetworkSecurityPerimeterConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsNetworkSecurityPerimeterConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventHubsNetworkSecurityPerimeterConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ProvisioningIssues))
            {
                writer.WritePropertyName("provisioningIssues"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisioningIssues)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkSecurityPerimeter))
            {
                writer.WritePropertyName("networkSecurityPerimeter"u8);
                writer.WriteObjectValue(NetworkSecurityPerimeter, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceAssociation))
            {
                writer.WritePropertyName("resourceAssociation"u8);
                writer.WriteObjectValue(ResourceAssociation, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteObjectValue(Profile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(IsBackingResource))
            {
                writer.WritePropertyName("isBackingResource"u8);
                writer.WriteBooleanValue(IsBackingResource.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ApplicableFeatures))
            {
                writer.WritePropertyName("applicableFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicableFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ParentAssociationName))
            {
                writer.WritePropertyName("parentAssociationName"u8);
                writer.WriteStringValue(ParentAssociationName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            writer.WriteEndObject();
        }

        EventHubsNetworkSecurityPerimeterConfiguration IJsonModel<EventHubsNetworkSecurityPerimeterConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsNetworkSecurityPerimeterConfiguration(document.RootElement, options);
        }

        internal static EventHubsNetworkSecurityPerimeterConfiguration DeserializeEventHubsNetworkSecurityPerimeterConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            EventHubsNetworkSecurityPerimeterConfigurationProvisioningState? provisioningState = default;
            IList<EventHubsProvisioningIssue> provisioningIssues = default;
            EventHubsNetworkSecurityPerimeter networkSecurityPerimeter = default;
            EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation resourceAssociation = default;
            EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile profile = default;
            bool? isBackingResource = default;
            IReadOnlyList<string> applicableFeatures = default;
            string parentAssociationName = default;
            ResourceIdentifier sourceResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new EventHubsNetworkSecurityPerimeterConfigurationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningIssues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventHubsProvisioningIssue> array = new List<EventHubsProvisioningIssue>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventHubsProvisioningIssue.DeserializeEventHubsProvisioningIssue(item, options));
                            }
                            provisioningIssues = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityPerimeter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityPerimeter = EventHubsNetworkSecurityPerimeter.DeserializeEventHubsNetworkSecurityPerimeter(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceAssociation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceAssociation = EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation.DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("profile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            profile = EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile.DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isBackingResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isBackingResource = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("applicableFeatures"u8))
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
                            applicableFeatures = array;
                            continue;
                        }
                        if (property0.NameEquals("parentAssociationName"u8))
                        {
                            parentAssociationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
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
            return new EventHubsNetworkSecurityPerimeterConfiguration(
                id,
                name,
                type,
                systemData,
                provisioningState,
                provisioningIssues ?? new ChangeTrackingList<EventHubsProvisioningIssue>(),
                networkSecurityPerimeter,
                resourceAssociation,
                profile,
                isBackingResource,
                applicableFeatures ?? new ChangeTrackingList<string>(),
                parentAssociationName,
                sourceResourceId,
                location,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Location))
                {
                    builder.Append("  location: ");
                    builder.AppendLine($"'{Location.Value.ToString()}'");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningIssues), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningIssues: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ProvisioningIssues))
                {
                    if (ProvisioningIssues.Any())
                    {
                        builder.Append("    provisioningIssues: ");
                        builder.AppendLine("[");
                        foreach (var item in ProvisioningIssues)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    provisioningIssues: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkSecurityPerimeter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    networkSecurityPerimeter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetworkSecurityPerimeter))
                {
                    builder.Append("    networkSecurityPerimeter: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NetworkSecurityPerimeter, options, 4, false, "    networkSecurityPerimeter: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceAssociation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceAssociation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceAssociation))
                {
                    builder.Append("    resourceAssociation: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ResourceAssociation, options, 4, false, "    resourceAssociation: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Profile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    profile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Profile))
                {
                    builder.Append("    profile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Profile, options, 4, false, "    profile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsBackingResource), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isBackingResource: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsBackingResource))
                {
                    builder.Append("    isBackingResource: ");
                    var boolValue = IsBackingResource.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApplicableFeatures), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    applicableFeatures: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ApplicableFeatures))
                {
                    if (ApplicableFeatures.Any())
                    {
                        builder.Append("    applicableFeatures: ");
                        builder.AppendLine("[");
                        foreach (var item in ApplicableFeatures)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ParentAssociationName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    parentAssociationName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ParentAssociationName))
                {
                    builder.Append("    parentAssociationName: ");
                    if (ParentAssociationName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ParentAssociationName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ParentAssociationName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sourceResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceResourceId))
                {
                    builder.Append("    sourceResourceId: ");
                    builder.AppendLine($"'{SourceResourceId.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EventHubsNetworkSecurityPerimeterConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        EventHubsNetworkSecurityPerimeterConfiguration IPersistableModel<EventHubsNetworkSecurityPerimeterConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNetworkSecurityPerimeterConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubsNetworkSecurityPerimeterConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubsNetworkSecurityPerimeterConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsNetworkSecurityPerimeterConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
