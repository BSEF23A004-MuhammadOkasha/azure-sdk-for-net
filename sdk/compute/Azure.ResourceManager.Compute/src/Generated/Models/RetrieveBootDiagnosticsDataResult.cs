// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The SAS URIs of the console screenshot and serial log blobs. </summary>
    public partial class RetrieveBootDiagnosticsDataResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RetrieveBootDiagnosticsDataResult"/>. </summary>
        internal RetrieveBootDiagnosticsDataResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RetrieveBootDiagnosticsDataResult"/>. </summary>
        /// <param name="consoleScreenshotBlobUri"> The console screenshot blob URI. </param>
        /// <param name="serialConsoleLogBlobUri"> The serial console log blob URI. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RetrieveBootDiagnosticsDataResult(Uri consoleScreenshotBlobUri, Uri serialConsoleLogBlobUri, Dictionary<string, BinaryData> rawData)
        {
            ConsoleScreenshotBlobUri = consoleScreenshotBlobUri;
            SerialConsoleLogBlobUri = serialConsoleLogBlobUri;
            _rawData = rawData;
        }

        /// <summary> The console screenshot blob URI. </summary>
        public Uri ConsoleScreenshotBlobUri { get; }
        /// <summary> The serial console log blob URI. </summary>
        public Uri SerialConsoleLogBlobUri { get; }
    }
}
