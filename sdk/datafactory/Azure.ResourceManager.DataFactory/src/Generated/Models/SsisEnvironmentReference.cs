// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Ssis environment reference. </summary>
    public partial class SsisEnvironmentReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SsisEnvironmentReference"/>. </summary>
        internal SsisEnvironmentReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SsisEnvironmentReference"/>. </summary>
        /// <param name="id"> Environment reference id. </param>
        /// <param name="environmentFolderName"> Environment folder name. </param>
        /// <param name="environmentName"> Environment name. </param>
        /// <param name="referenceType"> Reference type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisEnvironmentReference(long? id, string environmentFolderName, string environmentName, string referenceType, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            EnvironmentFolderName = environmentFolderName;
            EnvironmentName = environmentName;
            ReferenceType = referenceType;
            _rawData = rawData;
        }

        /// <summary> Environment reference id. </summary>
        public long? Id { get; }
        /// <summary> Environment folder name. </summary>
        public string EnvironmentFolderName { get; }
        /// <summary> Environment name. </summary>
        public string EnvironmentName { get; }
        /// <summary> Reference type. </summary>
        public string ReferenceType { get; }
    }
}
