// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the origin group override action. </summary>
    public partial class OriginGroupOverrideActionProperties
    {
        /// <summary> Initializes a new instance of OriginGroupOverrideActionProperties. </summary>
        /// <param name="actionType"></param>
        /// <param name="originGroup"> defines the OriginGroup that would override the DefaultOriginGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroup"/> is null. </exception>
        public OriginGroupOverrideActionProperties(OriginGroupOverrideActionType actionType, WritableSubResource originGroup)
        {
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            ActionType = actionType;
            OriginGroup = originGroup;
        }

        /// <summary> Gets or sets the action type. </summary>
        public OriginGroupOverrideActionType ActionType { get; set; }
        /// <summary> defines the OriginGroup that would override the DefaultOriginGroup. </summary>
        internal WritableSubResource OriginGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginGroupId
        {
            get => OriginGroup is null ? default : OriginGroup.Id;
            set
            {
                if (OriginGroup is null)
                    OriginGroup = new WritableSubResource();
                OriginGroup.Id = value;
            }
        }
    }
}
