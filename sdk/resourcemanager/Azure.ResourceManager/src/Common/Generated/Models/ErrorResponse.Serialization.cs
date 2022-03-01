// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(ErrorResponseConverter))]
    internal partial class ErrorResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error");
                writer.WriteObjectValue(Error);
            }
            writer.WriteEndObject();
        }

        internal static ErrorResponse DeserializeErrorResponse(JsonElement element)
        {
            Optional<ErrorDetail> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
            }
            return new ErrorResponse(error.Value);
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
