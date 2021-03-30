// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    internal partial class PhoneNumbersPurchasePhoneNumbersHeaders
    {
        private readonly Response _response;
        public PhoneNumbersPurchasePhoneNumbersHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL to query for status of the operation. </summary>
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
        /// <summary> The operation id. </summary>
        public string OperationId => _response.Headers.TryGetValue("operation-id", out string value) ? value : null;
        /// <summary> The purchase operation id. </summary>
        public string PurchaseId => _response.Headers.TryGetValue("purchase-id", out string value) ? value : null;
    }
}
