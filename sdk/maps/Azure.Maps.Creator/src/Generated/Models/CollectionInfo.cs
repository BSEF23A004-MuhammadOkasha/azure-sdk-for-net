// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Creator.Models
{
    /// <summary> The CollectionInfo. </summary>
    public partial class CollectionInfo
    {
        /// <summary> Initializes a new instance of CollectionInfo. </summary>
        /// <param name="name"> identifier of the collection used, for example, in URIs. </param>
        /// <param name="links"> Links to other WFS endpoints. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="links"/> is null. </exception>
        internal CollectionInfo(string name, IEnumerable<WfsEndpointLink> links)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (links == null)
            {
                throw new ArgumentNullException(nameof(links));
            }

            Name = name;
            Links = links.ToList();
        }

        /// <summary> Initializes a new instance of CollectionInfo. </summary>
        /// <param name="name"> identifier of the collection used, for example, in URIs. </param>
        /// <param name="title"> human readable title of the collection. </param>
        /// <param name="ontology"> The ontology version of this dataset. </param>
        /// <param name="description"> a description of the features in the collection. </param>
        /// <param name="links"> Links to other WFS endpoints. </param>
        internal CollectionInfo(string name, string title, string ontology, string description, IReadOnlyList<WfsEndpointLink> links)
        {
            Name = name;
            Title = title;
            Ontology = ontology;
            Description = description;
            Links = links;
        }

        /// <summary> identifier of the collection used, for example, in URIs. </summary>
        public string Name { get; }
        /// <summary> human readable title of the collection. </summary>
        public string Title { get; }
        /// <summary> The ontology version of this dataset. </summary>
        public string Ontology { get; }
        /// <summary> a description of the features in the collection. </summary>
        public string Description { get; }
        /// <summary> Links to other WFS endpoints. </summary>
        public IReadOnlyList<WfsEndpointLink> Links { get; }
    }
}
