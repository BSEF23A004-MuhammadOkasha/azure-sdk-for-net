// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServiceFabricServicePatch : IUtf8JsonSerializable, IJsonModel<ServiceFabricServicePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricServicePatch>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ServiceFabricServicePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ETag))
                {
                    writer.WritePropertyName("etag"u8);
                    writer.WriteStringValue(ETag.Value.ToString());
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PlacementConstraints))
            {
                writer.WritePropertyName("placementConstraints"u8);
                writer.WriteStringValue(PlacementConstraints);
            }
            if (Optional.IsCollectionDefined(CorrelationScheme))
            {
                writer.WritePropertyName("correlationScheme"u8);
                writer.WriteStartArray();
                foreach (var item in CorrelationScheme)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceLoadMetrics))
            {
                writer.WritePropertyName("serviceLoadMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLoadMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServicePlacementPolicies))
            {
                writer.WritePropertyName("servicePlacementPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ServicePlacementPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultMoveCost))
            {
                writer.WritePropertyName("defaultMoveCost"u8);
                writer.WriteStringValue(DefaultMoveCost.Value.ToString());
            }
            if (Optional.IsDefined(ServiceKind))
            {
                writer.WritePropertyName("serviceKind"u8);
                writer.WriteStringValue(ServiceKind.Value.ToString());
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ServiceFabricServicePatch IJsonModel<ServiceFabricServicePatch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceFabricServicePatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricServicePatch(document.RootElement, options);
        }

        internal static ServiceFabricServicePatch DeserializeServiceFabricServicePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> placementConstraints = default;
            Optional<IList<ServiceCorrelationDescription>> correlationScheme = default;
            Optional<IList<ServiceLoadMetricDescription>> serviceLoadMetrics = default;
            Optional<IList<ServicePlacementPolicyDescription>> servicePlacementPolicies = default;
            Optional<ApplicationMoveCost> defaultMoveCost = default;
            Optional<ApplicationServiceKind> serviceKind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
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
                        if (property0.NameEquals("placementConstraints"u8))
                        {
                            placementConstraints = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlationScheme"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceCorrelationDescription> array = new List<ServiceCorrelationDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceCorrelationDescription.DeserializeServiceCorrelationDescription(item));
                            }
                            correlationScheme = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceLoadMetrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceLoadMetricDescription> array = new List<ServiceLoadMetricDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceLoadMetricDescription.DeserializeServiceLoadMetricDescription(item));
                            }
                            serviceLoadMetrics = array;
                            continue;
                        }
                        if (property0.NameEquals("servicePlacementPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServicePlacementPolicyDescription> array = new List<ServicePlacementPolicyDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServicePlacementPolicyDescription.DeserializeServicePlacementPolicyDescription(item));
                            }
                            servicePlacementPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultMoveCost"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultMoveCost = new ApplicationMoveCost(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceKind = new ApplicationServiceKind(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceFabricServicePatch(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, placementConstraints.Value, Optional.ToList(correlationScheme), Optional.ToList(serviceLoadMetrics), Optional.ToList(servicePlacementPolicies), Optional.ToNullable(defaultMoveCost), Optional.ToNullable(serviceKind), Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        BinaryData IModel<ServiceFabricServicePatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceFabricServicePatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServiceFabricServicePatch IModel<ServiceFabricServicePatch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceFabricServicePatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServiceFabricServicePatch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ServiceFabricServicePatch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
