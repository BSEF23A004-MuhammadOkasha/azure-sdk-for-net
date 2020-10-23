// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    public partial class TimeSeriesPoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timestamp");
            writer.WriteStringValue(Timestamp, "O");
            writer.WritePropertyName("value");
            writer.WriteNumberValue(Value);
            writer.WriteEndObject();
        }
    }
}
