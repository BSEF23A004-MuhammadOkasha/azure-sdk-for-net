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

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterStorageProfileSnapshotController : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterStorageProfileSnapshotController>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterStorageProfileSnapshotController>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterStorageProfileSnapshotController>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterStorageProfileSnapshotController>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        internal static ManagedClusterStorageProfileSnapshotController DeserializeManagedClusterStorageProfileSnapshotController(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterStorageProfileSnapshotController(Optional.ToNullable(enabled), rawData);
        }

        ManagedClusterStorageProfileSnapshotController IModelJsonSerializable<ManagedClusterStorageProfileSnapshotController>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterStorageProfileSnapshotController>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterStorageProfileSnapshotController(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterStorageProfileSnapshotController>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterStorageProfileSnapshotController>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterStorageProfileSnapshotController IModelSerializable<ManagedClusterStorageProfileSnapshotController>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedClusterStorageProfileSnapshotController>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterStorageProfileSnapshotController(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedClusterStorageProfileSnapshotController"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedClusterStorageProfileSnapshotController"/> to convert. </param>
        public static implicit operator RequestContent(ManagedClusterStorageProfileSnapshotController model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedClusterStorageProfileSnapshotController"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedClusterStorageProfileSnapshotController(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterStorageProfileSnapshotController(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
