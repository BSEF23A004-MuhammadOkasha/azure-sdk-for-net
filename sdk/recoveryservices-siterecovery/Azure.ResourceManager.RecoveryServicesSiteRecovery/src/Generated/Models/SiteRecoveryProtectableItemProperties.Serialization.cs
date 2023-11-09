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
    public partial class SiteRecoveryProtectableItemProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryProtectableItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryProtectableItemProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SiteRecoveryProtectableItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionStatus))
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus);
            }
            if (Optional.IsDefined(ReplicationProtectedItemId))
            {
                writer.WritePropertyName("replicationProtectedItemId"u8);
                writer.WriteStringValue(ReplicationProtectedItemId);
            }
            if (Optional.IsDefined(RecoveryServicesProviderId))
            {
                writer.WritePropertyName("recoveryServicesProviderId"u8);
                writer.WriteStringValue(RecoveryServicesProviderId);
            }
            if (Optional.IsCollectionDefined(ProtectionReadinessErrors))
            {
                writer.WritePropertyName("protectionReadinessErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectionReadinessErrors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedReplicationProviders))
            {
                writer.WritePropertyName("supportedReplicationProviders"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedReplicationProviders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CustomDetails))
            {
                writer.WritePropertyName("customDetails"u8);
                writer.WriteObjectValue(CustomDetails);
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

        SiteRecoveryProtectableItemProperties IJsonModel<SiteRecoveryProtectableItemProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProtectableItemProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProtectableItemProperties(document.RootElement, options);
        }

        internal static SiteRecoveryProtectableItemProperties DeserializeSiteRecoveryProtectableItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<string> protectionStatus = default;
            Optional<ResourceIdentifier> replicationProtectedItemId = default;
            Optional<ResourceIdentifier> recoveryServicesProviderId = default;
            Optional<IReadOnlyList<string>> protectionReadinessErrors = default;
            Optional<IReadOnlyList<string>> supportedReplicationProviders = default;
            Optional<SiteRecoveryReplicationProviderSettings> customDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationProtectedItemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationProtectedItemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryServicesProviderId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionReadinessErrors"u8))
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
                    protectionReadinessErrors = array;
                    continue;
                }
                if (property.NameEquals("supportedReplicationProviders"u8))
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
                    supportedReplicationProviders = array;
                    continue;
                }
                if (property.NameEquals("customDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDetails = SiteRecoveryReplicationProviderSettings.DeserializeSiteRecoveryReplicationProviderSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryProtectableItemProperties(friendlyName.Value, protectionStatus.Value, replicationProtectedItemId.Value, recoveryServicesProviderId.Value, Optional.ToList(protectionReadinessErrors), Optional.ToList(supportedReplicationProviders), customDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SiteRecoveryProtectableItemProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProtectableItemProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SiteRecoveryProtectableItemProperties IModel<SiteRecoveryProtectableItemProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProtectableItemProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryProtectableItemProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SiteRecoveryProtectableItemProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
