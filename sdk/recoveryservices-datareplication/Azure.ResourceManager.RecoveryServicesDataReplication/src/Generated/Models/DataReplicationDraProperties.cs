// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Dra model properties. </summary>
    public partial class DataReplicationDraProperties
    {
        /// <summary> Initializes a new instance of <see cref="DataReplicationDraProperties"/>. </summary>
        /// <param name="machineId"> Gets or sets the machine Id where Dra is running. </param>
        /// <param name="machineName"> Gets or sets the machine name where Dra is running. </param>
        /// <param name="authenticationIdentity"> Identity model. </param>
        /// <param name="resourceAccessIdentity"> Identity model. </param>
        /// <param name="customProperties">
        /// Dra model custom properties.
        /// Please note <see cref="DraModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeneralDraModelCustomProperties"/> and <see cref="VMwareDraModelCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineId"/>, <paramref name="machineName"/>, <paramref name="authenticationIdentity"/>, <paramref name="resourceAccessIdentity"/> or <paramref name="customProperties"/> is null. </exception>
        public DataReplicationDraProperties(string machineId, string machineName, DataReplicationIdentity authenticationIdentity, DataReplicationIdentity resourceAccessIdentity, DraModelCustomProperties customProperties)
        {
            Argument.AssertNotNull(machineId, nameof(machineId));
            Argument.AssertNotNull(machineName, nameof(machineName));
            Argument.AssertNotNull(authenticationIdentity, nameof(authenticationIdentity));
            Argument.AssertNotNull(resourceAccessIdentity, nameof(resourceAccessIdentity));
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            MachineId = machineId;
            MachineName = machineName;
            AuthenticationIdentity = authenticationIdentity;
            ResourceAccessIdentity = resourceAccessIdentity;
            HealthErrors = new ChangeTrackingList<DataReplicationHealthErrorInfo>();
            CustomProperties = customProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationDraProperties"/>. </summary>
        /// <param name="correlationId"> Gets or sets the Dra correlation Id. </param>
        /// <param name="machineId"> Gets or sets the machine Id where Dra is running. </param>
        /// <param name="machineName"> Gets or sets the machine name where Dra is running. </param>
        /// <param name="authenticationIdentity"> Identity model. </param>
        /// <param name="resourceAccessIdentity"> Identity model. </param>
        /// <param name="isResponsive"> Gets or sets a value indicating whether Dra is responsive. </param>
        /// <param name="lastHeartbeatOn"> Gets or sets the time when last heartbeat was sent by the Dra. </param>
        /// <param name="versionNumber"> Gets or sets the Dra version. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state of the Dra. </param>
        /// <param name="healthErrors"> Gets or sets the list of health errors. </param>
        /// <param name="customProperties">
        /// Dra model custom properties.
        /// Please note <see cref="DraModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeneralDraModelCustomProperties"/> and <see cref="VMwareDraModelCustomProperties"/>.
        /// </param>
        internal DataReplicationDraProperties(string correlationId, string machineId, string machineName, DataReplicationIdentity authenticationIdentity, DataReplicationIdentity resourceAccessIdentity, bool? isResponsive, DateTimeOffset? lastHeartbeatOn, string versionNumber, DataReplicationProvisioningState? provisioningState, IReadOnlyList<DataReplicationHealthErrorInfo> healthErrors, DraModelCustomProperties customProperties)
        {
            CorrelationId = correlationId;
            MachineId = machineId;
            MachineName = machineName;
            AuthenticationIdentity = authenticationIdentity;
            ResourceAccessIdentity = resourceAccessIdentity;
            IsResponsive = isResponsive;
            LastHeartbeatOn = lastHeartbeatOn;
            VersionNumber = versionNumber;
            ProvisioningState = provisioningState;
            HealthErrors = healthErrors;
            CustomProperties = customProperties;
        }

        /// <summary> Gets or sets the Dra correlation Id. </summary>
        public string CorrelationId { get; }
        /// <summary> Gets or sets the machine Id where Dra is running. </summary>
        public string MachineId { get; set; }
        /// <summary> Gets or sets the machine name where Dra is running. </summary>
        public string MachineName { get; set; }
        /// <summary> Identity model. </summary>
        public DataReplicationIdentity AuthenticationIdentity { get; set; }
        /// <summary> Identity model. </summary>
        public DataReplicationIdentity ResourceAccessIdentity { get; set; }
        /// <summary> Gets or sets a value indicating whether Dra is responsive. </summary>
        public bool? IsResponsive { get; }
        /// <summary> Gets or sets the time when last heartbeat was sent by the Dra. </summary>
        public DateTimeOffset? LastHeartbeatOn { get; }
        /// <summary> Gets or sets the Dra version. </summary>
        public string VersionNumber { get; }
        /// <summary> Gets or sets the provisioning state of the Dra. </summary>
        public DataReplicationProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the list of health errors. </summary>
        public IReadOnlyList<DataReplicationHealthErrorInfo> HealthErrors { get; }
        /// <summary>
        /// Dra model custom properties.
        /// Please note <see cref="DraModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeneralDraModelCustomProperties"/> and <see cref="VMwareDraModelCustomProperties"/>.
        /// </summary>
        public DraModelCustomProperties CustomProperties { get; set; }
    }
}
