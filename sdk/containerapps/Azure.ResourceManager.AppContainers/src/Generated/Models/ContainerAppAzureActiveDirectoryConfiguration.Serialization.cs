// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppAzureActiveDirectoryConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppAzureActiveDirectoryConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppAzureActiveDirectoryConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration"u8);
                BinaryData data = ModelReaderWriter.Write(Registration, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                BinaryData data = ModelReaderWriter.Write(Login, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Validation))
            {
                writer.WritePropertyName("validation"u8);
                BinaryData data = ModelReaderWriter.Write(Validation, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(IsAutoProvisioned))
            {
                writer.WritePropertyName("isAutoProvisioned"u8);
                writer.WriteBooleanValue(IsAutoProvisioned.Value);
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

        ContainerAppAzureActiveDirectoryConfiguration IJsonModel<ContainerAppAzureActiveDirectoryConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAzureActiveDirectoryConfiguration(document.RootElement, options);
        }

        internal static ContainerAppAzureActiveDirectoryConfiguration DeserializeContainerAppAzureActiveDirectoryConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<ContainerAppAzureActiveDirectoryRegistrationConfiguration> registration = default;
            Optional<ContainerAppAzureActiveDirectoryLoginConfiguration> login = default;
            Optional<ContainerAppAzureActiveDirectoryValidationConfiguration> validation = default;
            Optional<bool> isAutoProvisioned = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registration = ContainerAppAzureActiveDirectoryRegistrationConfiguration.DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    login = ContainerAppAzureActiveDirectoryLoginConfiguration.DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("validation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validation = ContainerAppAzureActiveDirectoryValidationConfiguration.DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("isAutoProvisioned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProvisioned = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppAzureActiveDirectoryConfiguration(Optional.ToNullable(enabled), registration.Value, login.Value, validation.Value, Optional.ToNullable(isAutoProvisioned), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppAzureActiveDirectoryConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppAzureActiveDirectoryConfiguration IPersistableModel<ContainerAppAzureActiveDirectoryConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppAzureActiveDirectoryConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppAzureActiveDirectoryConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
