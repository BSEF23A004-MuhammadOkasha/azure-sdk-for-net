// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class KerberosCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kerberosKdcAddress");
            writer.WriteStringValue(KerberosKdcAddress);
            writer.WritePropertyName("kerberosPrincipal");
            writer.WriteStringValue(KerberosPrincipal);
            writer.WritePropertyName("kerberosRealm");
            writer.WriteStringValue(KerberosRealm);
            writer.WriteEndObject();
        }

        internal static KerberosCredentials DeserializeKerberosCredentials(JsonElement element)
        {
            string kerberosKdcAddress = default;
            string kerberosPrincipal = default;
            string kerberosRealm = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kerberosKdcAddress"))
                {
                    kerberosKdcAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kerberosPrincipal"))
                {
                    kerberosPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kerberosRealm"))
                {
                    kerberosRealm = property.Value.GetString();
                    continue;
                }
            }
            return new KerberosCredentials(kerberosKdcAddress, kerberosPrincipal, kerberosRealm);
        }
    }
}
