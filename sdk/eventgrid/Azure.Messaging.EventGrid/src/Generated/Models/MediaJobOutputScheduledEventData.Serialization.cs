// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaJobOutputScheduledEventDataConverter))]
    public partial class MediaJobOutputScheduledEventData
    {
        internal static MediaJobOutputScheduledEventData DeserializeMediaJobOutputScheduledEventData(JsonElement element)
        {
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobOutput> output = default;
            Optional<IReadOnlyDictionary<string, string>> jobCorrelationData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("previousState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    output = MediaJobOutput.DeserializeMediaJobOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("jobCorrelationData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    jobCorrelationData = dictionary;
                    continue;
                }
            }
            return new MediaJobOutputScheduledEventData(Optional.ToNullable(previousState), output.Value, Optional.ToDictionary(jobCorrelationData));
        }

        internal partial class MediaJobOutputScheduledEventDataConverter : JsonConverter<MediaJobOutputScheduledEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobOutputScheduledEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaJobOutputScheduledEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobOutputScheduledEventData(document.RootElement);
            }
        }
    }
}
