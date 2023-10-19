// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class AssetPageResult
    {
        internal static AssetPageResult DeserializeAssetPageResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalElements = default;
            Optional<string> mark = default;
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<AssetResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalElements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalElements = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("mark"u8))
                {
                    mark = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssetResource> array = new List<AssetResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssetResource.DeserializeAssetResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AssetPageResult(Optional.ToNullable(totalElements), mark.Value, nextLink.Value, Optional.ToList(value));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssetPageResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAssetPageResult(document.RootElement);
        }
    }
}
