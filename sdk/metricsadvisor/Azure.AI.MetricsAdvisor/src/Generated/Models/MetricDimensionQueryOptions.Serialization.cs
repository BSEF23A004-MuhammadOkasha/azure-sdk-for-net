// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.MetricsAdvisor;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class MetricDimensionQueryOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dimensionName"u8);
            writer.WriteStringValue(DimensionName);
            if (Optional.IsDefined(DimensionValueFilter))
            {
                writer.WritePropertyName("dimensionValueFilter"u8);
                writer.WriteStringValue(DimensionValueFilter);
            }
            writer.WriteEndObject();
        }
    }
}
