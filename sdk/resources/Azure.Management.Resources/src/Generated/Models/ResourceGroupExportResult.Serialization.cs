// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class ResourceGroupExportResult
    {
        internal static ResourceGroupExportResult DeserializeResourceGroupExportResult(JsonElement element)
        {
            object template = default;
            ErrorResponse error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("template"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ErrorResponse.DeserializeErrorResponse(property.Value);
                    continue;
                }
            }
            return new ResourceGroupExportResult(template, error);
        }
    }
}
