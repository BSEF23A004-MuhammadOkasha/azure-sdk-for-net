// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Part of the solution and are dividers in the solution rendering. </summary>
    public partial class SelfHelpSection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SelfHelpSection"/>. </summary>
        public SelfHelpSection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelpSection"/>. </summary>
        /// <param name="title"> Solution sections title. </param>
        /// <param name="content"> Solution sections content. </param>
        /// <param name="replacementMaps"> Solution replacement maps. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SelfHelpSection(string title, string content, ReplacementMaps replacementMaps, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Title = title;
            Content = content;
            ReplacementMaps = replacementMaps;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Solution sections title. </summary>
        public string Title { get; set; }
        /// <summary> Solution sections content. </summary>
        public string Content { get; set; }
        /// <summary> Solution replacement maps. </summary>
        public ReplacementMaps ReplacementMaps { get; set; }
    }
}
