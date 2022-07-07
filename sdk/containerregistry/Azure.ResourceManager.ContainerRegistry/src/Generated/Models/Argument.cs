// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a run argument. </summary>
    public partial class Argument
    {
        /// <summary> Initializes a new instance of Argument. </summary>
        /// <param name="name"> The name of the argument. </param>
        /// <param name="value"> The value of the argument. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public Argument(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Name = name;
            Value = value;
        }

        /// <summary> Initializes a new instance of Argument. </summary>
        /// <param name="name"> The name of the argument. </param>
        /// <param name="value"> The value of the argument. </param>
        /// <param name="isSecret"> Flag to indicate whether the argument represents a secret and want to be removed from build logs. </param>
        internal Argument(string name, string value, bool? isSecret)
        {
            Name = name;
            Value = value;
            IsSecret = isSecret;
        }

        /// <summary> The name of the argument. </summary>
        public string Name { get; set; }
        /// <summary> The value of the argument. </summary>
        public string Value { get; set; }
        /// <summary> Flag to indicate whether the argument represents a secret and want to be removed from build logs. </summary>
        public bool? IsSecret { get; set; }
    }
}
