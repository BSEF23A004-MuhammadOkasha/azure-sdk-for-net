// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Render.Models
{
    public partial class GetCopyrightCaptionResult
    {
        internal static GetCopyrightCaptionResult DeserializeGetCopyrightCaptionResult(JsonElement element)
        {
            Optional<string> formatVersion = default;
            Optional<string> copyrightsCaption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatVersion"))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyrightsCaption"))
                {
                    copyrightsCaption = property.Value.GetString();
                    continue;
                }
            }
            return new GetCopyrightCaptionResult(formatVersion.Value, copyrightsCaption.Value);
        }
    }
}
