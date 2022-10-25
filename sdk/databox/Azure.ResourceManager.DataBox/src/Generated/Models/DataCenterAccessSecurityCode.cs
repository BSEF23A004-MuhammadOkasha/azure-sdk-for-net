// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Dc access security code. </summary>
    public partial class DataCenterAccessSecurityCode
    {
        /// <summary> Initializes a new instance of DataCenterAccessSecurityCode. </summary>
        internal DataCenterAccessSecurityCode()
        {
        }

        /// <summary> Initializes a new instance of DataCenterAccessSecurityCode. </summary>
        /// <param name="reverseDataCenterAccessCode"> Reverse Dc access security code. </param>
        /// <param name="forwardDataCenterAccessCode"> Forward Dc access security code. </param>
        internal DataCenterAccessSecurityCode(string reverseDataCenterAccessCode, string forwardDataCenterAccessCode)
        {
            ReverseDataCenterAccessCode = reverseDataCenterAccessCode;
            ForwardDataCenterAccessCode = forwardDataCenterAccessCode;
        }

        /// <summary> Reverse Dc access security code. </summary>
        public string ReverseDataCenterAccessCode { get; }
        /// <summary> Forward Dc access security code. </summary>
        public string ForwardDataCenterAccessCode { get; }
    }
}
