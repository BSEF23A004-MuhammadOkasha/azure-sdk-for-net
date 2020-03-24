// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class FreshnessScoringParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("boostingDuration");
            writer.WriteStringValue(BoostingDuration, "P");
            writer.WriteEndObject();
        }

        internal static FreshnessScoringParameters DeserializeFreshnessScoringParameters(JsonElement element)
        {
            TimeSpan boostingDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boostingDuration"))
                {
                    boostingDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new FreshnessScoringParameters(boostingDuration);
        }
    }
}
