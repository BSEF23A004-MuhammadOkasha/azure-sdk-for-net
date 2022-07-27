// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A list of server configurations. </summary>
    public partial class MySqlFlexibleServerConfigurationListResult
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerConfigurationListResult. </summary>
        internal MySqlFlexibleServerConfigurationListResult()
        {
            Value = new ChangeTrackingList<MySqlFlexibleServerConfigurationData>();
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerConfigurationListResult. </summary>
        /// <param name="value"> The list of server configurations. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        internal MySqlFlexibleServerConfigurationListResult(IReadOnlyList<MySqlFlexibleServerConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of server configurations. </summary>
        public IReadOnlyList<MySqlFlexibleServerConfigurationData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
