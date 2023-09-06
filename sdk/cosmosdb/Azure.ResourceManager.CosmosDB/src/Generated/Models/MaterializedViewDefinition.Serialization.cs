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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MaterializedViewDefinition : IUtf8JsonSerializable, IModelJsonSerializable<MaterializedViewDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MaterializedViewDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MaterializedViewDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaterializedViewDefinition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceCollectionId"u8);
            writer.WriteStringValue(SourceCollectionId);
            writer.WritePropertyName("definition"u8);
            writer.WriteStringValue(Definition);
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

        internal static MaterializedViewDefinition DeserializeMaterializedViewDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sourceCollectionRid = default;
            string sourceCollectionId = default;
            string definition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceCollectionRid"u8))
                {
                    sourceCollectionRid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCollectionId"u8))
                {
                    sourceCollectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MaterializedViewDefinition(sourceCollectionRid.Value, sourceCollectionId, definition, rawData);
        }

        MaterializedViewDefinition IModelJsonSerializable<MaterializedViewDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaterializedViewDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMaterializedViewDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MaterializedViewDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaterializedViewDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MaterializedViewDefinition IModelSerializable<MaterializedViewDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaterializedViewDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMaterializedViewDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MaterializedViewDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MaterializedViewDefinition"/> to convert. </param>
        public static implicit operator RequestContent(MaterializedViewDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MaterializedViewDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MaterializedViewDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMaterializedViewDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
