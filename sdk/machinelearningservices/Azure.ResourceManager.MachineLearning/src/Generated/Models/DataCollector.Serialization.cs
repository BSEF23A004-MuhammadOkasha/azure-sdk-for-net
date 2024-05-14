// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DataCollector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("collections"u8);
            writer.WriteStartObject();
            foreach (var item in Collections)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
            if (Optional.IsDefined(RequestLogging))
            {
                if (RequestLogging != null)
                {
                    writer.WritePropertyName("requestLogging"u8);
                    writer.WriteObjectValue(RequestLogging);
                }
                else
                {
                    writer.WriteNull("requestLogging");
                }
            }
            if (Optional.IsDefined(RollingRate))
            {
                writer.WritePropertyName("rollingRate"u8);
                writer.WriteStringValue(RollingRate.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DataCollector DeserializeDataCollector(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, DataCollectionConfiguration> collections = default;
            Optional<RequestLogging> requestLogging = default;
            Optional<RollingRateType> rollingRate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collections"u8))
                {
                    Dictionary<string, DataCollectionConfiguration> dictionary = new Dictionary<string, DataCollectionConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DataCollectionConfiguration.DeserializeDataCollectionConfiguration(property0.Value));
                    }
                    collections = dictionary;
                    continue;
                }
                if (property.NameEquals("requestLogging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestLogging = null;
                        continue;
                    }
                    requestLogging = RequestLogging.DeserializeRequestLogging(property.Value);
                    continue;
                }
                if (property.NameEquals("rollingRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollingRate = new RollingRateType(property.Value.GetString());
                    continue;
                }
            }
            return new DataCollector(collections, requestLogging.Value, Optional.ToNullable(rollingRate));
        }
    }
}
