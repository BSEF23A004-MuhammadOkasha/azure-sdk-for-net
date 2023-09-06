// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The KPI participant profile metadata. </summary>
    public partial class KpiParticipantProfilesMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KpiParticipantProfilesMetadata"/>. </summary>
        /// <param name="typeName"> Name of the type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="typeName"/> is null. </exception>
        internal KpiParticipantProfilesMetadata(string typeName)
        {
            Argument.AssertNotNull(typeName, nameof(typeName));

            TypeName = typeName;
        }

        /// <summary> Initializes a new instance of <see cref="KpiParticipantProfilesMetadata"/>. </summary>
        /// <param name="typeName"> Name of the type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KpiParticipantProfilesMetadata(string typeName, Dictionary<string, BinaryData> rawData)
        {
            TypeName = typeName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KpiParticipantProfilesMetadata"/> for deserialization. </summary>
        internal KpiParticipantProfilesMetadata()
        {
        }

        /// <summary> Name of the type. </summary>
        public string TypeName { get; }
    }
}
