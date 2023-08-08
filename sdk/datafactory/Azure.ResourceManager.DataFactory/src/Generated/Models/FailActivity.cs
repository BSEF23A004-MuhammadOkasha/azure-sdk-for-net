// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> This activity will fail within its own scope and output a custom error message and error code. The error message and code can provided either as a string literal or as an expression that can be evaluated to a string at runtime. The activity scope can be the whole pipeline or a control activity (e.g. foreach, switch, until), if the fail activity is contained in it. </summary>
    public partial class FailActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of FailActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="message"> The error message that surfaced in the Fail activity. It can be dynamic content that's evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        /// <param name="errorCode"> The error code that categorizes the error type of the Fail activity. It can be dynamic content that's evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="message"/> or <paramref name="errorCode"/> is null. </exception>
        public FailActivity(string name, DataFactoryElement<string> message, DataFactoryElement<string> errorCode) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(message, nameof(message));
            Argument.AssertNotNull(errorCode, nameof(errorCode));

            Message = message;
            ErrorCode = errorCode;
            ActivityType = "Fail";
        }

        /// <summary> Initializes a new instance of FailActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="message"> The error message that surfaced in the Fail activity. It can be dynamic content that's evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        /// <param name="errorCode"> The error code that categorizes the error type of the Fail activity. It can be dynamic content that's evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        internal FailActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> message, DataFactoryElement<string> errorCode) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            Message = message;
            ErrorCode = errorCode;
            ActivityType = activityType ?? "Fail";
        }

        /// <summary> The error message that surfaced in the Fail activity. It can be dynamic content that's evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Message { get; set; }
        /// <summary> The error code that categorizes the error type of the Fail activity. It can be dynamic content that's evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ErrorCode { get; set; }
    }
}
