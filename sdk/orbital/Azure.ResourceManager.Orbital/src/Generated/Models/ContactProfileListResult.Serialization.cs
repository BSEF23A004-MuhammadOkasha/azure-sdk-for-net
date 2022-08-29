// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Models
{
    internal partial class ContactProfileListResult
    {
        internal static ContactProfileListResult DeserializeContactProfileListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ContactProfileData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContactProfileData> array = new List<ContactProfileData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContactProfileData.DeserializeContactProfileData(item));
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
            return new ContactProfileListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
