// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    public partial class DetectedLanguage
    {
        internal static DetectedLanguage DeserializeDetectedLanguage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string iso6391Name = default;
            double confidenceScore = default;
            Optional<ScriptKind> script = default;
            Optional<ScriptCode> scriptCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iso6391Name"u8))
                {
                    iso6391Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("script"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    script = new ScriptKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scriptCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scriptCode = new ScriptCode(property.Value.GetString());
                    continue;
                }
            }
            return new DetectedLanguage(name, iso6391Name, confidenceScore, Optional.ToNullable(script), Optional.ToNullable(scriptCode));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DetectedLanguage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDetectedLanguage(document.RootElement);
        }
    }
}
