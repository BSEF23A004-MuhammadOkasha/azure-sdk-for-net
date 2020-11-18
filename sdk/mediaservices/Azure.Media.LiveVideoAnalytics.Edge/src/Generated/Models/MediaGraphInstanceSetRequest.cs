// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> The MediaGraphInstanceSetRequest. </summary>
    public partial class MediaGraphInstanceSetRequest : OperationBase
    {
        /// <summary> Initializes a new instance of MediaGraphInstanceSetRequest. </summary>
        /// <param name="instance"> Represents a Media Graph instance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        public MediaGraphInstanceSetRequest(MediaGraphInstance instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            Instance = instance;
            MethodName = "GraphInstanceSet";
        }

        /// <summary> Initializes a new instance of MediaGraphInstanceSetRequest. </summary>
        /// <param name="methodName"> method name. </param>
        /// <param name="apiVersion"> api version. </param>
        /// <param name="instance"> Represents a Media Graph instance. </param>
        internal MediaGraphInstanceSetRequest(string methodName, string apiVersion, MediaGraphInstance instance) : base(methodName, apiVersion)
        {
            Instance = instance;
            MethodName = methodName ?? "GraphInstanceSet";
        }

        /// <summary> Represents a Media Graph instance. </summary>
        public MediaGraphInstance Instance { get; set; }
    }
}
