// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterSecurityProfile>, IPersistableModel<ManagedClusterSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterSecurityProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterSecurityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Defender))
            {
                writer.WritePropertyName("defender"u8);
                writer.WriteObjectValue(Defender);
            }
            if (Optional.IsDefined(AzureKeyVaultKms))
            {
                writer.WritePropertyName("azureKeyVaultKms"u8);
                writer.WriteObjectValue(AzureKeyVaultKms);
            }
            if (Optional.IsDefined(WorkloadIdentity))
            {
                writer.WritePropertyName("workloadIdentity"u8);
                writer.WriteObjectValue(WorkloadIdentity);
            }
            if (Optional.IsDefined(ImageCleaner))
            {
                writer.WritePropertyName("imageCleaner"u8);
                writer.WriteObjectValue(ImageCleaner);
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

        ManagedClusterSecurityProfile IJsonModel<ManagedClusterSecurityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfile(document.RootElement, options);
        }

        internal static ManagedClusterSecurityProfile DeserializeManagedClusterSecurityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedClusterSecurityProfileDefender> defender = default;
            Optional<ManagedClusterSecurityProfileKeyVaultKms> azureKeyVaultKms = default;
            Optional<ManagedClusterSecurityProfileWorkloadIdentity> workloadIdentity = default;
            Optional<ManagedClusterSecurityProfileImageCleaner> imageCleaner = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defender"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defender = ManagedClusterSecurityProfileDefender.DeserializeManagedClusterSecurityProfileDefender(property.Value);
                    continue;
                }
                if (property.NameEquals("azureKeyVaultKms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureKeyVaultKms = ManagedClusterSecurityProfileKeyVaultKms.DeserializeManagedClusterSecurityProfileKeyVaultKms(property.Value);
                    continue;
                }
                if (property.NameEquals("workloadIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadIdentity = ManagedClusterSecurityProfileWorkloadIdentity.DeserializeManagedClusterSecurityProfileWorkloadIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("imageCleaner"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageCleaner = ManagedClusterSecurityProfileImageCleaner.DeserializeManagedClusterSecurityProfileImageCleaner(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterSecurityProfile(defender.Value, azureKeyVaultKms.Value, workloadIdentity.Value, imageCleaner.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Defender))
            {
                builder.Append("  defender:");
                AppendChildObject(builder, Defender, options, 2);
            }

            if (Optional.IsDefined(AzureKeyVaultKms))
            {
                builder.Append("  azureKeyVaultKms:");
                AppendChildObject(builder, AzureKeyVaultKms, options, 2);
            }

            if (Optional.IsDefined(WorkloadIdentity))
            {
                builder.Append("  workloadIdentity:");
                AppendChildObject(builder, WorkloadIdentity, options, 2);
            }

            if (Optional.IsDefined(ImageCleaner))
            {
                builder.Append("  imageCleaner:");
                AppendChildObject(builder, ImageCleaner, options, 2);
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<ManagedClusterSecurityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterSecurityProfile IPersistableModel<ManagedClusterSecurityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterSecurityProfile(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterSecurityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
