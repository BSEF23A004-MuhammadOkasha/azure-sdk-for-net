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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmIlrRegistrationContent : IUtf8JsonSerializable, IJsonModel<IaasVmIlrRegistrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmIlrRegistrationContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<IaasVmIlrRegistrationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(InitiatorName))
            {
                writer.WritePropertyName("initiatorName"u8);
                writer.WriteStringValue(InitiatorName);
            }
            if (Optional.IsDefined(RenewExistingRegistration))
            {
                writer.WritePropertyName("renewExistingRegistration"u8);
                writer.WriteBooleanValue(RenewExistingRegistration.Value);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        IaasVmIlrRegistrationContent IJsonModel<IaasVmIlrRegistrationContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IaasVmIlrRegistrationContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmIlrRegistrationContent(document.RootElement, options);
        }

        internal static IaasVmIlrRegistrationContent DeserializeIaasVmIlrRegistrationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryPointId = default;
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> initiatorName = default;
            Optional<bool> renewExistingRegistration = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initiatorName"u8))
                {
                    initiatorName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewExistingRegistration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewExistingRegistration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmIlrRegistrationContent(objectType, serializedAdditionalRawData, recoveryPointId.Value, virtualMachineId.Value, initiatorName.Value, Optional.ToNullable(renewExistingRegistration));
        }

        BinaryData IModel<IaasVmIlrRegistrationContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IaasVmIlrRegistrationContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IaasVmIlrRegistrationContent IModel<IaasVmIlrRegistrationContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IaasVmIlrRegistrationContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIaasVmIlrRegistrationContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<IaasVmIlrRegistrationContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
