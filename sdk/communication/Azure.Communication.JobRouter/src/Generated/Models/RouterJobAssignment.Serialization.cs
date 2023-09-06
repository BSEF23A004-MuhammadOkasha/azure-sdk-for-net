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
    public partial class RouterJobAssignment : IUtf8JsonSerializable, IModelJsonSerializable<RouterJobAssignment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouterJobAssignment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouterJobAssignment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJobAssignment>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("assignmentId"u8);
            writer.WriteStringValue(AssignmentId);
            if (Optional.IsDefined(WorkerId))
            {
                writer.WritePropertyName("workerId"u8);
                writer.WriteStringValue(WorkerId);
            }
            writer.WritePropertyName("assignedAt"u8);
            writer.WriteStringValue(AssignedAt, "O");
            if (Optional.IsDefined(CompletedAt))
            {
                writer.WritePropertyName("completedAt"u8);
                writer.WriteStringValue(CompletedAt.Value, "O");
            }
            if (Optional.IsDefined(ClosedAt))
            {
                writer.WritePropertyName("closedAt"u8);
                writer.WriteStringValue(ClosedAt.Value, "O");
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

        internal static RouterJobAssignment DeserializeRouterJobAssignment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assignmentId = default;
            Optional<string> workerId = default;
            DateTimeOffset assignedAt = default;
            Optional<DateTimeOffset> completedAt = default;
            Optional<DateTimeOffset> closedAt = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignmentId"u8))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignedAt"u8))
                {
                    assignedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("completedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("closedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    closedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouterJobAssignment(assignmentId, workerId.Value, assignedAt, Optional.ToNullable(completedAt), Optional.ToNullable(closedAt), rawData);
        }

        RouterJobAssignment IModelJsonSerializable<RouterJobAssignment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJobAssignment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterJobAssignment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouterJobAssignment>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJobAssignment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouterJobAssignment IModelSerializable<RouterJobAssignment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RouterJobAssignment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouterJobAssignment(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RouterJobAssignment"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RouterJobAssignment"/> to convert. </param>
        public static implicit operator RequestContent(RouterJobAssignment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RouterJobAssignment"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RouterJobAssignment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouterJobAssignment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
