// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Copy Log Details for customer disk. </summary>
    public partial class DataBoxCustomerDiskCopyLogDetails : CopyLogDetails
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxCustomerDiskCopyLogDetails"/>. </summary>
        internal DataBoxCustomerDiskCopyLogDetails()
        {
            CopyLogDetailsType = DataBoxOrderType.DataBoxCustomerDisk;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxCustomerDiskCopyLogDetails"/>. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="serialNumber"> Disk Serial Number. </param>
        /// <param name="errorLogLink"> Link for copy error logs. </param>
        /// <param name="verboseLogLink"> Link for copy verbose logs. </param>
        internal DataBoxCustomerDiskCopyLogDetails(DataBoxOrderType copyLogDetailsType, IDictionary<string, BinaryData> serializedAdditionalRawData, string serialNumber, string errorLogLink, string verboseLogLink) : base(copyLogDetailsType, serializedAdditionalRawData)
        {
            SerialNumber = serialNumber;
            ErrorLogLink = errorLogLink;
            VerboseLogLink = verboseLogLink;
            CopyLogDetailsType = copyLogDetailsType;
        }

        /// <summary> Disk Serial Number. </summary>
        public string SerialNumber { get; }
        /// <summary> Link for copy error logs. </summary>
        public string ErrorLogLink { get; }
        /// <summary> Link for copy verbose logs. </summary>
        public string VerboseLogLink { get; }
    }
}
