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
    public partial class UpdateReplicationProtectedItemProperties : IUtf8JsonSerializable, IJsonModel<UpdateReplicationProtectedItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateReplicationProtectedItemProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<UpdateReplicationProtectedItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryAzureVmName))
            {
                writer.WritePropertyName("recoveryAzureVMName"u8);
                writer.WriteStringValue(RecoveryAzureVmName);
            }
            if (Optional.IsDefined(RecoveryAzureVmSize))
            {
                writer.WritePropertyName("recoveryAzureVMSize"u8);
                writer.WriteStringValue(RecoveryAzureVmSize);
            }
            if (Optional.IsDefined(SelectedRecoveryAzureNetworkId))
            {
                writer.WritePropertyName("selectedRecoveryAzureNetworkId"u8);
                writer.WriteStringValue(SelectedRecoveryAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedTfoAzureNetworkId))
            {
                writer.WritePropertyName("selectedTfoAzureNetworkId"u8);
                writer.WriteStringValue(SelectedTfoAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedSourceNicId))
            {
                writer.WritePropertyName("selectedSourceNicId"u8);
                writer.WriteStringValue(SelectedSourceNicId);
            }
            if (Optional.IsDefined(EnableRdpOnTargetOption))
            {
                writer.WritePropertyName("enableRdpOnTargetOption"u8);
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails);
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

        UpdateReplicationProtectedItemProperties IJsonModel<UpdateReplicationProtectedItemProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UpdateReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateReplicationProtectedItemProperties(document.RootElement, options);
        }

        internal static UpdateReplicationProtectedItemProperties DeserializeUpdateReplicationProtectedItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryAzureVmName = default;
            Optional<string> recoveryAzureVmSize = default;
            Optional<ResourceIdentifier> selectedRecoveryAzureNetworkId = default;
            Optional<ResourceIdentifier> selectedTfoAzureNetworkId = default;
            Optional<string> selectedSourceNicId = default;
            Optional<string> enableRdpOnTargetOption = default;
            Optional<IList<VmNicContentDetails>> vmNics = default;
            Optional<SiteRecoveryLicenseType> licenseType = default;
            Optional<ResourceIdentifier> recoveryAvailabilitySetId = default;
            Optional<UpdateReplicationProtectedItemProviderContent> providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryAzureVMName"u8))
                {
                    recoveryAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureVMSize"u8))
                {
                    recoveryAzureVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectedRecoveryAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedRecoveryAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectedTfoAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedTfoAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectedSourceNicId"u8))
                {
                    selectedSourceNicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableRdpOnTargetOption"u8))
                {
                    enableRdpOnTargetOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmNicContentDetails> array = new List<VmNicContentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmNicContentDetails.DeserializeVmNicContentDetails(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SiteRecoveryLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = UpdateReplicationProtectedItemProviderContent.DeserializeUpdateReplicationProtectedItemProviderContent(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpdateReplicationProtectedItemProperties(recoveryAzureVmName.Value, recoveryAzureVmSize.Value, selectedRecoveryAzureNetworkId.Value, selectedTfoAzureNetworkId.Value, selectedSourceNicId.Value, enableRdpOnTargetOption.Value, Optional.ToList(vmNics), Optional.ToNullable(licenseType), recoveryAvailabilitySetId.Value, providerSpecificDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<UpdateReplicationProtectedItemProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UpdateReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        UpdateReplicationProtectedItemProperties IModel<UpdateReplicationProtectedItemProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UpdateReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUpdateReplicationProtectedItemProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<UpdateReplicationProtectedItemProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
