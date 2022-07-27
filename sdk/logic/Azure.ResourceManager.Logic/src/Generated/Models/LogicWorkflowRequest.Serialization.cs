// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Headers))
            {
                writer.WritePropertyName("headers");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Headers);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Headers.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri");
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method");
                writer.WriteStringValue(Method);
            }
            writer.WriteEndObject();
        }

        internal static LogicWorkflowRequest DeserializeLogicWorkflowRequest(JsonElement element)
        {
            Optional<BinaryData> headers = default;
            Optional<Uri> uri = default;
            Optional<string> method = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    headers = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("method"))
                {
                    method = property.Value.GetString();
                    continue;
                }
            }
            return new LogicWorkflowRequest(headers.Value, uri.Value, method.Value);
        }
    }
}
