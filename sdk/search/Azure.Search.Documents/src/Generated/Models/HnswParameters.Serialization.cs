// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class HnswParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (M.HasValue)
            {
                if (M != null)
                {
                    writer.WritePropertyName("m"u8);
                    writer.WriteNumberValue(M.Value);
                }
                else
                {
                    writer.WriteNull("m");
                }
            }
            if (EfConstruction.HasValue)
            {
                if (EfConstruction != null)
                {
                    writer.WritePropertyName("efConstruction"u8);
                    writer.WriteNumberValue(EfConstruction.Value);
                }
                else
                {
                    writer.WriteNull("efConstruction");
                }
            }
            if (EfSearch.HasValue)
            {
                if (EfSearch != null)
                {
                    writer.WritePropertyName("efSearch"u8);
                    writer.WriteNumberValue(EfSearch.Value);
                }
                else
                {
                    writer.WriteNull("efSearch");
                }
            }
            if (Metric.HasValue)
            {
                if (Metric != null)
                {
                    writer.WritePropertyName("metric"u8);
                    writer.WriteStringValue(Metric.Value.ToString());
                }
                else
                {
                    writer.WriteNull("metric");
                }
            }
            writer.WriteEndObject();
        }

        internal static HnswParameters DeserializeHnswParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? m = default;
            int? efConstruction = default;
            int? efSearch = default;
            VectorSearchAlgorithmMetric? metric = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("m"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        m = null;
                        continue;
                    }
                    m = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("efConstruction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        efConstruction = null;
                        continue;
                    }
                    efConstruction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("efSearch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        efSearch = null;
                        continue;
                    }
                    efSearch = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metric = null;
                        continue;
                    }
                    metric = new VectorSearchAlgorithmMetric(property.Value.GetString());
                    continue;
                }
            }
            return new HnswParameters(m, efConstruction, efSearch, metric);
        }
    }
}
