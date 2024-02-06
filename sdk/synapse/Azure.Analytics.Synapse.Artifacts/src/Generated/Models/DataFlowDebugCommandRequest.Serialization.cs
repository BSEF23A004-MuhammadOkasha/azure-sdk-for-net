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
    [JsonConverter(typeof(DataFlowDebugCommandRequestConverter))]
    public partial class DataFlowDebugCommandRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStringValue(Command.Value.ToString());
            }
            if (Optional.IsDefined(CommandPayload))
            {
                writer.WritePropertyName("commandPayload"u8);
                writer.WriteObjectValue(CommandPayload);
            }
            writer.WriteEndObject();
        }

        internal partial class DataFlowDebugCommandRequestConverter : JsonConverter<DataFlowDebugCommandRequest>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugCommandRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override DataFlowDebugCommandRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
