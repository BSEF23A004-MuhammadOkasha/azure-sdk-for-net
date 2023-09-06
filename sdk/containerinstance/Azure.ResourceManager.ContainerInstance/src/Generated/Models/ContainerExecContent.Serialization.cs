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

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerExecContent : IUtf8JsonSerializable, IModelJsonSerializable<ContainerExecContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerExecContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerExecContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerExecContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStringValue(Command);
            }
            if (Optional.IsDefined(TerminalSize))
            {
                writer.WritePropertyName("terminalSize"u8);
                if (TerminalSize is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerExecRequestTerminalSize>)TerminalSize).Serialize(writer, options);
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

        internal static ContainerExecContent DeserializeContainerExecContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> command = default;
            Optional<ContainerExecRequestTerminalSize> terminalSize = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("command"u8))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("terminalSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminalSize = ContainerExecRequestTerminalSize.DeserializeContainerExecRequestTerminalSize(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerExecContent(command.Value, terminalSize.Value, rawData);
        }

        ContainerExecContent IModelJsonSerializable<ContainerExecContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerExecContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerExecContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerExecContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerExecContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerExecContent IModelSerializable<ContainerExecContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerExecContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerExecContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerExecContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerExecContent"/> to convert. </param>
        public static implicit operator RequestContent(ContainerExecContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerExecContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerExecContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerExecContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
