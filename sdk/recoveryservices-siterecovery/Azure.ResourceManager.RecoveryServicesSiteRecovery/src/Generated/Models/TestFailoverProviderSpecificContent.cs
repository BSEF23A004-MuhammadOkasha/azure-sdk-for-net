// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Provider specific test failover input.
    /// Please note <see cref="TestFailoverProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2ATestFailoverContent"/>, <see cref="HyperVReplicaAzureTestFailoverContent"/>, <see cref="InMageTestFailoverContent"/>, <see cref="InMageAzureV2TestFailoverContent"/> and <see cref="InMageRcmTestFailoverContent"/>.
    /// </summary>
    public abstract partial class TestFailoverProviderSpecificContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TestFailoverProviderSpecificContent"/>. </summary>
        protected TestFailoverProviderSpecificContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TestFailoverProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TestFailoverProviderSpecificContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceType = instanceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
