// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.OpenAI
{
    public partial class ContentFilterResultsForPrompt
    {
        internal static ContentFilterResultsForPrompt DeserializeContentFilterResultsForPrompt(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int promptIndex = default;
            ContentFilterResultDetailsForPrompt contentFilterResults = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prompt_index"u8))
                {
                    promptIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    contentFilterResults = ContentFilterResultDetailsForPrompt.DeserializeContentFilterResultDetailsForPrompt(property.Value);
                    continue;
                }
            }
            return new ContentFilterResultsForPrompt(promptIndex, contentFilterResults);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ContentFilterResultsForPrompt FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeContentFilterResultsForPrompt(document.RootElement);
        }
    }
}
