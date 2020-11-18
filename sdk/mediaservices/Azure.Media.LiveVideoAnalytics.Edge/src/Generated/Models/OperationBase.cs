// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> The OperationBase. </summary>
    public partial class OperationBase
    {
        /// <summary> Initializes a new instance of OperationBase. </summary>
        public OperationBase()
        {
            ApiVersion = "1.0";
        }

        /// <summary> Initializes a new instance of OperationBase. </summary>
        /// <param name="methodName"> method name. </param>
        /// <param name="apiVersion"> api version. </param>
        internal OperationBase(string methodName, string apiVersion)
        {
            MethodName = methodName;
            ApiVersion = apiVersion;
        }
        /// <summary> api version. </summary>
        public string ApiVersion { get; set; }
    }
}
