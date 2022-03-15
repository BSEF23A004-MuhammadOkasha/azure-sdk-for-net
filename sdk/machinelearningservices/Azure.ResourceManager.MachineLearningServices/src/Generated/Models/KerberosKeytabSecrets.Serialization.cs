// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class KerberosKeytabSecrets : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KerberosKeytab))
            {
                if (KerberosKeytab != null)
                {
                    writer.WritePropertyName("kerberosKeytab");
                    writer.WriteStringValue(KerberosKeytab);
                }
                else
                {
                    writer.WriteNull("kerberosKeytab");
                }
            }
            writer.WritePropertyName("secretsType");
            writer.WriteStringValue(SecretsType.ToString());
            writer.WriteEndObject();
        }

        internal static KerberosKeytabSecrets DeserializeKerberosKeytabSecrets(JsonElement element)
        {
            Optional<string> kerberosKeytab = default;
            SecretsType secretsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kerberosKeytab"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        kerberosKeytab = null;
                        continue;
                    }
                    kerberosKeytab = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
            }
            return new KerberosKeytabSecrets(secretsType, kerberosKeytab.Value);
        }
    }
}
