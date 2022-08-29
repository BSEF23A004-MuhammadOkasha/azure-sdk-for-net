// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The UnknownCopyLogDetails. </summary>
    internal partial class UnknownCopyLogDetails : CopyLogDetails
    {
        /// <summary> Initializes a new instance of UnknownCopyLogDetails. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        internal UnknownCopyLogDetails(DataBoxOrderType copyLogDetailsType) : base(copyLogDetailsType)
        {
            CopyLogDetailsType = copyLogDetailsType;
        }
    }
}
