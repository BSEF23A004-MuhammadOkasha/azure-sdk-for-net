// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The location of http server. </summary>
    public partial class HttpServerLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of HttpServerLocation. </summary>
        public HttpServerLocation()
        {
            DatasetLocationType = "HttpServerLocation";
        }

        /// <summary> Initializes a new instance of HttpServerLocation. </summary>
        /// <param name="datasetLocationType"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="relativeUri"> Specify the relativeUrl of http server. Type: string (or Expression with resultType string). </param>
        internal HttpServerLocation(string datasetLocationType, BinaryData folderPath, BinaryData fileName, IDictionary<string, BinaryData> additionalProperties, BinaryData relativeUri) : base(datasetLocationType, folderPath, fileName, additionalProperties)
        {
            RelativeUri = relativeUri;
            DatasetLocationType = datasetLocationType ?? "HttpServerLocation";
        }

        /// <summary>
        /// Specify the relativeUrl of http server. Type: string (or Expression with resultType string)
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData RelativeUri { get; set; }
    }
}
