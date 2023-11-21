// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of manifest attributes. </summary>
    internal partial class ManifestAttributesManifest
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManifestAttributesManifest"/>. </summary>
        internal ManifestAttributesManifest()
        {
            References = new ChangeTrackingList<ArtifactManifestPlatform>();
        }

        /// <summary> Initializes a new instance of <see cref="ManifestAttributesManifest"/>. </summary>
        /// <param name="references"> List of manifest attributes details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManifestAttributesManifest(IReadOnlyList<ArtifactManifestPlatform> references, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            References = references;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of manifest attributes details. </summary>
        public IReadOnlyList<ArtifactManifestPlatform> References { get; }
    }
}
