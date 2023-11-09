// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Input field mapping for a skill. </summary>
    public partial class InputFieldMappingEntry
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InputFieldMappingEntry"/>. </summary>
        /// <param name="name"> The name of the input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public InputFieldMappingEntry(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Inputs = new ChangeTrackingList<InputFieldMappingEntry>();
        }

        /// <summary> Initializes a new instance of <see cref="InputFieldMappingEntry"/>. </summary>
        /// <param name="name"> The name of the input. </param>
        /// <param name="source"> The source of the input. </param>
        /// <param name="sourceContext"> The source context used for selecting recursive inputs. </param>
        /// <param name="inputs"> The recursive inputs used when creating a complex type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InputFieldMappingEntry(string name, string source, string sourceContext, IList<InputFieldMappingEntry> inputs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Source = source;
            SourceContext = sourceContext;
            Inputs = inputs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InputFieldMappingEntry"/> for deserialization. </summary>
        internal InputFieldMappingEntry()
        {
        }

        /// <summary> The name of the input. </summary>
        public string Name { get; set; }
        /// <summary> The source of the input. </summary>
        public string Source { get; set; }
        /// <summary> The source context used for selecting recursive inputs. </summary>
        public string SourceContext { get; set; }
    }
}
