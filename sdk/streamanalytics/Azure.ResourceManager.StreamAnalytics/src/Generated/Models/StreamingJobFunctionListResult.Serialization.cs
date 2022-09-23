// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    internal partial class StreamingJobFunctionListResult
    {
        internal static StreamingJobFunctionListResult DeserializeStreamingJobFunctionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<StreamingJobFunctionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StreamingJobFunctionData> array = new List<StreamingJobFunctionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingJobFunctionData.DeserializeStreamingJobFunctionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new StreamingJobFunctionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
