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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderProduct : IUtf8JsonSerializable, IJsonModel<EdgeOrderProduct>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderProduct>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderProduct>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProduct>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EdgeOrderProduct)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteObjectValue(Description);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ImageInformation))
            {
                writer.WritePropertyName("imageInformation"u8);
                writer.WriteStartArray();
                foreach (var item in ImageInformation)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CostInformation))
            {
                writer.WritePropertyName("costInformation"u8);
                writer.WriteObjectValue(CostInformation);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailabilityInformation))
            {
                writer.WritePropertyName("availabilityInformation"u8);
                writer.WriteObjectValue(AvailabilityInformation);
            }
            if (options.Format != "W" && Optional.IsDefined(HierarchyInformation))
            {
                writer.WritePropertyName("hierarchyInformation"u8);
                writer.WriteObjectValue(HierarchyInformation);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FilterableProperties))
            {
                writer.WritePropertyName("filterableProperties"u8);
                writer.WriteStartArray();
                foreach (var item in FilterableProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Configurations))
            {
                writer.WritePropertyName("configurations"u8);
                writer.WriteStartArray();
                foreach (var item in Configurations)
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

        EdgeOrderProduct IJsonModel<EdgeOrderProduct>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProduct>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EdgeOrderProduct)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderProduct(document.RootElement, options);
        }

        internal static EdgeOrderProduct DeserializeEdgeOrderProduct(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<ProductDescription> description = default;
            Optional<IReadOnlyList<EdgeOrderProductImageInformation>> imageInformation = default;
            Optional<EdgeOrderProductCostInformation> costInformation = default;
            Optional<ProductAvailabilityInformation> availabilityInformation = default;
            Optional<HierarchyInformation> hierarchyInformation = default;
            Optional<IReadOnlyList<FilterableProperty>> filterableProperties = default;
            Optional<IReadOnlyList<ProductConfiguration>> configurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            description = ProductDescription.DeserializeProductDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("imageInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EdgeOrderProductImageInformation> array = new List<EdgeOrderProductImageInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EdgeOrderProductImageInformation.DeserializeEdgeOrderProductImageInformation(item));
                            }
                            imageInformation = array;
                            continue;
                        }
                        if (property0.NameEquals("costInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costInformation = EdgeOrderProductCostInformation.DeserializeEdgeOrderProductCostInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilityInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityInformation = ProductAvailabilityInformation.DeserializeProductAvailabilityInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hierarchyInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filterableProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FilterableProperty> array = new List<FilterableProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterableProperty.DeserializeFilterableProperty(item));
                            }
                            filterableProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("configurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ProductConfiguration> array = new List<ProductConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProductConfiguration.DeserializeProductConfiguration(item));
                            }
                            configurations = array;
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
            return new EdgeOrderProduct(displayName.Value, description.Value, Optional.ToList(imageInformation), costInformation.Value, availabilityInformation.Value, hierarchyInformation.Value, Optional.ToList(filterableProperties), Optional.ToList(configurations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderProduct>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProduct>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(EdgeOrderProduct)} does not support '{options.Format}' format.");
            }
        }

        EdgeOrderProduct IPersistableModel<EdgeOrderProduct>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProduct>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderProduct(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(EdgeOrderProduct)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderProduct>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
