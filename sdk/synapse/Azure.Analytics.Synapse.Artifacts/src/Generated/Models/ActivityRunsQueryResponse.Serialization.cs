// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ActivityRunsQueryResponseConverter))]
    public partial class ActivityRunsQueryResponse
    {
        internal static ActivityRunsQueryResponse DeserializeActivityRunsQueryResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ActivityRun> value = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ActivityRun> array = new List<ActivityRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityRun.DeserializeActivityRun(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new ActivityRunsQueryResponse(value, continuationToken.Value);
        }

        internal partial class ActivityRunsQueryResponseConverter : JsonConverter<ActivityRunsQueryResponse>
        {
            public override void Write(Utf8JsonWriter writer, ActivityRunsQueryResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ActivityRunsQueryResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivityRunsQueryResponse(document.RootElement);
            }
        }
    }
}
