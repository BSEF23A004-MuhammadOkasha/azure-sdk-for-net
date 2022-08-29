// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class JpgImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers");
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SpriteColumn))
            {
                writer.WritePropertyName("spriteColumn");
                writer.WriteNumberValue(SpriteColumn.Value);
            }
            writer.WritePropertyName("start");
            writer.WriteStringValue(Start);
            if (Optional.IsDefined(Step))
            {
                writer.WritePropertyName("step");
                writer.WriteStringValue(Step);
            }
            if (Optional.IsDefined(Range))
            {
                writer.WritePropertyName("range");
                writer.WriteStringValue(Range);
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                writer.WritePropertyName("keyFrameInterval");
                writer.WriteStringValue(KeyFrameInterval.Value, "P");
            }
            if (Optional.IsDefined(StretchMode))
            {
                writer.WritePropertyName("stretchMode");
                writer.WriteStringValue(StretchMode.Value.ToString());
            }
            if (Optional.IsDefined(SyncMode))
            {
                writer.WritePropertyName("syncMode");
                writer.WriteStringValue(SyncMode.Value.ToString());
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            writer.WriteEndObject();
        }

        internal static JpgImage DeserializeJpgImage(JsonElement element)
        {
            Optional<IList<JpgLayer>> layers = default;
            Optional<int> spriteColumn = default;
            string start = default;
            Optional<string> step = default;
            Optional<string> range = default;
            Optional<TimeSpan> keyFrameInterval = default;
            Optional<InputVideoStretchMode> stretchMode = default;
            Optional<VideoSyncMode> syncMode = default;
            string odataType = default;
            Optional<string> label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("layers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JpgLayer> array = new List<JpgLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JpgLayer.DeserializeJpgLayer(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("spriteColumn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    spriteColumn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("start"))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("step"))
                {
                    step = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("range"))
                {
                    range = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stretchMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    syncMode = new VideoSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new JpgImage(odataType, label.Value, Optional.ToNullable(keyFrameInterval), Optional.ToNullable(stretchMode), Optional.ToNullable(syncMode), start, step.Value, range.Value, Optional.ToList(layers), Optional.ToNullable(spriteColumn));
        }
    }
}
