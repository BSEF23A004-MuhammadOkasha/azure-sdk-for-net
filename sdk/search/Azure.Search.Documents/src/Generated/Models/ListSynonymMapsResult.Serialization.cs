// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class ListSynonymMapsResult
    {
        internal static ListSynonymMapsResult DeserializeListSynonymMapsResult(JsonElement element)
        {
            ListSynonymMapsResult result = new ListSynonymMapsResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.SynonymMaps.Add(SynonymMap.DeserializeSynonymMap(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
