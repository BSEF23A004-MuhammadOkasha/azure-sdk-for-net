// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamingJobFunctionInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType");
                writer.WriteStringValue(DataType);
            }
            if (Optional.IsDefined(IsConfigurationParameter))
            {
                if (IsConfigurationParameter != null)
                {
                    writer.WritePropertyName("isConfigurationParameter");
                    writer.WriteBooleanValue(IsConfigurationParameter.Value);
                }
                else
                {
                    writer.WriteNull("isConfigurationParameter");
                }
            }
            writer.WriteEndObject();
        }

        internal static StreamingJobFunctionInput DeserializeStreamingJobFunctionInput(JsonElement element)
        {
            Optional<string> dataType = default;
            Optional<bool?> isConfigurationParameter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataType"))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isConfigurationParameter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isConfigurationParameter = null;
                        continue;
                    }
                    isConfigurationParameter = property.Value.GetBoolean();
                    continue;
                }
            }
            return new StreamingJobFunctionInput(dataType.Value, Optional.ToNullable(isConfigurationParameter));
        }
    }
}
