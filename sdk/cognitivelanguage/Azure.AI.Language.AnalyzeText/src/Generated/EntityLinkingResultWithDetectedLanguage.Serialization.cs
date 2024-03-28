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
    public partial class EntityLinkingResultWithDetectedLanguage
    {
        internal static EntityLinkingResultWithDetectedLanguage DeserializeEntityLinkingResultWithDetectedLanguage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<LinkedEntity> entities = default;
            string id = default;
            IReadOnlyList<DocumentWarning> warnings = default;
            Optional<DocumentStatistics> statistics = default;
            Optional<DetectedLanguage> detectedLanguage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"u8))
                {
                    List<LinkedEntity> array = new List<LinkedEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedEntity.DeserializeLinkedEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = DocumentStatistics.DeserializeDocumentStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("detectedLanguage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectedLanguage = DetectedLanguage.DeserializeDetectedLanguage(property.Value);
                    continue;
                }
            }
            return new EntityLinkingResultWithDetectedLanguage(entities, id, warnings, statistics.Value, detectedLanguage.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EntityLinkingResultWithDetectedLanguage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEntityLinkingResultWithDetectedLanguage(document.RootElement);
        }
    }
}
