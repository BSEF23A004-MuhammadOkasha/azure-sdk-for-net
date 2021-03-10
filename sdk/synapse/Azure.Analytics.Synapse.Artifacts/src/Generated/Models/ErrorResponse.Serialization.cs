// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ErrorResponseConverter))]
    internal partial class ErrorResponse
    {
        internal static ErrorResponse DeserializeErrorResponse(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<ErrorResponse>> details = default;
            Optional<IReadOnlyList<ErrorAdditionalInfo>> additionalInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeErrorResponse(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("additionalInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorAdditionalInfo> array = new List<ErrorAdditionalInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorAdditionalInfo.DeserializeErrorAdditionalInfo(item));
                    }
                    additionalInfo = array;
                    continue;
                }
            }
            return new ErrorResponse(code.Value, message.Value, target.Value, Optional.ToList(details), Optional.ToList(additionalInfo));
        }

        internal partial class ErrorResponseConverter : JsonConverter<ErrorResponse>
        {
            public override void Write(Utf8JsonWriter writer, ErrorResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ErrorResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeErrorResponse(document.RootElement);
            }
        }
    }
}
