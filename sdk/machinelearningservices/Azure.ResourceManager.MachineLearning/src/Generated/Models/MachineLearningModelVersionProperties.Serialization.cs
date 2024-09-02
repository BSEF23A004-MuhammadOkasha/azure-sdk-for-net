// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningModelVersionProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningModelVersionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningModelVersionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningModelVersionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningModelVersionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningModelVersionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Flavors))
            {
                if (Flavors != null)
                {
                    writer.WritePropertyName("flavors"u8);
                    writer.WriteStartObject();
                    foreach (var item in Flavors)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value, options);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("flavors");
                }
            }
<<<<<<< HEAD
=======
            if (Optional.IsDefined(JobName))
            {
                if (JobName != null)
                {
                    writer.WritePropertyName("jobName"u8);
                    writer.WriteStringValue(JobName);
                }
                else
                {
                    writer.WriteNull("jobName");
                }
            }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            if (Optional.IsDefined(ModelType))
            {
                if (ModelType != null)
                {
                    writer.WritePropertyName("modelType"u8);
                    writer.WriteStringValue(ModelType);
                }
                else
                {
                    writer.WriteNull("modelType");
                }
            }
            if (Optional.IsDefined(ModelUri))
            {
                if (ModelUri != null)
                {
                    writer.WritePropertyName("modelUri"u8);
                    writer.WriteStringValue(ModelUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("modelUri");
                }
            }
            if (Optional.IsDefined(JobName))
            {
                if (JobName != null)
                {
                    writer.WritePropertyName("jobName"u8);
                    writer.WriteStringValue(JobName);
                }
                else
                {
                    writer.WriteNull("jobName");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Stage))
            {
                if (Stage != null)
                {
                    writer.WritePropertyName("stage"u8);
                    writer.WriteStringValue(Stage);
                }
                else
                {
                    writer.WriteNull("stage");
                }
            }
<<<<<<< HEAD
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
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

        MachineLearningModelVersionProperties IJsonModel<MachineLearningModelVersionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningModelVersionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningModelVersionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningModelVersionProperties(document.RootElement, options);
        }

        internal static MachineLearningModelVersionProperties DeserializeMachineLearningModelVersionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, MachineLearningFlavorData> flavors = default;
<<<<<<< HEAD
=======
            string jobName = default;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            string modelType = default;
            Uri modelUri = default;
            string jobName = default;
            RegistryAssetProvisioningState? provisioningState = default;
            string stage = default;
<<<<<<< HEAD
=======
            bool? isAnonymous = default;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            bool? isArchived = default;
            bool? isAnonymous = default;
            string description = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("flavors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        flavors = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningFlavorData> dictionary = new Dictionary<string, MachineLearningFlavorData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningFlavorData.DeserializeMachineLearningFlavorData(property0.Value, options));
                    }
                    flavors = dictionary;
                    continue;
                }
<<<<<<< HEAD
=======
                if (property.NameEquals("jobName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobName = null;
                        continue;
                    }
                    jobName = property.Value.GetString();
                    continue;
                }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                if (property.NameEquals("modelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelType = null;
                        continue;
                    }
                    modelType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelUri = null;
                        continue;
                    }
                    modelUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobName = null;
                        continue;
                    }
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new RegistryAssetProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stage = null;
                        continue;
                    }
                    stage = property.Value.GetString();
                    continue;
                }
<<<<<<< HEAD
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningModelVersionProperties(
                description,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
<<<<<<< HEAD
=======
                isAnonymous,
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                isArchived,
                isAnonymous,
                flavors ?? new ChangeTrackingDictionary<string, MachineLearningFlavorData>(),
<<<<<<< HEAD
=======
                jobName,
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                modelType,
                modelUri,
                jobName,
                provisioningState,
                stage);
        }

        BinaryData IPersistableModel<MachineLearningModelVersionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningModelVersionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningModelVersionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningModelVersionProperties IPersistableModel<MachineLearningModelVersionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningModelVersionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningModelVersionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningModelVersionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningModelVersionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
