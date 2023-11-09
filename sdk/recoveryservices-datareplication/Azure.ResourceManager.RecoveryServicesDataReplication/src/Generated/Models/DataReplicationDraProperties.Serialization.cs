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

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationDraProperties : IUtf8JsonSerializable, IJsonModel<DataReplicationDraProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationDraProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataReplicationDraProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CorrelationId))
                {
                    writer.WritePropertyName("correlationId"u8);
                    writer.WriteStringValue(CorrelationId);
                }
            }
            writer.WritePropertyName("machineId"u8);
            writer.WriteStringValue(MachineId);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("authenticationIdentity"u8);
            writer.WriteObjectValue(AuthenticationIdentity);
            writer.WritePropertyName("resourceAccessIdentity"u8);
            writer.WriteObjectValue(ResourceAccessIdentity);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(IsResponsive))
                {
                    writer.WritePropertyName("isResponsive"u8);
                    writer.WriteBooleanValue(IsResponsive.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LastHeartbeatOn))
                {
                    writer.WritePropertyName("lastHeartbeat"u8);
                    writer.WriteStringValue(LastHeartbeatOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(VersionNumber))
                {
                    writer.WritePropertyName("versionNumber"u8);
                    writer.WriteStringValue(VersionNumber);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(HealthErrors))
                {
                    writer.WritePropertyName("healthErrors"u8);
                    writer.WriteStartArray();
                    foreach (var item in HealthErrors)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WritePropertyName("customProperties"u8);
            writer.WriteObjectValue(CustomProperties);
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

        DataReplicationDraProperties IJsonModel<DataReplicationDraProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationDraProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationDraProperties(document.RootElement, options);
        }

        internal static DataReplicationDraProperties DeserializeDataReplicationDraProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> correlationId = default;
            string machineId = default;
            string machineName = default;
            DataReplicationIdentity authenticationIdentity = default;
            DataReplicationIdentity resourceAccessIdentity = default;
            Optional<bool> isResponsive = default;
            Optional<DateTimeOffset> lastHeartbeat = default;
            Optional<string> versionNumber = default;
            Optional<DataReplicationProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<DataReplicationHealthErrorInfo>> healthErrors = default;
            DraModelCustomProperties customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineId"u8))
                {
                    machineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationIdentity"u8))
                {
                    authenticationIdentity = DataReplicationIdentity.DeserializeDataReplicationIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceAccessIdentity"u8))
                {
                    resourceAccessIdentity = DataReplicationIdentity.DeserializeDataReplicationIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("isResponsive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isResponsive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("versionNumber"u8))
                {
                    versionNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataReplicationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationHealthErrorInfo> array = new List<DataReplicationHealthErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationHealthErrorInfo.DeserializeDataReplicationHealthErrorInfo(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = DraModelCustomProperties.DeserializeDraModelCustomProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataReplicationDraProperties(correlationId.Value, machineId, machineName, authenticationIdentity, resourceAccessIdentity, Optional.ToNullable(isResponsive), Optional.ToNullable(lastHeartbeat), versionNumber.Value, Optional.ToNullable(provisioningState), Optional.ToList(healthErrors), customProperties, serializedAdditionalRawData);
        }

        BinaryData IModel<DataReplicationDraProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationDraProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataReplicationDraProperties IModel<DataReplicationDraProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationDraProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataReplicationDraProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataReplicationDraProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
