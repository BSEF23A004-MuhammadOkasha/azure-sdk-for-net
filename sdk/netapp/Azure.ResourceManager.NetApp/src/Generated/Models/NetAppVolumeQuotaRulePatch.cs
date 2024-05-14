// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Patchable Quota Rule of a Volume. </summary>
    public partial class NetAppVolumeQuotaRulePatch
    {
        /// <summary> Initializes a new instance of <see cref="NetAppVolumeQuotaRulePatch"/>. </summary>
        public NetAppVolumeQuotaRulePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeQuotaRulePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="provisioningState"> Gets the status of the VolumeQuotaRule at the time the operation was called. </param>
        /// <param name="quotaSizeInKiBs"> Size of quota. </param>
        /// <param name="quotaType"> Type of quota. </param>
        /// <param name="quotaTarget"> UserID/GroupID/SID based on the quota target type. UserID and groupID can be found by running ‘id’ or ‘getent’ command for the user or group and SID can be found by running &lt;wmic useraccount where name='user-name' get sid&gt;. </param>
        internal NetAppVolumeQuotaRulePatch(IDictionary<string, string> tags, NetAppProvisioningState? provisioningState, long? quotaSizeInKiBs, NetAppVolumeQuotaType? quotaType, string quotaTarget)
        {
            Tags = tags;
            ProvisioningState = provisioningState;
            QuotaSizeInKiBs = quotaSizeInKiBs;
            QuotaType = quotaType;
            QuotaTarget = quotaTarget;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets the status of the VolumeQuotaRule at the time the operation was called. </summary>
        public NetAppProvisioningState? ProvisioningState { get; }
        /// <summary> Size of quota. </summary>
        public long? QuotaSizeInKiBs { get; set; }
        /// <summary> Type of quota. </summary>
        public NetAppVolumeQuotaType? QuotaType { get; set; }
        /// <summary> UserID/GroupID/SID based on the quota target type. UserID and groupID can be found by running ‘id’ or ‘getent’ command for the user or group and SID can be found by running &lt;wmic useraccount where name='user-name' get sid&gt;. </summary>
        public string QuotaTarget { get; set; }
    }
}
