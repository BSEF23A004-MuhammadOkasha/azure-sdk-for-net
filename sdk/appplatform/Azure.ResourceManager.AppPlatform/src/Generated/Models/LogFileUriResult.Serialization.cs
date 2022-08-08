// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class LogFileUriResult
    {
        internal static LogFileUriResult DeserializeLogFileUriResult(JsonElement element)
        {
            Uri uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new LogFileUriResult(uri);
        }
    }
}
