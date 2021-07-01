// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class SearchResultAddressRanges
    {
        internal static SearchResultAddressRanges DeserializeSearchResultAddressRanges(JsonElement element)
        {
            Optional<string> rangeLeft = default;
            Optional<string> rangeRight = default;
            Optional<CoordinatesPairAbbreviated> @from = default;
            Optional<CoordinatesPairAbbreviated> to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rangeLeft"))
                {
                    rangeLeft = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rangeRight"))
                {
                    rangeRight = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @from = CoordinatesPairAbbreviated.DeserializeCoordinatesPairAbbreviated(property.Value);
                    continue;
                }
                if (property.NameEquals("to"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    to = CoordinatesPairAbbreviated.DeserializeCoordinatesPairAbbreviated(property.Value);
                    continue;
                }
            }
            return new SearchResultAddressRanges(rangeLeft.Value, rangeRight.Value, @from.Value, to.Value);
        }
    }
}
