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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RoleInstances : IUtf8JsonSerializable, IModelJsonSerializable<RoleInstances>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoleInstances>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoleInstances>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleInstances>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("roleInstances"u8);
            writer.WriteStartArray();
            foreach (var item in RoleInstancesValue)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        internal static RoleInstances DeserializeRoleInstances(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> roleInstances = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("roleInstances"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    roleInstances = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoleInstances(roleInstances, rawData);
        }

        RoleInstances IModelJsonSerializable<RoleInstances>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleInstances>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleInstances(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoleInstances>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleInstances>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoleInstances IModelSerializable<RoleInstances>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoleInstances>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoleInstances(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RoleInstances"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RoleInstances"/> to convert. </param>
        public static implicit operator RequestContent(RoleInstances model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RoleInstances"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RoleInstances(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoleInstances(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
