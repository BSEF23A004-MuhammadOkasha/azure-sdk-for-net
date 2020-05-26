// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> An error response from the storage resource provider. </summary>
    public partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="code"> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the error, intended to be suitable for display in a user interface. </param>
        internal ErrorResponse(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; }
    }
}
