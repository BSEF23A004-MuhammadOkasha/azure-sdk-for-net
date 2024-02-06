// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RoleAssignmentResourceFormatData : IUtf8JsonSerializable, IJsonModel<RoleAssignmentResourceFormatData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleAssignmentResourceFormatData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleAssignmentResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleAssignmentResourceFormatData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AssignmentName))
            {
                writer.WritePropertyName("assignmentName"u8);
                writer.WriteStringValue(AssignmentName);
            }
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Principals))
            {
                writer.WritePropertyName("principals"u8);
                writer.WriteStartArray();
                foreach (var item in Principals)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Profiles))
            {
                writer.WritePropertyName("profiles"u8);
                BinaryData data = ModelReaderWriter.Write(Profiles, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Interactions))
            {
                writer.WritePropertyName("interactions"u8);
                BinaryData data = ModelReaderWriter.Write(Interactions, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Links))
            {
                writer.WritePropertyName("links"u8);
                BinaryData data = ModelReaderWriter.Write(Links, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Kpis))
            {
                writer.WritePropertyName("kpis"u8);
                BinaryData data = ModelReaderWriter.Write(Kpis, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(SasPolicies))
            {
                writer.WritePropertyName("sasPolicies"u8);
                BinaryData data = ModelReaderWriter.Write(SasPolicies, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Connectors))
            {
                writer.WritePropertyName("connectors"u8);
                BinaryData data = ModelReaderWriter.Write(Connectors, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Views))
            {
                writer.WritePropertyName("views"u8);
                BinaryData data = ModelReaderWriter.Write(Views, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(RelationshipLinks))
            {
                writer.WritePropertyName("relationshipLinks"u8);
                BinaryData data = ModelReaderWriter.Write(RelationshipLinks, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Relationships))
            {
                writer.WritePropertyName("relationships"u8);
                BinaryData data = ModelReaderWriter.Write(Relationships, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(WidgetTypes))
            {
                writer.WritePropertyName("widgetTypes"u8);
                BinaryData data = ModelReaderWriter.Write(WidgetTypes, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(RoleAssignments))
            {
                writer.WritePropertyName("roleAssignments"u8);
                BinaryData data = ModelReaderWriter.Write(RoleAssignments, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ConflationPolicies))
            {
                writer.WritePropertyName("conflationPolicies"u8);
                BinaryData data = ModelReaderWriter.Write(ConflationPolicies, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Segments))
            {
                writer.WritePropertyName("segments"u8);
                BinaryData data = ModelReaderWriter.Write(Segments, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        RoleAssignmentResourceFormatData IJsonModel<RoleAssignmentResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleAssignmentResourceFormatData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleAssignmentResourceFormatData(document.RootElement, options);
        }

        internal static RoleAssignmentResourceFormatData DeserializeRoleAssignmentResourceFormatData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> tenantId = default;
            Optional<string> assignmentName = default;
            Optional<IDictionary<string, string>> displayName = default;
            Optional<IDictionary<string, string>> description = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<RoleType> role = default;
            Optional<IList<AssignmentPrincipal>> principals = default;
            Optional<ResourceSetDescription> profiles = default;
            Optional<ResourceSetDescription> interactions = default;
            Optional<ResourceSetDescription> links = default;
            Optional<ResourceSetDescription> kpis = default;
            Optional<ResourceSetDescription> sasPolicies = default;
            Optional<ResourceSetDescription> connectors = default;
            Optional<ResourceSetDescription> views = default;
            Optional<ResourceSetDescription> relationshipLinks = default;
            Optional<ResourceSetDescription> relationships = default;
            Optional<ResourceSetDescription> widgetTypes = default;
            Optional<ResourceSetDescription> roleAssignments = default;
            Optional<ResourceSetDescription> conflationPolicies = default;
            Optional<ResourceSetDescription> segments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("assignmentName"u8))
                        {
                            assignmentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = property0.Value.GetString().ToRoleType();
                            continue;
                        }
                        if (property0.NameEquals("principals"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AssignmentPrincipal> array = new List<AssignmentPrincipal>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AssignmentPrincipal.DeserializeAssignmentPrincipal(item));
                            }
                            principals = array;
                            continue;
                        }
                        if (property0.NameEquals("profiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            profiles = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("interactions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interactions = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            links = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kpis"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kpis = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sasPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasPolicies = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectors = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("views"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            views = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("relationshipLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            relationshipLinks = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("relationships"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            relationships = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("widgetTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            widgetTypes = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("roleAssignments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleAssignments = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("conflationPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conflationPolicies = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("segments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            segments = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
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
            return new RoleAssignmentResourceFormatData(id, name, type, systemData.Value, Optional.ToNullable(tenantId), assignmentName.Value, Optional.ToDictionary(displayName), Optional.ToDictionary(description), Optional.ToNullable(provisioningState), Optional.ToNullable(role), Optional.ToList(principals), profiles.Value, interactions.Value, links.Value, kpis.Value, sasPolicies.Value, connectors.Value, views.Value, relationshipLinks.Value, relationships.Value, widgetTypes.Value, roleAssignments.Value, conflationPolicies.Value, segments.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleAssignmentResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleAssignmentResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        RoleAssignmentResourceFormatData IPersistableModel<RoleAssignmentResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleAssignmentResourceFormatData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleAssignmentResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleAssignmentResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
