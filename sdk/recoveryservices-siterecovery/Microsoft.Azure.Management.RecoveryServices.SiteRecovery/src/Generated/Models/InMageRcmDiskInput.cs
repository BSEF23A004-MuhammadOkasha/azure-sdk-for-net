// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// InMageRcm disk input.
    /// </summary>
    public partial class InMageRcmDiskInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmDiskInput class.
        /// </summary>
        public InMageRcmDiskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmDiskInput class.
        /// </summary>
        /// <param name="diskId">The disk Id.</param>
        /// <param name="logStorageAccountId">The log storage account ARM
        /// Id.</param>
        /// <param name="diskType">The disk type. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS', 'StandardSSD_LRS'</param>
        /// <param name="diskEncryptionSetId">The DiskEncryptionSet ARM
        /// Id.</param>
        public InMageRcmDiskInput(string diskId, string logStorageAccountId, string diskType, string diskEncryptionSetId = default(string))
        {
            DiskId = diskId;
            LogStorageAccountId = logStorageAccountId;
            DiskType = diskType;
            DiskEncryptionSetId = diskEncryptionSetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk Id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets the log storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountId")]
        public string LogStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the disk type. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS', 'StandardSSD_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "diskType")]
        public string DiskType { get; set; }

        /// <summary>
        /// Gets or sets the DiskEncryptionSet ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionSetId")]
        public string DiskEncryptionSetId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskId");
            }
            if (LogStorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LogStorageAccountId");
            }
            if (DiskType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskType");
            }
        }
    }
}
