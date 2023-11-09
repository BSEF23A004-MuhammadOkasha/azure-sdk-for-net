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
    public partial class A2AFabricSpecificLocationDetails : IUtf8JsonSerializable, IJsonModel<A2AFabricSpecificLocationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AFabricSpecificLocationDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<A2AFabricSpecificLocationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InitialPrimaryZone))
            {
                writer.WritePropertyName("initialPrimaryZone"u8);
                writer.WriteStringValue(InitialPrimaryZone);
            }
            if (Optional.IsDefined(InitialRecoveryZone))
            {
                writer.WritePropertyName("initialRecoveryZone"u8);
                writer.WriteStringValue(InitialRecoveryZone);
            }
            if (Optional.IsDefined(InitialPrimaryExtendedLocation))
            {
                writer.WritePropertyName("initialPrimaryExtendedLocation"u8);
                writer.WriteObjectValue(InitialPrimaryExtendedLocation);
            }
            if (Optional.IsDefined(InitialRecoveryExtendedLocation))
            {
                writer.WritePropertyName("initialRecoveryExtendedLocation"u8);
                writer.WriteObjectValue(InitialRecoveryExtendedLocation);
            }
            if (Optional.IsDefined(InitialPrimaryFabricLocation))
            {
                writer.WritePropertyName("initialPrimaryFabricLocation"u8);
                writer.WriteStringValue(InitialPrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(InitialRecoveryFabricLocation))
            {
                writer.WritePropertyName("initialRecoveryFabricLocation"u8);
                writer.WriteStringValue(InitialRecoveryFabricLocation.Value);
            }
            if (Optional.IsDefined(PrimaryZone))
            {
                writer.WritePropertyName("primaryZone"u8);
                writer.WriteStringValue(PrimaryZone);
            }
            if (Optional.IsDefined(RecoveryZone))
            {
                writer.WritePropertyName("recoveryZone"u8);
                writer.WriteStringValue(RecoveryZone);
            }
            if (Optional.IsDefined(PrimaryExtendedLocation))
            {
                writer.WritePropertyName("primaryExtendedLocation"u8);
                writer.WriteObjectValue(PrimaryExtendedLocation);
            }
            if (Optional.IsDefined(RecoveryExtendedLocation))
            {
                writer.WritePropertyName("recoveryExtendedLocation"u8);
                writer.WriteObjectValue(RecoveryExtendedLocation);
            }
            if (Optional.IsDefined(PrimaryFabricLocation))
            {
                writer.WritePropertyName("primaryFabricLocation"u8);
                writer.WriteStringValue(PrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(RecoveryFabricLocation))
            {
                writer.WritePropertyName("recoveryFabricLocation"u8);
                writer.WriteStringValue(RecoveryFabricLocation.Value);
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

        A2AFabricSpecificLocationDetails IJsonModel<A2AFabricSpecificLocationDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2AFabricSpecificLocationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AFabricSpecificLocationDetails(document.RootElement, options);
        }

        internal static A2AFabricSpecificLocationDetails DeserializeA2AFabricSpecificLocationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> initialPrimaryZone = default;
            Optional<string> initialRecoveryZone = default;
            Optional<SiteRecoveryExtendedLocation> initialPrimaryExtendedLocation = default;
            Optional<SiteRecoveryExtendedLocation> initialRecoveryExtendedLocation = default;
            Optional<AzureLocation> initialPrimaryFabricLocation = default;
            Optional<AzureLocation> initialRecoveryFabricLocation = default;
            Optional<string> primaryZone = default;
            Optional<string> recoveryZone = default;
            Optional<SiteRecoveryExtendedLocation> primaryExtendedLocation = default;
            Optional<SiteRecoveryExtendedLocation> recoveryExtendedLocation = default;
            Optional<AzureLocation> primaryFabricLocation = default;
            Optional<AzureLocation> recoveryFabricLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initialPrimaryZone"u8))
                {
                    initialPrimaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialRecoveryZone"u8))
                {
                    initialRecoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialPrimaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("initialRecoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("initialPrimaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialRecoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryZone"u8))
                {
                    primaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryZone"u8))
                {
                    recoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AFabricSpecificLocationDetails(initialPrimaryZone.Value, initialRecoveryZone.Value, initialPrimaryExtendedLocation.Value, initialRecoveryExtendedLocation.Value, Optional.ToNullable(initialPrimaryFabricLocation), Optional.ToNullable(initialRecoveryFabricLocation), primaryZone.Value, recoveryZone.Value, primaryExtendedLocation.Value, recoveryExtendedLocation.Value, Optional.ToNullable(primaryFabricLocation), Optional.ToNullable(recoveryFabricLocation), serializedAdditionalRawData);
        }

        BinaryData IModel<A2AFabricSpecificLocationDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2AFabricSpecificLocationDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        A2AFabricSpecificLocationDetails IModel<A2AFabricSpecificLocationDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2AFabricSpecificLocationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeA2AFabricSpecificLocationDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<A2AFabricSpecificLocationDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
