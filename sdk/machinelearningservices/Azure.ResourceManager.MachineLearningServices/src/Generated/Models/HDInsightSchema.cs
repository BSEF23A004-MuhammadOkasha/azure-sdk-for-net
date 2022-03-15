// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The HDInsightSchema. </summary>
    internal partial class HDInsightSchema
    {
        /// <summary> Initializes a new instance of HDInsightSchema. </summary>
        public HDInsightSchema()
        {
        }

        /// <summary> Initializes a new instance of HDInsightSchema. </summary>
        /// <param name="properties"> HDInsight compute properties. </param>
        internal HDInsightSchema(HDInsightProperties properties)
        {
            Properties = properties;
        }

        /// <summary> HDInsight compute properties. </summary>
        public HDInsightProperties Properties { get; set; }
    }
}
