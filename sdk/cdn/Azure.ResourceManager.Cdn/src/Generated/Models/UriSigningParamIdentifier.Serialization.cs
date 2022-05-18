// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UriSigningParamIdentifier : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("paramIndicator");
            writer.WriteStringValue(ParamIndicator.ToString());
            writer.WritePropertyName("paramName");
            writer.WriteStringValue(ParamName);
            writer.WriteEndObject();
        }

        internal static UriSigningParamIdentifier DeserializeUriSigningParamIdentifier(JsonElement element)
        {
            ParamIndicator paramIndicator = default;
            string paramName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("paramIndicator"))
                {
                    paramIndicator = new ParamIndicator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("paramName"))
                {
                    paramName = property.Value.GetString();
                    continue;
                }
            }
            return new UriSigningParamIdentifier(paramIndicator, paramName);
        }
    }
}
