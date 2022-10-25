// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class ComponentSetup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(CustomSetupBaseType);
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("componentName");
            writer.WriteStringValue(ComponentName);
            if (Optional.IsDefined(LicenseKey))
            {
                writer.WritePropertyName("licenseKey");
                writer.WriteObjectValue(LicenseKey);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ComponentSetup DeserializeComponentSetup(JsonElement element)
        {
            string type = default;
            string componentName = default;
            Optional<SecretBase> licenseKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("componentName"))
                        {
                            componentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            licenseKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ComponentSetup(type, componentName, licenseKey.Value);
        }
    }
}
