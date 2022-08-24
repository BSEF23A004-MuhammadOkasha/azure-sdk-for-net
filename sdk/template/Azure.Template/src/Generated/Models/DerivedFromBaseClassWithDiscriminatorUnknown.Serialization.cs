// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Template.Models
{
    public partial class DerivedFromBaseClassWithUnknownDiscriminator
    {
        internal override void WriteCore(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("discriminatorProperty");
            writer.WriteStringValue(DiscriminatorProperty);
            writer.WritePropertyName("baseClassProperty");
            writer.WriteStringValue(BaseClassProperty);
            writer.WriteEndObject();
        }

        internal static DerivedFromBaseClassWithUnknownDiscriminator DeserializeDerivedFromBaseClassWithDiscriminatorUnknown(JsonElement element)
        {
            string discriminatorProperty = default;
            string baseClassProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("discriminatorProperty"))
                {
                    discriminatorProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseClassProperty"))
                {
                    baseClassProperty = property.Value.GetString();
                    continue;
                }
            }
            return new DerivedFromBaseClassWithUnknownDiscriminator(baseClassProperty, discriminatorProperty);
        }
    }
}
