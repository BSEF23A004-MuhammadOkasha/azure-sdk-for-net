// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class LegalHoldProperties
    {
        internal static LegalHoldProperties DeserializeLegalHoldProperties(JsonElement element)
        {
            Optional<bool> hasLegalHold = default;
            Optional<IReadOnlyList<TagProperty>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasLegalHold"))
                {
                    hasLegalHold = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    List<TagProperty> array = new List<TagProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TagProperty.DeserializeTagProperty(item));
                    }
                    tags = array;
                    continue;
                }
            }
            return new LegalHoldProperties(Optional.ToNullable(hasLegalHold), Optional.ToList(tags));
        }
    }
}
