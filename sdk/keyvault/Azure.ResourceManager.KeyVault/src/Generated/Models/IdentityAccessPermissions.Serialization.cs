// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class IdentityAccessPermissions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Keys))
            {
                writer.WritePropertyName("keys");
                writer.WriteStartArray();
                foreach (var item in Keys)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets");
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates");
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Storage))
            {
                writer.WritePropertyName("storage");
                writer.WriteStartArray();
                foreach (var item in Storage)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IdentityAccessPermissions DeserializeIdentityAccessPermissions(JsonElement element)
        {
            Optional<IList<IdentityAccessKeyPermission>> keys = default;
            Optional<IList<IdentityAccessSecretPermission>> secrets = default;
            Optional<IList<IdentityAccessCertificatePermission>> certificates = default;
            Optional<IList<IdentityAccessStoragePermission>> storage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IdentityAccessKeyPermission> array = new List<IdentityAccessKeyPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessKeyPermission(item.GetString()));
                    }
                    keys = array;
                    continue;
                }
                if (property.NameEquals("secrets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IdentityAccessSecretPermission> array = new List<IdentityAccessSecretPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessSecretPermission(item.GetString()));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("certificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IdentityAccessCertificatePermission> array = new List<IdentityAccessCertificatePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessCertificatePermission(item.GetString()));
                    }
                    certificates = array;
                    continue;
                }
                if (property.NameEquals("storage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IdentityAccessStoragePermission> array = new List<IdentityAccessStoragePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessStoragePermission(item.GetString()));
                    }
                    storage = array;
                    continue;
                }
            }
            return new IdentityAccessPermissions(Optional.ToList(keys), Optional.ToList(secrets), Optional.ToList(certificates), Optional.ToList(storage));
        }
    }
}
