// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> List Restore Ranges Response. </summary>
    public partial class BackupFindRestorableTimeRangeResultProperties
    {
        /// <summary> Initializes a new instance of <see cref="BackupFindRestorableTimeRangeResultProperties"/>. </summary>
        public BackupFindRestorableTimeRangeResultProperties()
        {
            RestorableTimeRanges = new ChangeTrackingList<RestorableTimeRange>();
        }

        /// <summary> Initializes a new instance of <see cref="BackupFindRestorableTimeRangeResultProperties"/>. </summary>
        /// <param name="restorableTimeRanges"> Returns the Restore Ranges available on the Backup Instance. </param>
        /// <param name="objectType"></param>
        internal BackupFindRestorableTimeRangeResultProperties(IList<RestorableTimeRange> restorableTimeRanges, string objectType)
        {
            RestorableTimeRanges = restorableTimeRanges;
            ObjectType = objectType;
        }

        /// <summary> Returns the Restore Ranges available on the Backup Instance. </summary>
        public IList<RestorableTimeRange> RestorableTimeRanges { get; }
        /// <summary> Gets or sets the object type. </summary>
        public string ObjectType { get; set; }
    }
}
