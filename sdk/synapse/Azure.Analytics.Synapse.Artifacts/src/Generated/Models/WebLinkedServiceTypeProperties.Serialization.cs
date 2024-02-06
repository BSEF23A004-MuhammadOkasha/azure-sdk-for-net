// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(WebLinkedServiceTypePropertiesConverter))]
    public partial class WebLinkedServiceTypeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteObjectValue(Url);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            writer.WriteEndObject();
        }

        internal static WebLinkedServiceTypeProperties DeserializeWebLinkedServiceTypeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authenticationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Anonymous": return WebAnonymousAuthentication.DeserializeWebAnonymousAuthentication(element);
                    case "Basic": return WebBasicAuthentication.DeserializeWebBasicAuthentication(element);
                    case "ClientCertificate": return WebClientCertificateAuthentication.DeserializeWebClientCertificateAuthentication(element);
                }
            }
            return UnknownWebLinkedServiceTypeProperties.DeserializeUnknownWebLinkedServiceTypeProperties(element);
        }

        internal partial class WebLinkedServiceTypePropertiesConverter : JsonConverter<WebLinkedServiceTypeProperties>
        {
            public override void Write(Utf8JsonWriter writer, WebLinkedServiceTypeProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override WebLinkedServiceTypeProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebLinkedServiceTypeProperties(document.RootElement);
            }
        }
    }
}
