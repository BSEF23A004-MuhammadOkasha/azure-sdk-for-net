// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Input field mapping for a skill.
    /// </summary>
    public partial class InputFieldMappingEntry
    {
        /// <summary>
        /// Initializes a new instance of the InputFieldMappingEntry class.
        /// </summary>
        public InputFieldMappingEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InputFieldMappingEntry class.
        /// </summary>
        /// <param name="name">The name of the input.</param>
        /// <param name="source">The source of the input.</param>
        /// <param name="sourceContext">The source context used for selecting
        /// recursive inputs.</param>
        /// <param name="inputs">The recursive inputs used when creating a
        /// complex type.</param>
        public InputFieldMappingEntry(string name, string source = default(string), string sourceContext = default(string), IList<InputFieldMappingEntry> inputs = default(IList<InputFieldMappingEntry>))
        {
            Name = name;
            Source = source;
            SourceContext = sourceContext;
            Inputs = inputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the input.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the source of the input.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the source context used for selecting recursive
        /// inputs.
        /// </summary>
        [JsonProperty(PropertyName = "sourceContext")]
        public string SourceContext { get; set; }

        /// <summary>
        /// Gets or sets the recursive inputs used when creating a complex
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<InputFieldMappingEntry> Inputs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Inputs != null)
            {
                foreach (var element in Inputs)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
