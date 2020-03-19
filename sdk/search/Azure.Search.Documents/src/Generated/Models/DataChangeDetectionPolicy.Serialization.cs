// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class DataChangeDetectionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WriteEndObject();
        }

        internal static DataChangeDetectionPolicy DeserializeDataChangeDetectionPolicy(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.HighWaterMarkChangeDetectionPolicy": return HighWaterMarkChangeDetectionPolicy.DeserializeHighWaterMarkChangeDetectionPolicy(element);
                    case "#Microsoft.Azure.Search.SqlIntegratedChangeTrackingPolicy": return SqlIntegratedChangeTrackingPolicy.DeserializeSqlIntegratedChangeTrackingPolicy(element);
                }
            }
            DataChangeDetectionPolicy result = new DataChangeDetectionPolicy();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    result.ODataType = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
