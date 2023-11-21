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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppBaseContainer : IUtf8JsonSerializable, IJsonModel<ContainerAppBaseContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppBaseContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppBaseContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBaseContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerAppBaseContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Args))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Args)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Env))
            {
                writer.WritePropertyName("env"u8);
                writer.WriteStartArray();
                foreach (var item in Env)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteObjectValue(Resources);
            }
            if (Optional.IsCollectionDefined(VolumeMounts))
            {
                writer.WritePropertyName("volumeMounts"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeMounts)
                {
                    writer.WriteObjectValue(item);
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
            writer.WriteEndObject();
        }

        ContainerAppBaseContainer IJsonModel<ContainerAppBaseContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBaseContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerAppBaseContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppBaseContainer(document.RootElement, options);
        }

        internal static ContainerAppBaseContainer DeserializeContainerAppBaseContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> image = default;
            Optional<string> name = default;
            Optional<IList<string>> command = default;
            Optional<IList<string>> args = default;
            Optional<IList<ContainerAppEnvironmentVariable>> env = default;
            Optional<AppContainerResources> resources = default;
            Optional<IList<ContainerAppVolumeMount>> volumeMounts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("command"u8))
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
                    command = array;
                    continue;
                }
                if (property.NameEquals("args"u8))
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
                    args = array;
                    continue;
                }
                if (property.NameEquals("env"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppEnvironmentVariable> array = new List<ContainerAppEnvironmentVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppEnvironmentVariable.DeserializeContainerAppEnvironmentVariable(item));
                    }
                    env = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resources = AppContainerResources.DeserializeAppContainerResources(property.Value);
                    continue;
                }
                if (property.NameEquals("volumeMounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppVolumeMount> array = new List<ContainerAppVolumeMount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppVolumeMount.DeserializeContainerAppVolumeMount(item));
                    }
                    volumeMounts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppBaseContainer(image.Value, name.Value, Optional.ToList(command), Optional.ToList(args), Optional.ToList(env), resources.Value, Optional.ToList(volumeMounts), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppBaseContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBaseContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerAppBaseContainer)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppBaseContainer IPersistableModel<ContainerAppBaseContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBaseContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppBaseContainer(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerAppBaseContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppBaseContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
