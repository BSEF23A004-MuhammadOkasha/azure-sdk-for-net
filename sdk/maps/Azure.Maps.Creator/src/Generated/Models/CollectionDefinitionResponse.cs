// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    /// <summary> collection of GeoJSON features. </summary>
    public partial class CollectionDefinitionResponse
    {
        /// <summary> Initializes a new instance of CollectionDefinitionResponse. </summary>
        /// <param name="idPrefix"> prefix of the collection used. </param>
        /// <param name="name"> identifier of the collection used, for example, in URIs. </param>
        /// <param name="geometryType"> type of geometry returned. </param>
        /// <param name="featureTypes"> type of features returned. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="idPrefix"/>, <paramref name="name"/>, or <paramref name="featureTypes"/> is null. </exception>
        internal CollectionDefinitionResponse(string idPrefix, string name, GeoJsonGeometryType geometryType, IEnumerable<string> featureTypes)
        {
            if (idPrefix == null)
            {
                throw new ArgumentNullException(nameof(idPrefix));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (featureTypes == null)
            {
                throw new ArgumentNullException(nameof(featureTypes));
            }

            IdPrefix = idPrefix;
            Name = name;
            GeometryType = geometryType;
            FeatureTypes = featureTypes.ToList();
            Properties = new ChangeTrackingList<DefinitionProperties>();
            Links = new ChangeTrackingList<WfsEndpointLink>();
        }

        /// <summary> Initializes a new instance of CollectionDefinitionResponse. </summary>
        /// <param name="description"> describes the collection. </param>
        /// <param name="idPrefix"> prefix of the collection used. </param>
        /// <param name="name"> identifier of the collection used, for example, in URIs. </param>
        /// <param name="title"> title of collection. </param>
        /// <param name="ontology"> The ontology version of this dataset. </param>
        /// <param name="geometryType"> type of geometry returned. </param>
        /// <param name="featureTypes"> type of features returned. </param>
        /// <param name="properties"> attributes of the collection used. </param>
        /// <param name="links"> Links to other WFS endpoints. </param>
        internal CollectionDefinitionResponse(string description, string idPrefix, string name, string title, string ontology, GeoJsonGeometryType geometryType, IReadOnlyList<string> featureTypes, IReadOnlyList<DefinitionProperties> properties, IReadOnlyList<WfsEndpointLink> links)
        {
            Description = description;
            IdPrefix = idPrefix;
            Name = name;
            Title = title;
            Ontology = ontology;
            GeometryType = geometryType;
            FeatureTypes = featureTypes;
            Properties = properties;
            Links = links;
        }

        /// <summary> describes the collection. </summary>
        public string Description { get; }
        /// <summary> prefix of the collection used. </summary>
        public string IdPrefix { get; }
        /// <summary> identifier of the collection used, for example, in URIs. </summary>
        public string Name { get; }
        /// <summary> title of collection. </summary>
        public string Title { get; }
        /// <summary> The ontology version of this dataset. </summary>
        public string Ontology { get; }
        /// <summary> type of geometry returned. </summary>
        public GeoJsonGeometryType GeometryType { get; }
        /// <summary> type of features returned. </summary>
        public IReadOnlyList<string> FeatureTypes { get; }
        /// <summary> attributes of the collection used. </summary>
        public IReadOnlyList<DefinitionProperties> Properties { get; }
        /// <summary> Links to other WFS endpoints. </summary>
        public IReadOnlyList<WfsEndpointLink> Links { get; }
    }
}
