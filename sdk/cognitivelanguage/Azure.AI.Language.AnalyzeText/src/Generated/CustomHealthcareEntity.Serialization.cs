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
    public partial class CustomHealthcareEntity
    {
        internal static CustomHealthcareEntity DeserializeCustomHealthcareEntity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EntityComponentInformation>> entityComponentInformation = default;
            string text = default;
            HealthcareEntityCategory category = default;
            Optional<string> subcategory = default;
            int offset = default;
            int length = default;
            double confidenceScore = default;
            Optional<HealthcareAssertion> assertion = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<HealthcareEntityLink>> links = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entityComponentInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EntityComponentInformation> array = new List<EntityComponentInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzeText.EntityComponentInformation.DeserializeEntityComponentInformation(item));
                    }
                    entityComponentInformation = array;
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = new HealthcareEntityCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subcategory"u8))
                {
                    subcategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("assertion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assertion = HealthcareAssertion.DeserializeHealthcareAssertion(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("links"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareEntityLink> array = new List<HealthcareEntityLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntityLink.DeserializeHealthcareEntityLink(item));
                    }
                    links = array;
                    continue;
                }
            }
            return new CustomHealthcareEntity(text, category, subcategory.Value, offset, length, confidenceScore, assertion.Value, name.Value, Optional.ToList(links), Optional.ToList(entityComponentInformation));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new CustomHealthcareEntity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCustomHealthcareEntity(document.RootElement);
        }
    }
}
