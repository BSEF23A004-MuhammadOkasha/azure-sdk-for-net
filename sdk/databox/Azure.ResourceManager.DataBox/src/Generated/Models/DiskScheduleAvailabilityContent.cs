// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the availability for scheduling disk orders. </summary>
    public partial class DiskScheduleAvailabilityContent : ScheduleAvailabilityContent
    {
        /// <summary> Initializes a new instance of DiskScheduleAvailabilityContent. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="expectedDataSizeInTeraBytes"> The expected size of the data, which needs to be transferred in this job, in terabytes. </param>
        public DiskScheduleAvailabilityContent(AzureLocation storageLocation, int expectedDataSizeInTeraBytes) : base(storageLocation)
        {
            ExpectedDataSizeInTeraBytes = expectedDataSizeInTeraBytes;
            SkuName = DataBoxSkuName.DataBoxDisk;
        }

        /// <summary> The expected size of the data, which needs to be transferred in this job, in terabytes. </summary>
        public int ExpectedDataSizeInTeraBytes { get; }
    }
}
