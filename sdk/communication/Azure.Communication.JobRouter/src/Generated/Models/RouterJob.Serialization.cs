// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication.JobRouter;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterJob : IUtf8JsonSerializable, IModelJsonSerializable<RouterJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouterJob>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouterJob>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJob>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ChannelReference))
            {
                writer.WritePropertyName("channelReference"u8);
                writer.WriteStringValue(ChannelReference);
            }
            if (Optional.IsDefined(ChannelId))
            {
                writer.WritePropertyName("channelId"u8);
                writer.WriteStringValue(ChannelId);
            }
            if (Optional.IsDefined(ClassificationPolicyId))
            {
                writer.WritePropertyName("classificationPolicyId"u8);
                writer.WriteStringValue(ClassificationPolicyId);
            }
            if (Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId"u8);
                writer.WriteStringValue(QueueId);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(DispositionCode))
            {
                writer.WritePropertyName("dispositionCode"u8);
                writer.WriteStringValue(DispositionCode);
            }
            if (Optional.IsCollectionDefined(_requestedWorkerSelectors))
            {
                writer.WritePropertyName("requestedWorkerSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in _requestedWorkerSelectors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RouterWorkerSelector>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(_labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in _labels)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(_tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in _tags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(_notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStartObject();
                foreach (var item in _notes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(MatchingMode))
            {
                writer.WritePropertyName("matchingMode"u8);
                if (MatchingMode is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<JobMatchingMode>)MatchingMode).Serialize(writer, options);
                }
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

        internal static RouterJob DeserializeRouterJob(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> channelReference = default;
            Optional<RouterJobStatus> status = default;
            Optional<DateTimeOffset> enqueuedAt = default;
            Optional<string> channelId = default;
            Optional<string> classificationPolicyId = default;
            Optional<string> queueId = default;
            Optional<int> priority = default;
            Optional<string> dispositionCode = default;
            Optional<IList<RouterWorkerSelector>> requestedWorkerSelectors = default;
            Optional<IReadOnlyList<RouterWorkerSelector>> attachedWorkerSelectors = default;
            Optional<IDictionary<string, object>> labels = default;
            Optional<IReadOnlyDictionary<string, RouterJobAssignment>> assignments = default;
            Optional<IDictionary<string, object>> tags = default;
            Optional<IDictionary<string, string>> notes = default;
            Optional<DateTimeOffset> scheduledAt = default;
            Optional<JobMatchingMode> matchingMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new RouterJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enqueuedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enqueuedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classificationPolicyId"u8))
                {
                    classificationPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dispositionCode"u8))
                {
                    dispositionCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item));
                    }
                    requestedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("attachedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item));
                    }
                    attachedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("assignments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RouterJobAssignment> dictionary = new Dictionary<string, RouterJobAssignment>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, RouterJobAssignment.DeserializeRouterJobAssignment(property0.Value));
                    }
                    assignments = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("notes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    notes = dictionary;
                    continue;
                }
                if (property.NameEquals("scheduledAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("matchingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchingMode = JobMatchingMode.DeserializeJobMatchingMode(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouterJob(id.Value, channelReference.Value, Optional.ToNullable(status), Optional.ToNullable(enqueuedAt), channelId.Value, classificationPolicyId.Value, queueId.Value, Optional.ToNullable(priority), dispositionCode.Value, Optional.ToList(requestedWorkerSelectors), Optional.ToList(attachedWorkerSelectors), Optional.ToDictionary(labels), Optional.ToDictionary(assignments), Optional.ToDictionary(tags), Optional.ToDictionary(notes), Optional.ToNullable(scheduledAt), matchingMode.Value, rawData);
        }

        RouterJob IModelJsonSerializable<RouterJob>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJob>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterJob(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouterJob>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJob>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouterJob IModelSerializable<RouterJob>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJob>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouterJob(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RouterJob"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RouterJob"/> to convert. </param>
        public static implicit operator RequestContent(RouterJob model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RouterJob"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RouterJob(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouterJob(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
