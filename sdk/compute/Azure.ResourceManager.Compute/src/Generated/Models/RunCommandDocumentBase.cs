// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a Run Command metadata. </summary>
    public partial class RunCommandDocumentBase : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of RunCommandDocumentBase. </summary>
        /// <param name="schema"> The VM run command schema. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="label"> The VM run command label. </param>
        /// <param name="description"> The VM run command description. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schema"/>, <paramref name="label"/>, or <paramref name="description"/> is null. </exception>
        internal RunCommandDocumentBase(string schema, OperatingSystemTypes osType, string label, string description)
        {
            if (schema == null)
            {
                throw new ArgumentNullException(nameof(schema));
            }
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            Schema = schema;
            OsType = osType;
            Label = label;
            Description = description;
        }

        /// <summary> Initializes a new instance of RunCommandDocumentBase. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="schema"> The VM run command schema. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="label"> The VM run command label. </param>
        /// <param name="description"> The VM run command description. </param>
        internal RunCommandDocumentBase(string id, string schema, OperatingSystemTypes osType, string label, string description) : base(id)
        {
            Schema = schema;
            OsType = osType;
            Label = label;
            Description = description;
        }

        /// <summary> The VM run command schema. </summary>
        public string Schema { get; }
        /// <summary> The Operating System type. </summary>
        public OperatingSystemTypes OsType { get; }
        /// <summary> The VM run command label. </summary>
        public string Label { get; }
        /// <summary> The VM run command description. </summary>
        public string Description { get; }
    }
}
