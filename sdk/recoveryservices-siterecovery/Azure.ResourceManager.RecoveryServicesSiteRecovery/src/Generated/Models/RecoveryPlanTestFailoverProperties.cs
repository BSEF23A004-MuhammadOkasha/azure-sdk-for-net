// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan test failover input properties. </summary>
    public partial class RecoveryPlanTestFailoverProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanTestFailoverProperties"/>. </summary>
        /// <param name="failoverDirection"> The failover direction. </param>
        /// <param name="networkType"> The network type to be used for test failover. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkType"/> is null. </exception>
        public RecoveryPlanTestFailoverProperties(PossibleOperationsDirection failoverDirection, string networkType)
        {
            if (networkType == null)
            {
                throw new ArgumentNullException(nameof(networkType));
            }

            FailoverDirection = failoverDirection;
            NetworkType = networkType;
            ProviderSpecificDetails = new ChangeTrackingList<RecoveryPlanProviderSpecificFailoverContent>();
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanTestFailoverProperties"/>. </summary>
        /// <param name="failoverDirection"> The failover direction. </param>
        /// <param name="networkType"> The network type to be used for test failover. </param>
        /// <param name="networkId"> The Id of the network to be used for test failover. </param>
        /// <param name="providerSpecificDetails">
        /// The provider specific properties.
        /// Please note <see cref="RecoveryPlanProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailbackContent"/>, <see cref="RecoveryPlanInMageFailoverContent"/>, <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>, <see cref="RecoveryPlanInMageRcmFailoverContent"/> and <see cref="RecoveryPlanInMageRcmFailbackFailoverContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryPlanTestFailoverProperties(PossibleOperationsDirection failoverDirection, string networkType, ResourceIdentifier networkId, IList<RecoveryPlanProviderSpecificFailoverContent> providerSpecificDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FailoverDirection = failoverDirection;
            NetworkType = networkType;
            NetworkId = networkId;
            ProviderSpecificDetails = providerSpecificDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanTestFailoverProperties"/> for deserialization. </summary>
        internal RecoveryPlanTestFailoverProperties()
        {
        }

        /// <summary> The failover direction. </summary>
        public PossibleOperationsDirection FailoverDirection { get; }
        /// <summary> The network type to be used for test failover. </summary>
        public string NetworkType { get; }
        /// <summary> The Id of the network to be used for test failover. </summary>
        public ResourceIdentifier NetworkId { get; set; }
        /// <summary>
        /// The provider specific properties.
        /// Please note <see cref="RecoveryPlanProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailbackContent"/>, <see cref="RecoveryPlanInMageFailoverContent"/>, <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>, <see cref="RecoveryPlanInMageRcmFailoverContent"/> and <see cref="RecoveryPlanInMageRcmFailbackFailoverContent"/>.
        /// </summary>
        public IList<RecoveryPlanProviderSpecificFailoverContent> ProviderSpecificDetails { get; }
    }
}
