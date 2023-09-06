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
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    internal partial class AddonList : IUtf8JsonSerializable, IModelJsonSerializable<AddonList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AddonList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AddonList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddonList>(this, options.Format);

            writer.WriteStartObject();
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

        internal static AddonList DeserializeAddonList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataBoxEdgeRoleAddonData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeRoleAddonData> array = new List<DataBoxEdgeRoleAddonData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeRoleAddonData.DeserializeDataBoxEdgeRoleAddonData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AddonList(Optional.ToList(value), nextLink.Value, rawData);
        }

        AddonList IModelJsonSerializable<AddonList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddonList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAddonList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AddonList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddonList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AddonList IModelSerializable<AddonList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddonList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAddonList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AddonList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AddonList"/> to convert. </param>
        public static implicit operator RequestContent(AddonList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AddonList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AddonList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAddonList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
