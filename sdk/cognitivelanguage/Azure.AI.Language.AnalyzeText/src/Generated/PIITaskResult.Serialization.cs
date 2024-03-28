// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class PiiTaskResult
    {
        internal static PiiTaskResult DeserializePiiTaskResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PiiResult results = default;
            AnalyzeTextTaskResultsKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = PiiResult.DeserializePiiResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextTaskResultsKind(property.Value.GetString());
                    continue;
                }
            }
            return new PiiTaskResult(kind, results);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new PiiTaskResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePiiTaskResult(document.RootElement);
        }
    }
}
