// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class AgeMetadata
    {
        internal static AgeMetadata DeserializeAgeMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double value = default;
            AgeUnit unit = default;
            MetadataKind metadataKind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = new AgeUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadataKind"u8))
                {
                    metadataKind = new MetadataKind(property.Value.GetString());
                    continue;
                }
            }
            return new AgeMetadata(metadataKind, value, unit);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AgeMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAgeMetadata(document.RootElement);
        }
    }
}
