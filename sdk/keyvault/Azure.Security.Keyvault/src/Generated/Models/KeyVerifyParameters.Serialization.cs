// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Models
{
    public partial class KeyVerifyParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("alg");
            writer.WriteStringValue(Algorithm.ToString());
            writer.WritePropertyName("digest");
            writer.WriteBase64StringValue(Digest, "U");
            writer.WritePropertyName("value");
            writer.WriteBase64StringValue(Signature, "U");
            writer.WriteEndObject();
        }
    }
}
