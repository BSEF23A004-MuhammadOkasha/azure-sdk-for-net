// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{

    /// <summary>
    /// Defines values for StageName.
    /// </summary>
    public static class StageName
    {
        /// <summary>
        /// An order has been created.
        /// </summary>
        public const string DeviceOrdered = "DeviceOrdered";
        /// <summary>
        /// A device has been prepared for the order.
        /// </summary>
        public const string DevicePrepared = "DevicePrepared";
        /// <summary>
        /// Device has been dispatched to the user of the order.
        /// </summary>
        public const string Dispatched = "Dispatched";
        /// <summary>
        /// Device has been delivered to the user of the order.
        /// </summary>
        public const string Delivered = "Delivered";
        /// <summary>
        /// Device has been picked up from user and in transit to Azure
        /// datacenter.
        /// </summary>
        public const string PickedUp = "PickedUp";
        /// <summary>
        /// Device has been received at Azure datacenter from the user.
        /// </summary>
        public const string AtAzureDC = "AtAzureDC";
        /// <summary>
        /// Data copy from the device at Azure datacenter.
        /// </summary>
        public const string DataCopy = "DataCopy";
        /// <summary>
        /// Order has completed.
        /// </summary>
        public const string Completed = "Completed";
        /// <summary>
        /// Order has completed with errors.
        /// </summary>
        public const string CompletedWithErrors = "CompletedWithErrors";
        /// <summary>
        /// Order has been cancelled.
        /// </summary>
        public const string Cancelled = "Cancelled";
        /// <summary>
        /// Order has failed due to issue reported by user.
        /// </summary>
        public const string FailedIssueReportedAtCustomer = "Failed_IssueReportedAtCustomer";
        /// <summary>
        /// Order has failed due to issue detected at Azure datacenter.
        /// </summary>
        public const string FailedIssueDetectedAtAzureDC = "Failed_IssueDetectedAtAzureDC";
        /// <summary>
        /// Order has been aborted.
        /// </summary>
        public const string Aborted = "Aborted";
        /// <summary>
        /// Order has completed with warnings.
        /// </summary>
        public const string CompletedWithWarnings = "CompletedWithWarnings";
        /// <summary>
        /// Device is ready to be handed to customer from Azure DC.
        /// </summary>
        public const string ReadyToDispatchFromAzureDC = "ReadyToDispatchFromAzureDC";
        /// <summary>
        /// Device can be dropped off at Azure DC.
        /// </summary>
        public const string ReadyToReceiveAtAzureDC = "ReadyToReceiveAtAzureDC";
        /// <summary>
        /// Job created by the customer.
        /// </summary>
        public const string Created = "Created";
        /// <summary>
        /// User shipped the device to AzureDC.
        /// </summary>
        public const string ShippedToAzureDC = "ShippedToAzureDC";
        /// <summary>
        /// Awaiting shipment details of device from customer.
        /// </summary>
        public const string AwaitingShipmentDetails = "AwaitingShipmentDetails";
        /// <summary>
        /// Preparing the device to ship to customer.
        /// </summary>
        public const string PreparingToShipFromAzureDC = "PreparingToShipFromAzureDC";
        /// <summary>
        /// Shipped the device to customer.
        /// </summary>
        public const string ShippedToCustomer = "ShippedToCustomer";
    }
}
