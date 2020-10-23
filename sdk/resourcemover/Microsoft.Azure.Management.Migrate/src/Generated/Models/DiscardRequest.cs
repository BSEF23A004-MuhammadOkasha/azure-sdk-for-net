// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the request body for discard operation.
    /// </summary>
    public partial class DiscardRequest
    {
        /// <summary>
        /// Initializes a new instance of the DiscardRequest class.
        /// </summary>
        public DiscardRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiscardRequest class.
        /// </summary>
        /// <param name="moveResources">Gets or sets the list of resource Id's,
        /// by default it accepts move resource id's unless the input type is
        /// switched via moveResourceInputType property.</param>
        /// <param name="validateOnly">Gets or sets a value indicating whether
        /// the operation needs to only run pre-requisite.</param>
        /// <param name="moveResourceInputType">Possible values include:
        /// 'MoveResourceId', 'MoveResourceSourceId'</param>
        public DiscardRequest(IList<string> moveResources, bool? validateOnly = default(bool?), string moveResourceInputType = default(string))
        {
            ValidateOnly = validateOnly;
            MoveResources = moveResources;
            MoveResourceInputType = moveResourceInputType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether the operation needs to only
        /// run pre-requisite.
        /// </summary>
        [JsonProperty(PropertyName = "validateOnly")]
        public bool? ValidateOnly { get; set; }

        /// <summary>
        /// Gets or sets the list of resource Id's, by default it accepts move
        /// resource id's unless the input type is switched via
        /// moveResourceInputType property.
        /// </summary>
        [JsonProperty(PropertyName = "moveResources")]
        public IList<string> MoveResources { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'MoveResourceId',
        /// 'MoveResourceSourceId'
        /// </summary>
        [JsonProperty(PropertyName = "moveResourceInputType")]
        public string MoveResourceInputType { get; set; }

    }
}
