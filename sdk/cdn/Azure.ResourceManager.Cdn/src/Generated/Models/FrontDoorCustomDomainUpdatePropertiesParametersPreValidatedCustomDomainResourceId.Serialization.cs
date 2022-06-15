// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId DeserializeFrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new FrontDoorCustomDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId(id.Value);
        }
    }
}
