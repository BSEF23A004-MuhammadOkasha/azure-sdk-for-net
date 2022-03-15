// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the CodeContainerData data model. </summary>
    public partial class CodeContainerDataData : ResourceData
    {
        /// <summary> Initializes a new instance of CodeContainerDataData. </summary>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public CodeContainerDataData(CodeContainerDetails properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of CodeContainerDataData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        internal CodeContainerDataData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, CodeContainerDetails properties) : base(id, name, type, systemData)
        {
            Properties = properties;
        }

        /// <summary> Additional attributes of the entity. </summary>
        public CodeContainerDetails Properties { get; set; }
    }
}
