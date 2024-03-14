// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Gallery information for a workbook template. </summary>
    public partial class WorkbookTemplateGallery
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

        /// <summary> Initializes a new instance of <see cref="WorkbookTemplateGallery"/>. </summary>
        public WorkbookTemplateGallery()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkbookTemplateGallery"/>. </summary>
        /// <param name="name"> Name of the workbook template in the gallery. </param>
        /// <param name="category"> Category for the gallery. </param>
        /// <param name="workbookTemplateGalleryType"> Type of workbook supported by the workbook template. </param>
        /// <param name="order"> Order of the template within the gallery. </param>
        /// <param name="resourceType"> Azure resource type supported by the gallery. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkbookTemplateGallery(string name, string category, string workbookTemplateGalleryType, int? order, string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Category = category;
            WorkbookTemplateGalleryType = workbookTemplateGalleryType;
            Order = order;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the workbook template in the gallery. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> Category for the gallery. </summary>
        [WirePath("category")]
        public string Category { get; set; }
        /// <summary> Type of workbook supported by the workbook template. </summary>
        [WirePath("type")]
        public string WorkbookTemplateGalleryType { get; set; }
        /// <summary> Order of the template within the gallery. </summary>
        [WirePath("order")]
        public int? Order { get; set; }
        /// <summary> Azure resource type supported by the gallery. </summary>
        [WirePath("resourceType")]
        public string ResourceType { get; set; }
    }
}
