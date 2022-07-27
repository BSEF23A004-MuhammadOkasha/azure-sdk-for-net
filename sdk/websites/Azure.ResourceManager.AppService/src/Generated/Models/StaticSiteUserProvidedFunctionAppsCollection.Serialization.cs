// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class StaticSiteUserProvidedFunctionAppsCollection
    {
        internal static StaticSiteUserProvidedFunctionAppsCollection DeserializeStaticSiteUserProvidedFunctionAppsCollection(JsonElement element)
        {
            IReadOnlyList<StaticSiteUserProvidedFunctionAppARMData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<StaticSiteUserProvidedFunctionAppARMData> array = new List<StaticSiteUserProvidedFunctionAppARMData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticSiteUserProvidedFunctionAppARMData.DeserializeStaticSiteUserProvidedFunctionAppARMData(item));
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
            return new StaticSiteUserProvidedFunctionAppsCollection(value, nextLink.Value);
        }
    }
}
