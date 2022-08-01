// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class PipelineListResponse
    {
        internal static PipelineListResponse DeserializePipelineListResponse(JsonElement element)
        {
            IReadOnlyList<FactoryPipelineData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<FactoryPipelineData> array = new List<FactoryPipelineData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FactoryPipelineData.DeserializeFactoryPipelineData(item));
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
            return new PipelineListResponse(value, nextLink.Value);
        }
    }
}
