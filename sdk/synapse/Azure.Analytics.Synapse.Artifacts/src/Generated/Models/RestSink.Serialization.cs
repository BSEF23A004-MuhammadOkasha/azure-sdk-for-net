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
    [JsonConverter(typeof(RestSinkConverter))]
    public partial class RestSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RequestMethod))
            {
                writer.WritePropertyName("requestMethod");
                writer.WriteObjectValue(RequestMethod);
            }
            if (Optional.IsDefined(AdditionalHeaders))
            {
                writer.WritePropertyName("additionalHeaders");
                writer.WriteObjectValue(AdditionalHeaders);
            }
            if (Optional.IsDefined(HttpRequestTimeout))
            {
                writer.WritePropertyName("httpRequestTimeout");
                writer.WriteObjectValue(HttpRequestTimeout);
            }
            if (Optional.IsDefined(RequestInterval))
            {
                writer.WritePropertyName("requestInterval");
                writer.WriteObjectValue(RequestInterval);
            }
            if (Optional.IsDefined(HttpCompressionType))
            {
                writer.WritePropertyName("httpCompressionType");
                writer.WriteObjectValue(HttpCompressionType);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize");
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout");
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount");
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait");
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static RestSink DeserializeRestSink(JsonElement element)
        {
            Optional<object> requestMethod = default;
            Optional<object> additionalHeaders = default;
            Optional<object> httpRequestTimeout = default;
            Optional<object> requestInterval = default;
            Optional<object> httpCompressionType = default;
            string type = default;
            Optional<object> writeBatchSize = default;
            Optional<object> writeBatchTimeout = default;
            Optional<object> sinkRetryCount = default;
            Optional<object> sinkRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestMethod = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalHeaders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalHeaders = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("httpRequestTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    httpRequestTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("requestInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestInterval = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("httpCompressionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    httpCompressionType = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RestSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, requestMethod.Value, additionalHeaders.Value, httpRequestTimeout.Value, requestInterval.Value, httpCompressionType.Value);
        }

        internal partial class RestSinkConverter : JsonConverter<RestSink>
        {
            public override void Write(Utf8JsonWriter writer, RestSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RestSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRestSink(document.RootElement);
            }
        }
    }
}
