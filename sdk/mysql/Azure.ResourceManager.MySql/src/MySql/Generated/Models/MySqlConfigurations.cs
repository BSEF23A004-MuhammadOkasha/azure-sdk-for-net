// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of server configurations. </summary>
    public partial class MySqlConfigurations
    {
        /// <summary> Initializes a new instance of <see cref="MySqlConfigurations"/>. </summary>
        public MySqlConfigurations()
        {
            Values = new ChangeTrackingList<MySqlConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlConfigurations"/>. </summary>
        /// <param name="values"> The list of server configurations. </param>
        internal MySqlConfigurations(IList<MySqlConfigurationData> values)
        {
            Values = values;
        }

        /// <summary> The list of server configurations. </summary>
        public IList<MySqlConfigurationData> Values { get; }
    }
}
