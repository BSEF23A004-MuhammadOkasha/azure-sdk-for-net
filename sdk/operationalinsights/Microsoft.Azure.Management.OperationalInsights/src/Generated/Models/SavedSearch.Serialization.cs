// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace OperationalInsightsManagementClient.Models
{
    public partial class SavedSearch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("category");
            writer.WriteStringValue(Category);
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("query");
            writer.WriteStringValue(Query);
            if (Optional.IsDefined(FunctionAlias))
            {
                writer.WritePropertyName("functionAlias");
                writer.WriteStringValue(FunctionAlias);
            }
            if (Optional.IsDefined(FunctionParameters))
            {
                writer.WritePropertyName("functionParameters");
                writer.WriteStringValue(FunctionParameters);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SavedSearch DeserializeSavedSearch(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string category = default;
            string displayName = default;
            string query = default;
            Optional<string> functionAlias = default;
            Optional<string> functionParameters = default;
            Optional<long> version = default;
            Optional<IList<Tag>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("category"))
                        {
                            category = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("query"))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("functionAlias"))
                        {
                            functionAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("functionParameters"))
                        {
                            functionParameters = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            version = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("tags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Tag> array = new List<Tag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Tag.DeserializeTag(item));
                            }
                            tags = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SavedSearch(id.Value, name.Value, type.Value, etag.Value, category, displayName, query, functionAlias.Value, functionParameters.Value, Optional.ToNullable(version), Optional.ToList(tags));
        }
    }
}
