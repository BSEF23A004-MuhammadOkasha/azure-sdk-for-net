// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class CollectionDefinitionResponse
    {
        internal static CollectionDefinitionResponse DeserializeCollectionDefinitionResponse(JsonElement element)
        {
            Optional<string> description = default;
            string idPrefix = default;
            string name = default;
            Optional<string> title = default;
            Optional<string> ontology = default;
            GeoJsonGeometryType geometryType = default;
            IReadOnlyList<string> featureTypes = default;
            Optional<IReadOnlyList<DefinitionProperties>> properties = default;
            Optional<IReadOnlyList<WfsEndpointLink>> links = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("idPrefix"))
                {
                    idPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ontology"))
                {
                    ontology = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("geometryType"))
                {
                    geometryType = new GeoJsonGeometryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("featureTypes"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    featureTypes = array;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DefinitionProperties> array = new List<DefinitionProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DefinitionProperties.DeserializeDefinitionProperties(item));
                    }
                    properties = array;
                    continue;
                }
                if (property.NameEquals("links"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WfsEndpointLink> array = new List<WfsEndpointLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WfsEndpointLink.DeserializeWfsEndpointLink(item));
                    }
                    links = array;
                    continue;
                }
            }
            return new CollectionDefinitionResponse(description.Value, idPrefix, name, title.Value, ontology.Value, geometryType, featureTypes, Optional.ToList(properties), Optional.ToList(links));
        }
    }
}
