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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmApplianceDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmApplianceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmApplianceDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmApplianceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmApplianceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InMageRcmApplianceDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricArmId))
            {
                writer.WritePropertyName("fabricArmId"u8);
                writer.WriteStringValue(FabricArmId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProcessServer))
            {
                writer.WritePropertyName("processServer"u8);
                writer.WriteObjectValue(ProcessServer);
            }
            if (options.Format != "W" && Optional.IsDefined(RcmProxy))
            {
                writer.WritePropertyName("rcmProxy"u8);
                writer.WriteObjectValue(RcmProxy);
            }
            if (options.Format != "W" && Optional.IsDefined(PushInstaller))
            {
                writer.WritePropertyName("pushInstaller"u8);
                writer.WriteObjectValue(PushInstaller);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationAgent))
            {
                writer.WritePropertyName("replicationAgent"u8);
                writer.WriteObjectValue(ReplicationAgent);
            }
            if (options.Format != "W" && Optional.IsDefined(ReprotectAgent))
            {
                writer.WritePropertyName("reprotectAgent"u8);
                writer.WriteObjectValue(ReprotectAgent);
            }
            if (options.Format != "W" && Optional.IsDefined(MarsAgent))
            {
                writer.WritePropertyName("marsAgent"u8);
                writer.WriteObjectValue(MarsAgent);
            }
            if (options.Format != "W" && Optional.IsDefined(Dra))
            {
                writer.WritePropertyName("dra"u8);
                writer.WriteObjectValue(Dra);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SwitchProviderBlockingErrorDetails))
            {
                writer.WritePropertyName("switchProviderBlockingErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in SwitchProviderBlockingErrorDetails)
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

        InMageRcmApplianceDetails IJsonModel<InMageRcmApplianceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmApplianceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InMageRcmApplianceDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmApplianceDetails(document.RootElement, options);
        }

        internal static InMageRcmApplianceDetails DeserializeInMageRcmApplianceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<ResourceIdentifier> fabricArmId = default;
            Optional<SiteRecoveryProcessServerDetails> processServer = default;
            Optional<RcmProxyDetails> rcmProxy = default;
            Optional<PushInstallerDetails> pushInstaller = default;
            Optional<ReplicationAgentDetails> replicationAgent = default;
            Optional<ReprotectAgentDetails> reprotectAgent = default;
            Optional<MarsAgentDetails> marsAgent = default;
            Optional<SiteRecoveryDraDetails> dra = default;
            Optional<IReadOnlyList<InMageRcmFabricSwitchProviderBlockingErrorDetails>> switchProviderBlockingErrorDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("processServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processServer = SiteRecoveryProcessServerDetails.DeserializeSiteRecoveryProcessServerDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("rcmProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rcmProxy = RcmProxyDetails.DeserializeRcmProxyDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("pushInstaller"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pushInstaller = PushInstallerDetails.DeserializePushInstallerDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("replicationAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationAgent = ReplicationAgentDetails.DeserializeReplicationAgentDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("reprotectAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reprotectAgent = ReprotectAgentDetails.DeserializeReprotectAgentDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("marsAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marsAgent = MarsAgentDetails.DeserializeMarsAgentDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("dra"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dra = SiteRecoveryDraDetails.DeserializeSiteRecoveryDraDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("switchProviderBlockingErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmFabricSwitchProviderBlockingErrorDetails> array = new List<InMageRcmFabricSwitchProviderBlockingErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmFabricSwitchProviderBlockingErrorDetails.DeserializeInMageRcmFabricSwitchProviderBlockingErrorDetails(item));
                    }
                    switchProviderBlockingErrorDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmApplianceDetails(id.Value, name.Value, fabricArmId.Value, processServer.Value, rcmProxy.Value, pushInstaller.Value, replicationAgent.Value, reprotectAgent.Value, marsAgent.Value, dra.Value, Optional.ToList(switchProviderBlockingErrorDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmApplianceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmApplianceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(InMageRcmApplianceDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmApplianceDetails IPersistableModel<InMageRcmApplianceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmApplianceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmApplianceDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(InMageRcmApplianceDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmApplianceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
