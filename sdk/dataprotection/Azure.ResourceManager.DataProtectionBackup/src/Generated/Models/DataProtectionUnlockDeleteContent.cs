// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Request body of unlock delete API. </summary>
    public partial class DataProtectionUnlockDeleteContent
    {
        /// <summary> Initializes a new instance of <see cref="DataProtectionUnlockDeleteContent"/>. </summary>
        public DataProtectionUnlockDeleteContent()
        {
            ResourceGuardOperationRequests = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionUnlockDeleteContent"/>. </summary>
        /// <param name="resourceGuardOperationRequests"></param>
        /// <param name="resourceToBeDeleted"></param>
        internal DataProtectionUnlockDeleteContent(IList<string> resourceGuardOperationRequests, string resourceToBeDeleted)
        {
            ResourceGuardOperationRequests = resourceGuardOperationRequests;
            ResourceToBeDeleted = resourceToBeDeleted;
        }

        /// <summary> Gets the resource guard operation requests. </summary>
        public IList<string> ResourceGuardOperationRequests { get; }
        /// <summary> Gets or sets the resource to be deleted. </summary>
        public string ResourceToBeDeleted { get; set; }
    }
}
