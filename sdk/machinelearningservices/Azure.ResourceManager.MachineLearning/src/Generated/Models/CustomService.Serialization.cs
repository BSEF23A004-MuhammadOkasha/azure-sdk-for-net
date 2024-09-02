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
    public partial class CustomService : IUtf8JsonSerializable, IJsonModel<CustomService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomService>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomService)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteObjectValue(Image, options);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Docker))
            {
                if (Docker != null)
                {
                    writer.WritePropertyName("docker"u8);
                    writer.WriteObjectValue(Docker, options);
                }
                else
                {
                    writer.WriteNull("docker");
                }
            }
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Kernel))
            {
                writer.WritePropertyName("kernel"u8);
                writer.WriteObjectValue(Kernel, options);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        CustomService IJsonModel<CustomService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomService)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomService(document.RootElement, options);
        }

        internal static CustomService DeserializeCustomService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ImageSetting image = default;
            IDictionary<string, EnvironmentVariable> environmentVariables = default;
            DockerSetting docker = default;
            IList<ContainerEndpoint> endpoints = default;
            IList<VolumeDefinition> volumes = default;
            JupyterKernelConfig kernel = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    image = ImageSetting.DeserializeImageSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EnvironmentVariable> dictionary = new Dictionary<string, EnvironmentVariable>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EnvironmentVariable.DeserializeEnvironmentVariable(property0.Value, options));
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("docker"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        docker = null;
                        continue;
                    }
                    docker = DockerSetting.DeserializeDockerSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerEndpoint> array = new List<ContainerEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerEndpoint.DeserializeContainerEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("volumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VolumeDefinition> array = new List<VolumeDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VolumeDefinition.DeserializeVolumeDefinition(item, options));
                    }
                    volumes = array;
                    continue;
                }
                if (property.NameEquals("kernel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kernel = JupyterKernelConfig.DeserializeJupyterKernelConfig(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CustomService(
                name,
                image,
                environmentVariables ?? new ChangeTrackingDictionary<string, EnvironmentVariable>(),
                docker,
                endpoints ?? new ChangeTrackingList<ContainerEndpoint>(),
                volumes ?? new ChangeTrackingList<VolumeDefinition>(),
                kernel,
                additionalProperties);
        }

        BinaryData IPersistableModel<CustomService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomService)} does not support writing '{options.Format}' format.");
            }
        }

        CustomService IPersistableModel<CustomService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomService)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
