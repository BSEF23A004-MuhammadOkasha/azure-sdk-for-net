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

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WriteEndObject();
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

        internal static DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent DeserializeDataLakeStoreVirtualNetworkRuleCreateOrUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier subnetId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subnetId"u8))
                        {
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent(subnetId, rawData);
        }

        DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent IModelJsonSerializable<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreVirtualNetworkRuleCreateOrUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent IModelSerializable<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeStoreVirtualNetworkRuleCreateOrUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataLakeStoreVirtualNetworkRuleCreateOrUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeStoreVirtualNetworkRuleCreateOrUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
