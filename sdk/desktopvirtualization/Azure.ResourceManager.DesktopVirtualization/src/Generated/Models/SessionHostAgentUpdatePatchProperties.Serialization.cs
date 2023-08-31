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

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class SessionHostAgentUpdatePatchProperties : IUtf8JsonSerializable, IModelJsonSerializable<SessionHostAgentUpdatePatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SessionHostAgentUpdatePatchProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SessionHostAgentUpdatePatchProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UpdateType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(UpdateType.Value.ToString());
            }
            if (Optional.IsDefined(DoesUseSessionHostLocalTime))
            {
                writer.WritePropertyName("useSessionHostLocalTime"u8);
                writer.WriteBooleanValue(DoesUseSessionHostLocalTime.Value);
            }
            if (Optional.IsDefined(MaintenanceWindowTimeZone))
            {
                writer.WritePropertyName("maintenanceWindowTimeZone"u8);
                writer.WriteStringValue(MaintenanceWindowTimeZone);
            }
            if (Optional.IsCollectionDefined(MaintenanceWindows))
            {
                writer.WritePropertyName("maintenanceWindows"u8);
                writer.WriteStartArray();
                foreach (var item in MaintenanceWindows)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MaintenanceWindowPatchProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static SessionHostAgentUpdatePatchProperties DeserializeSessionHostAgentUpdatePatchProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SessionHostComponentUpdateType> type = default;
            Optional<bool> useSessionHostLocalTime = default;
            Optional<string> maintenanceWindowTimeZone = default;
            Optional<IList<MaintenanceWindowPatchProperties>> maintenanceWindows = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SessionHostComponentUpdateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useSessionHostLocalTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useSessionHostLocalTime = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maintenanceWindowTimeZone"u8))
                {
                    maintenanceWindowTimeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maintenanceWindows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaintenanceWindowPatchProperties> array = new List<MaintenanceWindowPatchProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceWindowPatchProperties.DeserializeMaintenanceWindowPatchProperties(item));
                    }
                    maintenanceWindows = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SessionHostAgentUpdatePatchProperties(Optional.ToNullable(type), Optional.ToNullable(useSessionHostLocalTime), maintenanceWindowTimeZone.Value, Optional.ToList(maintenanceWindows), rawData);
        }

        SessionHostAgentUpdatePatchProperties IModelJsonSerializable<SessionHostAgentUpdatePatchProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSessionHostAgentUpdatePatchProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SessionHostAgentUpdatePatchProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SessionHostAgentUpdatePatchProperties IModelSerializable<SessionHostAgentUpdatePatchProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSessionHostAgentUpdatePatchProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SessionHostAgentUpdatePatchProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SessionHostAgentUpdatePatchProperties"/> to convert. </param>
        public static implicit operator RequestContent(SessionHostAgentUpdatePatchProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SessionHostAgentUpdatePatchProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SessionHostAgentUpdatePatchProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSessionHostAgentUpdatePatchProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
