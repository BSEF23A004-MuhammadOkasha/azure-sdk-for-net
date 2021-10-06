// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The result details of calling operation. </summary>
    public partial class CallingOperationResultDetails
    {
        /// <summary> Initializes a new instance of CallingOperationResultDetails. </summary>
        /// <param name="code"> The result code associated with the operation. </param>
        /// <param name="subcode"> The subcode that further classifies the result. </param>
        internal CallingOperationResultDetails(int code, int subcode)
        {
            Code = code;
            Subcode = subcode;
        }

        /// <summary> Initializes a new instance of CallingOperationResultDetails. </summary>
        /// <param name="code"> The result code associated with the operation. </param>
        /// <param name="subcode"> The subcode that further classifies the result. </param>
        /// <param name="message"> The message is a detail explanation of subcode. </param>
        internal CallingOperationResultDetails(int code, int subcode, string message)
        {
            Code = code;
            Subcode = subcode;
            Message = message;
        }

        /// <summary> The result code associated with the operation. </summary>
        public int Code { get; }
        /// <summary> The subcode that further classifies the result. </summary>
        public int Subcode { get; }
        /// <summary> The message is a detail explanation of subcode. </summary>
        public string Message { get; }
    }
}
