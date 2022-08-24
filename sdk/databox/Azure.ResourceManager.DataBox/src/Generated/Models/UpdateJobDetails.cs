// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Job details for update. </summary>
    public partial class UpdateJobDetails
    {
        /// <summary> Initializes a new instance of UpdateJobDetails. </summary>
        public UpdateJobDetails()
        {
        }

        /// <summary> Contact details for notification and shipping. </summary>
        public ContactDetails ContactDetails { get; set; }
        /// <summary> Shipping address of the customer. </summary>
        public ShippingAddress ShippingAddress { get; set; }
        /// <summary> Key encryption key for the job. </summary>
        public KeyEncryptionKey KeyEncryptionKey { get; set; }
        /// <summary> Return package details of job. </summary>
        public PackageCarrierDetails ReturnToCustomerPackageDetails { get; set; }
    }
}
