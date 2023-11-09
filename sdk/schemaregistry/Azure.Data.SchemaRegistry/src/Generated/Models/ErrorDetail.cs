// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> Error response returned from Azure Schema Registry service. </summary>
    internal partial class ErrorDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ErrorDetail"/>. </summary>
        /// <param name="code"> Server-defined error code. </param>
        /// <param name="message"> Brief description of error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorDetail(string code, string message)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<ErrorDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDetail"/>. </summary>
        /// <param name="code"> Server-defined error code. </param>
        /// <param name="message"> Brief description of error. </param>
        /// <param name="details"> Error message details to help user understand/debug failure. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorDetail(string code, string message, IReadOnlyList<ErrorDetail> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDetail"/> for deserialization. </summary>
        internal ErrorDetail()
        {
        }

        /// <summary> Server-defined error code. </summary>
        public string Code { get; }
        /// <summary> Brief description of error. </summary>
        public string Message { get; }
        /// <summary> Error message details to help user understand/debug failure. </summary>
        public IReadOnlyList<ErrorDetail> Details { get; }
    }
}
