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

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class TransferConfigurationTransferFilterDetails : IUtf8JsonSerializable, IModelJsonSerializable<TransferConfigurationTransferFilterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TransferConfigurationTransferFilterDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TransferConfigurationTransferFilterDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransferConfigurationTransferFilterDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Include))
            {
                writer.WritePropertyName("include"u8);
                if (Include is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TransferFilterDetails>)Include).Serialize(writer, options);
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

        internal static TransferConfigurationTransferFilterDetails DeserializeTransferConfigurationTransferFilterDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TransferFilterDetails> include = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    include = TransferFilterDetails.DeserializeTransferFilterDetails(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TransferConfigurationTransferFilterDetails(include.Value, rawData);
        }

        TransferConfigurationTransferFilterDetails IModelJsonSerializable<TransferConfigurationTransferFilterDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransferConfigurationTransferFilterDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferConfigurationTransferFilterDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TransferConfigurationTransferFilterDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransferConfigurationTransferFilterDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TransferConfigurationTransferFilterDetails IModelSerializable<TransferConfigurationTransferFilterDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TransferConfigurationTransferFilterDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTransferConfigurationTransferFilterDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TransferConfigurationTransferFilterDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TransferConfigurationTransferFilterDetails"/> to convert. </param>
        public static implicit operator RequestContent(TransferConfigurationTransferFilterDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TransferConfigurationTransferFilterDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TransferConfigurationTransferFilterDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTransferConfigurationTransferFilterDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
