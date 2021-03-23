// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class BlobPrefix
    {
        internal static BlobPrefix DeserializeBlobPrefix(JsonElement element)
        {
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new BlobPrefix(name);
        }
    }
}
