// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class CustomMultiLabelClassificationLROResult
    {
        internal static CustomMultiLabelClassificationLROResult DeserializeCustomMultiLabelClassificationLROResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CustomLabelClassificationResultWithDocumentDetectedLanguage results = default;
            DateTimeOffset lastUpdateDateTime = default;
            State status = default;
            Optional<string> taskName = default;
            AnalyzeTextLROResultsKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = CustomLabelClassificationResultWithDocumentDetectedLanguage.DeserializeCustomLabelClassificationResultWithDocumentDetectedLanguage(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new State(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
            }
            return new CustomMultiLabelClassificationLROResult(lastUpdateDateTime, status, taskName.Value, kind, results);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new CustomMultiLabelClassificationLROResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCustomMultiLabelClassificationLROResult(document.RootElement);
        }
    }
}
