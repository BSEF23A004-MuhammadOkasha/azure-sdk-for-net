// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHub.Models
{
    /// <summary> Error response indicates Event Hub service is not able to process the incoming request. The reason is provided in the error message. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message indicating why the operation failed. </param>
        internal ErrorResponse(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message indicating why the operation failed. </summary>
        public string Message { get; }
    }
}
