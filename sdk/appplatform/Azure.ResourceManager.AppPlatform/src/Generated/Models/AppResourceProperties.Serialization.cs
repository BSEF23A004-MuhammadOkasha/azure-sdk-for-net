// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Public))
            {
                writer.WritePropertyName("public");
                writer.WriteBooleanValue(Public.Value);
            }
            if (Optional.IsCollectionDefined(AddonConfigs))
            {
                writer.WritePropertyName("addonConfigs");
                writer.WriteStartObject();
                foreach (var item in AddonConfigs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item0.Value);
#else
                        JsonSerializer.Serialize(writer, JsonDocument.Parse(item0.Value.ToString()).RootElement);
#endif
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn");
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(HttpsOnly))
            {
                writer.WritePropertyName("httpsOnly");
                writer.WriteBooleanValue(HttpsOnly.Value);
            }
            if (Optional.IsDefined(TemporaryDisk))
            {
                writer.WritePropertyName("temporaryDisk");
                writer.WriteObjectValue(TemporaryDisk);
            }
            if (Optional.IsDefined(PersistentDisk))
            {
                writer.WritePropertyName("persistentDisk");
                writer.WriteObjectValue(PersistentDisk);
            }
            if (Optional.IsCollectionDefined(CustomPersistentDisks))
            {
                writer.WritePropertyName("customPersistentDisks");
                writer.WriteStartArray();
                foreach (var item in CustomPersistentDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableEndToEndTls))
            {
                writer.WritePropertyName("enableEndToEndTLS");
                writer.WriteBooleanValue(EnableEndToEndTls.Value);
            }
            if (Optional.IsCollectionDefined(LoadedCertificates))
            {
                writer.WritePropertyName("loadedCertificates");
                writer.WriteStartArray();
                foreach (var item in LoadedCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AppResourceProperties DeserializeAppResourceProperties(JsonElement element)
        {
            Optional<bool> @public = default;
            Optional<Uri> url = default;
            Optional<IDictionary<string, IDictionary<string, BinaryData>>> addonConfigs = default;
            Optional<AppResourceProvisioningState> provisioningState = default;
            Optional<string> fqdn = default;
            Optional<bool> httpsOnly = default;
            Optional<TemporaryDisk> temporaryDisk = default;
            Optional<PersistentDisk> persistentDisk = default;
            Optional<IList<CustomPersistentDiskResource>> customPersistentDisks = default;
            Optional<bool> enableEndToEndTLS = default;
            Optional<IList<LoadedCertificate>> loadedCertificates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("public"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @public = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addonConfigs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, IDictionary<string, BinaryData>> dictionary = new Dictionary<string, IDictionary<string, BinaryData>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        Dictionary<string, BinaryData> dictionary0 = new Dictionary<string, BinaryData>();
                        foreach (var property1 in property0.Value.EnumerateObject())
                        {
                            dictionary0.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                        }
                        dictionary.Add(property0.Name, dictionary0);
                    }
                    addonConfigs = dictionary;
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new AppResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fqdn"))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    httpsOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("temporaryDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    temporaryDisk = TemporaryDisk.DeserializeTemporaryDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("persistentDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    persistentDisk = PersistentDisk.DeserializePersistentDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("customPersistentDisks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CustomPersistentDiskResource> array = new List<CustomPersistentDiskResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomPersistentDiskResource.DeserializeCustomPersistentDiskResource(item));
                    }
                    customPersistentDisks = array;
                    continue;
                }
                if (property.NameEquals("enableEndToEndTLS"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableEndToEndTLS = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("loadedCertificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LoadedCertificate> array = new List<LoadedCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadedCertificate.DeserializeLoadedCertificate(item));
                    }
                    loadedCertificates = array;
                    continue;
                }
            }
            return new AppResourceProperties(Optional.ToNullable(@public), url.Value, Optional.ToDictionary(addonConfigs), Optional.ToNullable(provisioningState), fqdn.Value, Optional.ToNullable(httpsOnly), temporaryDisk.Value, persistentDisk.Value, Optional.ToList(customPersistentDisks), Optional.ToNullable(enableEndToEndTLS), Optional.ToList(loadedCertificates));
        }
    }
}
