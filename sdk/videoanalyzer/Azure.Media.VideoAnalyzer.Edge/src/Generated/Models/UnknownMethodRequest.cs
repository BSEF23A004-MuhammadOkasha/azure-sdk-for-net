// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Unknown version of MethodRequest. </summary>
    internal partial class UnknownMethodRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of UnknownMethodRequest. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        internal UnknownMethodRequest(string methodName, string apiVersion) : base(methodName, apiVersion)
        {
            MethodName = methodName ?? "Unknown";
        }
    }
}
