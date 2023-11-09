// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Response from a list skillset request. If successful, it includes the full definitions of all skillsets. </summary>
    internal partial class ListSkillsetsResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListSkillsetsResult"/>. </summary>
        /// <param name="skillsets"> The skillsets defined in the Search service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsets"/> is null. </exception>
        internal ListSkillsetsResult(IEnumerable<SearchIndexerSkillset> skillsets)
        {
            Argument.AssertNotNull(skillsets, nameof(skillsets));

            Skillsets = skillsets.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ListSkillsetsResult"/>. </summary>
        /// <param name="skillsets"> The skillsets defined in the Search service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListSkillsetsResult(IReadOnlyList<SearchIndexerSkillset> skillsets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Skillsets = skillsets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ListSkillsetsResult"/> for deserialization. </summary>
        internal ListSkillsetsResult()
        {
        }

        /// <summary> The skillsets defined in the Search service. </summary>
        public IReadOnlyList<SearchIndexerSkillset> Skillsets { get; }
    }
}
