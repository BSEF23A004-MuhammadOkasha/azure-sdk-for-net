// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Container extended information. </summary>
    public partial class GenericContainerExtendedInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GenericContainerExtendedInfo"/>. </summary>
        public GenericContainerExtendedInfo()
        {
            ServiceEndpoints = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="GenericContainerExtendedInfo"/>. </summary>
        /// <param name="rawCertData"> Public key of container cert. </param>
        /// <param name="containerIdentityInfo"> Container identity information. </param>
        /// <param name="serviceEndpoints"> Azure Backup Service Endpoints for the container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GenericContainerExtendedInfo(string rawCertData, ContainerIdentityInfo containerIdentityInfo, IDictionary<string, string> serviceEndpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RawCertData = rawCertData;
            ContainerIdentityInfo = containerIdentityInfo;
            ServiceEndpoints = serviceEndpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Public key of container cert. </summary>
        public string RawCertData { get; set; }
        /// <summary> Container identity information. </summary>
        public ContainerIdentityInfo ContainerIdentityInfo { get; set; }
        /// <summary> Azure Backup Service Endpoints for the container. </summary>
        public IDictionary<string, string> ServiceEndpoints { get; }
    }
}
