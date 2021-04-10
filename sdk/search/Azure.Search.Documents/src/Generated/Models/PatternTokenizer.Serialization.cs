// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class PatternTokenizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern");
                writer.WriteStringValue(Pattern);
            }
            if (Optional.IsDefined(FlagsInternal))
            {
                writer.WritePropertyName("flags");
                writer.WriteStringValue(FlagsInternal);
            }
            if (Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group");
                writer.WriteNumberValue(Group.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PatternTokenizer DeserializePatternTokenizer(JsonElement element)
        {
            Optional<string> pattern = default;
            Optional<string> flags = default;
            Optional<int> group = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pattern"))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("flags"))
                {
                    flags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("group"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    group = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PatternTokenizer(odataType, name, pattern.Value, flags.Value, Optional.ToNullable(group));
        }
    }
}
