// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowDebugCommandResponseConverter))]
    public partial class DataFlowDebugCommandResponse
    {
        internal static DataFlowDebugCommandResponse DeserializeDataFlowDebugCommandResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<string> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    data = property.Value.GetString();
                    continue;
                }
            }
            return new DataFlowDebugCommandResponse(status.Value, data.Value);
        }

        internal partial class DataFlowDebugCommandResponseConverter : JsonConverter<DataFlowDebugCommandResponse>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugCommandResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override DataFlowDebugCommandResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugCommandResponse(document.RootElement);
            }
        }
    }
}
