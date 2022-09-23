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
    internal partial class StaticSiteCustomDomainOverviewCollection
    {
        internal static StaticSiteCustomDomainOverviewCollection DeserializeStaticSiteCustomDomainOverviewCollection(JsonElement element)
        {
            IReadOnlyList<StaticSiteCustomDomainOverviewData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<StaticSiteCustomDomainOverviewData> array = new List<StaticSiteCustomDomainOverviewData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticSiteCustomDomainOverviewData.DeserializeStaticSiteCustomDomainOverviewData(item));
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
            return new StaticSiteCustomDomainOverviewCollection(value, nextLink.Value);
        }
    }
}
