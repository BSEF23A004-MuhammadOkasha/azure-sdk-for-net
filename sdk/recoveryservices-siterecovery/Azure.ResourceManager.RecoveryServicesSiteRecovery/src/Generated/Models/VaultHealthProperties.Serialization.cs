// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VaultHealthProperties : IUtf8JsonSerializable, IJsonModel<VaultHealthProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VaultHealthProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<VaultHealthProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VaultErrors))
            {
                writer.WritePropertyName("vaultErrors"u8);
                writer.WriteStartArray();
                foreach (var item in VaultErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProtectedItemsHealth))
            {
                writer.WritePropertyName("protectedItemsHealth"u8);
                writer.WriteObjectValue(ProtectedItemsHealth);
            }
            if (Optional.IsDefined(FabricsHealth))
            {
                writer.WritePropertyName("fabricsHealth"u8);
                writer.WriteObjectValue(FabricsHealth);
            }
            if (Optional.IsDefined(ContainersHealth))
            {
                writer.WritePropertyName("containersHealth"u8);
                writer.WriteObjectValue(ContainersHealth);
            }
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

        VaultHealthProperties IJsonModel<VaultHealthProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VaultHealthProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultHealthProperties(document.RootElement, options);
        }

        internal static VaultHealthProperties DeserializeVaultHealthProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SiteRecoveryHealthError>> vaultErrors = default;
            Optional<ResourceHealthSummary> protectedItemsHealth = default;
            Optional<ResourceHealthSummary> fabricsHealth = default;
            Optional<ResourceHealthSummary> containersHealth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    vaultErrors = array;
                    continue;
                }
                if (property.NameEquals("protectedItemsHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("fabricsHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricsHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("containersHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containersHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VaultHealthProperties(Optional.ToList(vaultErrors), protectedItemsHealth.Value, fabricsHealth.Value, containersHealth.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<VaultHealthProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VaultHealthProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VaultHealthProperties IModel<VaultHealthProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VaultHealthProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVaultHealthProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<VaultHealthProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
