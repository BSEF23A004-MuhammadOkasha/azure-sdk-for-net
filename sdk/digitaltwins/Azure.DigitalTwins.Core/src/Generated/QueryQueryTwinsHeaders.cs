// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    internal partial class QueryQueryTwinsHeaders
    {
        private readonly Response _response;
        public QueryQueryTwinsHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The query charge. </summary>
        public float? QueryCharge => _response.Headers.TryGetValue("query-charge", out float? value) ? value : null;
    }
}
