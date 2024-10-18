// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class HelmArtifactProfile : IUtf8JsonSerializable, IJsonModel<HelmArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmArtifactProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HelmArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmArtifactProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(HelmPackageName))
            {
                writer.WritePropertyName("helmPackageName"u8);
                writer.WriteStringValue(HelmPackageName);
            }
            if (Optional.IsDefined(HelmPackageVersionRange))
            {
                writer.WritePropertyName("helmPackageVersionRange"u8);
                writer.WriteStringValue(HelmPackageVersionRange);
            }
            if (Optional.IsCollectionDefined(RegistryValuesPaths))
            {
                writer.WritePropertyName("registryValuesPaths"u8);
                writer.WriteStartArray();
                foreach (var item in RegistryValuesPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ImagePullSecretsValuesPaths))
            {
                writer.WritePropertyName("imagePullSecretsValuesPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ImagePullSecretsValuesPaths)
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
        }

        HelmArtifactProfile IJsonModel<HelmArtifactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmArtifactProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmArtifactProfile(document.RootElement, options);
        }

        internal static HelmArtifactProfile DeserializeHelmArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string helmPackageName = default;
            string helmPackageVersionRange = default;
            IList<string> registryValuesPaths = default;
            IList<string> imagePullSecretsValuesPaths = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("helmPackageName"u8))
                {
                    helmPackageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("helmPackageVersionRange"u8))
                {
                    helmPackageVersionRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryValuesPaths"u8))
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
                    registryValuesPaths = array;
                    continue;
                }
                if (property.NameEquals("imagePullSecretsValuesPaths"u8))
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
                    imagePullSecretsValuesPaths = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HelmArtifactProfile(helmPackageName, helmPackageVersionRange, registryValuesPaths ?? new ChangeTrackingList<string>(), imagePullSecretsValuesPaths ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HelmArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HelmArtifactProfile)} does not support writing '{options.Format}' format.");
            }
        }

        HelmArtifactProfile IPersistableModel<HelmArtifactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHelmArtifactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HelmArtifactProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HelmArtifactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
