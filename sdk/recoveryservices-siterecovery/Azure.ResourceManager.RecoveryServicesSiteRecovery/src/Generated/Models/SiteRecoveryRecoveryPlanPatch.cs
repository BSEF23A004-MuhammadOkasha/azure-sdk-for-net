// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Update recovery plan input class. </summary>
    public partial class SiteRecoveryRecoveryPlanPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRecoveryPlanPatch"/>. </summary>
        public SiteRecoveryRecoveryPlanPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRecoveryPlanPatch"/>. </summary>
        /// <param name="properties"> Recovery plan update properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryRecoveryPlanPatch(UpdateRecoveryPlanContentProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Recovery plan update properties. </summary>
        internal UpdateRecoveryPlanContentProperties Properties { get; set; }
        /// <summary> The recovery plan groups. </summary>
        public IList<SiteRecoveryPlanGroup> UpdateRecoveryPlanContentGroups
        {
            get
            {
                if (Properties is null)
                    Properties = new UpdateRecoveryPlanContentProperties();
                return Properties.Groups;
            }
        }
    }
}
