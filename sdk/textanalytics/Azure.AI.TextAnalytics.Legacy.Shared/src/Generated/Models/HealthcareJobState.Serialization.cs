// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy.Models;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class HealthcareJobState
    {
        internal static HealthcareJobState DeserializeHealthcareJobState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthcareResult results = default;
            IReadOnlyList<TextAnalyticsError> errors = default;
            string nextLink = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset? expirationDateTime = default;
            Guid jobId = default;
            DateTimeOffset lastUpdateDateTime = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = HealthcareResult.DeserializeHealthcareResult(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextAnalyticsError> array = new List<TextAnalyticsError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsError.DeserializeTextAnalyticsError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
            }
            return new HealthcareJobState(
                createdDateTime,
                expirationDateTime,
                jobId,
                lastUpdateDateTime,
                status,
                results,
                errors ?? new ChangeTrackingList<TextAnalyticsError>(),
                nextLink);
        }
    }
}
