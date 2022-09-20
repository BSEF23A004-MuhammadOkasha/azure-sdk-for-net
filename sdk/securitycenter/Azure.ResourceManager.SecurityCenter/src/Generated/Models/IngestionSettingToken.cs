// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Configures how to correlate scan data and logs with resources associated with the subscription. </summary>
    public partial class IngestionSettingToken
    {
        /// <summary> Initializes a new instance of IngestionSettingToken. </summary>
        internal IngestionSettingToken()
        {
        }

        /// <summary> Initializes a new instance of IngestionSettingToken. </summary>
        /// <param name="token"> The token is used for correlating security data and logs with the resources in the subscription. </param>
        internal IngestionSettingToken(string token)
        {
            Token = token;
        }

        /// <summary> The token is used for correlating security data and logs with the resources in the subscription. </summary>
        public string Token { get; }
    }
}
