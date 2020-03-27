// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Models
{
    /// <summary> A character filter that applies mappings defined with the mappings option. Matching is greedy (longest pattern matching at a given point wins). Replacement is allowed to be the empty string. This character filter is implemented using Apache Lucene. </summary>
    public partial class MappingCharFilter : CharFilter
    {
        /// <summary> Initializes a new instance of MappingCharFilter. </summary>
        /// <param name="mappings"> A list of mappings of the following format: &quot;a=&gt;b&quot; (all occurrences of the character &quot;a&quot; will be replaced with character &quot;b&quot;). </param>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public MappingCharFilter(IEnumerable<string> mappings, string name) : base(name)
        {
            if (mappings == null)
            {
                throw new ArgumentNullException(nameof(mappings));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Mappings = mappings.ToArray();
            ODataType = "#Microsoft.Azure.Search.MappingCharFilter";
        }

        /// <summary> Initializes a new instance of MappingCharFilter. </summary>
        /// <param name="mappings"> A list of mappings of the following format: &quot;a=&gt;b&quot; (all occurrences of the character &quot;a&quot; will be replaced with character &quot;b&quot;). </param>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal MappingCharFilter(IList<string> mappings, string oDataType, string name) : base(oDataType, name)
        {
            Mappings = mappings;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.MappingCharFilter";
        }

        /// <summary> A list of mappings of the following format: &quot;a=&gt;b&quot; (all occurrences of the character &quot;a&quot; will be replaced with character &quot;b&quot;). </summary>
        public IList<string> Mappings { get; }
    }
}
