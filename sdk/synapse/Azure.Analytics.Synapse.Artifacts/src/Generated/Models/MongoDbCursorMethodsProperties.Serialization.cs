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
    [JsonConverter(typeof(MongoDbCursorMethodsPropertiesConverter))]
    public partial class MongoDbCursorMethodsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Project != null)
            {
                writer.WritePropertyName("project"u8);
                writer.WriteObjectValue(Project);
            }
            if (Sort != null)
            {
                writer.WritePropertyName("sort"u8);
                writer.WriteObjectValue(Sort);
            }
            if (Skip != null)
            {
                writer.WritePropertyName("skip"u8);
                writer.WriteObjectValue(Skip);
            }
            if (Limit != null)
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteObjectValue(Limit);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static MongoDbCursorMethodsProperties DeserializeMongoDbCursorMethodsProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object project = default;
            object sort = default;
            object skip = default;
            object limit = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("project"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    project = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sort = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MongoDbCursorMethodsProperties(project, sort, skip, limit, additionalProperties);
        }

        internal partial class MongoDbCursorMethodsPropertiesConverter : JsonConverter<MongoDbCursorMethodsProperties>
        {
            public override void Write(Utf8JsonWriter writer, MongoDbCursorMethodsProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MongoDbCursorMethodsProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMongoDbCursorMethodsProperties(document.RootElement);
            }
        }
    }
}
