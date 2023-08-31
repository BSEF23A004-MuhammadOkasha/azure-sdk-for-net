// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Dynatrace account API Key. </summary>
    public partial class DynatraceAccountCredentialsInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceAccountCredentialsInfo"/>. </summary>
        internal DynatraceAccountCredentialsInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceAccountCredentialsInfo"/>. </summary>
        /// <param name="accountId"> Account Id of the account this environment is linked to. </param>
        /// <param name="apiKey"> API Key of the user account. </param>
        /// <param name="regionId"> Region in which the account is created. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceAccountCredentialsInfo(string accountId, string apiKey, string regionId, Dictionary<string, BinaryData> rawData)
        {
            AccountId = accountId;
            ApiKey = apiKey;
            RegionId = regionId;
            _rawData = rawData;
        }

        /// <summary> Account Id of the account this environment is linked to. </summary>
        public string AccountId { get; }
        /// <summary> API Key of the user account. </summary>
        public string ApiKey { get; }
        /// <summary> Region in which the account is created. </summary>
        public string RegionId { get; }
    }
}
