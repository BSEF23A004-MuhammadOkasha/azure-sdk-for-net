// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Parameters of a script block. </summary>
    public partial class ScriptActivityParameter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ScriptActivityParameter"/>. </summary>
        public ScriptActivityParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActivityParameter"/>. </summary>
        /// <param name="name"> The name of the parameter. Type: string (or Expression with resultType string). </param>
        /// <param name="parameterType"> The type of the parameter. </param>
        /// <param name="value"> The value of the parameter. Type: string (or Expression with resultType string). </param>
        /// <param name="direction"> The direction of the parameter. </param>
        /// <param name="size"> The size of the output direction parameter. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptActivityParameter(DataFactoryElement<string> name, ScriptActivityParameterType? parameterType, DataFactoryElement<string> value, ScriptActivityParameterDirection? direction, int? size, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ParameterType = parameterType;
            Value = value;
            Direction = direction;
            Size = size;
            _rawData = rawData;
        }

        /// <summary> The name of the parameter. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Name { get; set; }
        /// <summary> The type of the parameter. </summary>
        public ScriptActivityParameterType? ParameterType { get; set; }
        /// <summary> The value of the parameter. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Value { get; set; }
        /// <summary> The direction of the parameter. </summary>
        public ScriptActivityParameterDirection? Direction { get; set; }
        /// <summary> The size of the output direction parameter. </summary>
        public int? Size { get; set; }
    }
}
