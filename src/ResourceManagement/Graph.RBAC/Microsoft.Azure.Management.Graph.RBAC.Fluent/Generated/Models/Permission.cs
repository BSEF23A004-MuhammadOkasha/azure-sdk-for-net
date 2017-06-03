// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Role definition permissions.
    /// </summary>
    public partial class Permission
    {
        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        public Permission()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        /// <param name="actions">Allowed actions.</param>
        /// <param name="notActions">Denied actions.</param>
        public Permission(IList<string> actions = default(IList<string>), IList<string> notActions = default(IList<string>))
        {
            Actions = actions;
            NotActions = notActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowed actions.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<string> Actions { get; set; }

        /// <summary>
        /// Gets or sets denied actions.
        /// </summary>
        [JsonProperty(PropertyName = "notActions")]
        public IList<string> NotActions { get; set; }

    }
}
