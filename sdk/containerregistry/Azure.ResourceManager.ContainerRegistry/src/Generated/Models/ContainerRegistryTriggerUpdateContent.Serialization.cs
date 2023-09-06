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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTriggerUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryTriggerUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryTriggerUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryTriggerUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTriggerUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TimerTriggers))
            {
                writer.WritePropertyName("timerTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in TimerTriggers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ContainerRegistryTimerTriggerUpdateContent>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceTriggers))
            {
                writer.WritePropertyName("sourceTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in SourceTriggers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ContainerRegistrySourceTriggerUpdateContent>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BaseImageTrigger))
            {
                writer.WritePropertyName("baseImageTrigger"u8);
                if (BaseImageTrigger is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerRegistryBaseImageTriggerUpdateContent>)BaseImageTrigger).Serialize(writer, options);
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

        internal static ContainerRegistryTriggerUpdateContent DeserializeContainerRegistryTriggerUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ContainerRegistryTimerTriggerUpdateContent>> timerTriggers = default;
            Optional<IList<ContainerRegistrySourceTriggerUpdateContent>> sourceTriggers = default;
            Optional<ContainerRegistryBaseImageTriggerUpdateContent> baseImageTrigger = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timerTriggers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTimerTriggerUpdateContent> array = new List<ContainerRegistryTimerTriggerUpdateContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTimerTriggerUpdateContent.DeserializeContainerRegistryTimerTriggerUpdateContent(item));
                    }
                    timerTriggers = array;
                    continue;
                }
                if (property.NameEquals("sourceTriggers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistrySourceTriggerUpdateContent> array = new List<ContainerRegistrySourceTriggerUpdateContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistrySourceTriggerUpdateContent.DeserializeContainerRegistrySourceTriggerUpdateContent(item));
                    }
                    sourceTriggers = array;
                    continue;
                }
                if (property.NameEquals("baseImageTrigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseImageTrigger = ContainerRegistryBaseImageTriggerUpdateContent.DeserializeContainerRegistryBaseImageTriggerUpdateContent(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistryTriggerUpdateContent(Optional.ToList(timerTriggers), Optional.ToList(sourceTriggers), baseImageTrigger.Value, rawData);
        }

        ContainerRegistryTriggerUpdateContent IModelJsonSerializable<ContainerRegistryTriggerUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTriggerUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTriggerUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryTriggerUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTriggerUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryTriggerUpdateContent IModelSerializable<ContainerRegistryTriggerUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTriggerUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryTriggerUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistryTriggerUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistryTriggerUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistryTriggerUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistryTriggerUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistryTriggerUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryTriggerUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
