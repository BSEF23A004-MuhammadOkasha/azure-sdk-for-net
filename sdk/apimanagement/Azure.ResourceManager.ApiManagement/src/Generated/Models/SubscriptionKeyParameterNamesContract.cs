// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Subscription key parameter names details. </summary>
    public partial class SubscriptionKeyParameterNamesContract
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionKeyParameterNamesContract"/>. </summary>
        public SubscriptionKeyParameterNamesContract()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionKeyParameterNamesContract"/>. </summary>
        /// <param name="header"> Subscription key header name. </param>
        /// <param name="query"> Subscription key query string parameter name. </param>
        internal SubscriptionKeyParameterNamesContract(string header, string query)
        {
            Header = header;
            Query = query;
        }

        /// <summary> Subscription key header name. </summary>
        public string Header { get; set; }
        /// <summary> Subscription key query string parameter name. </summary>
        public string Query { get; set; }
    }
}
