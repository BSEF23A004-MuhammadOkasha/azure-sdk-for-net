// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    internal partial class TranslationsStatus
    {
        internal static TranslationsStatus DeserializeTranslationsStatus(JsonElement element)
        {
            IReadOnlyList<TranslationStatus> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TranslationStatus> array = new List<TranslationStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TranslationStatus.DeserializeTranslationStatus(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TranslationsStatus(value, nextLink.Value);
        }
    }
}
