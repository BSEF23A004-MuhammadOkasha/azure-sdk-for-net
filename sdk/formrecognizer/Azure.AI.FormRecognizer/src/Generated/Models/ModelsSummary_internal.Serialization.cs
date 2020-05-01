// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    internal partial class ModelsSummary_internal
    {
        internal static ModelsSummary_internal DeserializeModelsSummary_internal(JsonElement element)
        {
            int count = default;
            int limit = default;
            DateTimeOffset lastUpdatedDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
            }
            return new ModelsSummary_internal(count, limit, lastUpdatedDateTime);
        }
    }
}
