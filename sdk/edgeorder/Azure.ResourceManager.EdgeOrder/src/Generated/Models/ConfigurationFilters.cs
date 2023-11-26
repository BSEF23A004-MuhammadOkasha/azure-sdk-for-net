// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Configuration filters. </summary>
    public partial class ConfigurationFilters
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

        /// <summary> Initializes a new instance of <see cref="ConfigurationFilters"/>. </summary>
        /// <param name="hierarchyInformation"> Product hierarchy information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hierarchyInformation"/> is null. </exception>
        public ConfigurationFilters(HierarchyInformation hierarchyInformation)
        {
            Argument.AssertNotNull(hierarchyInformation, nameof(hierarchyInformation));

            HierarchyInformation = hierarchyInformation;
            FilterableProperty = new ChangeTrackingList<FilterableProperty>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationFilters"/>. </summary>
        /// <param name="hierarchyInformation"> Product hierarchy information. </param>
        /// <param name="filterableProperty"> Filters specific to product. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigurationFilters(HierarchyInformation hierarchyInformation, IList<FilterableProperty> filterableProperty, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HierarchyInformation = hierarchyInformation;
            FilterableProperty = filterableProperty;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationFilters"/> for deserialization. </summary>
        internal ConfigurationFilters()
        {
        }

        /// <summary> Product hierarchy information. </summary>
        public HierarchyInformation HierarchyInformation { get; }
        /// <summary> Filters specific to product. </summary>
        public IList<FilterableProperty> FilterableProperty { get; }
    }
}
