// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTokenCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates");
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Passwords))
            {
                writer.WritePropertyName("passwords");
                writer.WriteStartArray();
                foreach (var item in Passwords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryTokenCredentials DeserializeContainerRegistryTokenCredentials(JsonElement element)
        {
            Optional<IList<ContainerRegistryTokenCertificate>> certificates = default;
            Optional<IList<ContainerRegistryTokenPassword>> passwords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContainerRegistryTokenCertificate> array = new List<ContainerRegistryTokenCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTokenCertificate.DeserializeContainerRegistryTokenCertificate(item));
                    }
                    certificates = array;
                    continue;
                }
                if (property.NameEquals("passwords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContainerRegistryTokenPassword> array = new List<ContainerRegistryTokenPassword>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTokenPassword.DeserializeContainerRegistryTokenPassword(item));
                    }
                    passwords = array;
                    continue;
                }
            }
            return new ContainerRegistryTokenCredentials(Optional.ToList(certificates), Optional.ToList(passwords));
        }
    }
}
