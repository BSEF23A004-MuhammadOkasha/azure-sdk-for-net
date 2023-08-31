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
    public partial class DevTestLabDataDiskProperties : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabDataDiskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabDataDiskProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabDataDiskProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AttachNewDataDiskOptions))
            {
                writer.WritePropertyName("attachNewDataDiskOptions"u8);
                if (AttachNewDataDiskOptions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AttachNewDataDiskDetails>)AttachNewDataDiskOptions).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ExistingLabDiskId))
            {
                writer.WritePropertyName("existingLabDiskId"u8);
                writer.WriteStringValue(ExistingLabDiskId);
            }
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching"u8);
                writer.WriteStringValue(HostCaching.Value.ToString());
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

        internal static DevTestLabDataDiskProperties DeserializeDevTestLabDataDiskProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AttachNewDataDiskDetails> attachNewDataDiskOptions = default;
            Optional<ResourceIdentifier> existingLabDiskId = default;
            Optional<DevTestLabHostCachingOption> hostCaching = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attachNewDataDiskOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attachNewDataDiskOptions = AttachNewDataDiskDetails.DeserializeAttachNewDataDiskDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("existingLabDiskId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    existingLabDiskId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostCaching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostCaching = new DevTestLabHostCachingOption(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabDataDiskProperties(attachNewDataDiskOptions.Value, existingLabDiskId.Value, Optional.ToNullable(hostCaching), rawData);
        }

        DevTestLabDataDiskProperties IModelJsonSerializable<DevTestLabDataDiskProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabDataDiskProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabDataDiskProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabDataDiskProperties IModelSerializable<DevTestLabDataDiskProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabDataDiskProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabDataDiskProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabDataDiskProperties"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabDataDiskProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabDataDiskProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabDataDiskProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabDataDiskProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
