// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Maintenance Operation Status. </summary>
    public partial class MaintenanceRedeployStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MaintenanceRedeployStatus"/>. </summary>
        internal MaintenanceRedeployStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceRedeployStatus"/>. </summary>
        /// <param name="isCustomerInitiatedMaintenanceAllowed"> True, if customer is allowed to perform Maintenance. </param>
        /// <param name="preMaintenanceWindowStartOn"> Start Time for the Pre Maintenance Window. </param>
        /// <param name="preMaintenanceWindowEndOn"> End Time for the Pre Maintenance Window. </param>
        /// <param name="maintenanceWindowStartOn"> Start Time for the Maintenance Window. </param>
        /// <param name="maintenanceWindowEndOn"> End Time for the Maintenance Window. </param>
        /// <param name="lastOperationResultCode"> The Last Maintenance Operation Result Code. </param>
        /// <param name="lastOperationMessage"> Message returned for the last Maintenance Operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceRedeployStatus(bool? isCustomerInitiatedMaintenanceAllowed, DateTimeOffset? preMaintenanceWindowStartOn, DateTimeOffset? preMaintenanceWindowEndOn, DateTimeOffset? maintenanceWindowStartOn, DateTimeOffset? maintenanceWindowEndOn, MaintenanceOperationResultCodeType? lastOperationResultCode, string lastOperationMessage, Dictionary<string, BinaryData> rawData)
        {
            IsCustomerInitiatedMaintenanceAllowed = isCustomerInitiatedMaintenanceAllowed;
            PreMaintenanceWindowStartOn = preMaintenanceWindowStartOn;
            PreMaintenanceWindowEndOn = preMaintenanceWindowEndOn;
            MaintenanceWindowStartOn = maintenanceWindowStartOn;
            MaintenanceWindowEndOn = maintenanceWindowEndOn;
            LastOperationResultCode = lastOperationResultCode;
            LastOperationMessage = lastOperationMessage;
            _rawData = rawData;
        }

        /// <summary> True, if customer is allowed to perform Maintenance. </summary>
        public bool? IsCustomerInitiatedMaintenanceAllowed { get; }
        /// <summary> Start Time for the Pre Maintenance Window. </summary>
        public DateTimeOffset? PreMaintenanceWindowStartOn { get; }
        /// <summary> End Time for the Pre Maintenance Window. </summary>
        public DateTimeOffset? PreMaintenanceWindowEndOn { get; }
        /// <summary> Start Time for the Maintenance Window. </summary>
        public DateTimeOffset? MaintenanceWindowStartOn { get; }
        /// <summary> End Time for the Maintenance Window. </summary>
        public DateTimeOffset? MaintenanceWindowEndOn { get; }
        /// <summary> The Last Maintenance Operation Result Code. </summary>
        public MaintenanceOperationResultCodeType? LastOperationResultCode { get; }
        /// <summary> Message returned for the last Maintenance Operation. </summary>
        public string LastOperationMessage { get; }
    }
}
