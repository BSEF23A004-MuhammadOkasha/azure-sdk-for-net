// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SapOpenHubSourceConverter))]
    public partial class SapOpenHubSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExcludeLastRequest))
            {
                writer.WritePropertyName("excludeLastRequest"u8);
                writer.WriteObjectValue(ExcludeLastRequest);
            }
            if (Optional.IsDefined(BaseRequestId))
            {
                writer.WritePropertyName("baseRequestId"u8);
                writer.WriteObjectValue(BaseRequestId);
            }
            if (Optional.IsDefined(CustomRfcReadTableFunctionModule))
            {
                writer.WritePropertyName("customRfcReadTableFunctionModule"u8);
                writer.WriteObjectValue(CustomRfcReadTableFunctionModule);
            }
            if (Optional.IsDefined(SapDataColumnDelimiter))
            {
                writer.WritePropertyName("sapDataColumnDelimiter"u8);
                writer.WriteObjectValue(SapDataColumnDelimiter);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout"u8);
                writer.WriteObjectValue(QueryTimeout);
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SapOpenHubSource DeserializeSapOpenHubSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> excludeLastRequest = default;
            Optional<object> baseRequestId = default;
            Optional<object> customRfcReadTableFunctionModule = default;
            Optional<object> sapDataColumnDelimiter = default;
            Optional<object> queryTimeout = default;
            Optional<object> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("excludeLastRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeLastRequest = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("baseRequestId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseRequestId = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("customRfcReadTableFunctionModule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customRfcReadTableFunctionModule = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sapDataColumnDelimiter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sapDataColumnDelimiter = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SapOpenHubSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, queryTimeout.Value, additionalColumns.Value, excludeLastRequest.Value, baseRequestId.Value, customRfcReadTableFunctionModule.Value, sapDataColumnDelimiter.Value);
        }

        internal partial class SapOpenHubSourceConverter : JsonConverter<SapOpenHubSource>
        {
            public override void Write(Utf8JsonWriter writer, SapOpenHubSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SapOpenHubSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSapOpenHubSource(document.RootElement);
            }
        }
    }
}
