// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Analysis;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An array of administrator user identities
    /// </summary>
    public partial class ServerAdministrators
    {
        /// <summary>
        /// Initializes a new instance of the ServerAdministrators class.
        /// </summary>
        public ServerAdministrators()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerAdministrators class.
        /// </summary>
        /// <param name="members">An array of administrator user
        /// identities.</param>
        public ServerAdministrators(IList<string> members = default(IList<string>))
        {
            Members = members;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of administrator user identities.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<string> Members { get; set; }

    }
}
