// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Data.Tables
{
    internal class TableInternalUpdateEntityHeaders
    {
        private readonly Response _response;
        public TableInternalUpdateEntityHeaders(Response response)
        {
            _response = response;
        }
        public string XMsVersion => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
