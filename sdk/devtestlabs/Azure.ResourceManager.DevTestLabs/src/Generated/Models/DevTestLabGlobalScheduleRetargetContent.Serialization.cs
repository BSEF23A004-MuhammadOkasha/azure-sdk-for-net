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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabGlobalScheduleRetargetContent : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabGlobalScheduleRetargetContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabGlobalScheduleRetargetContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabGlobalScheduleRetargetContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CurrentResourceId))
            {
                writer.WritePropertyName("currentResourceId"u8);
                writer.WriteStringValue(CurrentResourceId);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
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

        internal static DevTestLabGlobalScheduleRetargetContent DeserializeDevTestLabGlobalScheduleRetargetContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> currentResourceId = default;
            Optional<ResourceIdentifier> targetResourceId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabGlobalScheduleRetargetContent(currentResourceId.Value, targetResourceId.Value, rawData);
        }

        DevTestLabGlobalScheduleRetargetContent IModelJsonSerializable<DevTestLabGlobalScheduleRetargetContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabGlobalScheduleRetargetContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabGlobalScheduleRetargetContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabGlobalScheduleRetargetContent IModelSerializable<DevTestLabGlobalScheduleRetargetContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabGlobalScheduleRetargetContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabGlobalScheduleRetargetContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabGlobalScheduleRetargetContent"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabGlobalScheduleRetargetContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabGlobalScheduleRetargetContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabGlobalScheduleRetargetContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabGlobalScheduleRetargetContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
