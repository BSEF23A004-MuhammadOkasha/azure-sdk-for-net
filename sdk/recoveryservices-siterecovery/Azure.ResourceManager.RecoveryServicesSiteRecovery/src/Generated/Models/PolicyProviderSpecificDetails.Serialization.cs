// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [ModelReaderProxy(typeof(UnknownPolicyProviderSpecificDetails))]
    public partial class PolicyProviderSpecificDetails : IUtf8JsonSerializable, IJsonModel<PolicyProviderSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyProviderSpecificDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<PolicyProviderSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        PolicyProviderSpecificDetails IJsonModel<PolicyProviderSpecificDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyProviderSpecificDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyProviderSpecificDetails(document.RootElement, options);
        }

        internal static PolicyProviderSpecificDetails DeserializePolicyProviderSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2APolicyDetails.DeserializeA2APolicyDetails(element);
                    case "HyperVReplica2012": return HyperVReplicaPolicyDetails.DeserializeHyperVReplicaPolicyDetails(element);
                    case "HyperVReplica2012R2": return HyperVReplicaBluePolicyDetails.DeserializeHyperVReplicaBluePolicyDetails(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzurePolicyDetails.DeserializeHyperVReplicaAzurePolicyDetails(element);
                    case "HyperVReplicaBasePolicyDetails": return HyperVReplicaBasePolicyDetails.DeserializeHyperVReplicaBasePolicyDetails(element);
                    case "InMage": return InMagePolicyDetails.DeserializeInMagePolicyDetails(element);
                    case "InMageAzureV2": return InMageAzureV2PolicyDetails.DeserializeInMageAzureV2PolicyDetails(element);
                    case "InMageBasePolicyDetails": return InMageBasePolicyDetails.DeserializeInMageBasePolicyDetails(element);
                    case "InMageRcm": return InMageRcmPolicyDetails.DeserializeInMageRcmPolicyDetails(element);
                    case "InMageRcmFailback": return InMageRcmFailbackPolicyDetails.DeserializeInMageRcmFailbackPolicyDetails(element);
                    case "VMwareCbt": return VMwareCbtPolicyDetails.DeserializeVMwareCbtPolicyDetails(element);
                }
            }
            return UnknownPolicyProviderSpecificDetails.DeserializeUnknownPolicyProviderSpecificDetails(element);
        }

        BinaryData IModel<PolicyProviderSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyProviderSpecificDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PolicyProviderSpecificDetails IModel<PolicyProviderSpecificDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyProviderSpecificDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePolicyProviderSpecificDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<PolicyProviderSpecificDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
