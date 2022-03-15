// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The DatabricksSchema. </summary>
    internal partial class DatabricksSchema
    {
        /// <summary> Initializes a new instance of DatabricksSchema. </summary>
        public DatabricksSchema()
        {
        }

        /// <summary> Initializes a new instance of DatabricksSchema. </summary>
        /// <param name="properties"> Properties of Databricks. </param>
        internal DatabricksSchema(DatabricksProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Properties of Databricks. </summary>
        public DatabricksProperties Properties { get; set; }
    }
}
