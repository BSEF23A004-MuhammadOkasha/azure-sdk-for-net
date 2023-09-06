// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterQueueItem : IUtf8JsonSerializable, IModelJsonSerializable<RouterQueueItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouterQueueItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouterQueueItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterQueueItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Queue))
            {
                writer.WritePropertyName("queue"u8);
                if (Queue is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RouterQueue>)Queue).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(_etag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(_etag);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static RouterQueueItem DeserializeRouterQueueItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RouterQueue> queue = default;
            Optional<string> etag = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queue = RouterQueue.DeserializeRouterQueue(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouterQueueItem(queue.Value, etag.Value, rawData);
        }

        RouterQueueItem IModelJsonSerializable<RouterQueueItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterQueueItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterQueueItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouterQueueItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterQueueItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouterQueueItem IModelSerializable<RouterQueueItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterQueueItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouterQueueItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RouterQueueItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RouterQueueItem"/> to convert. </param>
        public static implicit operator RequestContent(RouterQueueItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RouterQueueItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RouterQueueItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouterQueueItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
