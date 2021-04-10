// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Files.Shares
{
    internal partial class ShareRestoreHeaders
    {
        private readonly Response _response;
        public ShareRestoreHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the share was last modified. Any operation that modifies the share or its properties updates the last modified time. Operations on files do not affect the last modified time of the share. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
