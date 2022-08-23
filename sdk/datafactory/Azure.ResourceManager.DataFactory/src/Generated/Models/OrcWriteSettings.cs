// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Orc write settings. </summary>
    public partial class OrcWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of OrcWriteSettings. </summary>
        public OrcWriteSettings()
        {
            FormatWriteSettingsType = "OrcWriteSettings";
        }

        /// <summary> Initializes a new instance of OrcWriteSettings. </summary>
        /// <param name="formatWriteSettingsType"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="maxRowsPerFile"> Limit the written file&apos;s row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="fileNamePrefix"> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </param>
        internal OrcWriteSettings(string formatWriteSettingsType, IDictionary<string, BinaryData> additionalProperties, BinaryData maxRowsPerFile, BinaryData fileNamePrefix) : base(formatWriteSettingsType, additionalProperties)
        {
            MaxRowsPerFile = maxRowsPerFile;
            FileNamePrefix = fileNamePrefix;
            FormatWriteSettingsType = formatWriteSettingsType ?? "OrcWriteSettings";
        }

        /// <summary>
        /// Limit the written file&apos;s row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer).
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
        public BinaryData MaxRowsPerFile { get; set; }
        /// <summary>
        /// Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string).
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
        public BinaryData FileNamePrefix { get; set; }
    }
}
