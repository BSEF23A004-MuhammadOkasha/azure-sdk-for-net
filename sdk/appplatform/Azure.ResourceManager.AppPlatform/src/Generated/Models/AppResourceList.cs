// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of App resources and a possible link for next set. </summary>
    internal partial class AppResourceList
    {
        /// <summary> Initializes a new instance of AppResourceList. </summary>
        internal AppResourceList()
        {
            Value = new ChangeTrackingList<AppPlatformAppResourceData>();
        }

        /// <summary> Initializes a new instance of AppResourceList. </summary>
        /// <param name="value"> Collection of App resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal AppResourceList(IReadOnlyList<AppPlatformAppResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of App resources. </summary>
        public IReadOnlyList<AppPlatformAppResourceData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
