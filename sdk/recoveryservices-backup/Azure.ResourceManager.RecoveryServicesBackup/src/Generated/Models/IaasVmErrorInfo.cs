// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure IaaS VM workload-specific error information. </summary>
    public partial class IaasVmErrorInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IaasVmErrorInfo"/>. </summary>
        public IaasVmErrorInfo()
        {
            Recommendations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IaasVmErrorInfo"/>. </summary>
        /// <param name="errorCode"> Error code. </param>
        /// <param name="errorTitle"> Title: Typically, the entity that the error pertains to. </param>
        /// <param name="errorString"> Localized error string. </param>
        /// <param name="recommendations"> List of localized recommendations for above error code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IaasVmErrorInfo(int? errorCode, string errorTitle, string errorString, IReadOnlyList<string> recommendations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorCode = errorCode;
            ErrorTitle = errorTitle;
            ErrorString = errorString;
            Recommendations = recommendations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Error code. </summary>
        public int? ErrorCode { get; }
        /// <summary> Title: Typically, the entity that the error pertains to. </summary>
        public string ErrorTitle { get; }
        /// <summary> Localized error string. </summary>
        public string ErrorString { get; }
        /// <summary> List of localized recommendations for above error code. </summary>
        public IReadOnlyList<string> Recommendations { get; }
    }
}
