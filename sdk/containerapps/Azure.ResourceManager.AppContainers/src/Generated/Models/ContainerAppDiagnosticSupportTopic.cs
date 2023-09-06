// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Support topic information. </summary>
    public partial class ContainerAppDiagnosticSupportTopic
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticSupportTopic"/>. </summary>
        public ContainerAppDiagnosticSupportTopic()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticSupportTopic"/>. </summary>
        /// <param name="id"> Unique topic identifier. </param>
        /// <param name="pesId"> PES identifier. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppDiagnosticSupportTopic(string id, string pesId, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            PesId = pesId;
            _rawData = rawData;
        }

        /// <summary> Unique topic identifier. </summary>
        public string Id { get; }
        /// <summary> PES identifier. </summary>
        public string PesId { get; }
    }
}
