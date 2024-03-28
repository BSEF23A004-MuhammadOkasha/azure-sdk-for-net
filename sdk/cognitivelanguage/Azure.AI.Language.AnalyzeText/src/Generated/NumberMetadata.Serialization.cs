// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class NumberMetadata
    {
        internal static NumberMetadata DeserializeNumberMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NumberKind numberKind = default;
            double value = default;
            MetadataKind metadataKind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberKind"u8))
                {
                    numberKind = new NumberKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("metadataKind"u8))
                {
                    metadataKind = new MetadataKind(property.Value.GetString());
                    continue;
                }
            }
            return new NumberMetadata(metadataKind, numberKind, value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new NumberMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeNumberMetadata(document.RootElement);
        }
    }
}
