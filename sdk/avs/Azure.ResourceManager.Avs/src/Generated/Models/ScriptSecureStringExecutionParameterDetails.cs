// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> a plain text value execution parameter. </summary>
    public partial class ScriptSecureStringExecutionParameterDetails : ScriptExecutionParameterDetails
    {
        /// <summary> Initializes a new instance of <see cref="ScriptSecureStringExecutionParameterDetails"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ScriptSecureStringExecutionParameterDetails(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            ParameterType = ScriptExecutionParameterType.SecureValue;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptSecureStringExecutionParameterDetails"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <param name="parameterType"> The type of execution parameter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="secureValue"> A secure value for the passed parameter, not to be stored in logs. </param>
        internal ScriptSecureStringExecutionParameterDetails(string name, ScriptExecutionParameterType parameterType, IDictionary<string, BinaryData> serializedAdditionalRawData, string secureValue) : base(name, parameterType, serializedAdditionalRawData)
        {
            SecureValue = secureValue;
            ParameterType = parameterType;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptSecureStringExecutionParameterDetails"/> for deserialization. </summary>
        internal ScriptSecureStringExecutionParameterDetails()
        {
        }

        /// <summary> A secure value for the passed parameter, not to be stored in logs. </summary>
        public string SecureValue { get; set; }
    }
}
