// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> Object received from the registry containing the list of schema groups and link to next batch page. </summary>
    internal partial class SchemaGroups
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SchemaGroups"/>. </summary>
        internal SchemaGroups()
        {
            Groups = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SchemaGroups"/>. </summary>
        /// <param name="groups"> Array of schema groups. </param>
        /// <param name="nextLink"> URl to next batch of schema groups. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SchemaGroups(IReadOnlyList<string> groups, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Groups = groups;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of schema groups. </summary>
        public IReadOnlyList<string> Groups { get; }
        /// <summary> URl to next batch of schema groups. </summary>
        public string NextLink { get; }
    }
}
