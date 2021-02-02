// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    public partial class FileSystem
    {
        internal static FileSystem DeserializeFileSystem(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> lastModified = default;
            Optional<string> eTag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModified"))
                {
                    lastModified = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
            }
            return new FileSystem(name.Value, lastModified.Value, eTag.Value);
        }
    }
}
