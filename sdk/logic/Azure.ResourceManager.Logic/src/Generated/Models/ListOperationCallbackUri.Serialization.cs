// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class ListOperationCallbackUri
    {
        internal static ListOperationCallbackUri DeserializeListOperationCallbackUri(JsonElement element)
        {
            Optional<Uri> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    value = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ListOperationCallbackUri(value.Value);
        }
    }
}
