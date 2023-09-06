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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DeleteDataFlowDebugSessionContent : IUtf8JsonSerializable, IModelJsonSerializable<DeleteDataFlowDebugSessionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeleteDataFlowDebugSessionContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeleteDataFlowDebugSessionContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
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

        internal static DeleteDataFlowDebugSessionContent DeserializeDeleteDataFlowDebugSessionContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> sessionId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeleteDataFlowDebugSessionContent(Optional.ToNullable(sessionId), rawData);
        }

        DeleteDataFlowDebugSessionContent IModelJsonSerializable<DeleteDataFlowDebugSessionContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeleteDataFlowDebugSessionContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeleteDataFlowDebugSessionContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeleteDataFlowDebugSessionContent IModelSerializable<DeleteDataFlowDebugSessionContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeleteDataFlowDebugSessionContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeleteDataFlowDebugSessionContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeleteDataFlowDebugSessionContent"/> to convert. </param>
        public static implicit operator RequestContent(DeleteDataFlowDebugSessionContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeleteDataFlowDebugSessionContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeleteDataFlowDebugSessionContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeleteDataFlowDebugSessionContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
