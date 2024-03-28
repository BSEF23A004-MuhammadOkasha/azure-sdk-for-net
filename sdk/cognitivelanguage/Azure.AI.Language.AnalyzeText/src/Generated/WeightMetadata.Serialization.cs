// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class WeightMetadata
    {
        internal static WeightMetadata DeserializeWeightMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double value = default;
            WeightUnit unit = default;
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
                    unit = new WeightUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadataKind"u8))
                {
                    metadataKind = new MetadataKind(property.Value.GetString());
                    continue;
                }
            }
            return new WeightMetadata(metadataKind, value, unit);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WeightMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWeightMetadata(document.RootElement);
        }
    }
}
