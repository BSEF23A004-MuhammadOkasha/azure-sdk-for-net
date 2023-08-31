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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupJobSubTask : IUtf8JsonSerializable, IModelJsonSerializable<BackupJobSubTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupJobSubTask>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupJobSubTask>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdditionalDetails))
            {
                writer.WritePropertyName("additionalDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("taskId"u8);
            writer.WriteNumberValue(TaskId);
            writer.WritePropertyName("taskName"u8);
            writer.WriteStringValue(TaskName);
            writer.WritePropertyName("taskStatus"u8);
            writer.WriteStringValue(TaskStatus);
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

        internal static BackupJobSubTask DeserializeBackupJobSubTask(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, string>> additionalDetails = default;
            int taskId = default;
            string taskName = default;
            Optional<string> taskProgress = default;
            string taskStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalDetails = dictionary;
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskProgress"u8))
                {
                    taskProgress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskStatus"u8))
                {
                    taskStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupJobSubTask(Optional.ToDictionary(additionalDetails), taskId, taskName, taskProgress.Value, taskStatus, rawData);
        }

        BackupJobSubTask IModelJsonSerializable<BackupJobSubTask>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupJobSubTask(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupJobSubTask>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupJobSubTask IModelSerializable<BackupJobSubTask>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupJobSubTask(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupJobSubTask"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupJobSubTask"/> to convert. </param>
        public static implicit operator RequestContent(BackupJobSubTask model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupJobSubTask"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupJobSubTask(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupJobSubTask(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
