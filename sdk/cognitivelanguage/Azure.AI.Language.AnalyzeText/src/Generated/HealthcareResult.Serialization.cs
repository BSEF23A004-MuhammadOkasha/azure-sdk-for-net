// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class HealthcareResult
    {
        internal static HealthcareResult DeserializeHealthcareResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage> documents = default;
            IReadOnlyList<DocumentError> errors = default;
            Optional<RequestStatistics> statistics = default;
            string modelVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"u8))
                {
                    List<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage> array = new List<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage.DeserializeHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = RequestStatistics.DeserializeRequestStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
            }
            return new HealthcareResult(errors, statistics.Value, modelVersion, documents);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HealthcareResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHealthcareResult(document.RootElement);
        }
    }
}
