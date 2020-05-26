// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Resources.Models
{
    /// <summary> The debug setting. </summary>
    public partial class DebugSetting
    {
        /// <summary> Initializes a new instance of DebugSetting. </summary>
        public DebugSetting()
        {
        }

        /// <summary> Initializes a new instance of DebugSetting. </summary>
        /// <param name="detailLevel"> Specifies the type of information to log for debugging. The permitted values are none, requestContent, responseContent, or both requestContent and responseContent separated by a comma. The default is none. When setting this value, carefully consider the type of information you are passing in during deployment. By logging information about the request or response, you could potentially expose sensitive data that is retrieved through the deployment operations. </param>
        internal DebugSetting(string detailLevel)
        {
            DetailLevel = detailLevel;
        }

        /// <summary> Specifies the type of information to log for debugging. The permitted values are none, requestContent, responseContent, or both requestContent and responseContent separated by a comma. The default is none. When setting this value, carefully consider the type of information you are passing in during deployment. By logging information about the request or response, you could potentially expose sensitive data that is retrieved through the deployment operations. </summary>
        public string DetailLevel { get; set; }
    }
}
