// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Recovery plan provider specific input base class.
    /// Please note <see cref="RecoveryPlanProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RecoveryPlanA2AContent"/>.
    /// </summary>
    public abstract partial class RecoveryPlanProviderSpecificContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanProviderSpecificContent"/>. </summary>
        protected RecoveryPlanProviderSpecificContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryPlanProviderSpecificContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceType = instanceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the Instance type. </summary>
        internal string InstanceType { get; set; }
    }
}
