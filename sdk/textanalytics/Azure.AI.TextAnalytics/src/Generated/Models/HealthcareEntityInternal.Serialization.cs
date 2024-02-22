// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareEntityInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("category"u8);
            writer.WriteStringValue(Category.ToString());
            if (Optional.IsDefined(Subcategory))
            {
                writer.WritePropertyName("subcategory"u8);
                writer.WriteStringValue(Subcategory);
            }
            writer.WritePropertyName("offset"u8);
            writer.WriteNumberValue(Offset);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
            writer.WritePropertyName("confidenceScore"u8);
            writer.WriteNumberValue(ConfidenceScore);
            if (Optional.IsDefined(Assertion))
            {
                writer.WritePropertyName("assertion"u8);
                writer.WriteObjectValue(Assertion);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (!(Links is ChangeTrackingList<EntityDataSource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static HealthcareEntityInternal DeserializeHealthcareEntityInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            HealthcareEntityCategory category = default;
            Optional<string> subcategory = default;
            int offset = default;
            int length = default;
            double confidenceScore = default;
            Optional<HealthcareEntityAssertion> assertion = default;
            Optional<string> name = default;
            Optional<IList<EntityDataSource>> links = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = new HealthcareEntityCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subcategory"u8))
                {
                    subcategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("assertion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assertion = HealthcareEntityAssertion.DeserializeHealthcareEntityAssertion(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("links"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EntityDataSource> array = new List<EntityDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityDataSource.DeserializeEntityDataSource(item));
                    }
                    links = array;
                    continue;
                }
            }
            return new HealthcareEntityInternal(text, category, subcategory.Value, offset, length, confidenceScore, assertion.Value, name.Value, Optional.ToList(links));
        }
    }
}
