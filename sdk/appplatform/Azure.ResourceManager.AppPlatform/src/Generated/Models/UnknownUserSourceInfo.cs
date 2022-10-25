// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The UnknownUserSourceInfo. </summary>
    internal partial class UnknownUserSourceInfo : UserSourceInfo
    {
        /// <summary> Initializes a new instance of UnknownUserSourceInfo. </summary>
        /// <param name="userSourceInfoType"> Type of the source uploaded. </param>
        /// <param name="version"> Version of the source. </param>
        internal UnknownUserSourceInfo(string userSourceInfoType, string version) : base(userSourceInfoType, version)
        {
            UserSourceInfoType = userSourceInfoType ?? "Unknown";
        }
    }
}
