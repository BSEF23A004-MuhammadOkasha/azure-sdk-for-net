// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkConnectionListResponseConverter))]
    internal partial class LinkConnectionListResponse
    {
        internal static LinkConnectionListResponse DeserializeLinkConnectionListResponse(JsonElement element)
        {
            IReadOnlyList<LinkConnectionResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<LinkConnectionResource> array = new List<LinkConnectionResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkConnectionResource.DeserializeLinkConnectionResource(item));
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
            return new LinkConnectionListResponse(value, nextLink.Value);
        }

        internal partial class LinkConnectionListResponseConverter : JsonConverter<LinkConnectionListResponse>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override LinkConnectionListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionListResponse(document.RootElement);
            }
        }
    }
}
