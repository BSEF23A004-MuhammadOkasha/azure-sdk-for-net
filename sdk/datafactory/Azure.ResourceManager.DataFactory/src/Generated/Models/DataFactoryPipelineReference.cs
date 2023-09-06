// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Pipeline reference type. </summary>
    public partial class DataFactoryPipelineReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineReference"/>. </summary>
        /// <param name="referenceType"> Pipeline reference type. </param>
        /// <param name="referenceName"> Reference pipeline name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public DataFactoryPipelineReference(DataFactoryPipelineReferenceType referenceType, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            ReferenceType = referenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineReference"/>. </summary>
        /// <param name="referenceType"> Pipeline reference type. </param>
        /// <param name="referenceName"> Reference pipeline name. </param>
        /// <param name="name"> Reference name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryPipelineReference(DataFactoryPipelineReferenceType referenceType, string referenceName, string name, Dictionary<string, BinaryData> rawData)
        {
            ReferenceType = referenceType;
            ReferenceName = referenceName;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineReference"/> for deserialization. </summary>
        internal DataFactoryPipelineReference()
        {
        }

        /// <summary> Pipeline reference type. </summary>
        public DataFactoryPipelineReferenceType ReferenceType { get; set; }
        /// <summary> Reference pipeline name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Reference name. </summary>
        public string Name { get; set; }
    }
}
