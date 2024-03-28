// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.Language.AnalyzeText
{
    internal partial class UnknownBaseMetadata
    {
        internal static UnknownBaseMetadata DeserializeUnknownBaseMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MetadataKind metadataKind = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataKind"u8))
                {
                    metadataKind = new MetadataKind(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownBaseMetadata(metadataKind);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownBaseMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownBaseMetadata(document.RootElement);
        }
    }
}
