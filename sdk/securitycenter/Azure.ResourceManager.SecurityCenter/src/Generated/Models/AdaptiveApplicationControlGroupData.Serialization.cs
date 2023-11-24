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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class AdaptiveApplicationControlGroupData : IUtf8JsonSerializable, IJsonModel<AdaptiveApplicationControlGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdaptiveApplicationControlGroupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdaptiveApplicationControlGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AdaptiveApplicationControlGroupData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(EnforcementMode))
            {
                writer.WritePropertyName("enforcementMode"u8);
                writer.WriteStringValue(EnforcementMode.Value.ToString());
            }
            if (Optional.IsDefined(ProtectionMode))
            {
                writer.WritePropertyName("protectionMode"u8);
                writer.WriteObjectValue(ProtectionMode);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationStatus))
            {
                writer.WritePropertyName("configurationStatus"u8);
                writer.WriteStringValue(ConfigurationStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RecommendationStatus))
            {
                writer.WritePropertyName("recommendationStatus"u8);
                writer.WriteStringValue(RecommendationStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Issues))
            {
                writer.WritePropertyName("issues"u8);
                writer.WriteStartArray();
                foreach (var item in Issues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(SourceSystem))
            {
                writer.WritePropertyName("sourceSystem"u8);
                writer.WriteStringValue(SourceSystem.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VmRecommendations))
            {
                writer.WritePropertyName("vmRecommendations"u8);
                writer.WriteStartArray();
                foreach (var item in VmRecommendations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PathRecommendations))
            {
                writer.WritePropertyName("pathRecommendations"u8);
                writer.WriteStartArray();
                foreach (var item in PathRecommendations)
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

        AdaptiveApplicationControlGroupData IJsonModel<AdaptiveApplicationControlGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AdaptiveApplicationControlGroupData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdaptiveApplicationControlGroupData(document.RootElement, options);
        }

        internal static AdaptiveApplicationControlGroupData DeserializeAdaptiveApplicationControlGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AdaptiveApplicationControlEnforcementMode> enforcementMode = default;
            Optional<SecurityCenterFileProtectionMode> protectionMode = default;
            Optional<SecurityCenterConfigurationStatus> configurationStatus = default;
            Optional<RecommendationStatus> recommendationStatus = default;
            Optional<IReadOnlyList<AdaptiveApplicationControlIssueSummary>> issues = default;
            Optional<AdaptiveApplicationControlGroupSourceSystem> sourceSystem = default;
            Optional<IList<VmRecommendation>> vmRecommendations = default;
            Optional<IList<PathRecommendation>> pathRecommendations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("enforcementMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enforcementMode = new AdaptiveApplicationControlEnforcementMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("protectionMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protectionMode = SecurityCenterFileProtectionMode.DeserializeSecurityCenterFileProtectionMode(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("configurationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationStatus = new SecurityCenterConfigurationStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("recommendationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommendationStatus = new RecommendationStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("issues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AdaptiveApplicationControlIssueSummary> array = new List<AdaptiveApplicationControlIssueSummary>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AdaptiveApplicationControlIssueSummary.DeserializeAdaptiveApplicationControlIssueSummary(item));
                            }
                            issues = array;
                            continue;
                        }
                        if (property0.NameEquals("sourceSystem"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceSystem = new AdaptiveApplicationControlGroupSourceSystem(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmRecommendations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VmRecommendation> array = new List<VmRecommendation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VmRecommendation.DeserializeVmRecommendation(item));
                            }
                            vmRecommendations = array;
                            continue;
                        }
                        if (property0.NameEquals("pathRecommendations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PathRecommendation> array = new List<PathRecommendation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PathRecommendation.DeserializePathRecommendation(item));
                            }
                            pathRecommendations = array;
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
            return new AdaptiveApplicationControlGroupData(id, name, type, systemData.Value, Optional.ToNullable(enforcementMode), protectionMode.Value, Optional.ToNullable(configurationStatus), Optional.ToNullable(recommendationStatus), Optional.ToList(issues), Optional.ToNullable(sourceSystem), Optional.ToList(vmRecommendations), Optional.ToList(pathRecommendations), Optional.ToNullable(location), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdaptiveApplicationControlGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AdaptiveApplicationControlGroupData)} does not support '{options.Format}' format.");
            }
        }

        AdaptiveApplicationControlGroupData IPersistableModel<AdaptiveApplicationControlGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdaptiveApplicationControlGroupData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AdaptiveApplicationControlGroupData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdaptiveApplicationControlGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
