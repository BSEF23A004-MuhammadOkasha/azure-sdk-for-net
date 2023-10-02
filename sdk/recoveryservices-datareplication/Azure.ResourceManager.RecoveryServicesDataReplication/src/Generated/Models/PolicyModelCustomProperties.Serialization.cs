// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class PolicyModelCustomProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }

        internal static PolicyModelCustomProperties DeserializePolicyModelCustomProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HyperVToAzStackHCI": return HyperVToAzStackHciPolicyModelCustomProperties.DeserializeHyperVToAzStackHciPolicyModelCustomProperties(element);
                    case "PolicyModelCustomProperties": return GeneralPolicyModelCustomProperties.DeserializeGeneralPolicyModelCustomProperties(element);
                    case "VMwareToAzStackHCI": return VMwareToAzStackHciPolicyModelCustomProperties.DeserializeVMwareToAzStackHciPolicyModelCustomProperties(element);
                }
            }
            return UnknownPolicyModelCustomProperties.DeserializeUnknownPolicyModelCustomProperties(element);
        }
    }
}
