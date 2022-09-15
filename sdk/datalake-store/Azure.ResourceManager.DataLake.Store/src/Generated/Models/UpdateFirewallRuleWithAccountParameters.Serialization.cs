// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLake.Store.Models
{
    public partial class UpdateFirewallRuleWithAccountParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartIPAddress))
            {
                writer.WritePropertyName("startIpAddress");
                writer.WriteStringValue(StartIPAddress);
            }
            if (Optional.IsDefined(EndIPAddress))
            {
                writer.WritePropertyName("endIpAddress");
                writer.WriteStringValue(EndIPAddress);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
