// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ServicePrincipalDatastoreSecrets : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientSecret))
            {
                if (ClientSecret != null)
                {
                    writer.WritePropertyName("clientSecret");
                    writer.WriteStringValue(ClientSecret);
                }
                else
                {
                    writer.WriteNull("clientSecret");
                }
            }
            writer.WritePropertyName("secretsType");
            writer.WriteStringValue(SecretsType.ToString());
            writer.WriteEndObject();
        }

        internal static ServicePrincipalDatastoreSecrets DeserializeServicePrincipalDatastoreSecrets(JsonElement element)
        {
            Optional<string> clientSecret = default;
            SecretsType secretsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientSecret"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientSecret = null;
                        continue;
                    }
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
            }
            return new ServicePrincipalDatastoreSecrets(secretsType, clientSecret.Value);
        }
    }
}
