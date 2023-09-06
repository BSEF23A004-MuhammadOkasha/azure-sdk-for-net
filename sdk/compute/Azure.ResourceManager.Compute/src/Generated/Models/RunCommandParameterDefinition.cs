// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a run command parameter. </summary>
    public partial class RunCommandParameterDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RunCommandParameterDefinition"/>. </summary>
        /// <param name="name"> The run command parameter name. </param>
        /// <param name="runCommandParameterDefinitionType"> The run command parameter type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="runCommandParameterDefinitionType"/> is null. </exception>
        internal RunCommandParameterDefinition(string name, string runCommandParameterDefinitionType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(runCommandParameterDefinitionType, nameof(runCommandParameterDefinitionType));

            Name = name;
            RunCommandParameterDefinitionType = runCommandParameterDefinitionType;
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandParameterDefinition"/>. </summary>
        /// <param name="name"> The run command parameter name. </param>
        /// <param name="runCommandParameterDefinitionType"> The run command parameter type. </param>
        /// <param name="defaultValue"> The run command parameter default value. </param>
        /// <param name="required"> The run command parameter required. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RunCommandParameterDefinition(string name, string runCommandParameterDefinitionType, string defaultValue, bool? required, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            RunCommandParameterDefinitionType = runCommandParameterDefinitionType;
            DefaultValue = defaultValue;
            Required = required;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandParameterDefinition"/> for deserialization. </summary>
        internal RunCommandParameterDefinition()
        {
        }

        /// <summary> The run command parameter name. </summary>
        public string Name { get; }
        /// <summary> The run command parameter type. </summary>
        public string RunCommandParameterDefinitionType { get; }
        /// <summary> The run command parameter default value. </summary>
        public string DefaultValue { get; }
        /// <summary> The run command parameter required. </summary>
        public bool? Required { get; }
    }
}
