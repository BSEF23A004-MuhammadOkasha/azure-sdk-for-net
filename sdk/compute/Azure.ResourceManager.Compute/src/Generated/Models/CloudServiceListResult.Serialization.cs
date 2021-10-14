// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class CloudServiceListResult
    {
        internal static CloudServiceListResult DeserializeCloudServiceListResult(JsonElement element)
        {
            IReadOnlyList<CloudServiceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<CloudServiceData> array = new List<CloudServiceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CloudServiceData.DeserializeCloudServiceData(item));
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
            return new CloudServiceListResult(value, nextLink.Value);
        }
    }
}
