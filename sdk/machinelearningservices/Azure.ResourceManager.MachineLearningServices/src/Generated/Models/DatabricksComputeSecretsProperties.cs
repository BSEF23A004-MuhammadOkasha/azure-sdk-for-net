// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Properties of Databricks Compute Secrets. </summary>
    internal partial class DatabricksComputeSecretsProperties
    {
        /// <summary> Initializes a new instance of DatabricksComputeSecretsProperties. </summary>
        internal DatabricksComputeSecretsProperties()
        {
        }

        /// <summary> Initializes a new instance of DatabricksComputeSecretsProperties. </summary>
        /// <param name="databricksAccessToken"> access token for databricks account. </param>
        internal DatabricksComputeSecretsProperties(string databricksAccessToken)
        {
            DatabricksAccessToken = databricksAccessToken;
        }

        /// <summary> access token for databricks account. </summary>
        public string DatabricksAccessToken { get; }
    }
}
