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
    public partial class CustomLabelClassificationResultWithDocumentDetectedLanguage
    {
        internal static CustomLabelClassificationResultWithDocumentDetectedLanguage DeserializeCustomLabelClassificationResultWithDocumentDetectedLanguage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ClassificationDocumentResultWithDetectedLanguage> documents = default;
            IReadOnlyList<DocumentError> errors = default;
            Optional<RequestStatistics> statistics = default;
            string projectName = default;
            string deploymentName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"u8))
                {
                    List<ClassificationDocumentResultWithDetectedLanguage> array = new List<ClassificationDocumentResultWithDetectedLanguage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClassificationDocumentResultWithDetectedLanguage.DeserializeClassificationDocumentResultWithDetectedLanguage(item));
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
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentName"u8))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
            }
            return new CustomLabelClassificationResultWithDocumentDetectedLanguage(errors, statistics.Value, projectName, deploymentName, documents);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CustomLabelClassificationResultWithDocumentDetectedLanguage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCustomLabelClassificationResultWithDocumentDetectedLanguage(document.RootElement);
        }
    }
}
