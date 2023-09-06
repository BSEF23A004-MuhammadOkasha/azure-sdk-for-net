// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Orc write settings. </summary>
    public partial class OrcWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of <see cref="OrcWriteSettings"/>. </summary>
        public OrcWriteSettings()
        {
            FormatWriteSettingsType = "OrcWriteSettings";
        }

        /// <summary> Initializes a new instance of <see cref="OrcWriteSettings"/>. </summary>
        /// <param name="formatWriteSettingsType"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="maxRowsPerFile"> Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="fileNamePrefix"> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </param>
        internal OrcWriteSettings(string formatWriteSettingsType, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<int> maxRowsPerFile, DataFactoryElement<string> fileNamePrefix) : base(formatWriteSettingsType, additionalProperties)
        {
            MaxRowsPerFile = maxRowsPerFile;
            FileNamePrefix = fileNamePrefix;
            FormatWriteSettingsType = formatWriteSettingsType ?? "OrcWriteSettings";
        }

        /// <summary> Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> MaxRowsPerFile { get; set; }
        /// <summary> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileNamePrefix { get; set; }
    }
}
