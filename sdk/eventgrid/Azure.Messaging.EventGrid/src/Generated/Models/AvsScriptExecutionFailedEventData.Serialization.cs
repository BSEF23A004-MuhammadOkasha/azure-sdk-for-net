// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AvsScriptExecutionFailedEventDataConverter))]
    public partial class AvsScriptExecutionFailedEventData
    {
        internal static AvsScriptExecutionFailedEventData DeserializeAvsScriptExecutionFailedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string failureMessage = default;
            string operationId = default;
            string cmdletId = default;
            IReadOnlyList<string> output = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureMessage"u8))
                {
                    failureMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cmdletId"u8))
                {
                    cmdletId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    output = array;
                    continue;
                }
            }
            return new AvsScriptExecutionFailedEventData(operationId, cmdletId, output ?? new ChangeTrackingList<string>(), failureMessage);
        }

        internal partial class AvsScriptExecutionFailedEventDataConverter : JsonConverter<AvsScriptExecutionFailedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AvsScriptExecutionFailedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AvsScriptExecutionFailedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvsScriptExecutionFailedEventData(document.RootElement);
            }
        }
    }
}
