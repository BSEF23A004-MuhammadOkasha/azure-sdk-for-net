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
    [JsonConverter(typeof(PipelineRunInvokedByConverter))]
    public partial class PipelineRunInvokedBy
    {
        internal static PipelineRunInvokedBy DeserializePipelineRunInvokedBy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> invokedByType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invokedByType"u8))
                {
                    invokedByType = property.Value.GetString();
                    continue;
                }
            }
            return new PipelineRunInvokedBy(name.Value, id.Value, invokedByType.Value);
        }

        internal partial class PipelineRunInvokedByConverter : JsonConverter<PipelineRunInvokedBy>
        {
            public override void Write(Utf8JsonWriter writer, PipelineRunInvokedBy model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override PipelineRunInvokedBy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePipelineRunInvokedBy(document.RootElement);
            }
        }
    }
}
