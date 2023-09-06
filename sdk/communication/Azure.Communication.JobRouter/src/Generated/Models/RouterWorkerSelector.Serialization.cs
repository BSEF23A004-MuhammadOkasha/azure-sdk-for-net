// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication.JobRouter.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.JobRouter
{
    public partial class RouterWorkerSelector : IUtf8JsonSerializable, IModelJsonSerializable<RouterWorkerSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouterWorkerSelector>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouterWorkerSelector>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterWorkerSelector>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            writer.WritePropertyName("labelOperator"u8);
            writer.WriteStringValue(LabelOperator.ToString());
            if (Optional.IsDefined(_value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteObjectValue(_value);
            }
            if (Optional.IsDefined(_expiresAfterSeconds))
            {
                writer.WritePropertyName("expiresAfterSeconds"u8);
                writer.WriteNumberValue(_expiresAfterSeconds.Value);
            }
            if (Optional.IsDefined(Expedite))
            {
                writer.WritePropertyName("expedite"u8);
                writer.WriteBooleanValue(Expedite.Value);
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

        internal static RouterWorkerSelector DeserializeRouterWorkerSelector(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            LabelOperator labelOperator = default;
            Optional<object> value = default;
            Optional<double> expiresAfterSeconds = default;
            Optional<bool> expedite = default;
            Optional<RouterWorkerSelectorStatus> status = default;
            Optional<DateTimeOffset> expiresAt = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelOperator"u8))
                {
                    labelOperator = new LabelOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("expiresAfterSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresAfterSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("expedite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expedite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new RouterWorkerSelectorStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiresAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouterWorkerSelector(key, labelOperator, value.Value, Optional.ToNullable(expiresAfterSeconds), Optional.ToNullable(expedite), Optional.ToNullable(status), Optional.ToNullable(expiresAt), rawData);
        }

        RouterWorkerSelector IModelJsonSerializable<RouterWorkerSelector>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterWorkerSelector>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterWorkerSelector(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouterWorkerSelector>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterWorkerSelector>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouterWorkerSelector IModelSerializable<RouterWorkerSelector>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterWorkerSelector>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouterWorkerSelector(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RouterWorkerSelector"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RouterWorkerSelector"/> to convert. </param>
        public static implicit operator RequestContent(RouterWorkerSelector model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RouterWorkerSelector"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RouterWorkerSelector(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouterWorkerSelector(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
