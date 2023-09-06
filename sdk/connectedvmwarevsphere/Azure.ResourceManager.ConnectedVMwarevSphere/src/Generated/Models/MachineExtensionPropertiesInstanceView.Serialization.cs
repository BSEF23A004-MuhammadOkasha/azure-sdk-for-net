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

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class MachineExtensionPropertiesInstanceView : IUtf8JsonSerializable, IModelJsonSerializable<MachineExtensionPropertiesInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineExtensionPropertiesInstanceView>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineExtensionPropertiesInstanceView>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineExtensionPropertiesInstanceView>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                if (Status is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MachineExtensionInstanceViewStatus>)Status).Serialize(writer, options);
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

        internal static MachineExtensionPropertiesInstanceView DeserializeMachineExtensionPropertiesInstanceView(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> typeHandlerVersion = default;
            Optional<MachineExtensionInstanceViewStatus> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"u8))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = MachineExtensionInstanceViewStatus.DeserializeMachineExtensionInstanceViewStatus(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineExtensionPropertiesInstanceView(name.Value, type.Value, typeHandlerVersion.Value, status.Value, rawData);
        }

        MachineExtensionPropertiesInstanceView IModelJsonSerializable<MachineExtensionPropertiesInstanceView>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineExtensionPropertiesInstanceView>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineExtensionPropertiesInstanceView(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineExtensionPropertiesInstanceView>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineExtensionPropertiesInstanceView>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineExtensionPropertiesInstanceView IModelSerializable<MachineExtensionPropertiesInstanceView>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineExtensionPropertiesInstanceView>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineExtensionPropertiesInstanceView(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineExtensionPropertiesInstanceView"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineExtensionPropertiesInstanceView"/> to convert. </param>
        public static implicit operator RequestContent(MachineExtensionPropertiesInstanceView model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineExtensionPropertiesInstanceView"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineExtensionPropertiesInstanceView(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineExtensionPropertiesInstanceView(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
